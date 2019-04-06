using System.Web.Mvc;
using System.Web.Routing;

namespace QuartzExample.Api
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
                name: "HtmlDefault",
                url: "html/{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional },
                namespaces: new[] { "QuartzExample.Api.Controllers.Html" }
            );
        }
    }
}
