using MySql.Data;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Barber_Royal.RegistroDeBarberos;

namespace Barber_Royal
{
    public partial class Citas : Form
    {
        private string cadenaConexion = "server=localhost;user=root;database=barber_royal;password=";

       // private static string cadenaConexion = @"Server=(localdb)\mssqllocaldb;Database=barber_royal;Trusted_Connection=True;";

        private MySqlConnection conexion;
        public Citas()
        {
            InitializeComponent();
            //hola

            dtpHora.Format = DateTimePickerFormat.Time;
            dtpHora.ShowUpDown = true;

            dtpHoraFin.Format = DateTimePickerFormat.Time;
            dtpHoraFin.ShowUpDown = true;
            dtpHoraFin.Enabled = false;


            ckbCorte.CheckedChanged += ActualizarHoraFin_CheckedChanged;
            ckbBarba.CheckedChanged += ActualizarHoraFin_CheckedChanged;
            ckbCejas.CheckedChanged += ActualizarHoraFin_CheckedChanged;
            ckbColoracion.CheckedChanged += ActualizarHoraFin_CheckedChanged;
            ckbOtro.CheckedChanged += ActualizarHoraFin_CheckedChanged;


            dtpHora.ValueChanged += ActualizarHoraFin_CheckedChanged;

        }

        private void ActualizarHoraFin_CheckedChanged(object sender, EventArgs e)
        {
            ActualizarHoraFin();
        }

        private int citaSeleccionadaID = -1; // variable global en la clase


        private int CalcularDuracionMinutos()
        {
            int duracion = 0;
            if (ckbCorte.Checked) duracion += 40;
            if (ckbBarba.Checked) duracion += 20;
            if (ckbCejas.Checked) duracion += 15;
            if (ckbColoracion.Checked) duracion += 60;
            if (ckbOtro.Checked) duracion += 30;

            return duracion;
        }

        private void ActualizarHoraFin()
        {
            int duracion = CalcularDuracionMinutos();
            dtpHoraFin.Value = dtpHora.Value.AddMinutes(duracion);
        }

        private bool HayConflicto(string barbero, DateTime fecha, TimeSpan horaInicio, TimeSpan horaFin)
        {
            try
            {
                using (MySqlConnection conexion = new MySqlConnection(cadenaConexion))
                {
                    conexion.Open();
                    string sql = "SELECT COUNT(*) FROM citas " +
                                    "WHERE barbero = @barbero AND fecha = @fecha " +
                                    "AND ((hora BETWEEN @horaInicio AND @horaFin) " +
                                    "OR (hora_fin BETWEEN @horaInicio AND @horaFin) " +
                                    "OR (@horaInicio BETWEEN hora AND hora_fin) " +
                                    "OR (@horaFin BETWEEN hora AND hora_fin))";

                    MySqlCommand cmd = new MySqlCommand(sql, conexion);
                    cmd.Parameters.AddWithValue("@barbero", barbero);
                    cmd.Parameters.AddWithValue("@fecha", fecha.Date);
                    cmd.Parameters.AddWithValue("@horaInicio", horaInicio);
                    cmd.Parameters.AddWithValue("@horaFin", horaFin);

                    int count = Convert.ToInt32(cmd.ExecuteScalar());
                    conexion.Close();
                    return count > 0;
                }
            }
            catch
            {
                return true;
            }
        }
       

        private void CargarClientesCombo()
        {
            try
            {
                using (MySqlConnection conexion = new MySqlConnection(cadenaConexion))
                {
                    conexion.Open();
                    string query = "SELECT cliente_id, nombre, apellido FROM clientes";
                    MySqlCommand cmd = new MySqlCommand(query, conexion);
                    MySqlDataReader reader = cmd.ExecuteReader();

                    cmbCliente.Items.Clear();
                    while (reader.Read())
                    {
                        string nombreCompleto = reader["nombre"].ToString() + " " + reader["apellido"].ToString();
                        cmbCliente.Items.Add(new ComboboxItem { Text = nombreCompleto, Value = reader["cliente_id"] });
                    }
                    conexion.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar clientes: " + ex.Message);
            }
        }


        private void InicializarConexion()
        {
            try
            {
                conexion = new MySqlConnection(cadenaConexion);
                conexion.Open();

                conexion.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al conectar con la base de datos: " + ex.Message);
            }
        }

        private void CargarCitas()
        {
            try
            {
                using (MySqlConnection conexion = new MySqlConnection(cadenaConexion))
                {
                    conexion.Open();
                    string query = "SELECT cita_id, cliente, barbero, fecha, hora, hora_fin, servicios, observaciones, estado FROM citas";
                    MySqlDataAdapter da = new MySqlDataAdapter(query, conexion);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    dataGridView1.DataSource = dt;

                    if (dataGridView1.Columns.Contains("estado"))
                    {
                        int colIndex = dataGridView1.Columns["estado"].Index;
                        dataGridView1.Columns.RemoveAt(colIndex);

                        DataGridViewComboBoxColumn comboEstado = new DataGridViewComboBoxColumn();
                        comboEstado.Name = "estado";
                        comboEstado.HeaderText = "Estado";
                        comboEstado.DataPropertyName = "estado";
                        comboEstado.Items.AddRange("Programada", "Cancelada", "Completada", "Ausente");
                        comboEstado.FlatStyle = FlatStyle.Flat;

                        dataGridView1.Columns.Insert(colIndex, comboEstado);
                    }

                    if (dataGridView1.Columns.Contains("hora_fin"))
                        dataGridView1.Columns["hora_fin"].HeaderText = "Hora Fin";

                    conexion.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar citas: " + ex.Message);
            }
        }




        private void CargarBarberosCombo()
        {
            try
            {
                using (MySqlConnection conexion = new MySqlConnection(cadenaConexion))
                {
                    conexion.Open();
                    string query = "SELECT barbero_id, nombre, apellido FROM barberos";
                    MySqlCommand cmd = new MySqlCommand(query, conexion);
                    MySqlDataReader reader = cmd.ExecuteReader();

                    cmbBarbero.Items.Clear();
                    while (reader.Read())
                    {
                        string nombreCompleto = reader["nombre"].ToString() + " " + reader["apellido"].ToString();
                        cmbBarbero.Items.Add(new ComboboxItem { Text = nombreCompleto, Value = reader["barbero_id"] });
                    }
                    conexion.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar barberos: " + ex.Message);
            }
        }


        private void Citas_Load(object sender, EventArgs e)
        {
            InicializarConexion();
            CargarClientesCombo();
            CargarBarberosCombo();
            CargarCitas();
            dataGridView1.CellValueChanged += dataGridView1_CellValueChanged;
            dataGridView1.CurrentCellDirtyStateChanged += dataGridView1_CurrentCellDirtyStateChanged;
            dataGridView1.RowEnter += dataGridView1_RowEnter;
        }

        private void ckbBarba_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void ckbCorte_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void cmbCliente_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cmbBarbero_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dtpFecha_ValueChanged(object sender, EventArgs e)
        {

        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            if (cmbCliente.SelectedItem == null || cmbBarbero.SelectedItem == null)
            {
                MessageBox.Show("Selecciona un cliente y un barbero.");
                return;
            }


            ComboboxItem clienteItem = (ComboboxItem)cmbCliente.SelectedItem;
            ComboboxItem barberoItem = (ComboboxItem)cmbBarbero.SelectedItem;
            string clienteNombre = clienteItem.Text;
            string barberoNombre = barberoItem.Text;


            List<string> servicios = new List<string>();
            if (ckbCorte.Checked) servicios.Add("Corte");
            if (ckbBarba.Checked) servicios.Add("Barba");
            if (ckbCejas.Checked) servicios.Add("Cejas");
            if (ckbColoracion.Checked) servicios.Add("Coloración");
            if (ckbOtro.Checked) servicios.Add("Otro");

            if (servicios.Count == 0)
            {
                MessageBox.Show("Selecciona al menos un servicio.");
                return;
            }

            string serviciosStr = string.Join(", ", servicios);
            string observaciones = txtObservaciones.Text;


            int duracion = 0;
            if (ckbCorte.Checked) duracion += 40;
            if (ckbBarba.Checked) duracion += 20;
            if (ckbCejas.Checked) duracion += 15;
            if (ckbColoracion.Checked) duracion += 60;
            if (ckbOtro.Checked) duracion += 30;


            dtpHoraFin.Value = dtpHora.Value.AddMinutes(duracion);

            TimeSpan horaInicio = dtpHora.Value.TimeOfDay;
            TimeSpan horaFin = dtpHoraFin.Value.TimeOfDay;


            if (HayConflicto(barberoNombre, dtpFecha.Value, horaInicio, horaFin))
            {
                MessageBox.Show("Este barbero ya tiene una cita en este horario.");
                return;
            }

            try
            {
                using (MySqlConnection conexion = new MySqlConnection(cadenaConexion))
                {
                    conexion.Open();
                    string sql = "INSERT INTO citas (cliente, barbero, fecha, hora, hora_fin, servicios, observaciones) " +
                                 "VALUES (@cliente, @barbero, @fecha, @hora, @horaFin, @servicios, @observaciones)";
                    MySqlCommand cmd = new MySqlCommand(sql, conexion);
                    cmd.Parameters.AddWithValue("@cliente", clienteNombre);
                    cmd.Parameters.AddWithValue("@barbero", barberoNombre);
                    cmd.Parameters.AddWithValue("@fecha", dtpFecha.Value.Date);
                    cmd.Parameters.AddWithValue("@hora", horaInicio);
                    cmd.Parameters.AddWithValue("@horaFin", horaFin);
                    cmd.Parameters.AddWithValue("@servicios", serviciosStr);
                    cmd.Parameters.AddWithValue("@observaciones", observaciones);

                    cmd.ExecuteNonQuery();
                    conexion.Close();

                    MessageBox.Show("Cita registrada correctamente.");
                    CargarCitas();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al registrar cita: " + ex.Message);
            }
        }



        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow == null)
            {
                MessageBox.Show("Selecciona una cita para eliminar.");
                return;
            }

            int citaId = Convert.ToInt32(dataGridView1.CurrentRow.Cells["cita_id"].Value);

            DialogResult result = MessageBox.Show("¿Deseas eliminar esta cita?", "Confirmar", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                using (MySqlConnection conexion = new MySqlConnection(cadenaConexion))
                {
                    conexion.Open();
                    string sql = "DELETE FROM citas WHERE cita_id = @id";
                    MySqlCommand cmd = new MySqlCommand(sql, conexion);
                    cmd.Parameters.AddWithValue("@id", citaId);
                    cmd.ExecuteNonQuery();
                    conexion.Close();
                }
                MessageBox.Show("Cita eliminada correctamente.");
                CargarCitas();
            }
        }


        private void dtpHora_ValueChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && dataGridView1.Columns[e.ColumnIndex].Name == "estado")
            {
                citaSeleccionadaID = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells["cita_id"].Value);

                int citaId = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells["cita_id"].Value);
                string nuevoEstado = dataGridView1.Rows[e.RowIndex].Cells["estado"].Value?.ToString();

                try
                {
                    using (MySqlConnection conexion = new MySqlConnection(cadenaConexion))
                    {
                        conexion.Open();
                        string query = "UPDATE citas SET estado = @estado WHERE cita_id = @id";
                        MySqlCommand cmd = new MySqlCommand(query, conexion);
                        cmd.Parameters.AddWithValue("@estado", nuevoEstado);
                        cmd.Parameters.AddWithValue("@id", citaId);
                        cmd.ExecuteNonQuery();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al actualizar el estado: " + ex.Message);
                }
            }
        }


        private void dataGridView1_CurrentCellDirtyStateChanged(object sender, EventArgs e)
        {
            if (dataGridView1.IsCurrentCellDirty)
                dataGridView1.CommitEdit(DataGridViewDataErrorContexts.Commit);
        }

        private void dataGridView1_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
                citaSeleccionadaID = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells["cita_id"].Value);
        }

        private void ckbCejas_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void ckbOtro_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void ckbColoracion_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void dtpHoraFin_ValueChanged(object sender, EventArgs e)
        {

        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            if (citaSeleccionadaID == -1)
            {
                MessageBox.Show("Selecciona una cita en la tabla para actualizar.");
                return;
            }

            if (cmbBarbero.SelectedItem == null)
            {
                MessageBox.Show("Selecciona un barbero para actualizar la cita.");
                return;
            }

            ComboboxItem barberoItem = (ComboboxItem)cmbBarbero.SelectedItem;
            string barberoNombre = barberoItem.Text.Trim();

            DateTime nuevaFecha = dtpFecha.Value.Date;
            TimeSpan nuevaHoraInicio = dtpHora.Value.TimeOfDay;
            TimeSpan nuevaHoraFin = dtpHoraFin.Value.TimeOfDay;

            try
            {
                using (MySqlConnection conexion = new MySqlConnection(cadenaConexion))
                {
                    conexion.Open();
                    string sql = @"UPDATE citas 
                           SET barbero = @barbero, 
                               fecha = @fecha, 
                               hora = @hora, 
                               hora_fin = @horaFin 
                           WHERE cita_id = @id";

                    MySqlCommand cmd = new MySqlCommand(sql, conexion);
                    cmd.Parameters.AddWithValue("@barbero", barberoNombre);
                    cmd.Parameters.AddWithValue("@fecha", nuevaFecha);
                    cmd.Parameters.AddWithValue("@hora", nuevaHoraInicio.ToString(@"hh\:mm\:ss"));
                    cmd.Parameters.AddWithValue("@horaFin", nuevaHoraFin.ToString(@"hh\:mm\:ss"));
                    cmd.Parameters.AddWithValue("@id", citaSeleccionadaID);

                    int filasAfectadas = cmd.ExecuteNonQuery();
                    conexion.Close();

                    if (filasAfectadas > 0)
                    {
                        MessageBox.Show("Cita actualizada correctamente.");
                        CargarCitas();
                    }
                    else
                    {
                        MessageBox.Show("No se pudo actualizar la cita. Verifica la selección.");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al actualizar cita: " + ex.Message);
            }
        }


        private void btnFiltroCliente_Click(object sender, EventArgs e)
        {
            string textoBusqueda = txtbusquedaCLT.Text.Trim();
            DateTime fechaBusqueda;
            bool esFecha = DateTime.TryParse(textoBusqueda, out fechaBusqueda);

            try
            {
                ConexionDB conexionDB = new ConexionDB();
                using (MySqlConnection conexion = conexionDB.GetConnection())
                {
                    string query = "SELECT cita_id, cliente, barbero, fecha, hora, hora_fin, servicios, observaciones, estado FROM citas WHERE 1=1";

                    if (!string.IsNullOrEmpty(textoBusqueda))
                    {
                        if (esFecha)
                        {
                            // Si el texto es una fecha válida, buscar por la fecha exacta
                            query += " AND fecha = @fecha";
                        }
                        else
                        {
                            // Si no es fecha, buscar por nombre
                            query += " AND cliente LIKE @cliente";
                        }
                    }

                    MySqlCommand cmd = new MySqlCommand(query, conexion);

                    if (!string.IsNullOrEmpty(textoBusqueda))
                    {
                        if (esFecha)
                            cmd.Parameters.AddWithValue("@fecha", fechaBusqueda);
                        else
                            cmd.Parameters.AddWithValue("@cliente", "%" + textoBusqueda + "%");
                    }

                    MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    dataGridView1.DataSource = dt;

                    if (dataGridView1.Columns.Contains("hora_fin"))
                        dataGridView1.Columns["hora_fin"].HeaderText = "Hora Fin";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al buscar cliente o fecha: " + ex.Message);
            }
        }

        private void btnRefrescar_Click(object sender, EventArgs e)
        {
            try
            {
                // Limpia los controles del formulario
                txtbusquedaCLT.Text = "";
                cmbCliente.SelectedIndex = -1;
                cmbBarbero.SelectedIndex = -1;
                
                txtObservaciones.Text = "";
                ckbCorte.Checked = false;
                ckbBarba.Checked = false;
                ckbCejas.Checked = false;
                ckbColoracion.Checked = false;
                ckbOtro.Checked = false;

                // Reinicia las fechas y horas
                dtpFecha.Value = DateTime.Now;
                dtpHora.Value = DateTime.Now;
                dtpHoraFin.Value = DateTime.Now;

                // Recarga los datos
                CargarBarberosCombo();
                CargarCitas();

                // Limpia la selección del DataGridView
                dataGridView1.ClearSelection();
                citaSeleccionadaID = -1;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al refrescar el formulario: " + ex.Message);
            }
        }

        
    }
}