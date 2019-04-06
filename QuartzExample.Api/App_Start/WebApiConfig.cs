using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;

namespace QuartzExample.Api
{
    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {
            // Web API configuration and services

            // Web API routes
            config.MapHttpAttributeRoutes();

            config.Routes.MapHttpRoute(
                name: "DefaultApi",
                routeTemplate: "service/{controller}/{id}",
                defaults: new { id = RouteParameter.Optional }
            );

            // Show error message in server
            config.IncludeErrorDetailPolicy = IncludeErrorDetailPolicy.Always;
        }
    }
}
