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
using Amazon;
using Amazon.Runtime.Internal.Transform;
#if NETFRAMEWORK
using static AWSSDK.UnitTests.UnmarshallerTests;
#endif
using Amazon.Util;
using AWSSDK_DotNet.CommonTest.Utils;
using Amazon.Runtime.Internal.Auth;
using System.Security.Authentication;

namespace AWSSDK.UnitTests
{
    [TestClass()]
    public class RetryHandlerTests : RuntimePipelineTestBase<RetryHandler>
    {
        const int MAX_RETRIES = 2;
        const int MAX_INVALID_ENDPOINT_RETRIES = 2;

        [ClassInitialize]
        public static void Initialize(TestContext t)
        {    
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
        public void RetryForSslErrorZeroReturn()
        {
            Tester.Reset();
            var sslException = new Exception("Root exception", new AuthenticationException("Authentication failed, see inner exception", new Exception("SSL Handshake failed with OpenSSL error - SSL_ERROR_ZERO_RETURN")));
            Tester.Action = (int callCount) =>
            {
                throw sslException;
            };

            Utils.AssertExceptionExpected(() =>
            {
                var request = CreateTestContext();
                RuntimePipeline.InvokeSync(request);
            },
            typeof(Exception));
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

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Runtime")]
        public void RetryForWebExceptionStatusTimeout()
        {
            Tester.Reset();
            Tester.Action = (int callCount) =>
            {
                throw new AmazonServiceException(new WebException("WebException", WebExceptionStatus.Timeout));
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

        [TestMethod][TestCategory("UnitTest")]
        [TestCategory("Runtime")]
        public void RetryForHttpStatus421()
        {
            Tester.Reset();
            Tester.Action = (int callCount) =>
            {
                throw new AmazonServiceException("Invalid Endpoint Exception",
                    new WebException(), (HttpStatusCode)421);
            };

            Utils.AssertExceptionExpected(() =>
            {
                var request = CreateTestContext();
                RuntimePipeline.InvokeSync(request);
            },
            typeof(AmazonServiceException));
            Assert.AreEqual(MAX_INVALID_ENDPOINT_RETRIES, Tester.CallCount);
        }

        // Clock Skew Correction specification: a clock skew error is retried only when the absolute
        // skew computed from that response exceeds the 4-minute detection threshold. Skew is measured
        // from the response Date header in the HttpHandler; this RetryHandler-only pipeline has none,
        // so we seed the > 4-minute candidate the retry gate reads (it persists across attempts).
        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Runtime")]
        public void RetriesClockSkewErrorWhenSkewExceedsThreshold()
        {
            Tester.Reset();
            Uri requestEndpoint = new Uri("https://bucketname.s3.amazonaws.com");

            Tester.Action = (int callCount) =>
            {
                throw new AmazonServiceException("Signature error", ErrorType.Sender,
                    "RequestTimeTooSkewed", "req-1", HttpStatusCode.Forbidden);
            };

            Utils.AssertExceptionExpected(() =>
            {
                var request = CreateTestContext();
                request.RequestContext.Request.Endpoint = requestEndpoint;
                request.RequestContext.ContextAttributes[ClockSkewPipelineHelper.AttemptSkewCandidateKey] =
                    TimeSpan.FromMinutes(-7);
                RuntimePipeline.InvokeSync(request);
            }, typeof(AmazonServiceException));

            // Above the 4-minute threshold => retried until max attempts.
            Assert.AreEqual(MAX_RETRIES + 1, Tester.CallCount);
        }

        // Clock Skew Correction specification: a clock skew error whose computed skew is at or below
        // the 4-minute detection threshold is NOT retried through the clock skew classification.
        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Runtime")]
        public void DoesNotRetryClockSkewErrorWhenSkewBelowThreshold()
        {
            Tester.Reset();
            Uri requestEndpoint = new Uri("https://bucketname.s3.amazonaws.com");

            Tester.Action = (int callCount) =>
            {
                throw new AmazonServiceException("Signature error", ErrorType.Sender,
                    "InvalidSignatureException", "req-1", HttpStatusCode.Forbidden);
            };

            Utils.AssertExceptionExpected(() =>
            {
                var request = CreateTestContext();
                request.RequestContext.Request.Endpoint = requestEndpoint;
                request.RequestContext.ContextAttributes[ClockSkewPipelineHelper.AttemptSkewCandidateKey] =
                    TimeSpan.FromMinutes(-2);
                RuntimePipeline.InvokeSync(request);
            }, typeof(AmazonServiceException));

            // Below threshold => not a clock skew retry, and a 403 sender error is not otherwise retryable.
            Assert.AreEqual(1, Tester.CallCount);
        }

        // .NET implementation test (not a specification JSON case): this SDK stores the correction
        // per endpoint (in the process-global CorrectClockSkew dictionary), whereas the specification
        // models ClientSkew as a single per-client value; per-endpoint is the pre-existing, finer-grained
        // .NET behavior. A recorded skew must be keyed by the request endpoint and leave other endpoints
        // untouched. Recording now lives in ClockSkewPipelineHelper.RecordFromResponse (invoked by the
        // HttpHandler), so we drive that directly.
        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Runtime")]
        public void ClockSkewIsRecordedForTheRequestEndpointNotAnotherEndpoint()
        {
            var originalUtcNowSource = AWSConfigs.utcNowSource;
            try
            {
                var otherEndpoint = "https://other-" + Guid.NewGuid().ToString("N");
                CorrectClockSkew.SetClockCorrectionForEndpoint(otherEndpoint, TimeSpan.FromHours(-1));

                var ctx = CreateTestContext();
                ctx.RequestContext.Request.Endpoint = new Uri("https://request-" + Guid.NewGuid().ToString("N"));
                var requestEndpoint = ctx.RequestContext.Request.Endpoint.ToString();
                Assert.AreEqual(TimeSpan.Zero, CorrectClockSkew.GetClockCorrectionForEndpoint(requestEndpoint));

                // Record a +5 minute skew: midpoint of send/receive is 00:00:01, server Date is 00:05:01.
                var send = new DateTime(2026, 1, 1, 0, 0, 0, DateTimeKind.Utc);
                AWSConfigs.utcNowSource = () => new DateTime(2026, 1, 1, 0, 0, 2, DateTimeKind.Utc);
                var response = new ClockSkewResponseStub(HttpStatusCode.OK, "Thu, 01 Jan 2026 00:05:01 GMT");
                ClockSkewPipelineHelper.RecordFromResponse(ctx, send, response);

                // The learned correction lands on the REQUEST endpoint...
                Assert.AreEqual(300, CorrectClockSkew.GetClockCorrectionForEndpoint(requestEndpoint).TotalSeconds, 0.001);
                // ...and the unrelated endpoint's entry is left untouched.
                Assert.AreEqual(TimeSpan.FromHours(-1), CorrectClockSkew.GetClockCorrectionForEndpoint(otherEndpoint));
            }
            finally
            {
                AWSConfigs.utcNowSource = originalUtcNowSource;
            }
        }

        // Minimal IWebResponseData carrying a status code + Date header, for driving RecordFromResponse.
        private sealed class ClockSkewResponseStub : IWebResponseData
        {
            private readonly Dictionary<string, string> _headers =
                new Dictionary<string, string>(StringComparer.OrdinalIgnoreCase);

            public ClockSkewResponseStub(HttpStatusCode statusCode, string date)
            {
                StatusCode = statusCode;
                if (!string.IsNullOrEmpty(date)) _headers[HeaderKeys.DateHeader] = date;
            }

            public long ContentLength => 0;
            public string ContentType => null;
            public HttpStatusCode StatusCode { get; }
            public bool IsSuccessStatusCode => (int)StatusCode >= 200 && (int)StatusCode <= 299;
            public string[] GetHeaderNames()
            {
                var names = new string[_headers.Count];
                _headers.Keys.CopyTo(names, 0);
                return names;
            }
            public bool IsHeaderPresent(string headerName) => _headers.ContainsKey(headerName);
            public string GetHeaderValue(string headerName) =>
                _headers.TryGetValue(headerName, out var v) ? v : null;
            public IHttpResponseBody ResponseBody => null;
            public Amazon.Runtime.EventStreams.IEventStreamHeader GetEventStreamHeader(string headerName) => null;
            public bool IsEventHeaderPresent(string headerName) => false;
        }

#if NETFRAMEWORK
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
                    "destination", "key", "Upload123", 1);
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
#endif

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
        [TestCategory(@"Runtime\AsyncNetFramework")]
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

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Runtime")]
        [TestCategory(@"Runtime\AsyncNetFramework")]
        public async Task RetryForHttpStatus421Async()
        {
            Tester.Reset();
            Tester.Action = (int callCount) =>
            {
                throw new AmazonServiceException("Invalid Endpoint Exception",
                    new WebException(), (HttpStatusCode)421);
            };

            await Utils.AssertExceptionExpectedAsync(() =>
            {
                var request = CreateTestContext();
                return RuntimePipeline.InvokeAsync<AmazonWebServiceResponse>(request);
            },
            typeof(AmazonServiceException));
            Assert.AreEqual(MAX_INVALID_ENDPOINT_RETRIES, Tester.CallCount);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Runtime")]
        public void VerifyPipelineRetryPolicySelection()
        {
            MockServicePipelineValueClient client;
            RetryHandler handler;
            var credentials = new BasicAWSCredentials("access_key", "secret_key");

            //Test that StandardRetryPolicy is selected for no specified RetryMode which defaults to Standard
            client = new MockServicePipelineValueClient(credentials, new AmazonS3Config());

            handler = (RetryHandler)client.Pipeline.Handlers.Find(h => h is RetryHandler);
            Assert.IsTrue(handler.RetryPolicy is StandardRetryPolicy);

            //Test that StandardRetryPolicy is selected for Standard
            client = new MockServicePipelineValueClient(credentials,
                new AmazonS3Config
                {
                    RetryMode = RequestRetryMode.Standard
                });

            handler = (RetryHandler)client.Pipeline.Handlers.Find(h => h is RetryHandler);
            Assert.IsTrue(handler.RetryPolicy is StandardRetryPolicy);

            //Test that AdaptiveRetryPolicy is selected for Adaptive
            client = new MockServicePipelineValueClient(credentials,
                new AmazonS3Config
                {
                    RetryMode = RequestRetryMode.Adaptive
                });

            handler = (RetryHandler)client.Pipeline.Handlers.Find(h => h is RetryHandler);
            Assert.IsTrue(handler.RetryPolicy is AdaptiveRetryPolicy);
        }
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

    public class MockServicePipelineValueClient : AmazonServiceClient
    {   public RuntimePipeline Pipeline
        {
            get
            {
                return base.RuntimePipeline;
            }
        }
                
        public MockServicePipelineValueClient(AWSCredentials credentials, ClientConfig clientConfig)
            : base(credentials, clientConfig)
        {
        }
    }
}
