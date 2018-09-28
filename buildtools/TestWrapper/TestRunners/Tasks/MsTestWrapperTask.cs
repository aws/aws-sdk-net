using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Build.Utilities;
using System.IO;
using System.Reflection;
using Microsoft.Build.Framework;

using TestWrapper.TestRunners;

namespace TestWrapper
{
    public class MsTestWrapperTask : TestWrapperTask
    {
        public ITaskItem ResultsOutputDir { get; set; }

        protected override void PrepareRunner()
        {
            var msTestRunner = new MSTestRunner(TestSuiteRunnerFileInfo, TestContainerFileInfo, null);
            msTestRunner.Categories = CategoriesArray;
            msTestRunner.Configuration = Configuration == null ?
                TestRunner.TestConfiguration.Release :
                (TestRunner.TestConfiguration)Enum.Parse(typeof(TestRunner.TestConfiguration), Configuration.ItemSpec);
            msTestRunner.TestExecutionProfile = TestExecutionProfile.ItemSpec;
            Runner = msTestRunner;
        }
    }
}
