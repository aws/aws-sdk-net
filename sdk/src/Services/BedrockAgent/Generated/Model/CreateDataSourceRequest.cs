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
    /// Container for the parameters to the CreateDataSource operation.
    /// Connects a knowledge base to a data source. You specify the configuration for the
    /// specific data source service in the <c>dataSourceConfiguration</c> field.
    /// 
    ///  <important> 
    /// <para>
    /// You can't change the <c>chunkingConfiguration</c> after you create the data source
    /// connector.
    /// </para>
    ///  </important>
    /// </summary>
    public partial class CreateDataSourceRequest : AmazonBedrockAgentRequest
    {
        private string _clientToken;
        private DataDeletionPolicy _dataDeletionPolicy;
        private DataSourceConfiguration _dataSourceConfiguration;
        private string _description;
        private string _knowledgeBaseId;
        private string _name;
        private ServerSideEncryptionConfiguration _serverSideEncryptionConfiguration;
        private VectorIngestionConfiguration _vectorIngestionConfiguration;

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
        /// Gets and sets the property DataDeletionPolicy. 
        /// <para>
        /// The data deletion policy for the data source.
        /// </para>
        ///  
        /// <para>
        /// You can set the data deletion policy to:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// DELETE: Deletes all data from your data source that’s converted into vector embeddings
        /// upon deletion of a knowledge base or data source resource. Note that the <b>vector
        /// store itself is not deleted</b>, only the data. This flag is ignored if an Amazon
        /// Web Services account is deleted.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// RETAIN: Retains all data from your data source that’s converted into vector embeddings
        /// upon deletion of a knowledge base or data source resource. Note that the <b>vector
        /// store itself is not deleted</b> if you delete a knowledge base or data source resource.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public DataDeletionPolicy DataDeletionPolicy
        {
            get { return this._dataDeletionPolicy; }
            set { this._dataDeletionPolicy = value; }
        }

        // Check to see if DataDeletionPolicy property is set
        internal bool IsSetDataDeletionPolicy()
        {
            return this._dataDeletionPolicy != null;
        }

        /// <summary>
        /// Gets and sets the property DataSourceConfiguration. 
        /// <para>
        /// The connection configuration for the data source.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public DataSourceConfiguration DataSourceConfiguration
        {
            get { return this._dataSourceConfiguration; }
            set { this._dataSourceConfiguration = value; }
        }

        // Check to see if DataSourceConfiguration property is set
        internal bool IsSetDataSourceConfiguration()
        {
            return this._dataSourceConfiguration != null;
        }

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// A description of the data source.
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
        /// Gets and sets the property KnowledgeBaseId. 
        /// <para>
        /// The unique identifier of the knowledge base to which to add the data source.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
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
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the data source.
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
        /// Gets and sets the property ServerSideEncryptionConfiguration. 
        /// <para>
        /// Contains details about the server-side encryption for the data source.
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
        /// Gets and sets the property VectorIngestionConfiguration. 
        /// <para>
        /// Contains details about how to ingest the documents in the data source.
        /// </para>
        /// </summary>
        public VectorIngestionConfiguration VectorIngestionConfiguration
        {
            get { return this._vectorIngestionConfiguration; }
            set { this._vectorIngestionConfiguration = value; }
        }

        // Check to see if VectorIngestionConfiguration property is set
        internal bool IsSetVectorIngestionConfiguration()
        {
            return this._vectorIngestionConfiguration != null;
        }

    }
}