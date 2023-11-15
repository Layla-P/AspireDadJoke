
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
        private readonly HttpClient _httpClient;

        public JokeController(ILogger<JokeController> logger, HttpClient client)
        {
            _logger = logger;
            _httpClient = client;
            _httpClient.BaseAddress = new("http://dadjokeapi");
            //_httpClient.BaseAddress = new("https://localhost:5005");

        }
        [HttpGet]
        public async Task<string> Get()
        {
            return await _httpClient.GetStringAsync("/dadjoke");
        }
    }
}
