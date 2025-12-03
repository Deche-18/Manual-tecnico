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

namespace Barber_Royal
{
    public partial class Usuario_0 : Form
    {
        public Usuario_0()
        {
            InitializeComponent();
        }

        private void Usuario_0_Load(object sender, EventArgs e)
        {
            ConexionDB db = new ConexionDB();
            using (MySqlConnection conn = db.GetConnection())
            {
                // conn.Open(); <-- Quitar esta línea
                MySqlCommand cmd = new MySqlCommand("SELECT COUNT(*) FROM usuarios", conn);
                int cantidad = Convert.ToInt32(cmd.ExecuteScalar());

                if (cantidad > 0)
                {
                    MessageBox.Show("Ya existe un usuario. Este formulario no está disponible.");
                    this.Close();
                }
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNombre_US.Text) ||
        string.IsNullOrWhiteSpace(txtCorreo.Text) ||
        string.IsNullOrWhiteSpace(txtContrasena.Text))
            {
                MessageBox.Show("Por favor completa todos los campos obligatorios.");
                return;
            }

            try
            {
                ConexionDB db = new ConexionDB();
                using (MySqlConnection conn = db.GetConnection())
                {

                    // Comprobar otra vez por seguridad
                    MySqlCommand check = new MySqlCommand("SELECT COUNT(*) FROM usuarios", conn);
                    int cantidad = Convert.ToInt32(check.ExecuteScalar());
                    if (cantidad > 0)
                    {
                        MessageBox.Show("Ya existe un usuario. No puedes registrar otro.");
                        this.Close();
                        return;
                    }

                    string query = @"INSERT INTO usuarios 
                            (nombre_usuario, correo, contrasena, telefono, rol) 
                            VALUES (@nombre, @correo, @contrasena, @telefono, 'administrador')";
                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@nombre", txtNombre_US.Text);
                        cmd.Parameters.AddWithValue("@correo", txtCorreo.Text);
                        cmd.Parameters.AddWithValue("@contrasena", txtContrasena.Text);
                        cmd.Parameters.AddWithValue("@telefono", txtTelefono.Text);
                        cmd.ExecuteNonQuery();
                    }

                    MessageBox.Show("Usuario administrador creado correctamente 🎉");
                    this.Close(); // Cierra el formulario después de crear el usuario
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Error al registrar el usuario: " + ex.Message);
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtNombre_US.Clear();
            txtCorreo.Clear();
            txtContrasena.Clear();
            txtTelefono.Clear();
            txtNombre_US.Focus();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
