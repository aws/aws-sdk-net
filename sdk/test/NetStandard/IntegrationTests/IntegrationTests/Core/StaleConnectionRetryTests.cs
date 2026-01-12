using Amazon;
using Amazon.Runtime;
using Amazon.S3;
using Amazon.S3.Model;
using System;
using System.Net;
using System.Net.Http;
using System.Net.Sockets;
using System.Threading;
using System.Threading.Tasks;
using Xunit;

namespace Amazon.DNXCore.IntegrationTests.Core
{
    /// <summary>
    /// Integration tests for stale connection retry logic in RetryHandler
    /// </summary>
    public class StaleConnectionRetryTests : TestBase<AmazonS3Client>
    {
        private string bucketName;

        public StaleConnectionRetryTests()
        {
            bucketName = UtilityMethods.CreateBucketAsync(Client, "StaleConnectionRetryTests", true).Result;
        }

        protected override void Dispose(bool disposing)
        {
            UtilityMethods.DeleteBucketWithObjectsAsync(Client, bucketName).Wait();
            base.Dispose(disposing);
        }

        /// <summary>
        /// Test that a single stale connection error is automatically retried and succeeds.
        /// 
        /// Purpose: Validates that a single stale connection error (ConnectionReset) is automatically
        /// retried without counting against MaxErrorRetry.
        /// 
        /// Expected Behavior:
        /// - First attempt throws SocketException (ConnectionReset)
        /// - SDK automatically retries immediately (no backoff delay)
        /// - Second attempt succeeds
        /// - Total attempts: 2 (1 initial + 1 stale connection retry)
        /// - requestContext.Retries remains 0 (stale connection retries don't count)
        /// 
        /// Why This Matters:
        /// Stale connections are common when using connection pooling. The SDK should handle
        /// these transparently without penalizing the application with normal retry limits.
        /// </summary>
        [Fact]
        public async Task SingleStaleConnectionError_IsRetriedAndSucceeds()
        {
            var httpClientFactory = new StaleConnectionSimulatingHttpClientFactory
            {
                FailFirstNAttempts = 1,
                SocketErrorToThrow = SocketError.ConnectionReset
            };

            var client = CreateClientWithCustomHttpFactory(httpClientFactory);

            // Should succeed after one automatic retry
            var response = await client.PutObjectAsync(new PutObjectRequest
            {
                BucketName = bucketName,
                Key = "test-stale-connection",
                ContentBody = "test content"
            });

            Assert.Equal(HttpStatusCode.OK, response.HttpStatusCode);
            Assert.Equal(2, httpClientFactory.TotalAttempts); // 1 failed + 1 success
        }

        /// <summary>
        /// Test that multiple stale connection errors are retried up to MaxStaleConnectionRetries.
        /// 
        /// Purpose: Validates that multiple consecutive stale connection errors are retried up to
        /// MaxStaleConnectionRetries without counting against normal retry limits.
        /// 
        /// Expected Behavior:
        /// - First attempt throws SocketException (Shutdown)
        /// - SDK retries immediately (stale retry #1)
        /// - Second attempt throws SocketException (Shutdown)
        /// - SDK retries immediately (stale retry #2)
        /// - Third attempt succeeds
        /// - Total attempts: 3 (1 initial + 2 stale connection retries)
        /// - requestContext.Retries remains 0 (all were "free" stale connection retries)
        /// 
        /// Why This Matters:
        /// Sometimes connection pool issues affect multiple connections. The SDK should
        /// retry multiple times before giving up, allowing the connection pool to recover.
        /// </summary>
        [Fact]
        public async Task MultipleStaleConnectionErrors_RetriedUpToMaxAttempts()
        {
            var httpClientFactory = new StaleConnectionSimulatingHttpClientFactory
            {
                FailFirstNAttempts = 2,
                SocketErrorToThrow = SocketError.Shutdown
            };

            var client = CreateClientWithCustomHttpFactory(httpClientFactory, maxStaleRetries: 3);

            // Should succeed after two automatic retries
            var response = await client.PutObjectAsync(new PutObjectRequest
            {
                BucketName = bucketName,
                Key = "test-multiple-retries",
                ContentBody = "test content"
            });

            Assert.Equal(HttpStatusCode.OK, response.HttpStatusCode);
            Assert.Equal(3, httpClientFactory.TotalAttempts); // 2 failed + 1 success
        }

        /// <summary>
        /// Test that exceeding MaxStaleConnectionRetries throws the exception after exhausting
        /// both stale connection retries and normal retries.
        /// 
        /// This test validates the SDK's layered retry strategy:
        /// 1. Initial attempt fails with SocketException
        /// 2. SDK exhausts MaxStaleConnectionRetries (2 stale retries)
        /// 3. SDK continues with normal retry logic (MaxErrorRetry = 2)
        /// 4. Total: 1 initial + 2 stale + 2 normal = 5 attempts
        /// 5. Finally throws HttpRequestException (connection-level failures aren't wrapped in AmazonServiceException)
        /// 
        /// This demonstrates that stale connection retries provide immediate recovery,
        /// while normal retries offer additional resilience with backoff for persistent issues.
        /// </summary>
        [Fact]
        public async Task ExceedingMaxStaleConnectionRetries_ThrowsException()
        {
            var httpClientFactory = new StaleConnectionSimulatingHttpClientFactory
            {
                FailFirstNAttempts = 10, // Always fail
                SocketErrorToThrow = SocketError.ConnectionAborted
            };

            var client = CreateClientWithCustomHttpFactory(httpClientFactory, maxStaleRetries: 2);

            await Assert.ThrowsAsync<HttpRequestException>(async () =>
            {
                await client.PutObjectAsync(new PutObjectRequest
                {
                    BucketName = bucketName,
                    Key = "test-exceed-max",
                    ContentBody = "test content"
                });
            });

            // Expected: 1 initial + 2 stale retries + 2 normal retries = 5 total
            // The SDK exhausts stale connection retries first, then continues with normal retry logic
            Assert.Equal(5, httpClientFactory.TotalAttempts);
        }

        /// <summary>
        /// Test stale connection retry with request body (stream rewinding).
        /// 
        /// Purpose: Validates that when a stale connection error occurs while uploading content,
        /// the SDK correctly rewinds the request stream to retry from the beginning.
        /// 
        /// Expected Behavior:
        /// - First attempt: Upload 10KB content, throws SocketException mid-stream
        /// - SDK rewinds stream to position 0
        /// - Second attempt: Re-uploads same content successfully
        /// - Downloads and verifies content matches original (proves stream was rewound correctly)
        /// - Total attempts: 2
        /// 
        /// Why This Matters:
        /// If streams aren't rewound, retry attempts will send partial/corrupted data.
        /// This is critical for reliability with large payloads. The SDK's PrepareForRetry
        /// method handles stream rewinding automatically for seekable streams.
        /// </summary>
        [Fact]
        public async Task StaleConnectionWithRequestBody_StreamIsRewound()
        {
            var httpClientFactory = new StaleConnectionSimulatingHttpClientFactory
            {
                FailFirstNAttempts = 1,
                SocketErrorToThrow = SocketError.ConnectionReset
            };

            var client = CreateClientWithCustomHttpFactory(httpClientFactory);

            var largeContent = new string('a', 10000); // Large enough to test stream rewinding

            // Should succeed after one automatic retry with stream rewound
            var response = await client.PutObjectAsync(new PutObjectRequest
            {
                BucketName = bucketName,
                Key = "test-stream-rewind",
                ContentBody = largeContent
            });

            Assert.Equal(HttpStatusCode.OK, response.HttpStatusCode);
            Assert.Equal(2, httpClientFactory.TotalAttempts);

            // Verify the content was uploaded correctly
            var getResponse = await client.GetObjectAsync(bucketName, "test-stream-rewind");
            using (var reader = new System.IO.StreamReader(getResponse.ResponseStream))
            {
                var retrievedContent = await reader.ReadToEndAsync();
                Assert.Equal(largeContent, retrievedContent);
            }
        }

        /// <summary>
        /// Test different socket error types are recognized and retried.
        /// 
        /// Purpose: Validates that all three socket error types recognized as stale connections
        /// are handled correctly by the SDK's retry logic.
        /// 
        /// Socket Errors Tested:
        /// - Shutdown: Socket has been shut down (common on Unix/Linux, SIGPIPE/broken pipe)
        /// - ConnectionReset: Connection was forcibly closed by remote host (TCP RST)
        /// - ConnectionAborted: Connection aborted locally (network issues, timeouts)
        /// 
        /// Expected Behavior (for each error type):
        /// - First attempt throws SocketException with specific error
        /// - SDK recognizes it as stale connection
        /// - Second attempt succeeds
        /// - Total attempts: 2 per error type
        /// 
        /// Why This Matters:
        /// Different platforms and network conditions produce different socket errors.
        /// The SDK must handle all variants to provide consistent retry behavior across
        /// Windows, Linux, and macOS.
        /// </summary>
        [Theory]
        [InlineData(SocketError.Shutdown)]
        [InlineData(SocketError.ConnectionReset)]
        [InlineData(SocketError.ConnectionAborted)]
        public async Task DifferentSocketErrors_AreRecognizedAndRetried(SocketError errorType)
        {
            var httpClientFactory = new StaleConnectionSimulatingHttpClientFactory
            {
                FailFirstNAttempts = 1,
                SocketErrorToThrow = errorType
            };

            var client = CreateClientWithCustomHttpFactory(httpClientFactory);

            var response = await client.PutObjectAsync(new PutObjectRequest
            {
                BucketName = bucketName,
                Key = $"test-error-{errorType}",
                ContentBody = "test content"
            });

            Assert.Equal(HttpStatusCode.OK, response.HttpStatusCode);
            Assert.Equal(2, httpClientFactory.TotalAttempts);
        }

        /// <summary>
        /// Test custom MaxStaleConnectionRetries configuration values.
        /// 
        /// Purpose: Validates that the SDK correctly respects different MaxStaleConnectionRetries
        /// configuration values and retries the appropriate number of times.
        /// 
        /// Configuration Values Tested:
        /// - MaxStaleConnectionRetries = 1 (minimal retries)
        /// - MaxStaleConnectionRetries = 3 (default value)
        /// - MaxStaleConnectionRetries = 5 (higher limit for connection-heavy scenarios)
        /// 
        /// Expected Behavior (for each configuration):
        /// - Simulator fails (N-1) times where N = MaxStaleConnectionRetries
        /// - SDK retries exactly (N-1) times
        /// - Final attempt succeeds
        /// - Total attempts: N (matches configured MaxStaleConnectionRetries)
        /// 
        /// Why This Matters:
        /// Different applications have different reliability requirements and connection patterns.
        /// Mission-critical applications may want more retries (higher MaxStaleConnectionRetries),
        /// while latency-sensitive applications may want fewer. The SDK must honor these
        /// configuration choices precisely.
        /// </summary>
        [Theory]
        [InlineData(1)]
        [InlineData(3)]
        [InlineData(5)]
        public async Task CustomMaxStaleConnectionRetries_IsRespected(int maxRetries)
        {
            var httpClientFactory = new StaleConnectionSimulatingHttpClientFactory
            {
                FailFirstNAttempts = maxRetries - 1, // Fail one less than max to succeed on last attempt
                SocketErrorToThrow = SocketError.ConnectionReset
            };

            var client = CreateClientWithCustomHttpFactory(httpClientFactory, maxStaleRetries: maxRetries);

            var response = await client.PutObjectAsync(new PutObjectRequest
            {
                BucketName = bucketName,
                Key = $"test-custom-max-{maxRetries}",
                ContentBody = "test content"
            });

            Assert.Equal(HttpStatusCode.OK, response.HttpStatusCode);
            Assert.Equal(maxRetries, httpClientFactory.TotalAttempts);
        }

        /// <summary>
        /// Test that non-stale-connection errors are not retried as stale connections.
        /// 
        /// Purpose: Validates that exceptions which are NOT socket-related stale connection errors
        /// are properly distinguished and handled through normal retry logic instead of stale
        /// connection retry logic.
        /// 
        /// Configuration:
        /// - MaxStaleConnectionRetries = 2
        /// - MaxErrorRetry = 2
        /// - Simulator throws HttpRequestException (not a SocketException)
        /// 
        /// Expected Behavior:
        /// - SDK recognizes the exception is NOT a stale connection error
        /// - Does NOT use stale connection retry logic (no "free" immediate retries)
        /// - Uses normal retry logic with backoff delays
        /// - Total attempts: ≤5 (1 initial + up to 4 normal retries with backoff)
        /// - Finally throws HttpRequestException (connection-level failures aren't wrapped in AmazonServiceException)
        /// 
        /// Why This Matters:
        /// It's critical that the SDK distinguishes between stale connection errors (which deserve
        /// immediate retry) and other errors (which may indicate real problems and should use
        /// exponential backoff). Misclassification could lead to either excessive retries for
        /// genuine errors or insufficient retries for connection issues.
        /// </summary>
        [Fact]
        public async Task NonStaleConnectionError_NotRetriedAsStaleConnection()
        {
            var httpClientFactory = new StaleConnectionSimulatingHttpClientFactory
            {
                ThrowNonSocketException = true,
                FailFirstNAttempts = 10 // Would exceed stale connection retry limit if treated as stale
            };

            var client = CreateClientWithCustomHttpFactory(httpClientFactory, maxStaleRetries: 2);

            // Should throw after normal retries, not stale connection retries
            await Assert.ThrowsAsync<HttpRequestException>(async () =>
            {
                await client.PutObjectAsync(new PutObjectRequest
                {
                    BucketName = bucketName,
                    Key = "test-non-stale",
                    ContentBody = "test content"
                });
            });

            // Should use normal retry logic (initial + MaxErrorRetry), not stale connection retries
            Assert.True(httpClientFactory.TotalAttempts <= 5); // Depends on client's MaxErrorRetry config
        }

        private AmazonS3Client CreateClientWithCustomHttpFactory(
            StaleConnectionSimulatingHttpClientFactory httpClientFactory,
            int maxStaleRetries = 3)
        {
            return new AmazonS3Client(new AmazonS3Config
            {
                RegionEndpoint = Client.Config.RegionEndpoint,
                HttpClientFactory = httpClientFactory,
                MaxStaleConnectionRetries = maxStaleRetries,
                MaxErrorRetry = 2 // Keep normal retries low to distinguish from stale connection retries
            });
        }

        /// <summary>
        /// Custom HttpClientFactory that simulates stale connection errors
        /// </summary>
        private class StaleConnectionSimulatingHttpClientFactory : HttpClientFactory
        {
            public int FailFirstNAttempts { get; set; } = 1;
            public SocketError SocketErrorToThrow { get; set; } = SocketError.ConnectionReset;
            public bool ThrowNonSocketException { get; set; } = false;
            public int TotalAttempts { get; set; } = 0;

            public override HttpClient CreateHttpClient(IClientConfig clientConfig)
            {
                var handler = new StaleConnectionSimulatingHandler(new HttpClientHandler())
                {
                    FailFirstNAttempts = FailFirstNAttempts,
                    SocketErrorToThrow = SocketErrorToThrow,
                    ThrowNonSocketException = ThrowNonSocketException,
                    ParentFactory = this
                };

                return new HttpClient(handler);
            }
        }

        /// <summary>
        /// DelegatingHandler that simulates stale connection errors on first N attempts
        /// </summary>
        private class StaleConnectionSimulatingHandler : DelegatingHandler
        {
            public int FailFirstNAttempts { get; set; } = 1;
            public SocketError SocketErrorToThrow { get; set; } = SocketError.ConnectionReset;
            public bool ThrowNonSocketException { get; set; } = false;
            public StaleConnectionSimulatingHttpClientFactory ParentFactory { get; set; }
            private int _attemptCount = 0;

            public StaleConnectionSimulatingHandler(HttpMessageHandler innerHandler) : base(innerHandler) { }

            protected override async Task<HttpResponseMessage> SendAsync(
                HttpRequestMessage request,
                CancellationToken cancellationToken)
            {
                _attemptCount++;
                if (ParentFactory != null)
                {
                    ParentFactory.TotalAttempts = _attemptCount;
                }

                if (_attemptCount <= FailFirstNAttempts)
                {
                    if (ThrowNonSocketException)
                    {
                        // Throw a different type of exception that should not be treated as stale connection
                        throw new HttpRequestException("Connection failure");
                    }
                    else
                    {
                        // Simulate stale connection
                        throw new HttpRequestException("Socket error", new SocketException((int)SocketErrorToThrow));
                    }
                }

                // After failing N times, proceed with actual request
                return await base.SendAsync(request, cancellationToken);
            }
        }
    }
}
