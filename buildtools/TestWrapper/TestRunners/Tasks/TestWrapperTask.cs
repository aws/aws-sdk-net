using Microsoft.Build.Framework;
using Microsoft.Build.Utilities;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using TestWrapper.TestRunners;

namespace TestWrapper
{
    public abstract class TestWrapperTask : Task
    {
        public bool WaitForDebugger { get; set; }
        public ITaskItem Categories { get; set; }
        public ITaskItem TestSuiteRunner { get; set; }
        public ITaskItem TestContainer { get; set; }
        public ITaskItem Configuration { get; set; }

        protected FileInfo TestContainerFileInfo { get { return new FileInfo(TestContainer.ItemSpec); } }
        protected string TestSuiteRunnerFileInfo { get { return TestSuiteRunner.ItemSpec; } }
        protected string[] CategoriesArray
        {
            get
            {
                string[] array = null;
                if (Categories != null && !string.IsNullOrEmpty(Categories.ItemSpec))
                {
                    array = Categories.ItemSpec
                        .Split(new char[] { ','}, StringSplitOptions.RemoveEmptyEntries)
                        .Where(c => c != null && !string.IsNullOrEmpty(c.Trim()))
                        .ToArray();
                }

                return array;
            }
        }
        protected TestRunner Runner { get; set; }

        public TestWrapperTask()
        {
            WaitForDebugger = false;
        }

        public override bool Execute()
        {
            CheckWaitForDebugger();
            PrepareRunner();

            IList<string> failedTestNames;
            Exception testRunException;

            if (Runner.RunTests(out failedTestNames, out testRunException))
                return true;
            else
            {
                var loggingHelper = new TaskLoggingHelper(this);
                if (failedTestNames.Count > 0)
                {
                    foreach (var name in failedTestNames)
                    {
                        loggingHelper.LogError(string.Format("Test failure in {0}: {1}", Runner.RunnerName, name));
                    }
                }

                if (testRunException != null)
                    loggingHelper.LogErrorFromException(testRunException, true, true, null);

                return false;
            }
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

        protected abstract void PrepareRunner();
    }
}
