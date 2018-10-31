using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace TPP.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult EventCalender()
        {
            return View();
        }

        public ActionResult PhotoGallery()
        {
            return View();
        }

        public ActionResult ClubRules()
        {
            return View();
        }

        public ActionResult ContactUs()
        {
            return View();
        }
    }
}