using Final_Project.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;
using Newtonsoft.Json;
using RestSharp;



namespace Final_Project.Controllers
{

	public class CardController : Controller
	{
		private readonly IConfiguration _configuration;

		public CardController(IConfiguration configuration)
		{
			_configuration = configuration;
		}

		public JsonResult GetAPIData(string apiConfig)
		{
			string? apiKey = _configuration.GetSection("ApiConfig:ApiKey").Value;
			string? apiHost = _configuration.GetSection("ApiConfig:ApiHost").Value;

			return Json(apiConfig);
		}
		
		public IActionResult Card(string cardName, string cardNumber)
		{

			var client = new RestClient($"https://pokemon-tcg-card-prices.p.rapidapi.com/card?cardNumber={cardNumber}&name={cardName}");

            var request = new RestRequest();

            request.AddHeader("X-RapidAPI-Key", $"ff84c857bbmsheb2bb98fa878952p191cb2jsna8a78f2f9855");

            request.AddHeader("X-RapidAPI-Host", "pokemon-tcg-card-prices.p.rapidapi.com");

            var response = client.Execute(request).Content;

            //Console.WriteLine(response);

            var result = JsonConvert.DeserializeObject<Root>(response);

            return View(result);
        }
    }
}
