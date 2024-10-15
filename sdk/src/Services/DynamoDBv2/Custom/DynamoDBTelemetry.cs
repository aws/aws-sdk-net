using System;
using Amazon.Runtime.Telemetry;
using Amazon.Runtime.Telemetry.Tracing;
using Attributes = Amazon.Runtime.Telemetry.Attributes;

namespace Amazon.DynamoDBv2
{
    internal static class DynamoDBTelemetry
    {
        private static string DynamoDBTracerScope = $"{TelemetryConstants.TelemetryScopePrefix}.DynamoDBv2";

        internal static string ExtractOperationName(string className, string methodName)
        {
            if (methodName.EndsWith("Async", StringComparison.Ordinal))
                methodName = methodName.Substring(0, methodName.Length - 5);
            return $"{className}.{methodName}";
        }

        internal static TraceSpan CreateSpan(
            TracerProvider tracerProvider,
            string operationName,
            Attributes initialAttributes = null,
            SpanKind spanKind = SpanKind.INTERNAL,
            SpanContext parentContext = null)
        {
            if (initialAttributes == null)
                initialAttributes = new Attributes();

            initialAttributes.Set(TelemetryConstants.MethodAttributeKey, operationName);
            initialAttributes.Set(TelemetryConstants.SystemAttributeKey, TelemetryConstants.SystemAttributeValue);
            initialAttributes.Set(TelemetryConstants.ServiceAttributeKey, DynamoDBTracerScope);

            var tracer = tracerProvider.GetTracer(DynamoDBTracerScope);
            return tracer.CreateSpan(operationName, initialAttributes, spanKind, parentContext);
        }
    }
}
