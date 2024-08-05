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
    /// Abstract class representing a generic up-down counter.
    /// An up-down counter is an instrument that allows recording of both increments and decrements. 
    /// This is often used to capture metrics such as the current number of active requests, 
    /// concurrent connections, etc.
    /// The generic type parameter T specifies the type of value the counter records, such as int, long, etc.
    /// </summary>
    /// <typeparam name="T">The type of value the counter records.</typeparam>
    public abstract class UpDownCounter<T> where T : struct
    {
        /// <summary>
        /// Increments or decrements the counter by a specified value.
        /// The counter allows both increasing and decreasing values to be recorded, making it suitable for metrics that can go up and down.
        /// </summary>
        /// <param name="value">The amount to increment or decrement the counter by. This value can be positive or negative and is of type T.</param>
        /// <param name="attributes">Optional attributes associated with the operation. These attributes provide additional context or metadata.</param>
        public abstract void Add(T value, Attributes attributes = null);
    }
}
