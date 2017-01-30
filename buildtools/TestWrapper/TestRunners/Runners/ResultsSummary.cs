using System;
using System.Collections.Generic;
using System.IO;

namespace TestWrapper
{
    public class ResultsSummary
    {
        public ResultsSummary(string log,
            IList<string> failedTests,
            int passed, int failed, int skipped)
        {
            this.Log = log;
            this.FailedTestNames = failedTests;
            this.Passed = passed;
            this.Failed = failed;
            this.Skipped = skipped;
        }

        public IList<string> FailedTestNames { get; private set; }
        public int Passed { get; private set; }
        public int Failed { get; private set; }
        public int Skipped { get; private set; }
        public string Log { get; private set; }

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
                return writer.ToString();
            }
        }
    }
}
