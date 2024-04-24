using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab4_QLSV
{
    internal class database
    {
        private string SqlServerIPAdd = "localhost";
        private string port = "1433";
        private string DBName = "QLSVNhom";
        private string username = null;
        private string password = null;
        private SqlConnection conn = null;

        private string sql = null;
        private DataTable dt = null;
        private SqlCommand cmd = null;
        private SqlDataReader reader = null;
        private SqlDataAdapter ad = null;

        public database(string sqlServerIPAdd = "localhost", string port = "1433", string DBName = "QLSVNhom", string username = null, string password = null)
        {
            this.SqlServerIPAdd = sqlServerIPAdd;
            this.port = port;
            this.DBName = DBName;
            this.username = username;
            this.password = password;


            //string connectionString = @"Data Source=" + this.SqlServerIPAdd + "," + this.port +
            //        ";Initial Catalog=" + "QLNV" +
            //        ";User ID=" + this.username +
            //        ";Password=" + this.password + ";";
            //string connectionString = "Data Source=127.0.0.1,1433;InitialCatalog=QLSV;User ID=BDAdmin;Password= ;";

            string connectionString = "Data Source=" + this.SqlServerIPAdd + "," + this.port +
                ";Initial Catalog=" + this.DBName +
                ";Integrated Security=True;";

            try
            {
                conn = new SqlConnection(connectionString);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Connection fail", ex.Message);
            }
        }

        public bool Connect(string tendn, string mk)
        {
            if (tendn == null || mk == null)
            {
                throw new InvalidOperationException("Username or password is not set.");
            }

            string connectionString = "Data Source=" + this.SqlServerIPAdd + "," + this.port +
                ";Initial Catalog=" + this.DBName +
                ";Integrated Security=True;";
            string result = "";

            using (this.conn)
            {
                using (SqlCommand command = new SqlCommand("dbo.SP_CHECK_ENCRYPT_NHANVIEN", conn))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@username", tendn);
                    command.Parameters.AddWithValue("@MATKHAU", mk);

                    conn.Open();

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

        public DataTable SelectFromTable(string tableName)
        {
            try
            {
                conn.Open();
                sql = "select * from " + tableName;
                cmd = new SqlCommand(sql, conn);
                dt = new DataTable();
                dt.Load(cmd.ExecuteReader());
                return dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Connection fail", ex.Message);
                return null;
            }
            finally
            {
                conn.Close();
            }

        }

        public bool updateThroughProc(string procedure, List<KeyValuePair<string, string>> ls)
        {
            try
            {
                conn.Open();
                using (cmd = new SqlCommand(procedure, conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    if (ls != null)
                    {
                        for (int i = 0; i < ls.Count; i++)
                        {
                            cmd.Parameters.AddWithValue(ls[i].Key, ls[i].Value);
                        }
                    }
                    cmd.ExecuteNonQuery();
                    return true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Connection fail", ex.Message);
                return false;
            }
            finally
            {
                conn.Close();
            }
        }
        public DataTable readFromProc(string procedure, List<KeyValuePair<string, string>> ls)
        {
            try
            {
                conn.Open();
                using (cmd = new SqlCommand(procedure, conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    if (ls != null)
                    {
                        for (int i = 0; i < ls.Count; i++)
                        {
                            cmd.Parameters.AddWithValue(ls[i].Key, ls[i].Value);
                        }
                    }
                    using (ad = new SqlDataAdapter(cmd))
                    {
                        DataTable dt = new DataTable();
                        ad.Fill(dt);
                        return dt;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Connection fail", ex.Message);
                return null;
            }
            finally
            {
                conn.Close();
            }
        }
    }
}

