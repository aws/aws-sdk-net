using Amazon;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.S3;
using AWSSDK_DotNet35.UnitTests;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.IO;
using System.Net;

namespace AWSSDK.UnitTests
{
    [TestClass()]
    public class RetryHandlerStandardModeTests : RuntimePipelineTestBase<RetryHandler>
    {
        private const int DefaultMaxRetries = 2;

        public AmazonS3Config CreateConfig()
        {
            var config = new AmazonS3Config
            {
                //The URL must be unique for these tests as the capacity is stored per URL. Without a 
                //unique URL we would have to clear the static retry capacity cache.
                ServiceURL = $"https://s3-{Guid.NewGuid()}.amazonaws.com",                
                RetryMode = RequestRetryMode.Standard
            };

            return config;
        }
                
        public void RunRetryTest(Action<IExecutionContext, MockStandardRetryPolicy> DoAction, AmazonS3Config config, CapacityManager capacityManager = null)
        {
            try
            {
                if(capacityManager != null)
                {                    
                    MockStandardRetryPolicy.SetCapacityManagerInstance(capacityManager);
                }

                var retryPolicy = new MockStandardRetryPolicy(config);
                Handler = new RetryHandler(retryPolicy);
                if(RuntimePipeline.Handlers.Find(h => h is RetryHandler) != null)
                {
                    RuntimePipeline.ReplaceHandler<RetryHandler>(Handler);
                }
                else
                {
                    RuntimePipeline.AddHandler(Handler);
                }

                var executionContext = CreateTestContext(null, null, config);

                DoAction(executionContext, retryPolicy);
            }
            finally
            {
                if (capacityManager != null)
                {
                    MockStandardRetryPolicy.RestoreManagers();
                }                
            }
        }
        
        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Runtime")]
        public void RetryEventuallySucceeds()
        {
            var config = CreateConfig();
            RunRetryTest((executionContext, retryPolicy) =>
            {
                Tester.Reset();
                Tester.Action = (int callCount) =>
                {
                    switch (callCount)
                    {
                        case 1:                            
                        case 2:
                            throw new AmazonServiceException($"Mocked service error ({callCount})", new WebException(), HttpStatusCode.InternalServerError);
                        case 3:
                            //Return nothing so that a successful response is returned.
                            break;
                        default:
                            throw new Exception($"Invalid number of calls ({callCount})");
                    }
                };
                
                RuntimePipeline.InvokeSync(executionContext);

                var capacity = MockStandardRetryPolicy.CurrentCapacityManagerInstance.GetRetryCapacity(config.ServiceURL);
                Assert.AreEqual(DefaultMaxRetries, executionContext.RequestContext.Retries);
                Assert.AreEqual(3, Tester.CallCount);
                Assert.AreEqual(495, capacity.AvailableCapacity);

                retryPolicy.AssertDelaysMatch(new int[] { 1000, 2000 });
            }, config);
        }


        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Runtime")]
        public void FailDueToMaxAttemptsReached()
        {
            var config = CreateConfig();
            RunRetryTest((executionContext, retryPolicy) =>
            {
                Tester.Reset();
                Tester.Action = (int callCount) =>
                {
                    //Expecting 3 calls
                    throw new AmazonServiceException($"Mocked service error ({callCount})", new WebException(), HttpStatusCode.BadGateway);                    
                };

                var exception = Utils.AssertExceptionExpected<AmazonServiceException>(() =>
                {
                    RuntimePipeline.InvokeSync(executionContext);
                });

                Assert.AreEqual("Mocked service error (3)", exception.Message);

                var capacity = MockStandardRetryPolicy.CurrentCapacityManagerInstance.GetRetryCapacity(config.ServiceURL);
                Assert.AreEqual(DefaultMaxRetries, executionContext.RequestContext.Retries);
                Assert.AreEqual(3, Tester.CallCount);
                Assert.AreEqual(490, capacity.AvailableCapacity);

                retryPolicy.AssertDelaysMatch(new int[] { 1000, 2000 });
            }, config);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Runtime")]
        public void RetryQuotaReachedAfterASingleRetry()
        {
            var config = CreateConfig();
            var capacityManager = new CapacityManager(throttleRetryCount: 1, throttleRetryCost: 5, throttleCost: 1, timeoutRetryCost: 10);
            RunRetryTest((executionContext, retryPolicy) =>
            {
                Tester.Reset();
                Tester.Action = (int callCount) =>
                {
                    switch (callCount)
                    {
                        case 1:
                            throw new AmazonServiceException($"Mocked service error ({callCount})", new WebException(), HttpStatusCode.InternalServerError);
                        case 2:
                            throw new AmazonServiceException($"Mocked service error ({callCount})", new WebException(), HttpStatusCode.BadGateway);
                        default:
                            throw new Exception($"Invalid number of calls ({callCount})");
                    }
                };

                var exception = Utils.AssertExceptionExpected<AmazonServiceException>(() =>
                {
                    RuntimePipeline.InvokeSync(executionContext);
                });

                Assert.AreEqual("Mocked service error (2)", exception.Message);

                var capacity = MockStandardRetryPolicy.CurrentCapacityManagerInstance.GetRetryCapacity(config.ServiceURL);
                Assert.AreEqual(1, executionContext.RequestContext.Retries);
                Assert.AreEqual(2, Tester.CallCount);
                Assert.AreEqual(0, capacity.AvailableCapacity);

                retryPolicy.AssertDelaysMatch(new int[] { 1000 });
            }, config, capacityManager);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Runtime")]
        public void NoRetriesAtAllIfRetryQuotaIs0()
        {
            var config = CreateConfig();
            var capacityManager = new CapacityManager(throttleRetryCount: 0, throttleRetryCost: 5, throttleCost: 1, timeoutRetryCost: 10);
            RunRetryTest((executionContext, retryPolicy) =>
            {
                Tester.Reset();
                Tester.Action = (int callCount) =>
                {
                    switch (callCount)
                    {
                        case 1:
                            throw new AmazonServiceException($"Mocked service error ({callCount})", new WebException(), HttpStatusCode.InternalServerError);                        
                        default:
                            throw new Exception($"Invalid number of calls ({callCount})");
                    }
                };

                var exception = Utils.AssertExceptionExpected<AmazonServiceException>(() =>
                {
                    RuntimePipeline.InvokeSync(executionContext);
                });

                Assert.AreEqual("Mocked service error (1)", exception.Message);

                var capacity = MockStandardRetryPolicy.CurrentCapacityManagerInstance.GetRetryCapacity(config.ServiceURL);
                Assert.AreEqual(0, executionContext.RequestContext.Retries);
                Assert.AreEqual(1, Tester.CallCount);
                Assert.AreEqual(0, capacity.AvailableCapacity);
            }, config, capacityManager);
        }
        
        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Runtime")]
        public void VerifyExponentialBackoffTiming()
        {
            var config = CreateConfig();
            config.MaxErrorRetry = 4;
            RunRetryTest((executionContext, retryPolicy) =>
            {
                Tester.Reset();
                Tester.Action = (int callCount) =>
                {
                    //Expecting 5 calls
                    throw new AmazonServiceException($"Mocked service error ({callCount})", new WebException(), HttpStatusCode.InternalServerError);                    
                };

                var exception = Utils.AssertExceptionExpected<AmazonServiceException>(() =>
                {
                    RuntimePipeline.InvokeSync(executionContext);
                });

                Assert.AreEqual("Mocked service error (5)", exception.Message);

                var capacity = MockStandardRetryPolicy.CurrentCapacityManagerInstance.GetRetryCapacity(config.ServiceURL);
                Assert.AreEqual(4, executionContext.RequestContext.Retries);
                Assert.AreEqual(5, Tester.CallCount);
                Assert.AreEqual(480, capacity.AvailableCapacity);

                retryPolicy.AssertDelaysMatch(new int[] { 1000, 2000, 4000, 8000 });
            }, config);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Runtime")]
        public void VerifyMaxBackoffTime()
        {
            var config = CreateConfig();
            config.MaxErrorRetry = 4;
            RunRetryTest((executionContext, retryPolicy) =>
            {
                retryPolicy.MaxBackoffInMilliseconds = (int)TimeSpan.FromSeconds(3).TotalMilliseconds;
                Tester.Reset();
                Tester.Action = (int callCount) =>
                {
                    //Expecting 5 calls
                    throw new AmazonServiceException($"Mocked service error ({callCount})", new WebException(), HttpStatusCode.InternalServerError);
                };

                var exception = Utils.AssertExceptionExpected<AmazonServiceException>(() =>
                {
                    RuntimePipeline.InvokeSync(executionContext);
                });

                Assert.AreEqual("Mocked service error (5)", exception.Message);

                var capacity = MockStandardRetryPolicy.CurrentCapacityManagerInstance.GetRetryCapacity(config.ServiceURL);
                Assert.AreEqual(4, executionContext.RequestContext.Retries);
                Assert.AreEqual(5, Tester.CallCount);
                Assert.AreEqual(480, capacity.AvailableCapacity);

                retryPolicy.AssertDelaysMatch(new int[] { 1000, 2000, 3000, 3000 });
            }, config);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Runtime")]
        public void VerifyRetryOn200SuccessWithAmazonUnmarshallingError()
        {
            var config = CreateConfig();
            RunRetryTest((executionContext, retryPolicy) =>
            {
                Tester.Reset();
                Tester.Action = (int callCount) =>
                {
                    switch (callCount)
                    {
                        case 1:                            
                        case 2:
                            throw new AmazonUnmarshallingException("TestRequestId", "TestLastKnownLocation", "Mocked error", new NullReferenceException(), HttpStatusCode.OK);
                        case 3:
                            //Return nothing so that a successful response is returned.
                            break;
                        default:
                            throw new Exception($"Invalid number of calls ({callCount})");
                    }
                };

                RuntimePipeline.InvokeSync(executionContext);

                var capacity = MockStandardRetryPolicy.CurrentCapacityManagerInstance.GetRetryCapacity(config.ServiceURL);
                Assert.AreEqual(DefaultMaxRetries, executionContext.RequestContext.Retries);
                Assert.AreEqual(3, Tester.CallCount);
                Assert.AreEqual(495, capacity.AvailableCapacity);

                retryPolicy.AssertDelaysMatch(new int[] { 1000, 2000 });
            }, config);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Runtime")]
        public void VerifyRetryOnTooManyRequestsException()
        {
            var config = CreateConfig();
            RunRetryTest((executionContext, retryPolicy) =>
            {
                Tester.Reset();
                Tester.Action = (int callCount) =>
                {
                    switch (callCount)
                    {
                        case 1:
                        case 2:
                            throw new AmazonServiceException("Mocked exception", new WebException(), ErrorType.Receiver, "TooManyRequestsException", "TestRequestId", (HttpStatusCode)429);
                        case 3:
                            //Return nothing so that a successful response is returned.
                            break;
                        default:
                            throw new Exception($"Invalid number of calls ({callCount})");
                    }
                };

                RuntimePipeline.InvokeSync(executionContext);

                var capacity = MockStandardRetryPolicy.CurrentCapacityManagerInstance.GetRetryCapacity(config.ServiceURL);
                Assert.AreEqual(DefaultMaxRetries, executionContext.RequestContext.Retries);
                Assert.AreEqual(3, Tester.CallCount);
                Assert.AreEqual(495, capacity.AvailableCapacity);

                retryPolicy.AssertDelaysMatch(new int[] { 1000, 2000 });
            }, config);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Runtime")]
        public void VerifyRetryOnRequestTimeout()
        {
            var config = CreateConfig();
            RunRetryTest((executionContext, retryPolicy) =>
            {
                Tester.Reset();
                Tester.Action = (int callCount) =>
                {
                    switch (callCount)
                    {
                        case 1:
                        case 2:
                            throw new AmazonServiceException("Mocked exception", new WebException(), ErrorType.Receiver, "RequestTimeout", "TestRequestId", HttpStatusCode.RequestTimeout);
                        case 3:
                            //Return nothing so that a successful response is returned.
                            break;
                        default:
                            throw new Exception($"Invalid number of calls ({callCount})");
                    }
                };

                RuntimePipeline.InvokeSync(executionContext);

                var capacity = MockStandardRetryPolicy.CurrentCapacityManagerInstance.GetRetryCapacity(config.ServiceURL);
                Assert.AreEqual(DefaultMaxRetries, executionContext.RequestContext.Retries);
                Assert.AreEqual(3, Tester.CallCount);
                Assert.AreEqual(490, capacity.AvailableCapacity);

                retryPolicy.AssertDelaysMatch(new int[] { 1000, 2000 });
            }, config);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Runtime")]
        public void VerifyRetryOnNestedIOException()
        {
            var config = CreateConfig();
            RunRetryTest((executionContext, retryPolicy) =>
            {
                Tester.Reset();
                Tester.Action = (int callCount) =>
                {
                    switch (callCount)
                    {
                        case 1:
                        case 2:
                            throw new AmazonServiceException("Mocked exception", new IOException());
                        case 3:
                            //Return nothing so that a successful response is returned.
                            break;
                        default:
                            throw new Exception($"Invalid number of calls ({callCount})");
                    }
                };

                RuntimePipeline.InvokeSync(executionContext);

                var capacity = MockStandardRetryPolicy.CurrentCapacityManagerInstance.GetRetryCapacity(config.ServiceURL);
                Assert.AreEqual(DefaultMaxRetries, executionContext.RequestContext.Retries);
                Assert.AreEqual(3, Tester.CallCount);
                Assert.AreEqual(495, capacity.AvailableCapacity);

                retryPolicy.AssertDelaysMatch(new int[] { 1000, 2000 });
            }, config);
        }
    }

    public class MockStandardRetryPolicy : StandardRetryPolicy
    {
        private static CapacityManager _originalCapacityManager;
        private double _exponentialBase;
        private double _exponentialPower;        

        public MockStandardRetryPolicy(IClientConfig config)
            : base(config)
        {
            _exponentialBase = 1;
            _exponentialPower = 2;
        }

        public static void SetCapacityManagerInstance(CapacityManager capacityManager)
        {
            _originalCapacityManager = CapacityManagerInstance;
            CapacityManagerInstance = capacityManager;
        }

        public static void RestoreManagers()
        {
            CapacityManagerInstance = _originalCapacityManager;
        }
        
        public static CapacityManager CurrentCapacityManagerInstance => CapacityManagerInstance;

        public List<int> RecordedDelays { get; set; } = new List<int>();

        public void AssertDelaysMatch(int[] expectedDelays) 
        { 
            if(RecordedDelays.Count != expectedDelays.Length)
            {
                throw new AssertFailedException($"Recorded {RecordedDelays.Count} delays but expected {expectedDelays.Length} delays.");
            }

            for(var delay = 0; delay < expectedDelays.Length; delay++)
            {
                if(RecordedDelays[delay] != expectedDelays[delay])
                {
                    throw new AssertFailedException($"Delay index {delay} has recorded value of {RecordedDelays[delay]} but expected the value {expectedDelays[delay]}.");
                }
            }        
        }

        public override void WaitBeforeRetry(IExecutionContext executionContext)
        {
            var msDelay = WaitBeforeRetry(executionContext.RequestContext.Retries, this.MaxBackoffInMilliseconds, _exponentialBase, _exponentialPower);
            RecordedDelays.Add(msDelay);
        }       

        public static int WaitBeforeRetry(int retries, int maxBackoffInMilliseconds, double exponentialBase, double exponentialPower)
        {
            return Convert.ToInt32(Math.Min(exponentialBase * Math.Pow(exponentialPower, retries - 1) * 1000.0, maxBackoffInMilliseconds));            
        }
    }
}
