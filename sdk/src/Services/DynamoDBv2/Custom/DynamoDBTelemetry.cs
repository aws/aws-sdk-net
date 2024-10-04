using Amazon.Runtime.Telemetry;

namespace AWSSDK.DynamoDBv2
{
    internal static class DynamoDBTelemetry
    {
        internal static string DynamoDBTracerScope = $"{TelemetryConstants.TelemetryScopePrefix}.DynamoDBv2";
    }
}
