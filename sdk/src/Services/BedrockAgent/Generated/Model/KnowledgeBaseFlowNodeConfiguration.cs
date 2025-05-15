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
 * Do not modify this file. This file is generated from the bedrock-agent-2023-06-05.normal.json service model.
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
    /// Contains configurations for a knowledge base node in a flow. This node takes a query
    /// as the input and returns, as the output, the retrieved responses directly (as an array)
    /// or a response generated based on the retrieved responses. For more information, see
    /// <a href="https://docs.aws.amazon.com/bedrock/latest/userguide/flows-nodes.html">Node
    /// types in a flow</a> in the Amazon Bedrock User Guide.
    /// </summary>
    public partial class KnowledgeBaseFlowNodeConfiguration
    {
        private GuardrailConfiguration _guardrailConfiguration;
        private PromptInferenceConfiguration _inferenceConfiguration;
        private string _knowledgeBaseId;
        private string _modelId;
        private int? _numberOfResults;
        private KnowledgeBaseOrchestrationConfiguration _orchestrationConfiguration;
        private KnowledgeBasePromptTemplate _promptTemplate;
        private VectorSearchRerankingConfiguration _rerankingConfiguration;

        /// <summary>
        /// Gets and sets the property GuardrailConfiguration. 
        /// <para>
        /// Contains configurations for a guardrail to apply during query and response generation
        /// for the knowledge base in this configuration.
        /// </para>
        /// </summary>
        public GuardrailConfiguration GuardrailConfiguration
        {
            get { return this._guardrailConfiguration; }
            set { this._guardrailConfiguration = value; }
        }

        // Check to see if GuardrailConfiguration property is set
        internal bool IsSetGuardrailConfiguration()
        {
            return this._guardrailConfiguration != null;
        }

        /// <summary>
        /// Gets and sets the property InferenceConfiguration. 
        /// <para>
        /// Contains inference configurations for the prompt.
        /// </para>
        /// </summary>
        public PromptInferenceConfiguration InferenceConfiguration
        {
            get { return this._inferenceConfiguration; }
            set { this._inferenceConfiguration = value; }
        }

        // Check to see if InferenceConfiguration property is set
        internal bool IsSetInferenceConfiguration()
        {
            return this._inferenceConfiguration != null;
        }

        /// <summary>
        /// Gets and sets the property KnowledgeBaseId. 
        /// <para>
        /// The unique identifier of the knowledge base to query.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=0, Max=10)]
        public string KnowledgeBaseId
        {
            get { return this._knowledgeBaseId; }
            set { this._knowledgeBaseId = value; }
        }

        // Check to see if KnowledgeBaseId property is set
        internal bool IsSetKnowledgeBaseId()
        {
            return this._knowledgeBaseId != null;
        }

        /// <summary>
        /// Gets and sets the property ModelId. 
        /// <para>
        /// The unique identifier of the model or <a href="https://docs.aws.amazon.com/bedrock/latest/userguide/cross-region-inference.html">inference
        /// profile</a> to use to generate a response from the query results. Omit this field
        /// if you want to return the retrieved results as an array.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=2048)]
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
        /// Gets and sets the property NumberOfResults. 
        /// <para>
        /// The number of results to retrieve from the knowledge base.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=100)]
        public int? NumberOfResults
        {
            get { return this._numberOfResults; }
            set { this._numberOfResults = value; }
        }

        // Check to see if NumberOfResults property is set
        internal bool IsSetNumberOfResults()
        {
            return this._numberOfResults.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property OrchestrationConfiguration. 
        /// <para>
        /// The configuration for orchestrating the retrieval and generation process in the knowledge
        /// base node.
        /// </para>
        /// </summary>
        public KnowledgeBaseOrchestrationConfiguration OrchestrationConfiguration
        {
            get { return this._orchestrationConfiguration; }
            set { this._orchestrationConfiguration = value; }
        }

        // Check to see if OrchestrationConfiguration property is set
        internal bool IsSetOrchestrationConfiguration()
        {
            return this._orchestrationConfiguration != null;
        }

        /// <summary>
        /// Gets and sets the property PromptTemplate. 
        /// <para>
        /// A custom prompt template to use with the knowledge base for generating responses.
        /// </para>
        /// </summary>
        public KnowledgeBasePromptTemplate PromptTemplate
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
        /// Gets and sets the property RerankingConfiguration. 
        /// <para>
        /// The configuration for reranking the retrieved results from the knowledge base to improve
        /// relevance.
        /// </para>
        /// </summary>
        public VectorSearchRerankingConfiguration RerankingConfiguration
        {
            get { return this._rerankingConfiguration; }
            set { this._rerankingConfiguration = value; }
        }

        // Check to see if RerankingConfiguration property is set
        internal bool IsSetRerankingConfiguration()
        {
            return this._rerankingConfiguration != null;
        }

    }
}