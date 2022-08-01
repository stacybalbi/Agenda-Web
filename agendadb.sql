
CREATE DATABASE Agendadb
GO
USE agendadb

GO
CREATE TABLE telefono (
id INT PRIMARY KEY IDENTITY,
telefono VARCHAR(50),
id_usuario_tel INT,
CONSTRAINT fk_usuario FOREIGN KEY (id_usuario_tel) REFERENCES usuario (id)
)
GO
CREATE TABLE email (
id INT PRIMARY KEY IDENTITY,
email VARCHAR(50),
id_usuario_email INT,
CONSTRAINT fk_usuario FOREIGN KEY (id_usuario_email) REFERENCES usuario (id)
)

GO
CREATE TABLE usuario (
visible BIT NOT NULL,
id int IDENTITY(1,1) PRIMARY KEY ,
nombre VARCHAR(50),
apellido VARCHAR(50),
cedula VARCHAR(50),
direccion VARCHAR(200),
telefono VARCHAR(50),
email VARCHAR(50)
)


--cambiar valor de false a true del campo visible
UPDATE usuario SET visible = 1 WHERE visible = 0;

--mostrar tabla de contactos
SELECT * FROM usuario;