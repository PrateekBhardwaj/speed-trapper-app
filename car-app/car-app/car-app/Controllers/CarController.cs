using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace car_app.Controllers
{
    public class CarController : Controller
    {
        //
        // GET: /Car/
        public ActionResult Index()
        {
            Random r1 = new Random();
            ViewBag.Speed = r1.Next(10, 200);

            string[] carNames = System.IO.File.ReadAllLines(@"C:\Users\Bhavna\Downloads\speed-trapper-app-master\resources\car-names.txt");
            Random r2 = new Random();
            ViewBag.Car = carNames[r2.Next(0, 45)];
            ViewBag.Tag = "current speed";
            return View();
        }
	}
}