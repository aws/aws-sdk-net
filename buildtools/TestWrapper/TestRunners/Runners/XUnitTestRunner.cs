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
        public enum TestConfiguration
        {
            Debug, Release
        }
        public TestConfiguration Configuration { get; set; }

        public XUnitTestRunner(FileInfo testSuiteExecutable, FileInfo testContainer, DirectoryInfo workingDirectory)
            : base(testSuiteExecutable, testContainer, workingDirectory: null)
        {
        }

        protected override ResultsSummary Run(IEnumerable<string> tests)
        {
            var args = ConstructArguments(tests);
            var log = InvokeTestSuite(args);
            var summary = ParseLog(log);
            return summary;
        }

        private string ConstructArguments(IEnumerable<string> tests)
        {
            var components = new List<string>();

            // add test switch
            components.Add("test");
            
            // add container
            components.Add(GetContainerArg(TestContainer.FullName));

            // add configuration
            components.Add(GetConfigArg(Configuration));

            // add specific tests
            var testsList = tests.ToList();
            if (testsList.Count > 0)
            {
                var testsArgs = tests.Select(GetTestArg);
                components.AddRange(testsArgs);
            }
            // if there are no specific tests, add categories
            else if (Categories != null && Categories.Length > 0)
            {
                var categoryArgs = Categories.Select(GetCategoryArg);
                components.AddRange(categoryArgs);
            }

            var args = string.Join(" ", components);
            return args;
        }
        private static string GetContainerArg(string container)
        {
            return QuoteArg(container);
        }
        private static string GetTestArg(string testName)
        {
            return string.Format("-method {0}", QuoteArg(testName));
        }
        private static string GetCategoryArg(string categoryName)
        {
            var categoryEquals = string.Format("Category={0}", categoryName);
            return string.Format("-trait {0}", QuoteArg(categoryEquals));
        }
        private static string GetConfigArg(TestConfiguration config)
        {
            return string.Format("-c {0}", QuoteArg(config.ToString()));
        }

        private static ResultsSummary ParseLog(string log)
        {
            string[] lines = log.Trim().Split('\n');
            List<string> failedTests = GetFailedTests(lines);
            int passed = 0, failed = 0, skipped = 0;
            ExtractSummary(lines, out passed, out failed, out skipped);
            return new ResultsSummary(log, failedTests, passed, failed, skipped);
        }

        private static Regex summaryRegex = new Regex(@"Total:\s*(\d*).*Errors:\s*(\d*).*Failed:\s*(\d*).*Skipped:\s*(\d*).*");
        private static void ExtractSummary(string[] lines, out int passedCount, out int failedCount, out int skippedCount)
        {
            int total = 0;
            int errors = 0;
            int failed = 0;
            int skipped = 0;

            for (int i = lines.Length - 1; i >= 0; i--)
            {
                string line = lines[i].Trim();

                if (line.IndexOf(@"=== TEST EXECUTION SUMMARY ===", StringComparison.OrdinalIgnoreCase) >= 0)
                {
                    throw new Exception("Failed to parse the output while generating test run summary.");
                }

                Match match = summaryRegex.Match(line);
                if (match.Success)
                {
                    total = Int32.Parse(match.Groups[1].ToString());
                    errors = Int32.Parse(match.Groups[2].ToString());
                    failed = Int32.Parse(match.Groups[3].ToString());
                    skipped = Int32.Parse(match.Groups[4].ToString());
                    break;
                }
            }
            passedCount = total - errors - failed;
            failedCount = errors + failed;
            skippedCount = skipped;
        }


        private static Regex failedTestNameRegex = new Regex(@"\s*([\d\w\.]*).*\[FAIL\]");
        private static string ExtractFailedTestName(string line)
        {
            Match match = failedTestNameRegex.Match(line);
            return match.Success ? match.Groups[1].ToString() : null;
        }
        private static List<string> GetFailedTests(string[] lines)
        {
            return lines.Select(ExtractFailedTestName)
                        .Where(testName => !string.IsNullOrEmpty(testName))
                        .ToList();
        }
    }
}
