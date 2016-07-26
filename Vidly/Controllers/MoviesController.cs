﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Vidly.Models;
using Vidly.ViewModels;

namespace Vidly.Controllers
{
    public class MoviesController : Controller
    {
        // GET: Movies/Random
        public ActionResult Random()
        {
            var movie = new Movie() { Name = "Shrek!" };

            //Never use these
            //ViewData["Movie"] = movie;
            //ViewBag.Movie = movie;
            var customers = new List<Customer>
            {
                new Customer {Name = "Customer1" },
                new Customer {Name = "Customer2" }
            };

            var viewModel = new RandomMovieViewModel
            {
                Movie = movie,
                Customers = customers
            };

            return View(viewModel); 
            //return Content("Hello");
            //return RedirectToAction("Index", "Home", new { page = 1, sortBy = "name" });  
            //return new EmptyResult(); 
            //View()
            //PartialView()
            //Content()
            //Redirect()
            //RedirectToAction()
            //Json()
            //File()
            //HttpNotFound()
        }

        //Passing value through URL
        public ActionResult Edit(int id)
        {
            return Content("id= " + id); 
        }
        // /Movies
        public ActionResult Index(int? pageIndex, string sortBy)
        {
            if (!pageIndex.HasValue)
                pageIndex = 1;

            if (String.IsNullOrWhiteSpace(sortBy))
                sortBy = "Name";

            return Content(String.Format("pageIndex ={0}&sortBy={1}", pageIndex, sortBy));
        }

        //With attribute routing
        [Route("movies/released/{year}/{month:regex(\\d{4}):range(1, 12)}")]
        public ActionResult ByReleaseDate(int year, int month)
        {
            return Content(year + "/" + month); 
        }
    }
}