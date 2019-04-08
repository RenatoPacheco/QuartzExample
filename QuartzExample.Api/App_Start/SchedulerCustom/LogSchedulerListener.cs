using Quartz;
using System.Threading;
using System.Threading.Tasks;

namespace QuartzExample.Api.App_Start.SchedulerCustom
{
    public class LogSchedulerListener : ISchedulerListener
    {
        public async Task JobAdded(IJobDetail jobDetail, CancellationToken cancellationToken = default(CancellationToken))
        {

        }

        public async Task JobDeleted(JobKey jobKey, CancellationToken cancellationToken = default(CancellationToken))
        {

        }

        public async Task JobInterrupted(JobKey jobKey, CancellationToken cancellationToken = default(CancellationToken))
        {

        }

        public async Task JobPaused(JobKey jobKey, CancellationToken cancellationToken = default(CancellationToken))
        {

        }

        public async Task JobResumed(JobKey jobKey, CancellationToken cancellationToken = default(CancellationToken))
        {

        }

        public async Task JobScheduled(ITrigger trigger, CancellationToken cancellationToken = default(CancellationToken))
        {

        }

        public async Task JobsPaused(string jobGroup, CancellationToken cancellationToken = default(CancellationToken))
        {

        }

        public async Task JobsResumed(string jobGroup, CancellationToken cancellationToken = default(CancellationToken))
        {

        }

        public async Task JobUnscheduled(TriggerKey triggerKey, CancellationToken cancellationToken = default(CancellationToken))
        {

        }

        public async Task SchedulerError(string msg, SchedulerException cause, CancellationToken cancellationToken = default(CancellationToken))
        {

        }

        public async Task SchedulerInStandbyMode(CancellationToken cancellationToken = default(CancellationToken))
        {

        }

        public async Task SchedulerShutdown(CancellationToken cancellationToken = default(CancellationToken))
        {

        }

        public async Task SchedulerShuttingdown(CancellationToken cancellationToken = default(CancellationToken))
        {

        }

        public async Task SchedulerStarted(CancellationToken cancellationToken = default(CancellationToken))
        {

        }

        public async Task SchedulerStarting(CancellationToken cancellationToken = default(CancellationToken))
        {

        }

        public async Task SchedulingDataCleared(CancellationToken cancellationToken = default(CancellationToken))
        {

        }

        public async Task TriggerFinalized(ITrigger trigger, CancellationToken cancellationToken = default(CancellationToken))
        {

        }

        public async Task TriggerPaused(TriggerKey triggerKey, CancellationToken cancellationToken = default(CancellationToken))
        {

        }

        public async Task TriggerResumed(TriggerKey triggerKey, CancellationToken cancellationToken = default(CancellationToken))
        {

        }

        public async Task TriggersPaused(string triggerGroup, CancellationToken cancellationToken = default(CancellationToken))
        {

        }

        public async Task TriggersResumed(string triggerGroup, CancellationToken cancellationToken = default(CancellationToken))
        {

        }
    }
}