using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace demo.folly.io.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index(int siteID = 0)
        {
            ViewBag.SiteID = siteID;
            return View();
        }

        public ActionResult Product(int id, int siteID = 0)
        {
            ViewBag.SiteID = siteID;
            return View();
        }

        public ActionResult AttributesExample(int siteID = 0)
        {
            ViewBag.SiteID = siteID;
            return View();
        }
    }
}