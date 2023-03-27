USE master
drop database Configuracao
GO

CREATE DATABASE Configuracao
GO

USE Configuracao
GO

CREATE TABLE Usuario
(
	Id INT PRIMARY KEY IDENTITY(1,1),
	Nome VARCHAR(150),
	NomeUsuario VARCHAR(50),
	Email VARCHAR(150),
	CPF VARCHAR(15),
	Ativo BIT,
	Senha VARCHAR(50)
)
GO

CREATE TABLE GrupoUsuario
(
	Id INT PRIMARY KEY IDENTITY(1,1),
	NomeGrupo VARCHAR(150)
)
GO

CREATE TABLE Permissao
(
	Id INT PRIMARY KEY IDENTITY(1,1),
	Descricao VARCHAR(250)
)
GO

CREATE TABLE UsuarioGrupoUsuario
(
	IdUsuario INT,
	IdGrupoUsuario INT,
	CONSTRAINT PK_UsuarioGrupoUsuario PRIMARY KEY (IdUsuario, IdGrupoUsuario)
)
GO

CREATE TABLE PermissaoGrupoUsuario
(
	IdPermissao INT,
	IdGrupoUsuario INT,
	CONSTRAINT PK_PermissaoGrupoUsuario PRIMARY KEY (IdPermissao, IdGrupoUsuario)
)
GO

ALTER TABLE UsuarioGrupoUsuario
ADD CONSTRAINT FK_UsuarioGrupoUsuario_Usuario
FOREIGN KEY (IdUsuario) REFERENCES Usuario(Id)

GO

ALTER TABLE UsuarioGrupoUsuario
ADD CONSTRAINT FK_UsuarioGrupoUsuario_GrupoUsuario
FOREIGN KEY (IdGrupoUsuario) REFERENCES GrupoUsuario(Id)

GO

ALTER TABLE PermissaoGrupoUsuario
ADD CONSTRAINT FK_PermissaoGrupoUsuario_Permissao
FOREIGN KEY (IdPermissao) REFERENCES Permissao(Id)

GO

ALTER TABLE PermissaoGrupoUsuario
ADD CONSTRAINT FK_PermissaoGrupoUsuario_GrupoUsuario
FOREIGN KEY (IdGrupoUsuario) REFERENCES GrupoUsuario(Id)

GO
Select * from Usuario;