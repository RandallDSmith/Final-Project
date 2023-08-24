using Final_Project.Models;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using RestSharp;



namespace Final_Project.Controllers
{
    public class CardController : Controller
    {
        private class ApiConfig
        {
            public string ApiKey { get; } = "ff84c857bbmsheb2bb98fa878952p191cb2jsna8a78f2f9855";

            public string ApiHost { get; } = "pokemon-tcg-card-prices.p.rapidapi.com";

		}
        
        public IActionResult Card()
        {
            var apiConfig = new ApiConfig();

            var client = new RestClient($"https://pokemon-tcg-card-prices.p.rapidapi.com/card?cardNumber=122&name=Arceus%20V");

            var request = new RestRequest();

            request.AddHeader("X-RapidAPI-Key", apiConfig.ApiKey);

            request.AddHeader("X-RapidAPI-Host", apiConfig.ApiHost);

            var response = client.Execute(request).Content;

            //Console.WriteLine(response);

            var cardInfo = JsonConvert.DeserializeObject<Root>(response);

            return View(cardInfo);
        }
    }
}
