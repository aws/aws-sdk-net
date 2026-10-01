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
    /// Contains information about an input or output for a node in the flow. For more information,
    /// see <a href="https://docs.aws.amazon.com/bedrock/latest/userguide/flows-trace.html">Track
    /// each step in your prompt flow by viewing its trace in Amazon Bedrock</a>.
    /// </summary>
    public partial class FlowTrace
    {
        /// <summary>
        /// Gets and sets the property ConditionNodeResultTrace. 
        /// <para>
        /// Contains information about an output from a condition node.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive = true)]
        public FlowTraceConditionNodeResultEvent ConditionNodeResultTrace { get; set; }

        /// <summary>
        /// Checks to see if the ConditionNodeResultTrace property is set.
        /// </summary>
        internal bool IsSetConditionNodeResultTrace() => this.ConditionNodeResultTrace != null;

        /// <summary>
        /// Gets and sets the property NodeActionTrace. 
        /// <para>
        /// Contains information about an action (operation) called by a node.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive = true)]
        public FlowTraceNodeActionEvent NodeActionTrace { get; set; }

        /// <summary>
        /// Checks to see if the NodeActionTrace property is set.
        /// </summary>
        internal bool IsSetNodeActionTrace() => this.NodeActionTrace != null;

        /// <summary>
        /// Gets and sets the property NodeDependencyTrace. 
        /// <para>
        /// Contains information about an internal trace of a node.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive = true)]
        public FlowTraceDependencyEvent NodeDependencyTrace { get; set; }

        /// <summary>
        /// Checks to see if the NodeDependencyTrace property is set.
        /// </summary>
        internal bool IsSetNodeDependencyTrace() => this.NodeDependencyTrace != null;

        /// <summary>
        /// Gets and sets the property NodeInputTrace. 
        /// <para>
        /// Contains information about the input into a node.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive = true)]
        public FlowTraceNodeInputEvent NodeInputTrace { get; set; }

        /// <summary>
        /// Checks to see if the NodeInputTrace property is set.
        /// </summary>
        internal bool IsSetNodeInputTrace() => this.NodeInputTrace != null;

        /// <summary>
        /// Gets and sets the property NodeOutputTrace. 
        /// <para>
        /// Contains information about the output from a node.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive = true)]
        public FlowTraceNodeOutputEvent NodeOutputTrace { get; set; }

        /// <summary>
        /// Checks to see if the NodeOutputTrace property is set.
        /// </summary>
        internal bool IsSetNodeOutputTrace() => this.NodeOutputTrace != null;
    }
}
