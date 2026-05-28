#if !NETFRAMEWORK
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Util;
using Amazon.Util.Internal;
using Moq;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AWSSDK.UnitTests
{
    [TestClass]
    public class InternalSDKUtilsNetStandardTests
    {
        [TestMethod]
        public void RuntimeInformationTest()
        {
            var framework = InternalSDKUtils.DetermineFramework();
            Assert.AreNotEqual("Unknown", framework);
            Assert.IsFalse(framework.Contains(" "));

            var os = InternalSDKUtils.DetermineOS();
            Assert.AreNotEqual("Unknown", os);
            Assert.IsFalse(os.Contains(" "));

            var platform = InternalSDKUtils.PlatformUserAgent();
            Assert.AreNotEqual("Unknown", platform);
            Assert.IsTrue(platform.Contains("md/ARCH"));
        }

        [TestMethod]
        [DataRow(@"c:\a\b\c\test.txt", @"c:\a\b\c", true)]
        [DataRow(@"c:\a\b\c\..\test.txt", @"c:\a\b\c", false)]
        [DataRow(@"c:\a\b\c\..\ctest.txt", @"c:\a\b\c", false)]
        [DataRow(@"c:\a\b\c\test.txt", @"c:\a\b\c\", true)]
        [DataRow(@"c:\a\b\c\..\test.txt", @"c:\a\b\c\", false)]
        [DataRow(@"c:\a\b\c\..\ctest.txt", @"c:\a\b\c\", false)]
        [DataRow(@"/home/a/b/c/test.txt", @"/home/a/b/c", true)]
        [DataRow(@"/home/a/b/c/../test.txt", @"/home/a/b/c", false)]
        [DataRow(@"/home/a/b/c/../ctest.txt", @"/home/a/b/c", false)]
        [DataRow(@"/home/a/b/c/test.txt", @"/home/a/b/c/", true)]
        [DataRow(@"/home/a/b/c/../test.txt", @"/home/a/b/c/", false)]
        [DataRow(@"/home/a/b/c/../ctest.txt", @"/home/a/b/c/", false)]
        [DataRow(@"c:\a\b\c\\test.txt", @"c:\a\b\c", true)]
        [DataRow(@"c:/a/b/c/test.txt", @"c:\a\b\c", true)]
        [DataRow(@"c:/a/b/c/test.txt", @"c:/a/b/c", true)]
        [DataRow(@"c:\a\b\c\d\test.txt", @"c:\a\b\c", true)]
        [DataRow(@"c:\a\b\c\d/test.txt", @"c:\a\b\c", true)]
        public void IsFilePathRootedWithDirectoryPathTests(string filePath, string directoryPath, bool expectedResult)
        {
            var result = InternalSDKUtils.IsFilePathRootedWithDirectoryPath(filePath, directoryPath);
            Assert.AreEqual(expectedResult, result);
        }

        [TestMethod]
        public void DetermineFrameworkHandlesNonconventionalVersions()
        {
            var mockWrapper = new Mock<IRuntimeInformationWrapper>();
            mockWrapper.Setup(w => w.FrameworkDescription).Returns("01-12-2024");
            InternalSDKUtils.SetRuntimeInformationWrapper(mockWrapper.Object);

            var framework = InternalSDKUtils.DetermineFramework();

            Assert.AreEqual("Unknown md/framework-raw-version#01-12-2024", framework);
            InternalSDKUtils.ResetRuntimeInformationWrapper();
        }

        [TestMethod]
        public void DetermineFrameworkHandlesNonconventionalVersions2()
        {
            var mockWrapper = new Mock<IRuntimeInformationWrapper>();
            mockWrapper.Setup(w => w.FrameworkDescription).Returns("-EX25+1");
            InternalSDKUtils.SetRuntimeInformationWrapper(mockWrapper.Object);

            var framework = InternalSDKUtils.DetermineFramework();

            Assert.AreEqual("Unknown md/framework-raw-version#-EX25+1", framework);
            InternalSDKUtils.ResetRuntimeInformationWrapper();
        }

        [TestMethod]
        public void DetermineFrameworkHandlesConventionalVersion()
        {
            var mockWrapper = new Mock<IRuntimeInformationWrapper>();
            mockWrapper.Setup(w => w.FrameworkDescription).Returns("8.0.0");
            InternalSDKUtils.SetRuntimeInformationWrapper(mockWrapper.Object);

            var framework = InternalSDKUtils.DetermineFramework();

            Assert.AreEqual(".NET_Core#8.0.0", framework);
            InternalSDKUtils.ResetRuntimeInformationWrapper();
        }

        [TestMethod]
        public void DetermineFrameworkReturnsUnknownIfExceptionIsThrown()
        {
            var mockWrapper = new Mock<IRuntimeInformationWrapper>();
            mockWrapper.Setup(w => w.FrameworkDescription).Throws<ArgumentException>();
            InternalSDKUtils.SetRuntimeInformationWrapper(mockWrapper.Object);

            var framework = InternalSDKUtils.DetermineFramework();

            Assert.AreEqual("Unknown", framework);
            InternalSDKUtils.ResetRuntimeInformationWrapper();
        }

        [TestMethod]
        public void SimpleSetTaskContext()
        {
            SDKTaskContext.Default.Set("key1", "value1");
            Assert.AreEqual("value1", SDKTaskContext.Default.Get("key1"));
        }

        [TestMethod]
        public async Task EnsureTaskContextAcrossTasks()
        {
            bool task1Confirmed = false;
            bool task2Set = false;
            var key = "key1";
            var task1 = Task.Run(async () =>
            {
                SDKTaskContext.Default.Set(key, "task1");
                while (!task2Set)
                {
                    await Task.Delay(100);
                }
                await Task.Run(() =>
                {
                    if (string.Equals("task1", SDKTaskContext.Default.Get(key)))
                        task1Confirmed = true;
                    return Task.CompletedTask;
                });
            });

            var task2 = Task.Run(() =>
            {
                SDKTaskContext.Default.Set(key, "task2");
                task2Set = true;
            });

            await Task.WhenAll(task1, task2);
            Assert.IsTrue(task1Confirmed);
        }

        [TestMethod]
        public void ConfirmTraceIdSetForMarshaller()
        {
            try
            {
                SDKTaskContext.Default.Set(EnvironmentVariables._X_AMZN_TRACE_ID, "contextTraceId");
                Environment.SetEnvironmentVariable(EnvironmentVariables._X_AMZN_TRACE_ID, "environmentTraceId");

                IDictionary<string, string> headers = new Dictionary<string, string>();
                Marshaller.SetRecursionDetectionHeader(headers);
                Assert.IsFalse(headers.ContainsKey(HeaderKeys.XAmznTraceIdHeader));

                Environment.SetEnvironmentVariable(EnvironmentVariables.AWS_LAMBDA_FUNCTION_NAME, "LambdaFunction");

                headers = new Dictionary<string, string>();
                Marshaller.SetRecursionDetectionHeader(headers);
                Assert.AreEqual("environmentTraceId", headers[HeaderKeys.XAmznTraceIdHeader]);

                Environment.SetEnvironmentVariable(EnvironmentVariables.AWS_LAMBDA_MAX_CONCURRENCY, "1");
                headers = new Dictionary<string, string>();
                Marshaller.SetRecursionDetectionHeader(headers);
                Assert.AreEqual("contextTraceId", headers[HeaderKeys.XAmznTraceIdHeader]);

                SDKTaskContext.Default.Set(EnvironmentVariables._X_AMZN_TRACE_ID, null);
                headers = new Dictionary<string, string>();
                Marshaller.SetRecursionDetectionHeader(headers);
                Assert.AreEqual("environmentTraceId", headers[HeaderKeys.XAmznTraceIdHeader]);

                headers = new Dictionary<string, string>() { { HeaderKeys.XAmznTraceIdHeader, "existingTrace" } };
                Marshaller.SetRecursionDetectionHeader(headers);
                Assert.AreEqual("existingTrace", headers[HeaderKeys.XAmznTraceIdHeader]);
            }
            finally
            {
                Environment.SetEnvironmentVariable(EnvironmentVariables._X_AMZN_TRACE_ID, null);
                Environment.SetEnvironmentVariable(EnvironmentVariables.AWS_LAMBDA_FUNCTION_NAME, null);
                Environment.SetEnvironmentVariable(EnvironmentVariables.AWS_LAMBDA_MAX_CONCURRENCY, null);
                SDKTaskContext.Default.Set(EnvironmentVariables._X_AMZN_TRACE_ID, null);
            }
        }
    }
}
#endif
