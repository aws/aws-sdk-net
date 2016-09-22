using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;
using System.Text.RegularExpressions;
using System.Linq;

namespace TestWrapper
{
    class XUnitTestRunner : ITestRunner
    {
        private string executable;
        private string[] arguments;

        public XUnitTestRunner(string executable, string[] arguments)
        {
            this.executable = executable;
            this.arguments = arguments;
        }

        public ResultsSummary RunTests(IEnumerable<string> tests)
        {
            StringBuilder buffer = new StringBuilder();

            Process xunit = new Process()
            {
                StartInfo = new ProcessStartInfo
                {
                    UseShellExecute = false,
                    RedirectStandardOutput = true,
                    RedirectStandardError = true,
                    FileName = this.executable,
                    Arguments = GetAdditionalArgs(tests),
                },
                EnableRaisingEvents = true
            };
            DataReceivedEventHandler sink = (s, e) =>
                {
                    Console.WriteLine(e.Data);
                    buffer.AppendLine(e.Data);
                };

            xunit.OutputDataReceived += sink;
            xunit.ErrorDataReceived += sink;

            xunit.Start();
            xunit.BeginOutputReadLine();
            xunit.BeginErrorReadLine();
            xunit.WaitForExit();

            string log = buffer.ToString();
            string[] lines = log.Trim().Split('\n');
            List<string> failedTests = GetFailedTests(lines);
            int passed = 0, failed = 0, skipped = 0;
            ExtractSummary(lines, out passed, out failed, out skipped);
            return new ResultsSummary(log, failedTests, passed, failed, skipped);
        }

        private string GetAdditionalArgs(IEnumerable<string> tests)
        {
            string testsArgument = string.Join(" ", tests.Select(test => string.Format("-method \"{0}\"", test)));
            return string.Format("{0} {1}", string.Join(" ", this.arguments), testsArgument);
        }

        private static Regex summaryRegex = new Regex(@"Total:\s*(\d*).*Errors:\s*(\d*).*Failed:\s*(\d*).*Skipped:\s*(\d*).*");
        private void ExtractSummary(string[] lines, out int passedCount, out int failedCount, out int skippedCount)
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
        private string ExtractFailedTestName(string line)
        {
            Match match = failedTestNameRegex.Match(line);
            return match.Success ? match.Groups[1].ToString() : null;
        }

        private List<string> GetFailedTests(string[] lines)
        {
            return lines.Select(ExtractFailedTestName)
                        .Where(testName => !string.IsNullOrEmpty(testName))
                        .ToList();
        }

        public override string ToString()
        {
            return string.Format("Executable : {0}\nBase Arguments: {1}", this.executable, GetAdditionalArgs(new List<string>()));
        }
    }
}
