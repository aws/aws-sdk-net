/*
 * Copyright Amazon.com, Inc. or its affiliates. All Rights Reserved.
 *
 * Licensed under the Apache License, Version 2.0 (the "License").
 * You may not use this file except in compliance with the License.
 * A copy of the License is located at
 *
 *  http://aws.amazon.com/apache2.0
 *
 * or in the "license" file accompanying this file. This file is distributed
 * on an "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either
 * express or implied. See the License for the specific language governing
 * permissions and limitations under the License.
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json;
using System.Threading;
using System.Threading.Tasks;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Util;
using Amazon.Runtime.Telemetry;
using Amazon.Runtime.Telemetry.Metrics;
using Amazon.Runtime.Telemetry.Tracing;
using Amazon.S3;
using Amazon.S3.Model;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AWSSDK.UnitTests
{
    /// <summary>
    /// The "Allocation" tests assert exact allocated bytes; exclude them with
    /// <c>TestCategory!=Allocation</c> if a runtime update changes what the JIT or BCL allocates.
    /// </summary>
    [TestClass]
    [TestCategory("UnitTest")]
    [TestCategory("Runtime")]
    public class DisabledMetricsCostTests
    {
        private const string Allocation = "Allocation";

        [TestMethod]
        public void Disabled_TracksNothing()
        {
            var metrics = new RequestMetrics();

            var e1 = metrics.StartEvent(Metric.HttpRequestTime);
            Assert.AreSame(e1, metrics.StartEvent(Metric.RequestSigningTime));
            e1.Dispose();
            e1.Dispose();
            metrics.AddProperty(Metric.AsyncCall, true);
            metrics.SetCounter(Metric.AttemptCount, 1);
            metrics.IncrementCounter(Metric.AttemptCount);

            Assert.AreEqual(0, metrics.Timings.Count);
            Assert.AreEqual(0, metrics.Properties.Count);
            Assert.AreEqual(0, metrics.Counters.Count);
            Assert.AreEqual(string.Empty, metrics.GetErrors());
            Assert.AreEqual("Metrics logging disabled", metrics.ToString());
            Assert.AreEqual("{ }", metrics.ToJSON());
            Assert.AreEqual(0, metrics.StopEvent(Metric.ClientExecuteTime).ElapsedTicks);

            var counters = new Dictionary<Metric, long>();
            metrics.Counters = counters;
            Assert.AreSame(counters, metrics.Counters);
        }

        [TestMethod]
        public void Disabled_CsmAttemptLatencyIsStillMeasured()
        {
            var context = CreateExecutionContext(new DefaultTelemetryProvider(), enableMetrics: false);
            context.RequestContext.Request = new DefaultRequest(context.RequestContext.OriginalRequest, "S3");
            context.RequestContext.CSMCallEvent = new MonitoringAPICallEvent(context.RequestContext);
            var handler = new TestCsmHandler();

            handler.CallPreInvoke(context);
            Thread.Sleep(20);
            handler.CallCapture(context);

            Assert.IsTrue(context.RequestContext.CSMCallAttempt.AttemptLatency >= 10);
            Assert.AreEqual(0, context.RequestContext.Metrics.Timings.Count);
        }

        [TestMethod]
        public void Enabled_RecordsAsBefore()
        {
            var metrics = new RequestMetrics { IsEnabled = true };

            using (metrics.StartEvent(Metric.HttpRequestTime)) { Thread.Sleep(5); }
            using (metrics.StartEvent(Metric.HttpRequestTime)) { }
            metrics.StartTimedEvent(Metric.ClientExecuteTime);
            var executeTiming = metrics.StopEvent(Metric.ClientExecuteTime);
            metrics.AddProperty(Metric.AsyncCall, false);
            metrics.AddProperty(Metric.ServiceName, "S3");
            metrics.AddProperty(Metric.ServiceName, "S3-again");
            metrics.SetCounter(Metric.AttemptCount, 2);
            metrics.IncrementCounter(Metric.AttemptCount);
            metrics.IncrementCounter(Metric.BytesProcessed);

            Assert.AreEqual(2, metrics.Timings[Metric.HttpRequestTime].Count);
            Assert.IsTrue(metrics.Timings[Metric.HttpRequestTime][0].ElapsedTime >= TimeSpan.FromMilliseconds(1));
            Assert.AreSame(executeTiming, metrics.Timings[Metric.ClientExecuteTime].Single());
            CollectionAssert.AreEqual(new object[] { "S3", "S3-again" }, metrics.Properties[Metric.ServiceName]);
            CollectionAssert.AreEqual(new object[] { false }, metrics.Properties[Metric.AsyncCall]);
            Assert.AreEqual(3L, metrics.Counters[Metric.AttemptCount]);
            Assert.AreEqual(1L, metrics.Counters[Metric.BytesProcessed]);
            Assert.AreEqual(string.Empty, metrics.GetErrors());

            var text = metrics.ToString();
            StringAssert.Contains(text, "AsyncCall = False; ");
            StringAssert.Contains(text, "ServiceName = S3, S3-again; ");
            StringAssert.Contains(text, "HttpRequestTime = ");
            StringAssert.Contains(text, "ClientExecuteTime = ");
            StringAssert.Contains(text, "AttemptCount = 3; ");

            using (var doc = JsonDocument.Parse(metrics.ToJSON()))
            {
                Assert.AreEqual("S3-again", doc.RootElement.GetProperty("properties").GetProperty("ServiceName")[1].GetString());
                Assert.AreEqual(2, doc.RootElement.GetProperty("timings").GetProperty("HttpRequestTime").GetArrayLength());
                Assert.AreEqual(3, doc.RootElement.GetProperty("counters").GetProperty("AttemptCount").GetInt64());
            }
        }

        [TestMethod]
        public void Enabled_ReportsErrorsAndInFlightTimings()
        {
            var metrics = new RequestMetrics { IsEnabled = true };

            metrics.StopEvent(Metric.RetryPauseTime);
            metrics.StartEvent(Metric.HttpRequestTime);
            metrics.StartEvent(Metric.HttpRequestTime);

            var errors = metrics.GetErrors();
            StringAssert.Contains(errors, "Timings are still in flight: HttpRequestTime.");
            StringAssert.Contains(errors, "Logged 2 metrics errors: ");
            StringAssert.Contains(errors, "RetryPauseTime - Trying to stop event that has not been started;");
            StringAssert.Contains(errors, "HttpRequestTime - Starting multiple events for the same metric;");
        }

        [TestMethod]
        public void NoOpProviders_ShortCircuit()
        {
            var requestContext = CreateRequestContext(new DefaultTelemetryProvider(), enableMetrics: false);

            Assert.IsNull(MetricsUtilities.MeasureDuration(requestContext, TelemetryConstants.CallDurationMetricName));
            Assert.AreSame(TracingUtilities.NoOpSpan, TracingUtilities.CreateSpan(requestContext, "span"));
        }

        [TestMethod]
        public void CustomProviders_RecordAsBefore()
        {
            var meter = new RecordingMeterProvider();
            var tracer = new RecordingTracerProvider();
            var requestContext = CreateRequestContext(Telemetry(meter, tracer), enableMetrics: false);

            using (MetricsUtilities.MeasureDuration(requestContext, TelemetryConstants.SerializationDurationMetricName)) { Thread.Sleep(5); }
            MetricsUtilities.AddMonotonicCounterValue(requestContext, TelemetryConstants.CallAttemptsMetricName, TelemetryConstants.AttemptUnitName, 2);
            MetricsUtilities.RecordError(requestContext, new InvalidOperationException());
            using (TracingUtilities.CreateSpan(requestContext, TelemetryConstants.HTTPRequestSpanName)) { }

            CollectionAssert.AreEqual(
                new[] { TelemetryConstants.SerializationDurationMetricName, TelemetryConstants.CallAttemptsMetricName, TelemetryConstants.CallErrorsMetricName },
                meter.Records.Select(r => r.Name).ToArray());
            CollectionAssert.AreEqual(new[] { "AWSSDK.S3", "AWSSDK.S3", "AWSSDK.S3" }, meter.Scopes);
            Assert.IsTrue(meter.Records[0].Value > 0.001);
            Assert.AreEqual(TelemetryConstants.SecondsUnitName, meter.Records[0].Unit);
            Assert.AreEqual(2.0, meter.Records[1].Value);
            Assert.AreEqual("InvalidOperationException", meter.Records[2].Attributes.Get(TelemetryConstants.ExceptionTypeAttributeKey));
            AssertCommonAttributes(meter.Records[0].Attributes);
            AssertCommonAttributes(meter.Records[1].Attributes);

            var span = tracer.Spans.Single();
            Assert.AreEqual("AWSSDK.S3", span.Scope);
            Assert.AreEqual(TelemetryConstants.HTTPRequestSpanName, span.Name);
            Assert.AreEqual(SpanKind.INTERNAL, span.Kind);
            Assert.IsTrue(span.Disposed);
            AssertCommonAttributes(span.InitialAttributes);
        }

        [TestMethod]
        public void CustomTracerOnly_MetricsStillShortCircuit()
        {
            var tracer = new RecordingTracerProvider();
            var requestContext = CreateRequestContext(Telemetry(tracer: tracer), enableMetrics: false);

            Assert.IsNull(MetricsUtilities.MeasureDuration(requestContext, TelemetryConstants.CallDurationMetricName));
            using (TracingUtilities.CreateSpan(requestContext, "span")) { }
            Assert.AreEqual(1, tracer.Spans.Count);
        }

        [TestMethod]
        [DataRow(false)]
        [DataRow(true)]
        public async Task MetricsHandler_CustomProviders_RecordsSpanHistogramAndRequestMetrics(bool async)
        {
            var meter = new RecordingMeterProvider();
            var tracer = new RecordingTracerProvider();
            var context = CreateExecutionContext(Telemetry(meter, tracer), enableMetrics: true);

            if (async)
                await CreateMetricsHandler().InvokeAsync<AmazonWebServiceResponse>(context);
            else
                CreateMetricsHandler().InvokeSync(context);

            var span = tracer.Spans.Single();
            Assert.AreEqual("S3.PutObject", span.Name);
            Assert.AreEqual(SpanKind.CLIENT, span.Kind);
            Assert.AreEqual("request-id-1", span.Attributes[TelemetryConstants.RequestIdAttributeKey]);
            Assert.IsTrue(span.Disposed);
            AssertCommonAttributes(span.InitialAttributes);
            Assert.AreEqual(TelemetryConstants.CallDurationMetricName, meter.Records.Single().Name);
            AssertCommonAttributes(meter.Records.Single().Attributes);

            var metrics = context.RequestContext.Metrics;
            CollectionAssert.AreEqual(new object[] { async }, metrics.Properties[Metric.AsyncCall]);
            Assert.IsTrue(metrics.Timings[Metric.ClientExecuteTime].Single().IsFinished);
            Assert.AreEqual(string.Empty, metrics.GetErrors());
        }

        [TestMethod]
        public void MetricsHandler_Error_RecordsExceptionAndErrorCounter()
        {
            var meter = new RecordingMeterProvider();
            var tracer = new RecordingTracerProvider();
            var context = CreateExecutionContext(Telemetry(meter, tracer), enableMetrics: true);

            Assert.ThrowsExactly<InvalidOperationException>(() => CreateMetricsHandler(new InvalidOperationException()).InvokeSync(context));

            var span = tracer.Spans.Single();
            Assert.AreEqual(1, span.Exceptions.Count);
            Assert.AreEqual(typeof(InvalidOperationException).ToString(), span.Attributes[TelemetryConstants.ExceptionTypeAttributeKey]);
            Assert.IsTrue(span.Disposed);
            Assert.IsTrue(meter.Records.Any(r => r.Name == TelemetryConstants.CallErrorsMetricName));
            Assert.IsTrue(meter.Records.Any(r => r.Name == TelemetryConstants.CallDurationMetricName));
            Assert.AreEqual(1, context.RequestContext.Metrics.Timings[Metric.ClientExecuteTime].Count);
        }

#if NETCOREAPP
        [TestMethod]
        [TestCategory(Allocation)]
        public void Disabled_HotCallsDoNotAllocate()
        {
            var metrics = new RequestMetrics();
            Assert.AreEqual(0L, MeasureAllocations(() =>
            {
                using (metrics.StartEvent(Metric.HttpRequestTime)) { }
                metrics.AddProperty(Metric.AsyncCall, "x");
                metrics.SetCounter(Metric.AttemptCount, 1);
                metrics.IncrementCounter(Metric.AttemptCount);
            }));
        }

        [TestMethod]
        [TestCategory(Allocation)]
        public void Disabled_ConstructorAllocatesOnlyItself()
        {
            RequestMetrics metrics = null;
            long allocated = MeasureAllocations(() => metrics = new RequestMetrics(), iterations: 1);
            GC.KeepAlive(metrics);
            Assert.IsTrue(allocated <= 96, $"Allocated {allocated} bytes");
        }

        [TestMethod]
        [TestCategory(Allocation)]
        public void NoOpProviders_TelemetryCallsDoNotAllocate()
        {
            var requestContext = CreateRequestContext(new DefaultTelemetryProvider(), enableMetrics: false);
            var exception = new InvalidOperationException();
            Assert.AreEqual(0L, MeasureAllocations(() =>
            {
                using (MetricsUtilities.MeasureDuration(requestContext, TelemetryConstants.SerializationDurationMetricName)) { }
                MetricsUtilities.AddMonotonicCounterValue(requestContext, TelemetryConstants.CallAttemptsMetricName, TelemetryConstants.AttemptUnitName);
                MetricsUtilities.RecordError(requestContext, exception);
                using (var span = TracingUtilities.CreateSpan(requestContext, TelemetryConstants.HTTPRequestSpanName))
                {
                    span.SetAttribute(TelemetryConstants.HTTPMethodAttributeKey, "GET");
                }
            }));
        }

        [TestMethod]
        [TestCategory(Allocation)]
        public void NoOpProviders_MetricsHandlerDoesNotAllocate()
        {
            var context = CreateExecutionContext(new DefaultTelemetryProvider(), enableMetrics: false);
            var handler = CreateMetricsHandler();
            Assert.AreEqual(0L, MeasureAllocations(() => handler.InvokeSync(context)));
        }

        private static long MeasureAllocations(Action action, int iterations = 100)
        {
            // One warm-up call isn't enough: tiered JIT can allocate on the calling thread while promoting hot methods.
            for (int i = 0; iterations > 1 && i < 1000; i++)
                action();

            long before = GC.GetAllocatedBytesForCurrentThread();
            for (int i = 0; i < iterations; i++)
                action();
            return GC.GetAllocatedBytesForCurrentThread() - before;
        }
#endif

        private static void AssertCommonAttributes(Attributes attributes)
        {
            Assert.AreEqual("PutObject", attributes.Get(TelemetryConstants.MethodAttributeKey));
            Assert.AreEqual("S3", attributes.Get(TelemetryConstants.ServiceAttributeKey));
            Assert.AreEqual(TelemetryConstants.SystemAttributeValue, attributes.Get(TelemetryConstants.SystemAttributeKey));
        }

        private static TelemetryProvider Telemetry(MeterProvider meter = null, TracerProvider tracer = null)
        {
            var telemetry = new DefaultTelemetryProvider();
            if (meter != null)
                telemetry.RegisterMeterProvider(meter);
            if (tracer != null)
                telemetry.RegisterTracerProvider(tracer);
            return telemetry;
        }

        private static RequestContext CreateRequestContext(TelemetryProvider telemetryProvider, bool enableMetrics)
        {
            return new RequestContext(enableMetrics)
            {
                ClientConfig = new AmazonS3Config { TelemetryProvider = telemetryProvider, LogMetrics = enableMetrics },
                OriginalRequest = new PutObjectRequest(),
                ServiceMetaData = new TestServiceMetadata(),
            };
        }

        private static IExecutionContext CreateExecutionContext(TelemetryProvider telemetryProvider, bool enableMetrics)
            => new Amazon.Runtime.Internal.ExecutionContext(CreateRequestContext(telemetryProvider, enableMetrics), new ResponseContext());

        private static MetricsHandler CreateMetricsHandler(Exception toThrow = null)
            => new MetricsHandler { InnerHandler = new ResponseHandler(toThrow), Logger = Logger.GetLogger(typeof(DisabledMetricsCostTests)) };

        private class ResponseHandler : PipelineHandler
        {
            private readonly Exception _toThrow;
            private readonly AmazonWebServiceResponse _response = new AmazonWebServiceResponse
            {
                ResponseMetadata = new ResponseMetadata { RequestId = "request-id-1" }
            };

            public ResponseHandler(Exception toThrow) { _toThrow = toThrow; }

            public override void InvokeSync(IExecutionContext executionContext)
            {
                if (_toThrow != null)
                    throw _toThrow;
                executionContext.ResponseContext.Response = _response;
            }

            public override Task<T> InvokeAsync<T>(IExecutionContext executionContext)
            {
                InvokeSync(executionContext);
                return Task.FromResult(new T());
            }
        }

        private class TestCsmHandler : CSMCallAttemptHandler
        {
            public void CallPreInvoke(IExecutionContext context) => PreInvoke(context);
            public void CallCapture(IExecutionContext context) => CSMCallAttemptMetricsCapture(context.RequestContext, context.ResponseContext);
        }

        private class TestServiceMetadata : IServiceMetadata
        {
            public string ServiceId => "S3";
            public IDictionary<string, string> OperationNameMapping { get; } = new Dictionary<string, string>();
        }
    }
}
