// See https://aka.ms/new-console-template for more information
using System;
using System.Net.Http;
using System.Threading.Tasks;
using Client.Controller;

// HttpClient client = new(){
//     BaseAddress = new Uri("https://jsonplaceholder.typicode.com"),

// };

// try
// {
//     // HttpResponseMessage response = await client.GetAsync("https://jonplaceholder.typicode.com/posts");
//     HttpResponseMessage response = await client.GetAsync("/posts");
//     Console.WriteLine(response);

//     response.EnsureSuccessStatusCode();

//     string responseBody = await response.Content.ReadAsStringAsync();
//     Console.WriteLine(responseBody);
// }
// catch (HttpRequestException e)
// {
//     Console.WriteLine($"Error: {e.Message}");
// }

ClientController client = new("https://jsonplaceholder.typicode.com");

var res = await client.GetAsync("/users");
Console.WriteLine(res);