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






