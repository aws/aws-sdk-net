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

namespace Amazon.Runtime.Telemetry.Metrics
{
    /// <summary>
    /// Represents a handle for async measurements.
    /// The handle is used to manage and stop the async recording of measurements.
    /// </summary>
    /// <typeparam name="T">The type of value being measured.</typeparam>
    public abstract class AsyncMeasurementHandle<T> where T : struct
    {
        /// <summary>
        /// Gets the meter that created this handle.
        /// </summary>
        public Meter Meter { get; protected set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="AsyncMeasurementHandle{T}"/> class.
        /// </summary>
        /// <param name="meter">The meter that created this handle.</param>
        protected AsyncMeasurementHandle(Meter meter)
        {
            Meter = meter;
        }
    }
}
