using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;

using System.Text.RegularExpressions;
using System.Threading;
using System.Xml;
using System.Xml.Linq;
using Amazon.Runtime.CredentialManagement;

namespace TestWrapper.TestRunners
{
    public abstract class TestRunner
    {
        public enum TestConfiguration
        {
            Debug, Release
        }

        private readonly static TimeSpan MAX_SINGLE_EXEC_TIME = TimeSpan.FromHours(2);
        private const int MAX_TEST_RUNS_DEFAULT = 15;
        private const int MAX_CONSECUTIVE_FAILURES_DEFAULT = 5;
        private static readonly HashSet<char> CHARS_TO_QUOTE_ON = new HashSet<char>
        {
            ' ',
            '\t',
        };
        private const string AWS_PROFILE_ENVIRONMENT_VARIABLE = "AWS_PROFILE";

        protected TestRunner(string testSuiteExecutable, FileInfo testContainer, DirectoryInfo workingDirectory)
        {
            ValidateFileInfo(testContainer, nameof(testContainer));
            if (workingDirectory != null && !workingDirectory.Exists)
            {
                throw new ArgumentOutOfRangeException(nameof(workingDirectory), "Directory not found at location " + workingDirectory.FullName);
            }

            TestSuiteExecutable = testSuiteExecutable;
            TestContainer = testContainer;
            WorkingDirectory = workingDirectory == null ? TestContainer.Directory : workingDirectory;
            RunnerName = this.GetType().Name;
            MaxTestRuns = MAX_TEST_RUNS_DEFAULT;
            MaxConsecutiveFailures = MAX_CONSECUTIVE_FAILURES_DEFAULT;
            TestResultsPath = Path.Combine(TestContainer.DirectoryName, "TestResults");
        }

        public string RunnerName { get; set; }
        public int MaxTestRuns { get; set; }
        public int MaxConsecutiveFailures { get; set; }
        public string TestSuiteExecutable { get; private set; }
        public FileInfo TestContainer { get; private set; }
        public DirectoryInfo WorkingDirectory { get; private set; }
        public string FrameworkCategoryAttribute { get; set; }
        public string[] Categories { get; set; }
        public string[] CategoriesToIgnore { get; set; }
        public TestConfiguration Configuration { get; set; }
        public string TestExecutionProfile { get; set; }

        /// <summary>
        /// Whether the final test results file should be kept on disk.
        /// If set to true, the TRX file will not be deleted after all tests run successfully or
        /// all retries are exhausted.
        /// </summary>
        public bool KeepTestResults { get; set; }

        /// <summary>
        /// Specified the framework to use for testing. This is typically the framework that the
        /// test project has been built as in multi-target solutions. The default is to not specify
        /// a TargetFramework.
        /// </summary>
        public string TargetFramework { get; set; }

        /// <summary>
        /// Specifies the path to the TestResults folder. By default this will be the same as the project 
        /// directory but there are cases when running the build test dll where the path will not be
        /// the same as the project.
        /// </summary>
        public string TestResultsPath { get; set; }

        /// <summary>
        /// Run the tests for this test runner.
        /// </summary>
        /// <param name="failedTestNames">A list of the names of failed tests, if any.</param>
        /// <param name="exception">The exception that occurred while running tests, or null.</param>
        /// <returns>True if all tests passed, false otherwise.</returns>
        public bool RunTests(out IList<string> failedTestNames, out Exception exception)
        {
            bool allTestsPassed = false;
            exception = null;
            failedTestNames = new List<string>();

            try
            {
                int prevFailedTestCount = Int32.MaxValue;
                int consecutiveFailureCount = 0;

                for (int runCount = 1; runCount < MaxTestRuns; runCount++)
                {
                    var summary = Run(failedTestNames);
                    failedTestNames = summary.FailedTestNames;
                    Console.WriteLine("====== TestWrapper Run Attempt {0} =====", runCount);
                    Console.WriteLine(RunnerName);
                    Console.WriteLine(summary);
                    Console.WriteLine("=======================");

                    // If there were no Retryable test failures then stop all retries.
                    if(summary.ContainsNoRetryableTests)
                    {
                        break;
                    }

                    if (summary.ExitCode != 0)
                    {                        
                        prevFailedTestCount = summary.Failed;
                    }

                    var anyRan = summary.Passed > 0 || summary.Failed > 0;
                    if (!anyRan)
                    {
                        break;
                    }

                    allTestsPassed = summary.Failed == 0;
                    if (allTestsPassed)
                    {
                        break;
                    }

                    if (summary.Failed < prevFailedTestCount)
                    {
                        prevFailedTestCount = summary.Failed;
                        consecutiveFailureCount = 0;
                    }
                    else if (consecutiveFailureCount < MaxConsecutiveFailures)
                    {
                        consecutiveFailureCount++;
                    }
                    else
                    {
                        break;
                    }

                    // If the max number of retries hasn't been reached yet, delete the current test results file.
                    if (runCount < MaxTestRuns)
                    {
                        CleanUpTestResults();
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Exception occurred running tests:\n {0}", e.ToString());
                exception = e;
                allTestsPassed = false;
            }

            // At this point, the tests have completed (either successfully or not), but we check
            // if whoever invoked the task requested the results files should be maintained.
            if (!KeepTestResults)
            {
                CleanUpTestResults();
            }

            return allTestsPassed;
        }

        protected ResultsSummary Run(IEnumerable<string> tests)
        {
            var args = ConstructArguments(tests);
            int exitCode = InvokeTestSuite(args, out var logLocation);
            var summary = ParseLog(exitCode, logLocation);

            return summary;
        }

        private void CleanUpTestResults()
        {
            Directory.Delete(TestResultsPath, true);
        }
        
        private static ResultsSummary ParseLog(int exitCode, string logLocation)
        {
            XNamespace ns = "http://microsoft.com/schemas/VisualStudio/TeamTest/2010";

            var testRun = XElement.Load(logLocation);

            var resultSummary = testRun
                .Descendants(ns + "ResultSummary")
                .First();

            var statistics = resultSummary
                .Descendants(ns + "Counters")
                .First()
                .Attributes()
                .ToDictionary(stat => stat.Name.LocalName, stat => int.Parse(stat.Value));

            var passedCount = statistics["passed"];
            var failedCount = statistics["failed"];
            var skippedCount = statistics["total"] - statistics["executed"];

            var unitTestResults = testRun
                .Descendants(ns + "Results")
                .Descendants(ns + "UnitTestResult");

            /*
            * Previously, there was one query looking at all failed test results in the trx file.
            * However, there are a few methods which use [DataTest] and [DataRow] attributes, and in their case
            * the output will look something like this (one line for the test name and one line for each input):
            *    Failed Tests :
            *     TestMethod01
            *     TestMethod01 (abc)
            *     TestMethod01 (xyz)
            * In the XML file, the input lines will be inside an "InnerResults" element and contain an attribute
            * called "parentExecutionId". We don't want to include them in the results summary (only the parent test name).
            */
            var singleTests = unitTestResults.Where(ele => !ele.Descendants(ns + "InnerResults").Any() && !ele.Attributes("parentExecutionId").Any());
            var dataRowTests = unitTestResults.Where(ele => ele.Descendants(ns + "InnerResults").Any());
            
            var failedTests = singleTests.Union(dataRowTests)
                .Where(ele => ele.Attributes("outcome").First().Value == "Failed")
                .Select(ele => ele.Attributes("testName").First().Value)
                .ToList();

            var containsNoRetryableTests = false;
            var testReportContent = File.ReadAllText(logLocation);
            if (ResultsSummary.NO_RETRYABLE_STRINGS.Any(x => testReportContent.Contains(x)))
            {
                containsNoRetryableTests = true;
            }


            return new ResultsSummary(exitCode, failedTests, passedCount, failedCount, skippedCount, containsNoRetryableTests);
        }

        private static void ValidateFileInfo(FileInfo fileInfo, string argName)
        {
            if (fileInfo == null)
                throw new ArgumentNullException(argName);
            if (!fileInfo.Exists)
                throw new ArgumentOutOfRangeException(argName, "File not found at location " + fileInfo.FullName);
        }
        protected static string QuoteArg(string arg)
        {
            if (arg == null)
                throw new ArgumentNullException(nameof(arg));
            if (arg.IndexOf('"') >= 0)
                throw new ArgumentOutOfRangeException(nameof(arg), "Quotes are unexpected here");

            var shouldQuote = arg.Any(c => CHARS_TO_QUOTE_ON.Contains(c));
            if (shouldQuote)
                return string.Format("\"{0}\"", arg);
            else
                return arg;
        }

        protected int InvokeTestSuite(string args, out string logLocation)
        {
            var workingDir = WorkingDirectory.FullName;
            var file = TestSuiteExecutable;
            var si = new ProcessStartInfo
            {
                FileName = file,
                Arguments = args,
                UseShellExecute = false,
                RedirectStandardOutput = true,
                RedirectStandardError = true
            };

            Console.WriteLine("Invoking tests.");
            Console.WriteLine("File: {0}", file);
            Console.WriteLine("Args: {0}", args);
            Console.WriteLine("Dir:  {0}", workingDir);
            if (!string.IsNullOrWhiteSpace(TestExecutionProfile))
            {
                var chain = new CredentialProfileStoreChain();
                CredentialProfile profile;
                if (chain.TryGetProfile(TestExecutionProfile, out profile))
                {
                    Console.WriteLine($"Profile '{TestExecutionProfile}' found.");
                    si.EnvironmentVariables[AWS_PROFILE_ENVIRONMENT_VARIABLE] = TestExecutionProfile;
                    Console.WriteLine($"TestExecutionProfile: {TestExecutionProfile}");
                }
                else
                {
                    Console.WriteLine($"Profile '{TestExecutionProfile}' not found, ignoring the TestExecutionProfile attribute on test wrapper build task.");
                }
            }

            string error;
            string output;
            int exitCode;
            using (var outWriter = new StringWriter())
            using (var errWriter = new StringWriter())
            using (var p = new Process())
            {
                p.StartInfo = si;
                p.OutputDataReceived += LogMultiple(Console.Out, outWriter);
                p.ErrorDataReceived += LogMultiple(Console.Error, errWriter);
                p.Start();
                p.BeginOutputReadLine();
                p.BeginErrorReadLine();
                
                if (p.WaitForExit((int)MAX_SINGLE_EXEC_TIME.TotalMilliseconds))
                {
                    p.WaitForExit();
                }


                output = outWriter.ToString();
                error = errWriter.ToString();
                exitCode = p.ExitCode;

                if (!p.HasExited)
                {
                    var separator = new string('-', 10);
                    using (var sw = new StringWriter())
                    {
                        sw.WriteLine("Process is stuck!");
                        sw.WriteLine("StdOut");
                        sw.WriteLine(separator);
                        sw.WriteLine(output);
                        sw.WriteLine(separator);
                        sw.WriteLine("ErrOut");
                        sw.WriteLine(separator);
                        sw.WriteLine(error);
                        sw.WriteLine(separator);
                        var message = sw.ToString();

                        try
                        {
                            p.Kill();
                        }
                        catch (Exception) { }
                        throw new InvalidOperationException(message);
                    }
                }

                p.Close();
            }

            logLocation = Directory.GetFiles(TestResultsPath)
                .Select(fileName => new FileInfo(fileName))
                .OrderByDescending(fileInfo => fileInfo.CreationTime)
                .First().FullName;

            return exitCode;
        }
        private static DataReceivedEventHandler LogMultiple(TextWriter consoleWriter, StringWriter stringWriter)
        {
            return (s, e) =>
            {
                var data = e.Data;
                stringWriter.WriteLine(data);
                consoleWriter.WriteLine(data);
            };
        }

        protected virtual string ConstructArguments(IEnumerable<string> tests)
        {
            var components = new List<string>();

            // add test switch
            components.Add("test");

            // add container
            components.Add(GetContainerArg(TestContainer.FullName));

            if(!string.IsNullOrEmpty(TargetFramework))
            {
                // add the target framework
                components.Add($"-f {TargetFramework}");
            }

            // change logger to trx
            components.Add("--logger trx");

            // set the results directory so it will always be a predictable value.
            components.Add($"--results-directory \"{TestResultsPath}\"");

            // add configuration
            components.Add(GetConfigArg(Configuration));

            // add specific tests
            // dotnet test cannot handle parameterized test reruns (queries), so collapsing those failures to their distinct top theory
            var testsList = tests.Select(testName => Regex.Replace(testName, @"\(.*\)$", "")).Distinct().ToList();

            string filter = null;
            if (testsList.Count > 0)
            {
                filter = string.Join("|", testsList.Select(GetTestArg));
            }
            else if (Categories != null && Categories.Length > 0)
            {
                filter = string.Join("|", Categories.Select(GetCategoryArg));
            } 
            else if (CategoriesToIgnore != null && CategoriesToIgnore.Length > 0)
            {
                filter = string.Join("|", CategoriesToIgnore.Select(GetCategoryToIgnoreArg));
            }

            if (!string.IsNullOrEmpty(filter))
            {
                components.Add(string.Format("--filter \"{0}\"", filter));
            }

            components.Add("--no-build");

            var args = string.Join(" ", components);
            return args;
        }

        protected virtual string GetContainerArg(string container)
        {
            return QuoteArg(container);
        }

        protected virtual string GetTestArg(string testName)
        {
            if (testName.Contains("."))
            {
                // assume a "." means it's a fully qualified name
                return string.Format("FullyQualifiedName={0}", QuoteArg(testName));
            }
            else
            {
                // assume no "." means it's a test method name
                return string.Format("Name={0}", QuoteArg(testName.Trim(' ')));
            }
        }

        protected virtual string GetCategoryArg(string categoryName)
        {
            return string.Format("{0}={1}", FrameworkCategoryAttribute, categoryName);
        }

        protected virtual string GetCategoryToIgnoreArg(string categoryName)
        {
            return string.Format("{0}!={1}", FrameworkCategoryAttribute, categoryName);
        }

        protected virtual string GetConfigArg(TestConfiguration config)
        {
            return string.Format("-c {0}", QuoteArg(config.ToString()));
        }
    }
}
