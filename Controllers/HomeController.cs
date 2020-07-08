using MoviedbMVC5.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MoviedbMVC5.Controllers
{
    public class HomeController : Controller
    {
        private MovieContext db = new MovieContext();

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult Basic()
        {
            return View();
        }

        public ActionResult KOView()
        {
            var movie = new Movie
            {
                Title = "Batman",
                Genre = "Action/Adventure"

            };

            return View(movie);
        }
    }
}