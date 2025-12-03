using System;
using System.Diagnostics;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Barber_Royal
{
    public partial class Form1 : Form
    {
        private string connectionString = "server=localhost;user=root;database=barber_royal;password=;";

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            textBox1.Focus();
            textBox2.PasswordChar = '•';
            DBgestor db = new DBgestor();
            db.InicializarBase();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox1.Focus();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        // # Este botón permite al usuario entrar (button1)
        private void button1_Click(object sender, EventArgs e)
        {
            string nombreUsuario = textBox1.Text.Trim();
            string contrasena = textBox2.Text.Trim();

            if (string.IsNullOrWhiteSpace(nombreUsuario) || string.IsNullOrWhiteSpace(contrasena))
            {
                MessageBox.Show("Por favor, ingresa el nombre de usuario y la contraseña.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    connection.Open();

                    // Consulta para verificar usuario y contraseña
                    string query = "SELECT nombre_usuario, rol FROM usuarios WHERE nombre_usuario = @nombre AND contrasena = @contrasena";

                    using (MySqlCommand cmd = new MySqlCommand(query, connection))
                    {
                        cmd.Parameters.AddWithValue("@nombre", nombreUsuario);
                        cmd.Parameters.AddWithValue("@contrasena", contrasena);

                        using (MySqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                string nombre = reader.GetString("nombre_usuario");
                                string rol = reader.GetString("rol");

                                rol = rol.Trim().ToLower();

                                MessageBox.Show($"Bienvenido {nombre} ({rol})", "Acceso concedido", MessageBoxButtons.OK, MessageBoxIcon.Information);

                                // Abrir el formulario del menú principal
                                Menu menu = new Menu();
                                menu.tipoUsuario = rol; // Envía el rol
                                menu.Show();

                                this.Hide(); // Oculta el login
                            }
                            else
                            {
                                MessageBox.Show("Nombre o contraseña incorrectos.", "Error de acceso", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                textBox1.Clear();
                                textBox2.Clear();
                                textBox1.Focus();
                            }
                        }
                    }
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Error al conectar con la base de datos: " + ex.Message);
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            try
            {
                using (MySqlConnection conn = new MySqlConnection(connectionString))
                {
                    conn.Open();
                    MySqlCommand cmd = new MySqlCommand("SELECT COUNT(*) FROM usuarios", conn);
                    int totalUsuarios = Convert.ToInt32(cmd.ExecuteScalar());

                    if (totalUsuarios == 0)
                    {
                        MessageBox.Show("⚠️ No hay usuarios registrados. Se abrirá el formulario de registro.");

                        // Abrir Usuario_0 solo si no hay usuarios
                        Usuario_0 frm = new Usuario_0();

                        // Para que Form1 reaparezca cuando se cierre Usuario_0
                        frm.FormClosed += (s, args) => this.Show();

                        this.Hide(); // Oculta Form1 mientras Usuario_0 esté abierto
                        frm.Show();
                    }
                    else
                    {
                        MessageBox.Show("✅ Ya existen usuarios registrados.");
                        btnVerificar.Enabled = false; // deshabilita el botón
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al verificar la tabla: " + ex.Message);
            }
        }

        private void Tutorial_Click(object sender, EventArgs e)
        {
            string url = "https://drive.google.com/drive/folders/1_0K198eLlpMRQH-HTOsq2U00SZlEOkaM?usp=sharing";

            try
            {
                var psi = new ProcessStartInfo
                {
                    FileName = url,
                    UseShellExecute = true
                };
                Process.Start(psi);
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo abrir el enlace: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}