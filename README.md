# Manual-tecnico-Barber-Royal-Calendario
--Barber Royal--

Manual Técnico del Software de Barbería Royal:
El Software de Barbería Royal es un sistema diseñado para la gestión integral de citas y servicios dentro de una barbería. La aplicación permite registrar y controlar la fecha, hora y tipo de servicio solicitado por cada cliente, así como asignar el barbero responsable de su atención.

Además, el sistema incorpora módulos para la administración de citas, clientes y barberos, ofreciendo funcionalidades para la generación de reportes detallados sobre cada uno de estos componentes. Esto facilita el seguimiento operativo, la organización del personal y la toma de decisiones basada en información actualizada.

#Desarolladores involucrados

-Ivan Andres Galeas Murillo

-Alvaro Luis 

#Tecnologias

//C# (.NET 8) – ASP.NET Core MVC 

// MySQL Workbench 8.0 CE

//Entity Framework Core:Pomelo.EntityFrameworkCore.MySql


#Capturas

<img width="451" height="637" alt="image" src="https://github.com/user-attachments/assets/5aa84e50-7582-4789-88b3-1e601010effe" />


--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------


<img width="1599" height="609" alt="image" src="https://github.com/user-attachments/assets/fc0a97e8-9711-463e-a64c-e6afe9b4a9e3" />

--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------


<img width="1593" height="613" alt="image" src="https://github.com/user-attachments/assets/7ad28ce0-54d1-410c-8fbc-10adef54b0f1" />


--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------



#Instalacion rapida 

#Base de Datos


<img width="988" height="870" alt="image" src="https://github.com/user-attachments/assets/b77efa93-f520-4a96-bad8-d017c7a5abc3" />


-------CREATE DATABASE  IF NOT EXISTS `barber_royal`

--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------


-------CREATE TABLE `barberos` (

  `barbero_id` int NOT NULL AUTO_INCREMENT,
  
  `nombre` varchar(50) NOT NULL,
  
  `apellido` varchar(50) NOT NULL,
  
  `email` varchar(100) DEFAULT NULL,
  
  `telefono` varchar(20) DEFAULT NULL,
  
  `fecha_registro` timestamp NULL DEFAULT CURRENT_TIMESTAMP,
  
  PRIMARY KEY (`barbero_id`)
) 

--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------


-------CREATE TABLE `citas` (

  `cita_id` int NOT NULL AUTO_INCREMENT,
  
  `cliente` varchar(100) NOT NULL,
  
  `fecha` date NOT NULL,
  
  `hora` time NOT NULL,
  
  `hora_fin` time NOT NULL,
  
  `barbero` varchar(100) NOT NULL,
  
  `servicios` varchar(255) DEFAULT NULL,
  
  `observaciones` text,
  
  `estado` enum('Programada','Cancelada','Completada','Ausente') NOT NULL,
  
  PRIMARY KEY (`cita_id`) 
) 

--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------


-------CREATE TABLE `clientes` (

  `cliente_id` int NOT NULL AUTO_INCREMENT,
  
  `nombre` varchar(50) NOT NULL,
  
  `apellido` varchar(50) NOT NULL,
  
  `nacimiento` date DEFAULT NULL,
  
  `telefono` varchar(20) DEFAULT NULL,
  
  `email` varchar(100) DEFAULT NULL,
  
  `fecha_registro` timestamp NULL DEFAULT CURRENT_TIMESTAMP,
  
  PRIMARY KEY (`cliente_id`)
) 

--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------


-------CREATE TABLE `usuarios` (

  `id_usuario` int NOT NULL AUTO_INCREMENT,
  
  `nombre_usuario` varchar(50) NOT NULL,
  
  `correo` varchar(100) NOT NULL,
  
  `contrasena` varchar(255) NOT NULL,
  
  `telefono` varchar(15) DEFAULT NULL,
  
  `fecha_registro` timestamp NULL DEFAULT CURRENT_TIMESTAMP,
  
  `rol` enum('usuario','administrador') DEFAULT 'usuario',
  
  PRIMARY KEY (`id_usuario`),
  
  UNIQUE KEY `correo` (`correo`)
) 

--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------


#Documentacion de funciones 

1. Login

<img width="857" height="517" alt="butoom1 click1" src="https://github.com/user-attachments/assets/d2b52000-7ec1-44c3-a2bb-06ba96918e76" />

<img width="975" height="851" alt="buttom1" src="https://github.com/user-attachments/assets/9db9a84e-b1ed-4b10-9a20-09a84a5f3122" />

<img width="753" height="117" alt="Label2" src="https://github.com/user-attachments/assets/14cc18eb-6989-4916-bdcb-e2b7e69cceb9" />

<img width="578" height="95" alt="Label3" src="https://github.com/user-attachments/assets/0b7f3007-152d-4a3d-be10-d96a2a1d3ed6" />

<img width="886" height="293" alt="Tutorial" src="https://github.com/user-attachments/assets/e5d0fd35-985f-4bd2-ad8b-c341488b9986" />

--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

2. AutoDB

<img width="865" height="207" alt="Screenshot 2025-12-03 152838" src="https://github.com/user-attachments/assets/3ac7bdd8-3854-46cf-97a3-c3b315074819" />

<img width="687" height="835" alt="Screenshot 2025-12-03 152709" src="https://github.com/user-attachments/assets/2b53c1d6-1bec-4a83-81db-2730c4004f1b" />

<img width="1038" height="305" alt="Screenshot 2025-12-03 152656" src="https://github.com/user-attachments/assets/41459eb7-b64f-4ae5-8638-d1b324b8c994" />

--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

3. Conexion 

<img width="1070" height="642" alt="Screenshot 2025-12-03 152535" src="https://github.com/user-attachments/assets/801b0070-986e-4480-8096-b021e095e7e2" />

--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

