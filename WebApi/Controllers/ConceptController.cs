using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ConceptController : ControllerBase
    {
        private static readonly string[] Summaries = new[]
{
            "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
        };


        [HttpGet]
        public IEnumerable<Concept> Get()
        {
            var rng = new Random();
            return Enumerable.Range(1, 5).Select(index => new Concept
            {
                Id = rng.Next(),
                concept = Summaries[ rng.Next(Summaries.Length)],
                definition = Summaries[rng.Next(Summaries.Length)]
            })
            .ToArray();
        }

    }
}
