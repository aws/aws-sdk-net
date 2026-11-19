using System;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Telemetry;
using Amazon.Runtime.Telemetry.Metrics;
using Amazon.Runtime.Telemetry.Metrics.NoOp;
using Amazon.Runtime.Telemetry.Tracing;
using Amazon.Runtime.Telemetry.Tracing.NoOp;
using Amazon.S3;
using Amazon.S3.Model;
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

        [TestMethod]
        public void RecordError_CustomProvider_RecordsError()
        {
            var meterProvider = new CustomMeterProvider();
            var config = new AmazonS3Config { TelemetryProvider = new DefaultTelemetryProvider() };
            config.TelemetryProvider.RegisterMeterProvider(meterProvider);

            MetricsUtilities.RecordError(CreateRequestContext(config), new InvalidOperationException());

            Assert.AreEqual(1, meterProvider.GetMeterCalls);
        }

        [TestMethod]
        public void CreateSpan_DefaultNoOpProvider_ReturnsSharedNoOpSpan()
        {
            var config = new AmazonS3Config { TelemetryProvider = new DefaultTelemetryProvider() };
            Assert.AreSame(TracingUtilities.NoOpSpan, TracingUtilities.CreateSpan(CreateRequestContext(config), "span"));
        }

        [TestMethod]
        public void CreateSpan_CustomProvider_CreatesSpan()
        {
            var config = new AmazonS3Config { TelemetryProvider = new DefaultTelemetryProvider() };
            config.TelemetryProvider.RegisterTracerProvider(new CustomTracerProvider());
            Assert.AreNotSame(TracingUtilities.NoOpSpan, TracingUtilities.CreateSpan(CreateRequestContext(config), "span"));
        }

        private static RequestContext CreateRequestContext(AmazonS3Config config)
            => new RequestContext(false) { ClientConfig = config, OriginalRequest = new PutObjectRequest() };

        private class CustomMeterProvider : MeterProvider
        {
            public int GetMeterCalls { get; private set; }

            public override Meter GetMeter(string scope, Attributes attributes = null)
            {
                GetMeterCalls++;
                return new NoOpMeter();
            }
        }

        private class CustomTracerProvider : TracerProvider
        {
            public override Tracer GetTracer(string scope) => new NoOpTracer();
        }
    }
}
