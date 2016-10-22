using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace demo.folly.io
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
                name: "Examples",
                url: "{siteID}/examples/{action}/{id}",
                defaults: new { controller = "Examples", action = "Index", siteID = UrlParameter.Optional, id = UrlParameter.Optional }
            );

            routes.MapRoute(
                name: "Examples2",
                url: "examples/{action}/{id}",
                defaults: new { controller = "Examples", action = "Index", siteID = 0, id = UrlParameter.Optional }
            );

            routes.MapRoute(
                name: "Default",
                url: "{siteID}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", siteID = UrlParameter.Optional, id = UrlParameter.Optional }
            );
        }
    }
}
