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
 * Do not modify this file. This file is generated from the bedrock-agent-runtime-2023-07-26.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.EventStreams;
using Amazon.Runtime.EventStreams.Internal;
using Amazon.BedrockAgentRuntime.Model.Internal.MarshallTransformations;
using Amazon.Runtime.EventStreams.Utils;
using Amazon.Runtime.Internal.Util;

#pragma warning disable CS0612,CS0618,CS1570
namespace Amazon.BedrockAgentRuntime.Model
{
    /// <summary>
    /// Contains information about a trace, which tracks an input or output for a node in
    /// the flow. For more information, see <a href="https://docs.aws.amazon.com/bedrock/latest/userguide/flows-trace.html">Track
    /// each step in your prompt flow by viewing its trace in Amazon Bedrock</a>.
    /// </summary>
    public partial class FlowTraceEvent
        : IEventStreamEvent
    {
        private FlowTrace _trace;

        /// <summary>
        /// Gets and sets the property Trace. 
        /// <para>
        /// The trace object containing information about an input or output for a node in the
        /// flow.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Sensitive=true)]
        public FlowTrace Trace
        {
            get { return this._trace; }
            set { this._trace = value; }
        }

        // Check to see if Trace property is set
        internal bool IsSetTrace()
        {
            return this._trace != null;
        }

    }
}