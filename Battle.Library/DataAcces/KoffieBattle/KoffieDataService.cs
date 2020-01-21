using Battle.Library.Models;
using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.Extensions.Options;
using System.Linq;

namespace Battle.Library.DataAcces
{
    public class KoffieDataService
    {
        SqlDataAcces _con;
        public KoffieDataService(IOptions<ConnectionConfig> connectionConfig)
        {
            var connection = connectionConfig.Value;
            string connectionString = connection.Thuis;
            _con = new SqlDataAcces(connectionString);
        }
        public KoffieBattle GetMonthResult(int month, string restaurant)
        {
            return _con.MaandCijfer(restaurant).Where(x => x.datum.Month == month).LastOrDefault();
        }

    }
}
