using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Amazon.Runtime;
using System.IO;
using AWSSDK_DotNet35.UnitTests;
using Amazon.Runtime.Internal.Util;
using System.Threading;
using System.Net;

using Amazon.S3;
using Amazon.S3.Model;
using Amazon.S3.Model.Internal.MarshallTransformations;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;

namespace AWSSDK.UnitTests
{
    [TestClass]
    public class ErrorHandlerTests : RuntimePipelineTestBase<ErrorHandler>
    {
        [ClassInitialize]
        public static void Initialize(TestContext t)
        {
            var logger =
                 Amazon.Runtime.Internal.Util.Logger.GetLogger(new object().GetType());
            Handler = new ErrorHandler(logger);
            RuntimePipeline.AddHandler(Handler);
        }

        [TestMethod][TestCategory("UnitTest")]
        [TestCategory("Runtime")]
        public void TestSuppressed404()
        {
            Tester.Reset();
            Tester.Action = (int callCount) =>
            {
                var errorResponse = (HttpWebResponse)MockWebResponse.CreateFromResource("404Response.txt");
                throw new HttpErrorResponseException(new HttpWebRequestResponseData(errorResponse));
            };

            var context = CreateTestContext();
            var request = new GetBucketPolicyRequest
            {
                BucketName = "nonexistentbucket"
            };
            ((RequestContext)context.RequestContext).OriginalRequest = request;
            ((RequestContext)context.RequestContext).Request = new GetBucketPolicyRequestMarshaller().Marshall(request);
            ((RequestContext)context.RequestContext).Unmarshaller = GetBucketPolicyResponseUnmarshaller.Instance;

            RuntimePipeline.InvokeSync(context);
            Assert.AreEqual(1, Tester.CallCount);
        }

        [TestMethod][TestCategory("UnitTest")]
        [TestCategory("Runtime")]
        public void Test404()
        {
            Tester.Reset();
            Tester.Action = (int callCount) =>
            {
                var errorResponse = (HttpWebResponse) MockWebResponse.CreateFromResource("404Response.txt");
                throw new HttpErrorResponseException(new HttpWebRequestResponseData(errorResponse));
            };

            var context = CreateTestContext();

            var exception = Utils.AssertExceptionExpected(() =>
            {
                RuntimePipeline.InvokeSync(context);
            },
            typeof(AmazonS3Exception));
            Assert.AreEqual("NoSuchBucket", ((AmazonS3Exception)exception).ErrorCode);
            Assert.AreEqual(HttpStatusCode.NotFound, ((AmazonS3Exception)exception).StatusCode);
            Assert.AreEqual(1, Tester.CallCount);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Runtime")]
        public void Test400WithErrorTypeHeader()
        {
            Tester.Reset();
            Tester.Action = (int callCount) =>
            {
                var errorResponse = (HttpWebResponse)MockWebResponse.CreateFromResource("400WithErrorTypeHeader.txt");
                throw new HttpErrorResponseException(new HttpWebRequestResponseData(errorResponse));
            };

            var context = CreateTestContext();
            ((RequestContext)context.RequestContext).Unmarshaller =
                Amazon.IotData.Model.Internal.MarshallTransformations.UpdateThingShadowResponseUnmarshaller.Instance;

            var exception = Utils.AssertExceptionExpected<Amazon.IotData.Model.InvalidRequestException>(() =>
            {
                RuntimePipeline.InvokeSync(context);
            });
            Assert.AreEqual("InvalidRequestException", exception.ErrorCode);
            Assert.AreEqual(HttpStatusCode.BadRequest, exception.StatusCode);
            Assert.AreEqual(1, Tester.CallCount);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Runtime")]
        public void Test400WithErrorTypeHeaderAndData()
        {
            Tester.Reset();
            Tester.Action = (int callCount) =>
            {
                var errorResponse = (HttpWebResponse)MockWebResponse.CreateFromResource("400WithErrorTypeHeaderAndData.txt");
                throw new HttpErrorResponseException(new HttpWebRequestResponseData(errorResponse));
            };

            var context = CreateTestContext();
            ((RequestContext)context.RequestContext).Unmarshaller =
                Amazon.IotData.Model.Internal.MarshallTransformations.UpdateThingShadowResponseUnmarshaller.Instance;

            var exception = Utils.AssertExceptionExpected<Amazon.IotData.Model.InvalidRequestException>(() =>
            {
                RuntimePipeline.InvokeSync(context);
            });
            Assert.AreEqual("InvalidRequestException", exception.ErrorCode);
            Assert.AreEqual(HttpStatusCode.BadRequest, exception.StatusCode);
            Assert.AreEqual(1, Tester.CallCount);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Runtime")]
        public void Test404WithErrorTypeHeader()
        {
            Tester.Reset();
            Tester.Action = (int callCount) =>
            {
                var errorResponse = (HttpWebResponse)MockWebResponse.CreateFromResource("404WithErrorTypeHeader.txt");
                throw new HttpErrorResponseException(new HttpWebRequestResponseData(errorResponse));
            };

            var context = CreateTestContext();
            ((RequestContext)context.RequestContext).Unmarshaller =
                Amazon.IotData.Model.Internal.MarshallTransformations.GetThingShadowResponseUnmarshaller.Instance;

            var exception = Utils.AssertExceptionExpected<Amazon.IotData.Model.ResourceNotFoundException>(() =>
            {
                RuntimePipeline.InvokeSync(context);
            });
            Assert.AreEqual("ResourceNotFoundException", exception.ErrorCode);
            Assert.AreEqual(HttpStatusCode.NotFound, exception.StatusCode);
            Assert.AreEqual(1, Tester.CallCount);
        }

        [TestMethod][TestCategory("UnitTest")]
        [TestCategory("Runtime")]
        public void Test304()
        {
            Tester.Reset();
            Tester.Action = (int callCount) =>
            {
                var errorResponse = (HttpWebResponse)MockWebResponse.CreateFromResource("304Response.txt");
                throw new HttpErrorResponseException(new HttpWebRequestResponseData(errorResponse));
            };

            var context = CreateTest304Context();

            var exception = Utils.AssertExceptionExpected(() =>
            {
                RuntimePipeline.InvokeSync(context);
            },
            typeof(AmazonS3Exception));
            Assert.AreEqual("NotModified", ((AmazonS3Exception)exception).ErrorCode);
            Assert.AreEqual(HttpStatusCode.NotModified, ((AmazonS3Exception)exception).StatusCode);
            Assert.AreEqual(1, Tester.CallCount);
        }

        private static IExecutionContext CreateTest304Context()
        {
            var getObjectRequest = new GetObjectRequest
            {
                Key = "TestKey",
                BucketName = "TestBucket",
                EtagToNotMatch = "54b0c58c7ce9f2a8b551351102ee0938"
            };
            var requestContext = new RequestContext(true)
            {
                OriginalRequest = getObjectRequest,
                Request = new GetObjectRequestMarshaller().Marshall(getObjectRequest),
                Unmarshaller = GetObjectResponseUnmarshaller.Instance,
                ClientConfig = new AmazonS3Config()
            };
            requestContext.Request.Endpoint = new Uri("https://s3.amazonaws.com");

            //var putObjectResponse = MockWebResponse.CreateFromResource("PutObjectResponse.txt")
            //    as HttpWebResponse;
            return new Amazon.Runtime.Internal.ExecutionContext(requestContext,
                new ResponseContext
                {
                    //HttpResponse = new HttpWebRequestResponseData(putObjectResponse)
                });
        }

        [TestMethod][TestCategory("UnitTest")]
        [TestCategory("Runtime")]
        public void TestExceptionWithNoServerResponse()
        {
            Tester.Reset();
            Tester.Action = (int callCount) =>
            {                
                throw new WebException("Name resolution failure.",
                    WebExceptionStatus.NameResolutionFailure);
            };

            var context = CreateTestContext();
            var exception = Utils.AssertExceptionExpected(() =>
            {
                RuntimePipeline.InvokeSync(context);
            },
            typeof(AmazonServiceException));
            // Test the exact exception type.
            Assert.IsTrue(exception.GetType() == typeof(AmazonServiceException));
            Assert.AreEqual(1, Tester.CallCount);
        }

        [TestMethod][TestCategory("UnitTest")]
        [TestCategory("Runtime")]
        public void TestExceptionWithNoServerResponseBody()
        {
            Tester.Reset();
            Tester.Action = (int callCount) =>
            {
                throw new WebException("Connection closed.",
                    WebExceptionStatus.ConnectionClosed);
            };

            var context = CreateTestContext();
            var exception = Utils.AssertExceptionExpected(() =>
            {
                RuntimePipeline.InvokeSync(context);
            },
            typeof(AmazonServiceException));
            // Test the exact exception type.
            Assert.IsTrue(exception.GetType() == typeof(AmazonServiceException));
            Assert.AreEqual(1, Tester.CallCount);
        }


#if BCL45

        [TestMethod][TestCategory("UnitTest")]
        [TestCategory("Runtime")]
        [TestCategory(@"Runtime\Async45")]
        public async Task TestSuppressed404Async()
        {
            Tester.Reset();
            Tester.Action = (int callCount) =>
            {
                var errorResponse = (HttpWebResponse)MockWebResponse.CreateFromResource("404Response.txt");
                throw new HttpErrorResponseException(new HttpWebRequestResponseData(errorResponse));
            };

            var context = CreateTestContext();
            var request = new GetBucketPolicyRequest
            {
                BucketName = "nonexistentbucket"
            };
            ((RequestContext)context.RequestContext).OriginalRequest = request;
            ((RequestContext)context.RequestContext).Request = new GetBucketPolicyRequestMarshaller().Marshall(request);
            ((RequestContext)context.RequestContext).Unmarshaller = GetBucketPolicyResponseUnmarshaller.Instance;

            await RuntimePipeline.InvokeAsync<AmazonWebServiceResponse>(context);
            Assert.AreEqual(1, Tester.CallCount);
        }

        [TestMethod][TestCategory("UnitTest")]
        [TestCategory("Runtime")]
        [TestCategory(@"Runtime\Async45")]
        public async Task Test404Async()
        {
            Tester.Reset();
            Tester.Action = (int callCount) =>
            {
                var errorResponse = (HttpWebResponse)MockWebResponse.CreateFromResource("404Response.txt");
                throw new HttpErrorResponseException(new HttpWebRequestResponseData(errorResponse));
            };

            var context = CreateTestContext();

            await Utils.AssertExceptionExpectedAsync(() =>
            {
                return RuntimePipeline.InvokeAsync<AmazonWebServiceResponse>(context);
            },
            typeof(AmazonS3Exception));
            Assert.AreEqual(1, Tester.CallCount);
        }

        [TestMethod][TestCategory("UnitTest")]
        [TestCategory("Runtime")]
        [TestCategory(@"Runtime\Async45")]
        public async Task TestExceptionWithNoServerResponseAsync()
        {
            Tester.Reset();
            Tester.Action = (int callCount) =>
            {                
                throw new WebException("Name resolution failure.",
                    WebExceptionStatus.NameResolutionFailure);
            };

            var context = CreateTestContext();
            var exception = await Utils.AssertExceptionExpectedAsync(() =>
            {
                return RuntimePipeline.InvokeAsync<AmazonWebServiceResponse>(context);
            },
            typeof(AmazonServiceException));
            // Test the exact exception type.
            Assert.IsTrue(exception.GetType() == typeof(AmazonServiceException));
            Assert.AreEqual(1, Tester.CallCount);
        }

        [TestMethod][TestCategory("UnitTest")]
        [TestCategory("Runtime")]
        [TestCategory(@"Runtime\Async45")]
        public async Task TestExceptionWithNoServerResponseBodyAsync()
        {
            Tester.Reset();
            Tester.Action = (int callCount) =>
            {
                throw new WebException("Connection closed.",
                    WebExceptionStatus.ConnectionClosed);
            };

            var context = CreateTestContext();
            var exception = await Utils.AssertExceptionExpectedAsync(() =>
            {
                return RuntimePipeline.InvokeAsync<AmazonWebServiceResponse>(context);
            },
            typeof(AmazonServiceException));
            // Test the exact exception type.
            Assert.IsTrue(exception.GetType() == typeof(AmazonServiceException));
            Assert.AreEqual(1, Tester.CallCount);
        }

#elif !BCL45 && BCL

        [TestMethod][TestCategory("UnitTest")]
        [TestCategory("Runtime")]
        [TestCategory(@"Runtime\Async35")]
        public void TestSuppressed404Async()
        {
            Tester.Reset();
            Tester.Action = (int callCount) =>
            {
                var errorResponse = (HttpWebResponse)MockWebResponse.CreateFromResource("404Response.txt");
                throw new HttpErrorResponseException(new HttpWebRequestResponseData(errorResponse));
            };

            var context = CreateAsyncTestContext();
            var request = new GetBucketPolicyRequest
            {
                BucketName = "nonexistentbucket"
            };
            ((RequestContext)context.RequestContext).OriginalRequest = request;
            ((RequestContext)context.RequestContext).Request = new GetBucketPolicyRequestMarshaller().Marshall(request);
            ((RequestContext)context.RequestContext).Unmarshaller = GetBucketPolicyResponseUnmarshaller.Instance;

            var asyncResult = RuntimePipeline.InvokeAsync(context);
            asyncResult.AsyncWaitHandle.WaitOne();

            Assert.IsNull(((RuntimeAsyncResult)asyncResult).Exception);
            Assert.AreEqual(1, Tester.CallCount);
        }

        [TestMethod][TestCategory("UnitTest")]
        [TestCategory("Runtime")]
        [TestCategory(@"Runtime\Async35")]
        public void Test404Async()
        {
            Tester.Reset();
            Tester.Action = (int callCount) =>
            {
                var errorResponse = (HttpWebResponse)MockWebResponse.CreateFromResource("404Response.txt");
                throw new HttpErrorResponseException(new HttpWebRequestResponseData(errorResponse));
            };

            var context = CreateAsyncTestContext();

            var asyncResult = RuntimePipeline.InvokeAsync(context);
            asyncResult.AsyncWaitHandle.WaitOne();
            Assert.IsTrue(((RuntimeAsyncResult)asyncResult).Exception.GetType()
                == typeof(AmazonS3Exception));
            Assert.AreEqual(1, Tester.CallCount);
        }

        [TestMethod][TestCategory("UnitTest")]
        [TestCategory("Runtime")]
        [TestCategory(@"Runtime\Async35")]
        public void TestExceptionWithNoServerResponseAsync()
        {
            Tester.Reset();
            Tester.Action = (int callCount) =>
            {
                throw new WebException("Name resolution failure.",
                    WebExceptionStatus.NameResolutionFailure);
            };

            var context = CreateAsyncTestContext();

            var asyncResult = RuntimePipeline.InvokeAsync(context);
            asyncResult.AsyncWaitHandle.WaitOne();
            // Test the exact exception type.
            Assert.IsTrue(((RuntimeAsyncResult)asyncResult).Exception.GetType()
                == typeof(AmazonServiceException));
            Assert.AreEqual(1, Tester.CallCount);
        }

        [TestMethod][TestCategory("UnitTest")]
        [TestCategory("Runtime")]
        [TestCategory(@"Runtime\Async35")]
        public void TestExceptionWithNoServerResponseBodyAsync()
        {
            Tester.Reset();
            Tester.Action = (int callCount) =>
            {
                throw new WebException("Connection closed.",
                    WebExceptionStatus.ConnectionClosed);
            };

            var context = CreateAsyncTestContext();

            var asyncResult = RuntimePipeline.InvokeAsync(context);
            asyncResult.AsyncWaitHandle.WaitOne();
            // Test the exact exception type.
            Assert.IsTrue(((RuntimeAsyncResult)asyncResult).Exception.GetType()
                == typeof(AmazonServiceException));
            Assert.AreEqual(1, Tester.CallCount);
        }

#endif
    }
}
