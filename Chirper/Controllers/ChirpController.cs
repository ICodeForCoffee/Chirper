using Chirper.Models;
using Microsoft.AspNetCore.Mvc;
using static System.Net.Mime.MediaTypeNames;

namespace Chirper.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ChirpController : ControllerBase
    {
        private static readonly string[] Summaries = new[]
        {
            "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
        };

        private readonly ILogger<ChirpController> _logger;

        public ChirpController(ILogger<ChirpController> logger)
        {
            _logger = logger;
        }

        [HttpGet(Name = "GetWeatherForecast")]
        public IEnumerable<Chirp> Get()
        {
            return Enumerable.Range(1, 5).Select(index => new Chirp
            {
                Created = DateTime.Now,

                MessageText = Summaries[Random.Shared.Next(Summaries.Length)]
            })
            .ToArray();
        }
    }
}
