using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime;
using System.Xml;

namespace MSTestWrapper
{
    /// <summary>
    /// Tool to retry tests that are run by mstest. This helps us with tests that 
    /// fail because of eventual consistency issue.
    /// </summary>
    class Program
    {
        static int Main(string[] args)
        {
            try
            {
                var mstestExe = args[0];
                var mstTestArgs = new string[args.Length - 1];
                Array.Copy(args, 1, mstTestArgs, 0, mstTestArgs.Length);

                ResultsSummary msTestResults = null;
                do
                {
                    var arguments = new List<string>(mstTestArgs);
                    if (msTestResults != null)
                    {
                        Console.WriteLine("Attempting to retry tests for {0} failed tests.", msTestResults.Failed);
                        foreach(var test in msTestResults.FailedTestNames)
                        {
                            arguments.Add(string.Format("/test:{0}", test));
                        }
                    }
                    var output = RunMsTest(mstestExe, arguments);
                    var newResults = ParseMSTestOutput(output);

                    msTestResults = newResults;
                }
                while ((msTestResults.Passed > 0 && msTestResults.Failed > 0));


                if(msTestResults.Failed > 0)
                {
                    Console.WriteLine("Still failing tests after retry");
                    return 1;
                }
            }
            catch(Exception e)
            {
                Console.WriteLine("Unknown error running tests: {0}", e.Message);
                Console.WriteLine(e.StackTrace);
                return 1;
            }

            return 0;
        }

        static ResultsSummary ParseMSTestOutput(string output)
        {
            ResultsSummary summary = new ResultsSummary();

            bool foundSummary = false;
            string line = null;
            var reader = new StringReader(output);
            while((line = reader.ReadLine()) != null)
            {
                if (line.StartsWith("Summary") || line.StartsWith("Final Test Results"))
                {
                    foundSummary = true;
                    break;
                }

                if (line.StartsWith("Passed"))
                    summary.Passed++;
                if(line.StartsWith("Failed"))
                {
                    summary.Failed++;

                    var testName = line.Substring(line.IndexOf(' ')).Trim();
                    summary.FailedTestNames.Add(testName);
                }
            }

            if(!foundSummary)
            {
                throw new Exception("Failed to parse mstest output");
            }

            return summary;
        }

        static string RunMsTest(string msTestExe, IEnumerable<string> msTestArgs)
        {
            StringBuilder arguments = new StringBuilder();
            foreach(var arg in msTestArgs)
            {
                if (arguments.Length > 0)
                    arguments.Append(" ");
                arguments.Append("\"" + arg + "\"");
            }
            Process process = new Process();
            // Configure the process using the StartInfo properties.
            process.StartInfo.FileName = msTestExe;
            process.StartInfo.Arguments = arguments.ToString();
            process.StartInfo.RedirectStandardOutput = true;
            process.StartInfo.UseShellExecute = false;
            process.EnableRaisingEvents = true;
            StringBuilder buffer = new StringBuilder();
            process.OutputDataReceived += new DataReceivedEventHandler
            (
                delegate(object sender, DataReceivedEventArgs e)
                {
                    Console.WriteLine(e.Data);
                    buffer.AppendLine(e.Data);
                }
            );
            process.Start();
            process.BeginOutputReadLine();
            process.WaitForExit();


            return buffer.ToString();
        }

        public class ResultsSummary
        {
            public ResultsSummary()
            {
                FailedTestNames = new List<string>();
            }

            public IList<string> FailedTestNames { get; private set; }

            public int Passed { get; set; }
            public int Failed { get; set; }
        }
    }
}
