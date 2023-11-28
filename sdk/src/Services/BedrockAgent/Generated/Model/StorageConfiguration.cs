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

namespace Amazon.BedrockAgent.Model
{
    /// <summary>
    /// Configures the physical storage of ingested data in a knowledge base.
    /// </summary>
    public partial class StorageConfiguration
    {
        private OpenSearchServerlessConfiguration _opensearchServerlessConfiguration;
        private PineconeConfiguration _pineconeConfiguration;
        private RedisEnterpriseCloudConfiguration _redisEnterpriseCloudConfiguration;
        private KnowledgeBaseStorageType _type;

        /// <summary>
        /// Gets and sets the property OpensearchServerlessConfiguration.
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
        /// Gets and sets the property RedisEnterpriseCloudConfiguration.
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
        /// Gets and sets the property Type.
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