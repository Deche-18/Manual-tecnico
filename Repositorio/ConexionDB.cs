using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Barber_Royal
{
    internal class ConexionDB
    {
        private string cadenaConexion = "server=localhost;user=root;password=;database=barber_royal";

        public MySqlConnection? GetConnection()
        {
            MySqlConnection conexion = new MySqlConnection(cadenaConexion);
            try
            {

                conexion.Open(); 
                return conexion;
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Error al conectar: " + ex.Message);
                return null;
            }
        }
    }
}
