using System.Web.Mvc;
using QuartzExample.Api.App_Start.ViewEnginesCursom;

namespace QuartzExample.Api
{

    // https://weblogs.asp.net/imranbaloch/view-engine-with-dynamic-view-location
    public class ViewEnginesConfig
    {
        public static void RegisterEngines(ViewEngineCollection engines)
        {
            engines.Clear();
            engines.Add(new RazorViewEngineCustom());
            engines.Add(new WebFormViewEngineCustom());
        }
    }
}