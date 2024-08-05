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

namespace Amazon.Runtime.Telemetry.Metrics
{
    /// <summary>
    /// Represents a meter used to create various types of instruments for measuring telemetry data.
    /// </summary>
    public abstract class Meter : IDisposable
    {
        /// <summary>
        /// Creates an up-down counter instrument which can be incremented or decremented by a specified value.
        /// </summary>
        /// <typeparam name="T">The type of value being measured by the up-down counter instrument. This can be a numeric type such as int, long, double, etc.</typeparam>
        /// <param name="name">The name of the up-down counter instrument. This name uniquely identifies the instrument within the meter.</param>
        /// <param name="units">Optional. The unit of measure for the counter value, such as "seconds" or "bytes".</param>
        /// <param name="description">Optional. A description of the up-down counter instrument.</param>
        /// <returns>An <see cref="UpDownCounter{T}"/> used to measure values that can go up and down.</returns>
        public abstract UpDownCounter<T> CreateUpDownCounter<T>(
            string name,
            string units = null,
            string description = null) where T : struct;

        /// <summary>
        /// Creates a monotonic counter instrument which can only be incremented by a specified value.
        /// </summary>
        /// <typeparam name="T">The type of value being measured by the monotonic counter instrument. This can be a numeric type such as int, long, double, etc.</typeparam>
        /// <param name="name">The name of the monotonic counter instrument. This name uniquely identifies the instrument within the meter.</param>
        /// <param name="units">Optional. The unit of measure for the counter value, such as "seconds" or "bytes".</param>
        /// <param name="description">Optional. A description of the monotonic counter instrument.</param>
        /// <returns>A <see cref="MonotonicCounter{T}"/> used to measure values that can only be incremented.</returns>
        public abstract MonotonicCounter<T> CreateMonotonicCounter<T>(
            string name,
            string units = null,
            string description = null) where T : struct;

        /// <summary>
        /// Creates a histogram instrument which records values and provides statistical summaries.
        /// </summary>
        /// <typeparam name="T">The type of value being measured by the histogram instrument. This can be a numeric type such as int, long, double, etc.</typeparam>
        /// <param name="name">The name of the histogram instrument. This name uniquely identifies the instrument within the meter.</param>
        /// <param name="units">Optional. The unit of measure for the histogram values, such as "seconds" or "bytes".</param>
        /// <param name="description">Optional. A description of the histogram instrument.</param>
        /// <returns>A <see cref="Histogram{T}"/> used to measure and record statistical summaries of values.</returns>
        public abstract Histogram<T> CreateHistogram<T>(
            string name,
            string units = null,
            string description = null) where T : struct;

        /// <summary>
        /// Disposes the span, releasing any resources associated with it.
        /// </summary>
        public void Dispose()
        {
            this.Dispose(true);
            GC.SuppressFinalize(this);
        }

        protected virtual void Dispose(bool disposing)
        {
        }
    }
}
