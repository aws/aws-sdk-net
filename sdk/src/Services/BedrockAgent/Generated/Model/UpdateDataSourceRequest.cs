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
    /// Container for the parameters to the UpdateDataSource operation.
    /// Updates the configurations for a data source connector.
    /// 
    ///  <important> 
    /// <para>
    /// You can't change the <c>chunkingConfiguration</c> after you create the data source
    /// connector. Specify the existing <c>chunkingConfiguration</c>.
    /// </para>
    ///  </important>
    /// </summary>
    public partial class UpdateDataSourceRequest : AmazonBedrockAgentRequest
    {
        private DataDeletionPolicy _dataDeletionPolicy;
        private DataSourceConfiguration _dataSourceConfiguration;
        private string _dataSourceId;
        private string _description;
        private string _knowledgeBaseId;
        private string _name;
        private ServerSideEncryptionConfiguration _serverSideEncryptionConfiguration;
        private VectorIngestionConfiguration _vectorIngestionConfiguration;

        /// <summary>
        /// Gets and sets the property DataDeletionPolicy. 
        /// <para>
        /// The data deletion policy for the data source that you want to update.
        /// </para>
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
        /// The connection configuration for the data source that you want to update.
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
        /// Gets and sets the property DataSourceId. 
        /// <para>
        /// The unique identifier of the data source.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string DataSourceId
        {
            get { return this._dataSourceId; }
            set { this._dataSourceId = value; }
        }

        // Check to see if DataSourceId property is set
        internal bool IsSetDataSourceId()
        {
            return this._dataSourceId != null;
        }

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// Specifies a new description for the data source.
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
        /// The unique identifier of the knowledge base for the data source.
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
        /// Specifies a new name for the data source.
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
        /// Contains details about server-side encryption of the data source.
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