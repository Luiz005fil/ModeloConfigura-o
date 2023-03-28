USE Configuracao
GO


DECLARE @Idusuario INT = 14
 
SELECT GrupoUsuario.Id, GrupoUsuario.NomeGrupo FROM GrupoUsuario
INNER JOIN UsuarioGrupoUsuario ON GrupoUsuario.Id = UsuarioGrupoUsuario.IdGrupoUsuario
WHERE UsuarioGrupoUsuario.IdUsuario = @Idusuario

SELECT 1 FROM UsuarioGrupo WHERE IdUsuario = @IdUsuario AND IdgrupoUsuario = 