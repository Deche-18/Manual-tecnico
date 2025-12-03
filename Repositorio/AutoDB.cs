using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Barber_Royal
{
    internal class AutoDB
    {
        public static void Initialize()
        {
            CrearBase();
            CrearTablas();
        }

        private static void CrearBase()
        {
            string connSinDB = "server=localhost;user=root;password=;";

            using (var conn = new MySqlConnection(connSinDB))
            {
                conn.Open();
                using (var cmd = new MySqlCommand("CREATE DATABASE IF NOT EXISTS barber_royal;", conn))
                    cmd.ExecuteNonQuery();
            }
        }

        private static void CrearTablas()
        {
            string connDB = "server=localhost;user=root;password=;database=barber_royal;";
            using (var conn = new MySqlConnection(connDB))
            {
                conn.Open();

                Ejecutar(conn, @"
                CREATE TABLE IF NOT EXISTS clientes (
                    cliente_id INT AUTO_INCREMENT PRIMARY KEY,
                    nombre VARCHAR(50) NOT NULL,
                    apellido VARCHAR(50) NOT NULL,
                    nacimiento DATE,
                    telefono VARCHAR(20),
                    email VARCHAR(100),
                    fecha_registro TIMESTAMP DEFAULT CURRENT_TIMESTAMP
                );");

                Ejecutar(conn, @"
                CREATE TABLE IF NOT EXISTS barberos (
                    barbero_id INT AUTO_INCREMENT PRIMARY KEY,
                    nombre VARCHAR(50) NOT NULL,
                    apellido VARCHAR(50) NOT NULL,
                    email VARCHAR(100),
                    telefono VARCHAR(20),
                    fecha_registro TIMESTAMP DEFAULT CURRENT_TIMESTAMP
                );");

                Ejecutar(conn, @"
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
                );");

                Ejecutar(conn, @"
                CREATE TABLE IF NOT EXISTS usuarios (
                    id_usuario INT AUTO_INCREMENT PRIMARY KEY,
                    nombre_usuario VARCHAR(50) NOT NULL,
                    correo VARCHAR(100) NOT NULL UNIQUE,
                    contrasena VARCHAR(255) NOT NULL,
                    telefono VARCHAR(15),
                    fecha_registro TIMESTAMP DEFAULT CURRENT_TIMESTAMP,
                    rol ENUM('usuario', 'administrador') DEFAULT 'usuario'
                );");
            }
        }

        private static void Ejecutar(MySqlConnection conn, string query)
        {
            using (var cmd = new MySqlCommand(query, conn))
                cmd.ExecuteNonQuery();
        }
    }
}
