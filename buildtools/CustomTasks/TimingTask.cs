using System;
using System.Threading;

namespace CustomTasks
{
    public class TimingTask : BuildTaskBase
    {
        private readonly static TimeSpan SleepTime = TimeSpan.FromSeconds(30);
        private static bool ShouldInit = true;
        private static Thread MainThread = null;
        private static DateTime StartTime;

        public override bool Execute()
        {
            if (ShouldInit)
            {
                ShouldInit = false;
                StartTime = DateTime.UtcNow;
                MainThread = new Thread(() =>
                {
                    try
                    {
                        while (true)
                        {
                            var elapsed = DateTime.UtcNow - StartTime;
                            Console.WriteLine(">>>>> ELAPSED TIME = " + elapsed.ToString("h'h 'm'm 's's'"));
                            Thread.Sleep(SleepTime);
                        }
                    }
                    catch(Exception e)
                    {
                        Console.WriteLine("TimingTask encountered error: " + e);
                    }
                });
                MainThread.IsBackground = true;
                MainThread.Start();
            }

            return true;
        }
    }
}
