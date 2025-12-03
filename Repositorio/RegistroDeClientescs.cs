using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Barber_Royal
{
    public partial class RegistroDeClientescs : Form
    {

        private string tipoUsuario;

        public RegistroDeClientescs(string tipoUsuario)
        {
            InitializeComponent();
            this.tipoUsuario = tipoUsuario;
            CargarClientes();
        }

        private void AplicarRestricciones()
        {
            string rol = tipoUsuario?.Trim().ToLower();

            if (rol == "usuario")
            {
                btnRegistrar.Enabled = true;
                btnEditar.Enabled = false;
                btnEliminar.Enabled = false;
            }
            else if (rol == "administrador")
            {
                btnRegistrar.Enabled = true;
                btnEditar.Enabled = true;
                btnEliminar.Enabled = true;
            }
        }


        private void CargarClientes()
        {
            ConexionDB db = new ConexionDB();
            MySqlConnection? con = db.GetConnection();

            if (con != null)
            {
                try
                {
                    string query = "SELECT * FROM clientes";
                    MySqlCommand cmd = new MySqlCommand(query, con);
                    MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    dgvClientes.DataSource = dt;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al cargar datos: " + ex.Message);
                }
                finally
                {
                    con.Close();
                }
            }
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {

            if (txtNombreC.Text == "" || txtApellidoC.Text == "" || dtpNacimientoC.Value == null)
            {
                MessageBox.Show("Por favor complete los campos obligatorios.");
                return;
            }


            ConexionDB db = new ConexionDB();
            MySqlConnection? conexion = db.GetConnection();

            if (conexion is not null)
            {
                try
                {
                    string sql = "INSERT INTO clientes (nombre, apellido, nacimiento, telefono, email) " +
                                 "VALUES (@nombre, @apellido, @nacimiento, @telefono, @email)";

                    using (MySqlCommand cmd = new MySqlCommand(sql, conexion))
                    {
                        cmd.Parameters.AddWithValue("@nombre", txtNombreC.Text.ToUpper());
                        cmd.Parameters.AddWithValue("@apellido", txtApellidoC.Text.ToUpper());
                        cmd.Parameters.AddWithValue("@nacimiento", dtpNacimientoC.Value.Date);
                        cmd.Parameters.AddWithValue("@telefono", txtTelefonoC.Text.ToUpper());
                        cmd.Parameters.AddWithValue("@email", txtEmailC.Text.ToUpper());

                        cmd.ExecuteNonQuery();
                    }

                    MessageBox.Show("Cliente registrado correctamente.");
                    LimpiarCampos();
                    CargarClientes();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al registrar cliente: " + ex.Message);
                }
                finally
                {
                    conexion.Close();
                }
            }
        }


        private void LimpiarCampos()
        {
            txtNombreC.Clear();
            txtApellidoC.Clear();
            txtTelefonoC.Clear();
            txtEmailC.Clear();
            dtpNacimientoC.Value = DateTime.Now;
        }

        private void txtNombreC_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtTelefonoC_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtApellidoC_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtEmailC_TextChanged(object sender, EventArgs e)
        {

        }



        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dgvClientes.CurrentRow == null)
            {
                MessageBox.Show("Seleccione un cliente para eliminar.");
                return;
            }


            int clienteId = Convert.ToInt32(dgvClientes.CurrentRow.Cells["cliente_id"].Value);


            DialogResult result = MessageBox.Show("¿Está seguro de eliminar este cliente?",
                                                  "Confirmar eliminación",
                                                  MessageBoxButtons.YesNo,
                                                  MessageBoxIcon.Warning);

            if (result == DialogResult.Yes)
            {
                ConexionDB db = new ConexionDB();
                using (MySqlConnection con = db.GetConnection())
                {
                    if (con != null)
                    {
                        try
                        {
                            string sql = "DELETE FROM clientes WHERE cliente_id = @id";
                            using (MySqlCommand cmd = new MySqlCommand(sql, con))
                            {
                                cmd.Parameters.AddWithValue("@id", clienteId);
                                cmd.ExecuteNonQuery();
                            }

                            MessageBox.Show("Cliente eliminado correctamente.");
                            CargarClientes();
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Error al eliminar cliente: " + ex.Message);
                        }
                    }
                }
            }
        }


        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (dgvClientes.CurrentRow == null)
            {
                MessageBox.Show("Seleccione un cliente para editar.");
                return;
            }

            int clienteId = Convert.ToInt32(dgvClientes.CurrentRow.Cells["cliente_id"].Value);

            ConexionDB db = new ConexionDB();
            using (MySqlConnection con = db.GetConnection())
            {
                if (con != null)
                {
                    try
                    {
                        string sql = "UPDATE clientes SET nombre = @nombre, apellido = @apellido, " +
                                     "nacimiento = @nacimiento, telefono = @telefono, email = @email " +
                                     "WHERE cliente_id = @id";

                        using (MySqlCommand cmd = new MySqlCommand(sql, con))
                        {
                            cmd.Parameters.AddWithValue("@nombre", txtNombreC.Text.ToUpper());
                            cmd.Parameters.AddWithValue("@apellido", txtApellidoC.Text.ToUpper());
                            cmd.Parameters.AddWithValue("@nacimiento", dtpNacimientoC.Value.Date);
                            cmd.Parameters.AddWithValue("@telefono", txtTelefonoC.Text.ToUpper());
                            cmd.Parameters.AddWithValue("@email", txtEmailC.Text.ToUpper());
                            cmd.Parameters.AddWithValue("@id", clienteId);

                            cmd.ExecuteNonQuery();
                        }

                        MessageBox.Show("Cliente editado correctamente.");
                        LimpiarCampos();
                        CargarClientes();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error al editar cliente: " + ex.Message);
                    }
                }
            }
        }

        private void dtpNacimientoC_ValueChanged(object sender, EventArgs e)
        {

        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtNombreC.Clear();
            txtApellidoC.Clear();
            txtTelefonoC.Clear();
            txtEmailC.Clear();
            dtpNacimientoC.Value = DateTime.Now;
        }

        private void RegistroDeClientescs_Load(object sender, EventArgs e)
        {
            AplicarRestricciones();
        }

        private void dgvClientes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // TODO: Add your logic here for handling cell content clicks
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            string valorBuscado = txtBuscadorCLT.Text.Trim();

            try
            {
                ConexionDB cn = new ConexionDB();
                using (MySqlConnection conexion = cn.GetConnection())
                {
                    if (conexion != null)
                    {
                        string query = "SELECT cliente_id, nombre, apellido, nacimiento, telefono, email FROM clientes";

                        if (!string.IsNullOrEmpty(valorBuscado))
                        {
                            query += " WHERE nombre LIKE @valor OR apellido LIKE @valor";

                            if (DateTime.TryParse(valorBuscado, out DateTime fechaNacimiento))
                            {
                                query += " OR nacimiento = @fecha";
                            }
                        }

                        MySqlCommand cmd = new MySqlCommand(query, conexion);

                        if (!string.IsNullOrEmpty(valorBuscado))
                        {
                            cmd.Parameters.AddWithValue("@valor", "%" + valorBuscado + "%");

                            if (DateTime.TryParse(valorBuscado, out DateTime fechaNacimiento))
                            {
                                cmd.Parameters.AddWithValue("@fecha", fechaNacimiento.Date);
                            }
                        }

                        MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                        DataTable dt = new DataTable();
                        da.Fill(dt);

                        dgvClientes.DataSource = dt;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al buscar cliente: " + ex.Message);
            }
        }

        private void btnRefrescar_Click(object sender, EventArgs e)
        {
            try
            {
                txtNombreC.Clear();
                txtApellidoC.Clear();
                txtTelefonoC.Clear();
                txtEmailC.Clear();
                dtpNacimientoC.Value = DateTime.Now;

                txtBuscadorCLT.Text = "";

                CargarClientes();

                dgvClientes.ClearSelection();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al refrescar el formulario: " + ex.Message);
            }
        }
    }
}