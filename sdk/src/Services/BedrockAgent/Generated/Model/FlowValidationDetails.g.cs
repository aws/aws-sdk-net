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

namespace Amazon.BedrockAgent.Model
{
    /// <summary>
    /// A union type containing various possible validation issues in the flow.
    /// </summary>
    public partial class FlowValidationDetails
    {
        /// <summary>
        /// Gets and sets the property CyclicConnection. 
        /// <para>
        /// Details about a cyclic connection in the flow.
        /// </para>
        /// </summary>
        public CyclicConnectionFlowValidationDetails CyclicConnection { get; set; }

        /// <summary>
        /// Checks to see if the CyclicConnection property is set.
        /// </summary>
        internal bool IsSetCyclicConnection() => this.CyclicConnection != null;

        /// <summary>
        /// Gets and sets the property DuplicateConditionExpression. 
        /// <para>
        /// Details about duplicate condition expressions in a node.
        /// </para>
        /// </summary>
        public DuplicateConditionExpressionFlowValidationDetails DuplicateConditionExpression { get; set; }

        /// <summary>
        /// Checks to see if the DuplicateConditionExpression property is set.
        /// </summary>
        internal bool IsSetDuplicateConditionExpression() => this.DuplicateConditionExpression != null;

        /// <summary>
        /// Gets and sets the property DuplicateConnections. 
        /// <para>
        /// Details about duplicate connections between nodes.
        /// </para>
        /// </summary>
        public DuplicateConnectionsFlowValidationDetails DuplicateConnections { get; set; }

        /// <summary>
        /// Checks to see if the DuplicateConnections property is set.
        /// </summary>
        internal bool IsSetDuplicateConnections() => this.DuplicateConnections != null;

        /// <summary>
        /// Gets and sets the property IncompatibleConnectionDataType. 
        /// <para>
        /// Details about incompatible data types in a connection.
        /// </para>
        /// </summary>
        public IncompatibleConnectionDataTypeFlowValidationDetails IncompatibleConnectionDataType { get; set; }

        /// <summary>
        /// Checks to see if the IncompatibleConnectionDataType property is set.
        /// </summary>
        internal bool IsSetIncompatibleConnectionDataType() => this.IncompatibleConnectionDataType != null;

        /// <summary>
        /// Gets and sets the property InvalidLoopBoundary. 
        /// <para>
        /// Details about a flow that includes connections that violate loop boundary rules.
        /// </para>
        /// </summary>
        public InvalidLoopBoundaryFlowValidationDetails InvalidLoopBoundary { get; set; }

        /// <summary>
        /// Checks to see if the InvalidLoopBoundary property is set.
        /// </summary>
        internal bool IsSetInvalidLoopBoundary() => this.InvalidLoopBoundary != null;

        /// <summary>
        /// Gets and sets the property LoopIncompatibleNodeType. 
        /// <para>
        /// Details about a flow that includes incompatible node types in a DoWhile loop.
        /// </para>
        /// </summary>
        public LoopIncompatibleNodeTypeFlowValidationDetails LoopIncompatibleNodeType { get; set; }

        /// <summary>
        /// Checks to see if the LoopIncompatibleNodeType property is set.
        /// </summary>
        internal bool IsSetLoopIncompatibleNodeType() => this.LoopIncompatibleNodeType != null;

        /// <summary>
        /// Gets and sets the property MalformedConditionExpression. 
        /// <para>
        /// Details about a malformed condition expression in a node.
        /// </para>
        /// </summary>
        public MalformedConditionExpressionFlowValidationDetails MalformedConditionExpression { get; set; }

        /// <summary>
        /// Checks to see if the MalformedConditionExpression property is set.
        /// </summary>
        internal bool IsSetMalformedConditionExpression() => this.MalformedConditionExpression != null;

        /// <summary>
        /// Gets and sets the property MalformedNodeInputExpression. 
        /// <para>
        /// Details about a malformed input expression in a node.
        /// </para>
        /// </summary>
        public MalformedNodeInputExpressionFlowValidationDetails MalformedNodeInputExpression { get; set; }

        /// <summary>
        /// Checks to see if the MalformedNodeInputExpression property is set.
        /// </summary>
        internal bool IsSetMalformedNodeInputExpression() => this.MalformedNodeInputExpression != null;

        /// <summary>
        /// Gets and sets the property MismatchedNodeInputType. 
        /// <para>
        /// Details about mismatched input data types in a node.
        /// </para>
        /// </summary>
        public MismatchedNodeInputTypeFlowValidationDetails MismatchedNodeInputType { get; set; }

        /// <summary>
        /// Checks to see if the MismatchedNodeInputType property is set.
        /// </summary>
        internal bool IsSetMismatchedNodeInputType() => this.MismatchedNodeInputType != null;

        /// <summary>
        /// Gets and sets the property MismatchedNodeOutputType. 
        /// <para>
        /// Details about mismatched output data types in a node.
        /// </para>
        /// </summary>
        public MismatchedNodeOutputTypeFlowValidationDetails MismatchedNodeOutputType { get; set; }

        /// <summary>
        /// Checks to see if the MismatchedNodeOutputType property is set.
        /// </summary>
        internal bool IsSetMismatchedNodeOutputType() => this.MismatchedNodeOutputType != null;

        /// <summary>
        /// Gets and sets the property MissingConnectionConfiguration. 
        /// <para>
        /// Details about missing configuration for a connection.
        /// </para>
        /// </summary>
        public MissingConnectionConfigurationFlowValidationDetails MissingConnectionConfiguration { get; set; }

        /// <summary>
        /// Checks to see if the MissingConnectionConfiguration property is set.
        /// </summary>
        internal bool IsSetMissingConnectionConfiguration() => this.MissingConnectionConfiguration != null;

        /// <summary>
        /// Gets and sets the property MissingDefaultCondition. 
        /// <para>
        /// Details about a missing default condition in a conditional node.
        /// </para>
        /// </summary>
        public MissingDefaultConditionFlowValidationDetails MissingDefaultCondition { get; set; }

        /// <summary>
        /// Checks to see if the MissingDefaultCondition property is set.
        /// </summary>
        internal bool IsSetMissingDefaultCondition() => this.MissingDefaultCondition != null;

        /// <summary>
        /// Gets and sets the property MissingEndingNodes. 
        /// <para>
        /// Details about missing ending nodes in the flow.
        /// </para>
        /// </summary>
        public MissingEndingNodesFlowValidationDetails MissingEndingNodes { get; set; }

        /// <summary>
        /// Checks to see if the MissingEndingNodes property is set.
        /// </summary>
        internal bool IsSetMissingEndingNodes() => this.MissingEndingNodes != null;

        /// <summary>
        /// Gets and sets the property MissingLoopControllerNode. 
        /// <para>
        /// Details about a flow that's missing a required <c>LoopController</c> node in a DoWhile
        /// loop.
        /// </para>
        /// </summary>
        public MissingLoopControllerNodeFlowValidationDetails MissingLoopControllerNode { get; set; }

        /// <summary>
        /// Checks to see if the MissingLoopControllerNode property is set.
        /// </summary>
        internal bool IsSetMissingLoopControllerNode() => this.MissingLoopControllerNode != null;

        /// <summary>
        /// Gets and sets the property MissingLoopInputNode. 
        /// <para>
        /// Details about a flow that's missing a required <c>LoopInput</c> node in a DoWhile
        /// loop.
        /// </para>
        /// </summary>
        public MissingLoopInputNodeFlowValidationDetails MissingLoopInputNode { get; set; }

        /// <summary>
        /// Checks to see if the MissingLoopInputNode property is set.
        /// </summary>
        internal bool IsSetMissingLoopInputNode() => this.MissingLoopInputNode != null;

        /// <summary>
        /// Gets and sets the property MissingNodeConfiguration. 
        /// <para>
        /// Details about missing configuration for a node.
        /// </para>
        /// </summary>
        public MissingNodeConfigurationFlowValidationDetails MissingNodeConfiguration { get; set; }

        /// <summary>
        /// Checks to see if the MissingNodeConfiguration property is set.
        /// </summary>
        internal bool IsSetMissingNodeConfiguration() => this.MissingNodeConfiguration != null;

        /// <summary>
        /// Gets and sets the property MissingNodeInput. 
        /// <para>
        /// Details about a missing required input in a node.
        /// </para>
        /// </summary>
        public MissingNodeInputFlowValidationDetails MissingNodeInput { get; set; }

        /// <summary>
        /// Checks to see if the MissingNodeInput property is set.
        /// </summary>
        internal bool IsSetMissingNodeInput() => this.MissingNodeInput != null;

        /// <summary>
        /// Gets and sets the property MissingNodeOutput. 
        /// <para>
        /// Details about a missing required output in a node.
        /// </para>
        /// </summary>
        public MissingNodeOutputFlowValidationDetails MissingNodeOutput { get; set; }

        /// <summary>
        /// Checks to see if the MissingNodeOutput property is set.
        /// </summary>
        internal bool IsSetMissingNodeOutput() => this.MissingNodeOutput != null;

        /// <summary>
        /// Gets and sets the property MissingStartingNodes. 
        /// <para>
        /// Details about missing starting nodes in the flow.
        /// </para>
        /// </summary>
        public MissingStartingNodesFlowValidationDetails MissingStartingNodes { get; set; }

        /// <summary>
        /// Checks to see if the MissingStartingNodes property is set.
        /// </summary>
        internal bool IsSetMissingStartingNodes() => this.MissingStartingNodes != null;

        /// <summary>
        /// Gets and sets the property MultipleLoopControllerNodes. 
        /// <para>
        /// Details about a flow that contains multiple <c>LoopController</c> nodes in a DoWhile
        /// loop.
        /// </para>
        /// </summary>
        public MultipleLoopControllerNodesFlowValidationDetails MultipleLoopControllerNodes { get; set; }

        /// <summary>
        /// Checks to see if the MultipleLoopControllerNodes property is set.
        /// </summary>
        internal bool IsSetMultipleLoopControllerNodes() => this.MultipleLoopControllerNodes != null;

        /// <summary>
        /// Gets and sets the property MultipleLoopInputNodes. 
        /// <para>
        /// Details about a flow that contains multiple <c>LoopInput</c> nodes in a DoWhile loop.
        /// </para>
        /// </summary>
        public MultipleLoopInputNodesFlowValidationDetails MultipleLoopInputNodes { get; set; }

        /// <summary>
        /// Checks to see if the MultipleLoopInputNodes property is set.
        /// </summary>
        internal bool IsSetMultipleLoopInputNodes() => this.MultipleLoopInputNodes != null;

        /// <summary>
        /// Gets and sets the property MultipleNodeInputConnections. 
        /// <para>
        /// Details about multiple connections to a single node input.
        /// </para>
        /// </summary>
        public MultipleNodeInputConnectionsFlowValidationDetails MultipleNodeInputConnections { get; set; }

        /// <summary>
        /// Checks to see if the MultipleNodeInputConnections property is set.
        /// </summary>
        internal bool IsSetMultipleNodeInputConnections() => this.MultipleNodeInputConnections != null;

        /// <summary>
        /// Gets and sets the property UnfulfilledNodeInput. 
        /// <para>
        /// Details about an unfulfilled node input with no valid connections.
        /// </para>
        /// </summary>
        public UnfulfilledNodeInputFlowValidationDetails UnfulfilledNodeInput { get; set; }

        /// <summary>
        /// Checks to see if the UnfulfilledNodeInput property is set.
        /// </summary>
        internal bool IsSetUnfulfilledNodeInput() => this.UnfulfilledNodeInput != null;

        /// <summary>
        /// Gets and sets the property UnknownConnectionCondition. 
        /// <para>
        /// Details about an unknown condition for a connection.
        /// </para>
        /// </summary>
        public UnknownConnectionConditionFlowValidationDetails UnknownConnectionCondition { get; set; }

        /// <summary>
        /// Checks to see if the UnknownConnectionCondition property is set.
        /// </summary>
        internal bool IsSetUnknownConnectionCondition() => this.UnknownConnectionCondition != null;

        /// <summary>
        /// Gets and sets the property UnknownConnectionSource. 
        /// <para>
        /// Details about an unknown source node for a connection.
        /// </para>
        /// </summary>
        public UnknownConnectionSourceFlowValidationDetails UnknownConnectionSource { get; set; }

        /// <summary>
        /// Checks to see if the UnknownConnectionSource property is set.
        /// </summary>
        internal bool IsSetUnknownConnectionSource() => this.UnknownConnectionSource != null;

        /// <summary>
        /// Gets and sets the property UnknownConnectionSourceOutput. 
        /// <para>
        /// Details about an unknown source output for a connection.
        /// </para>
        /// </summary>
        public UnknownConnectionSourceOutputFlowValidationDetails UnknownConnectionSourceOutput { get; set; }

        /// <summary>
        /// Checks to see if the UnknownConnectionSourceOutput property is set.
        /// </summary>
        internal bool IsSetUnknownConnectionSourceOutput() => this.UnknownConnectionSourceOutput != null;

        /// <summary>
        /// Gets and sets the property UnknownConnectionTarget. 
        /// <para>
        /// Details about an unknown target node for a connection.
        /// </para>
        /// </summary>
        public UnknownConnectionTargetFlowValidationDetails UnknownConnectionTarget { get; set; }

        /// <summary>
        /// Checks to see if the UnknownConnectionTarget property is set.
        /// </summary>
        internal bool IsSetUnknownConnectionTarget() => this.UnknownConnectionTarget != null;

        /// <summary>
        /// Gets and sets the property UnknownConnectionTargetInput. 
        /// <para>
        /// Details about an unknown target input for a connection.
        /// </para>
        /// </summary>
        public UnknownConnectionTargetInputFlowValidationDetails UnknownConnectionTargetInput { get; set; }

        /// <summary>
        /// Checks to see if the UnknownConnectionTargetInput property is set.
        /// </summary>
        internal bool IsSetUnknownConnectionTargetInput() => this.UnknownConnectionTargetInput != null;

        /// <summary>
        /// Gets and sets the property UnknownNodeInput. 
        /// <para>
        /// Details about an unknown input for a node.
        /// </para>
        /// </summary>
        public UnknownNodeInputFlowValidationDetails UnknownNodeInput { get; set; }

        /// <summary>
        /// Checks to see if the UnknownNodeInput property is set.
        /// </summary>
        internal bool IsSetUnknownNodeInput() => this.UnknownNodeInput != null;

        /// <summary>
        /// Gets and sets the property UnknownNodeOutput. 
        /// <para>
        /// Details about an unknown output for a node.
        /// </para>
        /// </summary>
        public UnknownNodeOutputFlowValidationDetails UnknownNodeOutput { get; set; }

        /// <summary>
        /// Checks to see if the UnknownNodeOutput property is set.
        /// </summary>
        internal bool IsSetUnknownNodeOutput() => this.UnknownNodeOutput != null;

        /// <summary>
        /// Gets and sets the property UnreachableNode. 
        /// <para>
        /// Details about an unreachable node in the flow.
        /// </para>
        /// </summary>
        public UnreachableNodeFlowValidationDetails UnreachableNode { get; set; }

        /// <summary>
        /// Checks to see if the UnreachableNode property is set.
        /// </summary>
        internal bool IsSetUnreachableNode() => this.UnreachableNode != null;

        /// <summary>
        /// Gets and sets the property UnsatisfiedConnectionConditions. 
        /// <para>
        /// Details about unsatisfied conditions for a connection.
        /// </para>
        /// </summary>
        public UnsatisfiedConnectionConditionsFlowValidationDetails UnsatisfiedConnectionConditions { get; set; }

        /// <summary>
        /// Checks to see if the UnsatisfiedConnectionConditions property is set.
        /// </summary>
        internal bool IsSetUnsatisfiedConnectionConditions() => this.UnsatisfiedConnectionConditions != null;

        /// <summary>
        /// Gets and sets the property Unspecified. 
        /// <para>
        /// Details about an unspecified validation.
        /// </para>
        /// </summary>
        public UnspecifiedFlowValidationDetails Unspecified { get; set; }

        /// <summary>
        /// Checks to see if the Unspecified property is set.
        /// </summary>
        internal bool IsSetUnspecified() => this.Unspecified != null;
    }
}
