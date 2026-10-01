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
    /// Configurations for a managed knowledge base.
    /// </summary>
    public partial class ManagedKnowledgeBaseConfiguration
    {
        /// <summary>
        /// Gets and sets the property EmbeddingModelArn. 
        /// <para>
        /// The ARN for the embeddings model.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 20, Max = 2048)]
        public string EmbeddingModelArn { get; set; }

        /// <summary>
        /// Checks to see if the EmbeddingModelArn property is set.
        /// </summary>
        internal bool IsSetEmbeddingModelArn() => this.EmbeddingModelArn != null;

        /// <summary>
        /// Gets and sets the property EmbeddingModelConfiguration. 
        /// <para>
        /// The configuration details for the embeddings model. Not required when choosing the
        /// MANAGED embeddingModelType.
        /// </para>
        /// </summary>
        public EmbeddingModelConfiguration EmbeddingModelConfiguration { get; set; }

        /// <summary>
        /// Checks to see if the EmbeddingModelConfiguration property is set.
        /// </summary>
        internal bool IsSetEmbeddingModelConfiguration() => this.EmbeddingModelConfiguration != null;

        /// <summary>
        /// Gets and sets the property EmbeddingModelType. 
        /// <para>
        /// Choose CUSTOM to provide your own Bedrock embedding model ARN. Choose MANAGED to use
        /// a service-managed embedding model.
        /// </para>
        /// </summary>
        public EmbeddingModelType EmbeddingModelType { get; set; }

        /// <summary>
        /// Checks to see if the EmbeddingModelType property is set.
        /// </summary>
        internal bool IsSetEmbeddingModelType() => this.EmbeddingModelType != null;

        /// <summary>
        /// Gets and sets the property ServerSideEncryptionConfiguration. 
        /// <para>
        /// Contains the configuration for server-side encryption for your managed knowledge base.
        /// </para>
        /// </summary>
        public ServerSideEncryptionConfiguration ServerSideEncryptionConfiguration { get; set; }

        /// <summary>
        /// Checks to see if the ServerSideEncryptionConfiguration property is set.
        /// </summary>
        internal bool IsSetServerSideEncryptionConfiguration() => this.ServerSideEncryptionConfiguration != null;

        /// <summary>
        /// Gets and sets the property SupplementalDataStorageConfiguration. 
        /// <para>
        /// Use this object to specify the Amazon S3 location that the knowledge base uses to
        /// process and ingest multimodal content. This field is required when you use a native
        /// multimodal embedding model.
        /// </para>
        /// </summary>
        public SupplementalDataStorageConfiguration SupplementalDataStorageConfiguration { get; set; }

        /// <summary>
        /// Checks to see if the SupplementalDataStorageConfiguration property is set.
        /// </summary>
        internal bool IsSetSupplementalDataStorageConfiguration() => this.SupplementalDataStorageConfiguration != null;
    }
}
