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

using Amazon.Runtime.Telemetry.Metrics;
using Amazon.Runtime.Telemetry.Metrics.NoOp;
using Amazon.Runtime.Telemetry.Tracing;
using Amazon.Runtime.Telemetry.Tracing.NoOp;

namespace Amazon.Runtime.Telemetry
{
    /// <summary>
    /// Default implementation of <see cref="TelemetryProvider"/> that uses no-op providers by default.
    /// </summary>
    public class DefaultTelemetryProvider : TelemetryProvider
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DefaultTelemetryProvider"/> class with no-op providers.
        /// This setup prevents any telemetry actions from being performed unless explicitly registered using the
        /// registration methods.
        /// </summary>
        public DefaultTelemetryProvider()
        {
            TracerProvider = new NoOpTracerProvider();
            MeterProvider = new NoOpMeterProvider();
        }

        /// <summary>
        /// Gets the <see cref="TracerProvider"/> used to create new tracers.
        /// This property is initialized with a no-op implementation by default.
        /// </summary>
        public override TracerProvider TracerProvider { get; protected set; }

        /// <summary>
        /// Gets the <see cref="MeterProvider"/> used to create new metrics.
        /// This property is initialized with a no-op implementation by default.
        /// </summary>
        public override MeterProvider MeterProvider { get; protected set; }

        /// <summary>
        /// Registers a new <see cref="TracerProvider"/>.
        /// This method sets a custom tracer provider to replace the default no-op provider,
        /// enabling the collection of tracing data.
        /// </summary>
        /// <param name="tracerProvider">The tracer provider to register.</param>
        public override void RegisterTracerProvider(TracerProvider tracerProvider)
        {
            TracerProvider = tracerProvider;
        }

        /// <summary>
        /// Registers a new <see cref="MeterProvider"/>.
        /// This method sets a custom meter provider to replace the default no-op provider,
        /// enabling the collection of metrics data.
        /// </summary>
        /// <param name="meterProvider">The meter provider to register.</param>
        public override void RegisterMeterProvider(MeterProvider meterProvider)
        {
            MeterProvider = meterProvider;
        }
    }
}