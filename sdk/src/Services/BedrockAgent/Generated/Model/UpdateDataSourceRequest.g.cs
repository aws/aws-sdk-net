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
    /// Container for the parameters to the UpdateDataSource operation. Updates the configurations
    /// for a data source connector. <important> <para> You can't change the <c>chunkingConfiguration</c>
    /// after you create the data source connector. Specify the existing <c>chunkingConfiguration</c>.
    /// </para> </important>
    /// </summary>
    public partial class UpdateDataSourceRequest : AmazonBedrockAgentRequest
    {
        /// <summary>
        /// Gets and sets the property DataDeletionPolicy. 
        /// <para>
        /// The data deletion policy for the data source that you want to update.
        /// </para>
        /// </summary>
        public DataDeletionPolicy DataDeletionPolicy { get; set; }

        /// <summary>
        /// Checks to see if the DataDeletionPolicy property is set.
        /// </summary>
        internal bool IsSetDataDeletionPolicy() => this.DataDeletionPolicy != null;

        /// <summary>
        /// Gets and sets the property DataSourceConfiguration. 
        /// <para>
        /// The connection configuration for the data source that you want to update.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public DataSourceConfiguration DataSourceConfiguration { get; set; }

        /// <summary>
        /// Checks to see if the DataSourceConfiguration property is set.
        /// </summary>
        internal bool IsSetDataSourceConfiguration() => this.DataSourceConfiguration != null;

        /// <summary>
        /// Gets and sets the property DataSourceId. 
        /// <para>
        /// The unique identifier of the data source.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string DataSourceId { get; set; }

        /// <summary>
        /// Checks to see if the DataSourceId property is set.
        /// </summary>
        internal bool IsSetDataSourceId() => this.DataSourceId != null;

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// Specifies a new description for the data source.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 200)]
        public string Description { get; set; }

        /// <summary>
        /// Checks to see if the Description property is set.
        /// </summary>
        internal bool IsSetDescription() => this.Description != null;

        /// <summary>
        /// Gets and sets the property KnowledgeBaseId. 
        /// <para>
        /// The unique identifier of the knowledge base for the data source.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string KnowledgeBaseId { get; set; }

        /// <summary>
        /// Checks to see if the KnowledgeBaseId property is set.
        /// </summary>
        internal bool IsSetKnowledgeBaseId() => this.KnowledgeBaseId != null;

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// Specifies a new name for the data source.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string Name { get; set; }

        /// <summary>
        /// Checks to see if the Name property is set.
        /// </summary>
        internal bool IsSetName() => this.Name != null;

        /// <summary>
        /// Gets and sets the property ServerSideEncryptionConfiguration. 
        /// <para>
        /// Contains details about server-side encryption of the data source.
        /// </para>
        /// </summary>
        public ServerSideEncryptionConfiguration ServerSideEncryptionConfiguration { get; set; }

        /// <summary>
        /// Checks to see if the ServerSideEncryptionConfiguration property is set.
        /// </summary>
        internal bool IsSetServerSideEncryptionConfiguration() => this.ServerSideEncryptionConfiguration != null;

        /// <summary>
        /// Gets and sets the property VectorIngestionConfiguration. 
        /// <para>
        /// Contains details about how to ingest the documents in the data source.
        /// </para>
        /// </summary>
        public VectorIngestionConfiguration VectorIngestionConfiguration { get; set; }

        /// <summary>
        /// Checks to see if the VectorIngestionConfiguration property is set.
        /// </summary>
        internal bool IsSetVectorIngestionConfiguration() => this.VectorIngestionConfiguration != null;
    }
}
