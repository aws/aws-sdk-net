using System.Linq;
using System.Threading;
using Amazon.Runtime;
using Amazon.Runtime.Internal.Util;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AWSSDK.UnitTests
{
    [TestClass]
    [TestCategory("Core")]
    public class RequestMetricsTests
    {
        [TestMethod]
        public void Disabled_TracksNothing()
        {
            var metrics = new RequestMetrics();

            var timingEvent = metrics.StartEvent(Metric.HttpRequestTime);
            Assert.AreSame(timingEvent, metrics.StartEvent(Metric.RequestSigningTime));
            timingEvent.Dispose();
            metrics.AddProperty(Metric.AsyncCall, true);
            metrics.IncrementCounter(Metric.AttemptCount);

            Assert.AreEqual(0, metrics.Timings.Count);
            Assert.AreEqual(0, metrics.Properties.Count);
            Assert.AreEqual(0, metrics.Counters.Count);
            Assert.AreEqual(string.Empty, metrics.GetErrors());
        }

        [TestMethod]
        public void Disabled_StillTimesCsmAttemptLatency()
        {
            var metrics = new RequestMetrics();

            metrics.StartEvent(Metric.CSMAttemptLatency);
            Thread.Sleep(1);

            Assert.IsTrue(metrics.StopEvent(Metric.CSMAttemptLatency).ElapsedTicks > 0);
            Assert.AreEqual(0, metrics.Timings.Count);
        }

        [TestMethod]
        public void Enabled_RecordsTimingsPropertiesCountersAndErrors()
        {
            var metrics = new RequestMetrics { IsEnabled = true };

            using (metrics.StartEvent(Metric.HttpRequestTime)) { }
            metrics.StopEvent(Metric.RetryPauseTime);
            metrics.AddProperty(Metric.ServiceName, "S3");
            metrics.IncrementCounter(Metric.AttemptCount);

            Assert.IsTrue(metrics.Timings[Metric.HttpRequestTime].Single().IsFinished);
            CollectionAssert.AreEqual(new object[] { "S3" }, metrics.Properties[Metric.ServiceName]);
            Assert.AreEqual(1L, metrics.Counters[Metric.AttemptCount]);
            StringAssert.Contains(metrics.GetErrors(), "RetryPauseTime - Trying to stop event that has not been started;");
            StringAssert.Contains(metrics.ToString(), "ServiceName = S3; ");
        }
    }
}
