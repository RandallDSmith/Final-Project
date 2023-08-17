using Final_Project.Models;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using RestSharp;



namespace Final_Project.Controllers
{
    public class CardController : Controller
    {
        [HttpGet]
        public ActionResult Card()
        {

            var client = new RestClient($"https://pokemon-tcg-card-prices.p.rapidapi.com/card?cardNumber=122&name=Arcues%20V");

            var request = new RestRequest();

            request.AddHeader("X-RapidAPI-Key", "ff84c857bbmsheb2bb98fa878952p191cb2jsna8a78f2f9855");

            request.AddHeader("X-RapidAPI-Host", "pokemon-tcg-card-prices.p.rapidapi.com");

            var response = client.Execute(request).Content;

            //Console.WriteLine(response);

            var root = JsonConvert.DeserializeObject<Root>(response);

            return View(root);
        }
    }
}
