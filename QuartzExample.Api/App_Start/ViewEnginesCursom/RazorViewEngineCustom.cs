using System.Text.RegularExpressions;
using System.Web.Mvc;

namespace QuartzExample.Api.App_Start.ViewEnginesCursom
{
    public class RazorViewEngineCustom : RazorViewEngine
    {
        public RazorViewEngineCustom() : base()
        {
            AreaViewLocationFormats = new[] {
                "~/Areas/{2}/Views/%1/{1}/{0}.cshtml",
                "~/Areas/{2}/Views/%1/{1}/{0}.vbhtml",
                "~/Areas/{2}/Views/%1/Shared/{0}.cshtml",
                "~/Areas/{2}/Views/%1/Shared/{0}.vbhtml"
            };

            AreaMasterLocationFormats = new[] {
                "~/Areas/{2}/Views/%1/{1}/{0}.cshtml",
                "~/Areas/{2}/Views/%1/{1}/{0}.vbhtml",
                "~/Areas/{2}/Views/%1/Shared/{0}.cshtml",
                "~/Areas/{2}/Views/%1/Shared/{0}.vbhtml"
            };

            AreaPartialViewLocationFormats = new[] {
                "~/Areas/{2}/Views/%1/{1}/{0}.cshtml",
                "~/Areas/{2}/Views/%1/{1}/{0}.vbhtml",
                "~/Areas/{2}/Views/%1/Shared/{0}.cshtml",
                "~/Areas/{2}/Views/%1/Shared/{0}.vbhtml"
            };

            ViewLocationFormats = new[] {
                "~/Views/%1/{1}/{0}.cshtml",
                "~/Views/%1/{1}/{0}.vbhtml",
                "~/Views/%1/Shared/{0}.cshtml",
                "~/Views/%1/Shared/{0}.vbhtml"
            };

            MasterLocationFormats = new[] {
                "~/Views/%1/{1}/{0}.cshtml",
                "~/Views/%1/{1}/{0}.vbhtml",
                "~/Views/%1/Shared/{0}.cshtml",
                "~/Views/%1/Shared/{0}.vbhtml"
            };

            PartialViewLocationFormats = new[] {
                "~/Views/%1/{1}/{0}.cshtml",
                "~/Views/%1/{1}/{0}.vbhtml",
                "~/Views/%1/Shared/{0}.cshtml",
                "~/Views/%1/Shared/{0}.vbhtml"
            };
        }

        protected override IView CreatePartialView(ControllerContext controllerContext, string partialPath)
        {
            var nameSpace = Regex.Match(controllerContext.Controller.GetType().Namespace, @"[^\.]+$").Value;
            return base.CreatePartialView(controllerContext, partialPath.Replace("%1", nameSpace));
        }

        protected override IView CreateView(ControllerContext controllerContext, string viewPath, string masterPath)
        {
            var nameSpace = Regex.Match(controllerContext.Controller.GetType().Namespace, @"[^\.]+$").Value;
            return base.CreateView(controllerContext, viewPath.Replace("%1", nameSpace), masterPath.Replace("%1", nameSpace));
        }

        protected override bool FileExists(ControllerContext controllerContext, string virtualPath)
        {
            var nameSpace = Regex.Match(controllerContext.Controller.GetType().Namespace, @"[^\.]+$").Value;
            return base.FileExists(controllerContext, virtualPath.Replace("%1", nameSpace));
        }

    }
}