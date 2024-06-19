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

namespace Amazon.Runtime.Telemetry.Tracing
{
    /// <summary>
    /// Represents the context of a span in a trace.
    /// </summary>
    public abstract class SpanContext
    {
        /// <summary>
        /// Gets the trace identifier this span belongs to.
        /// </summary>
        public abstract string TraceId { get; }

        /// <summary>
        /// Gets the unique span identifier.
        /// </summary>
        public abstract string SpanId { get; }

        /// <summary>
        /// Gets a value indicating whether the SpanContext was propagated from a remote parent.
        /// </summary>
        public abstract bool IsRemote { get; }

        /// <summary>
        /// Gets a value indicating whether the SpanContext has a non-zero TraceId and non-zero SpanId.
        /// </summary>
        public abstract bool IsValid { get; }
    }
}
