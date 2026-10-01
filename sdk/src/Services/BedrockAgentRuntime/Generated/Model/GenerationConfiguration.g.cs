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

namespace Amazon.BedrockAgentRuntime.Model
{
    /// <summary>
    /// Contains configurations for response generation based on the knowledge base query
    /// results.
    /// 
    ///  
    /// <para>
    /// This data type is used in the following API operations:
    /// </para>
    ///  <ul> <li> 
    /// <para>
    ///  <a href="https://docs.aws.amazon.com/bedrock/latest/APIReference/API_agent-runtime_RetrieveAndGenerate.html#API_agent-runtime_RetrieveAndGenerate_RequestSyntax">RetrieveAndGenerate
    /// request</a> 
    /// </para>
    ///  </li> </ul>
    /// </summary>
    public partial class GenerationConfiguration
    {
        /// <summary>
        /// Gets and sets the property AdditionalModelRequestFields. 
        /// <para>
        ///  Additional model parameters and corresponding values not included in the textInferenceConfig
        /// structure for a knowledge base. This allows users to provide custom model parameters
        /// specific to the language model being used. 
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public Dictionary<string, Amazon.Runtime.Documents.Document> AdditionalModelRequestFields { get; set; } = AWSConfigs.InitializeCollections ? new Dictionary<string, Amazon.Runtime.Documents.Document>() : null;

        /// <summary>
        /// Checks to see if the AdditionalModelRequestFields property is set.
        /// </summary>
        internal bool IsSetAdditionalModelRequestFields() => this.AdditionalModelRequestFields != null && (this.AdditionalModelRequestFields.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property GuardrailConfiguration. 
        /// <para>
        /// The configuration details for the guardrail.
        /// </para>
        /// </summary>
        public GuardrailConfiguration GuardrailConfiguration { get; set; }

        /// <summary>
        /// Checks to see if the GuardrailConfiguration property is set.
        /// </summary>
        internal bool IsSetGuardrailConfiguration() => this.GuardrailConfiguration != null;

        /// <summary>
        /// Gets and sets the property InferenceConfig. 
        /// <para>
        ///  Configuration settings for inference when using RetrieveAndGenerate to generate responses
        /// while using a knowledge base as a source. 
        /// </para>
        /// </summary>
        public InferenceConfig InferenceConfig { get; set; }

        /// <summary>
        /// Checks to see if the InferenceConfig property is set.
        /// </summary>
        internal bool IsSetInferenceConfig() => this.InferenceConfig != null;

        /// <summary>
        /// Gets and sets the property PerformanceConfig. 
        /// <para>
        /// The latency configuration for the model.
        /// </para>
        /// </summary>
        public PerformanceConfiguration PerformanceConfig { get; set; }

        /// <summary>
        /// Checks to see if the PerformanceConfig property is set.
        /// </summary>
        internal bool IsSetPerformanceConfig() => this.PerformanceConfig != null;

        /// <summary>
        /// Gets and sets the property PromptTemplate. 
        /// <para>
        /// Contains the template for the prompt that's sent to the model for response generation.
        /// Generation prompts must include the <c>$search_results$</c> variable. For more information,
        /// see <a href="https://docs.aws.amazon.com/bedrock/latest/userguide/prompt-placeholders.html">Use
        /// placeholder variables</a> in the user guide.
        /// </para>
        /// </summary>
        public PromptTemplate PromptTemplate { get; set; }

        /// <summary>
        /// Checks to see if the PromptTemplate property is set.
        /// </summary>
        internal bool IsSetPromptTemplate() => this.PromptTemplate != null;
    }
}
