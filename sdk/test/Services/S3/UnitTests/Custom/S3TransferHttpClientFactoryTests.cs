#if !NETFRAMEWORK
using System;
using Amazon;
using Amazon.S3;
using Amazon.S3.Transfer.Http;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AWSSDK.UnitTests
{
    [TestClass]
    public class S3TransferHttpClientFactoryTests
    {
        [TestMethod]
        [TestCategory("S3")]
        public void DefaultsToTenGbps()
        {
            // Matches the CRT S3 client's default throughput target.
            Assert.AreEqual(10.0, new S3TransferHttpClientFactory().TargetThroughputGbps);
        }

        [TestMethod]
        [TestCategory("S3")]
        public void ConnectionCountDerivedFromThroughput()
        {
            // 0.4 Gbps per connection: 10 Gbps -> 25, 100 Gbps -> 250.
            Assert.AreEqual(25, S3TransferHttpClientFactory.CalculateIdealConnectionCount(10));
            Assert.AreEqual(250, S3TransferHttpClientFactory.CalculateIdealConnectionCount(100));
            Assert.AreEqual(1000, S3TransferHttpClientFactory.CalculateIdealConnectionCount(400));
        }

        [TestMethod]
        [TestCategory("S3")]
        public void ConnectionCountClampedToMinimum()
        {
            // Small targets must still get a usable pool rather than one or two connections.
            Assert.AreEqual(10, S3TransferHttpClientFactory.CalculateIdealConnectionCount(0.1));
            Assert.AreEqual(10, S3TransferHttpClientFactory.CalculateIdealConnectionCount(4));
        }

        [TestMethod]
        [TestCategory("S3")]
        public void ConnectionCountClampedToMaximum()
        {
            Assert.AreEqual(10000, S3TransferHttpClientFactory.CalculateIdealConnectionCount(1000000));
        }

        [TestMethod]
        [TestCategory("S3")]
        public void ConnectionCountRoundsUp()
        {
            // 11 Gbps / 0.4 = 27.5; rounding down would under-provision.
            Assert.AreEqual(28, S3TransferHttpClientFactory.CalculateIdealConnectionCount(11));
        }

        [TestMethod]
        [TestCategory("S3")]
        public void ExplicitConnectionCountOverridesDerivedValue()
        {
            var factory = new S3TransferHttpClientFactory
            {
                TargetThroughputGbps = 100,
                MaxConnectionsPerServer = 42
            };

            Assert.AreEqual(42, factory.IdealConnectionCount);
        }

        [TestMethod]
        [TestCategory("S3")]
        public void RecommendedConcurrencyMatchesConnectionCount()
        {
            // TransferUtility's default of 10 would leave a 25-connection pool under-driven.
            var factory = new S3TransferHttpClientFactory { TargetThroughputGbps = 10 };

            Assert.AreEqual(25, factory.RecommendedConcurrentServiceRequests);
            Assert.AreEqual(100, factory.MaximumInFlightRequests);
        }

        [TestMethod]
        [TestCategory("S3")]
        public void RejectsNonPositiveThroughput()
        {
            Assert.ThrowsExactly<ArgumentOutOfRangeException>(
                () => new S3TransferHttpClientFactory { TargetThroughputGbps = 0 });
            Assert.ThrowsExactly<ArgumentOutOfRangeException>(
                () => new S3TransferHttpClientFactory { TargetThroughputGbps = -1 });
        }

        [TestMethod]
        [TestCategory("S3")]
        public void StallDetectionDisabledByDefault()
        {
            // Both stall detection and the adaptive upload timeout are opt-in; they can turn working
            // requests into retries if mis-tuned.
            var factory = new S3TransferHttpClientFactory();

            Assert.IsFalse(factory.EnableStallDetection);
            Assert.IsFalse(factory.EnableAdaptiveUploadTimeout);
            Assert.AreEqual(1, factory.MinimumThroughputBytesPerSecond);
            Assert.AreEqual(TimeSpan.FromSeconds(30), factory.AllowableThroughputFailureInterval);
        }

        [TestMethod]
        [TestCategory("S3")]
        public void UniqueStringDiffersByThroughputTarget()
        {
            // Without this, two differently tuned factories share one cached HttpClient and the
            // second configuration is silently discarded.
            var config = new AmazonS3Config { RegionEndpoint = RegionEndpoint.USEast1 };

            var ten = new S3TransferHttpClientFactory { TargetThroughputGbps = 10 };
            var hundred = new S3TransferHttpClientFactory { TargetThroughputGbps = 100 };

            Assert.AreNotEqual(
                ten.GetConfigUniqueString(config),
                hundred.GetConfigUniqueString(config));
        }

        [TestMethod]
        [TestCategory("S3")]
        public void UniqueStringDiffersByStallDetection()
        {
            var config = new AmazonS3Config { RegionEndpoint = RegionEndpoint.USEast1 };

            var off = new S3TransferHttpClientFactory { TargetThroughputGbps = 10 };
            var on = new S3TransferHttpClientFactory { TargetThroughputGbps = 10, EnableStallDetection = true };

            Assert.AreNotEqual(
                off.GetConfigUniqueString(config),
                on.GetConfigUniqueString(config));
        }

        [TestMethod]
        [TestCategory("S3")]
        public void UniqueStringIsNotNullSoClientsAreCachedGlobally()
        {
            // A null return would cache per service client instead of globally, defeating pool reuse.
            var config = new AmazonS3Config { RegionEndpoint = RegionEndpoint.USEast1 };

            Assert.IsNotNull(new S3TransferHttpClientFactory().GetConfigUniqueString(config));
        }

        [TestMethod]
        [TestCategory("S3")]
        public void CreateHttpClientHonorsConfiguredTimeout()
        {
            var config = new AmazonS3Config
            {
                RegionEndpoint = RegionEndpoint.USEast1,
                Timeout = TimeSpan.FromSeconds(123)
            };

            using (var client = new S3TransferHttpClientFactory().CreateHttpClient(config))
            {
                Assert.AreEqual(TimeSpan.FromSeconds(123), client.Timeout);
            }
        }
    }
}
#endif
