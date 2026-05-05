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
    /// The configuration for a recommendation, varying by recommendation type.
    /// </summary>
    public partial class RecommendationConfig
    {
        private SystemPromptRecommendationConfig _systemPromptRecommendationConfig;
        private ToolDescriptionRecommendationConfig _toolDescriptionRecommendationConfig;

        /// <summary>
        /// Gets and sets the property SystemPromptRecommendationConfig. 
        /// <para>
        /// The configuration for a system prompt recommendation.
        /// </para>
        /// </summary>
        public SystemPromptRecommendationConfig SystemPromptRecommendationConfig
        {
            get { return this._systemPromptRecommendationConfig; }
            set { this._systemPromptRecommendationConfig = value; }
        }

        // Check to see if SystemPromptRecommendationConfig property is set
        internal bool IsSetSystemPromptRecommendationConfig()
        {
            return this._systemPromptRecommendationConfig != null;
        }

        /// <summary>
        /// Gets and sets the property ToolDescriptionRecommendationConfig. 
        /// <para>
        /// The configuration for a tool description recommendation.
        /// </para>
        /// </summary>
        public ToolDescriptionRecommendationConfig ToolDescriptionRecommendationConfig
        {
            get { return this._toolDescriptionRecommendationConfig; }
            set { this._toolDescriptionRecommendationConfig = value; }
        }

        // Check to see if ToolDescriptionRecommendationConfig property is set
        internal bool IsSetToolDescriptionRecommendationConfig()
        {
            return this._toolDescriptionRecommendationConfig != null;
        }

    }
}