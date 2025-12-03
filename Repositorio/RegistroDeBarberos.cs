using Microsoft.VisualBasic.Logging;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace Barber_Royal
{
    public partial class RegistroDeBarberos : Form
    {
        public string tipoUsuario { get; set; }
        public RegistroDeBarberos(string rolUsuario)
        {
            InitializeComponent();
            tipoUsuario = rolUsuario;
            CargarBarberos();
            AplicarRestricciones();
        }

        private void AplicarRestricciones()
        {
            string rol = tipoUsuario?.Trim().ToLower();

            if (rol == "usuario")
            {
                btnEliminar.Enabled = false;
                btnEditar.Enabled = false;
            }
            else if (rol == "administrador")
            {
                btnEliminar.Enabled = true;
                btnEditar.Enabled = true;
            }
        }


        private void CargarBarberos()
        {
            try
            {
                ConexionDB cn = new ConexionDB();
                using (MySqlConnection conexion = cn.GetConnection())
                {
                    if (conexion != null)
                    {
                        string query = "SELECT * FROM barberos";
                        MySqlDataAdapter adapter = new MySqlDataAdapter(query, conexion);
                        DataTable dt = new DataTable();
                        adapter.Fill(dt);
                        dgvBarberos.DataSource = dt;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar barberos: " + ex.Message);
            }
        }


        private void txtNombreB_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtApellidoB_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtTelefonoB_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtEmailB_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            // 🔹 Validación de rol
            if (tipoUsuario?.Trim().ToLower() == "usuario")
            {
                MessageBox.Show("No tienes permiso para eliminar barberos.", "Acceso denegado", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // 🔹 Validación de selección
            if (dgvBarberos.SelectedRows.Count == 0)
            {
                MessageBox.Show("Selecciona un barbero para eliminar.");
                return;
            }

            int idBarbero = Convert.ToInt32(dgvBarberos.SelectedRows[0].Cells["barbero_id"].Value);

            DialogResult resultado = MessageBox.Show("¿Deseas eliminar este barbero?", "Confirmar eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (resultado == DialogResult.Yes)
            {
                try
                {
                    ConexionDB cn = new ConexionDB();
                    using (MySqlConnection conexion = cn.GetConnection())
                    {
                        if (conexion != null)
                        {
                            string query = "DELETE FROM barberos WHERE barbero_id=@id";
                            MySqlCommand cmd = new MySqlCommand(query, conexion);
                            cmd.Parameters.AddWithValue("@id", idBarbero);

                            int filasAfectadas = cmd.ExecuteNonQuery();

                            if (filasAfectadas > 0)
                            {
                                MessageBox.Show("Barbero eliminado correctamente.");
                                dgvBarberos.Rows.RemoveAt(dgvBarberos.SelectedRows[0].Index);
                            }
                            else
                            {
                                MessageBox.Show("No se pudo eliminar el barbero.");
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al eliminar: " + ex.Message);
                }
            }
        }



        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (tipoUsuario?.Trim().ToLower() == "usuario")
            {
                MessageBox.Show("No tienes permiso para editar barberos.", "Acceso denegado", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (dgvBarberos.SelectedRows.Count == 0)
            {
                MessageBox.Show("Selecciona un barbero para editar.");
                return;
            }

            int idBarbero = Convert.ToInt32(dgvBarberos.SelectedRows[0].Cells["barbero_id"].Value);

            if (string.IsNullOrWhiteSpace(txtNombreB.Text) ||
                string.IsNullOrWhiteSpace(txtApellidoB.Text) ||
                string.IsNullOrWhiteSpace(txtTelefonoB.Text) ||
                string.IsNullOrWhiteSpace(txtEmailB.Text))
            {
                MessageBox.Show("Por favor completa todos los campos.");
                return;
            }

            try
            {
                ConexionDB cn = new ConexionDB();
                using (MySqlConnection conexion = cn.GetConnection())
                {
                    if (conexion != null)
                    {
                        string query = "UPDATE barberos SET nombre=@nombre, apellido=@apellido, telefono=@telefono, email=@correo WHERE barbero_id=@id";
                        MySqlCommand cmd = new MySqlCommand(query, conexion);

                        cmd.Parameters.AddWithValue("@nombre", ToUpperSafe(txtNombreB.Text));
                        cmd.Parameters.AddWithValue("@apellido", ToUpperSafe(txtApellidoB.Text));
                        cmd.Parameters.AddWithValue("@telefono", ToUpperSafe(txtTelefonoB.Text));
                        cmd.Parameters.AddWithValue("@correo", ToUpperSafe(txtEmailB.Text));
                        cmd.Parameters.AddWithValue("@id", idBarbero);

                        int filasAfectadas = cmd.ExecuteNonQuery();

                        if (filasAfectadas > 0)
                        {
                            MessageBox.Show("Barbero actualizado correctamente.");

                            dgvBarberos.SelectedRows[0].Cells["nombre"].Value = ToUpperSafe(txtNombreB.Text);
                            dgvBarberos.SelectedRows[0].Cells["apellido"].Value = ToUpperSafe(txtApellidoB.Text);
                            dgvBarberos.SelectedRows[0].Cells["telefono"].Value = ToUpperSafe(txtTelefonoB.Text);
                            dgvBarberos.SelectedRows[0].Cells["email"].Value = ToUpperSafe(txtEmailB.Text);
                        }
                        else
                        {
                            MessageBox.Show("No se pudo actualizar el barbero.");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al actualizar: " + ex.Message);
            }
        }



        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNombreB.Text) ||
                string.IsNullOrWhiteSpace(txtApellidoB.Text) ||
                string.IsNullOrWhiteSpace(txtTelefonoB.Text) ||
                string.IsNullOrWhiteSpace(txtEmailB.Text))
            {
                MessageBox.Show("Por favor completa todos los campos.");
                return;
            }

            try
            {
                ConexionDB cn = new ConexionDB();
                using (MySqlConnection conexion = cn.GetConnection())
                {
                    if (conexion != null)
                    {
                        string query = "INSERT INTO barberos (nombre, apellido, telefono, email) VALUES (@nombre, @apellido, @telefono, @correo)";
                        MySqlCommand cmd = new MySqlCommand(query, conexion);

                        cmd.Parameters.AddWithValue("@nombre", ToUpperSafe(txtNombreB.Text));
                        cmd.Parameters.AddWithValue("@apellido", ToUpperSafe(txtApellidoB.Text));
                        cmd.Parameters.AddWithValue("@telefono", ToUpperSafe(txtTelefonoB.Text));
                        cmd.Parameters.AddWithValue("@correo", ToUpperSafe(txtEmailB.Text));

                        int filasAfectadas = cmd.ExecuteNonQuery();

                        if (filasAfectadas > 0)
                        {
                            MessageBox.Show("Barbero agregado correctamente.");


                            int nuevoId = Convert.ToInt32(cmd.LastInsertedId);


                            DataTable dt = dgvBarberos.DataSource as DataTable;
                            if (dt != null)
                            {
                                DataRow nuevaFila = dt.NewRow();
                                nuevaFila["barbero_id"] = nuevoId;
                                nuevaFila["nombre"] = ToUpperSafe(txtNombreB.Text);
                                nuevaFila["apellido"] = ToUpperSafe(txtApellidoB.Text);
                                nuevaFila["telefono"] = ToUpperSafe(txtTelefonoB.Text);
                                nuevaFila["email"] = ToUpperSafe(txtEmailB.Text);
                                dt.Rows.Add(nuevaFila);
                            }


                            txtNombreB.Clear();
                            txtApellidoB.Clear();
                            txtTelefonoB.Clear();
                            txtEmailB.Clear();
                        }
                        else
                        {
                            MessageBox.Show("No se pudo agregar el barbero.");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al agregar: " + ex.Message);
            }
        }



        private void dgvBarberos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow fila = dgvBarberos.Rows[e.RowIndex];
                txtNombreB.Text = fila.Cells["nombre"].Value.ToString();
                txtApellidoB.Text = fila.Cells["apellido"].Value.ToString();
                txtTelefonoB.Text = fila.Cells["telefono"].Value.ToString();
                txtEmailB.Text = fila.Cells["email"].Value.ToString();
            }
        }

        private void dgvBarberos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void RegistroDeBarberos_Load(object sender, EventArgs e)
        {
            AplicarRestricciones();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }


        private string ToUpperSafe(string input)
        {
            return string.IsNullOrWhiteSpace(input) ? string.Empty : input.ToUpper();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            string nombreBarbero = txtBuscadorBR.Text.Trim();

            try
            {
                ConexionDB cn = new ConexionDB();
                using (MySqlConnection conexion = cn.GetConnection())
                {
                    if (conexion != null)
                    {
                        string query = "SELECT barbero_id, nombre, apellido, telefono, email FROM barberos";

                        if (!string.IsNullOrEmpty(nombreBarbero))
                        {
                            query += " WHERE nombre LIKE @nombre OR apellido LIKE @nombre";
                        }

                        MySqlCommand cmd = new MySqlCommand(query, conexion);

                        if (!string.IsNullOrEmpty(nombreBarbero))
                        {
                            cmd.Parameters.AddWithValue("@nombre", "%" + nombreBarbero + "%");
                        }

                        MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                        DataTable dt = new DataTable();
                        da.Fill(dt);

                        dgvBarberos.DataSource = dt;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al buscar barbero: " + ex.Message);
            }
        }

        private void btnRefrescar_Click(object sender, EventArgs e)
        {
            try
            {
                txtNombreB.Clear();
                txtApellidoB.Clear();
                txtTelefonoB.Clear();
                txtEmailB.Clear();
                txtBuscadorBR.Text = "";

                CargarBarberos();
                dgvBarberos.ClearSelection();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al refrescar el formulario: " + ex.Message);
            }
        }
    }
}