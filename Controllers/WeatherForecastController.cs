using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GameStop_API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {
        private static readonly string[] Summaries = new[]
        {
            "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
        };

        private readonly ILogger<WeatherForecastController> _logger;

        public WeatherForecastController(ILogger<WeatherForecastController> logger)
        {
            _logger = logger;
        }



        //(!)

            /*
            List<int> numeri = new List<int> { 1, 3, 4, 5231, 3155, 3, 8 };
            var numeriPari = from n in numeri where n % 2 == 0 select n;
            foreach (var n in numeriPari)
            {
                Console.WriteLine(n);
            }
            Console.WriteLine("========================");
            var nPari = numeri.Where(n => n % 2 == 0);
            foreach (var n in nPari)
            {
                Console.WriteLine(n);
            }
            */
        [HttpGet]
        public IEnumerable<WeatherForecast> Get()
        {

            List<string> names = new List<string> { "Mario", "Pippo", "Alessia" };

            // Select fa in modo di generare un nuovo IEnumerable
            // a partire da uno esistente, sfuttando la lambda expression passata come
            // parametro
            var lengthOfNames = names.Select(n => n.Length);

            foreach (var l in lengthOfNames)
            {
                Console.WriteLine(l);
            }

            var DoubleLength = lengthOfNames.Select(n => n * 2);

            foreach (var l in DoubleLength)
            {
                Console.WriteLine(l);
            }

            var test = names.Select(x => x.Length).Select(x => x * 2);

            List<int> ris = new List<int>();

            foreach (var n in names)
            {
                ris.Add(n.Length);
            }

            var QNamesLength = from n in names select n.Length;

            var lns = new Random();
            return Enumerable.Range(1, 5).Select(index => new WeatherForecast
            {
                Date = DateTime.Now.AddDays(index),
                TemperatureC = lns.Next(-20, 55),
                Summary = Summaries[lns.Next(Summaries.Length)]
            })
            .ToArray();
        }
    }
}
