using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Amazon.Runtime;
using System.Threading;

namespace AWSSDKDocSamples.Util
{
    public static class Common
    {
        public static void WaitUntil(Func<bool> isDoneFunc)
        {
            WaitUntil(isDoneFunc, TimeSpan.FromSeconds(5), TimeSpan.FromMinutes(10));
        }
        public static void WaitUntil(Func<bool> isDoneFunc, TimeSpan checkPeriod)
        {
            WaitUntil(isDoneFunc, checkPeriod, TimeSpan.FromMinutes(10));
        }
        public static void WaitUntil(Func<bool> isDoneFunc, TimeSpan checkPeriod, TimeSpan maxTotalWaitTime)
        {
            if (isDoneFunc == null) throw new ArgumentNullException("isDoneFunc");
            if (checkPeriod.Ticks <= 0) throw new ArgumentOutOfRangeException("checkPeriod");
            if (maxTotalWaitTime.Ticks < 0) throw new ArgumentOutOfRangeException("maxTotalWaitTime");

            DateTime startTime = DateTime.Now;
            while (true)
            {
                // check if exit criteria is reached
                if (isDoneFunc())
                    break;
                // check if maximum alotted time is reached
                if (maxTotalWaitTime.Ticks > 0 && (startTime + maxTotalWaitTime < DateTime.Now))
                    break;
                Thread.Sleep(checkPeriod);
            }
        }
    }
}
