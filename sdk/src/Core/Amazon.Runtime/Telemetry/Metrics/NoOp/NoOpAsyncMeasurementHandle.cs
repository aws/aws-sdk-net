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
    /// No-op implementation of the <see cref="AsyncMeasurementHandle{T}"/> class.
    /// This implementation does nothing when methods are called and is used as a placeholder or default
    /// implementation when async measurement recording is not enabled or required.
    /// </summary>
    /// <typeparam name="T">The type of value being measured.</typeparam>
    internal class NoOpAsyncMeasurementHandle<T> : AsyncMeasurementHandle<T> where T : struct
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="NoOpAsyncMeasurementHandle{T}"/> class.
        /// </summary>
        /// <param name="meter">The meter that created this handle.</param>
        public NoOpAsyncMeasurementHandle(Meter meter) : base(meter) { }
    }
}
