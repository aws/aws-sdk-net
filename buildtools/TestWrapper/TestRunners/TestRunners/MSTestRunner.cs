using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;
using System.IO;


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
            Process process = new Process();
            // Configure the process using the StartInfo properties.
            process.StartInfo.FileName = executable;
            process.StartInfo.Arguments = GetArguments(tests);
            process.StartInfo.RedirectStandardOutput = true;
            process.StartInfo.UseShellExecute = false;
            process.EnableRaisingEvents = true;
            StringBuilder buffer = new StringBuilder();
            process.OutputDataReceived += new DataReceivedEventHandler
            (
                delegate (object sender, DataReceivedEventArgs e)
                {
                    Console.WriteLine(e.Data);
                    buffer.AppendLine(e.Data);
                }
            );
            process.Start();
            process.BeginOutputReadLine();
            process.WaitForExit();

            return ParseMSTestOutput(buffer.ToString());
        }

        private static ResultsSummary ParseMSTestOutput(string output)
        {
            bool foundSummary = false;
            string line = null;
            var reader = new StringReader(output);
            int passed = 0;
            int failed = 0;
            List<string> failedTests = new List<string>();
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

            if (!foundSummary)
            {
                throw new Exception("Failed to parse mstest output");
            }

            return new ResultsSummary(output, failedTests, passed, failed, 0);
        }

        private string GetArguments(IEnumerable<string> tests)
        {
            StringBuilder arguments = new StringBuilder();
            arguments.Append(String.Join(" ", this.arguments));
            foreach (var arg in tests)
            {
                if (arguments.Length > 0)
                    arguments.Append(" ");
                arguments.Append(String.Format("/test:{0} ", arg));
            }
            return arguments.ToString();
        }

        public override string ToString()
        {
            return String.Format("Exectuable : {0}\nBase Arguments : {1}", this.executable, String.Join(" ", this.arguments));
        }
    }
}
