using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Glimpse.Mvc.AlternateType;
using Vidly.Models;
using Vidly.Dtos2;

namespace Vidly.Controllers.Api
{
    public class NewRentalsController : ApiController
    {
        private ApplicationDbContext _context;

        public NewRentalsController()
        {
            _context = new ApplicationDbContext();
        }
        public IHttpActionResult UpdateRental(NewRentalsDto newRentals)
        {
            var customer = _context.Customers.SingleOrDefault(c => c.Id == newRentals.CustomerId);

            var movies = _context.Movies.Where(m => newRentals.MovieIds.Contains(m.Id)).ToList();

            foreach (var movie in movies)
            {
                if (movie.NumberAvailable == 0)
                    return BadRequest("Movie is not available."); 

                movie.NumberAvailable--; 

                var rental = new Rental
                {
                    Customer = customer,
                    Movie = movie,
                    DateRented = DateTime.Now
                };

                _context.NewRentals.Add(rental); 
            }

            _context.SaveChanges();

            return Ok(); 
        }

        [HttpGet]
        public IEnumerable<Rental> GetRentals()
        {
            var rentals = _context.NewRentals.ToList();
            
            

            return rentals;
        }
    }
}
