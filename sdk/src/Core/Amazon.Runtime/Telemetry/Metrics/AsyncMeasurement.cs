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
    /// Represents an async measurement.
    /// An async measurement records values, such as periodically or based on events.
    /// The generic type parameter T specifies the type of value being recorded, such as int, long, etc.
    /// </summary>
    /// <typeparam name="T">The type of value being measured.</typeparam>
    public abstract class AsyncMeasurement<T> where T : struct
    {
        /// <summary>
        /// Records a value.
        /// This method is called to record a measurement value.
        /// </summary>
        /// <param name="value">The value to be recorded. This value is of type T.</param>
        /// <param name="attributes">Optional attributes associated with the measurement.</param>
        public abstract void Record(T value, Attributes attributes = null);
    }
}
