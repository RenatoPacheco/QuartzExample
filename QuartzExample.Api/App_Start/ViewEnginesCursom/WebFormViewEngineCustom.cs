using System.Text.RegularExpressions;
using System.Web.Mvc;

namespace QuartzExample.Api.App_Start.ViewEnginesCursom
{
    public class WebFormViewEngineCustom : WebFormViewEngine
    {
        public WebFormViewEngineCustom() : base()
        {
            MasterLocationFormats = new[] {
                "~/Views/%1/{1}/{0}.master",
                "~/Views/%1/Shared/{0}.master"
            };

            AreaMasterLocationFormats = new[] {
                "~/Areas/{2}/Views/%1/{1}/{0}.master",
                "~/Areas/{2}/Views/%1/Shared/{0}.master",
            };

            ViewLocationFormats = new[] {
                "~/Views/%1/{1}/{0}.aspx",
                "~/Views/%1/{1}/{0}.ascx",
                "~/Views/%1/Shared/{0}.aspx",
                "~/Views/%1/Shared/{0}.ascx"
            };

            AreaViewLocationFormats = new[] {
                "~/Areas/{2}/Views/%1/{1}/{0}.aspx",
                "~/Areas/{2}/Views/%1/{1}/{0}.ascx",
                "~/Areas/{2}/Views/%1/Shared/{0}.aspx",
                "~/Areas/{2}/Views/%1/Shared/{0}.ascx",
            };

            PartialViewLocationFormats = ViewLocationFormats;
            AreaPartialViewLocationFormats = AreaViewLocationFormats;
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