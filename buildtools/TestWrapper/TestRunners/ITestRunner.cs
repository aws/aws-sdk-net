using System;
using System.Collections.Generic;
using System.Text;

namespace TestWrapper
{
    public class ResultsSummary
    {
        public ResultsSummary()
        {
            this.FailedTestNames = new List<string>();
        }

        public ResultsSummary(string log, IList<string> failedTests, int passed, int failed, int skipped)
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
        public string Log { get; private set;  }

        public override string ToString()
        {
            StringBuilder builder = new StringBuilder();

            if (0 < this.FailedTestNames.Count)
            { 
                builder.Append("Failed Tests : \n");
                foreach (string testName in this.FailedTestNames)
                {
                    builder.Append(String.Format("\t{0}\n", testName));
                }
            }
            
            builder.Append(String.Format("Passed : {0}, Failed : {1}", this.Passed, this.Failed));
            return builder.ToString();
        }
    }

    interface ITestRunner
    {
        ResultsSummary RunTests(IEnumerable<string> tests);
    }
}
