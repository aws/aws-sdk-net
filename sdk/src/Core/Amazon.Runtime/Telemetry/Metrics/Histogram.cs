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
    /// Abstract class representing a histogram used to record values of a specified type.
    /// A histogram is a type of metric instrument that tracks the distribution of values.
    /// </summary>
    /// <typeparam name="T">The type of the histogram value. Must be a struct.</typeparam>
    public abstract class Histogram<T> where T : struct
    {
        /// <summary>
        /// Records a value in the histogram.
        /// </summary>
        /// <param name="value">The value to record. This represents a measurement or observation.</param>
        /// <param name="attributes">Optional attributes associated with the measurement. These can be used to
        /// provide additional context or dimensions to the recorded value.</param>
        public abstract void Record(T value, Attributes attributes = null);
    }
}
