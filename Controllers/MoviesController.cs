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
        private ApplicationDbContext _context;
        public MoviesController()
        {
            _context = new ApplicationDbContext();
        }
       
        private List<Movie> GetMovies()
        {
            return _context.Movies.ToList();
        }
        public ActionResult Edit(int id)
        {
            return Content("id=" + id);

        }
        // GET: Movies
        public ActionResult Index()
        {
            
            return View(GetMovies());
        }


    }
}