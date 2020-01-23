using System;
using System.Collections.Generic;
using System.Linq;
using Battle.Library.DataAcces;
using Battle.Library.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;
using Battle.Library.DataAcces.Koffie;

namespace WebAPI.Controllers
{
    [Route("Koffie")]
    [ApiController]
    public class KoffieBattleController : ControllerBase
    {
        // afblijven
        KoffieDataService _con;
        public KoffieBattleController(IOptions<ConnectionConfig> connectionConfig)
        {
            var connection = connectionConfig.Value;
            string connectionString = connection.Thuis;
            _con = new KoffieDataService(connectionString);
        }

        // Laatste input
        [HttpGet]
        public IEnumerable<KoffieBattle> GetKoffieBattleLive()
        {
            return _con.LiveKoffieBattle().Where(x => x.datum.Month == DateTime.Now.Month);
        }
        // Laatste input refactor?
        [HttpGet("last/{restaurant}")]
        public IEnumerable<KoffieBattle> GetKoffieBattleLiveAsync(string restaurant)
        {
            return _con.LastInputPerRestaurant(restaurant).Where(x => x.datum.Month == DateTime.Now.Month);
        }
        // Specifieke maand
        [HttpGet("{month}/{restaurant}")]
        public KoffieBattle GetMonthResult(int month, string restaurant)
        {
            return _con.MaandCijfer(restaurant).Where(x => x.datum.Month == month).LastOrDefault();
        }
        // volledig jaar
        [HttpGet("year/{year}/{restaurant}")]
        public List<KoffieBattle> GetYearResultsPerMonth(int year, string restaurant)
        {
            return _con.JaarCijfer(restaurant, year);
        }
        // insert
        [Route("/post")]
        [HttpPost]
        public bool Post([FromBody]KoffieBattle koffieBattle)
        {
            return _con.InsertData(koffieBattle);
        }
    }
}