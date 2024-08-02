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

namespace Amazon.Runtime.Telemetry.Metrics.NoOp
{
    /// <summary>
    /// A no-op implementation of the <see cref="MeterProvider"/> that returns a no-op meter.
    /// </summary>
    internal class NoOpMeterProvider : MeterProvider
    {
        /// <summary>
        /// Retrieves a no-op meter, which is a meter that does not record any telemetry data.
        /// </summary>
        /// <param name="scope">
        /// The name of the instrumentation scope that uniquely identifies this meter.
        /// </param>
        /// <param name="attributes">Optional attributes associated with the metrics.</param>
        /// <returns>A no-op <see cref="Meter"/> instance.</returns>
        public override Meter GetMeter(string scope, Attributes attributes = null)
        {
            return new NoOpMeter();
        }
    }
}