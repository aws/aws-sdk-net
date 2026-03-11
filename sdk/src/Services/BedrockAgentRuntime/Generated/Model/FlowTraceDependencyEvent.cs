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

#pragma warning disable CS0612,CS0618,CS1570
namespace Amazon.BedrockAgentRuntime.Model
{
    /// <summary>
    /// Contains information about a dependency trace event in the flow.
    /// </summary>
    public partial class FlowTraceDependencyEvent
    {
        private string _nodeName;
        private DateTime? _timestamp;
        private TraceElements _traceElements;

        /// <summary>
        /// Gets and sets the property NodeName. 
        /// <para>
        /// The name of the node that generated the dependency trace.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string NodeName
        {
            get { return this._nodeName; }
            set { this._nodeName = value; }
        }

        // Check to see if NodeName property is set
        internal bool IsSetNodeName()
        {
            return this._nodeName != null;
        }

        /// <summary>
        /// Gets and sets the property Timestamp. 
        /// <para>
        /// The date and time that the dependency trace was generated.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public DateTime? Timestamp
        {
            get { return this._timestamp; }
            set { this._timestamp = value; }
        }

        // Check to see if Timestamp property is set
        internal bool IsSetTimestamp()
        {
            return this._timestamp.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property TraceElements. 
        /// <para>
        /// The trace elements containing detailed information about the dependency.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Sensitive=true)]
        public TraceElements TraceElements
        {
            get { return this._traceElements; }
            set { this._traceElements = value; }
        }

        // Check to see if TraceElements property is set
        internal bool IsSetTraceElements()
        {
            return this._traceElements != null;
        }

    }
}