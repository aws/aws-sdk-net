using Amazon.Runtime;
using Amazon.Runtime.Internal.Util;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace AWSSDK.UnitTests.Custom.NetFramework.Custom.Util
{
    [TestClass]
    [TestCategory("UnitTest")]
    [TestCategory("Util")]
    public class MetricsTests
    {
        [TestMethod]
        public void IncrementCounter()
        {
            var metrics = new RequestMetrics() { IsEnabled = true };

            for (var i = 0; i < 1000; i++)
            {
                metrics.IncrementCounter(Metric.AttemptCount);
            }

            Assert.AreEqual(1000, metrics.Counters[Metric.AttemptCount]);
        }

        [TestMethod]
        public void IncrementCounterConcurrently()
        {
            var metrics = new RequestMetrics() { IsEnabled = true };

            Parallel.For(0, 1000, (i) =>
            {
                metrics.IncrementCounter(Metric.AttemptCount);
            });

            Assert.AreEqual(1000, metrics.Counters[Metric.AttemptCount]);
        }
    }
}
