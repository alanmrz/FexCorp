USE master;
go
create database Envios
go
Use [Envios]
go
create table Cliente
(
DNI varchar(13)PRiMARY KEY NOT NULL,
Nombre varchar(20) NOT NULL,
Apellido varchar(30) NOT NULL,
Direccion varchar(40) NOT NULL

)
go

create table Estado
(
Id_Estado Int PRiMARY KEY NOT NULL,
Estado varchar(20) NOT NULL

)
go

create table MedioDeEnvio
(
Id_Medio Int PRiMARY KEY NOT NULL,
Nombre varchar(20) NOT NULL,
PesoMaximo float NOT NULL

)
go

create table Categoria
(
Id_Categoria int PRiMARY KEY NOT NULL,
Descripcion varchar(40) NOT NULL

)
go

create table Provincias
(
IdProvincia Int PRiMARY KEY NOT NULL,
Nombre varchar(40) NOT NULL

)
go

create table Sucursal
(
Cod_Sucursal int PRiMARY KEY NOT NULL,
Id_Provincia int NOT NULL references provincias(IdProvincia)

)
go

create table Costos
(
Id_cat int  NOT NULL references Categoria(Id_Categoria),
Id_medio int NOT NULL references MedioDeEnvio(Id_Medio),
Costo int not null,
constraint Pk_costo primary key (Id_cat,Id_Medio)
)
go

create table Seguimiento
(
Id_estado int  NOT NULL references Estado(Id_Estado),
Cod_Envio int NOT NULL references Envios(Cod_Envio),
Id_Seguimiento int not null,
dia int not null,
mes int not null,
año int not null,
constraint Pk_segui primary key (Id_Seguimiento,Cod_Envio)
)
go
create table Envios
(
DNI varchar(13) NOT NULL references Cliente(DNI),
Cod_Envio int primary key NOT NULL,
Id_cat int  NOT NULL,
Id_medio int NOT NULL,
Sucursal_Envia int  NOT NULL  references Sucursal(Cod_Sucursal),
Sucursal_Recibe int  NOT NULL  references Sucursal(Cod_Sucursal),
Descripcion varchar(50) not null,
constraint fk_costo foreign key(Id_cat, Id_medio) references Costos(Id_cat, Id_medio),

)
go