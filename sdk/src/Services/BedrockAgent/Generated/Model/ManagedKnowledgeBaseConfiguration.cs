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
    /// Configurations for a managed knowledge base.
    /// </summary>
    public partial class ManagedKnowledgeBaseConfiguration
    {
        private string _embeddingModelArn;
        private EmbeddingModelConfiguration _embeddingModelConfiguration;
        private EmbeddingModelType _embeddingModelType;
        private ServerSideEncryptionConfiguration _serverSideEncryptionConfiguration;
        private SupplementalDataStorageConfiguration _supplementalDataStorageConfiguration;

        /// <summary>
        /// Gets and sets the property EmbeddingModelArn. 
        /// <para>
        /// The ARN for the embeddings model.
        /// </para>
        /// </summary>
        [AWSProperty(Min=20, Max=2048)]
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
        /// The configuration details for the embeddings model. Not required when choosing the
        /// MANAGED embeddingModelType.
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
        /// Gets and sets the property EmbeddingModelType. 
        /// <para>
        /// Choose CUSTOM to provide your own Bedrock embedding model ARN. Choose MANAGED to use
        /// a service-managed embedding model.
        /// </para>
        /// </summary>
        public EmbeddingModelType EmbeddingModelType
        {
            get { return this._embeddingModelType; }
            set { this._embeddingModelType = value; }
        }

        // Check to see if EmbeddingModelType property is set
        internal bool IsSetEmbeddingModelType()
        {
            return this._embeddingModelType != null;
        }

        /// <summary>
        /// Gets and sets the property ServerSideEncryptionConfiguration. 
        /// <para>
        /// Contains the configuration for server-side encryption for your managed knowledge base.
        /// </para>
        /// </summary>
        public ServerSideEncryptionConfiguration ServerSideEncryptionConfiguration
        {
            get { return this._serverSideEncryptionConfiguration; }
            set { this._serverSideEncryptionConfiguration = value; }
        }

        // Check to see if ServerSideEncryptionConfiguration property is set
        internal bool IsSetServerSideEncryptionConfiguration()
        {
            return this._serverSideEncryptionConfiguration != null;
        }

        /// <summary>
        /// Gets and sets the property SupplementalDataStorageConfiguration. 
        /// <para>
        /// Use this object to specify the Amazon S3 location that the knowledge base uses to
        /// process and ingest multimodal content. This field is required when you use a native
        /// multimodal embedding model.
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