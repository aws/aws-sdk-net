using System;
using System.Collections.Generic;
using System.IO;

namespace TestWrapper
{
    public class ResultsSummary
    {
        public readonly static IList<string> NO_RETRYABLE_STRINGS = new List<string>
        {
            "The request signature we calculated does not match the signature you provided."
        };

        public ResultsSummary(
            int exitCode,
            IList<string> failedTests,
            int passed, int failed, int skipped, bool containsNoRetryableTests)
        {
            this.ExitCode = exitCode;
            this.FailedTestNames = failedTests;
            this.Passed = passed;
            this.Failed = failed;
            this.Skipped = skipped;
            this.ContainsNoRetryableTests = containsNoRetryableTests;
        }

        public IList<string> FailedTestNames { get; private set; }
        public int Passed { get; private set; }
        public int Failed { get; private set; }
        public int Skipped { get; private set; }
        public int ExitCode { get; private set; }

        public bool ContainsNoRetryableTests { get; private set; }

        public override string ToString()
        {
            using (StringWriter writer = new StringWriter())
            {
                if (0 < this.FailedTestNames.Count)
                {
                    writer.WriteLine("Failed Tests :");
                    foreach (string testName in this.FailedTestNames)
                    {
                        writer.WriteLine(String.Format("\t{0}\n", testName));
                    }
                }

                writer.WriteLine("Passed : {0}, Failed : {1}", this.Passed, this.Failed);

                if(this.ContainsNoRetryableTests)
                {
                    writer.WriteLine($"Non Retryable failed tests found");
                }
                return writer.ToString();
            }
        }
    }
}
