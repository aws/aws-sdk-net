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

namespace Amazon.BedrockAgent.Model
{
    /// <summary>
    /// Configures how the knowledge base orchestrates the retrieval and generation process,
    /// allowing for customization of prompts, inference parameters, and performance settings.
    /// </summary>
    public partial class KnowledgeBaseOrchestrationConfiguration
    {
        /// <summary>
        /// Gets and sets the property AdditionalModelRequestFields. 
        /// <para>
        /// The additional model-specific request parameters as key-value pairs to be included
        /// in the request to the foundation model.
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
        /// Gets and sets the property InferenceConfig. 
        /// <para>
        /// Contains inference configurations for the prompt.
        /// </para>
        /// </summary>
        public PromptInferenceConfiguration InferenceConfig { get; set; }

        /// <summary>
        /// Checks to see if the InferenceConfig property is set.
        /// </summary>
        internal bool IsSetInferenceConfig() => this.InferenceConfig != null;

        /// <summary>
        /// Gets and sets the property PerformanceConfig. 
        /// <para>
        /// The performance configuration options for the knowledge base retrieval and generation
        /// process.
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
        /// A custom prompt template for orchestrating the retrieval and generation process.
        /// </para>
        /// </summary>
        public KnowledgeBasePromptTemplate PromptTemplate { get; set; }

        /// <summary>
        /// Checks to see if the PromptTemplate property is set.
        /// </summary>
        internal bool IsSetPromptTemplate() => this.PromptTemplate != null;
    }
}
