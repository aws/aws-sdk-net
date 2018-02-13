using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Text.RegularExpressions;

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
        private const int MAX_CONSECUTIVE_FAILURES_DEFAULT = 3;
        private static readonly HashSet<char> CHARS_TO_QUOTE_ON = new HashSet<char>
        {
            ' ',
            '\t',
        };

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
        }

        public string RunnerName { get; set; }
        public int MaxTestRuns { get; set; }
        public int MaxConsecutiveFailures { get; set; }
        public string TestSuiteExecutable { get; private set; }
        public FileInfo TestContainer { get; private set; }
        public DirectoryInfo WorkingDirectory { get; private set; }
        public string[] Categories { get; set; }
        public TestConfiguration Configuration { get; set; }

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

                    if (summary.ExitCode != 0)
                    {
                        consecutiveFailureCount++;
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
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Exception occurred running tests:\n {0}", e.ToString());
                exception = e;
                allTestsPassed = false;
            }

            return allTestsPassed;
        }

        protected ResultsSummary Run(IEnumerable<string> tests)
        {
            var args = ConstructArguments(tests);
            string log;
            int exitCode = InvokeTestSuite(args, out log);
            var summary = ParseLog(exitCode, log);
            return summary;
        }

        protected abstract string ConstructArguments(IEnumerable<string> tests);
        
        private static ResultsSummary ParseLog(int exitCode, string log)
        {
            string[] lines = log.Trim().Split('\n');
            List<string> failedTests = GetFailedTests(lines);
            int passed = 0, failed = 0, skipped = 0;
            ExtractSummary(lines, out passed, out failed, out skipped);
            return new ResultsSummary(exitCode, log, failedTests, passed, failed, skipped);
        }

        private static Regex summaryRegex = new Regex(@"Total tests:\s*(\d*).*Failed:\s*(\d*).*Skipped:\s*(\d*).*");
        private static void ExtractSummary(string[] lines, out int passedCount, out int failedCount, out int skippedCount)
        {
            int total = 0;
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
                    failed = Int32.Parse(match.Groups[2].ToString());
                    skipped = Int32.Parse(match.Groups[3].ToString());
                    break;
                }
            }
            passedCount = total - failed;
            failedCount = failed;
            skippedCount = skipped;
        }

        private static string ExtractFailedTestName(string line)
        {
            return line.StartsWith("Failed") ? line.Substring(6).Trim() : null;
        }
        private static List<string> GetFailedTests(string[] lines)
        {
            return lines.Select(ExtractFailedTestName)
                        .Where(testName => !string.IsNullOrEmpty(testName))
                        .ToList();
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

        protected int InvokeTestSuite(string args, out string log)
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

            using (var writer = new StringWriter())
            {
                writer.WriteLine(output);
                if (!string.IsNullOrEmpty(error))
                {
                    writer.WriteLine("StdErr:");
                    writer.WriteLine(error);
                }
                if (exitCode != 0)
                    writer.WriteLine("Exit code = {0}", exitCode);

                log = writer.ToString();
            }

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
    }
}
