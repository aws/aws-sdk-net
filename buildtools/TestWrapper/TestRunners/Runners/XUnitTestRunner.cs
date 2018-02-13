using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;
using System.Text.RegularExpressions;
using System.Linq;
using TestWrapper.TestRunners;
using System.IO;

namespace TestWrapper
{
    public class XUnitTestRunner : TestRunner
    {
        public XUnitTestRunner(string testSuiteExecutable, FileInfo testContainer, DirectoryInfo workingDirectory)
            : base(testSuiteExecutable, testContainer, workingDirectory: null)
        {
        }

        protected override string ConstructArguments(IEnumerable<string> tests)
        {
            var components = new List<string>();

            // add test switch
            components.Add("test");

            // add container
            components.Add(GetContainerArg(TestContainer.FullName));

            // add configuration
            components.Add(GetConfigArg(Configuration));

            // add specific tests
            string filter = null;
            var testsList = tests.ToList();
            if (testsList.Count > 0)
            {
                filter = string.Join("|", tests.Select(GetTestArg));
            }
            else if (Categories != null && Categories.Length > 0)
            {
                filter = string.Join("|", Categories.Select(GetCategoryArg));
            }

            if (!string.IsNullOrEmpty(filter))
            {
                components.Add(string.Format("--filter \"{0}\"", filter));
            }

            components.Add("--no-build");

            var args = string.Join(" ", components);
            return args;
        }
        private static string GetContainerArg(string container)
        {
            return QuoteArg(container);
        }
        private static string GetTestArg(string testName)
        {
            if (testName.Contains("."))
            {
                // assume a "." means it's a fully qualified name
                return string.Format("FullyQualifiedName={0}", QuoteArg(testName));
            }
            else
            {
                // assume no "." means it's a test method name
                return string.Format("Name={0}", QuoteArg(testName));
            }
        }

        private static string GetCategoryArg(string categoryName)
        {
            return string.Format("Category={0}", categoryName);
        }
        private static string GetConfigArg(TestConfiguration config)
        {
            return string.Format("-c {0}", QuoteArg(config.ToString()));
        }
    }
}
