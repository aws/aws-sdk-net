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

namespace Amazon.Runtime.Telemetry.Tracing.NoOp
{
    /// <summary>
    /// No-op implementation of the <see cref="TraceSpan"/> class.
    /// This implementation does nothing when methods are called, and is used as a placeholder or default
    /// implementation when tracing is not enabled or required.
    /// </summary>
    internal class NoOpTraceSpan : TraceSpan
    {
        /// <summary>
        /// No-op implementation of the <see cref="EmitEvent(string, Attributes)"/> method.
        /// This method does nothing when called.
        /// </summary>
        /// <param name="name">The name of the event. This parameter is ignored in the no-op implementation.</param>
        /// <param name="attributes">Optional attributes associated with the event. This parameter is ignored in the no-op implementation.</param>
        public override void EmitEvent(string name, Attributes attributes = null)
        {
            // No-op implementation
        }

        /// <summary>
        /// No-op implementation of the <see cref="SetAttribute(string, object)"/> method.
        /// This method does nothing when called.
        /// </summary>
        /// <param name="key">The key for the attribute. This parameter is ignored in the no-op implementation.</param>
        /// <param name="value">The value of the attribute. This parameter is ignored in the no-op implementation.</param>
        public override void SetAttribute(string key, object value)
        {
            // No-op implementation
        }

        /// <summary>
        /// No-op implementation of the <see cref="SetStatus(SpanStatus)"/> method.
        /// This method does nothing when called.
        /// </summary>
        /// <param name="status">The status to set for the span. This parameter is ignored in the no-op implementation.</param>
        public override void SetStatus(SpanStatus status)
        {
            // No-op implementation
        }

        /// <summary>
        /// No-op implementation of the <see cref="RecordException(Exception, Attributes)"/> method.
        /// </summary>
        /// <param name="exception">The exception to record. This parameter is ignored in the no-op implementation.</param>
        /// <param name="attributes">Optional attributes associated with the exception. This parameter is ignored in the no-op implementation.</param>
        public override void RecordException(Exception exception, Attributes attributes = null)
        {
            // No-op implementation
        }

        /// <summary>
        /// No-op implementation of the <see cref="End"/> method.
        /// This method does nothing when called.
        /// </summary>
        public override void End()
        {
            // No-op implementation
        }
    }
}
