﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace Task14
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {


            routes.MapRoute("MyRoutesController", "{controller}/{action}",
              new { controller = "Home", action = "Index" });
            routes.MapRoute("MyRoutesAction", "{controller}/{action}",
                           new { action = "Index"});
        
        }
    }
}