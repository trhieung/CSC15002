using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab3_QLSV
{
    public class SqlServer
    {
        private string SqlServerIPAdd = "localhost";
        private string port = "1433";
        private string DBName = "QLSV";
        private string username = null;
        private string password = null;

        public SqlServer(string username, string password, string sqlServerIPAdd = "localhost", string port = "1433")
        {
            this.SqlServerIPAdd = sqlServerIPAdd;
            this.port = port;
            this.username = username;
            this.password = password;
        }

        public bool Connect()
        {
            if (this.username == null || this.password == null)
            {
                throw new InvalidOperationException("Username or password is not set.");
            }

            //string connectionString = @"Data Source=" + this.SqlServerIPAdd + "," + this.port +
            //        ";Initial Catalog=" + "QLNV" +
            //        ";User ID=" + this.username +
            //        ";Password=" + this.password + ";";
            //string connectionString = "Data Source=127.0.0.1,1433;InitialCatalog=QLSV;User ID=BDAdmin;Password= ;";

            string connectionString = "Data Source=" + this.SqlServerIPAdd + "," + this.port+
                ";Initial Catalog="+ this.DBName + 
                ";Integrated Security=True;";
            string result = "";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand command = new SqlCommand("dbo.SP_CheckLogin", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@username", username);
                    command.Parameters.AddWithValue("@password", password);

                    connection.Open();

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            result = reader["Result"].ToString();
                        }
                    }
                }
            }

            if (result == "Success")
            {
                return true;
            }
            else
            {
                return false;
            }

        }

        public void Connect(string username, string password, string sqlServerIPAdd = "localhost", string port = "1433")
        {
            this.SqlServerIPAdd = sqlServerIPAdd;
            this.port = port;
            this.username = username;
            this.password = password;
            this.Connect();
        }
    }
}
