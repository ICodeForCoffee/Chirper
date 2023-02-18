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
            "Hey, I love cheese", "Let's go sports team!", "This is like a tweet", "I'm tired."
        };

        private readonly ILogger<ChirpController> _logger;

        public ChirpController(ILogger<ChirpController> logger)
        {
            _logger = logger;
        }

        [HttpGet(Name = "GetRecentChirps")]
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
