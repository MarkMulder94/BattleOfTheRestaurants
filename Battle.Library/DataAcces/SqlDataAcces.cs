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
                var x = connection.Query<Manager>("select * from Manager").ToList();
                return x;
            }
        }
        // KoffieBattle
        public List<KoffieBattle> MaandCijfer(string restaurant)
        {
            string sql = $"SELECT * FROM KoffieBattle WHERE NameRestaurant = @restaurantName";
            using (var connection = new SqlConnection(_connectionString))
            {
                var result = connection.QueryAsync<KoffieBattle>(sql, new {restaurantName = restaurant} ).Result.ToList();
                return result;
            }
        }
        public bool InsertData(KoffieBattle koffieBattle)
        {

            string sql = @"INSERT KoffieBattle([Groot],[Medium],[NameRestaurant],[NameManager]) values (@Groot, @Medium, @NameRestaurant, @NameManager)";
            using (IDbConnection connection = new SqlConnection(_connectionString))
            {
                int rowsAffected = connection.Execute
                    (
                    sql,
                    new { 
                        Groot = koffieBattle.Groot, 
                        Medium = koffieBattle.Medium,
                        NameRestaurant = koffieBattle.NameRestaurant,
                        NameManager = koffieBattle.NameManager
                    });

                if (rowsAffected > 0)
                {
                    return true;
                }
                return false;
            }

        }
        public List<KoffieBattle> LiveKoffieBattle()
        {
            using (var connection = new SqlConnection(_connectionString))
            {
                string sql = "SELECT A.Groot, A.Medium, A.datum, A.NameManager, A.NameRestaurant FROM KoffieBattle A " +
                    "INNER JOIN(SELECT NameRestaurant, MAX(datum) as datum FROM KoffieBattle GROUP BY NameRestaurant)" +
                    "AS B ON A.NameRestaurant = B.NameRestaurant AND A.datum = B.datum";
                var BattleMaand = (List<KoffieBattle>)connection.Query<KoffieBattle>(sql).Where(x => x.datum.Month == DateTime.Now.Month).ToList();
                return BattleMaand;
            }
        }
    }
}
