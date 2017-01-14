using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace MovieRentals
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapMvcAttributeRoutes();

            /*
            routes.MapRoute(
                "MoviesByReleaseDate", // name for route
                "movies/released/{year}/{month}", // url for route
                new { controller = "Movies", action = "ByReleaseDate" }, // which controller and action 
                new { year = @"2015|2016", month = @"\d{2}" }); // ensures year is 2015 or 2016, month is 2 digits
            
             */
            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}
