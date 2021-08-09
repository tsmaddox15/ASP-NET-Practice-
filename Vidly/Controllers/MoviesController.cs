using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Vidly.Models;
using Vidly.ViewModels;
using Microsoft.Data.Sqlite;

namespace Vidly.Controllers
{
    public class MoviesController : Controller
    {
        // GET: Movies
        public ActionResult Random()
        {
            var movie = new Movie() { Name = "Shrek!" };
            var customers = new List<Customer>
            {
                new Customer {Name = "Customer 1"},
                new Customer { Name = "Customer 2" }
            };
           /* var viewModel = new RandomMovieViewModel
            {
                Movie = movie,
                Customers = customers
            };
            //ViewData["Movie"] = movie;*/
            return View(movie);
        }

        public ActionResult Customers()
        {
            //var customers = new Customer() { Name = "Testing" };
            var customers = new List<Customer>
            {
                new Customer {Id=0, Name="Taylor Maddox"},
                new Customer {Id=1, Name="Caitlyn Fox"}
            };
            return View(customers);
        }
        public ActionResult Edit(int movieId)
        {
         return Content("Id= " + movieId);

        }

        // ? lets var be nullable. String is nullable by default.
        public ActionResult Index(int? pageIndex, string sortBy)
        {
            if (!pageIndex.HasValue)
            {
                pageIndex = 1;
            }
            if (String.IsNullOrWhiteSpace(sortBy))
            {
                sortBy = "Name";
            }

            return Content(String.Format("pageIndex={0}&sortBy={1}",pageIndex,sortBy));
        }
        [Route("movies/released/{year}/{month}")]
        public ActionResult ByReleaseDate(int year, int month)
        {
            return Content(year + "/" + month);
        }
    }
}