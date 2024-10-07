using Amazon.Runtime;
using Amazon.Runtime.Internal.Util;
using System.Threading.Tasks;
using Xunit;

namespace UnitTests.NetStandard
{
    [Trait("Category", "Core")]
    public class MetricsTests
    {
        [Fact]
        public void IncrementCounter()
        {
            var metrics = new RequestMetrics() { IsEnabled = true };

            for (var i = 0; i < 1000; i++)
            {
                metrics.IncrementCounter(Metric.AttemptCount);
            }

            Assert.Equal(1000, metrics.Counters[Metric.AttemptCount]);
        }

        [Fact]
        public void IncrementCounterConcurrently()
        {
            var metrics = new RequestMetrics() { IsEnabled = true };

            Parallel.For(0, 1000, (i) =>
            {
                metrics.IncrementCounter(Metric.AttemptCount);
            });

            Assert.Equal(1000, metrics.Counters[Metric.AttemptCount]);
        }
    }
}
