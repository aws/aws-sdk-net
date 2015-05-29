using Amazon;
using Amazon.Runtime;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework.Api;
using System.Reflection;
using NUnit.Framework.Interfaces;
using NUnit.Framework.Internal;
using System.Threading;

namespace CommonTests
{
    public abstract class TestRunner
    {
        private Listener _testListener = null;
        internal static AWSCredentials Credentials { get; set; }

        internal static RegionEndpoint RegionEndpoint 
        {
            get { return RegionEndpoint.USWest2; } 
        }

		public TestRunner(Stream credentials)
        {
            TestRunner.Credentials = 
				new VendedCredentials(credentials);
        }

        public void ExecuteAllTests()
        {
            Execute();
        }

        public async Task ExecuteAllTestsAsync()
        {
            await Task.Run(()=>Execute());           

            //var test = new IntegrationTests.SampleTests();
            //await test.ListBucketTestsAsync();
        }

        public int Execute()
        {
            var runner = new NUnitTestAssemblyRunner(new DefaultTestAssemblyBuilder());
            var currentAssembly = typeof(TestRunner).GetTypeInfo().Assembly;
            var options = new Dictionary<string,string>();
            var tests = runner.Load(currentAssembly, options);

            _testListener = new Listener(this);
            var result = runner.Run(this.Listener, this.Filter);

            runner.WaitForCompletion(int.MaxValue);
            return 0;
        }

        public virtual ITestListener Listener
        {
            //get { return TestListener.NULL;}
            get { return _testListener; }
        }

        public virtual ITestFilter Filter
        {
            get { return TestFilter.Empty; }
        }

        public void WriteToOutput(string format, params object[] args)
        {
            var message = string.Format(format, args);
            this.WriteLine(message);
        }

        public abstract void WriteLine(string message);
    }

    public class Listener : ITestListener
    {
        private TestRunner _runner;

        public Listener(TestRunner runner)
        {
            _runner = runner;
        }

        public void TestFinished(ITestResult result)
        {
            //var oldColor = Console.ForegroundColor;

            var testAssembly = result.Test as TestAssembly;
            if (testAssembly != null)
            {
                _runner.WriteToOutput("\n=== Executed {0} tests in assembly {1} ===",
                    testAssembly.TestCaseCount,
                    testAssembly.Assembly.FullName);
                _runner.WriteToOutput("\t\tPassed : {0}\tFailed : {1}\tInconclusive : {2}",
                    result.PassCount, result.FailCount, result.InconclusiveCount);
            }

            var testFixture = result.Test as TestFixture;
            if (testFixture != null)
            {
                _runner.WriteToOutput("  === Executed tests in class {0} ===\n", testFixture.FullName);
            }

            var testMethod = result.Test as TestMethod;
            if (testMethod != null)
            {
                if (result.FailCount > 0)
                {
                    //Console.ForegroundColor = ConsoleColor.Red;
                    _runner.WriteToOutput("\tTest {0}.{1} failed", testMethod.ClassName, testMethod.MethodName);
                    //_runner.WriteToOutput("\tException : {0}", result.ex);
                    _runner.WriteToOutput("\tMessage : {0}", result.Message);
                    _runner.WriteToOutput("\tStack trace : {0}", result.StackTrace);
                    //Console.ForegroundColor = oldColor;
                }

                if (result.InconclusiveCount > 0)
                {
                    //Console.ForegroundColor = ConsoleColor.Yellow;
                    _runner.WriteToOutput("\tTest {0}.{1} inconclusive", testMethod.ClassName, testMethod.MethodName);
                    //Console.ForegroundColor = oldColor;
                }

                if (result.PassCount > 0)
                {
                    //Console.ForegroundColor = ConsoleColor.Green;
                    _runner.WriteToOutput("\tTest {0}.{1} succeeded", testMethod.ClassName, testMethod.MethodName);
                    //Console.ForegroundColor = oldColor;
                }
            }
        }

        public void TestStarted(ITest test)
        {
            var testAssembly = test as TestAssembly;
            if (testAssembly != null)
            {
                _runner.WriteToOutput("\n=== Executing tests in assembly {0} ===\n", testAssembly.Assembly.FullName);
            }

            var testFixture = test as TestFixture;
            if (testFixture != null)
            {
                _runner.WriteToOutput("\n  === Executing tests in class {0} ===", testFixture.FullName);
            }

            var testMethod = test as TestMethod;
            if (testMethod != null)
            {
                _runner.WriteToOutput("\tTest {0}.{1} started", testMethod.ClassName, testMethod.MethodName);
            }
        }
    }

    
}
