using Quartz;
using QuartzExample.Api.Helpers;
using System;
using System.Diagnostics;
using System.IO;

namespace QuartzExample.Api.App_Start.SchedulerCustom
{
    public class LogJob : IJob
    {
        public LogJob()
        {
            folder = AppInfo.Local("~/logs");
            if (!Directory.Exists(folder))
                Directory.CreateDirectory(folder);
        }

        private readonly string folder;

        public void Execute(IJobExecutionContext context)
        {
            string file = string.Format("{0}/{1}.txt", folder, DateTime.Now.ToString("yyyyMMdd"));
            string value = string.Format("Register log: {0}{1}", DateTime.Now.ToString(), Environment.NewLine);

            if (!File.Exists(file))
                File.Create(file);

            File.AppendAllText(file, value);
            Debug.WriteLine(value);
        }
    }
}