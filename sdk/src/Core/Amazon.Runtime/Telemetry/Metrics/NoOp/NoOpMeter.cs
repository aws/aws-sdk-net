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

namespace Amazon.Runtime.Telemetry.Metrics.NoOp
{
    /// <summary>
    /// No-op implementation of the <see cref="Meter"/> class.
    /// This implementation does nothing when methods are called and is used as a placeholder or default
    /// implementation when telemetry data recording is not enabled.
    /// </summary>
    internal class NoOpMeter : Meter
    {
        /// <summary>
        /// No-op implementation of the <see cref="CreateUpDownCounter"/> method.
        /// This method does nothing when called and returns a no-op counter.
        /// </summary>
        /// <typeparam name="T">The type of value being measured by the up-down counter instrument.</typeparam>
        /// <param name="name">The name of the up-down counter instrument.</param>
        /// <param name="units">Optional. The unit of measure for the counter value.</param>
        /// <param name="description">Optional. A description of the up-down counter instrument.</param>
        /// <returns>A no-op <see cref="UpDownCounter{T}"/> instance.</returns>
        public override UpDownCounter<T> CreateUpDownCounter<T>(
            string name,
            string units = null,
            string description = null)
        {
            return new NoOpUpDownCounter<T>();
        }

        /// <summary>
        /// No-op implementation of the <see cref="CreateMonotonicCounter"/> method.
        /// This method does nothing when called and returns a no-op counter.
        /// </summary>
        /// <typeparam name="T">The type of value being measured by the monotonic counter instrument.</typeparam>
        /// <param name="name">The name of the monotonic counter instrument.</param>
        /// <param name="units">Optional. The unit of measure for the counter value.</param>
        /// <param name="description">Optional. A description of the monotonic counter instrument.</param>
        /// <returns>A no-op <see cref="MonotonicCounter{T}"/> instance.</returns>
        public override MonotonicCounter<T> CreateMonotonicCounter<T>(
            string name,
            string units = null,
            string description = null)
        {
            return new NoOpMonotonicCounter<T>();
        }

        /// <summary>
        /// No-op implementation of the <see cref="CreateHistogram"/> method.
        /// This method does nothing when called and returns a no-op histogram.
        /// </summary>
        /// <typeparam name="T">The type of value being measured by the histogram instrument.</typeparam>
        /// <param name="name">The name of the histogram instrument.</param>
        /// <param name="units">Optional. The unit of measure for the histogram values.</param>
        /// <param name="description">Optional. A description of the histogram instrument.</param>
        /// <returns>A no-op <see cref="Histogram{T}"/> instance.</returns>
        public override Histogram<T> CreateHistogram<T>(
            string name,
            string units = null,
            string description = null)
        {
            return new NoOpHistogram<T>();
        }
    }
}
