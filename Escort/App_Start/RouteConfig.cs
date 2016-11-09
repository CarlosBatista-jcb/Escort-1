using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace Escort
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");


            routes.MapRoute("LoginPage", "sign-in",
        new { controller = "Home", action = "LoginPage" });



            routes.MapRoute("AdminManage", "admin",
            new { controller = "Home", action = "AdminManage" });
            routes.MapRoute("AdminLogin", "login",
           new { controller = "Home", action = "AdminLogin" });


            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}
