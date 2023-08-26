using Final_Project.Models;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using RestSharp;



namespace Final_Project.Controllers
{

	public class CardController : Controller
    {
		

		public IActionResult Card()
        {
			//IConfiguration config = new ConfigurationBuilder()
			//.SetBasePath(Directory.GetCurrentDirectory())
			//.AddJsonFile("appsettings.json", optional: true, reloadOnChange: true)
			//.Build();

   //         string apiKey = config["AppSettings:ApiKey"];

   //         string apiHost = config["appsettings:ApiHost"];

			var client = new RestClient($"https://pokemon-tcg-card-prices.p.rapidapi.com/card?cardNumber=122&name=Arceus%20V");

            var request = new RestRequest();

            request.AddHeader("X-RapidAPI-Key", "ff84c857bbmsheb2bb98fa878952p191cb2jsna8a78f2f9855");

            request.AddHeader("X-RapidAPI-Host", "pokemon-tcg-card-prices.p.rapidapi.com");

            var response = client.Execute(request).Content;

            //Console.WriteLine(response);

            var result = JsonConvert.DeserializeObject<Root>(response);

            return View(result);
        }
    }
}
