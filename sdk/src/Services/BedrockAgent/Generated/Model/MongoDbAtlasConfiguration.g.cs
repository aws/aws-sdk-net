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
    /// Contains details about the storage configuration of the knowledge base in MongoDB
    /// Atlas.
    /// </summary>
    public partial class MongoDbAtlasConfiguration
    {
        /// <summary>
        /// Gets and sets the property CollectionName. 
        /// <para>
        /// The collection name of the knowledge base in MongoDB Atlas.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Max = 63)]
        public string CollectionName { get; set; }

        /// <summary>
        /// Checks to see if the CollectionName property is set.
        /// </summary>
        internal bool IsSetCollectionName() => this.CollectionName != null;

        /// <summary>
        /// Gets and sets the property CredentialsSecretArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the secret that you created in Secrets Manager that
        /// contains user credentials for your MongoDB Atlas cluster.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string CredentialsSecretArn { get; set; }

        /// <summary>
        /// Checks to see if the CredentialsSecretArn property is set.
        /// </summary>
        internal bool IsSetCredentialsSecretArn() => this.CredentialsSecretArn != null;

        /// <summary>
        /// Gets and sets the property DatabaseName. 
        /// <para>
        /// The database name in your MongoDB Atlas cluster for your knowledge base.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Max = 63)]
        public string DatabaseName { get; set; }

        /// <summary>
        /// Checks to see if the DatabaseName property is set.
        /// </summary>
        internal bool IsSetDatabaseName() => this.DatabaseName != null;

        /// <summary>
        /// Gets and sets the property Endpoint. 
        /// <para>
        /// The endpoint URL of your MongoDB Atlas cluster for your knowledge base.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Max = 2048)]
        public string Endpoint { get; set; }

        /// <summary>
        /// Checks to see if the Endpoint property is set.
        /// </summary>
        internal bool IsSetEndpoint() => this.Endpoint != null;

        /// <summary>
        /// Gets and sets the property EndpointServiceName. 
        /// <para>
        /// The name of the VPC endpoint service in your account that is connected to your MongoDB
        /// Atlas cluster.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 255)]
        public string EndpointServiceName { get; set; }

        /// <summary>
        /// Checks to see if the EndpointServiceName property is set.
        /// </summary>
        internal bool IsSetEndpointServiceName() => this.EndpointServiceName != null;

        /// <summary>
        /// Gets and sets the property FieldMapping. 
        /// <para>
        /// Contains the names of the fields to which to map information about the vector store.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public MongoDbAtlasFieldMapping FieldMapping { get; set; }

        /// <summary>
        /// Checks to see if the FieldMapping property is set.
        /// </summary>
        internal bool IsSetFieldMapping() => this.FieldMapping != null;

        /// <summary>
        /// Gets and sets the property TextIndexName. 
        /// <para>
        /// The name of the text search index in the MongoDB collection. This is required for
        /// using the hybrid search feature.
        /// </para>
        /// </summary>
        [AWSProperty(Max = 2048)]
        public string TextIndexName { get; set; }

        /// <summary>
        /// Checks to see if the TextIndexName property is set.
        /// </summary>
        internal bool IsSetTextIndexName() => this.TextIndexName != null;

        /// <summary>
        /// Gets and sets the property VectorIndexName. 
        /// <para>
        /// The name of the MongoDB Atlas vector search index.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Max = 2048)]
        public string VectorIndexName { get; set; }

        /// <summary>
        /// Checks to see if the VectorIndexName property is set.
        /// </summary>
        internal bool IsSetVectorIndexName() => this.VectorIndexName != null;
    }
}
