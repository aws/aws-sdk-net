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
using Amazon.S3.Model;
using Amazon.SimpleNotificationService.Model;
using System.Collections;
using System.Net;
using System.Net.Http;

namespace CommonTests.Framework
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
        private const string internetTestAddress = "http://aws.amazon.com/sdk-for-net/";
        private const string timestampFormat = "yyyy-MM-dd-HH-mm-ss";
        private const string s3KeyFormat = "{1}-{0}.txt"; // 0 - prefix, 1 - timestamp
        private const string snsSubjectFormat = "{2} - {0}-{1}"; // 0 - prefix, 1 - timestamp, 2 - PASSED or FAILED
        private const int snsMaxMessageSizeKb = 256; // http://docs.aws.amazon.com/sns/latest/api/API_Publish.html
        private const int kb = 1024;
        private static int snsMaxMessageSize = snsMaxMessageSizeKb * kb;
        private static string logTooLongMessage = "The test log was longer than {0} KB. Truncated log follows." + Environment.NewLine; // 0 - snsMaxMessageSizeKb
        private const string truncationSuffix = "...";

        internal static AWSCredentials Credentials { get; set; }
        internal static RegionEndpoint RegionEndpoint { get; set; }
        public static TestRunner Instance { get; private set; }

        private TextWriter LogWriter { get; set; }
        public virtual ITestListener Listener { get; private set; }
        public virtual ITestFilter Filter
        {
            get
            {
                var selectTests = (TestsToRun != null && TestsToRun.Count != 0);
                var selectCategories = (CategoriesToRun != null && CategoriesToRun.Count != 0);
                if (selectTests && selectCategories)
                    throw new InvalidOperationException("Cannot set both TestsToRun and CategoriesToRun");

                if (selectTests)
                    return SpecificTestsFilter.RunOnlyTests(this, TestsToRun);
                if (selectCategories)
                    return SpecificTestsFilter.RunOnlyCategories(this, CategoriesToRun);
                
                return TestFilter.Empty;
            }
        }

        public ICollection<string> TestsToRun { get; set; }
        public ICollection<string> CategoriesToRun { get; set; }

        private LogLevel _logMode = LogLevel.Info | LogLevel.Error;
        public LogLevel LogMode
        {
            get { return _logMode; }
            set { _logMode = value; }
        }

        protected abstract string TestTypeNamePrefix
        {
            get;
        }

        private List<TestMethod> FailedTestMethods { get; set; }
    
        public TestRunner()
        {
            TestRunner.Credentials = Settings.Credentials;
            TestRunner.RegionEndpoint = Settings.RegionEndpoint;
            var logging = AWSConfigs.LoggingConfig;
            logging.LogTo = LoggingOptions.SystemDiagnostics;
            logging.LogResponses = ResponseLoggingOption.Always;
            logging.LogMetrics = true;

            Instance = this;
            LogWriter = new StringWriter();
        }

        public bool ExecuteAllTests()
        {
            return Execute();
        }

        public async Task<bool> ExecuteAllTestsAsync()
        {
            return await Task.Run(() => Execute());  
        }

        private bool Execute()
        {
            try
            {
                FailedTestMethods = new List<TestMethod>();

                if (!IsInternetAvailable())
                {
                    WriteInfo("Internet is not available, exiting");
                    return false;
                }

                WriteInfo("Setting up runner...");
                var runner = new NUnitTestAssemblyRunner(new DefaultTestAssemblyBuilder());
                var currentAssembly = typeof(TestRunner).GetTypeInfo().Assembly;
                var options = new Dictionary<string, string>();
                var tests = runner.Load(currentAssembly, options);

                WriteInfo("Running tests...");
                var result = runner.Run(this, this.Filter);
                runner.WaitForCompletion(int.MaxValue);

                var success = result.HasTestSucceeded();

                WriteInfo("All tests executed");
                WriteInfo("Time elapsed: {0}", TimeSpan.FromSeconds(result.Duration));

                if (!success)
                {
                    var failedMethodNames = FailedTestMethods.Select(tm => tm.Name).ToList();
                    WriteInfo("Failed methods: {0}", string.Join(", ", failedMethodNames));
                }

                // optionally, write result as xml
                //WriteInfo("Test results as XML: {0}", result.ToXml(true).OuterXml);

                PushLog(success);

                return success;
            }
            catch(Exception e)
            {
                WriteError("Encountered catastrophic error during test execution: {0}", e.ToString());
                return false;
            }
        }

        private bool IsInternetAvailable()
        {
            try
            {
                var client = new HttpClient();
                var content = client.GetStringAsync(internetTestAddress).Result;
                if (string.IsNullOrEmpty(content))
                {
                    WriteError("Accessing {0} returned an empty body");
                    return false;
                }

                return true;
            }
            catch(Exception e)
            {
                WriteError("Error accessing {0}: {1}", e);
                return false;
            }
        }

        #region Output

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
            LogWriter.WriteLine("TestRunner >> {0}", message);

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

        #endregion

        #region Test reporting

        protected virtual void TestCompleted(TestMethod test)
        {

        }

        protected virtual void TestCompleted(string testMethodName, bool succeeded)
        {

        }

        #endregion

        #region Log pushes

        private void PushLog(bool allPassed)
        {
            if (string.IsNullOrEmpty(Settings.ResultsBucket) &&
                string.IsNullOrEmpty(Settings.ResultsTopic))
                return;

            WriteInfo("Preparing to push logs");

            try
            {
                var timestamp = DateTime.Now.ToString(timestampFormat);
                var key = string.Format(s3KeyFormat, TestTypeNamePrefix, timestamp);
                var snsSubject = string.Format(snsSubjectFormat, TestTypeNamePrefix, timestamp, allPassed ? "PASSED" : "FAILED");

                // if SNS fails, we may see the reason in the S3 push, so keep this order and use LogWriter.ToString()
                PushLogToSNS(snsSubject, LogWriter.ToString());

                PushLogToS3(key, LogWriter.ToString());
            }
            catch(Exception e)
            {
                WriteError("Error pushing logs: {0}", e);
            }

            WriteInfo("Logs pushed");
        }

        private void PushLogToSNS(string snsSubject, string log)
        {
            if (string.IsNullOrEmpty(Settings.ResultsTopic))
                return;

            try
            {
                if (log.Length > snsMaxMessageSize)
                {
                    WriteInfo("Log too long for SNS, truncating...");
                    var tooLongPrefix = string.Format(logTooLongMessage, snsMaxMessageSizeKb);
                    var maxCharacters = snsMaxMessageSize - (tooLongPrefix.Length + truncationSuffix.Length);
                    log =
                        tooLongPrefix +
                        log.Substring(0, maxCharacters) +
                        truncationSuffix;
                }

                WriteInfo("Pushing log to SNS...");
                using (var sns = new Amazon.SimpleNotificationService.AmazonSimpleNotificationServiceClient(Credentials, RegionEndpoint))
                {
                    sns.PublishAsync(new PublishRequest
                    {
                        TopicArn = Settings.ResultsTopic,
                        Subject = snsSubject,
                        Message = log
                    }).Wait();
                }
            }
            catch(Exception e)
            {
                WriteError("Error pushing logs to SNS: {0}", e);
            }
        }

        private void PushLogToS3(string key, string log)
        {
            if (string.IsNullOrEmpty(Settings.ResultsBucket))
                return;

            try
            {
                WriteInfo("Pushing log to S3...");
                using (var s3 = new Amazon.S3.AmazonS3Client(Credentials, RegionEndpoint))
                {
                    s3.PutObjectAsync(new PutObjectRequest
                    {
                        BucketName = Settings.ResultsBucket,
                        Key = key,
                        ContentBody = log
                    }).Wait();
                }
            }
            catch(Exception e)
            {
                WriteError("Error pushing logs to S3: {0}", e);
            }
        }

        #endregion

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
                    this.WriteError("Test Fixture {0} ({1}) has {2} failures.",
                        testFixture.Name, testFixture.FullName, result.FailCount);

                    if (result.HasChildren)
                    {
                        foreach (var childResult in result.Children)
                        {
                            if (childResult.ResultState.Site != FailureSite.Test)
                                TestFinished(childResult);
                        }
                    }

                    this.WriteError("\tMessage : {0}", result.Message);
                    this.WriteError("\tStack trace : {0}", result.StackTrace);
                }
                this.WriteVerbose("  --- Executed tests in class {0}   ---\n", testFixture.FullName);
            }

            var testMethod = result.Test as TestMethod;
            if (testMethod != null)
            {
                if (result.FailCount > 0)
                {
                    this.WriteError("FAIL {0} ({1})", testMethod.MethodName, testMethod.FullName);
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
                var testSucceeded = result.HasTestSucceeded();
                TestCompleted(testMethod.Name, testSucceeded);
                if (!testSucceeded)
                    FailedTestMethods.Add(testMethod);
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

        private class SpecificTestsFilter : ITestFilter
        {
            private const string CategoryKey = "Category";

            private TestRunner _runner;
            private ICollection<string> _categories;
            private ICollection<string> _tests;
            private bool _isRunOnly;
            private bool CheckTests
            {
                get
                {
                    return (_tests != null && _tests.Count != 0);
                }
            }
            private bool CheckCategories
            {
                get
                {
                    return (_categories != null && _categories.Count != 0);
                }
            }

            private SpecificTestsFilter(TestRunner runner)
            {
                _runner = runner;
            }

            public static SpecificTestsFilter RunOnlyTests(TestRunner runner, ICollection<string> testsToRun)
            {
                return Create_Tests(runner, testsToRun, isRunOnly: true);
            }
            public static SpecificTestsFilter RunAllTestsExcept(TestRunner runner, ICollection<string> testsToSkip)
            {
                return Create_Tests(runner, testsToSkip, isRunOnly: false);
            }
            public static SpecificTestsFilter RunOnlyCategories(TestRunner runner, ICollection<string> categoriesToRun)
            {
                return Create_Categories(runner, categoriesToRun, isRunOnly: true);
            }
            public static SpecificTestsFilter RunAllCategoriesExcept(TestRunner runner, ICollection<string> categoriesToSkip)
            {
                return Create_Categories(runner, categoriesToSkip, isRunOnly: false);
            }

            private static SpecificTestsFilter Create_Tests(TestRunner runner, ICollection<string> tests, bool isRunOnly)
            {
                return new SpecificTestsFilter(runner)
                {
                    _tests = tests ?? new HashSet<string>(),
                    _isRunOnly = isRunOnly
                };
            }
            private static SpecificTestsFilter Create_Categories(TestRunner runner, ICollection<string> categories, bool isRunOnly)
            {
                return new SpecificTestsFilter(runner)
                {
                    _categories = categories ?? new HashSet<string>(),
                    _isRunOnly = isRunOnly
                };
            }


            private bool ShouldRunTest(string name)
            {
                if (_isRunOnly)
                    // only run tests in collection
                    return (_tests.Contains(name));
                else
                    // only run tests NOT in collection
                    return (!_tests.Contains(name));
            }
            private bool ShouldRunCategories(IList categories)
            {
                var stringCategories = categories.Cast<string>().ToList();

                if (_isRunOnly)
                    // only run test if categories intersect (a category is present in both lists)
                    return (_categories.Intersect(stringCategories).Any());
                else
                    // only run tests if categories DO NOT intersect (test has no categories that are present in _categories)
                    return (!_categories.Intersect(stringCategories).Any());
            }

            public bool Pass(ITest test)
            {
                if (test.Method == null)
                    return true;

                var testName = test.Name;
                var categories = (test.Properties.ContainsKey(CategoryKey)) ?
                    test.Properties[CategoryKey] : new List<string>();

                var shouldRunTest = CheckTests ? ShouldRunTest(testName) : ShouldRunCategories(categories);

                if (!shouldRunTest)
                    _runner.WriteInfo("Test {0} ({1}) excluded from run by filter", testName, test.FullName);

                return shouldRunTest;
            }
        }
    }
}
