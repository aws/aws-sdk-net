using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Amazon.CloudWatch;
using Amazon.CloudWatch.Model;
using Amazon.Runtime;
using System.Net;
using System.Threading.Tasks;

namespace AWSSDK_DotNet.IntegrationTests.Tests
{
    [TestClass]
    public class CloudWatch : TestBase<AmazonCloudWatchClient>
    {
        [TestMethod]
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

            var config = Client.Config as ClientConfig;
            config.RequestMinCompressionSizeBytes = 0;

            var response = await Client.PutMetricDataAsync(request);
            Assert.IsFalse(Client.Config.DisableRequestCompression);
            Assert.AreEqual(response.HttpStatusCode, HttpStatusCode.OK);
        }
    }
}
