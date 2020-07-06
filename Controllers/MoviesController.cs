using MoviedbMVC5.Models;
using MoviedbMVC5.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MoviedbMVC5.Controllers
{
    public class MoviesController : Controller
    {
        // GET: Movies
        public ActionResult Random()
        {
            var movie = new List<Movie> { 
                
              new Movie { Id=1, name = "Shrek!" },
              new Movie { Id=2, name = "E.T." }

            };

            var customers = new List<Customer>
            {
                new Customer { Id=1, name = "John Smith"},
                new Customer { Id=2, name = "Mary Williamson"}
            };

            var viewModel = new RandomMovieViewModel
            {
                Movie = movie,
                Customer = customers
            };

            return View(viewModel);
            //return Content("Hello world!");
            //return HttpNotFound();
            //return new EmptyResult();
            //return RedirectToAction("Index", "Home", new { page = 1, sortBy = "name" });
        }

        public ActionResult Edit(int id)
        {

            return Content("id=" + id);
        }

        //movies
        public ActionResult Pagination(int? pageindex, string sortBy)
        {
            if (!pageindex.HasValue)
            {
                pageindex = 1;
            }

            if (String.IsNullOrWhiteSpace(sortBy))
            {
                sortBy = "Name";
            }

            return Content(String.Format("pageIndex={0}&sortBy={1}", pageindex, sortBy));
        }

        [Route("movies/released/{year}/{month:regex(\\d{2}):range(1, 12)}")]
        public ActionResult ByReleaseYear(int year, int month)
        {
            return Content(year + "/" + month);

        }

        
    }
}