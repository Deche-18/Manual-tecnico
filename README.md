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

3. ConexionDB

<img width="1070" height="642" alt="Screenshot 2025-12-03 152535" src="https://github.com/user-attachments/assets/801b0070-986e-4480-8096-b021e095e7e2" />

--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

4. Menu
   
<img width="655" height="147" alt="Screenshot 2025-12-03 164015" src="https://github.com/user-attachments/assets/4dc9fc5c-0b96-4a9d-93b5-7e03e3b0ac07" />

<img width="657" height="150" alt="Screenshot 2025-12-03 164404" src="https://github.com/user-attachments/assets/a30da087-e573-46ee-85f3-0807fc1c6932" />

<img width="794" height="135" alt="Screenshot 2025-12-03 164556" src="https://github.com/user-attachments/assets/c19763be-d020-4aec-9190-231c17c8881b" />

<img width="1172" height="289" alt="Screenshot 2025-12-03 164703" src="https://github.com/user-attachments/assets/b317f61e-8e18-4b4a-8357-6883d830f086" />

<img width="744" height="318" alt="Screenshot 2025-12-03 143903" src="https://github.com/user-attachments/assets/a680f94d-10ca-4809-ae3a-0ca2c7bd0a6e" />

<img width="950" height="263" alt="Screenshot 2025-12-03 165235" src="https://github.com/user-attachments/assets/20b782c7-f345-40ff-8098-2198c1fb9cb6" />

--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

5. Registro

<img width="414" height="98" alt="exit app" src="https://github.com/user-attachments/assets/155491aa-0661-4673-98b3-5bae7f495e9a" />

<img width="547" height="167" alt="botonlimpiar" src="https://github.com/user-attachments/assets/c19e4099-25f4-4773-bb7a-387f2b662922" />

<img width="870" height="705" alt="boton1" src="https://github.com/user-attachments/assets/bbbd63e7-2b0b-40f1-b4b2-3626576f2207" />

--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

6. Registro de Barberos
   
<img width="703" height="415" alt="Screenshot 2025-12-03 165839" src="https://github.com/user-attachments/assets/74b6effa-54b6-492a-8a35-8b676c006e19" />

<img width="709" height="120" alt="Screenshot 2025-12-03 144203" src="https://github.com/user-attachments/assets/4d989816-ea57-4490-9bd6-4db1ea8d5a34" />

<img width="709" height="254" alt="Screenshot 2025-12-03 144152" src="https://github.com/user-attachments/assets/18d01139-ad9a-4cff-99f1-10aa0141029c" />

<img width="1161" height="863" alt="Screenshot 2025-12-03 170227" src="https://github.com/user-attachments/assets/99986b5c-620e-4969-b9ed-42be2a7c9917" />

<img width="951" height="900" alt="Screenshot 2025-12-03 170306" src="https://github.com/user-attachments/assets/39ea18ac-ed2c-4dd3-a6a1-9212c69dd49f" />

<img width="660" height="546" alt="Screenshot 2025-12-03 170415" src="https://github.com/user-attachments/assets/c9c6a087-21f7-43ce-bdd6-efb48d3933e3" />

<img width="533" height="280" alt="Screenshot 2025-12-03 170435" src="https://github.com/user-attachments/assets/d6d50bec-52e5-4f75-83b7-79c0f418ef82" />

--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

7. Registro de Clientes

<img width="532" height="117" alt="Screenshot 2025-12-03 170605" src="https://github.com/user-attachments/assets/0626af4e-baf2-481c-8194-a9bbced0c77b" />

--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

8. Citas
   
<img width="794" height="259" alt="Screenshot 2025-12-03 171121" src="https://github.com/user-attachments/assets/086aa847-4e2d-40e7-81ab-c9b48862b6df" />

<img width="697" height="163" alt="Screenshot 2025-12-03 171214" src="https://github.com/user-attachments/assets/2d5d9ced-a8ce-4cf0-b5c5-e907bb90a366" />

<img width="892" height="644" alt="Screenshot 2025-12-03 171307" src="https://github.com/user-attachments/assets/0ba18458-886e-4a84-bc5d-900f3f792f0b" />

<img width="892" height="644" alt="Screenshot 2025-12-03 171307" src="https://github.com/user-attachments/assets/9a82f182-d673-4a31-9e9e-ee2d22c5726a" />

<img width="1005" height="548" alt="Screenshot 2025-12-03 171427" src="https://github.com/user-attachments/assets/a17b7338-de40-40d2-aa23-154ad881fc28" />

<img width="1021" height="644" alt="Screenshot 2025-12-03 171529" src="https://github.com/user-attachments/assets/7c0d8737-fe36-4a7d-82b3-224f55b30595" />

<img width="1068" height="340" alt="Screenshot 2025-12-03 171557" src="https://github.com/user-attachments/assets/d247f0c6-ca4c-4946-bcd6-2faa3d425e2d" />

<img width="688" height="916" alt="Screenshot 2025-12-03 171628" src="https://github.com/user-attachments/assets/b19a6ec7-e98d-41d3-a44f-bc5fe9a1841b" />

<img width="970" height="819" alt="Screenshot 2025-12-03 171650" src="https://github.com/user-attachments/assets/969d1231-e186-4647-9ac6-df504727605a" />


--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

9. Usuario_0

<img width="783" height="346" alt="Screenshot 2025-12-03 144437" src="https://github.com/user-attachments/assets/35f50211-e428-45b8-8e67-c92d10ebd655" />

--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

10. Dashboard

<img width="833" height="233" alt="CargarUltimasCitas" src="https://github.com/user-attachments/assets/71aabffd-4903-4942-8815-01ad784017a7" />

<img width="1159" height="309" alt="DashboardLoad" src="https://github.com/user-attachments/assets/f98c78df-de05-4d28-bc3e-bbf5afcf74d3" />

<img width="994" height="619" alt="MostrarGraficas" src="https://github.com/user-attachments/assets/fc4ebdd6-ac29-463f-b71c-167c2e79b267" />

<img width="745" height="99" alt="RelojTimer" src="https://github.com/user-attachments/assets/51928895-4d8c-4789-8179-07f7b77dbbc0" />

<img width="955" height="479" alt="MostrarTotales" src="https://github.com/user-attachments/assets/c8d61e85-ddc4-459f-abc5-fe22136d1d02" />

--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

11. Backup
    
<img width="1107" height="625" alt="BtnRestore" src="https://github.com/user-attachments/assets/641658bb-f50e-4789-b77e-0b04c08032b5" />

<img width="1119" height="642" alt="BtnBackup" src="https://github.com/user-attachments/assets/507ac188-e82b-4c1e-abbb-8b6bd7359331" />

--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

12. Reportes

<img width="1230" height="192" alt="Screenshot 2025-12-03 144711" src="https://github.com/user-attachments/assets/b1624d8d-a15a-4305-9f72-c87b36abb723" />

<img width="424" height="435" alt="Screenshot 2025-12-03 144652" src="https://github.com/user-attachments/assets/74765adc-14f9-4b2b-8be0-0715dc9b87fc" />

<img width="823" height="749" alt="Screenshot 2025-12-03 144643" src="https://github.com/user-attachments/assets/4cf6b25c-5510-4a5e-9912-db42429c0e19" />

<img width="834" height="404" alt="Screenshot 2025-12-03 144635" src="https://github.com/user-attachments/assets/737c5826-aa02-4f8b-84f2-0214f4aa18d1" />

<img width="622" height="450" alt="Screenshot 2025-12-03 144626" src="https://github.com/user-attachments/assets/aa876b06-ceba-4eec-b0ac-5cf598815700" />

<img width="718" height="140" alt="Screenshot 2025-12-03 144616" src="https://github.com/user-attachments/assets/d27b7e4e-e870-43d6-b677-5255ec789df4" />

<img width="592" height="228" alt="Screenshot 2025-12-03 144608" src="https://github.com/user-attachments/assets/9375458b-609f-4381-929d-c6130f799301" />

<img width="740" height="853" alt="Screenshot 2025-12-03 144558" src="https://github.com/user-attachments/assets/929d81ce-e50f-4d79-95be-2fe15c3a48a0" />

<img width="711" height="451" alt="Screenshot 2025-12-03 144529" src="https://github.com/user-attachments/assets/fd229469-da71-4780-a127-9cd1bfddc702" />

--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
