using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WestSprings.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        //test view
        //public ActionResult test()
        //{
        //    return PartialView("_test");
        //}

        public ActionResult About()
        {

            return View();
        }

        public ActionResult Statements()
        {

            return View();
        }

        public ActionResult Ministries()
        {

            return View();
        }

        public ActionResult Sermons()
        {

            return View();
        }

        public ActionResult OngoingOpp()
        {
            return View();
        }

        public ActionResult Give()
        {
            return View();
        }

        public ActionResult ComingSoon()
        {
            return View();
        }

    }
}