using System;
using Microsoft.Build.Utilities;
using System.Diagnostics;
using System.Threading;

namespace CustomTasks
{
    public abstract class BuildTaskBase : Task
    {
        public bool WaitForDebugger { get; set; }
        public int MaxAttempts { get; set; }

        public BuildTaskBase()
        {
            WaitForDebugger = false;
            MaxAttempts = 10;
        }

        protected void CheckWaitForDebugger()
        {
            if (WaitForDebugger)
            {
                Log.LogMessage("MSBuild process id: {0}", Process.GetCurrentProcess().Id);
                Log.LogMessage("Waiting for debugger to be attached");
                while (!Debugger.IsAttached)
                {
                    Thread.Sleep(TimeSpan.FromSeconds(1));
                }
                Debugger.Break();
            }
        }

        public override bool Execute()
        {
            if (MaxAttempts <= 0)
                throw new ArgumentOutOfRangeException("MaxAttempts");

            CheckWaitForDebugger();

            for (int i = 0; i < MaxAttempts; i++)
            {
                try
                {
                    var result = RetriableExecute();
                    if (result)
                        return true;
                }
                catch (Exception e)
                {
                    Log.LogWarning("Failed attempt {0}: {1}", (i + 1), e);
                }
            }

            Log.LogError("Attempted task {0} times without success", MaxAttempts);
            return false;
        }

        protected virtual bool RetriableExecute()
        {
            return true;
        }
    }
}
