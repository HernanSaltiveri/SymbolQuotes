using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;

namespace NNProject
{
    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {
            // Web API configuration and services

            // Web API routes
            config.MapHttpAttributeRoutes();

            //config.Routes.MapHttpRoute(
            //    name: "DefaultApi",
            //    routeTemplate: "api/{controller}/{id}",
            //    defaults: new { id = RouteParameter.Optional }
            //);
            config.Routes.MapHttpRoute(
                name: "DefaultApi",
                routeTemplate: "api/{controller}/{action}",
                defaults: new { id = RouteParameter.Optional }
            );
            //config.Routes.MapHttpRoute(
            //    name: "Quotes",
            //    routeTemplate: "api/quotes/{action}",
               
            //    defaults: new { id = RouteParameter.Optional }
            //);
            //routes.MapRoute(
            //     "Default",                                              // Route name
            //     "{controller}/{action}/{id}",                           // URL with parameters
            //     new { controller = "Home", action = "Index", id = "" }  // Parameter defaults
            // );
        }
    }
}
