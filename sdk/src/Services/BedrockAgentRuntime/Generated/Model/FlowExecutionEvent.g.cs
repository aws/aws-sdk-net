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
    /// Represents an event that occurred during an flow execution. This is a union type that
    /// can contain one of several event types, such as node input and output events; flow
    /// input and output events; condition node result events, or failure events.
    /// 
    ///  <note> 
    /// <para>
    /// Flow executions is in preview release for Amazon Bedrock and is subject to change.
    /// </para>
    ///  </note>
    /// </summary>
    public partial class FlowExecutionEvent
    {
        /// <summary>
        /// Gets and sets the property ConditionResultEvent. 
        /// <para>
        /// Contains information about a condition evaluation result during the flow execution.
        /// This event is generated when a condition node in the flow evaluates its conditions.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive = true)]
        public ConditionResultEvent ConditionResultEvent { get; set; }

        /// <summary>
        /// Checks to see if the ConditionResultEvent property is set.
        /// </summary>
        internal bool IsSetConditionResultEvent() => this.ConditionResultEvent != null;

        /// <summary>
        /// Gets and sets the property FlowFailureEvent. 
        /// <para>
        /// Contains information about a failure that occurred at the flow level during execution.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive = true)]
        public FlowFailureEvent FlowFailureEvent { get; set; }

        /// <summary>
        /// Checks to see if the FlowFailureEvent property is set.
        /// </summary>
        internal bool IsSetFlowFailureEvent() => this.FlowFailureEvent != null;

        /// <summary>
        /// Gets and sets the property FlowInputEvent. 
        /// <para>
        /// Contains information about the inputs provided to the flow at the start of execution.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive = true)]
        public FlowExecutionInputEvent FlowInputEvent { get; set; }

        /// <summary>
        /// Checks to see if the FlowInputEvent property is set.
        /// </summary>
        internal bool IsSetFlowInputEvent() => this.FlowInputEvent != null;

        /// <summary>
        /// Gets and sets the property FlowOutputEvent. 
        /// <para>
        /// Contains information about the outputs produced by the flow at the end of execution.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive = true)]
        public FlowExecutionOutputEvent FlowOutputEvent { get; set; }

        /// <summary>
        /// Checks to see if the FlowOutputEvent property is set.
        /// </summary>
        internal bool IsSetFlowOutputEvent() => this.FlowOutputEvent != null;

        /// <summary>
        /// Gets and sets the property NodeActionEvent. 
        /// <para>
        /// Contains information about an action (operation) called by a node during execution.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive = true)]
        public NodeActionEvent NodeActionEvent { get; set; }

        /// <summary>
        /// Checks to see if the NodeActionEvent property is set.
        /// </summary>
        internal bool IsSetNodeActionEvent() => this.NodeActionEvent != null;

        /// <summary>
        /// Gets and sets the property NodeDependencyEvent. 
        /// <para>
        /// Contains information about an internal trace of a specific node during execution.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive = true)]
        public NodeDependencyEvent NodeDependencyEvent { get; set; }

        /// <summary>
        /// Checks to see if the NodeDependencyEvent property is set.
        /// </summary>
        internal bool IsSetNodeDependencyEvent() => this.NodeDependencyEvent != null;

        /// <summary>
        /// Gets and sets the property NodeFailureEvent. 
        /// <para>
        /// Contains information about a failure that occurred at a specific node during execution.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive = true)]
        public NodeFailureEvent NodeFailureEvent { get; set; }

        /// <summary>
        /// Checks to see if the NodeFailureEvent property is set.
        /// </summary>
        internal bool IsSetNodeFailureEvent() => this.NodeFailureEvent != null;

        /// <summary>
        /// Gets and sets the property NodeInputEvent. 
        /// <para>
        /// Contains information about the inputs provided to a specific node during execution.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive = true)]
        public NodeInputEvent NodeInputEvent { get; set; }

        /// <summary>
        /// Checks to see if the NodeInputEvent property is set.
        /// </summary>
        internal bool IsSetNodeInputEvent() => this.NodeInputEvent != null;

        /// <summary>
        /// Gets and sets the property NodeOutputEvent. 
        /// <para>
        /// Contains information about the outputs produced by a specific node during execution.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive = true)]
        public NodeOutputEvent NodeOutputEvent { get; set; }

        /// <summary>
        /// Checks to see if the NodeOutputEvent property is set.
        /// </summary>
        internal bool IsSetNodeOutputEvent() => this.NodeOutputEvent != null;
    }
}
