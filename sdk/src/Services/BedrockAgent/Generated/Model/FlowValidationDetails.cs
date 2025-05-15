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
 * Do not modify this file. This file is generated from the bedrock-agent-2023-06-05.normal.json service model.
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
        private CyclicConnectionFlowValidationDetails _cyclicConnection;
        private DuplicateConditionExpressionFlowValidationDetails _duplicateConditionExpression;
        private DuplicateConnectionsFlowValidationDetails _duplicateConnections;
        private IncompatibleConnectionDataTypeFlowValidationDetails _incompatibleConnectionDataType;
        private InvalidLoopBoundaryFlowValidationDetails _invalidLoopBoundary;
        private LoopIncompatibleNodeTypeFlowValidationDetails _loopIncompatibleNodeType;
        private MalformedConditionExpressionFlowValidationDetails _malformedConditionExpression;
        private MalformedNodeInputExpressionFlowValidationDetails _malformedNodeInputExpression;
        private MismatchedNodeInputTypeFlowValidationDetails _mismatchedNodeInputType;
        private MismatchedNodeOutputTypeFlowValidationDetails _mismatchedNodeOutputType;
        private MissingConnectionConfigurationFlowValidationDetails _missingConnectionConfiguration;
        private MissingDefaultConditionFlowValidationDetails _missingDefaultCondition;
        private MissingEndingNodesFlowValidationDetails _missingEndingNodes;
        private MissingLoopControllerNodeFlowValidationDetails _missingLoopControllerNode;
        private MissingLoopInputNodeFlowValidationDetails _missingLoopInputNode;
        private MissingNodeConfigurationFlowValidationDetails _missingNodeConfiguration;
        private MissingNodeInputFlowValidationDetails _missingNodeInput;
        private MissingNodeOutputFlowValidationDetails _missingNodeOutput;
        private MissingStartingNodesFlowValidationDetails _missingStartingNodes;
        private MultipleLoopControllerNodesFlowValidationDetails _multipleLoopControllerNodes;
        private MultipleLoopInputNodesFlowValidationDetails _multipleLoopInputNodes;
        private MultipleNodeInputConnectionsFlowValidationDetails _multipleNodeInputConnections;
        private UnfulfilledNodeInputFlowValidationDetails _unfulfilledNodeInput;
        private UnknownConnectionConditionFlowValidationDetails _unknownConnectionCondition;
        private UnknownConnectionSourceFlowValidationDetails _unknownConnectionSource;
        private UnknownConnectionSourceOutputFlowValidationDetails _unknownConnectionSourceOutput;
        private UnknownConnectionTargetFlowValidationDetails _unknownConnectionTarget;
        private UnknownConnectionTargetInputFlowValidationDetails _unknownConnectionTargetInput;
        private UnknownNodeInputFlowValidationDetails _unknownNodeInput;
        private UnknownNodeOutputFlowValidationDetails _unknownNodeOutput;
        private UnreachableNodeFlowValidationDetails _unreachableNode;
        private UnsatisfiedConnectionConditionsFlowValidationDetails _unsatisfiedConnectionConditions;
        private UnspecifiedFlowValidationDetails _unspecified;

        /// <summary>
        /// Gets and sets the property CyclicConnection. 
        /// <para>
        /// Details about a cyclic connection in the flow.
        /// </para>
        /// </summary>
        public CyclicConnectionFlowValidationDetails CyclicConnection
        {
            get { return this._cyclicConnection; }
            set { this._cyclicConnection = value; }
        }

        // Check to see if CyclicConnection property is set
        internal bool IsSetCyclicConnection()
        {
            return this._cyclicConnection != null;
        }

        /// <summary>
        /// Gets and sets the property DuplicateConditionExpression. 
        /// <para>
        /// Details about duplicate condition expressions in a node.
        /// </para>
        /// </summary>
        public DuplicateConditionExpressionFlowValidationDetails DuplicateConditionExpression
        {
            get { return this._duplicateConditionExpression; }
            set { this._duplicateConditionExpression = value; }
        }

        // Check to see if DuplicateConditionExpression property is set
        internal bool IsSetDuplicateConditionExpression()
        {
            return this._duplicateConditionExpression != null;
        }

        /// <summary>
        /// Gets and sets the property DuplicateConnections. 
        /// <para>
        /// Details about duplicate connections between nodes.
        /// </para>
        /// </summary>
        public DuplicateConnectionsFlowValidationDetails DuplicateConnections
        {
            get { return this._duplicateConnections; }
            set { this._duplicateConnections = value; }
        }

        // Check to see if DuplicateConnections property is set
        internal bool IsSetDuplicateConnections()
        {
            return this._duplicateConnections != null;
        }

        /// <summary>
        /// Gets and sets the property IncompatibleConnectionDataType. 
        /// <para>
        /// Details about incompatible data types in a connection.
        /// </para>
        /// </summary>
        public IncompatibleConnectionDataTypeFlowValidationDetails IncompatibleConnectionDataType
        {
            get { return this._incompatibleConnectionDataType; }
            set { this._incompatibleConnectionDataType = value; }
        }

        // Check to see if IncompatibleConnectionDataType property is set
        internal bool IsSetIncompatibleConnectionDataType()
        {
            return this._incompatibleConnectionDataType != null;
        }

        /// <summary>
        /// Gets and sets the property InvalidLoopBoundary. 
        /// <para>
        /// Details about a flow that includes connections that violate loop boundary rules.
        /// </para>
        /// </summary>
        public InvalidLoopBoundaryFlowValidationDetails InvalidLoopBoundary
        {
            get { return this._invalidLoopBoundary; }
            set { this._invalidLoopBoundary = value; }
        }

        // Check to see if InvalidLoopBoundary property is set
        internal bool IsSetInvalidLoopBoundary()
        {
            return this._invalidLoopBoundary != null;
        }

        /// <summary>
        /// Gets and sets the property LoopIncompatibleNodeType. 
        /// <para>
        /// Details about a flow that includes incompatible node types in a DoWhile loop.
        /// </para>
        /// </summary>
        public LoopIncompatibleNodeTypeFlowValidationDetails LoopIncompatibleNodeType
        {
            get { return this._loopIncompatibleNodeType; }
            set { this._loopIncompatibleNodeType = value; }
        }

        // Check to see if LoopIncompatibleNodeType property is set
        internal bool IsSetLoopIncompatibleNodeType()
        {
            return this._loopIncompatibleNodeType != null;
        }

        /// <summary>
        /// Gets and sets the property MalformedConditionExpression. 
        /// <para>
        /// Details about a malformed condition expression in a node.
        /// </para>
        /// </summary>
        public MalformedConditionExpressionFlowValidationDetails MalformedConditionExpression
        {
            get { return this._malformedConditionExpression; }
            set { this._malformedConditionExpression = value; }
        }

        // Check to see if MalformedConditionExpression property is set
        internal bool IsSetMalformedConditionExpression()
        {
            return this._malformedConditionExpression != null;
        }

        /// <summary>
        /// Gets and sets the property MalformedNodeInputExpression. 
        /// <para>
        /// Details about a malformed input expression in a node.
        /// </para>
        /// </summary>
        public MalformedNodeInputExpressionFlowValidationDetails MalformedNodeInputExpression
        {
            get { return this._malformedNodeInputExpression; }
            set { this._malformedNodeInputExpression = value; }
        }

        // Check to see if MalformedNodeInputExpression property is set
        internal bool IsSetMalformedNodeInputExpression()
        {
            return this._malformedNodeInputExpression != null;
        }

        /// <summary>
        /// Gets and sets the property MismatchedNodeInputType. 
        /// <para>
        /// Details about mismatched input data types in a node.
        /// </para>
        /// </summary>
        public MismatchedNodeInputTypeFlowValidationDetails MismatchedNodeInputType
        {
            get { return this._mismatchedNodeInputType; }
            set { this._mismatchedNodeInputType = value; }
        }

        // Check to see if MismatchedNodeInputType property is set
        internal bool IsSetMismatchedNodeInputType()
        {
            return this._mismatchedNodeInputType != null;
        }

        /// <summary>
        /// Gets and sets the property MismatchedNodeOutputType. 
        /// <para>
        /// Details about mismatched output data types in a node.
        /// </para>
        /// </summary>
        public MismatchedNodeOutputTypeFlowValidationDetails MismatchedNodeOutputType
        {
            get { return this._mismatchedNodeOutputType; }
            set { this._mismatchedNodeOutputType = value; }
        }

        // Check to see if MismatchedNodeOutputType property is set
        internal bool IsSetMismatchedNodeOutputType()
        {
            return this._mismatchedNodeOutputType != null;
        }

        /// <summary>
        /// Gets and sets the property MissingConnectionConfiguration. 
        /// <para>
        /// Details about missing configuration for a connection.
        /// </para>
        /// </summary>
        public MissingConnectionConfigurationFlowValidationDetails MissingConnectionConfiguration
        {
            get { return this._missingConnectionConfiguration; }
            set { this._missingConnectionConfiguration = value; }
        }

        // Check to see if MissingConnectionConfiguration property is set
        internal bool IsSetMissingConnectionConfiguration()
        {
            return this._missingConnectionConfiguration != null;
        }

        /// <summary>
        /// Gets and sets the property MissingDefaultCondition. 
        /// <para>
        /// Details about a missing default condition in a conditional node.
        /// </para>
        /// </summary>
        public MissingDefaultConditionFlowValidationDetails MissingDefaultCondition
        {
            get { return this._missingDefaultCondition; }
            set { this._missingDefaultCondition = value; }
        }

        // Check to see if MissingDefaultCondition property is set
        internal bool IsSetMissingDefaultCondition()
        {
            return this._missingDefaultCondition != null;
        }

        /// <summary>
        /// Gets and sets the property MissingEndingNodes. 
        /// <para>
        /// Details about missing ending nodes in the flow.
        /// </para>
        /// </summary>
        public MissingEndingNodesFlowValidationDetails MissingEndingNodes
        {
            get { return this._missingEndingNodes; }
            set { this._missingEndingNodes = value; }
        }

        // Check to see if MissingEndingNodes property is set
        internal bool IsSetMissingEndingNodes()
        {
            return this._missingEndingNodes != null;
        }

        /// <summary>
        /// Gets and sets the property MissingLoopControllerNode. 
        /// <para>
        /// Details about a flow that's missing a required <c>LoopController</c> node in a DoWhile
        /// loop.
        /// </para>
        /// </summary>
        public MissingLoopControllerNodeFlowValidationDetails MissingLoopControllerNode
        {
            get { return this._missingLoopControllerNode; }
            set { this._missingLoopControllerNode = value; }
        }

        // Check to see if MissingLoopControllerNode property is set
        internal bool IsSetMissingLoopControllerNode()
        {
            return this._missingLoopControllerNode != null;
        }

        /// <summary>
        /// Gets and sets the property MissingLoopInputNode. 
        /// <para>
        /// Details about a flow that's missing a required <c>LoopInput</c> node in a DoWhile
        /// loop.
        /// </para>
        /// </summary>
        public MissingLoopInputNodeFlowValidationDetails MissingLoopInputNode
        {
            get { return this._missingLoopInputNode; }
            set { this._missingLoopInputNode = value; }
        }

        // Check to see if MissingLoopInputNode property is set
        internal bool IsSetMissingLoopInputNode()
        {
            return this._missingLoopInputNode != null;
        }

        /// <summary>
        /// Gets and sets the property MissingNodeConfiguration. 
        /// <para>
        /// Details about missing configuration for a node.
        /// </para>
        /// </summary>
        public MissingNodeConfigurationFlowValidationDetails MissingNodeConfiguration
        {
            get { return this._missingNodeConfiguration; }
            set { this._missingNodeConfiguration = value; }
        }

        // Check to see if MissingNodeConfiguration property is set
        internal bool IsSetMissingNodeConfiguration()
        {
            return this._missingNodeConfiguration != null;
        }

        /// <summary>
        /// Gets and sets the property MissingNodeInput. 
        /// <para>
        /// Details about a missing required input in a node.
        /// </para>
        /// </summary>
        public MissingNodeInputFlowValidationDetails MissingNodeInput
        {
            get { return this._missingNodeInput; }
            set { this._missingNodeInput = value; }
        }

        // Check to see if MissingNodeInput property is set
        internal bool IsSetMissingNodeInput()
        {
            return this._missingNodeInput != null;
        }

        /// <summary>
        /// Gets and sets the property MissingNodeOutput. 
        /// <para>
        /// Details about a missing required output in a node.
        /// </para>
        /// </summary>
        public MissingNodeOutputFlowValidationDetails MissingNodeOutput
        {
            get { return this._missingNodeOutput; }
            set { this._missingNodeOutput = value; }
        }

        // Check to see if MissingNodeOutput property is set
        internal bool IsSetMissingNodeOutput()
        {
            return this._missingNodeOutput != null;
        }

        /// <summary>
        /// Gets and sets the property MissingStartingNodes. 
        /// <para>
        /// Details about missing starting nodes in the flow.
        /// </para>
        /// </summary>
        public MissingStartingNodesFlowValidationDetails MissingStartingNodes
        {
            get { return this._missingStartingNodes; }
            set { this._missingStartingNodes = value; }
        }

        // Check to see if MissingStartingNodes property is set
        internal bool IsSetMissingStartingNodes()
        {
            return this._missingStartingNodes != null;
        }

        /// <summary>
        /// Gets and sets the property MultipleLoopControllerNodes. 
        /// <para>
        /// Details about a flow that contains multiple <c>LoopController</c> nodes in a DoWhile
        /// loop.
        /// </para>
        /// </summary>
        public MultipleLoopControllerNodesFlowValidationDetails MultipleLoopControllerNodes
        {
            get { return this._multipleLoopControllerNodes; }
            set { this._multipleLoopControllerNodes = value; }
        }

        // Check to see if MultipleLoopControllerNodes property is set
        internal bool IsSetMultipleLoopControllerNodes()
        {
            return this._multipleLoopControllerNodes != null;
        }

        /// <summary>
        /// Gets and sets the property MultipleLoopInputNodes. 
        /// <para>
        /// Details about a flow that contains multiple <c>LoopInput</c> nodes in a DoWhile loop.
        /// </para>
        /// </summary>
        public MultipleLoopInputNodesFlowValidationDetails MultipleLoopInputNodes
        {
            get { return this._multipleLoopInputNodes; }
            set { this._multipleLoopInputNodes = value; }
        }

        // Check to see if MultipleLoopInputNodes property is set
        internal bool IsSetMultipleLoopInputNodes()
        {
            return this._multipleLoopInputNodes != null;
        }

        /// <summary>
        /// Gets and sets the property MultipleNodeInputConnections. 
        /// <para>
        /// Details about multiple connections to a single node input.
        /// </para>
        /// </summary>
        public MultipleNodeInputConnectionsFlowValidationDetails MultipleNodeInputConnections
        {
            get { return this._multipleNodeInputConnections; }
            set { this._multipleNodeInputConnections = value; }
        }

        // Check to see if MultipleNodeInputConnections property is set
        internal bool IsSetMultipleNodeInputConnections()
        {
            return this._multipleNodeInputConnections != null;
        }

        /// <summary>
        /// Gets and sets the property UnfulfilledNodeInput. 
        /// <para>
        /// Details about an unfulfilled node input with no valid connections.
        /// </para>
        /// </summary>
        public UnfulfilledNodeInputFlowValidationDetails UnfulfilledNodeInput
        {
            get { return this._unfulfilledNodeInput; }
            set { this._unfulfilledNodeInput = value; }
        }

        // Check to see if UnfulfilledNodeInput property is set
        internal bool IsSetUnfulfilledNodeInput()
        {
            return this._unfulfilledNodeInput != null;
        }

        /// <summary>
        /// Gets and sets the property UnknownConnectionCondition. 
        /// <para>
        /// Details about an unknown condition for a connection.
        /// </para>
        /// </summary>
        public UnknownConnectionConditionFlowValidationDetails UnknownConnectionCondition
        {
            get { return this._unknownConnectionCondition; }
            set { this._unknownConnectionCondition = value; }
        }

        // Check to see if UnknownConnectionCondition property is set
        internal bool IsSetUnknownConnectionCondition()
        {
            return this._unknownConnectionCondition != null;
        }

        /// <summary>
        /// Gets and sets the property UnknownConnectionSource. 
        /// <para>
        /// Details about an unknown source node for a connection.
        /// </para>
        /// </summary>
        public UnknownConnectionSourceFlowValidationDetails UnknownConnectionSource
        {
            get { return this._unknownConnectionSource; }
            set { this._unknownConnectionSource = value; }
        }

        // Check to see if UnknownConnectionSource property is set
        internal bool IsSetUnknownConnectionSource()
        {
            return this._unknownConnectionSource != null;
        }

        /// <summary>
        /// Gets and sets the property UnknownConnectionSourceOutput. 
        /// <para>
        /// Details about an unknown source output for a connection.
        /// </para>
        /// </summary>
        public UnknownConnectionSourceOutputFlowValidationDetails UnknownConnectionSourceOutput
        {
            get { return this._unknownConnectionSourceOutput; }
            set { this._unknownConnectionSourceOutput = value; }
        }

        // Check to see if UnknownConnectionSourceOutput property is set
        internal bool IsSetUnknownConnectionSourceOutput()
        {
            return this._unknownConnectionSourceOutput != null;
        }

        /// <summary>
        /// Gets and sets the property UnknownConnectionTarget. 
        /// <para>
        /// Details about an unknown target node for a connection.
        /// </para>
        /// </summary>
        public UnknownConnectionTargetFlowValidationDetails UnknownConnectionTarget
        {
            get { return this._unknownConnectionTarget; }
            set { this._unknownConnectionTarget = value; }
        }

        // Check to see if UnknownConnectionTarget property is set
        internal bool IsSetUnknownConnectionTarget()
        {
            return this._unknownConnectionTarget != null;
        }

        /// <summary>
        /// Gets and sets the property UnknownConnectionTargetInput. 
        /// <para>
        /// Details about an unknown target input for a connection.
        /// </para>
        /// </summary>
        public UnknownConnectionTargetInputFlowValidationDetails UnknownConnectionTargetInput
        {
            get { return this._unknownConnectionTargetInput; }
            set { this._unknownConnectionTargetInput = value; }
        }

        // Check to see if UnknownConnectionTargetInput property is set
        internal bool IsSetUnknownConnectionTargetInput()
        {
            return this._unknownConnectionTargetInput != null;
        }

        /// <summary>
        /// Gets and sets the property UnknownNodeInput. 
        /// <para>
        /// Details about an unknown input for a node.
        /// </para>
        /// </summary>
        public UnknownNodeInputFlowValidationDetails UnknownNodeInput
        {
            get { return this._unknownNodeInput; }
            set { this._unknownNodeInput = value; }
        }

        // Check to see if UnknownNodeInput property is set
        internal bool IsSetUnknownNodeInput()
        {
            return this._unknownNodeInput != null;
        }

        /// <summary>
        /// Gets and sets the property UnknownNodeOutput. 
        /// <para>
        /// Details about an unknown output for a node.
        /// </para>
        /// </summary>
        public UnknownNodeOutputFlowValidationDetails UnknownNodeOutput
        {
            get { return this._unknownNodeOutput; }
            set { this._unknownNodeOutput = value; }
        }

        // Check to see if UnknownNodeOutput property is set
        internal bool IsSetUnknownNodeOutput()
        {
            return this._unknownNodeOutput != null;
        }

        /// <summary>
        /// Gets and sets the property UnreachableNode. 
        /// <para>
        /// Details about an unreachable node in the flow.
        /// </para>
        /// </summary>
        public UnreachableNodeFlowValidationDetails UnreachableNode
        {
            get { return this._unreachableNode; }
            set { this._unreachableNode = value; }
        }

        // Check to see if UnreachableNode property is set
        internal bool IsSetUnreachableNode()
        {
            return this._unreachableNode != null;
        }

        /// <summary>
        /// Gets and sets the property UnsatisfiedConnectionConditions. 
        /// <para>
        /// Details about unsatisfied conditions for a connection.
        /// </para>
        /// </summary>
        public UnsatisfiedConnectionConditionsFlowValidationDetails UnsatisfiedConnectionConditions
        {
            get { return this._unsatisfiedConnectionConditions; }
            set { this._unsatisfiedConnectionConditions = value; }
        }

        // Check to see if UnsatisfiedConnectionConditions property is set
        internal bool IsSetUnsatisfiedConnectionConditions()
        {
            return this._unsatisfiedConnectionConditions != null;
        }

        /// <summary>
        /// Gets and sets the property Unspecified. 
        /// <para>
        /// Details about an unspecified validation.
        /// </para>
        /// </summary>
        public UnspecifiedFlowValidationDetails Unspecified
        {
            get { return this._unspecified; }
            set { this._unspecified = value; }
        }

        // Check to see if Unspecified property is set
        internal bool IsSetUnspecified()
        {
            return this._unspecified != null;
        }

    }
}