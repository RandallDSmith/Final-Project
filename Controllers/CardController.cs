using Final_Project.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;
using Newtonsoft.Json;
using RestSharp;



namespace Final_Project.Controllers
{

	public class CardController : Controller
	{
        
        private readonly ApiSettings _aSettings;

        public CardController(IOptions<ApiSettings> aSettings)
        {
            _aSettings = aSettings.Value;
        }

        [HttpGet("ApiConfig")]
        public ApiSettings Get() => _aSettings;

        public IActionResult GetApiSettings()
        {
            var apiKey = _aSettings.ApiKey;
            var apiHost = _aSettings.ApiHost;

            return Json(_aSettings);
        }
    
		public IActionResult Card(string cardName, string cardNumber)
		{

			var client = new RestClient($"https://pokemon-tcg-card-prices.p.rapidapi.com/card?cardNumber={cardNumber}&name={cardName}");

            var request = new RestRequest();

            request.AddHeader("X-RapidAPI-Key", $"ff84c857bbmsheb2bb98fa878952p191cb2jsna8a78f2f9855");

            request.AddHeader("X-RapidAPI-Host", "pokemon-tcg-card-prices.p.rapidapi.com");

            var response = client.Execute(request).Content;


            var result = JsonConvert.DeserializeObject<Root>(response);

            if(result.results == null)
            {
                ViewBag.ErrorMessage = "Error: The card you entered does not exist.  Please Try again";
                return View();
            }

			return View(result);
        }
    }
}
