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

namespace Amazon.BedrockAgentRuntime.Model
{
    /// <summary>
    /// Contains information about an internal trace of a specific node during execution.
    /// </summary>
    public partial class NodeDependencyEvent
    {
        /// <summary>
        /// Gets and sets the property NodeName. 
        /// <para>
        /// The name of the node that generated the dependency trace.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string NodeName { get; set; }

        /// <summary>
        /// Checks to see if the NodeName property is set.
        /// </summary>
        internal bool IsSetNodeName() => this.NodeName != null;

        /// <summary>
        /// Gets and sets the property Timestamp. 
        /// <para>
        /// The date and time that the dependency trace was generated.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public DateTime? Timestamp { get; set; }

        /// <summary>
        /// Checks to see if the Timestamp property is set.
        /// </summary>
        internal bool IsSetTimestamp() => this.Timestamp.HasValue;

        /// <summary>
        /// Gets and sets the property TraceElements. 
        /// <para>
        /// The trace elements containing detailed information about the node execution.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Sensitive = true)]
        public NodeTraceElements TraceElements { get; set; }

        /// <summary>
        /// Checks to see if the TraceElements property is set.
        /// </summary>
        internal bool IsSetTraceElements() => this.TraceElements != null;
    }
}
