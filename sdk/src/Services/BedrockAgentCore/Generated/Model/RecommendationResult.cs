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
    /// The result of a recommendation, containing the optimized output.
    /// </summary>
    public partial class RecommendationResult
    {
        private SystemPromptRecommendationResult _systemPromptRecommendationResult;
        private ToolDescriptionRecommendationResult _toolDescriptionRecommendationResult;

        /// <summary>
        /// Gets and sets the property SystemPromptRecommendationResult. 
        /// <para>
        /// The result of a system prompt recommendation.
        /// </para>
        /// </summary>
        public SystemPromptRecommendationResult SystemPromptRecommendationResult
        {
            get { return this._systemPromptRecommendationResult; }
            set { this._systemPromptRecommendationResult = value; }
        }

        // Check to see if SystemPromptRecommendationResult property is set
        internal bool IsSetSystemPromptRecommendationResult()
        {
            return this._systemPromptRecommendationResult != null;
        }

        /// <summary>
        /// Gets and sets the property ToolDescriptionRecommendationResult. 
        /// <para>
        /// The result of a tool description recommendation.
        /// </para>
        /// </summary>
        public ToolDescriptionRecommendationResult ToolDescriptionRecommendationResult
        {
            get { return this._toolDescriptionRecommendationResult; }
            set { this._toolDescriptionRecommendationResult = value; }
        }

        // Check to see if ToolDescriptionRecommendationResult property is set
        internal bool IsSetToolDescriptionRecommendationResult()
        {
            return this._toolDescriptionRecommendationResult != null;
        }

    }
}