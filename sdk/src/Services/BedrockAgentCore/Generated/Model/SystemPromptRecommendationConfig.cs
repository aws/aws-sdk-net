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
    /// Configuration for generating system prompt optimization recommendations.
    /// </summary>
    public partial class SystemPromptRecommendationConfig
    {
        private AgentTracesConfig _agentTraces;
        private RecommendationEvaluationConfig _evaluationConfig;
        private SystemPromptConfig _systemPrompt;

        /// <summary>
        /// Gets and sets the property AgentTraces. 
        /// <para>
        /// The agent traces to analyze for generating recommendations.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public AgentTracesConfig AgentTraces
        {
            get { return this._agentTraces; }
            set { this._agentTraces = value; }
        }

        // Check to see if AgentTraces property is set
        internal bool IsSetAgentTraces()
        {
            return this._agentTraces != null;
        }

        /// <summary>
        /// Gets and sets the property EvaluationConfig. 
        /// <para>
        /// The evaluation configuration specifying which evaluator to use for assessing recommendation
        /// quality.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public RecommendationEvaluationConfig EvaluationConfig
        {
            get { return this._evaluationConfig; }
            set { this._evaluationConfig = value; }
        }

        // Check to see if EvaluationConfig property is set
        internal bool IsSetEvaluationConfig()
        {
            return this._evaluationConfig != null;
        }

        /// <summary>
        /// Gets and sets the property SystemPrompt. 
        /// <para>
        /// The current system prompt to optimize.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public SystemPromptConfig SystemPrompt
        {
            get { return this._systemPrompt; }
            set { this._systemPrompt = value; }
        }

        // Check to see if SystemPrompt property is set
        internal bool IsSetSystemPrompt()
        {
            return this._systemPrompt != null;
        }

    }
}