using System;
using System.Collections.Generic;
using System.Linq;

namespace TestWrapper
{
    using CreateTestRunnerFunc = Func<string, string[], ITestRunner>;

    class RunTests
    {
        private static int MAX_TEST_RUNS = 15;
        private static int MAX_CONSECUTIVE_FAILURE = 3;
        private static bool ExecuteRunner(ITestRunner runner)
        {
            bool allTestsPassed = false;
            try
            {
                ResultsSummary summary = new ResultsSummary();
                int prevFailedTestCount = Int32.MaxValue;
                int consecutiveFailureCount = 0;
                
                for(int runCount = 1; runCount < MAX_TEST_RUNS; runCount++)
                {
                    summary = runner.RunTests(summary.FailedTestNames);
                    Console.WriteLine("====== TestWrapper Run Attempt {0} =====", runCount);
                    Console.WriteLine(runner.ToString());
                    Console.WriteLine(summary);
                    Console.WriteLine("=======================");

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
                    else if (consecutiveFailureCount < MAX_CONSECUTIVE_FAILURE)
                    {
                        consecutiveFailureCount++;
                    }
                    else
                    {
                        break;
                    }
                }
            }
            catch(Exception e)
            {
                Console.WriteLine("Exception occurred running tests:\n {0}", e.ToString());
                allTestsPassed = false;
            }

            return allTestsPassed;
        }

        private static Dictionary<string, CreateTestRunnerFunc> testRunnerMap = new Dictionary<string, CreateTestRunnerFunc>(StringComparer.OrdinalIgnoreCase)
        {
            {"mstest", (executable, arguments) => (new MSTestRunner(executable, arguments)) },
            {"xunit", (executable, arguments)=> (new XUnitTestRunner(executable, arguments)) },
        };

        private static string GetHelpString()
        {
            return @"usage: TestWrapper.exe {mstest | xunit} <test exectuable> <parameters for the test executable>";
        }

        public static int Main(string[] args)
        {
            string testRunnerType;
            string testSuiteExecutable;
            string[] testSuiteArguments;

            if (args.Length < 3)
            {
                Console.WriteLine(GetHelpString());
                return 11; // Undefined or incomplete commmandline option
            }
            else
            {
                testRunnerType = args[0].ToLower();
                testSuiteExecutable = args[1];
                testSuiteArguments = args.Skip(2).ToArray();
            }

            ITestRunner runner = null;
            CreateTestRunnerFunc createTest = null;
            if (testRunnerMap.TryGetValue(testRunnerType, out createTest))
            {
                runner = createTest(testSuiteExecutable, testSuiteArguments);
            }

            if (runner == null)
            {
                Console.WriteLine("Failed to instantiate an instance of ITestRunner associated with '{}'", testRunnerType);
                return 87; // Invalid parameter
            }
            else
            {
                if (ExecuteRunner(runner))
                {
                    Console.WriteLine("All tests passed.");
                    return 0;
                }
                else
                {
                    Console.WriteLine("Some tests failed.");
                    return 1;
                }
            }
        }
    }
}

