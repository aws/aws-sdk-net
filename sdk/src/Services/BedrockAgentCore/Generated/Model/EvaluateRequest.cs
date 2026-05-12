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
 * Do not modify this file. This file is generated from the bedrock-agentcore-2024-02-28.normal.json service model.
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
    /// Container for the parameters to the Evaluate operation.
    /// Performs on-demand evaluation of agent traces using a specified evaluator. This synchronous
    /// API accepts traces in OpenTelemetry format and returns immediate scoring results with
    /// detailed explanations.
    /// </summary>
    public partial class EvaluateRequest : AmazonBedrockAgentCoreRequest
    {
        private EvaluationInput _evaluationInput;
        private List<EvaluationReferenceInput> _evaluationReferenceInputs = AWSConfigs.InitializeCollections ? new List<EvaluationReferenceInput>() : null;
        private EvaluationTarget _evaluationTarget;
        private string _evaluatorId;

        /// <summary>
        /// Gets and sets the property EvaluationInput. 
        /// <para>
        ///  The input data containing agent session spans to be evaluated. Includes a list of
        /// spans in OpenTelemetry format from supported frameworks like Strands (AgentCore Runtime)
        /// or LangGraph with OpenInference instrumentation. 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public EvaluationInput EvaluationInput
        {
            get { return this._evaluationInput; }
            set { this._evaluationInput = value; }
        }

        // Check to see if EvaluationInput property is set
        internal bool IsSetEvaluationInput()
        {
            return this._evaluationInput != null;
        }

        /// <summary>
        /// Gets and sets the property EvaluationReferenceInputs. 
        /// <para>
        ///  Ground truth data to compare against agent responses during evaluation. Allows to
        /// provide expected responses, assertions, and expected tool trajectories at different
        /// evaluation levels. Session-level reference inputs apply to the entire conversation,
        /// while trace-level reference inputs target specific request-response interactions identified
        /// by trace ID. 
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Sensitive=true, Min=1, Max=1000)]
        public List<EvaluationReferenceInput> EvaluationReferenceInputs
        {
            get { return this._evaluationReferenceInputs; }
            set { this._evaluationReferenceInputs = value; }
        }

        // Check to see if EvaluationReferenceInputs property is set
        internal bool IsSetEvaluationReferenceInputs()
        {
            return this._evaluationReferenceInputs != null && (this._evaluationReferenceInputs.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property EvaluationTarget. 
        /// <para>
        ///  The specific trace or span IDs to evaluate within the provided input. Allows targeting
        /// evaluation at different levels: individual tool calls, single request-response interactions
        /// (traces), or entire conversation sessions. 
        /// </para>
        /// </summary>
        public EvaluationTarget EvaluationTarget
        {
            get { return this._evaluationTarget; }
            set { this._evaluationTarget = value; }
        }

        // Check to see if EvaluationTarget property is set
        internal bool IsSetEvaluationTarget()
        {
            return this._evaluationTarget != null;
        }

        /// <summary>
        /// Gets and sets the property EvaluatorId. 
        /// <para>
        ///  The unique identifier of the evaluator to use for scoring. Can be a built-in evaluator
        /// (e.g., <c>Builtin.Helpfulness</c>, <c>Builtin.Correctness</c>) or a custom evaluator
        /// Id created through the control plane API. 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string EvaluatorId
        {
            get { return this._evaluatorId; }
            set { this._evaluatorId = value; }
        }

        // Check to see if EvaluatorId property is set
        internal bool IsSetEvaluatorId()
        {
            return this._evaluatorId != null;
        }

    }
}