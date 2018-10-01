using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Build.Utilities;
using System.IO;
using System.Reflection;
using Microsoft.Build.Framework;
using static TestWrapper.XUnitTestRunner;
using TestWrapper.TestRunners;

namespace TestWrapper
{
    public class XUnitWrapperTask : TestWrapperTask
    {

        protected override void PrepareRunner()
        {
            var xunitRunner = new XUnitTestRunner(TestSuiteRunnerFileInfo, TestContainerFileInfo, null);
            xunitRunner.Categories = CategoriesArray;
            xunitRunner.Configuration = Configuration == null ?
                TestRunner.TestConfiguration.Release :
                (TestRunner.TestConfiguration)Enum.Parse(typeof(TestRunner.TestConfiguration), Configuration.ItemSpec);
            xunitRunner.TestExecutionProfile = TestExecutionProfile.ItemSpec;
            Runner = xunitRunner;
        }
    }
}
