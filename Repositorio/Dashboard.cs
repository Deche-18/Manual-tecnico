using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using MySql.Data.MySqlClient;
using System.Data;

namespace Barber_Royal
{
    public partial class Dashboard : Form
    {
        ConexionDB db = new ConexionDB();
        public Dashboard()
        {
            InitializeComponent();
        }
        // Declarar Timer
        private System.Windows.Forms.Timer relojTimer = new System.Windows.Forms.Timer();

        private void Dashboard_Load(object sender, EventArgs e)
        {
            MostrarTotales();
            MostrarGraficoCitas();
            CargarUltimasCitas();


            // Configurar reloj
            relojTimer.Interval = 1000; // 1 segundo
            relojTimer.Tick += RelojTimer_Tick;
            relojTimer.Start();



            // Estilo de colores
            calendarioDashboard.BackColor = Color.White;
            calendarioDashboard.ForeColor = Color.Black;
            
            calendarioDashboard.TitleForeColor = Color.White;
            calendarioDashboard.TrailingForeColor = Color.Gray;

            dgvUltimasCitas.DefaultCellStyle.ForeColor = Color.Black;

        }

        private void MostrarTotales()
        {
            using (MySqlConnection con = db.GetConnection())
            {
                if (con != null)
                {
                    try
                    {
                        // Total clientes
                        MySqlCommand cmdClientes = new MySqlCommand("SELECT COUNT(*) FROM clientes", con);
                        lblTotalClientes.Text = cmdClientes.ExecuteScalar().ToString();

                        // Total barberos
                        MySqlCommand cmdBarberos = new MySqlCommand("SELECT COUNT(*) FROM barberos", con);
                        lblTotalBarberos.Text = cmdBarberos.ExecuteScalar().ToString();

                        // Citas programadas
                        MySqlCommand cmdProgramadas = new MySqlCommand("SELECT COUNT(*) FROM citas WHERE estado='Programada'", con);
                        lblCitasProgramadas.Text = cmdProgramadas.ExecuteScalar().ToString();

                        // Citas completadas
                        MySqlCommand cmdCompletadas = new MySqlCommand("SELECT COUNT(*) FROM citas WHERE estado='Completada'", con);
                        lblCitasCompletadas.Text = cmdCompletadas.ExecuteScalar().ToString();






                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error al cargar totales: " + ex.Message);
                    }
                }
            }
        }

        // Evento Tick del reloj
        private void RelojTimer_Tick(object sender, EventArgs e)
        {
            lblReloj.Text = DateTime.Now.ToString("HH:mm:ss"); // formato 24h 
        }

        private void CargarUltimasCitas()
        {
            using (MySqlConnection con = db.GetConnection())
            {
                if (con != null)
                {
                    string query = "SELECT cliente, fecha, hora, estado FROM citas ORDER BY fecha DESC LIMIT 10";
                    MySqlDataAdapter da = new MySqlDataAdapter(query, con);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    dgvUltimasCitas.DataSource = dt;
                }
            }
        }

        private void MostrarGraficoCitas()
        {
            using (MySqlConnection con = db.GetConnection())
            {
                if (con != null)
                {
                    try
                    {
                        string query = @"
                    SELECT estado, COUNT(*) AS cantidad 
                    FROM citas 
                    WHERE estado IN ('Programada','Completada','Cancelada','Ausente')
                    GROUP BY estado";

                        MySqlCommand cmd = new MySqlCommand(query, con);
                        MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                        DataTable dt = new DataTable();
                        da.Fill(dt);

                        chartCitas.Series.Clear();
                        chartCitas.Titles.Clear();

                        chartCitas.Titles.Add("Distribución de Citas");
                        chartCitas.Series.Add("Citas");
                        chartCitas.Series["Citas"].XValueMember = "estado";
                        chartCitas.Series["Citas"].YValueMembers = "cantidad";
                        chartCitas.Series["Citas"].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;

                        // etiquetas con valores y porcentajes
                        chartCitas.Series["Citas"].IsValueShownAsLabel = true;
                        chartCitas.Series["Citas"].Label = "#VALX (#PERCENT{P0})";

                        chartCitas.DataSource = dt;
                        chartCitas.DataBind();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error al mostrar gráfico: " + ex.Message);
                    }
                }
            }
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }
    }
}
