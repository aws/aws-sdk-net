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

namespace Amazon.Runtime.Telemetry
{
    /// <summary>
    /// Contains constants used for telemetry within the SDK.
    /// </summary>
    public static class TelemetryConstants
    {
        /// <summary>
        /// The prefix used for telemetry scopes within the SDK.
        /// </summary>
        public const string TelemetryScopePrefix = "AWSSDK";

        public const string HTTPRequestSpanName = "HttpRequest";
        public const string RequestCompressionSpanName = "RequestCompression";
        public const string CredentialsRetrievalSpanName = "CredentialsRetrieval";

        public const string SystemAttributeKey = "rpc.system";
        public const string SystemAttributeValue = "aws-api";
        public const string MethodAttributeKey = "rpc.method";
        public const string ServiceAttributeKey = "rpc.service";

        public const string RequestIdAttributeKey = "aws.request_id";

        public const string HTTPStatusCodeAttributeKey = "http.status_code";
        public const string HTTPRequestContentLengthAttributeKey = "http.request_content_length";
        public const string HTTPResponseContentLengthAttributeKey = "http.response_content_length";
        public const string HTTPMethodAttributeKey = "http.method";
        public const string ServerAddressAttributeKey = "server.address";

        public const string ExceptionMessageAttributeKey = "exception.message";
        public const string ExceptionStackTraceAttributeKey = "exception.stacktrace";
        public const string ExceptionTypeAttributeKey = "exception.type";
        public const string ErrorAttributeKey = "error";
        public const string AWSErrorCodeAttributeKey = "aws.error_code";

        public const string CallDurationMetricName = "client.call.duration";
        public const string ClientUptimeMetricName = "client.uptime";
        public const string CallAttemptsMetricName = "client.call.attempts";
        public const string CallErrorsMetricName = "client.call.errors";
        public const string CallAttemptDurationMetricName = "client.call.attempt_duration";

        public const string ResolveEndpointDurationMetricName = "client.call.resolve_endpoint_duration";
        public const string SerializationDurationMetricName = "client.call.serialization_duration";
        public const string DeserializationDurationMetricName = "client.call.deserialization_duration";
        public const string AuthSigningDurationMetricName = "client.call.auth.signing_duration";
        public const string ResolveIdentityDurationMetricName = "client.call.auth.resolve_identity_duration";

        public const string HTTPBytesSentMetricName = "client.http.bytes_sent";
        public const string HTTPBytesReceivedMetricName = "client.http.bytes_received";

        public const string AttemptUnitName = "{attempt}";
        public const string ErrorUnitName = "{error}";
        public const string BytesUnitName = "By";
        public const string SecondsUnitName = "s";
    }
}