using Amazon.Runtime;
using Amazon.Runtime.Telemetry;
using Amazon.Runtime.Telemetry.Metrics;
using Amazon.Runtime.Telemetry.Metrics.NoOp;
using Amazon.S3;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AWSSDK.UnitTests
{
    [TestClass]
    [TestCategory("Core")]
    public class MetricsUtilitiesTests
    {
        [TestMethod]
        public void MeasureDuration_DefaultNoOpProvider_ReturnsNull()
        {
            Assert.IsNull(MetricsUtilities.MeasureDuration(new AmazonS3Config(), TelemetryConstants.CallDurationMetricName));
        }

        [TestMethod]
        public void MeasureDuration_CustomProvider_ReturnsMeasurer()
        {
            // Own TelemetryProvider so the process-wide AWSConfigs.TelemetryProvider is never touched.
            var config = new AmazonS3Config { TelemetryProvider = new DefaultTelemetryProvider() };
            config.TelemetryProvider.RegisterMeterProvider(new CustomMeterProvider());
            Assert.IsNotNull(MetricsUtilities.MeasureDuration(config, TelemetryConstants.CallDurationMetricName));
        }

        private class CustomMeterProvider : MeterProvider
        {
            public override Meter GetMeter(string scope, Attributes attributes = null) => new NoOpMeter();
        }
    }
}
