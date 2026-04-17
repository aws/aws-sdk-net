using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Auth;
using Amazon.Runtime.Internal.Transform;
using Amazon.S3;
using Amazon.SQS;
using Amazon.SQS.Model;
using Amazon.SQS.Model.Internal.MarshallTransformations;
using Amazon.DynamoDBv2;
using AWSSDK_DotNet.UnitTests;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Net;
using System.Reflection;

namespace AWSSDK.UnitTests
{
    /// <summary>
    /// Tests for the SEP 2.1 retry behavior, gated behind UseNewRetries2026.
    /// These test cases correspond to the standard mode test cases defined in the
    /// Retry Behavior 2.1 SEP specification.
    /// </summary>
    [TestClass]
    public class RetryHandlerStandardMode21Tests : RuntimePipelineTestBase<RetryHandler>
    {
        private bool _originalUseNewRetries2026;

        [TestInitialize]
        public void TestSetup()
        {
            _originalUseNewRetries2026 = RetryPolicy.UseNewRetries2026;
            RetryPolicy.UseNewRetries2026 = true;
        }

        [TestCleanup]
        public void TestCleanup()
        {
            RetryPolicy.UseNewRetries2026 = _originalUseNewRetries2026;
            Mock21StandardRetryPolicy.Restore();
        }

        private AmazonS3Config CreateS3Config()
        {
            return new AmazonS3Config
            {
                ServiceURL = $"https://s3-{Guid.NewGuid()}.amazonaws.com",
                RetryMode = RequestRetryMode.Standard
            };
        }

        private AmazonDynamoDBConfig CreateDynamoDBConfig()
        {
            return new AmazonDynamoDBConfig
            {
                ServiceURL = $"https://dynamodb-{Guid.NewGuid()}.amazonaws.com",
                RetryMode = RequestRetryMode.Standard
            };
        }

        /// <summary>
        /// Default SEP 2.1 capacity manager with the spec-defined values.
        /// </summary>
        private static CapacityManager CreateDefault21CapacityManager() =>
            new CapacityManager(initialRetryTokens: 500, retryCost: 14, noRetryIncrement: 1,
                timeoutRetryCost: 10, throttlingRetryCost: 5);

        private void RunRetryTest(Action<IExecutionContext, Mock21StandardRetryPolicy> doAction, 
            ClientConfig config, CapacityManager capacityManager = null)
        {
            try
            {
                // Always set a 2.1 capacity manager because the static CapacityManagerInstance
                // is initialized at class load time (before UseNewRetries2026 = true in TestSetup).
                Mock21StandardRetryPolicy.SetCapacityManagerInstance(capacityManager ?? CreateDefault21CapacityManager());

                var retryPolicy = new Mock21StandardRetryPolicy(config);
                Handler = new RetryHandler(retryPolicy);
                if (RuntimePipeline.Handlers.Find(h => h is RetryHandler) != null)
                {
                    RuntimePipeline.ReplaceHandler<RetryHandler>(Handler);
                }
                else
                {
                    RuntimePipeline.AddHandler(Handler);
                }

                var executionContext = CreateTestContext(null, null, config);
                doAction(executionContext, retryPolicy);
            }
            finally
            {
                Mock21StandardRetryPolicy.Restore();
            }
        }

        /// <summary>
        /// Creates an SQS ReceiveMessage execution context for testing long-polling behavior.
        /// </summary>
        private IExecutionContext CreateSqsReceiveMessageContext(AmazonSQSConfig config)
        {
            var receiveMessageRequest = new ReceiveMessageRequest
            {
                QueueUrl = "https://sqs.us-east-1.amazonaws.com/123456789/test-queue"
            };

            var requestContext = new RequestContext(true, new NullSigner())
            {
                OriginalRequest = receiveMessageRequest,
                Request = new ReceiveMessageRequestMarshaller().Marshall(receiveMessageRequest),
                Unmarshaller = ReceiveMessageResponseUnmarshaller.Instance,
                ClientConfig = config
            };

            var serviceMetaData = Assembly.GetAssembly(requestContext.GetType())
                .CreateInstance("Amazon.Runtime.Internal.ServiceMetadata");
            requestContext.GetType().GetProperty("ServiceMetaData").SetValue(requestContext, serviceMetaData);

            requestContext.Request.Endpoint = new Uri("https://sqs.us-east-1.amazonaws.com");

            // Uses PutObjectResponse.txt as a dummy HTTP response — same as RuntimePipelineTestBase.
            // The actual response content is irrelevant; retry tests only need a non-null HttpResponse.
            var dummyResponse = MockWebResponse.CreateFromResource("PutObjectResponse.txt") as HttpWebResponse;
            return new Amazon.Runtime.Internal.ExecutionContext(requestContext,
                new ResponseContext
                {
                    HttpResponse = new HttpWebRequestResponseData(dummyResponse)
                });
        }

        private AmazonSQSConfig CreateSQSConfig()
        {
            return new AmazonSQSConfig
            {
                ServiceURL = $"https://sqs-{Guid.NewGuid()}.amazonaws.com",
                RetryMode = RequestRetryMode.Standard
            };
        }

        #region SEP 2.1 Standard Mode Test Cases

        /// <summary>
        /// SEP Test: Retry eventually succeeds.
        /// exponential_base: 1, delays: [0.05, 0.1], quota: 486→472→486
        /// </summary>
        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Runtime")]
        public void RetryEventuallySucceeds()
        {
            var config = CreateS3Config();
            RunRetryTest((executionContext, retryPolicy) =>
            {
                Tester.Reset();
                Tester.Action = (int callCount) =>
                {
                    switch (callCount)
                    {
                        case 1:
                        case 2:
                            throw new AmazonServiceException($"Mocked service error ({callCount})",
                                new WebException(), HttpStatusCode.InternalServerError);
                        case 3:
                            break; // Success
                        default:
                            throw new Exception($"Invalid number of calls ({callCount})");
                    }
                };

                RuntimePipeline.InvokeSync(executionContext);

                var capacity = Mock21StandardRetryPolicy.CurrentCapacityManagerInstance
                    .GetRetryCapacity(config.ServiceURL);
                Assert.AreEqual(2, executionContext.RequestContext.Retries);
                Assert.AreEqual(3, Tester.CallCount);
                Assert.AreEqual(486, capacity.AvailableCapacity); // 500 - 14 = 486, then restored to 486

                retryPolicy.AssertDelaysMatch(new int[] { 50, 100 });
            }, config);
        }

        /// <summary>
        /// SEP Test: Fail due to max attempts reached.
        /// exponential_base: 1, delays: [0.05, 0.1], quota: 486→472
        /// </summary>
        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Runtime")]
        public void FailDueToMaxAttemptsReached()
        {
            var config = CreateS3Config();
            RunRetryTest((executionContext, retryPolicy) =>
            {
                Tester.Reset();
                Tester.Action = (int callCount) =>
                {
                    throw new AmazonServiceException($"Mocked service error ({callCount})",
                        new WebException(), HttpStatusCode.BadGateway);
                };

                var exception = Utils.AssertExceptionExpected<AmazonServiceException>(() =>
                {
                    RuntimePipeline.InvokeSync(executionContext);
                });

                Assert.AreEqual("Mocked service error (3)", exception.Message);

                var capacity = Mock21StandardRetryPolicy.CurrentCapacityManagerInstance
                    .GetRetryCapacity(config.ServiceURL);
                Assert.AreEqual(2, executionContext.RequestContext.Retries);
                Assert.AreEqual(3, Tester.CallCount);
                Assert.AreEqual(472, capacity.AvailableCapacity); // 500 - 14 - 14 = 472

                retryPolicy.AssertDelaysMatch(new int[] { 50, 100 });
            }, config);
        }

        /// <summary>
        /// SEP Test: Retry Quota reached after a single retry.
        /// initial_retry_tokens: 14, delays: [0.05], quota: 0
        /// </summary>
        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Runtime")]
        public void RetryQuotaReachedAfterASingleRetry()
        {
            var config = CreateS3Config();
            var capacityManager = new CapacityManager(
                initialRetryTokens: 14, retryCost: 14, noRetryIncrement: 1, 
                timeoutRetryCost: 10, throttlingRetryCost: 5);
            RunRetryTest((executionContext, retryPolicy) =>
            {
                Tester.Reset();
                Tester.Action = (int callCount) =>
                {
                    switch (callCount)
                    {
                        case 1:
                            throw new AmazonServiceException($"Mocked service error ({callCount})",
                                new WebException(), HttpStatusCode.InternalServerError);
                        case 2:
                            throw new AmazonServiceException($"Mocked service error ({callCount})",
                                new WebException(), HttpStatusCode.InternalServerError);
                        default:
                            throw new Exception($"Invalid number of calls ({callCount})");
                    }
                };

                var exception = Utils.AssertExceptionExpected<AmazonServiceException>(() =>
                {
                    RuntimePipeline.InvokeSync(executionContext);
                });

                Assert.AreEqual("Mocked service error (2)", exception.Message);

                var capacity = Mock21StandardRetryPolicy.CurrentCapacityManagerInstance
                    .GetRetryCapacity(config.ServiceURL);
                Assert.AreEqual(1, executionContext.RequestContext.Retries);
                Assert.AreEqual(2, Tester.CallCount);
                Assert.AreEqual(0, capacity.AvailableCapacity);

                retryPolicy.AssertDelaysMatch(new int[] { 50 });
            }, config, capacityManager);
        }

        /// <summary>
        /// SEP Test: No retries at all if retry quota is 0.
        /// initial_retry_tokens: 0
        /// </summary>
        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Runtime")]
        public void NoRetriesAtAllIfRetryQuotaIs0()
        {
            var config = CreateS3Config();
            var capacityManager = new CapacityManager(
                initialRetryTokens: 0, retryCost: 14, noRetryIncrement: 1, 
                timeoutRetryCost: 10, throttlingRetryCost: 5);
            RunRetryTest((executionContext, retryPolicy) =>
            {
                Tester.Reset();
                Tester.Action = (int callCount) =>
                {
                    switch (callCount)
                    {
                        case 1:
                            throw new AmazonServiceException($"Mocked service error ({callCount})",
                                new WebException(), HttpStatusCode.InternalServerError);
                        default:
                            throw new Exception($"Invalid number of calls ({callCount})");
                    }
                };

                var exception = Utils.AssertExceptionExpected<AmazonServiceException>(() =>
                {
                    RuntimePipeline.InvokeSync(executionContext);
                });

                Assert.AreEqual("Mocked service error (1)", exception.Message);

                var capacity = Mock21StandardRetryPolicy.CurrentCapacityManagerInstance
                    .GetRetryCapacity(config.ServiceURL);
                Assert.AreEqual(0, executionContext.RequestContext.Retries);
                Assert.AreEqual(1, Tester.CallCount);
                Assert.AreEqual(0, capacity.AvailableCapacity);
            }, config, capacityManager);
        }

        /// <summary>
        /// SEP Test: Verifying exponential backoff timing.
        /// max_attempts: 5, exponential_base: 1, delays: [0.05, 0.1, 0.2, 0.4]
        /// quota: 486→472→458→444
        /// </summary>
        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Runtime")]
        public void VerifyExponentialBackoffTiming()
        {
            var config = CreateS3Config();
            config.MaxErrorRetry = 4;
            RunRetryTest((executionContext, retryPolicy) =>
            {
                Tester.Reset();
                Tester.Action = (int callCount) =>
                {
                    throw new AmazonServiceException($"Mocked service error ({callCount})",
                        new WebException(), HttpStatusCode.InternalServerError);
                };

                var exception = Utils.AssertExceptionExpected<AmazonServiceException>(() =>
                {
                    RuntimePipeline.InvokeSync(executionContext);
                });

                Assert.AreEqual("Mocked service error (5)", exception.Message);

                var capacity = Mock21StandardRetryPolicy.CurrentCapacityManagerInstance
                    .GetRetryCapacity(config.ServiceURL);
                Assert.AreEqual(4, executionContext.RequestContext.Retries);
                Assert.AreEqual(5, Tester.CallCount);
                Assert.AreEqual(444, capacity.AvailableCapacity); // 500 - 4*14 = 444

                retryPolicy.AssertDelaysMatch(new int[] { 50, 100, 200, 400 });
            }, config);
        }

        /// <summary>
        /// SEP Test: Verify max backoff time.
        /// max_attempts: 5, exponential_base: 1, max_backoff_time: 0.2 (200ms)
        /// delays: [0.05, 0.1, 0.2, 0.2]
        /// </summary>
        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Runtime")]
        public void VerifyMaxBackoffTime()
        {
            var config = CreateS3Config();
            config.MaxErrorRetry = 4;
            RunRetryTest((executionContext, retryPolicy) =>
            {
                retryPolicy.MaxBackoffInMilliseconds = 200;
                Tester.Reset();
                Tester.Action = (int callCount) =>
                {
                    throw new AmazonServiceException($"Mocked service error ({callCount})",
                        new WebException(), HttpStatusCode.InternalServerError);
                };

                var exception = Utils.AssertExceptionExpected<AmazonServiceException>(() =>
                {
                    RuntimePipeline.InvokeSync(executionContext);
                });

                Assert.AreEqual("Mocked service error (5)", exception.Message);

                var capacity = Mock21StandardRetryPolicy.CurrentCapacityManagerInstance
                    .GetRetryCapacity(config.ServiceURL);
                Assert.AreEqual(4, executionContext.RequestContext.Retries);
                Assert.AreEqual(5, Tester.CallCount);
                Assert.AreEqual(444, capacity.AvailableCapacity);

                retryPolicy.AssertDelaysMatch(new int[] { 50, 100, 200, 200 });
            }, config);
        }

        /// <summary>
        /// SEP Test: Retry Stops After Retry Quota Exhaustion.
        /// max_attempts: 5, initial_retry_tokens: 20, delays: [0.05]
        /// After 1st retry: quota=6, 2nd retry denied (6 is less than 14)
        /// </summary>
        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Runtime")]
        public void RetryStopsAfterRetryQuotaExhaustion()
        {
            var config = CreateS3Config();
            config.MaxErrorRetry = 4;
            var capacityManager = new CapacityManager(
                initialRetryTokens: 20, retryCost: 14, noRetryIncrement: 1,
                timeoutRetryCost: 10, throttlingRetryCost: 5);
            RunRetryTest((executionContext, retryPolicy) =>
            {
                Tester.Reset();
                Tester.Action = (int callCount) =>
                {
                    throw new AmazonServiceException($"Mocked service error ({callCount})",
                        new WebException(), HttpStatusCode.InternalServerError);
                };

                var exception = Utils.AssertExceptionExpected<AmazonServiceException>(() =>
                {
                    RuntimePipeline.InvokeSync(executionContext);
                });

                Assert.AreEqual("Mocked service error (2)", exception.Message);

                var capacity = Mock21StandardRetryPolicy.CurrentCapacityManagerInstance
                    .GetRetryCapacity(config.ServiceURL);
                Assert.AreEqual(1, executionContext.RequestContext.Retries);
                Assert.AreEqual(2, Tester.CallCount);
                Assert.AreEqual(6, capacity.AvailableCapacity); // 20 - 14 = 6

                retryPolicy.AssertDelaysMatch(new int[] { 50 });
            }, config, capacityManager);
        }

        /// <summary>
        /// SEP Test: Retry quota Recovery After Successful Responses.
        /// max_attempts: 5, initial_retry_tokens: 30
        /// quota: 30→16→2→16→2→16
        /// </summary>
        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Runtime")]
        public void RetryQuotaRecoveryAfterSuccessfulResponses()
        {
            var config = CreateS3Config();
            config.MaxErrorRetry = 4;
            var capacityManager = new CapacityManager(
                initialRetryTokens: 30, retryCost: 14, noRetryIncrement: 1,
                timeoutRetryCost: 10, throttlingRetryCost: 5);
            RunRetryTest((executionContext, retryPolicy) =>
            {
                Tester.Reset();
                Tester.Action = (int callCount) =>
                {
                    switch (callCount)
                    {
                        case 1:
                            throw new AmazonServiceException($"Mocked service error ({callCount})",
                                new WebException(), HttpStatusCode.InternalServerError);
                        case 2:
                            throw new AmazonServiceException($"Mocked service error ({callCount})",
                                new WebException(), HttpStatusCode.BadGateway);
                        case 3:
                            break; // Success
                        default:
                            throw new Exception($"Invalid number of calls ({callCount})");
                    }
                };

                RuntimePipeline.InvokeSync(executionContext);

                var capacity = Mock21StandardRetryPolicy.CurrentCapacityManagerInstance
                    .GetRetryCapacity(config.ServiceURL);
                Assert.AreEqual(16, capacity.AvailableCapacity); // 30 - 14 - 14 + 14 = 16

                retryPolicy.AssertDelaysMatch(new int[] { 50, 100 });

                // Second SDK operation invocation
                retryPolicy.RecordedDelays.Clear();
                var executionContext2 = CreateTestContext(null, null, config);
                Tester.Reset();
                Tester.Action = (int callCount) =>
                {
                    switch (callCount)
                    {
                        case 1:
                            throw new AmazonServiceException($"Mocked service error ({callCount})",
                                new WebException(), HttpStatusCode.InternalServerError);
                        case 2:
                            break; // Success
                        default:
                            throw new Exception($"Invalid number of calls ({callCount})");
                    }
                };

                RuntimePipeline.InvokeSync(executionContext2);

                capacity = Mock21StandardRetryPolicy.CurrentCapacityManagerInstance
                    .GetRetryCapacity(config.ServiceURL);
                Assert.AreEqual(16, capacity.AvailableCapacity); // 16 - 14 + 14 = 16

                retryPolicy.AssertDelaysMatch(new int[] { 50 });
            }, config, capacityManager);
        }

        /// <summary>
        /// SEP Test: Throttling Error Token Bucket Drain (5 tokens) and Backoff Duration (1000ms).
        /// error_code: "Throttling", quota: 495→500, delay: 1000ms
        /// </summary>
        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Runtime")]
        public void ThrottlingErrorTokenBucketDrainAndBackoff()
        {
            var config = CreateS3Config();
            RunRetryTest((executionContext, retryPolicy) =>
            {
                Tester.Reset();
                Tester.Action = (int callCount) =>
                {
                    switch (callCount)
                    {
                        case 1:
                            // Throttling error - costs 5 tokens, uses 1000ms base delay
                            throw new AmazonServiceException("Mocked throttling", new WebException(),
                                ErrorType.Receiver, "Throttling", "TestRequestId", HttpStatusCode.BadRequest);
                        case 2:
                            break; // Success
                        default:
                            throw new Exception($"Invalid number of calls ({callCount})");
                    }
                };

                RuntimePipeline.InvokeSync(executionContext);

                var capacity = Mock21StandardRetryPolicy.CurrentCapacityManagerInstance
                    .GetRetryCapacity(config.ServiceURL);
                Assert.AreEqual(1, executionContext.RequestContext.Retries);
                Assert.AreEqual(2, Tester.CallCount);
                Assert.AreEqual(500, capacity.AvailableCapacity); // 500 - 5 + 5 = 500

                retryPolicy.AssertDelaysMatch(new int[] { 1000 });
            }, config);
        }

        /// <summary>
        /// SEP Test: DynamoDB Base Backoff (25ms) and Increased Retries.
        /// service: dynamodb, delays: [25, 50, 100], max_attempts: 4 (3 retries)
        /// </summary>
        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Runtime")]
        public void DynamoDBBaseBackoffAndIncreasedRetries()
        {
            var config = CreateDynamoDBConfig();
            RunRetryTest((executionContext, retryPolicy) =>
            {
                Tester.Reset();
                Tester.Action = (int callCount) =>
                {
                    throw new AmazonServiceException($"Mocked service error ({callCount})",
                        new WebException(), HttpStatusCode.InternalServerError);
                };

                var exception = Utils.AssertExceptionExpected<AmazonServiceException>(() =>
                {
                    RuntimePipeline.InvokeSync(executionContext);
                });

                // DynamoDB gets 4 max attempts (3 retries) per SEP 2.1
                Assert.AreEqual("Mocked service error (4)", exception.Message);
                Assert.AreEqual(3, executionContext.RequestContext.Retries);
                Assert.AreEqual(4, Tester.CallCount);

                var capacity = Mock21StandardRetryPolicy.CurrentCapacityManagerInstance
                    .GetRetryCapacity(config.ServiceURL);
                Assert.AreEqual(458, capacity.AvailableCapacity); // 500 - 3*14 = 458

                retryPolicy.AssertDelaysMatch(new int[] { 25, 50, 100 });
            }, config);
        }

        /// <summary>
        /// SEP Test: Long-Polling Backoff When Token Bucket Empty.
        /// service: sqs, long_polling: true, initial_retry_tokens: 0
        /// Even though retry quota is exhausted, a long-polling operation should still back off.
        /// outcome: retry_quota_exceeded, delay: 0.05
        /// </summary>
        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Runtime")]
        public void LongPollingBackoffWhenTokenBucketEmpty()
        {
            var config = CreateSQSConfig();
            var capacityManager = new CapacityManager(
                initialRetryTokens: 0, retryCost: 14, noRetryIncrement: 1,
                timeoutRetryCost: 10, throttlingRetryCost: 5);
            try
            {
                Mock21StandardRetryPolicy.SetCapacityManagerInstance(capacityManager);

                var retryPolicy = new Mock21StandardRetryPolicy(config);
                Handler = new RetryHandler(retryPolicy);
                if (RuntimePipeline.Handlers.Find(h => h is RetryHandler) != null)
                {
                    RuntimePipeline.ReplaceHandler<RetryHandler>(Handler);
                }
                else
                {
                    RuntimePipeline.AddHandler(Handler);
                }

                // Use SQS ReceiveMessage context to trigger long-polling detection
                var executionContext = CreateSqsReceiveMessageContext(config);

                Tester.Reset();
                Tester.Action = (int callCount) =>
                {
                    switch (callCount)
                    {
                        case 1:
                            throw new AmazonServiceException($"Mocked service error ({callCount})",
                                new WebException(), HttpStatusCode.InternalServerError);
                        default:
                            throw new Exception($"Invalid number of calls ({callCount})");
                    }
                };

                var exception = Utils.AssertExceptionExpected<AmazonServiceException>(() =>
                {
                    RuntimePipeline.InvokeSync(executionContext);
                });

                Assert.AreEqual("Mocked service error (1)", exception.Message);

                var capacity = Mock21StandardRetryPolicy.CurrentCapacityManagerInstance
                    .GetRetryCapacity(config.ServiceURL);
                Assert.AreEqual(0, executionContext.RequestContext.Retries);
                Assert.AreEqual(1, Tester.CallCount);
                Assert.AreEqual(0, capacity.AvailableCapacity);

                // Even though we didn't retry (quota exhausted), the long-polling operation
                // should still have delayed (backoff on quota exhaustion per SEP 2.1)
                retryPolicy.AssertDelaysMatch(new int[] { 50 });
            }
            finally
            {
                Mock21StandardRetryPolicy.Restore();
            }
        }

        /// <summary>
        /// SEP Test: Honor x-amz-retry-after Header.
        /// header: "1500", delay: 1.5s (1500ms)
        /// </summary>
        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Runtime")]
        public void HonorXAmzRetryAfterHeader()
        {
            var config = CreateS3Config();
            RunRetryTest((executionContext, retryPolicy) =>
            {
                Tester.Reset();
                retryPolicy.RetryAfterValue = 1500;
                Tester.Action = (int callCount) =>
                {
                    switch (callCount)
                    {
                        case 1:
                            throw new AmazonServiceException($"Mocked service error ({callCount})",
                                new WebException(), HttpStatusCode.InternalServerError);
                        case 2:
                            break; // Success
                        default:
                            throw new Exception($"Invalid number of calls ({callCount})");
                    }
                };

                RuntimePipeline.InvokeSync(executionContext);

                Assert.AreEqual(1, executionContext.RequestContext.Retries);
                Assert.AreEqual(2, Tester.CallCount);

                var capacity = Mock21StandardRetryPolicy.CurrentCapacityManagerInstance
                    .GetRetryCapacity(config.ServiceURL);
                Assert.AreEqual(500, capacity.AvailableCapacity); // 500 - 14 + 14 = 500

                retryPolicy.AssertDelaysMatch(new int[] { 1500 });
            }, config);
        }

        /// <summary>
        /// SEP Test: x-amz-retry-after minimum is exponential backoff duration.
        /// header: "0", delay: 0.05s (50ms) — falls back to backoffDelayMs
        /// </summary>
        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Runtime")]
        public void XAmzRetryAfterMinimumIsExponentialBackoff()
        {
            var config = CreateS3Config();
            RunRetryTest((executionContext, retryPolicy) =>
            {
                Tester.Reset();
                retryPolicy.RetryAfterValue = 0;
                Tester.Action = (int callCount) =>
                {
                    switch (callCount)
                    {
                        case 1:
                            throw new AmazonServiceException($"Mocked service error ({callCount})",
                                new WebException(), HttpStatusCode.InternalServerError);
                        case 2:
                            break; // Success
                        default:
                            throw new Exception($"Invalid number of calls ({callCount})");
                    }
                };

                RuntimePipeline.InvokeSync(executionContext);

                retryPolicy.AssertDelaysMatch(new int[] { 50 }); // Clamped to backoffDelayMs = 50ms
            }, config);
        }

        /// <summary>
        /// SEP Test: x-amz-retry-after maximum is 5+exponential backoff duration.
        /// header: "10000" (10s), delay: 5.05s (5050ms) = 5000 + backoffDelayMs(50)
        /// </summary>
        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Runtime")]
        public void XAmzRetryAfterMaximumIs5PlusExponentialBackoff()
        {
            var config = CreateS3Config();
            RunRetryTest((executionContext, retryPolicy) =>
            {
                Tester.Reset();
                retryPolicy.RetryAfterValue = 10000;
                Tester.Action = (int callCount) =>
                {
                    switch (callCount)
                    {
                        case 1:
                            throw new AmazonServiceException($"Mocked service error ({callCount})",
                                new WebException(), HttpStatusCode.InternalServerError);
                        case 2:
                            break; // Success
                        default:
                            throw new Exception($"Invalid number of calls ({callCount})");
                    }
                };

                RuntimePipeline.InvokeSync(executionContext);

                retryPolicy.AssertDelaysMatch(new int[] { 5050 }); // Clamped to 5000 + backoffDelayMs(50)
            }, config);
        }

        /// <summary>
        /// SEP Test: Invalid x-amz-retry-after Falls Back to Exponential Backoff.
        /// When a non-integer value is present in the retry-after context attribute,
        /// CalculateRetryDelay ignores it and falls back to standard exponential backoff.
        /// </summary>
        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Runtime")]
        public void InvalidXAmzRetryAfterFallsBackToExponentialBackoff()
        {
            var config = CreateS3Config();
            RunRetryTest((executionContext, retryPolicy) =>
            {
                Tester.Reset();
                retryPolicy.RetryAfterValue = "invalid";
                Tester.Action = (int callCount) =>
                {
                    switch (callCount)
                    {
                        case 1:
                            throw new AmazonServiceException($"Mocked service error ({callCount})",
                                new WebException(), HttpStatusCode.InternalServerError);
                        case 2:
                            break; // Success
                        default:
                            throw new Exception($"Invalid number of calls ({callCount})");
                    }
                };

                RuntimePipeline.InvokeSync(executionContext);

                retryPolicy.AssertDelaysMatch(new int[] { 50 }); // Falls back to exponential backoff
            }, config);
        }

        /// <summary>
        /// Verify that when UseNewRetries2026 is false, legacy behavior is preserved
        /// (1000ms base delay, jitter applied after MAX_BACKOFF).
        /// </summary>
        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Runtime")]
        public void FeatureFlagOff_PreservesLegacyBehavior()
        {
            RetryPolicy.UseNewRetries2026 = false;
            var config = CreateS3Config();
            RunRetryTest((executionContext, retryPolicy) =>
            {
                Tester.Reset();
                Tester.Action = (int callCount) =>
                {
                    switch (callCount)
                    {
                        case 1:
                            throw new AmazonServiceException($"Mocked service error ({callCount})",
                                new WebException(), HttpStatusCode.InternalServerError);
                        case 2:
                            break; // Success
                        default:
                            throw new Exception($"Invalid number of calls ({callCount})");
                    }
                };

                RuntimePipeline.InvokeSync(executionContext);

                // Legacy formula with jitter=1.0: Min(1 * 2^0 * 1000, 20000) = 1000ms
                retryPolicy.AssertDelaysMatch(new int[] { 1000 });
            }, config);
        }

        /// <summary>
        /// Verify NO_RETRY_INCREMENT: a successful request after a retry restores
        /// the retry cost, while a first-time success adds NO_RETRY_INCREMENT (1 token).
        /// </summary>
        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Runtime")]
        public void NoRetryIncrementOnSuccessAfterRetry()
        {
            var config = CreateS3Config();
            var capacityManager = new CapacityManager(
                initialRetryTokens: 490, retryCost: 14, noRetryIncrement: 1,
                timeoutRetryCost: 10, throttlingRetryCost: 5);
            RunRetryTest((executionContext, retryPolicy) =>
            {
                Tester.Reset();
                Tester.Action = (int callCount) =>
                {
                    switch (callCount)
                    {
                        case 1:
                            throw new AmazonServiceException($"Mocked service error ({callCount})",
                                new WebException(), HttpStatusCode.InternalServerError);
                        case 2:
                            break; // Success after retry
                        default:
                            throw new Exception($"Invalid number of calls ({callCount})");
                    }
                };

                RuntimePipeline.InvokeSync(executionContext);

                var capacity = Mock21StandardRetryPolicy.CurrentCapacityManagerInstance
                    .GetRetryCapacity(config.ServiceURL);
                // 490 - 14 (retry cost) + 14 (restored on success) = 490
                Assert.AreEqual(490, capacity.AvailableCapacity);
            }, config, capacityManager);
        }

        /// <summary>
        /// Verify capacity never exceeds INITIAL_RETRY_TOKENS after success.
        /// </summary>
        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Runtime")]
        public void CapacityNeverExceedsInitialRetryTokens()
        {
            var config = CreateS3Config();
            RunRetryTest((executionContext, retryPolicy) =>
            {
                Tester.Reset();
                Tester.Action = (int callCount) => { /* Success on first try */ };

                RuntimePipeline.InvokeSync(executionContext);

                var capacity = Mock21StandardRetryPolicy.CurrentCapacityManagerInstance
                    .GetRetryCapacity(config.ServiceURL);
                // Should be capped at 500 (INITIAL_RETRY_TOKENS), not 501
                Assert.AreEqual(500, capacity.AvailableCapacity);
            }, config);
        }

        #endregion
    }

    /// <summary>
    /// A Random implementation that always returns a fixed value.
    /// Used to eliminate jitter in tests.
    /// </summary>
    internal class FixedRandom : Random
    {
        private readonly double _value;
        public FixedRandom(double value) { _value = value; }
        public override double NextDouble() => _value;
    }

    public class Mock21StandardRetryPolicy : StandardRetryPolicy
    {
        private static CapacityManager _originalCapacityManager;
        private static Random _originalRandomJitter;

        private static readonly FieldInfo RandomJitterField = typeof(StandardRetryPolicy)
            .GetField("_randomJitter", BindingFlags.NonPublic | BindingFlags.Static)
            ?? throw new InvalidOperationException(
                "Could not find private static field '_randomJitter' on StandardRetryPolicy. " +
                "The field may have been renamed or removed.");

        public Mock21StandardRetryPolicy(IClientConfig config) : base(config)
        {
            // Replace random jitter with fixed value of 1.0 (no jitter, per SEP tests)
            // Uses reflection since _randomJitter is private.
            _originalRandomJitter = (Random)RandomJitterField.GetValue(null);
            RandomJitterField.SetValue(null, new FixedRandom(1.0));
        }

        public static void SetCapacityManagerInstance(CapacityManager capacityManager)
        {
            _originalCapacityManager = CapacityManagerInstance;
            CapacityManagerInstance = capacityManager;
        }

        public static void Restore()
        {
            if (_originalCapacityManager != null)
            {
                CapacityManagerInstance = _originalCapacityManager;
                _originalCapacityManager = null;
            }
            if (_originalRandomJitter != null)
            {
                RandomJitterField.SetValue(null, _originalRandomJitter);
                _originalRandomJitter = null;
            }
        }

        public static CapacityManager CurrentCapacityManagerInstance => CapacityManagerInstance;

        public object RetryAfterValue { get; set; }

        public List<int> RecordedDelays { get; set; } = new List<int>();

        public void AssertDelaysMatch(int[] expectedDelays)
        {
            if (RecordedDelays.Count != expectedDelays.Length)
            {
                throw new AssertFailedException(
                    $"Recorded {RecordedDelays.Count} delays [{string.Join(", ", RecordedDelays)}] " +
                    $"but expected {expectedDelays.Length} delays [{string.Join(", ", expectedDelays)}].");
            }

            for (var i = 0; i < expectedDelays.Length; i++)
            {
                if (RecordedDelays[i] != expectedDelays[i])
                {
                    throw new AssertFailedException(
                        $"Delay index {i} has recorded value of {RecordedDelays[i]} " +
                        $"but expected {expectedDelays[i]}. " +
                        $"All recorded: [{string.Join(", ", RecordedDelays)}], " +
                        $"All expected: [{string.Join(", ", expectedDelays)}].");
                }
            }
        }

        /// <summary>
        /// Overrides WaitBeforeRetry to record the delay calculated by the real
        /// CalculateRetryDelay method instead of actually sleeping. Jitter is set to 1.0
        /// (no randomness) by replacing the Random instance in the constructor.
        /// </summary>
        public override void WaitBeforeRetry(IExecutionContext executionContext)
        {
            if (RetryAfterValue != null)
            {
                executionContext.RequestContext.ContextAttributes["RetryAfterMs"] = RetryAfterValue;
            }

            var delay = CalculateRetryDelay(executionContext, this.MaxBackoffInMilliseconds);
            RecordedDelays.Add(delay);
        }
    }
}
