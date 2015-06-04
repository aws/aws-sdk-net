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
using System.Diagnostics;

namespace CommonTests
{
    [Flags]
    public enum LogLevel
    {
        None = 0,
        Info = 1,
        Error = 2,
        Verbose = 4,       
    } 

    public abstract class TestRunner : ITestListener
    {        
              

        internal static AWSCredentials Credentials { get; set; }
        internal static RegionEndpoint RegionEndpoint { get { return RegionEndpoint.USWest2; } }
        public static TestRunner Instance { get; private set; }

        public virtual ITestListener Listener { get; private set; }
        public virtual ITestFilter Filter { get { return TestFilter.Empty; } }

        private LogLevel _logMode = LogLevel.Info | LogLevel.Error;
        public LogLevel LogMode
        {
            get { return _logMode; }
            set { _logMode = value; }
        }
    
        public TestRunner(string credentialsResourcePartialName = "credentials.json")
        {
            var credentialsStream = GetCredentialsStream(credentialsResourcePartialName);
            TestRunner.Credentials = new VendedCredentials(credentialsStream);
            Instance = this;
        }
		public TestRunner(Stream credentials)
        {
            TestRunner.Credentials = new VendedCredentials(credentials);
            Instance = this;
        }

        public bool ExecuteAllTests()
        {
            return Execute();
        }


        public async Task<bool> ExecuteAllTestsAsync()
        {
            return await Task.Run(() => Execute());  
        }

        public bool Execute()
        {
            var runner = new NUnitTestAssemblyRunner(new DefaultTestAssemblyBuilder());
            var currentAssembly = typeof(TestRunner).GetTypeInfo().Assembly;
            var options = new Dictionary<string, string>();
            var tests = runner.Load(currentAssembly, options);
            
            var result = runner.Run(this, this.Filter);
            runner.WaitForCompletion(int.MaxValue);

            var success =
                result.FailCount == 0 &&
                result.InconclusiveCount == 0 &&
                result.SkipCount == 0;
            return success;
        }

        public void WriteError(string format, params object[] args)
        {
            WriteToOutput(format, LogLevel.Error, args);
        }

        public void WriteVerbose(string format, params object[] args)
        {
            WriteToOutput(format, LogLevel.Verbose, args);
        }

        protected void WriteInfo(string format, params object[] args)
        {
            WriteToOutput(format, LogLevel.Info, args);
        }

        public void WriteToOutput(string format, LogLevel level, params object[] args)
        {
            var message = string.Format(format, args);
            Debug.WriteLine("TestRunner >> {0}", message);

            if (this.LogMode == LogLevel.Verbose)
            {
                this.WriteLine(message);    
            }
            else if ((this.LogMode & level) != LogLevel.None)
            {
                this.WriteLine(message);  
            }
        }

        protected abstract void WriteLine(string message);

        private Stream GetCredentialsStream(string credentialsResourcePartialName)
        {
            var assembly = this.GetType().GetTypeInfo().Assembly;
            var resources = assembly.GetManifestResourceNames();
            var credentialsResourceName = resources.First(r => r.IndexOf(credentialsResourcePartialName, StringComparison.OrdinalIgnoreCase) >= 0);
            var credsStream = assembly.GetManifestResourceStream(credentialsResourceName);
            return credsStream;
        }

        protected virtual void TestCompleted(TestMethod test)
        {

        }

        protected virtual void TestCompleted(string testMethodName, bool succeeded)
        {

        }

        #region ITestListener

        public void TestFinished(ITestResult result)
        {
            var testAssembly = result.Test as TestAssembly;
            if (testAssembly != null)
            {
                this.WriteVerbose("=== Executed {0} tests in assembly {1} ===",
                    testAssembly.TestCaseCount,
                    testAssembly.Assembly.FullName);

                this.WriteInfo("\nPassed : {0}\tFailed : {1}",
                    result.PassCount, result.FailCount);
            }

            var testFixture = result.Test as TestFixture;
            if (testFixture != null)
            {
                if (result.FailCount > 0)
                {
                    this.WriteError("\tMessage : {0}", result.Message);
                    this.WriteError("\tStack trace : {0}", result.StackTrace);
                }
                this.WriteVerbose("  --- Executed tests in class {0}   ---\n", LogLevel.Verbose, 
                    testFixture.FullName);
            }

            var testMethod = result.Test as TestMethod;
            if (testMethod != null)
            {
                if (result.FailCount > 0)
                {
                    this.WriteError("FAIL {0}", testMethod.MethodName);
                    this.WriteError("\tMessage : {0}", result.Message);
                    this.WriteError("\tStack trace : {0}", result.StackTrace);
                }

                if (result.InconclusiveCount > 0)
                {
                    this.WriteInfo("INCONCLUSIVE {0}", testMethod.MethodName);
                }

                if (result.PassCount > 0)
                {
                    this.WriteInfo("PASS {0}", testMethod.MethodName);
                }

                TestCompleted(testMethod);

                var testSucceeded =
                    result.FailCount == 0 &&
                    result.InconclusiveCount == 0 &&
                    result.SkipCount == 0;

                TestCompleted(testMethod.Name, testSucceeded);
            }
        }

        public void TestStarted(ITest test)
        {
            var testAssembly = test as TestAssembly;
            if (testAssembly != null)
            {
                this.WriteVerbose("=== Executing tests in assembly {0} ===\n",
                    testAssembly.Assembly.FullName);
            }

            var testFixture = test as TestFixture;
            if (testFixture != null)
            {
                this.WriteVerbose("  --- Executing tests in class {0} ---",
                    testFixture.FullName);
            }

            var testMethod = test as TestMethod;
            if (testMethod != null)
            {
                this.WriteVerbose("\tTest {0}.{1} started",
                    testMethod.ClassName, testMethod.MethodName);
            }
        }

        #endregion
    }
}
