using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace ConferenceRegistration
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults:
                    new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            );
            
            routes.MapRoute(
                name: "Confirm",
                url: "{controller}/{action}/{Email}",
                defaults:
                    new { controller = "Home", action = "Confirm", Email = UrlParameter.Optional }
            );

            routes.MapRoute(
                name: "ConfirmedEmail",
                url: "{controller}/{action}/{id}/{Email}",
                defaults:
                    new { controller = "Home", action = "ConfirmedEmail", id = UrlParameter.Optional, Email = UrlParameter.Optional }
            );
        }
    }
}
