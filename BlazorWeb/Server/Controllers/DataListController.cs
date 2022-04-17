using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using BlazorWeb.Shared;

namespace BlazorWeb.Server.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class DataListController
    {
        private static readonly string[] Summaries = new[]
{
            "aaaa", "bbb", "ccc", "ddd", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
        };

        private readonly ILogger<WeatherForecastController> _logger;

        public DataListController(ILogger<WeatherForecastController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public IEnumerable<WeatherForecast> Get()
        {
            var rng = new Random();
            return Enumerable.Range(1, 5).Select(index => new WeatherForecast
            {
                Date = DateTime.Now.AddDays(index),
                TemperatureC = rng.Next(-20, 55),
                Summary = Summaries[rng.Next(Summaries.Length)]
            })
            .ToArray();
        }

        //[HttpGet]
        //public IEnumerable<WeatherForecast> OnPostRegister()
        //{
        //    var rng = new Random();
        //    return Enumerable.Range(1, 5).Select(index => new WeatherForecast
        //    {
        //        Date = DateTime.Now.AddDays(index),
        //        TemperatureC = rng.Next(-20, 55),
        //        Summary = Summaries[rng.Next(Summaries.Length)]
        //    })
        //    .ToArray();
        //}

        /// <summary>
        /// サイトデータ取得
        /// </summary>
        /// <returns>サイトデータ</returns>
        [Route("SiteData")]  // 👈念のためクライアントからのリクエストURLに合わせた
        public async Task<OwnData> GetSiteData()
        {

            return new OwnData() { Name = "taro", Age = "1" };
        }
    }
}