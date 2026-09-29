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
    /// Configuration for a Google Gemini model provider. Requires an API key stored in AgentCore
    /// Identity.
    /// </summary>
    public partial class HarnessGeminiModelConfig
    {
        /// <summary>
        /// Gets and sets the property AdditionalParams. 
        /// <para>
        /// Provider-specific parameters passed through to the Gemini model provider unchanged.
        /// </para>
        /// </summary>
        public Amazon.Runtime.Documents.Document AdditionalParams { get; set; }

        /// <summary>
        /// Checks to see if the AdditionalParams property is set.
        /// </summary>
        internal bool IsSetAdditionalParams() => !this.AdditionalParams.IsNull();

        /// <summary>
        /// Gets and sets the property ApiKeyArn. 
        /// <para>
        /// The ARN of your Gemini API key on AgentCore Identity.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string ApiKeyArn { get; set; }

        /// <summary>
        /// Checks to see if the ApiKeyArn property is set.
        /// </summary>
        internal bool IsSetApiKeyArn() => this.ApiKeyArn != null;

        /// <summary>
        /// Gets and sets the property MaxTokens. 
        /// <para>
        /// The maximum number of tokens to allow in the generated response per iteration.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1)]
        public int? MaxTokens { get; set; }

        /// <summary>
        /// Checks to see if the MaxTokens property is set.
        /// </summary>
        internal bool IsSetMaxTokens() => this.MaxTokens.HasValue;

        /// <summary>
        /// Gets and sets the property ModelId. 
        /// <para>
        /// The Gemini model ID.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string ModelId { get; set; }

        /// <summary>
        /// Checks to see if the ModelId property is set.
        /// </summary>
        internal bool IsSetModelId() => this.ModelId != null;

        /// <summary>
        /// Gets and sets the property Temperature. 
        /// <para>
        /// The temperature to set when calling the model.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 2)]
        public float? Temperature { get; set; }

        /// <summary>
        /// Checks to see if the Temperature property is set.
        /// </summary>
        internal bool IsSetTemperature() => this.Temperature.HasValue;

        /// <summary>
        /// Gets and sets the property TopK. 
        /// <para>
        /// The topK set when calling the model.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 500)]
        public int? TopK { get; set; }

        /// <summary>
        /// Checks to see if the TopK property is set.
        /// </summary>
        internal bool IsSetTopK() => this.TopK.HasValue;

        /// <summary>
        /// Gets and sets the property TopP. 
        /// <para>
        /// The topP set when calling the model.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 1)]
        public float? TopP { get; set; }

        /// <summary>
        /// Checks to see if the TopP property is set.
        /// </summary>
        internal bool IsSetTopP() => this.TopP.HasValue;
    }
}
