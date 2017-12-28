INSERT INTO Cliente (DNI, Nombre, Apellido, Direccion)
VALUES (10000, 'Federico', 'Borja', 'Av.olivos')

go

INSERT INTO Estado (Id_Estado, Estado)
VALUES (1, 'Entregado')

go

INSERT INTO MedioDeEnvio (Id_Medio, Nombre, PesoMaximo)
VALUES (4, 'Camioneta', 455)

go

INSERT INTO Categoria (Id_Categoria, Descripcion)
VALUES (1222, 'Articulos del hogar')

go

INSERT INTO Provincias(IdProvincia, Nombre)
VALUES (1, 'BUENOS AIRES')

go

INSERT INTO Sucursal(Id_Provincia, Cod_Sucursal)
SELECT 1, 1000 UNION
SELECT 1, 2000

go

INSERT INTO Costos(Id_cat, Id_medio, Costo)
VALUES (1222, 4, 4363)

go

INSERT INTO Envios(DNI, Cod_Envio, Id_cat, Id_medio, Sucursal_Envia, Sucursal_Recibe, Descripcion)
VALUES (10000, 1111, 1222, 4, 1000, 2000, 'Paquete chico')

go

INSERT INTO Seguimiento(Id_estado, Cod_Envio, Id_Seguimiento, dia, mes, año)
VALUES (1, 1111, 123, 23, 4, 1990)

go