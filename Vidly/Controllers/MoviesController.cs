using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Vidly.Models;
using Vidly.ViewModels;
using Vidly.Migrations;

namespace Vidly.Controllers
{
    public class MoviesController : Controller
    {
        private ApplicationDbContext _context;
        public MoviesController()
        {
            _context = new ApplicationDbContext();
        }

        protected override void Dispose(bool disposing)
        {
            _context.Dispose();
        }
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
        public ActionResult Edit(Movie movie)
        {
            var genre = _context.Genre.ToList();
            var viewModel = new MovieFormViewModel
            {
                Genre = genre,
                Movie = movie
            };
            return View(viewModel);
        }
        // /Movies
        public ViewResult Index()
        {
            var movies = _context.Movies.ToList();

            return View(movies);
        }

        //With attribute routing
        [Route("movies/released/{year}/{month:regex(\\d{2}):range(1,12)}")]
        public ActionResult ByReleaseDate(int year, int month)
        {
            return Content(year + "/" + month); 
        }

        public ActionResult Details(int id)
        {
            var movie = _context.Movies.SingleOrDefault(c => c.Id == id);
            return View(movie); 
        }

        public ActionResult New()
        {
            var genre = _context.Genre.ToList();
            var viewModel = new MovieFormViewModel
            {
                Genre = genre
            };
            return View(viewModel);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Save(Movie movie)
        {
            if (!ModelState.IsValid)
            {
                var viewModel = new MovieFormViewModel()
                {
                    Movie = movie,
                    Genre = _context.Genre.ToList()
                };

                return View("New", viewModel);
            }
            if (movie.Id == 0)
                _context.Movies.Add(movie);
            else
            {
                var movieInDb = _context.Movies.Single(c => c.Id == movie.Id);
                movieInDb.Name = movie.Name;
                movieInDb.ReleaseDate = movie.ReleaseDate;
                movieInDb.Genre = movie.Genre;
                movieInDb.NumberInStock = movie.NumberInStock;
            }
            _context.SaveChanges();

            return RedirectToAction("Index", "Movies"); 
        }

        public ActionResult Test()
        {
            return View(); 
        }
    }
}