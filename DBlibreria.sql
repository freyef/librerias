CREATE DATABASE LibreriaLosLectores;
USE LibreriaLosLectores;

CREATE TABLE Clientes (
    ClienteID INT PRIMARY KEY IDENTITY,
    Nombre NVARCHAR(100),
    Genero NVARCHAR(10)
);

CREATE TABLE Libros (
    LibroID INT PRIMARY KEY IDENTITY,
    Titulo NVARCHAR(100),
    TipoLibro INT,
    Precio DECIMAL(10, 2)
);

CREATE TABLE Ventas (
    VentaID INT PRIMARY KEY IDENTITY,
    ClienteID INT,
    LibroID INT,
    Cantidad INT,
    ImporteBruto DECIMAL(10, 2),
    MontoDescuento DECIMAL(10, 2),
    ImporteNeto DECIMAL(10, 2),
    CONSTRAINT FK_Ventas_Clientes FOREIGN KEY (ClienteID) REFERENCES Clientes(ClienteID),
    CONSTRAINT FK_Ventas_Libros FOREIGN KEY (LibroID) REFERENCES Libros(LibroID)
);

