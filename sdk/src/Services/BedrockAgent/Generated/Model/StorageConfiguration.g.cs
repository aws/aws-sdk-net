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
    /// Contains the storage configuration of the knowledge base.
    /// </summary>
    public partial class StorageConfiguration
    {
        /// <summary>
        /// Gets and sets the property MongoDbAtlasConfiguration. 
        /// <para>
        /// Contains the storage configuration of the knowledge base in MongoDB Atlas.
        /// </para>
        /// </summary>
        public MongoDbAtlasConfiguration MongoDbAtlasConfiguration { get; set; }

        /// <summary>
        /// Checks to see if the MongoDbAtlasConfiguration property is set.
        /// </summary>
        internal bool IsSetMongoDbAtlasConfiguration() => this.MongoDbAtlasConfiguration != null;

        /// <summary>
        /// Gets and sets the property NeptuneAnalyticsConfiguration. 
        /// <para>
        /// Contains details about the Neptune Analytics configuration of the knowledge base in
        /// Amazon Neptune. For more information, see <a href="https://docs.aws.amazon.com/bedrock/latest/userguide/knowledge-base-setup-neptune.html">Create
        /// a vector index in Amazon Neptune Analytics.</a>.
        /// </para>
        /// </summary>
        public NeptuneAnalyticsConfiguration NeptuneAnalyticsConfiguration { get; set; }

        /// <summary>
        /// Checks to see if the NeptuneAnalyticsConfiguration property is set.
        /// </summary>
        internal bool IsSetNeptuneAnalyticsConfiguration() => this.NeptuneAnalyticsConfiguration != null;

        /// <summary>
        /// Gets and sets the property OpensearchManagedClusterConfiguration. 
        /// <para>
        /// Contains details about the storage configuration of the knowledge base in OpenSearch
        /// Managed Cluster. For more information, see <a href="https://docs.aws.amazon.com/bedrock/latest/userguide/knowledge-base-setup-osm.html">Create
        /// a vector index in Amazon OpenSearch Service</a>.
        /// </para>
        /// </summary>
        public OpenSearchManagedClusterConfiguration OpensearchManagedClusterConfiguration { get; set; }

        /// <summary>
        /// Checks to see if the OpensearchManagedClusterConfiguration property is set.
        /// </summary>
        internal bool IsSetOpensearchManagedClusterConfiguration() => this.OpensearchManagedClusterConfiguration != null;

        /// <summary>
        /// Gets and sets the property OpensearchServerlessConfiguration. 
        /// <para>
        /// Contains the storage configuration of the knowledge base in Amazon OpenSearch Service.
        /// </para>
        /// </summary>
        public OpenSearchServerlessConfiguration OpensearchServerlessConfiguration { get; set; }

        /// <summary>
        /// Checks to see if the OpensearchServerlessConfiguration property is set.
        /// </summary>
        internal bool IsSetOpensearchServerlessConfiguration() => this.OpensearchServerlessConfiguration != null;

        /// <summary>
        /// Gets and sets the property PineconeConfiguration. 
        /// <para>
        /// Contains the storage configuration of the knowledge base in Pinecone.
        /// </para>
        /// </summary>
        public PineconeConfiguration PineconeConfiguration { get; set; }

        /// <summary>
        /// Checks to see if the PineconeConfiguration property is set.
        /// </summary>
        internal bool IsSetPineconeConfiguration() => this.PineconeConfiguration != null;

        /// <summary>
        /// Gets and sets the property RdsConfiguration. 
        /// <para>
        /// Contains details about the storage configuration of the knowledge base in Amazon RDS.
        /// For more information, see <a href="https://docs.aws.amazon.com/bedrock/latest/userguide/knowledge-base-setup-rds.html">Create
        /// a vector index in Amazon RDS</a>.
        /// </para>
        /// </summary>
        public RdsConfiguration RdsConfiguration { get; set; }

        /// <summary>
        /// Checks to see if the RdsConfiguration property is set.
        /// </summary>
        internal bool IsSetRdsConfiguration() => this.RdsConfiguration != null;

        /// <summary>
        /// Gets and sets the property RedisEnterpriseCloudConfiguration. 
        /// <para>
        /// Contains the storage configuration of the knowledge base in Redis Enterprise Cloud.
        /// </para>
        /// </summary>
        public RedisEnterpriseCloudConfiguration RedisEnterpriseCloudConfiguration { get; set; }

        /// <summary>
        /// Checks to see if the RedisEnterpriseCloudConfiguration property is set.
        /// </summary>
        internal bool IsSetRedisEnterpriseCloudConfiguration() => this.RedisEnterpriseCloudConfiguration != null;

        /// <summary>
        /// Gets and sets the property S3VectorsConfiguration. 
        /// <para>
        /// The configuration settings for storing knowledge base data using S3 vectors. This
        /// includes vector index information and S3 bucket details for vector storage.
        /// </para>
        /// </summary>
        public S3VectorsConfiguration S3VectorsConfiguration { get; set; }

        /// <summary>
        /// Checks to see if the S3VectorsConfiguration property is set.
        /// </summary>
        internal bool IsSetS3VectorsConfiguration() => this.S3VectorsConfiguration != null;

        /// <summary>
        /// Gets and sets the property Type. 
        /// <para>
        /// The vector store service in which the knowledge base is stored.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public KnowledgeBaseStorageType Type { get; set; }

        /// <summary>
        /// Checks to see if the Type property is set.
        /// </summary>
        internal bool IsSetType() => this.Type != null;
    }
}
