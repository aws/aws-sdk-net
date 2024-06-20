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
    /// Abstract class representing a generic monotonic counter.
    /// A monotonic counter is an instrument that records increasing values, often used to capture metrics such as request counts, error counts, etc.
    /// The generic type parameter T specifies the type of value the counter records, such as int, long, etc.
    /// </summary>
    /// <typeparam name="T">The type of value the counter records.</typeparam>
    public abstract class MonotonicCounter<T> where T : struct
    {
        /// <summary>
        /// Increments the counter by a specified value.
        /// The counter only allows increasing values to be recorded, making it suitable for metrics that should never decrease.
        /// </summary>
        /// <param name="value">The amount to increment the counter by. This value should be positive and of type T.</param>
        /// <param name="attributes">Optional attributes associated with the increment operation.</param>
        public abstract void Add(T value, Attributes attributes = null);
    }
}
