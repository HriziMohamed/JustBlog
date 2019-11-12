using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace JustBlog
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");
            routes.MapRoute(
                            "Action",
                            "{action}",
                            new { controller = "Blog", action = "Posts" }
                            );
            routes.MapRoute(
                            "Default",
                            "{controller}/{action}/{id}",
                            new { controller = "Blog", action = "Posts", id = UrlParameter.Optional }
                        );
            routes.MapRoute(
                            "Category",
                            "Category/{category}",
                            new { controller = "Blog", action = "Category" }
                        );

        }
    }
}
