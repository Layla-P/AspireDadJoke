
using Microsoft.AspNetCore.Mvc;
using System.Net.Http;

namespace EurekaDemo.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class JokeController : ControllerBase
    {

        //private readonly IList<Application> _apps;
        private readonly ILogger<JokeController> _logger;
        private readonly JokeService _jokeService;

        public JokeController(ILogger<JokeController> logger, JokeService jokeService)
        {
            _logger = logger;
            _jokeService = jokeService;

        }
        [HttpGet]
        public async Task<string> Get()
        {
            return await _jokeService.GetJoke();
        }
    }
}
