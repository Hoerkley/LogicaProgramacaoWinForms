CREATE DATABASE dbTechProd
ON PRIMARY(
NAME = dbTechProd,
FILENAME = 'D:\Hoerkley - atividade avaliativa\dbTechProd.mdf',
SIZE = 10MB,
MAXSIZE = 30MB,
FILEGROWTH = 10%
);
GO
USE dbTechProd;
GO

CREATE TABLE tblCargo
(
	codCargo INT PRIMARY KEY IDENTITY(10,1),
	descricao VARCHAR(50) NOT NULL
);

CREATE TABLE tblFuncionario
(
	codFuncionario INT PRIMARY KEY IDENTITY(11,1),
	loginFuncionario VARCHAR(50) NOT NULL,
	senha VARCHAR(50),
	nome VARCHAR(50) NOT NULL,
	codCargo INT NOT NULL,
	FOREIGN KEY(codCargo) REFERENCES
	tblCargo(codCargo),
	salarioBase MONEY NOT NULL
);

CREATE TABLE tblProducao
(
	codProducao INT PRIMARY KEY IDENTITY(11,1),
	tEntrega DATETIME NOT NULL,
	mes VARCHAR(50) NOT NULL,
	inconsistencias INT NOT NULL,
	hrExtras INT NOT NULL,
	valorReceber MONEY NOT NULL,
	codFuncionario INT NOT NULL,
	FOREIGN KEY(codFuncionario) REFERENCES
	tblFuncionario(codFuncionario)
);

BULK
INSERT tblCargo
FROM 'D:\Hoerkley - atividade avaliativa\tblCargo.txt'
WITH
(FIRSTROW = 2,
FIELDTERMINATOR = ';',
ROWTERMINATOR = '\n',
CODEPAGE = '1252')

BULK
INSERT tblFuncionario
FROM 'D:\Hoerkley - atividade avaliativa\tblFuncionario.txt'
WITH
(FIRSTROW = 2,
FIELDTERMINATOR = ';',
ROWTERMINATOR = '\n',
CODEPAGE = '1252')