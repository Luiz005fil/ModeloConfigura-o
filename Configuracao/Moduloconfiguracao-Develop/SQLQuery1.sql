

INSERT INTO Permissao(Id, Descricao)VALUES(1,'Visualizar usuário')
INSERT INTO Permissao(Id, Descricao)VALUES(2,'Cadastrar Usuario')
INSERT INTO Permissao(Id, Descricao)VALUES(3,'Alterar usuário')
INSERT INTO Permissao(Id, Descricao)VALUES(4,'Excluir usuário')
INSERT INTO Permissao(Id, Descricao)VALUES(5,'Visualizar grupo de usuário')
INSERT INTO Permissao(Id, Descricao)VALUES(6,'Cadastrar grupo de usuário')
INSERT INTO Permissao(Id, Descricao)VALUES(7,'Alterar grupo de usuário')
INSERT INTO Permissao(Id, Descricao)VALUES(8,'Excluir grupo de usuário')
INSERT INTO Permissao(Id, Descricao)VALUES(9,'Adicionar permissão a um grupo de usuário')
INSERT INTO Permissao(Id, Descricao)VALUES(10,'Adicionar grupo de usuário a um usuário')

--UPDATE GrupoUsuario set NomeGrupo = 'Vendedor' WHERE Id = 2


 SELECT * FROM GrupoUsuario;
 INSERT INTO GrupoUsuario(NomeGrupo) VALUES('Gerente')
 INSERT INTO GrupoUsuario(NomeGrupo) VALUES('Vendedor')
 INSERT INTO GrupoUsuario(NomeGrupo) VALUES('Estoquista')
 INSERT INTO GrupoUsuario(NomeGrupo) VALUES('Fiscal de caixa')
 INSERT INTO GrupoUsuario(NomeGrupo) VALUES('Operador de caixa')


 
 SELECT * FROM Usuario
 SELECT * FROM GrupoUsuario
 SELECT * FROM Permissao
 SELECT * FROM PermissaoGrupoUsuario
 SELECT * FROM UsuarioGrupoUsuario

INSERT INTO PermissaoGrupoUsuario(IdGrupoUsuario , IdPermissao)VALUES(1,1)
INSERT INTO PermissaoGrupoUsuario(IdGrupoUsuario , IdPermissao)VALUES(1,2)
INSERT INTO PermissaoGrupoUsuario(IdGrupoUsuario , IdPermissao)VALUES(1,3)
INSERT INTO PermissaoGrupoUsuario(IdGrupoUsuario , IdPermissao)VALUES(1,4)
INSERT INTO PermissaoGrupoUsuario(IdGrupoUsuario , IdPermissao)VALUES(1,5)
INSERT INTO PermissaoGrupoUsuario(IdGrupoUsuario , IdPermissao)VALUES(1,6)
INSERT INTO PermissaoGrupoUsuario(IdGrupoUsuario , IdPermissao)VALUES(1,7)
INSERT INTO PermissaoGrupoUsuario(IdGrupoUsuario , IdPermissao)VALUES(1,8)
INSERT INTO PermissaoGrupoUsuario(IdGrupoUsuario , IdPermissao)VALUES(1,9)
INSERT INTO PermissaoGrupoUsuario(IdGrupoUsuario , IdPermissao)VALUES(1,10)

INSERT INTO UsuarioGrupoUsuario(IdUsuario,IdGrupoUsuario) VALUES(1,1)

 
 
 
SELECT * FROM Usuario
SELECT * FROM UsuarioGrupoUsuario


  DECLARE @IdUsuario INT = 1
  DECLARE @IdPermissao INT = 10
  DECLARE


 SELECT 1 FROM PermissaoGrupoUsuario
INNER JOIN UsuarioGrupoUsuario ON PermissaoGrupoUsuario.IdGrupoUsuario = UsuarioGrupoUsuario.IdGrupoUsuario
 WHERE UsuarioGrupoUsuario.IdUsuario = @IdUsuario AND PermissaoGrupoUsuario.IdPermissao = @IdPermissao