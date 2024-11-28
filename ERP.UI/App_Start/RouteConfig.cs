﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace ERP
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
             name: "DefaultMap",
             url: "LMS/{controller}/{action}/{id}",
             defaults: new { controller = "Login", action = "Index", id = UrlParameter.Optional }
         );

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            );

            routes.MapRoute(
            name: "DefaultMapMaster",
            url: "MASTER/{controller}/{action}/{id}",
            defaults: new { controller = "Login", action = "Index", id = UrlParameter.Optional }
        );

        }
    }
}
