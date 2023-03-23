SELECT*FROM Configuracao..GrupoUsuario

USE Configuracao
GO

SELECT Id,Nomegrupo FROM GrupoUsuario WHERE Nomegrupo = @Nomegrupo