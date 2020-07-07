using MoviedbMVC5.Models;
using MoviedbMVC5.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;

namespace MoviedbMVC5.Controllers
{
    public class CustomersController : Controller
    {
        // GET: Customers
        public ActionResult Index()
        {
            ViewBag.Message = "Customers";
            
            //var customer = new Customer{ Id = 1, name = "John Smith" };         


            return View();
        }

        // GET: Customers/Details/5
        [Route("Customers/Details/{id:int?}")]
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }

            var customer = new List<Customer>
            {
                new Customer { Id = 1, name = "John Smith"},
                new Customer { Id = 2, name = "Mary Williams"}
            };

            var viewModel = new RandomMovieViewModel
            {
                Customer = customer
            };

            using (var db = new MovieContext())
            {

            }

            if (customer == null)
            {
                return HttpNotFound();
            }
            else
            {
                return View(viewModel);

            }
            
        }

        // GET: Customers/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Customers/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Customers/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Customers/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Customers/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Customers/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
