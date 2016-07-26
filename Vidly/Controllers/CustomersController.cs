using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Vidly.Models;

namespace Vidly.Controllers
{
    public class CustomersController : Controller
    {
        // GET: Customers
        [Route("Customers/Index")]
        public ActionResult Index()
        {
            var customers = new List<Customer>
            {
                new Customer {Name = "John Smith", Id = 1},
                new Customer {Name = "Mary Williams", Id = 2}
            };

            var customerModel = new Vidly.ViewModels.CustomersViewModel()
            {
                Customers = customers
            };
            return View(customerModel);
        }
    }
}