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
 * Do not modify this file. This file is generated from the bedrock-agentcore-control-2023-06-05.normal.json service model.
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
namespace Amazon.BedrockAgentCoreControl.Model
{
    /// <summary>
    /// Configuration for an OpenAI model provider. Requires an API key stored in AgentCore
    /// Identity.
    /// </summary>
    public partial class HarnessOpenAiModelConfig
    {
        private string _apiKeyArn;
        private int? _maxTokens;
        private string _modelId;
        private float? _temperature;
        private float? _topp;

        /// <summary>
        /// Gets and sets the property ApiKeyArn. 
        /// <para>
        /// The ARN of your OpenAI API key on AgentCore Identity.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string ApiKeyArn
        {
            get { return this._apiKeyArn; }
            set { this._apiKeyArn = value; }
        }

        // Check to see if ApiKeyArn property is set
        internal bool IsSetApiKeyArn()
        {
            return this._apiKeyArn != null;
        }

        /// <summary>
        /// Gets and sets the property MaxTokens. 
        /// <para>
        /// The maximum number of tokens to allow in the generated response per iteration.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1)]
        public int? MaxTokens
        {
            get { return this._maxTokens; }
            set { this._maxTokens = value; }
        }

        // Check to see if MaxTokens property is set
        internal bool IsSetMaxTokens()
        {
            return this._maxTokens.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property ModelId. 
        /// <para>
        /// The OpenAI model ID.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string ModelId
        {
            get { return this._modelId; }
            set { this._modelId = value; }
        }

        // Check to see if ModelId property is set
        internal bool IsSetModelId()
        {
            return this._modelId != null;
        }

        /// <summary>
        /// Gets and sets the property Temperature. 
        /// <para>
        /// The temperature to set when calling the model.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=2)]
        public float? Temperature
        {
            get { return this._temperature; }
            set { this._temperature = value; }
        }

        // Check to see if Temperature property is set
        internal bool IsSetTemperature()
        {
            return this._temperature.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property TopP. 
        /// <para>
        /// The topP set when calling the model.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=1)]
        public float? TopP
        {
            get { return this._topp; }
            set { this._topp = value; }
        }

        // Check to see if TopP property is set
        internal bool IsSetTopP()
        {
            return this._topp.HasValue; 
        }

    }
}