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

namespace Amazon.Runtime.Telemetry.Metrics
{
    /// <summary>
    /// Utility class for metrics related operations.
    /// </summary>
    internal static class MetricsUtilities
    {
        /// <summary>
        /// Records an error using a MonotonicCounter.
        /// </summary>
        /// <param name="requestContext">The request context object.</param>
        /// <param name="exception">The exception that occurred.</param>
        public static void RecordError(IRequestContext requestContext, Exception exception)
        {
            var attributes = new Attributes();
            attributes.Set(TelemetryConstants.ExceptionTypeAttributeKey, exception.GetType().Name);

            AddMonotonicCounterValue(requestContext, TelemetryConstants.CallErrorsMetricName, TelemetryConstants.ErrorUnitName, 1, attributes);
        }

        /// <summary>
        /// Records a value using a MonotonicCounter.
        /// </summary>
        /// <param name="requestContext">The request context object.</param>
        /// <param name="metricName">The name of the metric to record.</param>
        /// <param name="unit">The unit of the metric.</param>
        /// <param name="value">The value to be recorded by the MonotonicCounter.</param>
        /// <param name="initialAttributes">The attributes associated with the metric.</param>
        public static void AddMonotonicCounterValue(IRequestContext requestContext, string metricName, string unit, long value = 1, Attributes initialAttributes = null)
        {
            var serviceId = requestContext.ClientConfig.ServiceId;

            if (initialAttributes == null)
                initialAttributes = new Attributes();

            var operationName = AWSSDKUtils.ExtractOperationName(requestContext.RequestName);
            initialAttributes.Set(TelemetryConstants.MethodAttributeKey, operationName);

            initialAttributes.Set(TelemetryConstants.SystemAttributeKey, TelemetryConstants.SystemAttributeValue);
            initialAttributes.Set(TelemetryConstants.ServiceAttributeKey, serviceId);

            var scope = $"{TelemetryConstants.TelemetryScopePrefix}.{serviceId}";

            var meter = requestContext.ClientConfig.TelemetryProvider.MeterProvider.GetMeter(scope);
            var monotonicCounter = meter.CreateMonotonicCounter<long>(metricName, unit);

            monotonicCounter.Add(value, initialAttributes);
        }

        /// <summary>
        /// Measures the duration of an event in seconds. The duration is recorded into a histogram.
        /// </summary>
        /// <param name="requestContext">The request context object.</param>
        /// <param name="metricName">The name of the metric to record.</param>
        /// <param name="initialAttributes">The attributes associated with the metric.</param>
        /// <returns>A disposable object that records the duration when disposed.</returns>
        public static IDisposable MeasureDuration(IRequestContext requestContext, string metricName, Attributes initialAttributes = null)
        {
            if (initialAttributes == null)
                initialAttributes = new Attributes();

            var operationName = AWSSDKUtils.ExtractOperationName(requestContext.RequestName);
            initialAttributes.Set(TelemetryConstants.MethodAttributeKey, operationName);

            return MeasureDuration(requestContext.ClientConfig, metricName, initialAttributes);
        }

        /// <summary>
        /// Measures the duration of an event in seconds. The duration is recorded into a histogram.
        /// </summary>
        /// <param name="config">The client configuration object.</param>
        /// <param name="metricName">The name of the metric to record.</param>
        /// <param name="attributes">The attributes associated with the metric.</param>
        /// <returns>A disposable object that records the duration when disposed.</returns>
        public static IDisposable MeasureDuration(IClientConfig config, string metricName, Attributes attributes = null)
        {
            var serviceId = config.ServiceId;

            if (attributes == null)
                attributes = new Attributes();
            attributes.Set(TelemetryConstants.ServiceAttributeKey, serviceId);
            attributes.Set(TelemetryConstants.SystemAttributeKey, TelemetryConstants.SystemAttributeValue);

            var scope = $"{TelemetryConstants.TelemetryScopePrefix}.{serviceId}";
            var meter = config.TelemetryProvider.MeterProvider.GetMeter(scope);

            return new DurationMetricsMeasurer(meter, metricName, attributes);
        }

        private class DurationMetricsMeasurer: IDisposable
        {
            private readonly Histogram<double> _histogram;
            private readonly Attributes _attributes;
            private readonly DateTime _startTime;

            public DurationMetricsMeasurer(Meter meter, string metricName, Attributes attributes)
            {
                _histogram = meter.CreateHistogram<double>(metricName, TelemetryConstants.SecondsUnitName);
                _attributes = attributes;
                _startTime = AWSSDKUtils.CorrectedUtcNow;
            }

            public void Dispose()
            {
                // Record the duration in seconds using ticks precision to ensure high precision
                // and to avoid data loss that may occur due to rounding when using seconds.

                var ticks = (AWSSDKUtils.CorrectedUtcNow - _startTime).Ticks;
                var durationInSeconds  = (double)ticks / TimeSpan.TicksPerSecond;

                _histogram.Record(durationInSeconds, _attributes);
            }
        }
    }
}
