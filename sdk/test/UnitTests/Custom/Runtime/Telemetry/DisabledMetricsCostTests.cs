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
    /// Disabled metrics/telemetry (LogMetrics off, NoOp providers) must not allocate on hot calls,
    /// and enabled metrics/telemetry must keep recording the same data.
    /// The allocation assertions (category <c>Allocation</c>) measure exact allocated bytes on the test thread.
    /// They are stable, but depend on runtime behavior, so they can be excluded with
    /// <c>--filter TestCategory!=Allocation</c> if a runtime update changes what the JIT or BCL allocates.
    /// </summary>
    [TestClass]
    [TestCategory("UnitTest")]
    [TestCategory("Runtime")]
    public class DisabledMetricsCostTests
    {
        private const string AllocationCategory = "Allocation";
        private const int Iterations = 100;
        private const int WarmupIterations = 1000;

        #region RequestMetrics - disabled

        [TestMethod]
        public void Disabled_StartEvent_ReturnsSharedNoOpAndTracksNothing()
        {
            var metrics = new RequestMetrics();

            var e1 = metrics.StartEvent(Metric.HttpRequestTime);
            var e2 = metrics.StartEvent(Metric.RequestSigningTime);
            Assert.AreSame(e1, e2);
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

            var timing = metrics.StopEvent(Metric.ClientExecuteTime);
            Assert.IsTrue(timing.IsFinished);
            Assert.AreEqual(0, timing.ElapsedTicks);
        }

        [TestMethod]
        public void Disabled_CollectionsAreNeverNull()
        {
            var metrics = new RequestMetrics();
            Assert.IsNotNull(metrics.Properties);
            Assert.IsNotNull(metrics.Timings);
            Assert.IsNotNull(metrics.Counters);
            Assert.AreSame(metrics.Timings, metrics.Timings);

            var replacement = new Dictionary<Metric, long> { { Metric.AttemptCount, 3 } };
            metrics.Counters = replacement;
            Assert.AreSame(replacement, metrics.Counters);
        }

        [TestMethod]
        public void Disabled_StartTimedEvent_StillMeasuresForCsm()
        {
            // CSMCallAttemptHandler reads StopEvent(CSMAttemptLatency).ElapsedTime even when LogMetrics is off.
            var metrics = new RequestMetrics();
            metrics.StartTimedEvent(Metric.CSMAttemptLatency);
            Thread.Sleep(20);
            var timing = metrics.StopEvent(Metric.CSMAttemptLatency);

            Assert.IsTrue(timing.IsFinished);
            Assert.IsTrue(timing.ElapsedTime >= TimeSpan.FromMilliseconds(10), timing.ElapsedTime.ToString());
            Assert.AreEqual(0, metrics.Timings.Count);
        }

        [TestMethod]
        public void Disabled_CsmPreInvoke_StillTimesAttemptLatency()
        {
            // CSMCallAttemptHandler.PreInvoke must use StartTimedEvent: StartEvent tracks nothing when metrics are disabled.
            var executionContext = CreateExecutionContext(new DefaultTelemetryProvider(), enableMetrics: false);
            new CsmPreInvokeHandler().CallPreInvoke(executionContext);
            Thread.Sleep(20);
            var timing = executionContext.RequestContext.Metrics.StopEvent(Metric.CSMAttemptLatency);

            Assert.IsTrue(timing.ElapsedTime >= TimeSpan.FromMilliseconds(10), timing.ElapsedTime.ToString());
        }

        [TestMethod]
        public void Disabled_CsmAttemptCapture_ReportsAttemptLatency()
        {
            // End to end through the handler's own capture: PreInvoke starts the timing, and
            // CSMCallAttemptMetricsCapture writes it to CSMCallAttempt.AttemptLatency.
            var executionContext = CreateExecutionContext(new DefaultTelemetryProvider(), enableMetrics: false);
            var requestContext = executionContext.RequestContext;
            requestContext.Request = new DefaultRequest(requestContext.OriginalRequest, "S3");
            requestContext.CSMCallEvent = new MonitoringAPICallEvent(requestContext);

            var handler = new CsmPreInvokeHandler();
            handler.CallPreInvoke(executionContext);
            Thread.Sleep(20);
            handler.CallCapture(executionContext);

            Assert.IsTrue(requestContext.CSMCallAttempt.AttemptLatency >= 10, requestContext.CSMCallAttempt.AttemptLatency.ToString());
        }

#if NETCOREAPP
        [TestMethod]
        [TestCategory(AllocationCategory)]
        public void Disabled_HotCallsDoNotAllocate()
        {
            var metrics = new RequestMetrics();
            Action hot = () =>
            {
                using (metrics.StartEvent(Metric.HttpRequestTime)) { }
                using (metrics.StartEvent(Metric.ResponseProcessingTime)) { }
                metrics.AddProperty(Metric.AsyncCall, "x");
                metrics.SetCounter(Metric.AttemptCount, 1);
                metrics.IncrementCounter(Metric.AttemptCount);
            };

            Assert.AreEqual(0L, MeasureAllocations(hot));
        }

        [TestMethod]
        [TestCategory(AllocationCategory)]
        public void Disabled_ConstructorIsSmall()
        {
            RequestMetrics metrics = null;
            long allocated = MeasureAllocations(() => metrics = new RequestMetrics(), iterations: 1);
            GC.KeepAlive(metrics);
            // Only the RequestMetrics object itself; previously a Stopwatch, a lock object,
            // and five collections were allocated here (~500 B).
            Assert.IsTrue(allocated <= 96, $"Allocated {allocated} bytes");
        }
#endif

        #endregion

        #region RequestMetrics - enabled

        [TestMethod]
        public void Enabled_RecordsTimingsPropertiesCountersAndErrors()
        {
            var metrics = new RequestMetrics { IsEnabled = true };

            using (metrics.StartEvent(Metric.HttpRequestTime))
            {
                Thread.Sleep(5);
            }
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
            Assert.IsTrue(metrics.Timings[Metric.HttpRequestTime].All(t => t.IsFinished));
            Assert.IsTrue(metrics.Timings[Metric.HttpRequestTime][0].ElapsedTime >= TimeSpan.FromMilliseconds(1));
            Assert.AreSame(executeTiming, metrics.Timings[Metric.ClientExecuteTime].Single());
            CollectionAssert.AreEqual(new object[] { false }, metrics.Properties[Metric.AsyncCall]);
            CollectionAssert.AreEqual(new object[] { "S3", "S3-again" }, metrics.Properties[Metric.ServiceName]);
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
                var root = doc.RootElement;
                Assert.AreEqual("S3-again", root.GetProperty("properties").GetProperty("ServiceName")[1].GetString());
                Assert.AreEqual(2, root.GetProperty("timings").GetProperty("HttpRequestTime").GetArrayLength());
                Assert.AreEqual(3, root.GetProperty("counters").GetProperty("AttemptCount").GetInt64());
            }
        }

        [TestMethod]
        public void Enabled_ReportsErrorsAndInFlightTimings()
        {
            var metrics = new RequestMetrics { IsEnabled = true };

            var notStarted = metrics.StopEvent(Metric.RetryPauseTime);
            Assert.IsTrue(notStarted.IsFinished);
            metrics.StartEvent(Metric.HttpRequestTime);
            metrics.StartEvent(Metric.HttpRequestTime);

            var errors = metrics.GetErrors();
            StringAssert.Contains(errors, "Timings are still in flight: HttpRequestTime.");
            StringAssert.Contains(errors, "Logged 2 metrics errors: ");
            StringAssert.Contains(errors, "RetryPauseTime - Trying to stop event that has not been started;");
            StringAssert.Contains(errors, "HttpRequestTime - Starting multiple events for the same metric;");
        }

        #endregion

        #region MetricsUtilities / TracingUtilities - NoOp providers

        [TestMethod]
        public void NoOp_ProvidersShortCircuit()
        {
            var requestContext = CreateRequestContext(new DefaultTelemetryProvider(), enableMetrics: false);

            Assert.IsNull(MetricsUtilities.MeasureDuration(requestContext, TelemetryConstants.CallDurationMetricName));
            Assert.IsNull(MetricsUtilities.MeasureDuration(requestContext.ClientConfig, TelemetryConstants.ClientUptimeMetricName));

            Assert.AreSame(TracingUtilities.NoOpSpan, TracingUtilities.CreateSpan(requestContext, "span"));
        }

#if NETCOREAPP
        [TestMethod]
        [TestCategory(AllocationCategory)]
        public void NoOp_TelemetryCallsDoNotAllocate()
        {
            var requestContext = CreateRequestContext(new DefaultTelemetryProvider(), enableMetrics: false);
            var exception = new InvalidOperationException();
            Action hot = () =>
            {
                using (MetricsUtilities.MeasureDuration(requestContext, TelemetryConstants.SerializationDurationMetricName)) { }
                using (MetricsUtilities.MeasureDuration(requestContext.ClientConfig, TelemetryConstants.ClientUptimeMetricName)) { }
                MetricsUtilities.AddMonotonicCounterValue(requestContext, TelemetryConstants.CallAttemptsMetricName, TelemetryConstants.AttemptUnitName);
                MetricsUtilities.RecordError(requestContext, exception);
                using (var span = TracingUtilities.CreateSpan(requestContext, TelemetryConstants.HTTPRequestSpanName))
                {
                    span.SetAttribute(TelemetryConstants.HTTPMethodAttributeKey, "GET");
                }
            };

            Assert.AreEqual(0L, MeasureAllocations(hot));
        }

        [TestMethod]
        [TestCategory(AllocationCategory)]
        public void NoOp_MetricsHandlerDoesNotAllocate()
        {
            var executionContext = CreateExecutionContext(new DefaultTelemetryProvider(), enableMetrics: false);
            var handler = CreateMetricsHandler();

            Assert.AreEqual(0L, MeasureAllocations(() => handler.InvokeSync(executionContext)));
        }
#endif

        #endregion

        #region MetricsUtilities / TracingUtilities / MetricsHandler - recording providers

        [TestMethod]
        public void Recording_MeasureDurationAndCountersRecordAsBefore()
        {
            var meterProvider = new RecordingMeterProvider();
            var requestContext = CreateRequestContext(new TestTelemetryProvider(meterProvider, new RecordingTracerProvider()), enableMetrics: false);

            using (MetricsUtilities.MeasureDuration(requestContext, TelemetryConstants.SerializationDurationMetricName))
            {
                Thread.Sleep(5);
            }
            MetricsUtilities.AddMonotonicCounterValue(requestContext, TelemetryConstants.CallAttemptsMetricName, TelemetryConstants.AttemptUnitName, 2);
            MetricsUtilities.RecordError(requestContext, new InvalidOperationException());

            CollectionAssert.AreEqual(new[] { "AWSSDK.S3", "AWSSDK.S3", "AWSSDK.S3" }, meterProvider.Scopes);
            Assert.AreEqual(3, meterProvider.Records.Count);

            var duration = meterProvider.Records[0];
            Assert.AreEqual(TelemetryConstants.SerializationDurationMetricName, duration.Name);
            Assert.AreEqual(TelemetryConstants.SecondsUnitName, duration.Unit);
            Assert.IsTrue((double)duration.Value > 0.001, duration.Value.ToString());
            AssertCommonAttributes(duration.Attributes, "PutObject");

            var attempts = meterProvider.Records[1];
            Assert.AreEqual(TelemetryConstants.CallAttemptsMetricName, attempts.Name);
            Assert.AreEqual(TelemetryConstants.AttemptUnitName, attempts.Unit);
            Assert.AreEqual(2L, attempts.Value);
            AssertCommonAttributes(attempts.Attributes, "PutObject");

            var errors = meterProvider.Records[2];
            Assert.AreEqual(TelemetryConstants.CallErrorsMetricName, errors.Name);
            Assert.AreEqual(1L, errors.Value);
            Assert.AreEqual("InvalidOperationException", errors.Attributes.Get(TelemetryConstants.ExceptionTypeAttributeKey));
        }

        [TestMethod]
        public void Recording_CreateSpanRecordsAsBefore()
        {
            var tracerProvider = new RecordingTracerProvider();
            var requestContext = CreateRequestContext(new TestTelemetryProvider(new RecordingMeterProvider(), tracerProvider), enableMetrics: false);

            using (TracingUtilities.CreateSpan(requestContext, TelemetryConstants.HTTPRequestSpanName)) { }

            var span = tracerProvider.Spans.Single();
            Assert.AreEqual("AWSSDK.S3", span.Scope);
            Assert.AreEqual(TelemetryConstants.HTTPRequestSpanName, span.Name);
            Assert.AreEqual(SpanKind.INTERNAL, span.Kind);
            Assert.IsTrue(span.Disposed);
            AssertCommonAttributes(span.Attributes, "PutObject");
        }

        [TestMethod]
        public void Recording_OnlyTracerCustom_MetricsStillShortCircuit()
        {
            var tracerProvider = new RecordingTracerProvider();
            var telemetry = new DefaultTelemetryProvider();
            telemetry.RegisterTracerProvider(tracerProvider);
            var requestContext = CreateRequestContext(telemetry, enableMetrics: false);

            Assert.IsNull(MetricsUtilities.MeasureDuration(requestContext, TelemetryConstants.CallDurationMetricName));
            using (TracingUtilities.CreateSpan(requestContext, "span")) { }
            Assert.AreEqual(1, tracerProvider.Spans.Count);
        }

        [TestMethod]
        public void Recording_MetricsHandlerSync_RecordsSpanHistogramAndRequestMetrics()
        {
            var meterProvider = new RecordingMeterProvider();
            var tracerProvider = new RecordingTracerProvider();
            var executionContext = CreateExecutionContext(new TestTelemetryProvider(meterProvider, tracerProvider), enableMetrics: true);

            CreateMetricsHandler().InvokeSync(executionContext);

            AssertMetricsHandlerResults(executionContext, meterProvider, tracerProvider, async: false);
        }

        [TestMethod]
        public async Task Recording_MetricsHandlerAsync_RecordsSpanHistogramAndRequestMetrics()
        {
            var meterProvider = new RecordingMeterProvider();
            var tracerProvider = new RecordingTracerProvider();
            var executionContext = CreateExecutionContext(new TestTelemetryProvider(meterProvider, tracerProvider), enableMetrics: true);

            await CreateMetricsHandler().InvokeAsync<AmazonWebServiceResponse>(executionContext);

            AssertMetricsHandlerResults(executionContext, meterProvider, tracerProvider, async: true);
        }

        [TestMethod]
        public void Recording_MetricsHandlerError_RecordsExceptionAndErrorCounter()
        {
            var meterProvider = new RecordingMeterProvider();
            var tracerProvider = new RecordingTracerProvider();
            var executionContext = CreateExecutionContext(new TestTelemetryProvider(meterProvider, tracerProvider), enableMetrics: true);
            var handler = CreateMetricsHandler(new InvalidOperationException("boom"));

            Assert.ThrowsExactly<InvalidOperationException>(() => handler.InvokeSync(executionContext));

            var span = tracerProvider.Spans.Single();
            Assert.AreEqual("S3.PutObject", span.Name);
            Assert.AreEqual(1, span.Exceptions.Count);
            Assert.AreEqual(typeof(InvalidOperationException).ToString(), span.SetAttributes[TelemetryConstants.ExceptionTypeAttributeKey]);
            Assert.IsTrue(span.Disposed);
            Assert.IsTrue(meterProvider.Records.Any(r => r.Name == TelemetryConstants.CallErrorsMetricName));
            Assert.IsTrue(meterProvider.Records.Any(r => r.Name == TelemetryConstants.CallDurationMetricName));
            Assert.AreEqual(1, executionContext.RequestContext.Metrics.Timings[Metric.ClientExecuteTime].Count);
        }

        #endregion

        #region Helpers

        private static void AssertMetricsHandlerResults(IExecutionContext executionContext,
            RecordingMeterProvider meterProvider, RecordingTracerProvider tracerProvider, bool async)
        {
            var span = tracerProvider.Spans.Single();
            Assert.AreEqual("AWSSDK.S3", span.Scope);
            Assert.AreEqual("S3.PutObject", span.Name);
            Assert.AreEqual(SpanKind.CLIENT, span.Kind);
            Assert.AreEqual("request-id-1", span.SetAttributes[TelemetryConstants.RequestIdAttributeKey]);
            Assert.IsTrue(span.Disposed);
            AssertCommonAttributes(span.Attributes, "PutObject");

            var duration = meterProvider.Records.Single();
            Assert.AreEqual(TelemetryConstants.CallDurationMetricName, duration.Name);
            Assert.AreEqual(TelemetryConstants.SecondsUnitName, duration.Unit);
            AssertCommonAttributes(duration.Attributes, "PutObject");

            var metrics = executionContext.RequestContext.Metrics;
            CollectionAssert.AreEqual(new object[] { async }, metrics.Properties[Metric.AsyncCall]);
            var executeTime = metrics.Timings[Metric.ClientExecuteTime].Single();
            Assert.IsTrue(executeTime.IsFinished);
            Assert.AreEqual(string.Empty, metrics.GetErrors());
        }

        private static void AssertCommonAttributes(Attributes attributes, string operation)
        {
            Assert.AreEqual(operation, attributes.Get(TelemetryConstants.MethodAttributeKey));
            Assert.AreEqual("S3", attributes.Get(TelemetryConstants.ServiceAttributeKey));
            Assert.AreEqual(TelemetryConstants.SystemAttributeValue, attributes.Get(TelemetryConstants.SystemAttributeKey));
        }

#if NETCOREAPP
        private static long MeasureAllocations(Action action, int iterations = Iterations)
        {
            // Warm up so JIT and static initialization are excluded. One call is not enough on netcoreapp3.1:
            // its tiered JIT allocates on the calling thread while call counting promotes hot methods.
            if (iterations > 1)
            {
                for (int i = 0; i < WarmupIterations; i++)
                    action();
            }

            long before = GC.GetAllocatedBytesForCurrentThread();
            for (int i = 0; i < iterations; i++)
                action();
            return GC.GetAllocatedBytesForCurrentThread() - before;
        }
#endif

        private static MetricsHandler CreateMetricsHandler(Exception toThrow = null)
        {
            return new MetricsHandler
            {
                InnerHandler = new ResponseHandler(toThrow),
                Logger = Logger.GetLogger(typeof(DisabledMetricsCostTests))
            };
        }

        private static RequestContext CreateRequestContext(TelemetryProvider telemetryProvider, bool enableMetrics)
        {
            var config = new AmazonS3Config { TelemetryProvider = telemetryProvider, LogMetrics = enableMetrics };
            return new RequestContext(enableMetrics)
            {
                ClientConfig = config,
                OriginalRequest = new PutObjectRequest(),
                ServiceMetaData = new TestServiceMetadata(),
            };
        }

        private static IExecutionContext CreateExecutionContext(TelemetryProvider telemetryProvider, bool enableMetrics)
        {
            return new Amazon.Runtime.Internal.ExecutionContext(
                CreateRequestContext(telemetryProvider, enableMetrics), new ResponseContext());
        }

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

        private class CsmPreInvokeHandler : CSMCallAttemptHandler
        {
            public void CallPreInvoke(IExecutionContext executionContext) => PreInvoke(executionContext);
            public void CallCapture(IExecutionContext executionContext)
                => CSMCallAttemptMetricsCapture(executionContext.RequestContext, executionContext.ResponseContext);
        }

        private class TestServiceMetadata : IServiceMetadata
        {
            public string ServiceId => "S3";
            public IDictionary<string, string> OperationNameMapping { get; } = new Dictionary<string, string>();
        }

        private class TestTelemetryProvider : TelemetryProvider
        {
            public TestTelemetryProvider(MeterProvider meterProvider, TracerProvider tracerProvider)
                : base(meterProvider, tracerProvider) { }
        }

        private class RecordedValue
        {
            public string Name;
            public string Unit;
            public object Value;
            public Attributes Attributes;
        }

        private class RecordingMeterProvider : MeterProvider
        {
            public List<string> Scopes { get; } = new List<string>();
            public List<RecordedValue> Records { get; } = new List<RecordedValue>();

            public override Meter GetMeter(string scope, Attributes attributes = null)
            {
                Scopes.Add(scope);
                return new RecordingMeter(this);
            }
        }

        private class RecordingMeter : Meter
        {
            private readonly RecordingMeterProvider _provider;
            public RecordingMeter(RecordingMeterProvider provider) { _provider = provider; }

            public override UpDownCounter<T> CreateUpDownCounter<T>(string name, string units = null, string description = null)
                => throw new NotSupportedException();

            public override MonotonicCounter<T> CreateMonotonicCounter<T>(string name, string units = null, string description = null)
                => new RecordingCounter<T>(_provider, name, units);

            public override Histogram<T> CreateHistogram<T>(string name, string units = null, string description = null)
                => new RecordingHistogram<T>(_provider, name, units);
        }

        private class RecordingCounter<T> : MonotonicCounter<T> where T : struct
        {
            private readonly RecordingMeterProvider _provider;
            private readonly string _name, _unit;
            public RecordingCounter(RecordingMeterProvider provider, string name, string unit) { _provider = provider; _name = name; _unit = unit; }

            public override void Add(T value, Attributes attributes = null)
                => _provider.Records.Add(new RecordedValue { Name = _name, Unit = _unit, Value = value, Attributes = attributes });
        }

        private class RecordingHistogram<T> : Histogram<T> where T : struct
        {
            private readonly RecordingMeterProvider _provider;
            private readonly string _name, _unit;
            public RecordingHistogram(RecordingMeterProvider provider, string name, string unit) { _provider = provider; _name = name; _unit = unit; }

            public override void Record(T value, Attributes attributes = null)
                => _provider.Records.Add(new RecordedValue { Name = _name, Unit = _unit, Value = value, Attributes = attributes });
        }

        private class RecordingTracerProvider : TracerProvider
        {
            public List<RecordingSpan> Spans { get; } = new List<RecordingSpan>();

            public override Tracer GetTracer(string scope) => new RecordingTracer(this, scope);
        }

        private class RecordingTracer : Tracer
        {
            private readonly RecordingTracerProvider _provider;
            private readonly string _scope;
            public RecordingTracer(RecordingTracerProvider provider, string scope) { _provider = provider; _scope = scope; }

            public override TraceSpan CreateSpan(string name, Attributes initialAttributes = null, SpanKind spanKind = SpanKind.INTERNAL, SpanContext parentContext = null)
            {
                var span = new RecordingSpan(name, _scope, spanKind, initialAttributes);
                _provider.Spans.Add(span);
                return span;
            }
        }

        private class RecordingSpan : TraceSpan
        {
            public string Scope { get; }
            public SpanKind Kind { get; }
            public Attributes Attributes { get; }
            public Dictionary<string, object> SetAttributes { get; } = new Dictionary<string, object>();
            public List<Exception> Exceptions { get; } = new List<Exception>();
            public bool Disposed { get; private set; }

            public RecordingSpan(string name, string scope, SpanKind kind, Attributes attributes)
            {
                Name = name;
                Scope = scope;
                Kind = kind;
                Attributes = attributes;
            }

            public override void EmitEvent(string name, Attributes attributes = null) { }
            public override void SetAttribute(string key, object value) => SetAttributes[key] = value;
            public override void SetStatus(SpanStatus status) { }
            public override void RecordException(Exception exception, Attributes attributes = null) => Exceptions.Add(exception);
            public override void End() { }
            protected override void Dispose(bool disposing) => Disposed = true;
        }

        #endregion
    }
}
