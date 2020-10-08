using WebApplication1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApplication1.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        CarContext db = new CarContext();

        public ActionResult Index()
            {
                IEnumerable<Car> cars = db.Cars;
                ViewBag.Cars = cars;
                return View();
            }
            [HttpGet]
            public ActionResult Buy(int id)
            {
                ViewBag.СarId = id;
                return View();
            }
            [HttpPost]
            public string Buy(Purchase purchase)
            {
                purchase.Date = System.DateTime.Now;
                db.Purchases.Add(purchase);
                db.SaveChanges();
                return "Спасибі," + purchase.Person + ", за покупку!";
            }
    }
}