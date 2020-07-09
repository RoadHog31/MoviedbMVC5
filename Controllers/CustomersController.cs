using MoviedbMVC5.DAL;
using MoviedbMVC5.Models;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web.Mvc;

namespace MoviedbMVC5.Controllers
{
    public class CustomersController : Controller
    {
        private readonly MovieContext db = new MovieContext();

        // GET: Customers
        public ActionResult Index()
        {            

            return View(db.Customers.ToList());
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
                new Customer { Id = 1, FirstName = "John Smith"},
                new Customer { Id = 2, FirstName = "Mary Williams"}
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
                return View();

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
