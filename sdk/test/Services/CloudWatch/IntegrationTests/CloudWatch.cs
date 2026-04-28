using Amazon.CloudWatch;
using Amazon.CloudWatch.Model;
using Amazon.Runtime;
using AWSSDK_DotNet.IntegrationTests.Utils;
using System;
using System.Collections.Generic;
using System.Net;
using System.Threading.Tasks;
using Xunit;

namespace AWSSDK_DotNet.IntegrationTests.Tests
{
    /// <summary>
    /// xUnit fixture that owns a single <see cref="AmazonCloudWatchClient"/> for the lifetime
    /// of the <see cref="CloudWatchTests"/> class.
    /// </summary>
    public class CloudWatchClientFixture : IAsyncLifetime
    {
        public AmazonCloudWatchClient Client { get; private set; }

        public ValueTask InitializeAsync()
        {
            Client = new AmazonCloudWatchClient();
            RetryUtilities.ConfigureClient(Client);
            return default;
        }

        public ValueTask DisposeAsync()
        {
            Client?.Dispose();
            return default;
        }
    }

    [Trait("Category", "CloudWatch")]
    public class CloudWatchTests : IClassFixture<CloudWatchClientFixture>
    {
        private readonly AmazonCloudWatchClient _client;

        public CloudWatchTests(CloudWatchClientFixture fixture)
        {
            _client = fixture.Client;
        }

        [Fact]
        public async Task PutMetricDataWithNonStreamingPayload()
        {
            var random = new Random();
            var request = new PutMetricDataRequest
            {
                Namespace = "compression-test",
                MetricData = new List<MetricDatum>
                {
                    new MetricDatum { MetricName = "test-request-compression-metric", Timestamp = DateTime.UtcNow, Unit = StandardUnit.Count, Value = random.Next(100) },
                    new MetricDatum { MetricName = "test-request-compression-metric", Timestamp = DateTime.UtcNow.AddSeconds(2), Unit = StandardUnit.Bytes, Value = random.Next(100) },
                    new MetricDatum { MetricName = "test-request-compression-metric", Timestamp = DateTime.UtcNow.AddSeconds(4), Unit = StandardUnit.Bytes, Value = random.Next(100) },
                    new MetricDatum { MetricName = "test-request-compression-metric", Timestamp = DateTime.UtcNow.AddSeconds(6), Unit = StandardUnit.Bytes, Value = random.Next(100) },
                    new MetricDatum { MetricName = "test-request-compression-metric", Timestamp = DateTime.UtcNow.AddSeconds(8), Unit = StandardUnit.Bytes, Value = random.Next(100) },
                    new MetricDatum { MetricName = "test-request-compression-metric", Timestamp = DateTime.UtcNow.AddSeconds(10), Unit = StandardUnit.Bytes, Value = random.Next(100) },
                }
            };

            var config = _client.Config as ClientConfig;
            config.RequestMinCompressionSizeBytes = 0;

            var response = await _client.PutMetricDataAsync(request);
            Assert.False(_client.Config.DisableRequestCompression);
            Assert.Equal(HttpStatusCode.OK, response.HttpStatusCode);
        }
    }
}
