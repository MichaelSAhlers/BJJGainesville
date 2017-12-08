using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BJJGainesville.Controllers {
    public class HomeController : Controller {
        public ActionResult Index() {
            return View();
        }

        public ActionResult About() {
            ViewBag.Message = "About";

            return View();
        }

        public ActionResult Contact() {
            ViewBag.Message = "Contact";

            return View();
        }

        public ActionResult Instructors() {
            ViewBag.Message = "Instructors";

            return View();
        }

        public ActionResult Pricing() {
            ViewBag.Message = "Pricing";

            return View();
        }

        public ActionResult Rankings() {
            ViewBag.Message = "Rankings";

            return View();
        }

        public ActionResult Rules() {
            ViewBag.Message = "Rules";

            return View();
        }

        public ActionResult Schedule() {
            ViewBag.Message = "Schedule";

            return View();
        }

        public ActionResult Trial() {
            ViewBag.Message = "Trial";

            return View();
        }

        public ActionResult Kids() {
            ViewBag.Message = "Kids";

            return View();
        }
    }
}