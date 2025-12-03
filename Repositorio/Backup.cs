using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Barber_Royal
{
    public partial class Backup : Form
    {
        public Backup()
        {
            InitializeComponent();
        }

        private void Backup_Load(object sender, EventArgs e)
        {
            
        }

        private void btnBackup_Click(object sender, EventArgs e)
        {
            try
            {
                SaveFileDialog sfd = new SaveFileDialog();
                sfd.Filter = "Archivo SQL (*.sql)|*.sql";
                sfd.FileName = "backup_barber_royal_" + DateTime.Now.ToString("yyyyMMdd_HHmmss") + ".sql";

                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    string rutaArchivo = sfd.FileName;

                    string rutaMySqlDump = @"C:\Program Files\MySQL\MySQL Server 8.0\bin\mysqldump.exe";
                    string usuario = "root";
                    string baseDatos = "barber_royal";

                    string argumentos = $"-u {usuario} {baseDatos}";

                    ProcessStartInfo psi = new ProcessStartInfo()
                    {
                        FileName = "cmd.exe",
                        RedirectStandardInput = true,
                        UseShellExecute = false,
                        CreateNoWindow = true
                    };

                    Process proceso = Process.Start(psi);
                    proceso.StandardInput.WriteLine($"\"{rutaMySqlDump}\" {argumentos} > \"{rutaArchivo}\"");
                    proceso.StandardInput.Close();
                    proceso.WaitForExit();

                    MessageBox.Show("Respaldo creado correctamente.", "Éxito");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al crear el respaldo: " + ex.Message);
            }
        }

        private void btnRestore_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog ofd = new OpenFileDialog();
                ofd.Filter = "Archivo SQL (*.sql)|*.sql";

                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    string rutaArchivo = ofd.FileName;

                    string rutaMySql = @"C:\Program Files\MySQL\MySQL Server 8.0\bin\mysql.exe";
                    string usuario = "root";
                    string baseDatos = "barber_royal";

                    // SIN contraseña = NO poner -p
                    string argumentos = $"-u {usuario} {baseDatos} < \"{rutaArchivo}\"";

                    ProcessStartInfo psi = new ProcessStartInfo()
                    {
                        FileName = "cmd.exe",
                        RedirectStandardInput = true,
                        UseShellExecute = false,
                        CreateNoWindow = true
                    };

                    Process proceso = Process.Start(psi);
                    proceso.StandardInput.WriteLine($"\"{rutaMySql}\" {argumentos}");
                    proceso.StandardInput.Close();
                    proceso.WaitForExit();

                    MessageBox.Show("Base de datos restaurada correctamente.", "Éxito");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al restaurar el respaldo: " + ex.Message);
            }
        }
    }
}
