// See https://aka.ms/new-console-template for more information
using System;
using System.Net.Http;
using System.Threading.Tasks;

 
static async Task Main(string[] args) {
    Console.WriteLine("press any key to countinue...");
    Console.ReadLine();

    using (HttpClient client = new HttpClient())
    {
        var response = await client.GetAsync("http://localhost:5063/values");
        response.EnsureSuccessStatusCode();
        if (response.IsSuccessStatusCode)
        {
            string message = await response.Content.ReadAsStringAsync();
            Console.WriteLine(message);
        }
        else
        {
            Console.WriteLine($"response error code: {response.StatusCode}");
        }
    }

    Console.ReadLine();
    Console.WriteLine("Hello, World!");
}

await Main(args);
