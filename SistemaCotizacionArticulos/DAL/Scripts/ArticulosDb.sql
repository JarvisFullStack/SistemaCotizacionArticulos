CREATE DATABASE ArticulosDb
GO
USE ArticulosDb
GO
CREATE TABLE Articulo
(
	ArticuloID int primary key identity,
	FechaVencimiento date,
	Descripcion varchar(max),
	Precio float,
	Existencia integer,
	CantidadCotizada integer

);