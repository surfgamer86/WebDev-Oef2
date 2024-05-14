using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.Common;
using System.Configuration;
namespace WebDev_Oef2_Domain
{
    class Persistence
    {
        DbConnection connection;
        private void openConn()
        {
            string providerName = ConfigurationManager.ConnectionStrings["SQL"].ProviderName;
            string connectionString = ConfigurationManager.ConnectionStrings["SQL"].ConnectionString;

            DbProviderFactory factory = DbProviderFactories.GetFactory(providerName);
            connection = factory.CreateConnection();
            connection.ConnectionString = connectionString;
            connection.Open();
        }
        private void closeConn()
        {
            connection.Close();
        }
        public int AddUser(Business.User user)
        {
            openConn();
            string sql = "INSERT INTO [Table] (Naam, Email) VALUES (@Name, @Email)";
            DbCommand cmd = connection.CreateCommand();

            cmd.CommandText = sql;
            cmd.CommandType = CommandType.Text;

            DbParameter pName = cmd.CreateParameter();
            pName.ParameterName = "@Name";
            pName.Value = user.Naam;
            cmd.Parameters.Add(pName);

            DbParameter pEmail = cmd.CreateParameter();
            pEmail.ParameterName = "@Email";
            pEmail.Value = user.Mail;
            cmd.Parameters.Add(pEmail);

            int result = cmd.ExecuteNonQuery();

            closeConn();

            return result;
        }
    }
}
