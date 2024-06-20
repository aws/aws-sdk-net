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
    /// Represents the kind of span, which defines the general role a span plays in a trace.
    /// </summary>
    public enum SpanKind
    {
        /// <summary>
        /// Represents an internal operation within an application.
        /// </summary>
        INTERNAL,

        /// <summary>
        /// Represents a request to an external component.
        /// </summary>
        CLIENT,

        /// <summary>
        /// Represents a request received from an external component.
        /// </summary>
        SERVER,

        /// <summary>
        /// Represents an output provided to external components.
        /// </summary>
        PRODUCER,

        /// <summary>
        /// Represents an output received from an external component.
        /// </summary>
        CONSUMER
    }
}
