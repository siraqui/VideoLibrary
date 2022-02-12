using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Vidlib_v2.Models;
using Vidlib_v2.ViewModel;

namespace Vidlib_v2.Controllers
{
    public class MoviesController : Controller
    {

        public ActionResult Random()
        {
            var movie = new Movie() { Name = "Spider Man !" };
            var customers = new List<Customer> {
            new Customer{Name="Customer1"},
            new Customer { Name = "Customer2" }
    };
            var ViewModel = new RandomMovieViewModel { 
            Movie= movie,
            Customers= customers
            };
            return View(ViewModel);
        }

        public ActionResult Edit(int id)
        {
            return Content("id=" + id);

        }
        // GET: Movies
        public ActionResult Index()
        {
            return View();
        }


    }
}