using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace demo.folly.io.Controllers
{
    public class ExamplesController : Controller
    {
        public ActionResult Index(int siteID = 0)
        {
            ViewBag.SiteID = siteID;
            return View();
        }

        public ActionResult Attributes(int siteID = 0)
        {
            ViewBag.SiteID = siteID;
            return View();
        }
    }
}