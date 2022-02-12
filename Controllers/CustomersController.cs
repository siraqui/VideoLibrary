using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Vidlib_v2.Models;
using System.Data.Entity;
using Vidlib_v2.ViewModel;
namespace Vidlib_v2.Controllers
{
    public class CustomersController : Controller
    {
        private ApplicationDbContext _context;

        public CustomersController()
        {
            _context = new ApplicationDbContext();
        }
        protected override void Dispose(bool disposing)
        {
            _context.Dispose();
        }
        public List<Customer> GetCustomers()
        {

            #region Populated with data to test #NOT USED
            var customers = new List<Customer>
            {
               new Customer{Id=1,Name="Ayoub Er Razki"},
               new Customer{Id=2,Name="Gilbert Montagnard"},
               new Customer{Id=3,Name="Mohamed Al Hijazi"}
            };
            #endregion
            
            return _context.Customers.Include(x=>x.MemberShipType).ToList();
        }


        // GET: Customers
        public ActionResult Index()
        {
            var customers = GetCustomers();
            return View(customers);
        }

        public ActionResult Details(int? id)
        {
            var customer = GetCustomers().SingleOrDefault(c => c.Id == id);

            if (customer == null) return HttpNotFound();

            return View(customer);
        }
    }
}