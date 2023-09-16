using System.Security.Cryptography.X509Certificates;
using Final_Project.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.DotNet.MSIdentity.Shared;
using Microsoft.Extensions.Options;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
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

            request.AddHeader("X-RapidAPI-Key", $"{_aSettings.ApiKey}");

            request.AddHeader("X-RapidAPI-Host", $"{_aSettings.ApiHost}");

            var response = client.Execute(request).Content;


            var result = JsonConvert.DeserializeObject<Root>(response);

            if (result.results.Count == 0)
            {
                ViewBag.ErrorMessage = "Error: The card you entered does not exist.  Please Try again";
                return View();
            }
            //JObject data = JObject.Parse(result);

            //if (data.Count == 0)
            //{
            //    ViewBag.Message = "Please enter a valid card name and number";
            //}


            return View(result);
        }
    }
}
