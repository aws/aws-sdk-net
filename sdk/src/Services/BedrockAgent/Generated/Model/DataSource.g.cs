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
    /// Contains details about a data source.
    /// </summary>
    public partial class DataSource
    {
        /// <summary>
        /// Gets and sets the property CreatedAt. 
        /// <para>
        /// The time at which the data source was created.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public DateTime? CreatedAt { get; set; }

        /// <summary>
        /// Checks to see if the CreatedAt property is set.
        /// </summary>
        internal bool IsSetCreatedAt() => this.CreatedAt.HasValue;

        /// <summary>
        /// Gets and sets the property DataDeletionPolicy. 
        /// <para>
        /// The data deletion policy for the data source.
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
        /// The connection configuration for the data source.
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
        /// The description of the data source.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 200)]
        public string Description { get; set; }

        /// <summary>
        /// Checks to see if the Description property is set.
        /// </summary>
        internal bool IsSetDescription() => this.Description != null;

        /// <summary>
        /// Gets and sets the property FailureReasons. 
        /// <para>
        /// The detailed reasons on the failure to delete a data source.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Max = 2048)]
        public List<string> FailureReasons { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the FailureReasons property is set.
        /// </summary>
        internal bool IsSetFailureReasons() => this.FailureReasons != null && (this.FailureReasons.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property KnowledgeBaseId. 
        /// <para>
        /// The unique identifier of the knowledge base to which the data source belongs.
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
        /// The name of the data source.
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
        /// Contains details about the configuration of the server-side encryption.
        /// </para>
        /// </summary>
        public ServerSideEncryptionConfiguration ServerSideEncryptionConfiguration { get; set; }

        /// <summary>
        /// Checks to see if the ServerSideEncryptionConfiguration property is set.
        /// </summary>
        internal bool IsSetServerSideEncryptionConfiguration() => this.ServerSideEncryptionConfiguration != null;

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The status of the data source. The following statuses are possible:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Available – The data source has been created and is ready for ingestion into the knowledge
        /// base.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Deleting – The data source is being deleted.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        [AWSProperty(Required = true)]
        public DataSourceStatus Status { get; set; }

        /// <summary>
        /// Checks to see if the Status property is set.
        /// </summary>
        internal bool IsSetStatus() => this.Status != null;

        /// <summary>
        /// Gets and sets the property UpdatedAt. 
        /// <para>
        /// The time at which the data source was last updated.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public DateTime? UpdatedAt { get; set; }

        /// <summary>
        /// Checks to see if the UpdatedAt property is set.
        /// </summary>
        internal bool IsSetUpdatedAt() => this.UpdatedAt.HasValue;

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
