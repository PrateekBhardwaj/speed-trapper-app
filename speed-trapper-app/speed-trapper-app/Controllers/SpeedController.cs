using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace speed_trapper_app.Controllers
{
    public class SpeedController : Controller
    {
        //
        // GET: /Speed/
        public static int speedLimit = 100;
        public ActionResult Index()
        {
            ViewBag.SpeedLimit = speedLimit;
            return View();
        }

        [HttpPost]
        public ActionResult SetMaxSpeedLimit(string txtSpeed)
        {
            SpeedController.speedLimit = Convert.ToInt16(txtSpeed.ToString());
            ViewBag.SpeedLimit = speedLimit;
            return View("Index");

        }

    }
	
}