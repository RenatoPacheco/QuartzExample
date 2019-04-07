using Quartz;
using Quartz.Impl;
using QuartzExample.Api.App_Start.SchedulerCustom;
using System;

namespace QuartzExample.Api
{
    public static class SchedulerConfig
    {
        // To creat cron schedule  http://www.cronmaker.com/
        public static void Register()
        {
            IScheduler scheduler = StdSchedulerFactory.GetDefaultScheduler();

            scheduler.Start();

            IJobDetail job = JobBuilder.Create<LogJob>().Build();

            ITrigger trigger = TriggerBuilder.Create()
                .WithIdentity("LogJob", "Log")
                .WithCronSchedule("0 0/1 * 1/1 * ? *")
                .StartAt(DateTime.UtcNow)
                .WithPriority(1)
                .Build();

            scheduler.ScheduleJob(job, trigger);
        }
    }
}