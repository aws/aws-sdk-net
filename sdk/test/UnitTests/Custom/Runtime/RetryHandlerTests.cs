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
using Amazon.S3;

namespace AWSSDK.UnitTests
{
    [TestClass()]
    public class RetryHandlerTests : RuntimePipelineTestBase<RetryHandler>
    {
        const int MAX_RETRIES = 2;

        [ClassInitialize]
        public static void Initialize(TestContext t)
        {
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
        public void RetryForWebException()
        {
            Tester.Reset();
            Tester.Action = (int callCount) =>
            {
                throw new AmazonServiceException(new WebException("WebException", WebExceptionStatus.ConnectFailure));
            };

            Utils.AssertExceptionExpected(() =>
            {
                var request = CreateTestContext();
                RuntimePipeline.InvokeSync(request);
            },
            typeof(AmazonServiceException));
            Assert.AreEqual(MAX_RETRIES + 1, Tester.CallCount);
        }

        [TestMethod][TestCategory("UnitTest")]
        [TestCategory("Runtime")]
        public void RetryForHttpStatus500()
        {
            Tester.Reset();
            Tester.Action = (int callCount) =>
            {
                throw new AmazonServiceException("Internal Server Error",
                    new WebException(), HttpStatusCode.InternalServerError);
            };

            Utils.AssertExceptionExpected(() =>
            {
                var request = CreateTestContext();
                RuntimePipeline.InvokeSync(request);
            },
            typeof(AmazonServiceException));
            Assert.AreEqual(MAX_RETRIES + 1, Tester.CallCount);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Runtime")]
        public void RetryForHttpStatus200WithErrorResponse()
        {
            var s3Client = new MockS3Client(new BasicAWSCredentials("access_key", "secret_key"),
                new Amazon.S3.AmazonS3Config
                {
                    ServiceURL = @"http://S3200WithErrorResponse",
                    MaxErrorRetry = MAX_RETRIES
                });

            IExecutionContext executionContext = null;
            s3Client.Pipeline.AddHandlerAfter<RetryHandler>(new CallbackHandler
            {
                OnPreInvoke = (context) => 
                {
                    executionContext = context;
                }
            });

            var exception = Utils.AssertExceptionExpected<AmazonS3Exception>(() =>
            {
                var completeMultipartUploadResponse = s3Client.CompleteMultipartUpload(
                    new CompleteMultipartUploadRequest
                    {
                        BucketName = "bucketName",
                        Key = "key",
                        PartETags = new List<PartETag> { },
                        UploadId = "Upload123"
                    });
            });            
            Assert.AreEqual(MAX_RETRIES, executionContext.RequestContext.Retries);

            exception = Utils.AssertExceptionExpected<AmazonS3Exception>(() =>
            {
                var copyPartResponse = s3Client.CopyPart("source", "key",
                    "destination", "key", "Upload123");
            });
            Assert.AreEqual(MAX_RETRIES, executionContext.RequestContext.Retries);

            exception = Utils.AssertExceptionExpected<AmazonS3Exception>(()=>{
                var copyObjectResponse = s3Client.CopyObject("source", "key", 
                    "destination", "key");
            });
            Assert.AreEqual("InternalError", exception.ErrorCode);
            Assert.AreEqual("656c76696e6727732072657175657374", exception.RequestId);
            Assert.AreEqual("Uuag1LuByRx9e6j5Onimru9pO4ZVKnJ2Qz7/C1NPcfTWAtRPfTaOFg==", exception.AmazonId2);
            Assert.AreEqual("-UUNhfhfx0J622sdKihbDfqEvIa94CkVQvcb4AGlNmRbpbInOTYXSA==", exception.AmazonCloudFrontId);
            Assert.AreEqual(MAX_RETRIES, executionContext.RequestContext.Retries);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Runtime")]
        public void RetryForHttpStatus502FromS3Accelerate()
        {
            var s3Client = new MockS3Client(new BasicAWSCredentials("access_key", "secret_key"),
                new Amazon.S3.AmazonS3Config
                {
                    ServiceURL = @"http://S3Accelerate502ErrorResponse",
                    MaxErrorRetry = MAX_RETRIES
                });

            IExecutionContext executionContext = null;
            s3Client.Pipeline.AddHandlerAfter<RetryHandler>(new CallbackHandler
            {
                OnPreInvoke = (context) =>
                {
                    executionContext = context;
                }
            });

            var exception = Utils.AssertExceptionExpected<AmazonS3Exception>(() =>
            {
                var putObjectResponse = s3Client.PutObject(
                    new PutObjectRequest
                    {
                        BucketName = "bucketName",
                        Key = "key",
                        ContentBody = "Test Content"
                        
                    });
            });
            
            Assert.AreEqual(HttpStatusCode.BadGateway, exception.StatusCode);            
            Assert.AreEqual("zKxM2OZ8xQLqXp6UUteraUD5L8V-zNeiRAM9x7GsjPDHwXn7YJv8Jw==", exception.AmazonCloudFrontId);
            Assert.AreEqual(MAX_RETRIES, executionContext.RequestContext.Retries);
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
                throw new AmazonServiceException(new WebException("WebException", WebExceptionStatus.ConnectFailure));
            };

            await Utils.AssertExceptionExpectedAsync(() =>
            {
                var request = CreateTestContext();
                return RuntimePipeline.InvokeAsync<AmazonWebServiceResponse>(request);
            },
            typeof(AmazonServiceException));
            Assert.AreEqual(MAX_RETRIES + 1, Tester.CallCount);
        }

        [TestMethod][TestCategory("UnitTest")]
        [TestCategory("Runtime")]
        [TestCategory(@"Runtime\Async45")]
        public async Task RetryForHttpStatus500Async()
        {
            Tester.Reset();
            Tester.Action = (int callCount) =>
            {
                throw new AmazonServiceException("Internal Server Error",
                    new WebException(), HttpStatusCode.InternalServerError);
            };

            await Utils.AssertExceptionExpectedAsync(() =>
            {
                var request = CreateTestContext();
                return RuntimePipeline.InvokeAsync<AmazonWebServiceResponse>(request);
            },
            typeof(AmazonServiceException));
            Assert.AreEqual(MAX_RETRIES + 1, Tester.CallCount);
        }  
#elif !BCL45 && BCL

        [TestMethod][TestCategory("UnitTest")]
        [TestCategory("Runtime")]
        [TestCategory(@"Runtime\Async35")]
        public void RetryForIOExceptionAsync()
        {
            Tester.Reset();
            Tester.Action = (int callCount) =>
            {
                throw new IOException();
            };

            var request = CreateAsyncTestContext();
            var asyncResult = RuntimePipeline.InvokeAsync(request);
            asyncResult.AsyncWaitHandle.WaitOne();

            Assert.IsTrue(((RuntimeAsyncResult)asyncResult).Exception is IOException);
            Assert.AreEqual(MAX_RETRIES + 1, Tester.CallCount);
        }

        [TestMethod][TestCategory("UnitTest")]
        [TestCategory("Runtime")]
        [TestCategory(@"Runtime\Async35")]
        public void RetryForWebExceptionAsync()
        {
            Tester.Reset();
            Tester.Action = (int callCount) =>
            {
                throw new AmazonServiceException(new WebException("WebException", WebExceptionStatus.ConnectFailure));
            };

            var request = CreateAsyncTestContext();
            var asyncResult = RuntimePipeline.InvokeAsync(request);
            asyncResult.AsyncWaitHandle.WaitOne();

            Assert.IsTrue(((RuntimeAsyncResult)asyncResult).Exception is AmazonServiceException);
            Assert.AreEqual(MAX_RETRIES + 1, Tester.CallCount);
        }

        [TestMethod][TestCategory("UnitTest")]
        [TestCategory("Runtime")]
        [TestCategory(@"Runtime\Async35")]
        public void RetryForHttpStatus500Async()
        {
            Tester.Reset();
            Tester.Action = (int callCount) =>
            {
                throw new AmazonServiceException("Internal Server Error",
                    new WebException(), HttpStatusCode.InternalServerError);
            };

            var request = CreateAsyncTestContext();
            var asyncResult = RuntimePipeline.InvokeAsync(request);
            asyncResult.AsyncWaitHandle.WaitOne();

            Assert.IsTrue(((RuntimeAsyncResult)asyncResult).Exception is AmazonServiceException);
            Assert.AreEqual(MAX_RETRIES + 1, Tester.CallCount);
        }

#endif        
    }

    public class MockS3Client : AmazonS3Client
    {
        private AWSSDK.UnitTests.HttpHandlerTests.MockHttpRequestFactory _requestFactory = null;

        public RuntimePipeline Pipeline
        {
            get
            {
                return base.RuntimePipeline;
            }
        }

        public Action GetResponseAction
        {
            set { _requestFactory.GetResponseAction = value; }
        }


        public MockS3Client(AWSCredentials credentials, AmazonS3Config clientConfig)
            : base(credentials, clientConfig)
        {
        }

        public void Reset()
        {
            this.GetResponseAction = null;
        }

        protected override void CustomizeRuntimePipeline(RuntimePipeline pipeline)
        {
            base.CustomizeRuntimePipeline(pipeline);

            _requestFactory = new AWSSDK.UnitTests.HttpHandlerTests.MockHttpRequestFactory();
            var httpHandler = new HttpHandler<Stream>(_requestFactory, this);
            pipeline.ReplaceHandler<HttpHandler<Stream>>(httpHandler);
        }
    }
}
