using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace ReaderOfFileDAL
{
    public class ConexaoDAL
    {
        private const String strConnection = @"Server=.\SQLEXPRESS;Database=dbatvdade;Integrated Security=SSPI;";

        private SqlConnection sqlConnection;

        public ConexaoDAL()
        {
            SqlConnection = new SqlConnection(StrConnection);
        }

        public String StrConnection
        {
            get { return strConnection; }
        }           

        public SqlConnection SqlConnection
        {
            get { return sqlConnection; }
            set { sqlConnection = value; }
        }

        public void openConnection()
        {
            try
            {
                SqlConnection.Open();
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao abrir a conexão: " + ex.Message);
            }
        }

        public void closeConnection()
        {
            try
            {
                SqlConnection.Close();
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao fechar a conexão: " + ex.Message);
            }
            finally
            {
                SqlConnection.Dispose();
            }
        }
    }
}
