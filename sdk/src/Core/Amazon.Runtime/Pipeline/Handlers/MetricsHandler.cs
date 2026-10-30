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

using Amazon.Util;
using Amazon.Runtime.Internal.Util;
using System.Globalization;
using System;
using Amazon.Runtime.Telemetry;
using Amazon.Runtime.Telemetry.Tracing;
using Amazon.Runtime.Telemetry.Metrics;

namespace Amazon.Runtime.Internal
{
    /// <summary>
    /// This handler manages the metrics used to time the complete call and
    /// logs the final metrics.
    /// </summary>
    public class MetricsHandler : PipelineHandler
    {
        private static TraceSpan CreateCallSpan(IRequestContext requestContext)
        {
            // Skip building the span name when tracing is disabled.
            if (TracingUtilities.IsNoOp(requestContext.ClientConfig))
                return TracingUtilities.NoOpSpan;

            var operationName = AWSSDKUtils.ExtractOperationName(requestContext.RequestName);
            var spanName = $"{requestContext.ServiceMetaData.ServiceId}.{operationName}";
            return TracingUtilities.CreateSpan(requestContext, spanName, null, SpanKind.CLIENT);
        }

        /// <summary>
        /// Captures the overall execution time and logs final metrics.
        /// </summary>
        /// <param name="executionContext">The execution context which contains both the
        /// requests and response context.</param>
        public override void InvokeSync(IExecutionContext executionContext)
        {
            var metrics = executionContext.RequestContext.Metrics;
            if (metrics.IsEnabled)
                metrics.AddProperty(Metric.AsyncCall, false);

            var span = CreateCallSpan(executionContext.RequestContext);
            IDisposable callDurationMetricsMeasurer = null;

            try
            {
                callDurationMetricsMeasurer = MetricsUtilities.MeasureDuration(executionContext.RequestContext, TelemetryConstants.CallDurationMetricName);
                if (metrics.IsEnabled)
                    metrics.StartTimedEvent(Metric.ClientExecuteTime);
                base.InvokeSync(executionContext);

                var requestId = executionContext.ResponseContext.Response.ResponseMetadata?.RequestId;
                if (requestId != null)
                    span.SetAttribute(TelemetryConstants.RequestIdAttributeKey, requestId);
            }
            catch (Exception ex)
            {
                span.CaptureException(ex);
                MetricsUtilities.RecordError(executionContext.RequestContext, ex);
                throw;
            }
            finally
            {
                if (metrics.IsEnabled)
                    metrics.StopEvent(Metric.ClientExecuteTime);
                this.LogMetrics(executionContext);
                callDurationMetricsMeasurer?.Dispose();
                span.Dispose();
            }
        }

        /// <summary>
        /// Captures the overall execution time and logs final metrics.
        /// </summary>
        /// <typeparam name="T">The response type for the current request.</typeparam>
        /// <param name="executionContext">
        /// The execution context, it contains the request and response context.
        /// </param>
        /// <returns>A task that represents the asynchronous operation.</returns>
        public override async System.Threading.Tasks.Task<T> InvokeAsync<T>(IExecutionContext executionContext)
        {
            var metrics = executionContext.RequestContext.Metrics;
            if (metrics.IsEnabled)
                metrics.AddProperty(Metric.AsyncCall, true);

            var span = CreateCallSpan(executionContext.RequestContext);
            IDisposable callDurationMetricsMeasurer = null;

            try
            {
                callDurationMetricsMeasurer = MetricsUtilities.MeasureDuration(executionContext.RequestContext, TelemetryConstants.CallDurationMetricName);
                if (metrics.IsEnabled)
                    metrics.StartTimedEvent(Metric.ClientExecuteTime);
                var response = await base.InvokeAsync<T>(executionContext).ConfigureAwait(false);

                var requestId = executionContext.ResponseContext.Response.ResponseMetadata?.RequestId;
                if (requestId != null)
                    span.SetAttribute(TelemetryConstants.RequestIdAttributeKey, requestId);

                return response;
            }
            catch (Exception ex)
            {
                span.CaptureException(ex);
                MetricsUtilities.RecordError(executionContext.RequestContext, ex);
                throw;
            }
            finally
            {
                if (metrics.IsEnabled)
                    metrics.StopEvent(Metric.ClientExecuteTime);
                this.LogMetrics(executionContext);
                callDurationMetricsMeasurer?.Dispose();
                span.Dispose();
            }            
        }
    }
}
