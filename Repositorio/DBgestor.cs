using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Windows.Forms;

namespace Barber_Royal
{
    internal class DBgestor
    {
        private string servidor = "localhost";
        private string usuario = "root";
        private string contraseña = "";

        public void InicializarBase()
        {
            try
            {
                string connStr = $"server={servidor};user={usuario};password={contraseña};";
                using (var conn = new MySqlConnection(connStr))
                {
                    conn.Open();
                    string crearDB = "CREATE DATABASE IF NOT EXISTS barber_royal";
                    using (var cmd = new MySqlCommand(crearDB, conn))
                    {
                        cmd.ExecuteNonQuery();
                    }
                }

                connStr = $"server={servidor};user={usuario};password={contraseña};database=barber_royal;";
                using (var conn = new MySqlConnection(connStr))
                {
                    conn.Open();

                    string crearClientes = @"
                        CREATE TABLE IF NOT EXISTS clientes (
                            cliente_id INT AUTO_INCREMENT PRIMARY KEY,
                            nombre VARCHAR(50) NOT NULL,
                            apellido VARCHAR(50) NOT NULL,
                            nacimiento DATE,
                            telefono VARCHAR(20),
                            email VARCHAR(100),
                            fecha_registro TIMESTAMP DEFAULT CURRENT_TIMESTAMP
                        );
                    ";
                    EjecutarQuery(crearClientes, conn);

                    string crearBarberos = @"
                        CREATE TABLE IF NOT EXISTS barberos (
                            barbero_id INT AUTO_INCREMENT PRIMARY KEY,
                            nombre VARCHAR(50) NOT NULL,
                            apellido VARCHAR(50) NOT NULL,
                            email VARCHAR(100),
                            telefono VARCHAR(20),
                            fecha_registro TIMESTAMP DEFAULT CURRENT_TIMESTAMP
                        );
                    ";
                    EjecutarQuery(crearBarberos, conn);

                    string crearCitas = @"
                CREATE TABLE IF NOT EXISTS citas (
                    cita_id INT AUTO_INCREMENT PRIMARY KEY,
                    cliente VARCHAR(100) NOT NULL,
                    fecha DATE NOT NULL,
                    hora TIME NOT NULL,
                    hora_fin TIME NOT NULL,
                    barbero VARCHAR(100) NOT NULL,
                    servicios VARCHAR(255),
                    observaciones TEXT,
                    estado ENUM('Programada','Cancelada','Completada','Ausente') DEFAULT 'Programada'
                );";
                    EjecutarQuery(crearCitas, conn);

                    string crearUsuarios = @"
                        CREATE TABLE IF NOT EXISTS usuarios (
                            id_usuario INT AUTO_INCREMENT PRIMARY KEY,
                            nombre_usuario VARCHAR(50) NOT NULL,
                            correo VARCHAR(100) NOT NULL UNIQUE,
                            contrasena VARCHAR(255) NOT NULL,
                            telefono VARCHAR(15),
                            fecha_registro TIMESTAMP DEFAULT CURRENT_TIMESTAMP,
                            rol ENUM('usuario', 'administrador') DEFAULT 'usuario'
                        );
                    ";
                    EjecutarQuery(crearUsuarios, conn);
                }

                
            }
            catch (Exception ex)
            {
                
            }
        }

        private void EjecutarQuery(string query, MySqlConnection conn)
        {
            using (var cmd = new MySqlCommand(query, conn))
            {
                cmd.ExecuteNonQuery();
            }
        }
    }
}
