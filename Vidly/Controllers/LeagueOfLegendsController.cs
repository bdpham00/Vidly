using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
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
        public ActionResult SearchSummoner(Summoner summoner)
        {
            string url;
            string api_key;
            string region;

            api_key = "5d6c0476-ab4c-4403-aaa8-d7c8a95700bb";
            url = @"https://na.api.pvp.net/api/lol/na/v1.4/summoner/by-name/";

            var request = url + summoner.Name + "?api_key =" + api_key;
            return View();
        }
    }
}