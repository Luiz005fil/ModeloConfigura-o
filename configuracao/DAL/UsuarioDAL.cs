using MODELS;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class UsuarioDAL
    {
        public void Inserir(Usuario _usuario)
        {
            SqlConnection cn = new SqlConnection(Conexao.StringDeConexao);
            try
            {
                SqlCommand cmd = cn.CreateCommand();
                cmd.CommandText = "INSERT INTO Usuario(Nome, NomeUsuario, Emal, CPF, Ativo, Senha) VALUES(@Nome, @NomeUsuaro, @Email, @CPF, @Ativo, @Senha)";

                cmd.CommandType = System.Data.CommandType.Text;
                cmd.Parameters.AddWithValue("@Nome", _usuario.Name);
                cmd.Parameters.AddWithValue("@NomeUsuario", _usuario.NomeUsuario);
                cmd.Parameters.AddWithValue("@Email", _usuario.Email);
                cmd.Parameters.AddWithValue("@Ativa", _usuario.Ativo);
                cmd.Parameters.AddWithValue("@Senha", _usuario.Senha);
            }
            catch(Exception ex)
            {
                throw new Exception("Ocorreu erro ao tentar inserir um usuário no banco de dados:", ex);
            }
            finally
            {
                cn.Close();
            }
        }
        public List<Usuario> BuscarTodos()
        {
            throw new NotImplementedException();
        }
        public List <Usuario> BuscarPorNomeUsuaio(string _nomeUsuario)
        {
            throw new NotImplementedException();
        }
        public List<Usuario> BuscarPorId(int _id)
        {
            throw new NotImplementedException();
        }
        public void Alterar (Usuario _usuario)
        {

        }
        public void Delete (int _id)
        {
            SqlConnection cn = new SqlConnection(Conexao.StringDeConexao);
            try
            {
                SqlCommand cmd = cn.CreateCommand();
                cmd.CommandText = "DELETE FROM Usuario WHERE Id = @Id";
                cmd.CommandType = System.Data.CommandType.Text;

                cmd.Parameters.AddWithValue("@Id", _id);

                cmd.Connection = cn;
                cn.Open();

                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new Exception("Ocorreu erro ao tentar excluir um usuário no banco de dados:", ex);
            }
            finally
            {
                cn.Close();
            }
        }
    }
}
