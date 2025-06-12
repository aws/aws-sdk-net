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
 * Do not modify this file. This file is generated from the bedrock-agent-runtime-2023-07-26.normal.json service model.
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
    /// Settings for how the model processes the prompt prior to retrieval and generation.
    /// </summary>
    public partial class OrchestrationConfiguration
    {
        private Dictionary<string, Amazon.Runtime.Documents.Document> _additionalModelRequestFields = AWSConfigs.InitializeCollections ? new Dictionary<string, Amazon.Runtime.Documents.Document>() : null;
        private InferenceConfig _inferenceConfig;
        private PerformanceConfiguration _performanceConfig;
        private PromptTemplate _promptTemplate;
        private QueryTransformationConfiguration _queryTransformationConfiguration;

        /// <summary>
        /// Gets and sets the property AdditionalModelRequestFields. 
        /// <para>
        ///  Additional model parameters and corresponding values not included in the textInferenceConfig
        /// structure for a knowledge base. This allows users to provide custom model parameters
        /// specific to the language model being used. 
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public Dictionary<string, Amazon.Runtime.Documents.Document> AdditionalModelRequestFields
        {
            get { return this._additionalModelRequestFields; }
            set { this._additionalModelRequestFields = value; }
        }

        // Check to see if AdditionalModelRequestFields property is set
        internal bool IsSetAdditionalModelRequestFields()
        {
            return this._additionalModelRequestFields != null && (this._additionalModelRequestFields.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property InferenceConfig. 
        /// <para>
        ///  Configuration settings for inference when using RetrieveAndGenerate to generate responses
        /// while using a knowledge base as a source. 
        /// </para>
        /// </summary>
        public InferenceConfig InferenceConfig
        {
            get { return this._inferenceConfig; }
            set { this._inferenceConfig = value; }
        }

        // Check to see if InferenceConfig property is set
        internal bool IsSetInferenceConfig()
        {
            return this._inferenceConfig != null;
        }

        /// <summary>
        /// Gets and sets the property PerformanceConfig. 
        /// <para>
        /// The latency configuration for the model.
        /// </para>
        /// </summary>
        public PerformanceConfiguration PerformanceConfig
        {
            get { return this._performanceConfig; }
            set { this._performanceConfig = value; }
        }

        // Check to see if PerformanceConfig property is set
        internal bool IsSetPerformanceConfig()
        {
            return this._performanceConfig != null;
        }

        /// <summary>
        /// Gets and sets the property PromptTemplate. 
        /// <para>
        /// Contains the template for the prompt that's sent to the model. Orchestration prompts
        /// must include the <c>$conversation_history$</c> and <c>$output_format_instructions$</c>
        /// variables. For more information, see <a href="https://docs.aws.amazon.com/bedrock/latest/userguide/prompt-placeholders.html">Use
        /// placeholder variables</a> in the user guide.
        /// </para>
        /// </summary>
        public PromptTemplate PromptTemplate
        {
            get { return this._promptTemplate; }
            set { this._promptTemplate = value; }
        }

        // Check to see if PromptTemplate property is set
        internal bool IsSetPromptTemplate()
        {
            return this._promptTemplate != null;
        }

        /// <summary>
        /// Gets and sets the property QueryTransformationConfiguration. 
        /// <para>
        /// To split up the prompt and retrieve multiple sources, set the transformation type
        /// to <c>QUERY_DECOMPOSITION</c>.
        /// </para>
        /// </summary>
        public QueryTransformationConfiguration QueryTransformationConfiguration
        {
            get { return this._queryTransformationConfiguration; }
            set { this._queryTransformationConfiguration = value; }
        }

        // Check to see if QueryTransformationConfiguration property is set
        internal bool IsSetQueryTransformationConfiguration()
        {
            return this._queryTransformationConfiguration != null;
        }

    }
}