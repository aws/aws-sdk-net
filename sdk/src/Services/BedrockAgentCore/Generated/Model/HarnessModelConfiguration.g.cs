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
    /// Specification of which model to use.
    /// </summary>
    public partial class HarnessModelConfiguration
    {
        /// <summary>
        /// Gets and sets the property BedrockModelConfig. 
        /// <para>
        /// Configuration for an Amazon Bedrock model.
        /// </para>
        /// </summary>
        public HarnessBedrockModelConfig BedrockModelConfig { get; set; }

        /// <summary>
        /// Checks to see if the BedrockModelConfig property is set.
        /// </summary>
        internal bool IsSetBedrockModelConfig() => this.BedrockModelConfig != null;

        /// <summary>
        /// Gets and sets the property GeminiModelConfig. 
        /// <para>
        /// Configuration for a Google Gemini model.
        /// </para>
        /// </summary>
        public HarnessGeminiModelConfig GeminiModelConfig { get; set; }

        /// <summary>
        /// Checks to see if the GeminiModelConfig property is set.
        /// </summary>
        internal bool IsSetGeminiModelConfig() => this.GeminiModelConfig != null;

        /// <summary>
        /// Gets and sets the property LiteLlmModelConfig. 
        /// <para>
        /// The LiteLLM model configuration for connecting to third-party model providers.
        /// </para>
        /// </summary>
        public HarnessLiteLlmModelConfig LiteLlmModelConfig { get; set; }

        /// <summary>
        /// Checks to see if the LiteLlmModelConfig property is set.
        /// </summary>
        internal bool IsSetLiteLlmModelConfig() => this.LiteLlmModelConfig != null;

        /// <summary>
        /// Gets and sets the property OpenAiModelConfig. 
        /// <para>
        /// Configuration for an OpenAI model.
        /// </para>
        /// </summary>
        public HarnessOpenAiModelConfig OpenAiModelConfig { get; set; }

        /// <summary>
        /// Checks to see if the OpenAiModelConfig property is set.
        /// </summary>
        internal bool IsSetOpenAiModelConfig() => this.OpenAiModelConfig != null;
    }
}
