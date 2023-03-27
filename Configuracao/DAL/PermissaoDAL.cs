using Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class PermissaoDAL
    {
        public void inserir(Permissao _permissao)
        {
            SqlConnection cn = new SqlConnection(Conexao.StringDeConexao);

            try
            {
                SqlCommand cmd = cn.CreateCommand();
                cmd.CommandText = @"INSERT INTO Usuario(Descricao)
                                  VALUE(@Descricao )";
                cmd.Parameters.AddWithValue("@Descricao", _permissao.descricao);
                
                cmd.Connection = cn;
                cn.Open();
                cmd.ExecuteNonQuery();


            }
            catch (Exception ex)
            {
                throw new Exception("Ocorreu erro ao tentar inserir uma permissão no banco de dados. Por favor verifique sua conexão", ex);
            }
            finally
            {
                cn.Close();
            }

        }
        public void Alterar(Permissao _permissao)
        {
            SqlConnection cn = new SqlConnection(Conexao.StringDeConexao);

            try
            {
                SqlCommand cmd = cn.CreateCommand();
                cmd.CommandText = "update Usuario set Descricao = @Descricao WHERE Id = @id";
                cmd.CommandType = System.Data.CommandType.Text;

                cmd.Parameters.AddWithValue("@Id", _permissao.IdPermissao);
                cmd.Parameters.AddWithValue("@Descricao", _permissao.descricao);
                
                cmd.Connection = cn;
                cn.Open();
                cmd.ExecuteNonQuery();


            }
            catch (Exception ex)
            {
                throw new Exception("Ocorreu erro ao tentar alterar uma permissão no banco de dados. Por favor verifique sua conexão", ex);
            }
            finally
            {
                cn.Close();
            }
        }
        public void Excluir(int _id)
        {
            SqlConnection cn = new SqlConnection(Conexao.StringDeConexao);
            try
            {
                SqlCommand cmd = cn.CreateCommand();
                cmd.CommandText = "DELETE FROM Permissao WHERE Id = @Id";
                cmd.CommandType = System.Data.CommandType.Text;

                cmd.Parameters.AddWithValue("@Id", _id);

                cmd.Connection = cn;
                cn.Open();
                cmd.ExecuteNonQuery();

            }
            catch (Exception ex)
            {
                throw new Exception("Ocorreu erro ao tentar excluir uma permissão no banco de dados. Por favor verifique sua conexão", ex);
            }
            finally
            {
                cn.Close();
            }

        }
        public List<Permissao> BuscarPorTodos()
        {
            SqlConnection cn = new SqlConnection(Conexao.StringDeConexao);
            List<Permissao> permissoes = new List<Permissao >();
            Permissao permissao;
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = cn;
                cmd.CommandText = "SELECT Id, Descricao";
                cmd.CommandType = System.Data.CommandType.Text;

                cn.Open();
                using (SqlDataReader rd = cmd.ExecuteReader())
                {
                    while (rd.Read())
                    {
                       permissao = new Permissao();
                        permissao.IdPermissao = Convert.ToInt32(rd["Id"]);
                        permissao.descricao = rd["descricao "].ToString();
                        
                        

                        permissoes.Add(permissao);
                    }
                }
                return permissoes;
            }
            catch (Exception ex)
            {
                throw new Exception("Ocorreu um erro ao tentar buscar todas as permissoes no banco de dados. Por favor verifique sua conexao", ex);
            }
            finally
            {
                cn.Close();
            }

        }
        public List<Permissao> BuscarPorDescricao(string _descricao)
        {

            SqlConnection cn = new SqlConnection(Conexao.StringDeConexao);
            List<Permissao> permissoes = new List<Permissao>();
            Permissao permissao = new Permissao ();


            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = cn;
                cmd.CommandText = "SELECT Id, NomeGrupo FROM GrupoUsuario WHERE Descricao LIKE @Descricao";
                cmd.CommandType = System.Data.CommandType.Text;
                cmd.Parameters.AddWithValue("@Descricao", "%" + _descricao + "%");
                cn.Open();
               
                using (SqlDataReader rd = cmd.ExecuteReader())
                {
                    while (rd.Read())
                    {
                        permissao = new Permissao();
                        permissao.IdPermissao = Convert.ToInt32(rd["Id"]);
                        permissao.descricao = rd["descricao "].ToString();
                        permissoes.Add(permissao);
                    }
                }

                return permissoes;
            }

            catch (Exception ex)
            {
                throw new Exception("Ocorreu um erro ao tentar buscar todas as permissoes no banco de dados.Por favor verifique sua conexão", ex);
            }
            finally
            {
                cn.Close();
            }
        }

        public List<Permissao> BuscarPorId(int _id)
        {
            SqlConnection cn = new SqlConnection(Conexao.StringDeConexao);
            List<Permissao> permissoes = new List<Permissao>();
            Permissao permissao;
            try
            {

                SqlCommand cmd = new SqlCommand();
                cmd.Connection = cn;
                cmd.CommandText = "SELECT Id, NomeGrupo FROM GrupoUsuario WHERE Id LIKE @Id";
                cmd.CommandType = System.Data.CommandType.Text;
                cmd.Parameters.AddWithValue("Id", _id);
                cn.Open();
                
                using (SqlDataReader rd = cmd.ExecuteReader())
                {
                    while (rd.Read())
                    {
                        permissao = new Permissao();
                        permissao.IdPermissao = Convert.ToInt32(rd["Id"]);
                        permissao.descricao = rd["descricao "].ToString();
                        permissoes.Add(permissao);
                    }
                }

                return permissoes;

            }
            catch (Exception ex)
            {
                throw new Exception("Ocorreu um erro ao tentar buscar permissoes por Id no banco de dados. Por favor verifique sua conexão", ex);
            }
            finally
            {
                cn.Close();
            }

        }  
    }


                   

}

