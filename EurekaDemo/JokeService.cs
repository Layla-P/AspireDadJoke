using System.Net.Http;

namespace EurekaDemo;

public class JokeService(HttpClient client)
{
    public async Task<string> GetJoke()
    {
        var response =  await client.GetStringAsync("/dadjoke");

        if(string.IsNullOrEmpty(response))
        {
            return "No joke here";
        }
        return response;
    }
}
