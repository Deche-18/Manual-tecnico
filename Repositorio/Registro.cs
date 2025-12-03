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
using MySql.Data.MySqlClient;

namespace Barber_Royal
{
    public partial class Registro : Form
    {

        public Registro()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Determinar rol
            string rol = checkBox1.Checked ? "administrador" :
                         checkBox2.Checked ? "usuario" : "";

            if (string.IsNullOrWhiteSpace(rol))
            {
                MessageBox.Show("Por favor selecciona un rol (Administrador o Usuario)");
                return;
            }

            // Validar campos obligatorios
            if (string.IsNullOrWhiteSpace(textBox1.Text) ||
                string.IsNullOrWhiteSpace(textBox2.Text) ||
                string.IsNullOrWhiteSpace(textBox3.Text))
            {
                MessageBox.Show("Por favor completa todos los campos obligatorios.");
                return;
            }

            try
            {
                ConexionDB db = new ConexionDB();
                using (MySqlConnection conn = db.GetConnection())
                {
                    if (conn == null) return;

                    string query = @"INSERT INTO usuarios (nombre_usuario, correo, contrasena, telefono, rol) 
                             VALUES (@nombre, @correo, @contrasena, @telefono, @rol)";

                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@nombre", textBox1.Text);
                        cmd.Parameters.AddWithValue("@correo", textBox2.Text);
                        cmd.Parameters.AddWithValue("@contrasena", textBox3.Text);
                        cmd.Parameters.AddWithValue("@telefono", textBox4.Text);
                        cmd.Parameters.AddWithValue("@rol", rol);
                        cmd.ExecuteNonQuery();
                    }

                    MessageBox.Show("Usuario registrado exitosamente 🎉");
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Error al registrar el usuario: " + ex.Message);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // Limpiar los campos
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            checkBox1.Checked = false;
            checkBox2.Checked = false;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Registro_Load_1(object sender, EventArgs e)
        {

        }
    }
}
