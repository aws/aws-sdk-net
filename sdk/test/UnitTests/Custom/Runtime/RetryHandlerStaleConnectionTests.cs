/*
 * Copyright Amazon.com, Inc. or its affiliates. All Rights Reserved.
 * 
 * Licensed under the Apache License, Version 2.0 (the "License").
 * You may not use this file except in compliance with the License.
 * A copy of the License is located at
 * 
 *  http://aws.amazon.com/apache2.0
 * 
 * or in the "license" file accompanying this file. This file is distributed
 * on an "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either
 * express or implied. See the License for the specific language governing
 * permissions and limitations under the License.
 */

using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.S3;
using AWSSDK_DotNet.CommonTest.Utils;
using AWSSDK_DotNet.UnitTests;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Net.Sockets;

namespace AWSSDK.UnitTests
{
    [TestClass]
    public class RetryHandlerStaleConnectionTests : RuntimePipelineTestBase<RetryHandler>
    {
        const int MAX_RETRIES = 2;
        const int MAX_STALE_CONNECTION_RETRIES = 3;
        
        private static ClientConfig TestConfig;

        

        [ClassInitialize]
        public static void Initialize(TestContext t)
        {
            TestConfig = new AmazonS3Config
            {
                ServiceURL = @"https://s3.amazonaws.com",
                MaxErrorRetry = MAX_RETRIES,
                MaxStaleConnectionRetries = MAX_STALE_CONNECTION_RETRIES
            };
            Handler = new RetryHandler(new DefaultRetryPolicy(TestConfig));
            RuntimePipeline.AddHandler(Handler);
        }

        /// <summary>
        /// Test that SocketException with Shutdown error is detected as a stale connection error
        /// and retried without counting against MaxErrorRetry
        /// </summary>
        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Runtime")]
        public void SocketExceptionShutdown_IsDetectedAndRetried()
        {
            Tester.Reset();
            Tester.Action = (int callCount) =>
            {
                if (callCount == 1)
                {
                    // First attempt: throw socket shutdown error (Broken pipe on Unix)
                    throw new SocketException((int)SocketError.Shutdown);
                }
                // Second attempt: succeed
            };

            var request = CreateTestContext();
            RuntimePipeline.InvokeSync(request);

            Assert.AreEqual(2, Tester.CallCount, "Should have made 2 attempts (initial + stale connection retry)");
            Assert.AreEqual(0, request.RequestContext.Retries, "Stale connection retries should not count against MaxErrorRetry");
        }

        /// <summary>
        /// Test that SocketException with ConnectionReset is detected as a stale connection error
        /// </summary>
        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Runtime")]
        public void SocketExceptionConnectionReset_IsDetectedAndRetried()
        {
            Tester.Reset();
            Tester.Action = (int callCount) =>
            {
                if (callCount == 1)
                {
                    throw new SocketException((int)SocketError.ConnectionReset);
                }
            };

            var request = CreateTestContext();
            RuntimePipeline.InvokeSync(request);

            Assert.AreEqual(2, Tester.CallCount, "Should have made 2 attempts (initial + stale connection retry)");
            Assert.AreEqual(0, request.RequestContext.Retries, "Stale connection retries should not count against MaxErrorRetry");
        }

        /// <summary>
        /// Test that SocketException with ConnectionAborted is detected and retried
        /// </summary>
        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Runtime")]
        public void SocketExceptionConnectionAborted_IsDetectedAndRetried()
        {
            Tester.Reset();
            Tester.Action = (int callCount) =>
            {
                if (callCount == 1)
                {
                    throw new SocketException((int)SocketError.ConnectionAborted);
                }
            };

            var request = CreateTestContext();
            RuntimePipeline.InvokeSync(request);

            Assert.AreEqual(2, Tester.CallCount, "Should have made 2 attempts (initial + stale connection retry)");
            Assert.AreEqual(0, request.RequestContext.Retries, "Stale connection retries should not count against MaxErrorRetry");
        }

        /// <summary>
        /// Test that nested SocketException (wrapped in another exception) is properly unwrapped and detected
        /// </summary>
        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Runtime")]
        public void NestedSocketException_IsDetectedAndRetried()
        {
            Tester.Reset();
            Tester.Action = (int callCount) =>
            {
                if (callCount == 1)
                {
                    var socketException = new SocketException((int)SocketError.ConnectionReset);
                    throw new System.IO.IOException("Error while copying content", socketException);
                }
            };

            var request = CreateTestContext();
            RuntimePipeline.InvokeSync(request);

            Assert.AreEqual(2, Tester.CallCount, "Should have made 2 attempts (initial + stale connection retry)");
            Assert.AreEqual(0, request.RequestContext.Retries, "Stale connection retries should not count against MaxErrorRetry");
        }

        /// <summary>
        /// Test that MaxStaleConnectionRetries is respected
        /// </summary>
        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Runtime")]
        public void MaxStaleConnectionRetries_IsRespected()
        {
            Tester.Reset();
            Tester.Action = (int callCount) =>
            {
                // Always throw stale connection error
                throw new SocketException((int)SocketError.Shutdown);
            };

            Utils.AssertExceptionExpected(() =>
            {
                var request = CreateTestContext();
                RuntimePipeline.InvokeSync(request);
            },
            typeof(SocketException));

            // Should make initial attempt + MAX_STALE_CONNECTION_RETRIES attempts
            Assert.AreEqual(MAX_STALE_CONNECTION_RETRIES + 1, Tester.CallCount, 
                "Should have made exactly {0} attempts (initial + {1} stale connection retries)", 
                MAX_STALE_CONNECTION_RETRIES + 1, MAX_STALE_CONNECTION_RETRIES);
        }

        /// <summary>
        /// Test that non-stale-connection errors are not treated as stale connection errors
        /// </summary>
        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Runtime")]
        public void NonStaleConnectionError_IsNotRetriedAsStaleConnection()
        {
            Tester.Reset();
            Tester.Action = (int callCount) =>
            {
                throw new System.IO.IOException("Disk full");
            };

            Utils.AssertExceptionExpected(() =>
            {
                var request = CreateTestContext();
                RuntimePipeline.InvokeSync(request);
            },
            typeof(System.IO.IOException));

            // Should retry according to normal retry policy (MAX_RETRIES)
            Assert.AreEqual(MAX_RETRIES + 1, Tester.CallCount, 
                "Should have made {0} attempts using normal retry logic", MAX_RETRIES + 1);
        }

        /// <summary>
        /// Test that stale connection retries are independent of normal retries
        /// (stale connection retries first, then normal retries if still failing)
        /// </summary>
        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Runtime")]
        public void StaleConnectionRetries_ThenNormalRetries()
        {
            Tester.Reset();
            int staleConnectionAttempts = 0;
            Tester.Action = (int callCount) =>
            {
                // First 2 attempts: stale connection errors
                if (callCount <= 2)
                {
                    staleConnectionAttempts++;
                    throw new SocketException((int)SocketError.Shutdown);
                }
                // After stale connection retries exhausted, throw a different retryable error
                throw new System.IO.IOException("Network error");
            };

            Utils.AssertExceptionExpected(() =>
            {
                var request = CreateTestContext();
                RuntimePipeline.InvokeSync(request);
            },
            typeof(System.IO.IOException));

            // Should make: 2 stale connection attempts, then normal retries (MAX_RETRIES + 1)
            Assert.AreEqual(2, staleConnectionAttempts, "Should have made 2 stale connection attempts");
            Assert.AreEqual(2 + MAX_RETRIES + 1, Tester.CallCount, 
                "Should have made 2 stale connection attempts + {0} normal retry attempts", MAX_RETRIES + 1);
        }

        /// <summary>
        /// Test that configurable MaxStaleConnectionRetries value works correctly
        /// </summary>
        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Runtime")]
        public void CustomMaxStaleConnectionRetries_IsRespected()
        {
            const int CUSTOM_MAX_STALE_RETRIES = 5;
            
            // Create a custom config with different MaxStaleConnectionRetries
            ClientConfig config = new AmazonS3Config
            {
                ServiceURL = @"https://s3.amazonaws.com",
                MaxErrorRetry = MAX_RETRIES,
                MaxStaleConnectionRetries = CUSTOM_MAX_STALE_RETRIES
            };
            var customHandler = new RetryHandler(new DefaultRetryPolicy(config));
            var customPipeline = new RuntimePipeline(Tester);
            customPipeline.AddHandler(customHandler);

            Tester.Reset();
            Tester.Action = (int callCount) =>
            {
                // Always throw stale connection error
                throw new SocketException((int)SocketError.ConnectionReset);
            };

            Utils.AssertExceptionExpected(() =>
            {
                var request = CreateTestContext(null, null, config);
                customPipeline.InvokeSync(request);
            },
            typeof(SocketException));

            // Should make initial attempt + CUSTOM_MAX_STALE_RETRIES attempts
            Assert.AreEqual(CUSTOM_MAX_STALE_RETRIES + 1, Tester.CallCount, 
                "Should have made exactly {0} attempts (initial + {1} custom stale connection retries)", 
                CUSTOM_MAX_STALE_RETRIES + 1, CUSTOM_MAX_STALE_RETRIES);
        }

        /// <summary>
        /// Test successful request on first attempt (no retry needed)
        /// </summary>
        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Runtime")]
        public void SuccessfulRequest_NoRetry()
        {
            Tester.Reset();
            Tester.Action = (int callCount) =>
            {
                // Succeed on first attempt
            };

            var request = CreateTestContext();
            RuntimePipeline.InvokeSync(request);

            Assert.AreEqual(1, Tester.CallCount, "Should have made only 1 attempt (successful)");
            Assert.AreEqual(0, request.RequestContext.Retries, "Should have 0 retries");
        }

#if BCL
        /// <summary>
        /// Test async path: SocketException with Shutdown error is detected and retried
        /// </summary>
        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Runtime")]
        [TestCategory(@"Runtime\AsyncNetFramework")]
        public async System.Threading.Tasks.Task SocketExceptionShutdown_IsDetectedAndRetriedAsync()
        {
            Tester.Reset();
            Tester.Action = (int callCount) =>
            {
                if (callCount == 1)
                {
                    throw new SocketException((int)SocketError.Shutdown);
                }
            };

            var request = CreateTestContext();
            await RuntimePipeline.InvokeAsync<AmazonWebServiceResponse>(request);

            Assert.AreEqual(2, Tester.CallCount, "Should have made 2 attempts (initial + stale connection retry)");
            Assert.AreEqual(0, request.RequestContext.Retries, "Stale connection retries should not count against MaxErrorRetry");
        }

        /// <summary>
        /// Test async path: MaxStaleConnectionRetries is respected
        /// </summary>
        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Runtime")]
        [TestCategory(@"Runtime\AsyncNetFramework")]
        public async System.Threading.Tasks.Task MaxStaleConnectionRetries_IsRespectedAsync()
        {
            Tester.Reset();
            Tester.Action = (int callCount) =>
            {
                // Always throw stale connection error
                throw new SocketException((int)SocketError.ConnectionReset);
            };

            await Utils.AssertExceptionExpectedAsync(() =>
            {
                var request = CreateTestContext();
                return RuntimePipeline.InvokeAsync<AmazonWebServiceResponse>(request);
            },
            typeof(SocketException));

            // Should make initial attempt + MAX_STALE_CONNECTION_RETRIES attempts
            Assert.AreEqual(MAX_STALE_CONNECTION_RETRIES + 1, Tester.CallCount, 
                "Should have made exactly {0} attempts (initial + {1} stale connection retries)", 
                MAX_STALE_CONNECTION_RETRIES + 1, MAX_STALE_CONNECTION_RETRIES);
        }
#endif
    }
}
