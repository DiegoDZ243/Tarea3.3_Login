create database appUsuarios;
use appUsuarios;

create table usuarios(
	clave 		int				primary key 	auto_increment,
    usuario		varchar(80)		not null		unique,
    password	varchar(64)	not null, 
	nombre		varchar(60)		not null,
    aPaterno	varchar(30)		not null,
    aMaterno	varchar(30)		not null,
	email		varchar(80)		not null,
    fechaNac	date			not null,
    fechaCreacion	timestamp 	default 	current_timestamp,
    ultimoLogeo		timestamp	default 	current_timestamp
);

insert into usuarios (usuario,password,nombre,aPaterno,aMaterno,email,fechaNac) values 
('root',sha2('root',256),'Diego','Díaz','Zamudio','diegoRoot@gmail.com','2003-03-24'),
('eddy',sha2('ayuda123',256),'Ed','Camarena','Vega','ed@g.com','2010-12-31'),
('me',sha2('ayuda123',256),'Juan','Perez','Perez','aklk@gmail.com','2007-02-03'),
('rich',sha2('thispassword',256),'Richard','Mode','Burnwater','rich@gmail.com','1999-12-31'),
('juanapp',sha2('holamundo123',256),'Juana','Pérez','Pérez','junapp@gmail.com','2001-08-12'),
('franAyala',sha2('holamundo123',256),'Francisco','Ayala','Molina','franA@gmail.com','2009-07-31');

create view vwUsuarios as
select nombre as Nombre,
aPaterno `Apellido paterno`,
aMaterno `Apellido materno`,
usuario as Usuario,
email as Email,
date_format(fechaNac,'%d/%m/%Y') `Fecha de Naciemiento`,
date_format(fechaCreacion,'%d/%m/%Y') `Creación de cuenta`,
date_format(ultimoLogeo,'%d/%m/%Y') `Último logeo`from usuarios;

select * from vwUsuarios;