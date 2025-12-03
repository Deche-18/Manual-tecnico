using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace Barber_Royal
{
    public partial class Menu : Form
    {

        public string tipoUsuario { get; set; }

        public Menu()
        {
            InitializeComponent();

            // Hace que el formulario se abra en el centro de la pantalla
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void BarraTitulo_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private bool dashboardCargado = false;

        private void PanelContenedor_Paint(object sender, PaintEventArgs e)
        {
            if (!dashboardCargado)
            {
                AbrirFormEnPanel(new Dashboard());
                dashboardCargado = true;
            }
        }

        private void AbrirFormEnPanel(object Formhijo)
        {
            if (this.PanelContenedor.Controls.Count > 0)
                this.PanelContenedor.Controls.RemoveAt(0);
            Form fh = Formhijo as Form;
            fh.TopLevel = false;
            fh.FormBorderStyle = FormBorderStyle.None;
            fh.Dock = DockStyle.Fill;
            this.PanelContenedor.Controls.Add(fh);
            this.PanelContenedor.Tag = fh;
            fh.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!ControlAcceso.PermitirAcceso(tipoUsuario, "Registro"))
            {
                ControlAcceso.MostrarDenegado();
                return;
            }
            RegistroDeBarberos registro = new RegistroDeBarberos(tipoUsuario);
            AbrirFormEnPanel(registro);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            AbrirFormEnPanel(new Citas());
        }

        private void button3_Click(object sender, EventArgs e)
        {
            AbrirFormEnPanel(new RegistroDeClientescs(tipoUsuario));
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (!ControlAcceso.PermitirAcceso(tipoUsuario, "Registro"))
            {
                ControlAcceso.MostrarDenegado();
                return;
            }

            AbrirFormEnPanel(new Registro());
        }

        private void BarraTitulo_Paint(object sender, PaintEventArgs e)
        {

        }


        private void AplicarRestricciones()
        {
            if (tipoUsuario == "Usuario")
            {

                button1.Enabled = false;
                button3.Enabled = false;
            }
            else if (tipoUsuario == "Administrador")
            {

                button1.Enabled = true;
                button3.Enabled = true;
            }
        }


        private void Menu_Load(object sender, EventArgs e)
        {
            AplicarRestricciones();
            
        }

        private void button5_Click(object sender, EventArgs e)
        {
            // Confirmar si el usuario realmente quiere cerrar sesión
            DialogResult result = MessageBox.Show("¿Seguro que deseas cerrar sesión?", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                // Cierra el formulario actual (menú principal)
                this.Hide();

                // Crea una nueva instancia del formulario de Login
                Form1 login = new Form1();

                // Muestra el login otra vez
                login.Show();
            }
        }

        private void btnbackup_Click(object sender, EventArgs e)
        {
            if (!ControlAcceso.PermitirAcceso(tipoUsuario, "Registro"))
            {
                ControlAcceso.MostrarDenegado();
                return;
            }
            Submenu.Visible = true;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            AbrirFormEnPanel(new Backup());
            Submenu.Visible = false;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            AbrirFormEnPanel(new Reportes());

            Submenu.Visible = false;
            
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Submenu.Visible = false;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            AbrirFormEnPanel(new Dashboard());
        }
    }
}
