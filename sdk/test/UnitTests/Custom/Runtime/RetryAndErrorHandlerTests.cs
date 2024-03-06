using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Amazon.Runtime;
using System.IO;
using AWSSDK_DotNet.UnitTests;
using Amazon.S3.Model;
using Amazon.S3.Model.Internal.MarshallTransformations;
using Amazon.Runtime.Internal.Util;
using System.Threading;
using System.Net;
using Amazon.Runtime.Internal;
using Amazon.S3;

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

            ClientConfig config = new AmazonS3Config
            {
                ServiceURL = @"https://s3.amazonaws.com",
                MaxErrorRetry = MAX_RETRIES
            };
            Handler = new RetryHandler(new DefaultRetryPolicy(config));
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

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Runtime")]
        public void RetryForNestedIOException()
        {
            Tester.Reset();
            Tester.Action = (int callCount) =>
            {
                throw new ArgumentOutOfRangeException("Mocked exception", new IOException());
            };

            Utils.AssertExceptionExpected(() =>
            {
                var request = CreateTestContext();
                RuntimePipeline.InvokeSync(request);
            },
            typeof(ArgumentOutOfRangeException));
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

#if BCL
        [TestMethod][TestCategory("UnitTest")]
        [TestCategory("Runtime")]
        [TestCategory(@"Runtime\AsyncNetFramework")]
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
        [TestCategory(@"Runtime\AsyncNetFramework")]
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