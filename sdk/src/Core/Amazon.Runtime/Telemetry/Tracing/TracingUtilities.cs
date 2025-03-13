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
using Amazon.Util;

namespace Amazon.Runtime.Telemetry.Tracing
{
    /// <summary>
    /// Utility class for tracing related operations.
    /// </summary>
    internal static class TracingUtilities
    {
        /// <summary>
        /// Creates a new span from the requestContext using the span details.
        /// </summary>
        /// <param name="requestContext">The request context containing the tracer provider and service details.</param>
        /// <param name="spanName">The name of the span.</param>
        /// <param name="initialAttributes">Optional initial set of attributes for the span.</param>
        /// <param name="spanKind">Optional type of span to create.</param>
        /// <param name="parentContext">Optional parent context for the span.</param>
        /// <returns>A <see cref="TraceSpan"/> instance representing the created span.</returns>
        public static TraceSpan CreateSpan(
            IRequestContext requestContext,
            string spanName,
            Attributes initialAttributes = null,
            SpanKind spanKind = SpanKind.INTERNAL,
            SpanContext parentContext = null)
        {
            var serviceId = requestContext.ClientConfig.ServiceId;

            if (initialAttributes == null)
                initialAttributes = new Attributes();

            // Add common attributes
            var operationName = AWSSDKUtils.ExtractOperationName(requestContext.RequestName);
            initialAttributes.Set(TelemetryConstants.MethodAttributeKey, operationName);

            initialAttributes.Set(TelemetryConstants.SystemAttributeKey, TelemetryConstants.SystemAttributeValue);
            initialAttributes.Set(TelemetryConstants.ServiceAttributeKey, serviceId);

            var tracerProvider = requestContext.ClientConfig.TelemetryProvider.TracerProvider;

            var scope = $"{TelemetryConstants.TelemetryScopePrefix}.{serviceId}";
            var tracer = tracerProvider.GetTracer(scope);

            return tracer.CreateSpan(spanName, initialAttributes, spanKind, parentContext);
        }

        /// <summary>
        /// Records an exception in the provided trace span with additional attributes.
        /// </summary>
        /// <param name="span">The trace span to record the exception in.</param>
        /// <param name="exception">The exception to record.</param>
        public static void CaptureException(this TraceSpan span, Exception exception) 
        {
            span.RecordException(exception);

            span.SetAttribute(TelemetryConstants.ExceptionTypeAttributeKey, exception.GetType().ToString());
            span.SetAttribute(TelemetryConstants.ExceptionMessageAttributeKey, exception.Message);
            span.SetAttribute(TelemetryConstants.ExceptionStackTraceAttributeKey, exception.StackTrace);
            
            var amazonException = exception as AmazonServiceException;
            if (amazonException != null)
            {
                span.SetAttribute(TelemetryConstants.AWSErrorCodeAttributeKey, amazonException.ErrorCode);
                span.SetAttribute(TelemetryConstants.HTTPStatusCodeAttributeKey, ((int)amazonException.StatusCode));
                span.SetAttribute(TelemetryConstants.RequestIdAttributeKey, amazonException.RequestId);
            }
        }
    }
}
