using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service_Application.Connection
{
    class ConnectionDB
    {
        private readonly string connection = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=ServiceApplicationDB;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
        
        SqlConnection connectionDB;

        public ConnectionDB()
        {
            connectionDB = new SqlConnection(connection);
        }

        public void OpenConnection()
        {
            if (connectionDB.State == System.Data.ConnectionState.Closed) connectionDB.Open();
        }

        public void CloseConnection()
        {
            if (connectionDB.State == System.Data.ConnectionState.Open) connectionDB.Close();
        }

        public SqlConnection GetConnection()
        {
            return connectionDB;
        }

        public async Task OpenConnectionAsync()
        {
            if (connectionDB.State == System.Data.ConnectionState.Closed) await connectionDB.OpenAsync();
        }
    }
}
