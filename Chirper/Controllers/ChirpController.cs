﻿using Chirper.Models;
using Microsoft.AspNetCore.Mvc;

namespace Chirper.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ChirpController : ControllerBase
    {
        private string[] SummariesOld = new[]
        {
            "Hey, I love cheese", "Let's go sports team!", "This is like a tweet", "I'm tired."
        };
        private List<string> Summaries;

        private readonly ILogger<ChirpController> _logger;

        public ChirpController(ILogger<ChirpController> logger)
        {
            _logger = logger;
            Summaries = SummariesOld.ToList();
        }

        [HttpGet(Name = "GetRecentChirps")]
        public IEnumerable<Chirp> Get()
        {
            return Enumerable.Range(1, 5).Select(index => new Chirp
            {
                Created = DateTime.Now,

                MessageText = Summaries[Random.Shared.Next(Summaries.Count)]

            })
            .ToArray();
        }

        [HttpPost(Name = "SendChirp")]
        public void Post(Chirp newChirp)
        {
            Summaries.Add(newChirp?.MessageText);
        }

        //[HttpPost(Name = "DeleteChirp")]
        //public void Delete(int id)
        //{
        //    throw new NotImplementedException("Not yet implemented");
        //}
    }
}
