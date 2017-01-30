using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;
using System.IO;
using System.Linq;
using TestWrapper.TestRunners;

namespace TestWrapper
{
    // MSTest.exe command-line options
    //  https://msdn.microsoft.com/en-us/library/ms182489.aspx
    public class MSTestRunner : TestRunner
    {
        private const string RESULTS_FILE_TEXT = "Results file:";
        public DirectoryInfo ResultsOutputDir { get; set; }

        public MSTestRunner(FileInfo testSuiteExecutable, FileInfo testAssembly, DirectoryInfo workingDirectory)
            : base(testSuiteExecutable, testAssembly, workingDirectory)
        {
        }

        protected override ResultsSummary Run(IEnumerable<string> tests)
        {
            var args = ConstructArguments(tests);
            var output = InvokeTestSuite(args);
            var summary = ParseMSTestOutput(output);
            return summary;
        }

        private ResultsSummary ParseMSTestOutput(string output)
        {
            bool foundSummary = false;
            string line = null;
            int passed = 0;
            int failed = 0;
            List<string> failedTests = new List<string>();
            string resultsFile = null;

            using (StringReader reader = new StringReader(output))
            {
                while ((line = reader.ReadLine()) != null)
                {
                    if (line.StartsWith("Summary") || line.StartsWith("Final Test Results"))
                        foundSummary = true;

                    if (!foundSummary && line.StartsWith("Passed"))
                        passed++;
                    if (!foundSummary && line.StartsWith("Failed"))
                    {
                        failed++;

                        var testName = line.Substring(line.IndexOf(' ')).Trim();
                        failedTests.Add(testName);
                    }

                    if (foundSummary && line.StartsWith(RESULTS_FILE_TEXT))
                    {
                        resultsFile = line.Substring(line.IndexOf(RESULTS_FILE_TEXT) + RESULTS_FILE_TEXT.Length).Trim();
                    }
                }
            }

            if (!foundSummary)
            {
                throw new Exception("Failed to parse mstest output");
            }

            if (!string.IsNullOrEmpty(resultsFile) && ResultsOutputDir != null)
            {
                CopyResultFile(resultsFile);
            }

            return new ResultsSummary(output, failedTests, passed, failed, 0);
        }
        private void CopyResultFile(string resultsFile)
        {
            if (string.IsNullOrEmpty(resultsFile)) throw new ArgumentNullException(nameof(resultsFile));
            var source = new FileInfo(resultsFile);
            if (!source.Exists) throw new ArgumentOutOfRangeException(nameof(resultsFile), $"{resultsFile} does not exist");
            if (!ResultsOutputDir.Exists)
                ResultsOutputDir.Create();

            var fileName = Path.GetFileName(source.FullName);
            var newFileName = Path.GetFileNameWithoutExtension(fileName) + ".xml";
            var destFilePath = Path.Combine(ResultsOutputDir.FullName, newFileName);
            source.CopyTo(destFilePath);
        }
        private string ConstructArguments(IEnumerable<string> tests)
        {
            var arguments = new List<string>();

            // add container
            arguments.Add(GetContainerArg(TestContainer.FullName));

            // add specific tests
            var testsList = tests.ToList();
            if (testsList.Count > 0)
            {
                var testsArgs = tests.Select(GetTestArg);
                arguments.AddRange(testsArgs);
            }
            // if there are no specific tests, add categories
            else if (Categories != null && Categories.Length > 0)
            {
                var categoriesArg = GetCategoryArg(Categories);
                arguments.Add(categoriesArg);
            }

            var args = string.Join(" ", arguments);
            return args;
        }
        private static string GetContainerArg(string assemblyName)
        {
            return string.Format("/testcontainer:{0}", QuoteArg(assemblyName));
        }
        private static string GetTestArg(string testName)
        {
            return string.Format("/test:{0}", QuoteArg(testName));
        }
        private static string GetCategoryArg(string[] categoryNames)
        {
            var categoriesOr = string.Join("|", categoryNames);
            return string.Format("/category:{0}", QuoteArg(categoriesOr));
        }
    }
}
