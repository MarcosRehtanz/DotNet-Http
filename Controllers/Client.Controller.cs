using System;
using System.ComponentModel.DataAnnotations;
using System.Net.Http;
using System.Threading.Tasks;

namespace Client.Controller;

class ClientController
{
    private readonly HttpClient fetch;
    public ClientController(string uri = "")
    {
        fetch = new()
        {
            BaseAddress = new Uri(uri)
        };
    }

    public async Task<string> GetAsync(string uri)
    {
        HttpResponseMessage response = await fetch.GetAsync(uri);
        string responseBody = await response.Content.ReadAsStringAsync();
        return responseBody;
    }
}