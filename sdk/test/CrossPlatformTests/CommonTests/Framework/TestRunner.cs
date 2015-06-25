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
        public virtual ITestFilter Filter { get { return TestFilter.Empty; } }

        private LogLevel _logMode = LogLevel.Info | LogLevel.Error;
        public LogLevel LogMode
        {
            get { return _logMode; }
            set { _logMode = value; }
        }
    
        public TestRunner()
        {
            TestRunner.Credentials = Settings.Credentials;
            TestRunner.RegionEndpoint = Settings.RegionEndpoint;
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

            WriteInfo("All tests executed");

            PushLog(success);

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

        protected virtual void TestCompleted(TestMethod test)
        {

        }

        protected virtual void TestCompleted(string testMethodName, bool succeeded)
        {

        }

        protected abstract string TestTypeNamePrefix
        {
            get;
        }

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
