using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Build.Utilities;
using System.IO;
using System.Reflection;
using Microsoft.Build.Framework;
using static TestWrapper.XUnitTestRunner;

namespace TestWrapper
{
    public class XUnitWrapperTask : TestWrapperTask
    {
        public ITaskItem Configuration { get; set; }

        protected override void PrepareRunner()
        {
            var xunitRunner = new XUnitTestRunner(TestSuiteRunnerFileInfo, TestContainerFileInfo, null);
            xunitRunner.Categories = CategoriesArray;
            xunitRunner.Configuration = Configuration == null ?
                TestConfiguration.Release :
                (TestConfiguration)Enum.Parse(typeof(TestConfiguration), Configuration.ItemSpec);

            Runner = xunitRunner;
        }
    }
}
