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
    /// Container for the parameters to the StartRecommendation operation.
    /// Starts a recommendation job that analyzes agent traces and generates optimization
    /// suggestions for system prompts or tool descriptions to improve agent performance.
    /// </summary>
    public partial class StartRecommendationRequest : AmazonBedrockAgentCoreRequest
    {
        private string _clientToken;
        private string _description;
        private string _name;
        private RecommendationConfig _recommendationConfig;
        private RecommendationType _type;

        /// <summary>
        /// Gets and sets the property ClientToken. 
        /// <para>
        /// A unique, case-sensitive identifier to ensure that the API request completes no more
        /// than one time. If this token matches a previous request, the service ignores the request,
        /// but does not return an error.
        /// </para>
        /// </summary>
        [AWSProperty(Min=33, Max=256)]
        public string ClientToken
        {
            get { return this._clientToken; }
            set { this._clientToken = value; }
        }

        // Check to see if ClientToken property is set
        internal bool IsSetClientToken()
        {
            return this._clientToken != null;
        }

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// The description of the recommendation.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=4096)]
        public string Description
        {
            get { return this._description; }
            set { this._description = value; }
        }

        // Check to see if Description property is set
        internal bool IsSetDescription()
        {
            return this._description != null;
        }

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the recommendation. Must be unique within your account.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=0, Max=100)]
        public string Name
        {
            get { return this._name; }
            set { this._name = value; }
        }

        // Check to see if Name property is set
        internal bool IsSetName()
        {
            return this._name != null;
        }

        /// <summary>
        /// Gets and sets the property RecommendationConfig. 
        /// <para>
        /// The configuration for the recommendation, including the input to optimize, agent traces
        /// to analyze, and evaluation settings.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public RecommendationConfig RecommendationConfig
        {
            get { return this._recommendationConfig; }
            set { this._recommendationConfig = value; }
        }

        // Check to see if RecommendationConfig property is set
        internal bool IsSetRecommendationConfig()
        {
            return this._recommendationConfig != null;
        }

        /// <summary>
        /// Gets and sets the property Type. 
        /// <para>
        /// The type of recommendation to generate. Valid values are <c>SYSTEM_PROMPT_RECOMMENDATION</c>
        /// for system prompt optimization or <c>TOOL_DESCRIPTION_RECOMMENDATION</c> for tool
        /// description optimization.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public RecommendationType Type
        {
            get { return this._type; }
            set { this._type = value; }
        }

        // Check to see if Type property is set
        internal bool IsSetType()
        {
            return this._type != null;
        }

    }
}