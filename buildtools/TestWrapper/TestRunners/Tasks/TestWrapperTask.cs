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
        public ITaskItem[] Categories { get; set; }
        public ITaskItem TestSuiteRunner { get; set; }
        public ITaskItem TestContainer { get; set; }

        protected FileInfo TestContainerFileInfo { get { return new FileInfo(TestContainer.ItemSpec); } }
        protected FileInfo TestSuiteRunnerFileInfo { get { return new FileInfo(TestSuiteRunner.ItemSpec); } }
        protected string[] CategoriesArray
        {
            get
            {
                string[] array = null;
                if (Categories != null)
                {
                    array = Categories
                        .Select(ti => ti.ItemSpec)
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
            return Runner.RunTests();
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
