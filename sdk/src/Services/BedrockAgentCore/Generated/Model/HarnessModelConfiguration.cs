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
    /// Specification of which model to use.
    /// </summary>
    public partial class HarnessModelConfiguration
    {
        private HarnessBedrockModelConfig _bedrockModelConfig;
        private HarnessGeminiModelConfig _geminiModelConfig;
        private HarnessOpenAiModelConfig _openAiModelConfig;

        /// <summary>
        /// Gets and sets the property BedrockModelConfig. 
        /// <para>
        /// Configuration for an Amazon Bedrock model.
        /// </para>
        /// </summary>
        public HarnessBedrockModelConfig BedrockModelConfig
        {
            get { return this._bedrockModelConfig; }
            set { this._bedrockModelConfig = value; }
        }

        // Check to see if BedrockModelConfig property is set
        internal bool IsSetBedrockModelConfig()
        {
            return this._bedrockModelConfig != null;
        }

        /// <summary>
        /// Gets and sets the property GeminiModelConfig. 
        /// <para>
        /// Configuration for a Google Gemini model.
        /// </para>
        /// </summary>
        public HarnessGeminiModelConfig GeminiModelConfig
        {
            get { return this._geminiModelConfig; }
            set { this._geminiModelConfig = value; }
        }

        // Check to see if GeminiModelConfig property is set
        internal bool IsSetGeminiModelConfig()
        {
            return this._geminiModelConfig != null;
        }

        /// <summary>
        /// Gets and sets the property OpenAiModelConfig. 
        /// <para>
        /// Configuration for an OpenAI model.
        /// </para>
        /// </summary>
        public HarnessOpenAiModelConfig OpenAiModelConfig
        {
            get { return this._openAiModelConfig; }
            set { this._openAiModelConfig = value; }
        }

        // Check to see if OpenAiModelConfig property is set
        internal bool IsSetOpenAiModelConfig()
        {
            return this._openAiModelConfig != null;
        }

    }
}