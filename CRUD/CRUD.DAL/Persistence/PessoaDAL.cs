using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using CRUD.DAL.Model;

namespace CRUD.DAL.Persistence
{
    public class PessoaDAL : Conexao
    {
        //Metodo para gravar dados
        public void GravarDados(Pessoa pessoa)
        {
            try
            {
                //Abrir conexao
                AbrirConexao();
                Command = new SqlCommand("INSERT INTO PESSOA (Nome,Endereco,Email) values(@v1,@v2,@v3)", Connection);

                Command.Parameters.AddWithValue("@v1", pessoa.Nome);
                Command.Parameters.AddWithValue("@v2", pessoa.Endereco);
                Command.Parameters.AddWithValue("@v3", pessoa.Email);

                Command.ExecuteNonQuery();

                //Fechar Conexao
                FecharConexao();

            }
            catch (Exception ex)
            {

                throw new Exception("Erro ao gravar dados: " + ex.Message);
            }
            finally
            {
                //Fechar conexão
                FecharConexao();
            }
        }

        public int Atualizar(Pessoa pessoa)
        {
            int ret = -1;
            try
            {
                AbrirConexao();

                Command = new SqlCommand("UPDATE PESSOA  SET Nome=@v1, Endereco=@v2, Email=@v3 WHERE Codigo=@v4", Connection);
                Command.Parameters.AddWithValue("@v1", pessoa.Nome);
                Command.Parameters.AddWithValue("@v2", pessoa.Endereco);
                Command.Parameters.AddWithValue("@v3", pessoa.Email);
                Command.Parameters.AddWithValue("@v4", pessoa.Codigo);

                ret = Command.ExecuteNonQuery();

            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao atualizar pessoa:" + ex.Message);
            }
            finally
            {
                FecharConexao();
            }

            return ret;
        }

        public void Excluir(int codigo)
        {
            try
            {
                AbrirConexao();

                Command = new SqlCommand("DELETE FROM PESSOA WHERE Codigo=@v1", Connection);
                Command.Parameters.AddWithValue("@v1", codigo);

                Command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {

                throw new Exception("Erro ao excluir pessoa:" + ex.Message);
            }
            finally
            {
                FecharConexao();
            }
        }

        public Pessoa ListarPessoa(int codigo)
        {
            try
            {
                AbrirConexao();

                Command = new SqlCommand("SELECT * FROM PESSOA WHERE Codigo=@v1", Connection);
                Command.Parameters.AddWithValue("@v1", codigo);

                DataReader = Command.ExecuteReader();

                Pessoa pessoa = null;

                if (DataReader.Read())
                {
                    pessoa = new Pessoa();
                    pessoa.Codigo = Convert.ToInt32(DataReader["Codigo"]);
                    pessoa.Nome = Convert.ToString(DataReader["Nome"]);
                    pessoa.Endereco = Convert.ToString(DataReader["Endereco"]);
                    pessoa.Email = Convert.ToString(DataReader["Email"]);
                }

                return pessoa;
            }
            catch (Exception ex)
            {

                throw new Exception("Erro ao tentar listar:" + ex.Message);
            }
            finally
            {
                FecharConexao();
            }
        }

        public List<Pessoa> ListarPessoas()
        {
            try
            {
                AbrirConexao();
                Command = new SqlCommand("SELECT * FROM PESSOA", Connection);

                DataReader = Command.ExecuteReader();

                List<Pessoa> pessoas = new List<Pessoa>();

                while (DataReader.Read())
                {
                    Pessoa pessoa = new Pessoa();
                    pessoa.Codigo = Convert.ToInt32(DataReader["Codigo"]);
                    pessoa.Email = Convert.ToString(DataReader["Email"]);
                    pessoa.Endereco = Convert.ToString(DataReader["Endereco"]);
                    pessoa.Nome = Convert.ToString(DataReader["Nome"]);

                    pessoas.Add(pessoa);
                }

                return pessoas;
            }
            catch (Exception ex)
            {

                throw new Exception("Erro ao listar todos:" + ex.Message);
            }
            finally
            {
                FecharConexao();
            }
        }

    }
}
