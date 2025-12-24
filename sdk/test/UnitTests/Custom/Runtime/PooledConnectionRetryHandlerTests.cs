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

using Amazon.Runtime.Pipeline.HttpHandler;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.IO;
using System.Net;
using System.Net.Http;
using System.Net.Sockets;
using System.Threading;
using System.Threading.Tasks;

namespace AWSSDK.UnitTests.Custom.Runtime
{
    [TestClass]
    public class PooledConnectionRetryHandlerTests
    {

        /// <summary>
        /// Test that SocketException with Shutdown error is detected as a stale connection error
        /// </summary>
        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Runtime")]
        public async Task SocketExceptionShutdown_IsDetectedAndRetried()
        {
            var attemptCount = 0;
            var mockHandler = new MockHttpMessageHandler((request, ct) =>
            {
                attemptCount++;
                if (attemptCount == 1)
                {
                    // First attempt: throw socket shutdown error (Broken pipe on Unix)
                    throw new SocketException((int)SocketError.Shutdown);
                }
                // Second attempt: succeed
                return Task.FromResult(new HttpResponseMessage(HttpStatusCode.OK));
            });

            var retryHandler = new PooledConnectionRetryHandler(mockHandler);
            var client = new HttpClient(retryHandler);
            var request = new HttpRequestMessage(HttpMethod.Get, "https://example.com");

            var response = await client.SendAsync(request);

            Assert.AreEqual(2, attemptCount, "Should have made 2 attempts (initial + retry)");
            Assert.AreEqual(HttpStatusCode.OK, response.StatusCode);
        }

        /// <summary>
        /// Test that SocketException with ConnectionReset is detected as a stale connection error
        /// </summary>
        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Runtime")]
        public async Task SocketExceptionConnectionReset_IsDetectedAndRetried()
        {
            var attemptCount = 0;
            var mockHandler = new MockHttpMessageHandler((request, ct) =>
            {
                attemptCount++;
                if (attemptCount == 1)
                {
                    throw new SocketException((int)SocketError.ConnectionReset);
                }
                return Task.FromResult(new HttpResponseMessage(HttpStatusCode.OK));
            });

            var retryHandler = new PooledConnectionRetryHandler(mockHandler);
            var client = new HttpClient(retryHandler);
            var request = new HttpRequestMessage(HttpMethod.Get, "https://example.com");

            var response = await client.SendAsync(request);

            Assert.AreEqual(2, attemptCount, "Should have made 2 attempts (initial + retry)");
            Assert.AreEqual(HttpStatusCode.OK, response.StatusCode);
        }

        /// <summary>
        /// Test that HttpRequestException wrapping SocketException is properly unwrapped and detected
        /// </summary>
        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Runtime")]
        public async Task HttpRequestExceptionWrappingSocketException_IsDetectedAndRetried()
        {
            var attemptCount = 0;
            var mockHandler = new MockHttpMessageHandler((request, ct) =>
            {
                attemptCount++;
                if (attemptCount == 1)
                {
                    var socketException = new SocketException((int)SocketError.ConnectionReset);
                    throw new HttpRequestException("Error while copying content", socketException);
                }
                return Task.FromResult(new HttpResponseMessage(HttpStatusCode.OK));
            });

            var retryHandler = new PooledConnectionRetryHandler(mockHandler);
            var client = new HttpClient(retryHandler);
            var request = new HttpRequestMessage(HttpMethod.Get, "https://example.com");

            var response = await client.SendAsync(request);

            Assert.AreEqual(2, attemptCount, "Should have made 2 attempts (initial + retry)");
            Assert.AreEqual(HttpStatusCode.OK, response.StatusCode);
        }

        /// <summary>
        /// Test that only one automatic retry is attempted
        /// </summary>
        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Runtime")]
        public async Task OnlyOneRetryAttempt_PreventsInfiniteLoop()
        {
            var attemptCount = 0;
            var mockHandler = new MockHttpMessageHandler((request, ct) =>
            {
                attemptCount++;
                // Always throw stale connection error
                throw new SocketException((int)SocketError.Shutdown);
            });

            var retryHandler = new PooledConnectionRetryHandler(mockHandler);
            var client = new HttpClient(retryHandler);
            var request = new HttpRequestMessage(HttpMethod.Get, "https://example.com");

            await Assert.ThrowsExceptionAsync<SocketException>(async () =>
            {
                await client.SendAsync(request);
            });

            Assert.AreEqual(2, attemptCount, "Should have made exactly 2 attempts (initial + one retry)");
        }

        /// <summary>
        /// Test that non-stale-connection errors are not retried
        /// </summary>
        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Runtime")]
        public async Task NonStaleConnectionError_IsNotRetried()
        {
            var attemptCount = 0;
            var mockHandler = new MockHttpMessageHandler((request, ct) =>
            {
                attemptCount++;
                throw new TaskCanceledException("Request timed out");
            });

            var retryHandler = new PooledConnectionRetryHandler(mockHandler);
            var client = new HttpClient(retryHandler);
            var request = new HttpRequestMessage(HttpMethod.Get, "https://example.com");

            await Assert.ThrowsExceptionAsync<TaskCanceledException>(async () =>
            {
                await client.SendAsync(request);
            });

            Assert.AreEqual(1, attemptCount, "Should have made only 1 attempt (no retry for non-stale errors)");
        }

        /// <summary>
        /// Test that IOException with non-matching message is not retried
        /// </summary>
        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Runtime")]
        public async Task IOExceptionWithNonMatchingMessage_IsNotRetried()
        {
            var attemptCount = 0;
            var mockHandler = new MockHttpMessageHandler((request, ct) =>
            {
                attemptCount++;
                throw new IOException("Disk full");
            });

            var retryHandler = new PooledConnectionRetryHandler(mockHandler);
            var client = new HttpClient(retryHandler);
            var request = new HttpRequestMessage(HttpMethod.Get, "https://example.com");

            await Assert.ThrowsExceptionAsync<IOException>(async () =>
            {
                await client.SendAsync(request);
            });

            Assert.AreEqual(1, attemptCount, "Should have made only 1 attempt (message doesn't match stale connection patterns)");
        }

        /// <summary>
        /// Test successful request on first attempt (no retry needed)
        /// </summary>
        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Runtime")]
        public async Task SuccessfulRequest_NoRetry()
        {
            var attemptCount = 0;
            var mockHandler = new MockHttpMessageHandler((request, ct) =>
            {
                attemptCount++;
                return Task.FromResult(new HttpResponseMessage(HttpStatusCode.OK));
            });

            var retryHandler = new PooledConnectionRetryHandler(mockHandler);
            var client = new HttpClient(retryHandler);
            var request = new HttpRequestMessage(HttpMethod.Get, "https://example.com");

            var response = await client.SendAsync(request);

            Assert.AreEqual(1, attemptCount, "Should have made only 1 attempt (successful)");
            Assert.AreEqual(HttpStatusCode.OK, response.StatusCode);
        }

        /// <summary>
        /// Test that retry throws the new exception if retry also fails
        /// </summary>
        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Runtime")]
        public async Task RetryFailsWithDifferentError_ThrowsNewException()
        {
            var attemptCount = 0;
            var mockHandler = new MockHttpMessageHandler((request, ct) =>
            {
                attemptCount++;
                if (attemptCount == 1)
                {
                    throw new SocketException((int)SocketError.Shutdown);
                }
                // Second attempt throws different error
                throw new InvalidOperationException("Different error");
            });

            var retryHandler = new PooledConnectionRetryHandler(mockHandler);
            var client = new HttpClient(retryHandler);
            var request = new HttpRequestMessage(HttpMethod.Get, "https://example.com");

            await Assert.ThrowsExceptionAsync<InvalidOperationException>(async () =>
            {
                await client.SendAsync(request);
            });

            Assert.AreEqual(2, attemptCount, "Should have made 2 attempts");
        }

        /// <summary>
        /// Test ConnectionAborted SocketException is detected and retried
        /// </summary>
        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Runtime")]
        public async Task SocketExceptionConnectionAborted_IsDetectedAndRetried()
        {
            var attemptCount = 0;
            var mockHandler = new MockHttpMessageHandler((request, ct) =>
            {
                attemptCount++;
                if (attemptCount == 1)
                {
                    throw new SocketException((int)SocketError.ConnectionAborted);
                }
                return Task.FromResult(new HttpResponseMessage(HttpStatusCode.OK));
            });

            var retryHandler = new PooledConnectionRetryHandler(mockHandler);
            var client = new HttpClient(retryHandler);
            var request = new HttpRequestMessage(HttpMethod.Get, "https://example.com");

            var response = await client.SendAsync(request);

            Assert.AreEqual(2, attemptCount, "Should have made 2 attempts (initial + retry)");
            Assert.AreEqual(HttpStatusCode.OK, response.StatusCode);
        }

        /// <summary>
        /// Test thread safety with concurrent requests
        /// </summary>
        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Runtime")]
        public async Task ConcurrentRequests_AreHandledSafely()
        {
            var mockHandler = new MockHttpMessageHandler((request, ct) =>
            {
                // Simulate some work
                Thread.Sleep(10);
                return Task.FromResult(new HttpResponseMessage(HttpStatusCode.OK));
            });

            var retryHandler = new PooledConnectionRetryHandler(mockHandler);
            var client = new HttpClient(retryHandler);

            // Send 10 concurrent requests
            var tasks = new Task<HttpResponseMessage>[10];
            for (int i = 0; i < 10; i++)
            {
                var request = new HttpRequestMessage(HttpMethod.Get, $"https://example.com/{i}");
                tasks[i] = client.SendAsync(request);
            }

            var responses = await Task.WhenAll(tasks);

            Assert.AreEqual(10, responses.Length);
            foreach (var response in responses)
            {
                Assert.AreEqual(HttpStatusCode.OK, response.StatusCode);
            }
        }

        /// <summary>
        /// Mock HttpMessageHandler for testing
        /// </summary>
        private class MockHttpMessageHandler : HttpMessageHandler
        {
            private readonly Func<HttpRequestMessage, CancellationToken, Task<HttpResponseMessage>> _sendFunc;

            public MockHttpMessageHandler(Func<HttpRequestMessage, CancellationToken, Task<HttpResponseMessage>> sendFunc)
            {
                _sendFunc = sendFunc;
            }

            protected override Task<HttpResponseMessage> SendAsync(HttpRequestMessage request, CancellationToken cancellationToken)
            {
                return _sendFunc(request, cancellationToken);
            }
        }
    }
}
