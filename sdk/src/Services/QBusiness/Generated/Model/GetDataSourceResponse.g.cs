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

namespace Amazon.QBusiness.Model
{
    /// <summary>
    /// This is the response object from the GetDataSource operation.
    /// </summary>
    public partial class GetDataSourceResponse : AmazonWebServiceResponse
    {
        /// <summary>
        /// Gets and sets the property ApplicationId. 
        /// <para>
        /// The identifier of the Amazon Q Business application.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 36, Max = 36)]
        public string ApplicationId { get; set; }

        /// <summary>
        /// Checks to see if the ApplicationId property is set.
        /// </summary>
        internal bool IsSetApplicationId() => this.ApplicationId != null;

        /// <summary>
        /// Gets and sets the property Configuration. 
        /// <para>
        /// The details of how the data source connector is configured.
        /// </para>
        /// </summary>
        public Amazon.Runtime.Documents.Document Configuration { get; set; }

        /// <summary>
        /// Checks to see if the Configuration property is set.
        /// </summary>
        internal bool IsSetConfiguration() => !this.Configuration.IsNull();

        /// <summary>
        /// Gets and sets the property CreatedAt. 
        /// <para>
        /// The Unix timestamp when the data source connector was created.
        /// </para>
        /// </summary>
        public DateTime? CreatedAt { get; set; }

        /// <summary>
        /// Checks to see if the CreatedAt property is set.
        /// </summary>
        internal bool IsSetCreatedAt() => this.CreatedAt.HasValue;

        /// <summary>
        /// Gets and sets the property DataSourceArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the data source.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 1284)]
        public string DataSourceArn { get; set; }

        /// <summary>
        /// Checks to see if the DataSourceArn property is set.
        /// </summary>
        internal bool IsSetDataSourceArn() => this.DataSourceArn != null;

        /// <summary>
        /// Gets and sets the property DataSourceId. 
        /// <para>
        /// The identifier of the data source connector.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 36, Max = 36)]
        public string DataSourceId { get; set; }

        /// <summary>
        /// Checks to see if the DataSourceId property is set.
        /// </summary>
        internal bool IsSetDataSourceId() => this.DataSourceId != null;

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// The description for the data source connector.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 1000)]
        public string Description { get; set; }

        /// <summary>
        /// Checks to see if the Description property is set.
        /// </summary>
        internal bool IsSetDescription() => this.Description != null;

        /// <summary>
        /// Gets and sets the property DisplayName. 
        /// <para>
        /// The name for the data source connector.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 1000)]
        public string DisplayName { get; set; }

        /// <summary>
        /// Checks to see if the DisplayName property is set.
        /// </summary>
        internal bool IsSetDisplayName() => this.DisplayName != null;

        /// <summary>
        /// Gets and sets the property DocumentEnrichmentConfiguration.
        /// </summary>
        public DocumentEnrichmentConfiguration DocumentEnrichmentConfiguration { get; set; }

        /// <summary>
        /// Checks to see if the DocumentEnrichmentConfiguration property is set.
        /// </summary>
        internal bool IsSetDocumentEnrichmentConfiguration() => this.DocumentEnrichmentConfiguration != null;

        /// <summary>
        /// Gets and sets the property Error. 
        /// <para>
        /// When the <c>Status</c> field value is <c>FAILED</c>, the <c>ErrorMessage</c> field
        /// contains a description of the error that caused the data source connector to fail.
        /// </para>
        /// </summary>
        public ErrorDetail Error { get; set; }

        /// <summary>
        /// Checks to see if the Error property is set.
        /// </summary>
        internal bool IsSetError() => this.Error != null;

        /// <summary>
        /// Gets and sets the property IndexId. 
        /// <para>
        /// The identifier of the index linked to the data source connector.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 36, Max = 36)]
        public string IndexId { get; set; }

        /// <summary>
        /// Checks to see if the IndexId property is set.
        /// </summary>
        internal bool IsSetIndexId() => this.IndexId != null;

        /// <summary>
        /// Gets and sets the property MediaExtractionConfiguration. 
        /// <para>
        /// The configuration for extracting information from media in documents for the data
        /// source. 
        /// </para>
        /// </summary>
        public MediaExtractionConfiguration MediaExtractionConfiguration { get; set; }

        /// <summary>
        /// Checks to see if the MediaExtractionConfiguration property is set.
        /// </summary>
        internal bool IsSetMediaExtractionConfiguration() => this.MediaExtractionConfiguration != null;

        /// <summary>
        /// Gets and sets the property RoleArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the role with permission to access the data source
        /// and required resources.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 1284)]
        public string RoleArn { get; set; }

        /// <summary>
        /// Checks to see if the RoleArn property is set.
        /// </summary>
        internal bool IsSetRoleArn() => this.RoleArn != null;

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The current status of the data source connector. When the <c>Status</c> field value
        /// is <c>FAILED</c>, the <c>ErrorMessage</c> field contains a description of the error
        /// that caused the data source connector to fail.
        /// </para>
        /// </summary>
        public DataSourceStatus Status { get; set; }

        /// <summary>
        /// Checks to see if the Status property is set.
        /// </summary>
        internal bool IsSetStatus() => this.Status != null;

        /// <summary>
        /// Gets and sets the property SyncSchedule. 
        /// <para>
        /// The schedule for Amazon Q Business to update the index.
        /// </para>
        /// </summary>
        [AWSProperty(Max = 998)]
        public string SyncSchedule { get; set; }

        /// <summary>
        /// Checks to see if the SyncSchedule property is set.
        /// </summary>
        internal bool IsSetSyncSchedule() => this.SyncSchedule != null;

        /// <summary>
        /// Gets and sets the property Type. 
        /// <para>
        /// The type of the data source connector. For example, <c>S3</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 2048)]
        public string Type { get; set; }

        /// <summary>
        /// Checks to see if the Type property is set.
        /// </summary>
        internal bool IsSetType() => this.Type != null;

        /// <summary>
        /// Gets and sets the property UpdatedAt. 
        /// <para>
        /// The Unix timestamp when the data source connector was last updated.
        /// </para>
        /// </summary>
        public DateTime? UpdatedAt { get; set; }

        /// <summary>
        /// Checks to see if the UpdatedAt property is set.
        /// </summary>
        internal bool IsSetUpdatedAt() => this.UpdatedAt.HasValue;

        /// <summary>
        /// Gets and sets the property VpcConfiguration. 
        /// <para>
        /// Configuration information for an Amazon VPC (Virtual Private Cloud) to connect to
        /// your data source.
        /// </para>
        /// </summary>
        public DataSourceVpcConfiguration VpcConfiguration { get; set; }

        /// <summary>
        /// Checks to see if the VpcConfiguration property is set.
        /// </summary>
        internal bool IsSetVpcConfiguration() => this.VpcConfiguration != null;
    }
}
