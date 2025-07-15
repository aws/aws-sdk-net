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
    /// Contains the storage configuration of the knowledge base.
    /// </summary>
    public partial class StorageConfiguration
    {
        private MongoDbAtlasConfiguration _mongoDbAtlasConfiguration;
        private NeptuneAnalyticsConfiguration _neptuneAnalyticsConfiguration;
        private OpenSearchManagedClusterConfiguration _opensearchManagedClusterConfiguration;
        private OpenSearchServerlessConfiguration _opensearchServerlessConfiguration;
        private PineconeConfiguration _pineconeConfiguration;
        private RdsConfiguration _rdsConfiguration;
        private RedisEnterpriseCloudConfiguration _redisEnterpriseCloudConfiguration;
        private S3VectorsConfiguration _s3VectorsConfiguration;
        private KnowledgeBaseStorageType _type;

        /// <summary>
        /// Gets and sets the property MongoDbAtlasConfiguration. 
        /// <para>
        /// Contains the storage configuration of the knowledge base in MongoDB Atlas.
        /// </para>
        /// </summary>
        public MongoDbAtlasConfiguration MongoDbAtlasConfiguration
        {
            get { return this._mongoDbAtlasConfiguration; }
            set { this._mongoDbAtlasConfiguration = value; }
        }

        // Check to see if MongoDbAtlasConfiguration property is set
        internal bool IsSetMongoDbAtlasConfiguration()
        {
            return this._mongoDbAtlasConfiguration != null;
        }

        /// <summary>
        /// Gets and sets the property NeptuneAnalyticsConfiguration. 
        /// <para>
        /// Contains details about the Neptune Analytics configuration of the knowledge base in
        /// Amazon Neptune. For more information, see <a href="https://docs.aws.amazon.com/bedrock/latest/userguide/knowledge-base-setup-neptune.html">Create
        /// a vector index in Amazon Neptune Analytics.</a>.
        /// </para>
        /// </summary>
        public NeptuneAnalyticsConfiguration NeptuneAnalyticsConfiguration
        {
            get { return this._neptuneAnalyticsConfiguration; }
            set { this._neptuneAnalyticsConfiguration = value; }
        }

        // Check to see if NeptuneAnalyticsConfiguration property is set
        internal bool IsSetNeptuneAnalyticsConfiguration()
        {
            return this._neptuneAnalyticsConfiguration != null;
        }

        /// <summary>
        /// Gets and sets the property OpensearchManagedClusterConfiguration. 
        /// <para>
        /// Contains details about the storage configuration of the knowledge base in OpenSearch
        /// Managed Cluster. For more information, see <a href="https://docs.aws.amazon.com/bedrock/latest/userguide/knowledge-base-setup-osm.html">Create
        /// a vector index in Amazon OpenSearch Service</a>.
        /// </para>
        /// </summary>
        public OpenSearchManagedClusterConfiguration OpensearchManagedClusterConfiguration
        {
            get { return this._opensearchManagedClusterConfiguration; }
            set { this._opensearchManagedClusterConfiguration = value; }
        }

        // Check to see if OpensearchManagedClusterConfiguration property is set
        internal bool IsSetOpensearchManagedClusterConfiguration()
        {
            return this._opensearchManagedClusterConfiguration != null;
        }

        /// <summary>
        /// Gets and sets the property OpensearchServerlessConfiguration. 
        /// <para>
        /// Contains the storage configuration of the knowledge base in Amazon OpenSearch Service.
        /// </para>
        /// </summary>
        public OpenSearchServerlessConfiguration OpensearchServerlessConfiguration
        {
            get { return this._opensearchServerlessConfiguration; }
            set { this._opensearchServerlessConfiguration = value; }
        }

        // Check to see if OpensearchServerlessConfiguration property is set
        internal bool IsSetOpensearchServerlessConfiguration()
        {
            return this._opensearchServerlessConfiguration != null;
        }

        /// <summary>
        /// Gets and sets the property PineconeConfiguration. 
        /// <para>
        /// Contains the storage configuration of the knowledge base in Pinecone.
        /// </para>
        /// </summary>
        public PineconeConfiguration PineconeConfiguration
        {
            get { return this._pineconeConfiguration; }
            set { this._pineconeConfiguration = value; }
        }

        // Check to see if PineconeConfiguration property is set
        internal bool IsSetPineconeConfiguration()
        {
            return this._pineconeConfiguration != null;
        }

        /// <summary>
        /// Gets and sets the property RdsConfiguration. 
        /// <para>
        /// Contains details about the storage configuration of the knowledge base in Amazon RDS.
        /// For more information, see <a href="https://docs.aws.amazon.com/bedrock/latest/userguide/knowledge-base-setup-rds.html">Create
        /// a vector index in Amazon RDS</a>.
        /// </para>
        /// </summary>
        public RdsConfiguration RdsConfiguration
        {
            get { return this._rdsConfiguration; }
            set { this._rdsConfiguration = value; }
        }

        // Check to see if RdsConfiguration property is set
        internal bool IsSetRdsConfiguration()
        {
            return this._rdsConfiguration != null;
        }

        /// <summary>
        /// Gets and sets the property RedisEnterpriseCloudConfiguration. 
        /// <para>
        /// Contains the storage configuration of the knowledge base in Redis Enterprise Cloud.
        /// </para>
        /// </summary>
        public RedisEnterpriseCloudConfiguration RedisEnterpriseCloudConfiguration
        {
            get { return this._redisEnterpriseCloudConfiguration; }
            set { this._redisEnterpriseCloudConfiguration = value; }
        }

        // Check to see if RedisEnterpriseCloudConfiguration property is set
        internal bool IsSetRedisEnterpriseCloudConfiguration()
        {
            return this._redisEnterpriseCloudConfiguration != null;
        }

        /// <summary>
        /// Gets and sets the property S3VectorsConfiguration. 
        /// <para>
        /// The configuration settings for storing knowledge base data using S3 vectors. This
        /// includes vector index information and S3 bucket details for vector storage.
        /// </para>
        /// </summary>
        public S3VectorsConfiguration S3VectorsConfiguration
        {
            get { return this._s3VectorsConfiguration; }
            set { this._s3VectorsConfiguration = value; }
        }

        // Check to see if S3VectorsConfiguration property is set
        internal bool IsSetS3VectorsConfiguration()
        {
            return this._s3VectorsConfiguration != null;
        }

        /// <summary>
        /// Gets and sets the property Type. 
        /// <para>
        /// The vector store service in which the knowledge base is stored.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public KnowledgeBaseStorageType Type
        {
            get { return this._type; }
            set { this._type = value; }
        }

        // Check to see if Type property is set
        internal bool IsSetType()
        {
            return this._type != null;
        }

    }
}