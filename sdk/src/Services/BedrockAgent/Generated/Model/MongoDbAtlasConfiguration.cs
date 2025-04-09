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
    /// Contains details about the storage configuration of the knowledge base in MongoDB
    /// Atlas.
    /// </summary>
    public partial class MongoDbAtlasConfiguration
    {
        private string _collectionName;
        private string _credentialsSecretArn;
        private string _databaseName;
        private string _endpoint;
        private string _endpointServiceName;
        private MongoDbAtlasFieldMapping _fieldMapping;
        private string _textIndexName;
        private string _vectorIndexName;

        /// <summary>
        /// Gets and sets the property CollectionName. 
        /// <para>
        /// The collection name of the knowledge base in MongoDB Atlas.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=0, Max=63)]
        public string CollectionName
        {
            get { return this._collectionName; }
            set { this._collectionName = value; }
        }

        // Check to see if CollectionName property is set
        internal bool IsSetCollectionName()
        {
            return this._collectionName != null;
        }

        /// <summary>
        /// Gets and sets the property CredentialsSecretArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the secret that you created in Secrets Manager that
        /// contains user credentials for your MongoDB Atlas cluster.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string CredentialsSecretArn
        {
            get { return this._credentialsSecretArn; }
            set { this._credentialsSecretArn = value; }
        }

        // Check to see if CredentialsSecretArn property is set
        internal bool IsSetCredentialsSecretArn()
        {
            return this._credentialsSecretArn != null;
        }

        /// <summary>
        /// Gets and sets the property DatabaseName. 
        /// <para>
        /// The database name in your MongoDB Atlas cluster for your knowledge base.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=0, Max=63)]
        public string DatabaseName
        {
            get { return this._databaseName; }
            set { this._databaseName = value; }
        }

        // Check to see if DatabaseName property is set
        internal bool IsSetDatabaseName()
        {
            return this._databaseName != null;
        }

        /// <summary>
        /// Gets and sets the property Endpoint. 
        /// <para>
        /// The endpoint URL of your MongoDB Atlas cluster for your knowledge base.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=0, Max=2048)]
        public string Endpoint
        {
            get { return this._endpoint; }
            set { this._endpoint = value; }
        }

        // Check to see if Endpoint property is set
        internal bool IsSetEndpoint()
        {
            return this._endpoint != null;
        }

        /// <summary>
        /// Gets and sets the property EndpointServiceName. 
        /// <para>
        /// The name of the VPC endpoint service in your account that is connected to your MongoDB
        /// Atlas cluster.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=255)]
        public string EndpointServiceName
        {
            get { return this._endpointServiceName; }
            set { this._endpointServiceName = value; }
        }

        // Check to see if EndpointServiceName property is set
        internal bool IsSetEndpointServiceName()
        {
            return this._endpointServiceName != null;
        }

        /// <summary>
        /// Gets and sets the property FieldMapping. 
        /// <para>
        /// Contains the names of the fields to which to map information about the vector store.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public MongoDbAtlasFieldMapping FieldMapping
        {
            get { return this._fieldMapping; }
            set { this._fieldMapping = value; }
        }

        // Check to see if FieldMapping property is set
        internal bool IsSetFieldMapping()
        {
            return this._fieldMapping != null;
        }

        /// <summary>
        /// Gets and sets the property TextIndexName. 
        /// <para>
        /// The name of the text search index in the MongoDB collection. This is required for
        /// using the hybrid search feature.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=2048)]
        public string TextIndexName
        {
            get { return this._textIndexName; }
            set { this._textIndexName = value; }
        }

        // Check to see if TextIndexName property is set
        internal bool IsSetTextIndexName()
        {
            return this._textIndexName != null;
        }

        /// <summary>
        /// Gets and sets the property VectorIndexName. 
        /// <para>
        /// The name of the MongoDB Atlas vector search index.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=0, Max=2048)]
        public string VectorIndexName
        {
            get { return this._vectorIndexName; }
            set { this._vectorIndexName = value; }
        }

        // Check to see if VectorIndexName property is set
        internal bool IsSetVectorIndexName()
        {
            return this._vectorIndexName != null;
        }

    }
}