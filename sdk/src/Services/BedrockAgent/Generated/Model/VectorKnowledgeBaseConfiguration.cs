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
    /// Contains details about the model used to create vector embeddings for the knowledge
    /// base.
    /// </summary>
    public partial class VectorKnowledgeBaseConfiguration
    {
        private string _embeddingModelArn;
        private EmbeddingModelConfiguration _embeddingModelConfiguration;
        private SupplementalDataStorageConfiguration _supplementalDataStorageConfiguration;

        /// <summary>
        /// Gets and sets the property EmbeddingModelArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the model used to create vector embeddings for the
        /// knowledge base.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=20, Max=2048)]
        public string EmbeddingModelArn
        {
            get { return this._embeddingModelArn; }
            set { this._embeddingModelArn = value; }
        }

        // Check to see if EmbeddingModelArn property is set
        internal bool IsSetEmbeddingModelArn()
        {
            return this._embeddingModelArn != null;
        }

        /// <summary>
        /// Gets and sets the property EmbeddingModelConfiguration. 
        /// <para>
        /// The embeddings model configuration details for the vector model used in Knowledge
        /// Base.
        /// </para>
        /// </summary>
        public EmbeddingModelConfiguration EmbeddingModelConfiguration
        {
            get { return this._embeddingModelConfiguration; }
            set { this._embeddingModelConfiguration = value; }
        }

        // Check to see if EmbeddingModelConfiguration property is set
        internal bool IsSetEmbeddingModelConfiguration()
        {
            return this._embeddingModelConfiguration != null;
        }

        /// <summary>
        /// Gets and sets the property SupplementalDataStorageConfiguration. 
        /// <para>
        /// If you include multimodal data from your data source, use this object to specify configurations
        /// for the storage location of the images extracted from your documents. These images
        /// can be retrieved and returned to the end user. They can also be used in generation
        /// when using <a href="https://docs.aws.amazon.com/bedrock/latest/APIReference/API_agent-runtime_RetrieveAndGenerate.html">RetrieveAndGenerate</a>.
        /// </para>
        /// </summary>
        public SupplementalDataStorageConfiguration SupplementalDataStorageConfiguration
        {
            get { return this._supplementalDataStorageConfiguration; }
            set { this._supplementalDataStorageConfiguration = value; }
        }

        // Check to see if SupplementalDataStorageConfiguration property is set
        internal bool IsSetSupplementalDataStorageConfiguration()
        {
            return this._supplementalDataStorageConfiguration != null;
        }

    }
}