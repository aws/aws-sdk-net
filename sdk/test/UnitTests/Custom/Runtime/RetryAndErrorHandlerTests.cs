using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Amazon.Runtime;
using System.IO;
using AWSSDK_DotNet35.UnitTests;
using Amazon.S3.Model;
using Amazon.S3.Model.Internal.MarshallTransformations;
using Amazon.Runtime.Internal.Util;
using System.Threading;
using System.Net;
using Amazon.Runtime.Internal;

namespace AWSSDK.UnitTests
{
    [TestClass()]
    public class RetryAndErrorHandlerTests : RuntimePipelineTestBase<RetryHandler>
    {
        const int MAX_RETRIES = 2;
        private static Logger logger;

        [ClassInitialize]
        public static void Initialize(TestContext t)
        {
            logger = Logger.GetLogger(typeof(RetryAndErrorHandlerTests));
            var errorHandler = new ErrorHandler(logger);
            RuntimePipeline.AddHandler(errorHandler);

            Handler = new RetryHandler(new DefaultRetryPolicy(MAX_RETRIES));
            RuntimePipeline.AddHandler(Handler);
        }

        [TestMethod][TestCategory("UnitTest")]
        [TestCategory("Runtime")]
        public void RetryForIOException()
        {
            Tester.Reset();
            Tester.Action = (int callCount) =>
            {
                throw new IOException();
            };

            Utils.AssertExceptionExpected(() =>
            {
                var request = CreateTestContext();
                RuntimePipeline.InvokeSync(request);
            },
            typeof(IOException));
            Assert.AreEqual(MAX_RETRIES + 1, Tester.CallCount);
        }

        [TestMethod][TestCategory("UnitTest")]
        [TestCategory("Runtime")]
        public void RetryForWebExceptionWithConnectFailure()
        {
            Tester.Reset();
            Tester.Action = (int callCount) =>
            {
                throw new WebException("WebException", WebExceptionStatus.ConnectFailure);
            };

            Utils.AssertExceptionExpected(() =>
            {
                var request = CreateTestContext();
                RuntimePipeline.InvokeSync(request);
            },
            typeof(AmazonServiceException));
            Assert.AreEqual(MAX_RETRIES + 1, Tester.CallCount);
        }

#if BCL45

        [TestMethod][TestCategory("UnitTest")]
        [TestCategory("Runtime")]
        [TestCategory(@"Runtime\Async45")]
        public async Task RetryForIOExceptionAsync()
        {
            Tester.Reset();
            Tester.Action = (int callCount) =>
            {
                throw new IOException();
            };

            await Utils.AssertExceptionExpectedAsync(() =>
            {
                var request = CreateTestContext();
                return RuntimePipeline.InvokeAsync<AmazonWebServiceResponse>(request);
            },
            typeof(IOException));
            Assert.AreEqual(MAX_RETRIES + 1, Tester.CallCount);
        }

        [TestMethod][TestCategory("UnitTest")]
        [TestCategory("Runtime")]
        [TestCategory(@"Runtime\Async45")]
        public async Task RetryForWebExceptionAsync()
        {
            Tester.Reset();
            Tester.Action = (int callCount) =>
            {
                throw new WebException("WebException", WebExceptionStatus.ConnectFailure);
            };

            await Utils.AssertExceptionExpectedAsync(() =>
            {
                var request = CreateTestContext();
                return RuntimePipeline.InvokeAsync<AmazonWebServiceResponse>(request);
            },
            typeof(AmazonServiceException));
            Assert.AreEqual(MAX_RETRIES + 1, Tester.CallCount);
        }
#endif
    }
}