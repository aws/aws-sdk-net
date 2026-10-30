using System;
using System.Collections.Generic;
using Amazon.Runtime.Telemetry;
using Amazon.Runtime.Telemetry.Metrics;
using Amazon.Runtime.Telemetry.Tracing;

namespace AWSSDK.UnitTests
{
    internal class RecordedValue
    {
        public string Name;
        public string Unit;
        public double Value;
        public Attributes Attributes;
    }

    internal class RecordingMeterProvider : MeterProvider
    {
        public List<string> Scopes { get; } = new List<string>();
        public List<RecordedValue> Records { get; } = new List<RecordedValue>();

        public override Meter GetMeter(string scope, Attributes attributes = null)
        {
            Scopes.Add(scope);
            return new RecordingMeter(this);
        }

        public void Add(string name, string unit, object value, Attributes attributes)
            => Records.Add(new RecordedValue { Name = name, Unit = unit, Value = Convert.ToDouble(value), Attributes = attributes });
    }

    internal class RecordingMeter : Meter
    {
        private readonly RecordingMeterProvider _provider;
        public RecordingMeter(RecordingMeterProvider provider) { _provider = provider; }

        public override UpDownCounter<T> CreateUpDownCounter<T>(string name, string units = null, string description = null)
            => throw new NotSupportedException();
        public override MonotonicCounter<T> CreateMonotonicCounter<T>(string name, string units = null, string description = null)
            => new RecordingCounter<T>((v, a) => _provider.Add(name, units, v, a));
        public override Histogram<T> CreateHistogram<T>(string name, string units = null, string description = null)
            => new RecordingHistogram<T>((v, a) => _provider.Add(name, units, v, a));
    }

    internal class RecordingCounter<T> : MonotonicCounter<T> where T : struct
    {
        private readonly Action<T, Attributes> _record;
        public RecordingCounter(Action<T, Attributes> record) { _record = record; }
        public override void Add(T value, Attributes attributes = null) => _record(value, attributes);
    }

    internal class RecordingHistogram<T> : Histogram<T> where T : struct
    {
        private readonly Action<T, Attributes> _record;
        public RecordingHistogram(Action<T, Attributes> record) { _record = record; }
        public override void Record(T value, Attributes attributes = null) => _record(value, attributes);
    }

    internal class RecordingTracerProvider : TracerProvider
    {
        public List<RecordingSpan> Spans { get; } = new List<RecordingSpan>();
        public override Tracer GetTracer(string scope) => new RecordingTracer(this, scope);
    }

    internal class RecordingTracer : Tracer
    {
        private readonly RecordingTracerProvider _provider;
        private readonly string _scope;
        public RecordingTracer(RecordingTracerProvider provider, string scope) { _provider = provider; _scope = scope; }

        public override TraceSpan CreateSpan(string name, Attributes initialAttributes = null, SpanKind spanKind = SpanKind.INTERNAL, SpanContext parentContext = null)
        {
            var span = new RecordingSpan(name) { Scope = _scope, Kind = spanKind, InitialAttributes = initialAttributes };
            _provider.Spans.Add(span);
            return span;
        }
    }

    internal class RecordingSpan : TraceSpan
    {
        public string Scope;
        public SpanKind Kind;
        public Attributes InitialAttributes;
        public bool Disposed;
        public Dictionary<string, object> Attributes { get; } = new Dictionary<string, object>();
        public List<Exception> Exceptions { get; } = new List<Exception>();

        public RecordingSpan(string name) { Name = name; }
        public override void EmitEvent(string name, Attributes attributes = null) { }
        public override void SetAttribute(string key, object value) => Attributes[key] = value;
        public override void SetStatus(SpanStatus status) { }
        public override void RecordException(Exception exception, Attributes attributes = null) => Exceptions.Add(exception);
        public override void End() { }
        protected override void Dispose(bool disposing) => Disposed = true;
    }
}
