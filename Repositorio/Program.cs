using MySql.Data.MySqlClient;

namespace Barber_Royal
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            try
            {
                // Crear base y tablas automáticamente
                AutoDB.Initialize();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al preparar la base de datos:\n" + ex.Message,
                                "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Application.Run(new Form1());
        }
    }
}