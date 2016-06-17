using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;
using System.IO;
using System.Linq;

namespace TestWrapper
{
    class MSTestRunner : ITestRunner
    {
        private string executable;
        private string[] arguments;

        public MSTestRunner(string executable, string[] arguments)
        {
            this.executable = executable;
            this.arguments = arguments;
        }

        public ResultsSummary RunTests(IEnumerable<string> tests)
        {
            Process process = new Process()
            {
                StartInfo = new ProcessStartInfo
                {
                    FileName = executable,
                    Arguments = GetAdditionalArgs(tests),
                    RedirectStandardOutput = true,
                    UseShellExecute = false,
                },
                EnableRaisingEvents = true,
            };
            StringBuilder buffer = new StringBuilder();
            process.OutputDataReceived += (s, e) =>
                {
                    Console.WriteLine(e.Data);
                    buffer.AppendLine(e.Data);
                };

            process.Start();
            process.BeginOutputReadLine();
            process.WaitForExit();

            return ParseMSTestOutput(buffer.ToString());
        }

        private static ResultsSummary ParseMSTestOutput(string output)
        {
            bool foundSummary = false;
            string line = null;
            int passed = 0;
            int failed = 0;
            List<string> failedTests = new List<string>();

            using (StringReader reader = new StringReader(output))
            {
                while ((line = reader.ReadLine()) != null)
                {
                    if (line.StartsWith("Summary") || line.StartsWith("Final Test Results"))
                    {
                        foundSummary = true;
                        break;
                    }

                    if (line.StartsWith("Passed"))
                        passed++;
                    if (line.StartsWith("Failed"))
                    {
                        failed++;

                        var testName = line.Substring(line.IndexOf(' ')).Trim();
                        failedTests.Add(testName);
                    }
                }
            }

            if (!foundSummary)
            {
                throw new Exception("Failed to parse mstest output");
            }

            return new ResultsSummary(output, failedTests, passed, failed, 0);
        }

        private string GetAdditionalArgs(IEnumerable<string> tests)
        {
            string args = string.Join(" ", this.arguments);
            string testsArg = string.Join(" ", tests.Select(testName => "/test:" + testName));
            return string.Format("{0} {1}", args, testsArg);
        }

        public override string ToString()
        {
            return string.Format("Exectuable : {0}\nBase Arguments : {1}", this.executable, string.Join(" ", this.arguments));
        }
    }
}
