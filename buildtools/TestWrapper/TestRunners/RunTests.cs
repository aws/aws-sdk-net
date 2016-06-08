using System;
using System.Collections.Generic;

namespace TestWrapper
{
    class RunTests
    {
        private static bool ExecuteRunner(ITestRunner runner)
        {
            bool allTestsPassed = false;
            try
            {
                ResultsSummary summary = new ResultsSummary();
                int prevFailedTestCount = Int32.MaxValue;
                
                for(int runCount = 1; ; runCount++)
                {
                    summary = runner.RunTests(summary.FailedTestNames);
                    Console.WriteLine(String.Format("====== TestWrapper Run Attempt {0} =====", runCount));
                    Console.WriteLine(runner.ToString());
                    Console.WriteLine(summary);
                    Console.WriteLine("=======================");

                    allTestsPassed = summary.Failed == 0;
                    if (allTestsPassed)
                    {
                        break;
                    }
                    if (summary.Failed < prevFailedTestCount)
                    {
                        prevFailedTestCount = summary.Failed;
                    }
                    else
                    {
                        break;
                    }
                }
            }
            catch(Exception e)
            {
                Console.WriteLine("Exception occurred running tests: {0}", e.Message);
                Console.WriteLine(e.StackTrace);
                allTestsPassed = false;
            }

            return allTestsPassed;
        }

        private static Dictionary<string, Type> testRunnerTypeMap = new Dictionary<string, Type>(){
            {"mstest",  typeof(MSTestRunner)},
            {"xunit",   typeof(XUnitTestRunner)},
        };

        private static string GetHelpString()
        {
            return @"usage: TestWrappe.exe {mstest | xunit} <test exectuable> <parameters for the test executable>";
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
                testSuiteArguments = new string[args.Length - 2];
                Array.Copy(args, 2, testSuiteArguments, 0, args.Length - 2);
            }

            bool allTestsPassed = true;
            List<ITestRunner> testSuites = new List<ITestRunner>();

            try
            {
                testSuites.Add((ITestRunner)Activator.CreateInstance(testRunnerTypeMap[testRunnerType], testSuiteExecutable, testSuiteArguments));
            }
            catch(Exception)
            {
                Console.WriteLine("Failed to instantiate an instance of ITestRunner associated with " + testRunnerType);
            }

            foreach(ITestRunner runner in testSuites)
            {
                allTestsPassed &= ExecuteRunner(runner);
            }

            if (allTestsPassed)
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

