using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;
using System.Web.Script.Serialization;
using Newtonsoft.Json;
using Vidly.Models;
using Vidly.ViewModels;

namespace Vidly.Controllers
{
    public class LeagueOfLegendsController : Controller
    {
        // GET: LeagueOfLegends
        public ActionResult Index()
        {
            var viewModel = new SummonerViewModel();
            return View(viewModel);
        }
        [HttpPost]
        public async Task<ActionResult> GetSummoner(Summoner summoner)
        {
            string url;
            string api_key;
            string region;

            api_key = "5d6c0476-ab4c-4403-aaa8-d7c8a95700bb";
            url = @"https://na.api.pvp.net/api/lol/na/v1.4/summoner/by-name/" + summoner.Name + "?api_key=";

            var request = url + api_key;
            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri(request);
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));



            HttpResponseMessage responseMessage = await client.GetAsync(request);
            var responseData = responseMessage.Content.ReadAsStringAsync().Result;

            Summoner sum = new JavaScriptSerializer().Deserialize<Summoner>(responseData);

            return View();
        }
    }
}