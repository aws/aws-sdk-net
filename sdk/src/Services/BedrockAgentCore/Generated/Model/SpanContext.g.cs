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

/*
 * Do not modify this file. This file is generated from the smithy.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;
using Amazon.Runtime;
using Amazon.Runtime.Internal;

#pragma warning disable CS0612,CS0618,CS1570

namespace Amazon.BedrockAgentCore.Model
{
    /// <summary>
    /// The contextual information that uniquely identifies a span within the distributed
    /// tracing system. Contains session, trace, and span identifiers used to correlate evaluation
    /// results with specific agent execution points.
    /// </summary>
    public partial class SpanContext
    {
        /// <summary>
        /// Gets and sets the property SessionId. 
        /// <para>
        ///  The unique identifier of the session containing this span. Sessions represent complete
        /// conversation flows and are detected using configurable <c>SessionTimeoutMinutes</c>
        /// (default 15 minutes). 
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string SessionId { get; set; }

        /// <summary>
        /// Checks to see if the SessionId property is set.
        /// </summary>
        internal bool IsSetSessionId() => this.SessionId != null;

        /// <summary>
        /// Gets and sets the property SpanId. 
        /// <para>
        ///  The unique identifier of the specific span being referenced. Spans represent individual
        /// operations like tool calls, model invocations, or other discrete actions within the
        /// agent's execution. 
        /// </para>
        /// </summary>
        public string SpanId { get; set; }

        /// <summary>
        /// Checks to see if the SpanId property is set.
        /// </summary>
        internal bool IsSetSpanId() => this.SpanId != null;

        /// <summary>
        /// Gets and sets the property TraceId. 
        /// <para>
        ///  The unique identifier of the trace containing this span. Traces represent individual
        /// request-response interactions within a session and group related spans together. 
        /// </para>
        /// </summary>
        public string TraceId { get; set; }

        /// <summary>
        /// Checks to see if the TraceId property is set.
        /// </summary>
        internal bool IsSetTraceId() => this.TraceId != null;
    }
}
