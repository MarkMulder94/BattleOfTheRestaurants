using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Battle.Library.DataAcces;
using Battle.Library.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;

namespace WebAPI.Controllers
{
    [Route("Koffie")]
    [ApiController]
    public class KoffieBattleController : ControllerBase
    {
        SqlDataAcces _con;
        public KoffieBattleController(IOptions<ConnectionConfig> connectionConfig)
        {
            var connection = connectionConfig.Value;
            string connectionString = connection.Thuis;
            _con = new SqlDataAcces(connectionString);
        }

        // Alle
        [HttpGet]
        public IEnumerable<KoffieBattle> GetKoffieBattleLive()
        {
            return _con.LiveKoffieBattle().Where(x => x.datum.Month == DateTime.Now.Month);
        }

        // Deze maand
        [HttpGet("{month}/{restaurant}")]
        public KoffieBattle GetMonthResult(int month, string restaurant)
        {
            return _con.MaandCijfer(restaurant).Where(x => x.datum.Month == month).LastOrDefault();
        }

        [Route("/post")]
        [HttpPost]
        public bool Post([FromBody]KoffieBattle koffieBattle)
        {
            return _con.InsertData(koffieBattle);
        }
    }
}