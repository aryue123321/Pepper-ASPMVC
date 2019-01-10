using Pepper.Models;
using Pepper.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Pepper.Controllers
{
    public class MoviesController : Controller
    {
        // GET: Movies
        public ActionResult Random()
        {
            var movie = new Movie() { Name = "WTF" };
            var customers = new List<Customer>
            {
                new Customer{ Name = "KILL ME PLEASE"},
                new Customer{Name = "PLEASE"}
            };

            var vm = new RandomMovieViewModel
            {
                Movie = movie,
                Customers = customers
                
            };

            return View(vm);
        }

        public ActionResult Edit(int id)
        {
            return Content(id.ToString());
        }

        public  ActionResult Index(int? pageIndex, string sortBy)
        {
            var movie = new Movie { Name = "Batman" };

            return View(movie);
        }           

        [Route("movies/released/{year:regex(\\d{4})}/{month}")]
        public ActionResult ByReleaseDate(int year, int month)
        {
            return Content(year + "/" + month);
        }
    }
}