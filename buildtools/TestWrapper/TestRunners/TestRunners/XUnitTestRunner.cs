using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;
using System.Text.RegularExpressions;

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

            Process xunit = new Process();
            xunit.StartInfo.UseShellExecute = false;
            xunit.StartInfo.RedirectStandardOutput = true;
            xunit.StartInfo.RedirectStandardError = true;
            xunit.StartInfo.FileName = this.executable;
            xunit.StartInfo.Arguments = GetArguments(tests);
            xunit.EnableRaisingEvents = true;

            DataReceivedEventHandler sink = new DataReceivedEventHandler
            (
                delegate (object sender, DataReceivedEventArgs e)
                {
                    Console.WriteLine(e.Data);
                    buffer.AppendLine(e.Data);
                }
            );
            xunit.OutputDataReceived += sink;
            xunit.ErrorDataReceived += sink;

            xunit.Start();
            xunit.BeginOutputReadLine();
            xunit.BeginErrorReadLine();
            xunit.WaitForExit();

            string log = buffer.ToString();
            string[] lines = log.Trim().Split('\n');
            List<string> failedTests = GetFailedTests(lines);
            Tuple<int, int, int> metrics = ExtractSummary(lines);

            return new ResultsSummary(log, failedTests, metrics.Item1, metrics.Item2, metrics.Item3);
        }

        private string GetArguments(IEnumerable<string> tests)
        {
            string testsArgument = "";
            foreach (string test in tests)
            {
                if (!String.IsNullOrWhiteSpace(test))
                {
                    testsArgument += String.Format(" -method \"{0}\"", test);
                }
            }

            return String.Format("{0} {1}", String.Join(" ", this.arguments), testsArgument);
        }

        private static Regex summaryRegex = new Regex(@"Total:\s*(\d*).*Errors:\s*(\d*).*Failed:\s*(\d*).*Skipped:\s*(\d*).*");
        private Tuple<int, int, int> ExtractSummary(string[] lines)
        {
            int total = 0;
            int errors = 0;
            int failed = 0;
            int skipped = 0;

            for (int i = lines.Length - 1; i >= 0; i--)
            {
                string line = lines[i].Trim();

                if (line.Equals(@"=== TEST EXECUTION SUMMARY ==="))
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
            return new Tuple<int, int, int>(total - errors - failed, errors + failed, skipped);
        }


        private static Regex failedTestNameRegex = new Regex(@"\s*([\d\w\.]*).*\[FAIL\]");
        private string ExtractFailedTestName(string line)
        {
            Match match = failedTestNameRegex.Match(line);
            return match.Success ? match.Groups[1].ToString() : null;
        }

        private List<string> GetFailedTests(string[] lines)
        {
            List<string> failedTestNames = new List<string>();
            foreach (string line in lines)
            {
                string failedTestName = ExtractFailedTestName(line);
                if (!String.IsNullOrEmpty(failedTestName))
                {
                    failedTestNames.Add(failedTestName);
                }                
            }
            return failedTestNames;
        }

        public override string ToString()
        {
            return String.Format("Executable : {0}\nBase Arguments: {1}", this.executable, GetArguments(new List<string>()));
        }
    }
}
