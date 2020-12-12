using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System.IO;
using Newtonsoft.Json;

namespace JobApi.Controllers
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

        [HttpGet]
        public IEnumerable<WeatherForecast?> Get()
        {
            var rng = new Random();
            return Enumerable.Range(1, 5).Select(index => new WeatherForecast
            {
                Date = DateTime.Now.AddDays(index),
                TemperatureC = rng.Next(-20, 55),
                // Summary = Summaries[rng.Next(Summaries.Length)],
                id= 1,
                isActive= true,
                title= "Fu Er Dai",
                location= "Watchtower, Washington",
                industry = "Rich",
                picture = "https://i.picsum.photos/id/703/300/150.jpg?hmac=u4EJJhnL7eJiV1Ub0wJ5El9hPvAeZvfIIJuKvVFtNus",

            })
            .ToArray();
            //return null;
        }

        [HttpGet("jobdata")]
        public string GetJobData()
        {
            StreamReader sr = File.OpenText("data.json");
            string jsonWordTemplate = sr.ReadToEnd();
            var data = JsonConvert.DeserializeObject<JobData>(jsonWordTemplate);
            return "data";
        }
    }
}
