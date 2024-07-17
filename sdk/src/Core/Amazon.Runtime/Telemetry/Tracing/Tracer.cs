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

namespace Amazon.Runtime.Telemetry.Tracing
{
    /// <summary>
    /// Abstract class representing a tracer used to record tracing information.
    /// Tracer providers are used to create tracers which record tracing data.
    /// </summary>
    public abstract class Tracer : IDisposable
    {
        /// <summary>
        /// Creates a new <see cref="TraceSpan"/> with the given name.
        /// Optionally, a parent context, initial attributes, and type of span can be provided.
        /// </summary>
        /// <param name="name">The name of the span.</param>
        /// <param name="initialAttributes">Optional initial set of attributes for the span.</param>
        /// <param name="spanKind">Optional type of span to create. Defaults to <see cref="SpanKind.INTERNAL"/>.</param>
        /// <param name="parentContext">Optional parent context.</param>
        /// <returns>A <see cref="TraceSpan"/> instance representing the created span.</returns>
        public abstract TraceSpan CreateSpan(
            string name,
            Attributes initialAttributes = null,
            SpanKind spanKind = SpanKind.INTERNAL,
            SpanContext parentContext = null);

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
