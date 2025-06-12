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
    /// Container for the parameters to the CreateKnowledgeBase operation.
    /// Creates a knowledge base. A knowledge base contains your data sources so that Large
    /// Language Models (LLMs) can use your data. To create a knowledge base, you must first
    /// set up your data sources and configure a supported vector store. For more information,
    /// see <a href="https://docs.aws.amazon.com/bedrock/latest/userguide/knowlege-base-prereq.html">Set
    /// up a knowledge base</a>.
    /// 
    ///  <note> 
    /// <para>
    /// If you prefer to let Amazon Bedrock create and manage a vector store for you in Amazon
    /// OpenSearch Service, use the console. For more information, see <a href="https://docs.aws.amazon.com/bedrock/latest/userguide/knowledge-base-create">Create
    /// a knowledge base</a>.
    /// </para>
    ///  </note> <ul> <li> 
    /// <para>
    /// Provide the <c>name</c> and an optional <c>description</c>.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// Provide the Amazon Resource Name (ARN) with permissions to create a knowledge base
    /// in the <c>roleArn</c> field.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// Provide the embedding model to use in the <c>embeddingModelArn</c> field in the <c>knowledgeBaseConfiguration</c>
    /// object.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// Provide the configuration for your vector store in the <c>storageConfiguration</c>
    /// object.
    /// </para>
    ///  <ul> <li> 
    /// <para>
    /// For an Amazon OpenSearch Service database, use the <c>opensearchServerlessConfiguration</c>
    /// object. For more information, see <a href="https://docs.aws.amazon.com/bedrock/latest/userguide/knowledge-base-setup-oss.html">Create
    /// a vector store in Amazon OpenSearch Service</a>.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// For an Amazon Aurora database, use the <c>RdsConfiguration</c> object. For more information,
    /// see <a href="https://docs.aws.amazon.com/bedrock/latest/userguide/knowledge-base-setup-rds.html">Create
    /// a vector store in Amazon Aurora</a>.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// For a Pinecone database, use the <c>pineconeConfiguration</c> object. For more information,
    /// see <a href="https://docs.aws.amazon.com/bedrock/latest/userguide/knowledge-base-setup-pinecone.html">Create
    /// a vector store in Pinecone</a>.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// For a Redis Enterprise Cloud database, use the <c>redisEnterpriseCloudConfiguration</c>
    /// object. For more information, see <a href="https://docs.aws.amazon.com/bedrock/latest/userguide/knowledge-base-setup-redis.html">Create
    /// a vector store in Redis Enterprise Cloud</a>.
    /// </para>
    ///  </li> </ul> </li> </ul>
    /// </summary>
    public partial class CreateKnowledgeBaseRequest : AmazonBedrockAgentRequest
    {
        private string _clientToken;
        private string _description;
        private KnowledgeBaseConfiguration _knowledgeBaseConfiguration;
        private string _name;
        private string _roleArn;
        private StorageConfiguration _storageConfiguration;
        private Dictionary<string, string> _tags = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;

        /// <summary>
        /// Gets and sets the property ClientToken. 
        /// <para>
        /// A unique, case-sensitive identifier to ensure that the API request completes no more
        /// than one time. If this token matches a previous request, Amazon Bedrock ignores the
        /// request, but does not return an error. For more information, see <a href="https://docs.aws.amazon.com/AWSEC2/latest/APIReference/Run_Instance_Idempotency.html">Ensuring
        /// idempotency</a>.
        /// </para>
        /// </summary>
        [AWSProperty(Min=33, Max=256)]
        public string ClientToken
        {
            get { return this._clientToken; }
            set { this._clientToken = value; }
        }

        // Check to see if ClientToken property is set
        internal bool IsSetClientToken()
        {
            return this._clientToken != null;
        }

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// A description of the knowledge base.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=200)]
        public string Description
        {
            get { return this._description; }
            set { this._description = value; }
        }

        // Check to see if Description property is set
        internal bool IsSetDescription()
        {
            return this._description != null;
        }

        /// <summary>
        /// Gets and sets the property KnowledgeBaseConfiguration. 
        /// <para>
        /// Contains details about the embeddings model used for the knowledge base.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public KnowledgeBaseConfiguration KnowledgeBaseConfiguration
        {
            get { return this._knowledgeBaseConfiguration; }
            set { this._knowledgeBaseConfiguration = value; }
        }

        // Check to see if KnowledgeBaseConfiguration property is set
        internal bool IsSetKnowledgeBaseConfiguration()
        {
            return this._knowledgeBaseConfiguration != null;
        }

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// A name for the knowledge base.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string Name
        {
            get { return this._name; }
            set { this._name = value; }
        }

        // Check to see if Name property is set
        internal bool IsSetName()
        {
            return this._name != null;
        }

        /// <summary>
        /// Gets and sets the property RoleArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the IAM role with permissions to invoke API operations
        /// on the knowledge base.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=0, Max=2048)]
        public string RoleArn
        {
            get { return this._roleArn; }
            set { this._roleArn = value; }
        }

        // Check to see if RoleArn property is set
        internal bool IsSetRoleArn()
        {
            return this._roleArn != null;
        }

        /// <summary>
        /// Gets and sets the property StorageConfiguration. 
        /// <para>
        /// Contains details about the configuration of the vector database used for the knowledge
        /// base.
        /// </para>
        /// </summary>
        public StorageConfiguration StorageConfiguration
        {
            get { return this._storageConfiguration; }
            set { this._storageConfiguration = value; }
        }

        // Check to see if StorageConfiguration property is set
        internal bool IsSetStorageConfiguration()
        {
            return this._storageConfiguration != null;
        }

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// Specify the key-value pairs for the tags that you want to attach to your knowledge
        /// base in this object.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public Dictionary<string, string> Tags
        {
            get { return this._tags; }
            set { this._tags = value; }
        }

        // Check to see if Tags property is set
        internal bool IsSetTags()
        {
            return this._tags != null && (this._tags.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}