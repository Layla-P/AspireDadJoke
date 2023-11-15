using System.Net.Http;

namespace EurekaDemo;

public class JokeService(HttpClient client)
{
    public async Task<string> GetJoke()
    {
        return await client.GetStringAsync("/dadjoke");
    }
}
