using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Configuration;

namespace CRUD.DAL.Persistence
{
    public class Conexao
    {
        protected SqlConnection Connection { get; set; }
        protected SqlCommand Command { get; set; }
        protected SqlDataReader DataReader { get; set; }

        //Método para abrir conexão

        protected void AbrirConexao()
        {
            try
            {
                string connectionString = ConfigurationManager.ConnectionStrings["Default"].ConnectionString;
                Connection = new SqlConnection(connectionString);
                Connection.Open();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        protected void FecharConexao()
        {
            try
            {
                if (Connection != null)
                    Connection.Close();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
