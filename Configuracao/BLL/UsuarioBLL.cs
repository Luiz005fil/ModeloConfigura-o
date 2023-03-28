using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using DAL;
using Models;

namespace BLL
{
    public class UsuarioBLL
    {
        public void Inserir(Usuario _usuario, string _confirmacao)
        {
            ValidarPermissao(2);
            ValidarDados(_usuario, _confirmacao);

            UsuarioDAL usuarioDAL = new UsuarioDAL();
            usuarioDAL.Inserir(_usuario);
        }


        public void Alterar(Usuario _usuario, string _confirmacao)

        {
            ValidarPermissao(3);
            ValidarDados(_usuario, _confirmacao);

            UsuarioDAL usuarioDAL = new UsuarioDAL();
            usuarioDAL.Alterar(_usuario);
        }
        public void Excluir(int _id)
        {

            ValidarPermissao(4);
            new UsuarioDAL().Excluir(_id);
        }
        public List<Usuario> BuscarTodos()
        {
            ValidarPermissao(1);
            return new UsuarioDAL().BuscarPorTodos();
        }
        public List<Usuario> BuscarPorId(int _id)
        {
            ValidarPermissao(1);
            return new UsuarioDAL().BuscarPorId(_id);
        }
        public List<Usuario> BuscarPorCPF(string _cpf)
        {
            ValidarPermissao(1);
            return new UsuarioDAL().BuscarPorCPF(_cpf);
        }
        public List<Usuario> BuscarPorNome(string _nome)
        {
            ValidarPermissao(1);
            return new UsuarioDAL().BuscarPorNome(_nome);
        }
        public Usuario BuscarPorNomeUsuario(string _nomeUsuario)
        {
            ValidarPermissao(1);
            return new UsuarioDAL().BuscarPorNomeUsuario(_nomeUsuario);
        }
        private void ValidarDados(Usuario _usuario, string _confirmacao)

        {
            if (_usuario.Senha != _confirmacao)
            {
                throw new Exception("As senhas devem ser iguais.");
            }
            if (_usuario.Senha.Length <= 3)
            {
                throw new Exception("A senha deve ter mais de 3 caracteres.");
            }
            if (_usuario.Nome.Length <= 2)
            {
                throw new Exception("A nome  deve ter mais de 2 caracteres.");
            }
        }
        public void ValidarPermissao(int _idPermissao)
        {
            //if (!new UsuarioDAL().ValidarPermissao(Contantes.IdUsuarioLogado, _idPermissao))
            //throw new Exception("Você não tem permissão de realizar essa operação. Procure o administrador do sistema.");

        }

        public void AdicionarGrupoUsuario(int _idUsuario, int IdGrupoUsuario)
        {
            {
                if (!new UsuarioDAL().UsuarioPertenceAoGrupo(_idUsuario, IdGrupoUsuario))
                    new UsuarioDAL().AdicionaGrupoUsuario(_idUsuario, IdGrupoUsuario);
            }
            
        }
        public void RemoverGrupoUsuario(int _idUsuario, int _idGrupoUsuario)
        {
            new UsuarioDAL().RemoverGrupoUsuario(_idUsuario, _idGrupoUsuario);
        }

        public void Altenticar(string _nomeUsuario, string _senha)
        {
            Usuario usuario = new UsuarioDAL().BuscarPorNomeUsuario(_nomeUsuario);

            if (_senha == usuario.Senha && usuario.Ativo)
            {
                Constantes.IdUsuarioLogado = usuario.Id;
            }
            else
            {
                throw new Exception("Usuario ou senha inválida.");
            }
        }

    }
}

