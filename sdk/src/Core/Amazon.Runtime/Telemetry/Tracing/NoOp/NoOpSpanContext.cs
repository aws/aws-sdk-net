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

namespace Amazon.Runtime.Telemetry.Tracing.NoOp
{
    /// <summary>
    /// A no-op implementation of <see cref="SpanContext"/> serving as a default placeholder.
    /// </summary>
    internal class NoOpSpanContext : SpanContext
    {
        /// <summary>
        /// Gets the trace identifier this span belongs to. Returns an empty string for no-op.
        /// </summary>
        public override string TraceId => string.Empty;

        /// <summary>
        /// Gets the unique span identifier. Returns an empty string for no-op.
        /// </summary>
        public override string SpanId => string.Empty;

        /// <summary>
        /// Gets a value indicating whether the SpanContext was propagated from a remote parent. Always false for no-op.
        /// </summary>
        public override bool IsRemote => false;

        /// <summary>
        /// Gets a value indicating whether the SpanContext has a non-zero TraceId and non-zero SpanId. Always false for no-op.
        /// </summary>
        public override bool IsValid => false;
    }
}
