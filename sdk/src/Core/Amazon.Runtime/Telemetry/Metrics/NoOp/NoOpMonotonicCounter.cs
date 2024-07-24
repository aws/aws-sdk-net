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
    /// No-op implementation of the <see cref="MonotonicCounter{T}"/> class.
    /// This implementation does nothing when methods are called and is used as a placeholder or default
    /// implementation when metrics recording is not enabled or required.
    /// </summary>
    /// <typeparam name="T">The type of value the counter records.</typeparam>
    internal class NoOpMonotonicCounter<T> : MonotonicCounter<T> where T : struct
    {
        /// <summary>
        /// No-op implementation of the <see cref="Add(T, Attributes)"/> method.
        /// This method does nothing when called.
        /// </summary>
        /// <param name="value">The amount to increment the counter by. This parameter is ignored in the no-op implementation.</param>
        /// <param name="attributes">Optional attributes associated with the increment operation. This parameter is ignored in the no-op implementation.</param>
        public override void Add(T value, Attributes attributes = null)
        {
            // No-op implementation
        }
    }
}
