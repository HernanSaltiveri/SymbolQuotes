using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace NNProject.Web
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            );

            //routes.MapRoute(
            //    name: "Quotes",
            //    url: "Quotes/{action}",
            //    defaults: new { controller = "quotes", action = "Index"}
            //);




            //routes.MapRoute(
            //    "quotes",                                              // Route name
            //    "quotes/{action}/",                           // URL with parameters
            //    new { controller = "Quotes", action = "Custommethod", id = "" }  // Parameter defaults
            //);




            //routes.MapRoute(
            //    name: "Default",
            //    url: "{controller}/{action}/{id}",
            //    defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            //);
        }
    }
}
