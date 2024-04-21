using Npgsql;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace DatabaseAccess
{
    public class DatabaseConnection
    {
        private string username;
        private string password;
        private readonly string LIST_DB_QUERY = "SELECT datname FROM pg_database WHERE datistemplate = false;";
        private readonly int COMMAND_TIMEOUT_IN_SECS = 60; //CommandTimeout parameter is measured in seconds and controls for how long to wait for a command to finish before throwing an error.
        private readonly int CONNECTION_TIMEOUT_IN_SECS = 20;
        public DatabaseConnection(string username, string password)            
        { 
            this.username = username;
            this.password = password;
        }

        public List<string> ConnectToPostgres()
        {
            var connectionString = $"Server=localhost; Port=5432; User Id={username}; Password={password}; Timeout={this.CONNECTION_TIMEOUT_IN_SECS};";
            List<string> databaseList = new List<string>();

            using (NpgsqlConnection conn = new NpgsqlConnection(connectionString))
            {
                conn.Open();

                try
                {
                    NpgsqlCommand cmd = new NpgsqlCommand(this.LIST_DB_QUERY, conn);

                    using (NpgsqlDataReader sqldr = cmd.ExecuteReader())
                    {
                        if (sqldr.Read())
                        {
                            DataTable dt = new DataTable();
                            dt.Load(sqldr);
                            
                            databaseList = dt.Rows.OfType<DataRow>().Select(x => (string)x[0]).ToList();
                        }
                        sqldr.Close();
                    }
                }
                catch(Exception ex)
                {
                    throw new Exception(ex.Message);
                }
                finally { 
                    conn.Close();
                    conn.Dispose();
                }
                return databaseList;
            }
        }

        public DataTable ExecuteQuery(string databaseName, string query)
        {
            var connectionString = $"Server=localhost; Port=5432; User Id={username}; Password={password}; Database={databaseName}; Timeout={this.CONNECTION_TIMEOUT_IN_SECS};";
            DataTable dt = new DataTable();

            using (NpgsqlConnection conn = new NpgsqlConnection(connectionString))
            {
                conn.Open();

                try
                {
                    NpgsqlCommand cmd = new NpgsqlCommand(query, conn);
                    cmd.CommandTimeout = this.COMMAND_TIMEOUT_IN_SECS;

                    using (NpgsqlDataReader sqldr = cmd.ExecuteReader())
                    {
                        if (sqldr.Read())
                        {
                            var dtSchema = sqldr.GetSchemaTable();                          
                            dt.Load(sqldr);
                        }
                        sqldr.Close();
                    }
                }
                catch (Exception ex)
                {
                    throw new Exception(ex.Message);
                }
                finally
                {
                    conn.Close();
                    conn.Dispose();
                }
                return dt;
            }
        }
    }
}
