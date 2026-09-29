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

namespace Amazon.BedrockAgentCore.Model
{
    /// <summary>
    /// Configuration for generating system prompt optimization recommendations.
    /// </summary>
    public partial class SystemPromptRecommendationConfig
    {
        /// <summary>
        /// Gets and sets the property AgentTraces. 
        /// <para>
        /// The agent traces to analyze for generating recommendations.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public AgentTracesConfig AgentTraces { get; set; }

        /// <summary>
        /// Checks to see if the AgentTraces property is set.
        /// </summary>
        internal bool IsSetAgentTraces() => this.AgentTraces != null;

        /// <summary>
        /// Gets and sets the property EvaluationConfig. 
        /// <para>
        /// The evaluation configuration specifying which evaluator to use for assessing recommendation
        /// quality.
        /// </para>
        /// </summary>
        public RecommendationEvaluationConfig EvaluationConfig { get; set; }

        /// <summary>
        /// Checks to see if the EvaluationConfig property is set.
        /// </summary>
        internal bool IsSetEvaluationConfig() => this.EvaluationConfig != null;

        /// <summary>
        /// Gets and sets the property SystemPrompt. 
        /// <para>
        /// The current system prompt to optimize.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public SystemPromptConfig SystemPrompt { get; set; }

        /// <summary>
        /// Checks to see if the SystemPrompt property is set.
        /// </summary>
        internal bool IsSetSystemPrompt() => this.SystemPrompt != null;
    }
}
