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
using Amazon.Runtime.Telemetry.Tracing;

namespace Amazon.Runtime.Telemetry
{
    /// <summary>
    /// Abstract class representing a container for telemetry providers.
    /// This class provides the infrastructure for collecting and managing telemetry data such as metrics and traces.
    /// </summary>
    public abstract class TelemetryProvider
    {
        /// <summary>
        /// Gets the <see cref="MeterProvider"/> used to create new metrics.
        /// </summary>
        public abstract MeterProvider MeterProvider { get; protected set; }

        /// <summary>
        /// Gets the <see cref="TracerProvider"/> used to create new tracers.
        /// </summary>
        public abstract TracerProvider TracerProvider { get; protected set; }

        /// <summary>
        /// Registers a new <see cref="MeterProvider"/>.
        /// This method should be called to set a custom meter provider to enable metrics collection.
        /// </summary>
        /// <param name="meterProvider">The meter provider to register.</param>
        public abstract void RegisterMeterProvider(MeterProvider meterProvider);

        /// <summary>
        /// Registers a new <see cref="TracerProvider"/>.
        /// This method should be called to set a custom tracer provider to enable tracing.
        /// </summary>
        /// <param name="tracerProvider">The tracer provider to register.</param>
        public abstract void RegisterTracerProvider(TracerProvider tracerProvider);
    }
}