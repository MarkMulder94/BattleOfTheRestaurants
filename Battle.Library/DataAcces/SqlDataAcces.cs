using Battle.Library.Models;
using System.Collections.Generic;
using System.Data.SqlClient;
using Dapper;
using System.Linq;
using System.Threading.Tasks;
using System;
using System.Data;

namespace Battle.Library.DataAcces
{
    public class SqlDataAcces
    {
        private string _connectionString;

        public SqlDataAcces(string connectionString)
        {
            _connectionString = connectionString;
        }

        // Algemeen


        // Alle managers
        public List<Manager> GetManagers()
        {
            using (IDbConnection connection = new SqlConnection(_connectionString))
            {
                connection.Open();
                var x = connection.Query<Manager>("select * from Manager").ToList();
                connection.Close();
                return x;
            }
        }      
    }
}
