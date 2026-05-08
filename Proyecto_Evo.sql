CREATE DATABASE VentasDB;
GO

USE VentasDB;

CREATE TABLE Pedido (
    Id INT IDENTITY(1,1) PRIMARY KEY,
    Total DECIMAL(10,2),
    MetodoPago VARCHAR(50)
);

SELECT*FROM Pedido

CREATE TABLE Usuario (
    Id INT IDENTITY(1,1) PRIMARY KEY,
    Username VARCHAR(50),
    Password VARCHAR(50)
);

INSERT INTO Usuario (Username, Password)
VALUES ('admin', '1234');