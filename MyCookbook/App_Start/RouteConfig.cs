using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace MyCookbook
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

            routes.MapRoute(
             "RecipeSearch",
             "Recipe/Search/{searchTerm}",
             new
             {
                 controller = "Recipe",
                 action = "Search",
                 searchTerm = ""
             }
         );
            routes.MapRoute(
                "RecipeAjaxSearch",
                "Recipe/getAjaxResult/",
                new { controller = "Recipe", action = "getAjaxResult" }
            );
        }


    }
}
