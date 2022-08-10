using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace DenimProject
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
                name: "ListUserItems",
                url: "listItems",
                defaults: new { controller = "Home", action = "ListUserItems" }
            );

            routes.MapRoute(
                name: "AddItems",
                url: "addItems",
                defaults: new { controller = "Home", action = "Index" }
            );


            routes.MapRoute(
                name: "Login",
                url: "login",
                defaults: new { controller = "Home", action = "Login" }
            );


            routes.MapRoute(
                name: "Signup",
                url: "signup",
                defaults: new { controller = "Home", action = "Signup" }
            );

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "ListUserItems", id = UrlParameter.Optional }
            );

        }
    }
}
