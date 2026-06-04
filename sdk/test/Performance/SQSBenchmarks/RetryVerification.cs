using Amazon;
using Amazon.Runtime;
using Amazon.SQS;
using Amazon.SQS.Model;
using System;
using System.Net;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;

namespace SQSBenchmarks;

/// <summary>
/// Verifies that PooledContentStream survives retries correctly by forcing
/// the first N HTTP attempts to fail with 500, then letting the request through.
/// If the pooled buffer was corrupted or disposed prematurely, the retry would
/// send garbage or throw.
///
/// Usage: dotnet run -- --verify-retry
/// Requires a real SQS queue URL in the environment variable SQS_QUEUE_URL.
/// </summary>
public static class RetryVerification
{
    public static async Task RunAsync()
    {
        var queueUrl = Environment.GetEnvironmentVariable("SQS_QUEUE_URL");
        if (string.IsNullOrEmpty(queueUrl))
        {
            Console.WriteLine("Set SQS_QUEUE_URL environment variable to a real queue URL.");
            return;
        }

        Console.WriteLine("=== Retry Verification: PooledContentStream ===");
        Console.WriteLine($"Queue: {queueUrl}");
        Console.WriteLine();

        // Force 2 retries before allowing the real request through
        var failingHandler = new RetryForcingHandler(failCount: 2);

        var config = new AmazonSQSConfig
        {
            RegionEndpoint = RegionEndpoint.USEast1,
            HttpClientFactory = new SingleHandlerFactory(failingHandler),
            MaxErrorRetry = 3
        };

        using var client = new AmazonSQSClient(config);

        // Test with various payload sizes
        foreach (var size in new[] { 256, 4096, 65536 })
        {
            failingHandler.Reset();
            var messageBody = new string('X', size);

            Console.WriteLine($"--- Payload: {size} bytes, forcing 2 retries ---");
            try
            {
                var response = await client.SendMessageAsync(new SendMessageRequest
                {
                    QueueUrl = queueUrl,
                    MessageBody = messageBody
                });
                Console.WriteLine($"  SUCCESS: MessageId={response.MessageId}");
                Console.WriteLine($"  Total attempts: {failingHandler.AttemptCount}");
                Console.WriteLine();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"  FAILED: {ex.GetType().Name}: {ex.Message}");
                Console.WriteLine();
            }
        }

        Console.WriteLine("=== Done ===");
    }

    private class RetryForcingHandler : DelegatingHandler
    {
        private int _attemptCount;
        private readonly int _failCount;

        public int AttemptCount => _attemptCount;

        public RetryForcingHandler(int failCount) : base(new HttpClientHandler())
        {
            _failCount = failCount;
        }

        public void Reset() => _attemptCount = 0;

        protected override Task<HttpResponseMessage> SendAsync(
            HttpRequestMessage request, CancellationToken cancellationToken)
        {
            var attempt = Interlocked.Increment(ref _attemptCount);
            if (attempt <= _failCount)
            {
                Console.WriteLine($"  Attempt {attempt}: Returning 500 to force retry");
                return Task.FromResult(new HttpResponseMessage(HttpStatusCode.InternalServerError)
                {
                    Content = new StringContent(
                        "{\"__type\":\"InternalFailure\",\"message\":\"forced retry for testing\"}",
                        System.Text.Encoding.UTF8,
                        "application/x-amz-json-1.0")
                });
            }
            Console.WriteLine($"  Attempt {attempt}: Passing through to real service");
            return base.SendAsync(request, cancellationToken);
        }
    }

    private class SingleHandlerFactory : HttpClientFactory
    {
        private readonly HttpMessageHandler _handler;

        public SingleHandlerFactory(HttpMessageHandler handler)
        {
            _handler = handler;
        }

        public override HttpClient CreateHttpClient(IClientConfig clientConfig)
        {
            return new HttpClient(_handler, disposeHandler: false);
        }

        public override bool UseSDKHttpClientCaching(IClientConfig clientConfig) => false;
        public override bool DisposeHttpClientsAfterUse(IClientConfig clientConfig) => true;
    }
}
