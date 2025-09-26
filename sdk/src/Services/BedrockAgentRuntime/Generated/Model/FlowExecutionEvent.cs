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
        private ConditionResultEvent _conditionResultEvent;
        private FlowFailureEvent _flowFailureEvent;
        private FlowExecutionInputEvent _flowInputEvent;
        private FlowExecutionOutputEvent _flowOutputEvent;
        private NodeActionEvent _nodeActionEvent;
        private NodeDependencyEvent _nodeDependencyEvent;
        private NodeFailureEvent _nodeFailureEvent;
        private NodeInputEvent _nodeInputEvent;
        private NodeOutputEvent _nodeOutputEvent;

        /// <summary>
        /// Gets and sets the property ConditionResultEvent. 
        /// <para>
        /// Contains information about a condition evaluation result during the flow execution.
        /// This event is generated when a condition node in the flow evaluates its conditions.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive=true)]
        public ConditionResultEvent ConditionResultEvent
        {
            get { return this._conditionResultEvent; }
            set { this._conditionResultEvent = value; }
        }

        // Check to see if ConditionResultEvent property is set
        internal bool IsSetConditionResultEvent()
        {
            return this._conditionResultEvent != null;
        }

        /// <summary>
        /// Gets and sets the property FlowFailureEvent. 
        /// <para>
        /// Contains information about a failure that occurred at the flow level during execution.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive=true)]
        public FlowFailureEvent FlowFailureEvent
        {
            get { return this._flowFailureEvent; }
            set { this._flowFailureEvent = value; }
        }

        // Check to see if FlowFailureEvent property is set
        internal bool IsSetFlowFailureEvent()
        {
            return this._flowFailureEvent != null;
        }

        /// <summary>
        /// Gets and sets the property FlowInputEvent. 
        /// <para>
        /// Contains information about the inputs provided to the flow at the start of execution.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive=true)]
        public FlowExecutionInputEvent FlowInputEvent
        {
            get { return this._flowInputEvent; }
            set { this._flowInputEvent = value; }
        }

        // Check to see if FlowInputEvent property is set
        internal bool IsSetFlowInputEvent()
        {
            return this._flowInputEvent != null;
        }

        /// <summary>
        /// Gets and sets the property FlowOutputEvent. 
        /// <para>
        /// Contains information about the outputs produced by the flow at the end of execution.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive=true)]
        public FlowExecutionOutputEvent FlowOutputEvent
        {
            get { return this._flowOutputEvent; }
            set { this._flowOutputEvent = value; }
        }

        // Check to see if FlowOutputEvent property is set
        internal bool IsSetFlowOutputEvent()
        {
            return this._flowOutputEvent != null;
        }

        /// <summary>
        /// Gets and sets the property NodeActionEvent. 
        /// <para>
        /// Contains information about an action (operation) called by a node during execution.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive=true)]
        public NodeActionEvent NodeActionEvent
        {
            get { return this._nodeActionEvent; }
            set { this._nodeActionEvent = value; }
        }

        // Check to see if NodeActionEvent property is set
        internal bool IsSetNodeActionEvent()
        {
            return this._nodeActionEvent != null;
        }

        /// <summary>
        /// Gets and sets the property NodeDependencyEvent. 
        /// <para>
        /// Contains information about an internal trace of a specific node during execution.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive=true)]
        public NodeDependencyEvent NodeDependencyEvent
        {
            get { return this._nodeDependencyEvent; }
            set { this._nodeDependencyEvent = value; }
        }

        // Check to see if NodeDependencyEvent property is set
        internal bool IsSetNodeDependencyEvent()
        {
            return this._nodeDependencyEvent != null;
        }

        /// <summary>
        /// Gets and sets the property NodeFailureEvent. 
        /// <para>
        /// Contains information about a failure that occurred at a specific node during execution.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive=true)]
        public NodeFailureEvent NodeFailureEvent
        {
            get { return this._nodeFailureEvent; }
            set { this._nodeFailureEvent = value; }
        }

        // Check to see if NodeFailureEvent property is set
        internal bool IsSetNodeFailureEvent()
        {
            return this._nodeFailureEvent != null;
        }

        /// <summary>
        /// Gets and sets the property NodeInputEvent. 
        /// <para>
        /// Contains information about the inputs provided to a specific node during execution.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive=true)]
        public NodeInputEvent NodeInputEvent
        {
            get { return this._nodeInputEvent; }
            set { this._nodeInputEvent = value; }
        }

        // Check to see if NodeInputEvent property is set
        internal bool IsSetNodeInputEvent()
        {
            return this._nodeInputEvent != null;
        }

        /// <summary>
        /// Gets and sets the property NodeOutputEvent. 
        /// <para>
        /// Contains information about the outputs produced by a specific node during execution.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive=true)]
        public NodeOutputEvent NodeOutputEvent
        {
            get { return this._nodeOutputEvent; }
            set { this._nodeOutputEvent = value; }
        }

        // Check to see if NodeOutputEvent property is set
        internal bool IsSetNodeOutputEvent()
        {
            return this._nodeOutputEvent != null;
        }

    }
}