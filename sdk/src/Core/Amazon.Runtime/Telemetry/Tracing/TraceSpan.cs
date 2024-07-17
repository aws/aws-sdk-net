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
    /// Represents a single operation/task within a trace. Each trace contains a root span and
    /// optionally one or more child spans.
    /// </summary>
    public abstract class TraceSpan : IDisposable
    {
        /// <summary>
        /// The name of the span.
        /// </summary>
        public string Name { get; protected set; }

        /// <summary>
        /// Adds an event to the span.
        /// An event represents a notable occurrence within the span's lifetime, such as an error or a significant state change.
        /// </summary>
        /// <param name="name">The name of the event.</param>
        /// <param name="attributes">Optional attributes associated with the event. These can provide additional context or details about the event.</param>
        public abstract void EmitEvent(string name, Attributes attributes = null);

        /// <summary>
        /// Sets the value for a given attribute key.
        /// Attributes are key-value pairs that provide additional metadata or context about the span.
        /// </summary>
        /// <param name="key">The key for the attribute.</param>
        /// <param name="value">The value of the attribute.</param>
        public abstract void SetAttribute(string key, object value);

        /// <summary>
        /// Sets the status of the span.
        /// The status indicates whether the span represents a successful operation or an error.
        /// </summary>
        /// <param name="status">The status to set for the span.</param>
        public abstract void SetStatus(SpanStatus status);

        /// <summary>
        /// Records an exception and its associated attributes in the trace span.
        /// </summary>
        /// <param name="exception">The exception to record.</param>
        /// <param name="attributes">Optional attributes associated with the exception. These can provide additional context about the exception.</param>
        public abstract void RecordException(Exception exception, Attributes attributes = null);

        /// <summary>
        /// Marks the end of the span's execution.
        /// This should be called when the unit of work represented by the span has completed.
        /// </summary>
        public abstract void End();

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
