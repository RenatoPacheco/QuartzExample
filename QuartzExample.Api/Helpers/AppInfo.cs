using System;
using System.IO;
using System.Reflection;
using System.Text.RegularExpressions;

namespace QuartzExample.Api.Helpers
{
    public static class AppInfo
    {
        private static string _Local;
        public static string Local()
        {
            string resultado = _Local;

            if (string.IsNullOrWhiteSpace(resultado))
            {
                resultado = Path.GetDirectoryName(Assembly.GetExecutingAssembly().GetName().CodeBase);
                resultado = Regex.Replace(resultado, @"\s*[/\\]+\s*(bin)\s*[/\\]+.*$|\s*[/\\]+\s*(bin)[\s/\\]*$", "\\", RegexOptions.IgnoreCase);
                resultado = new Uri(resultado).LocalPath;
                _Local = resultado;
            }

            return resultado;
        }

        public static string Local(string value)
        {
            if (string.IsNullOrWhiteSpace(value))
                throw new ArgumentException("Value can't null or empty", "value");

            value = Regex.Replace(value.Trim(), @"[/]", "\\");
            value = Regex.Replace(value, @"^~[\\/]+", Local());
            return Regex.Replace(value, @"(\s*[/\\]+\s*)+", "\\");
        }

        public static string LocalRelative(string value)
        {
            if (string.IsNullOrWhiteSpace(value))
                throw new ArgumentException("Value can't null or empty", "value");

            value = Regex.Replace(value.Trim(), @"[/]", "\\");
            value = value.Replace(Local(), "~\\");
            return Regex.Replace(value, @"(\s*[/\\]+\s*)+", "\\");
        }
    }
}