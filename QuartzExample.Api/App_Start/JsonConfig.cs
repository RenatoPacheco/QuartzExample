using Newtonsoft.Json;
using System.Web.Http;
using System.Net.Http.Headers;
using Newtonsoft.Json.Serialization;

namespace QuartzExample.Api
{
    public static class JsonConfig
    {
        public static void Register(HttpConfiguration config)
        {
            // Ref: http://waldyrfelix.net/2013/04/29/asp-net-web-api-melhorando-o-retorno-json-dos-seus-servicos-rest/

            // Remove format XML
            config.Formatters.Remove(config.Formatters.XmlFormatter);

            // Format json
            var json = config.Formatters.JsonFormatter;
            json.SupportedMediaTypes.Clear();
            json.SupportedMediaTypes.Add(new MediaTypeHeaderValue("text/json"));
            json.SerializerSettings.ReferenceLoopHandling = ReferenceLoopHandling.Ignore;
            json.SerializerSettings.Culture = System.Globalization.CultureInfo.CurrentCulture;
            json.SerializerSettings.ContractResolver = new CamelCasePropertyNamesContractResolver();
            json.SerializerSettings.Converters.Add(new Newtonsoft.Json.Converters.StringEnumConverter());
        }
    }
}