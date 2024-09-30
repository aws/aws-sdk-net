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
    /// Contains details about the resource being queried.
    /// 
    ///  
    /// <para>
    /// This data type is used in the following API operations:
    /// </para>
    ///  <ul> <li> 
    /// <para>
    ///  <a href="https://docs.aws.amazon.com/bedrock/latest/APIReference/API_agent-runtime_Retrieve.html#API_agent-runtime_Retrieve_RequestSyntax">Retrieve
    /// request</a> – in the <c>knowledgeBaseConfiguration</c> field
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a href="https://docs.aws.amazon.com/bedrock/latest/APIReference/API_agent-runtime_RetrieveAndGenerate.html#API_agent-runtime_RetrieveAndGenerate_RequestSyntax">RetrieveAndGenerate
    /// request</a> – in the <c>knowledgeBaseConfiguration</c> field
    /// </para>
    ///  </li> </ul>
    /// </summary>
    public partial class KnowledgeBaseRetrieveAndGenerateConfiguration
    {
        private GenerationConfiguration _generationConfiguration;
        private string _knowledgeBaseId;
        private string _modelArn;
        private OrchestrationConfiguration _orchestrationConfiguration;
        private KnowledgeBaseRetrievalConfiguration _retrievalConfiguration;

        /// <summary>
        /// Gets and sets the property GenerationConfiguration. 
        /// <para>
        /// Contains configurations for response generation based on the knowledge base query
        /// results.
        /// </para>
        /// </summary>
        public GenerationConfiguration GenerationConfiguration
        {
            get { return this._generationConfiguration; }
            set { this._generationConfiguration = value; }
        }

        // Check to see if GenerationConfiguration property is set
        internal bool IsSetGenerationConfiguration()
        {
            return this._generationConfiguration != null;
        }

        /// <summary>
        /// Gets and sets the property KnowledgeBaseId. 
        /// <para>
        /// The unique identifier of the knowledge base that is queried.
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
        /// Gets and sets the property ModelArn. 
        /// <para>
        /// The ARN of the foundation model or <a href="https://docs.aws.amazon.com/bedrock/latest/userguide/cross-region-inference.html">inference
        /// profile</a> used to generate a response.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=2048)]
        public string ModelArn
        {
            get { return this._modelArn; }
            set { this._modelArn = value; }
        }

        // Check to see if ModelArn property is set
        internal bool IsSetModelArn()
        {
            return this._modelArn != null;
        }

        /// <summary>
        /// Gets and sets the property OrchestrationConfiguration. 
        /// <para>
        /// Settings for how the model processes the prompt prior to retrieval and generation.
        /// </para>
        /// </summary>
        public OrchestrationConfiguration OrchestrationConfiguration
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
        /// Gets and sets the property RetrievalConfiguration. 
        /// <para>
        /// Contains configurations for how to retrieve and return the knowledge base query.
        /// </para>
        /// </summary>
        public KnowledgeBaseRetrievalConfiguration RetrievalConfiguration
        {
            get { return this._retrievalConfiguration; }
            set { this._retrievalConfiguration = value; }
        }

        // Check to see if RetrievalConfiguration property is set
        internal bool IsSetRetrievalConfiguration()
        {
            return this._retrievalConfiguration != null;
        }

    }
}