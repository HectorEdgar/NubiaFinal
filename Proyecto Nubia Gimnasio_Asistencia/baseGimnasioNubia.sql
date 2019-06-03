/*
Created		23/09/2016
Modified		26/10/2016
Project		
Model			
Company		
Author		
Version		
Database		MS SQL 2000 
*/

create database Sistema_Gimnasio
go
use Sistema_Gimnasio
go

/*
Created		23/09/2016
Modified		04/11/2016
Project		
Model			
Company		
Author		
Version		
Database		MS SQL 2000 
*/


Drop table [Usuario] 
go
Drop table [Asistencia] 
go
Drop table [Alumnos_GrupoGimnasio] 
go
Drop table [HorarioGimnasio_Horas] 
go
Drop table [Horas] 
go
Drop table [HorarioGimnasio] 
go
Drop table [GrupoGimnasio] 
go
Drop table [Grupo] 
go
Drop table [Licenciatura] 
go
Drop table [Alumno] 
go


Create table [Alumno]
(
	[Matricula] Varchar(10) NOT NULL,
	[idGrupo] Integer NOT NULL,
	[Nombre] Varchar(100) NULL,
	[Apellidos] Varchar(100) NULL,
	[Edad] Char(10) NULL,
Primary Key ([Matricula])
) 
go

Create table [Licenciatura]
(
	[IdLicenciatura] Integer identity NOT NULL,
	[Nombre] Varchar(100) NULL,
Primary Key ([IdLicenciatura])
) 
go

Create table [Grupo]
(
	[Nombre] Varchar(100) NOT NULL,
	[IdLicenciatura] Integer NOT NULL,
	[idGrupo] Integer identity NOT NULL,
	[semestre] Varchar(100) NOT NULL,
Primary Key ([idGrupo])
) 
go

Create table [GrupoGimnasio]
(
	[idGimnasio] Integer identity NOT NULL,
	[nombre] Varchar(100) NULL,
	[IdHorario] Integer NOT NULL,
Primary Key ([idGimnasio])
) 
go

Create table [HorarioGimnasio]
(
	[IdHorario] Integer identity NOT NULL,
	[nombre] Varchar(100) NULL,
Primary Key ([IdHorario])
) 
go

Create table [Horas]
(
	[IdHora] integer identity NOT NULL,
	[HoraInicio] Datetime NOT NULL,
	[HoraFin] Datetime NOT NULL,
Primary Key ([IdHora])
) 
go

Create table [HorarioGimnasio_Horas]
(
	[IdHorarioGimnasio_Horas] integer identity NOT NULL,
	[IdHora] Integer NOT NULL,
	[IdHorario] Integer NOT NULL,
	[Dia] Varchar(10) NOT NULL,
	primary key([IdHorarioGimnasio_Horas])
) 
go

Create table [Alumnos_GrupoGimnasio]
(
	[Alumnos_GrupoGimnasio] integer identity NOT NULL,
	[Matricula] Varchar(8) NOT NULL,
	[idGimnasio] Integer NOT NULL,
Primary Key ([Matricula],[idGimnasio],[Alumnos_GrupoGimnasio])
) 
go

Create table [Asistencia]
(
	[Asistencia] Integer identity not null,
	[Fecha] Datetime NOT NULL,
	[Estado] Varchar(10) NOT NULL,
	[Matricula] Varchar(8) NOT NULL,
	[idGimnasio] Integer NOT NULL,
	Primary key ([Asistencia])
) 
go

Create table [Usuario]
(
	[nombreUsuario] Varchar(100) NOT NULL,
	[Contraseña] Varchar(100) NOT NULL,
	[Nombre] Varchar(100) NOT NULL,
	[Apellidos] Varchar(100) NOT NULL,
Primary Key ([nombreUsuario])
) 
go


Alter table [Alumnos_GrupoGimnasio] add  foreign key([Matricula]) references [Alumno] ([Matricula])  on update cascade on delete cascade 
go
Alter table [Grupo] add  foreign key([IdLicenciatura]) references [Licenciatura] ([IdLicenciatura])  on update cascade on delete cascade 
go
Alter table [Alumno] add  foreign key([idGrupo]) references [Grupo] ([idGrupo])  on update cascade on delete cascade 
go
Alter table [Alumnos_GrupoGimnasio] add  foreign key([idGimnasio]) references [GrupoGimnasio] ([idGimnasio])  on update cascade on delete cascade 
go
Alter table [HorarioGimnasio_Horas] add  foreign key([IdHorario]) references [HorarioGimnasio] ([IdHorario])  on update cascade on delete cascade 
go
Alter table [GrupoGimnasio] add  foreign key([IdHorario]) references [HorarioGimnasio] ([IdHorario])  on update cascade on delete cascade 
go
Alter table [HorarioGimnasio_Horas] add  foreign key([IdHora]) references [Horas] ([IdHora])  on update cascade on delete cascade 
go
Alter table [Asistencia] add  foreign key([Matricula],[idGimnasio]) references [Alumnos_GrupoGimnasio] ([Matricula],[idGimnasio])  on update cascade on delete cascade 
go





Set quoted_identifier on
go


Set quoted_identifier off
go


/* Roles permissions */


/* Users permissions */


