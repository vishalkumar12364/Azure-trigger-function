using System;
using Microsoft.Azure.WebJobs;
using Microsoft.Extensions.Logging;

namespace Azure_trigger_function
{
    public static class TimerFunction
    {
        [FunctionName("TimerFunction")]
        public static void Run([TimerTrigger("0,10 * * * * *")]TimerInfo myTimer, ILogger log)
        {
            log.LogInformation($"C# Timer trigger function executed at: {DateTime.Now}");
        }
    }
}
