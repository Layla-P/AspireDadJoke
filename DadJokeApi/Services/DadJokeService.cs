using EurekaDemo.Models;
using System.Net.Http;
using System.Net.Http.Json;
using System.Text.Json;
using System.Threading.Tasks;

namespace EurekaDemo.Services
{
	public class DadJokeService
	{
		private HttpClient _client;
		public DadJokeService(HttpClient client)
		{
			_client = client;
		}
		public async Task<string> GetJokeAsync()
		{
			_client.DefaultRequestHeaders.Add("Accept", "application/json");

			var response = await _client.GetAsync("https://icanhazdadjoke.com/");

			var jokeString = await response.Content.ReadAsStringAsync();

            var options = new JsonSerializerOptions
            {
                PropertyNameCaseInsensitive = true,
            };

            var joke = JsonSerializer.Deserialize<DadJokeResponse>(jokeString, options);


            if (joke == null)
			{
                joke = new DadJokeResponse { Joke = "no joke" };

            }

			return joke.Joke;
		}

		
	}
}
