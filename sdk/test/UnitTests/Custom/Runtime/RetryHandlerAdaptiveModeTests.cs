using Amazon;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.S3;
using AWSSDK_DotNet.UnitTests;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Net;

namespace AWSSDK.UnitTests
{
    [TestClass()]
    public class RetryHandlerAdaptiveModeTests : RuntimePipelineTestBase<RetryHandler>
    {
        private const int DefaultMaxRetries = 2;

        public AmazonS3Config CreateConfig()
        {
            var config = new AmazonS3Config
            {
                //The URL must be unique for these tests as the capacity is stored per URL. Without a 
                //unique URL we would have to clear the static retry capacity cache.
                ServiceURL = $"https://s3-{Guid.NewGuid()}.amazonaws.com",
                RetryMode = RequestRetryMode.Adaptive
            };

            return config;
        }
        
        public void RunRetryTest(Action<IExecutionContext, MockAdaptiveRetryPolicy> DoAction, AmazonS3Config config, CapacityManager capacityManager = null)
        {
            try
            {
                if (capacityManager != null)
                {
                    MockAdaptiveRetryPolicy.SetCapacityManagerInstance(capacityManager);
                }

                var retryPolicy = new MockAdaptiveRetryPolicy(config);
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

                DoAction(executionContext, retryPolicy);
            }
            finally
            {
                if (capacityManager != null)
                {
                    MockAdaptiveRetryPolicy.RestoreManagers();
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

                var capacity = MockAdaptiveRetryPolicy.CurrentCapacityManagerInstance.GetRetryCapacity(config.ServiceURL);
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

                var capacity = MockAdaptiveRetryPolicy.CurrentCapacityManagerInstance.GetRetryCapacity(config.ServiceURL);
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

                var capacity = MockAdaptiveRetryPolicy.CurrentCapacityManagerInstance.GetRetryCapacity(config.ServiceURL);
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

                var capacity = MockAdaptiveRetryPolicy.CurrentCapacityManagerInstance.GetRetryCapacity(config.ServiceURL);
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

                var capacity = MockAdaptiveRetryPolicy.CurrentCapacityManagerInstance.GetRetryCapacity(config.ServiceURL);
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

                var capacity = MockAdaptiveRetryPolicy.CurrentCapacityManagerInstance.GetRetryCapacity(config.ServiceURL);
                Assert.AreEqual(4, executionContext.RequestContext.Retries);
                Assert.AreEqual(5, Tester.CallCount);
                Assert.AreEqual(480, capacity.AvailableCapacity);

                retryPolicy.AssertDelaysMatch(new int[] { 1000, 2000, 3000, 3000 });
            }, config);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Runtime")]
        public void VerifyClientRateLimitingFastFailRequestWithNoTokenBucketCapacity()
        {
            var config = CreateConfig();
            config.FastFailRequests = true;
            RunRetryTest((executionContext, retryPolicy) =>
            {
                retryPolicy.EmptyTokenBucketCapacity();

                Tester.Reset();
                Tester.Action = (int callCount) =>
                {
                    switch (callCount)
                    {
                        case 1:
                            //Throw a throttling type error to trigger client rate limiting.
                            throw new AmazonServiceException("Mocked exception", new WebException(), ErrorType.Receiver, "TooManyRequestsException", "TestRequestId", (HttpStatusCode)429);
                        case 2:
                            break;
                        default:
                            throw new Exception($"Invalid number of calls ({callCount})");
                    }
                };

                var exception = Utils.AssertExceptionExpected<AmazonClientException>(() =>
                {
                    RuntimePipeline.InvokeSync(executionContext);
                });

                Assert.AreEqual("While attempting to retry a request error capacity could not be obtained. The client is configured to fail fast and there is insufficient capacity to attempt the request.", exception.Message);

                var capacity = MockAdaptiveRetryPolicy.CurrentCapacityManagerInstance.GetRetryCapacity(config.ServiceURL);
                Assert.AreEqual(1, executionContext.RequestContext.Retries);
                Assert.AreEqual(1, Tester.CallCount);
                Assert.AreEqual(495, capacity.AvailableCapacity);
                Assert.AreEqual(0, retryPolicy.TokenBucketInstance.WaitForTokenCallCount);
            }, config);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Runtime")]
        public void VerifyClientRateLimitingNoHangMultipleAttemptsNoTokenBucketCapacity()
        {
            var config = CreateConfig();
            RunRetryTest((executionContext, retryPolicy) =>
            {
                retryPolicy.EmptyTokenBucketCapacity();

                Tester.Reset();
                Tester.Action = (int callCount) =>
                {
                    switch (callCount)
                    {
                        case 1:
                            //Throw a throttling type error to trigger client rate limiting.
                            throw new AmazonServiceException("Mocked exception", new WebException(), ErrorType.Receiver, "TooManyRequestsException", "TestRequestId", (HttpStatusCode)429);
                        case 2:
                            break;
                        default:
                            throw new Exception($"Invalid number of calls ({callCount})");
                    }
                };

                var exception = Utils.AssertExceptionExpected<AmazonClientException>(() =>
                {
                    RuntimePipeline.InvokeSync(executionContext);
                });

                Assert.AreEqual("While attempting to retry a request error capacity could not be obtained. There is insufficient capacity to attempt the request after attempting to obtain capacity multiple times.", exception.Message);

                var capacity = MockAdaptiveRetryPolicy.CurrentCapacityManagerInstance.GetRetryCapacity(config.ServiceURL);
                Assert.AreEqual(1, executionContext.RequestContext.Retries);
                Assert.AreEqual(1, Tester.CallCount);
                Assert.AreEqual(495, capacity.AvailableCapacity);
                Assert.AreEqual(14, retryPolicy.TokenBucketInstance.WaitForTokenCallCount);
            }, config);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Runtime")]
        public void VerifyCUBICCalculations()
        {
            var expectedRates = new double[] { 7.0, 9.64893600966, 10.000030849917364, 
                10.453284520772092, 13.408697022224185, 21.266268354273642, 36.425998516920465 };

            var baseTimestamp = 5;
            var tokenBucket = new MockedTokenBucket(minRate: 0.5, minCapacity: 1.0, beta: 0.7, scaleConstant: 0.4, smooth: 0.8);
            tokenBucket.SetupTest(lastMaxRate: 10, lastThrottleTime: 5);
            for (var timestamp = baseTimestamp; timestamp <= 11; timestamp++)
            {
                tokenBucket.CurrentTimestamp = timestamp;
                tokenBucket.DoTestCalculation(false);
                Assert.AreEqual(expectedRates[timestamp - baseTimestamp], tokenBucket.LastCalculatedRate, .00000000001);
            }            
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Runtime")]
        public void VerifyCUBICCalculationsWithThrottling()
        {
            var expectedRates = new double[] { 7.0, 9.64893600966, 6.754255206761999,
                4.727978644733399, 6.606547753887045, 6.763279816944947, 7.598174833907107,
                11.511232804773524};

            var tokenBucket = new MockedTokenBucket(minRate: 0.5, minCapacity: 1.0, beta: 0.7, scaleConstant: 0.4, smooth: 0.8);
            tokenBucket.SetupTest(lastMaxRate: 10, lastThrottleTime: 5);

            var baseTimestamp = 5;
            for (var timestamp = baseTimestamp; timestamp <= 12; timestamp++)
            {
                tokenBucket.CurrentTimestamp = timestamp;
                tokenBucket.DoTestCalculation(timestamp == 7 || timestamp == 8);    
                Assert.AreEqual(expectedRates[timestamp - baseTimestamp], tokenBucket.LastCalculatedRate, .00000000001);
            }
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Runtime")]
        public void VerifyUpdateClientSendingRate()
        {
            var measuredTxRate = new double[] 
            { 
                0.000000, 0.000000, 4.800000, 4.800000, 4.160000, 
                4.160000, 4.160000, 5.632000, 5.632000, 4.326400, 
                4.326400, 4.326400, 5.665280, 5.665280, 4.333056, 
                4.333056, 4.333056
            };

            var newTokenBucketRate = new double[] 
            { 
                0.500000, 0.500000, 0.500000, 0.500000, 0.500000,
                0.691200, 1.097600, 1.638400, 2.332800, 3.028480,
                3.486639, 3.821874, 4.053386, 4.200373, 4.282037,
                2.997426, 3.452226
            };

            var tokenBucket = new MockedTokenBucket(minRate: 0.5, minCapacity: 1.0, beta: 0.7, scaleConstant: 0.4, smooth: 0.8);
            for (var request = 1; request <= 17; request++)
            {            
                tokenBucket.CurrentTimestamp = request * 0.2;
                tokenBucket.UpdateClientSendingRate(request == 10 || request == 16);
                Assert.AreEqual(measuredTxRate[request - 1], tokenBucket.LastMeasuredTxRate, .000001);
                Assert.AreEqual(newTokenBucketRate[request - 1], tokenBucket.LastNewTokenBucketRate, .000001);
            }
        }
    }

    public class MockAdaptiveRetryPolicy : AdaptiveRetryPolicy
    {
        private static CapacityManager _originalCapacityManager;        
        private double _exponentialBase;
        private double _exponentialPower;

        public MockAdaptiveRetryPolicy(IClientConfig config)
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
            if (RecordedDelays.Count != expectedDelays.Length)
            {
                throw new AssertFailedException($"Recorded {RecordedDelays.Count} delays but expected {expectedDelays.Length} delays.");
            }

            for (var delay = 0; delay < expectedDelays.Length; delay++)
            {
                if (RecordedDelays[delay] != expectedDelays[delay])
                {
                    throw new AssertFailedException($"Delay index {delay} has recorded value of {RecordedDelays[delay]} but expected the value {expectedDelays[delay]}.");
                }
            }
        }

        public override void WaitBeforeRetry(IExecutionContext executionContext)
        {
            //Adaptive and standard both use the same backoff with jitter calculations.
            var msDelay = MockStandardRetryPolicy.WaitBeforeRetry(executionContext.RequestContext.Retries, this.MaxBackoffInMilliseconds, _exponentialBase, _exponentialPower);
            RecordedDelays.Add(msDelay);
        }

        public void EmptyTokenBucketCapacity()
        {
            var mockedTokenBucket = new MockedTokenBucket();
            mockedTokenBucket.EmptyCapacity();
            TokenBucket = mockedTokenBucket;
        }

        public MockedTokenBucket TokenBucketInstance => TokenBucket as MockedTokenBucket;
    }

    public class MockedTokenBucket : TokenBucket
    {    
        public MockedTokenBucket()
           : base()
        {
        }

        public MockedTokenBucket(double minRate, double minCapacity, double beta, double scaleConstant, double smooth)
            : base(minRate, minCapacity, beta, scaleConstant, smooth)
        {
        }

        protected override void WaitForToken(int delayMs)
        {
            WaitForTokenCallCount++;
        }

        public int WaitForTokenCallCount { get; set; }

        public double LastCalculatedRate { get; private set; }

        public double CurrentTimestamp { get; set; }

        public double LastMeasuredTxRate { get; private set; }

        public double LastNewTokenBucketRate { get; private set; } 
        
        protected override double GetTimestamp()
        {
            return CurrentTimestamp;
        }        

        public void SetupTest(double lastMaxRate, double lastThrottleTime)
        {
            LastMaxRate = lastMaxRate;
            LastThrottleTime = lastThrottleTime;
        }                

        public void DoTestCalculation(bool throttle)
        {        
            if (throttle)
            {
                LastMaxRate = LastCalculatedRate;
                CalculateTimeWindow();
                LastThrottleTime = GetTimestamp();
                LastCalculatedRate = CUBICThrottle(LastCalculatedRate);
            }
            else
            {
                CalculateTimeWindow();
                LastCalculatedRate = CUBICSuccess(CurrentTimestamp);
            }
        }

        protected override void TokenBucketUpdateRate(double newRps)
        {        
            base.TokenBucketUpdateRate(newRps);
            LastNewTokenBucketRate = FillRate.Value;
        }

        protected override void UpdateMeasuredRate()
        {
            base.UpdateMeasuredRate();
            LastMeasuredTxRate = MeasuredTxRate;
        }

        public void EmptyCapacity()
        {
            CurrentCapacity = 0;
        }
    }
}
