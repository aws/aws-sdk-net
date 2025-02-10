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
 * Do not modify this file. This file is generated from the qbusiness-2023-11-27.normal.json service model.
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
        private string _applicationId;
        private Amazon.Runtime.Documents.Document _configuration;
        private DateTime? _createdAt;
        private string _dataSourceArn;
        private string _dataSourceId;
        private string _description;
        private string _displayName;
        private DocumentEnrichmentConfiguration _documentEnrichmentConfiguration;
        private ErrorDetail _error;
        private string _indexId;
        private MediaExtractionConfiguration _mediaExtractionConfiguration;
        private string _roleArn;
        private DataSourceStatus _status;
        private string _syncSchedule;
        private string _type;
        private DateTime? _updatedAt;
        private DataSourceVpcConfiguration _vpcConfiguration;

        /// <summary>
        /// Gets and sets the property ApplicationId. 
        /// <para>
        /// The identifier of the Amazon Q Business application.
        /// </para>
        /// </summary>
        [AWSProperty(Min=36, Max=36)]
        public string ApplicationId
        {
            get { return this._applicationId; }
            set { this._applicationId = value; }
        }

        // Check to see if ApplicationId property is set
        internal bool IsSetApplicationId()
        {
            return this._applicationId != null;
        }

        /// <summary>
        /// Gets and sets the property Configuration. 
        /// <para>
        /// The details of how the data source connector is configured.
        /// </para>
        /// </summary>
        public Amazon.Runtime.Documents.Document Configuration
        {
            get { return this._configuration; }
            set { this._configuration = value; }
        }

        // Check to see if Configuration property is set
        internal bool IsSetConfiguration()
        {
            return !this._configuration.IsNull();
        }

        /// <summary>
        /// Gets and sets the property CreatedAt. 
        /// <para>
        /// The Unix timestamp when the data source connector was created.
        /// </para>
        /// </summary>
        public DateTime? CreatedAt
        {
            get { return this._createdAt; }
            set { this._createdAt = value; }
        }

        // Check to see if CreatedAt property is set
        internal bool IsSetCreatedAt()
        {
            return this._createdAt.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property DataSourceArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the data source.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=1284)]
        public string DataSourceArn
        {
            get { return this._dataSourceArn; }
            set { this._dataSourceArn = value; }
        }

        // Check to see if DataSourceArn property is set
        internal bool IsSetDataSourceArn()
        {
            return this._dataSourceArn != null;
        }

        /// <summary>
        /// Gets and sets the property DataSourceId. 
        /// <para>
        /// The identifier of the data source connector.
        /// </para>
        /// </summary>
        [AWSProperty(Min=36, Max=36)]
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
        /// The description for the data source connector.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=1000)]
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
        /// Gets and sets the property DisplayName. 
        /// <para>
        /// The name for the data source connector.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=1000)]
        public string DisplayName
        {
            get { return this._displayName; }
            set { this._displayName = value; }
        }

        // Check to see if DisplayName property is set
        internal bool IsSetDisplayName()
        {
            return this._displayName != null;
        }

        /// <summary>
        /// Gets and sets the property DocumentEnrichmentConfiguration.
        /// </summary>
        public DocumentEnrichmentConfiguration DocumentEnrichmentConfiguration
        {
            get { return this._documentEnrichmentConfiguration; }
            set { this._documentEnrichmentConfiguration = value; }
        }

        // Check to see if DocumentEnrichmentConfiguration property is set
        internal bool IsSetDocumentEnrichmentConfiguration()
        {
            return this._documentEnrichmentConfiguration != null;
        }

        /// <summary>
        /// Gets and sets the property Error. 
        /// <para>
        /// When the <c>Status</c> field value is <c>FAILED</c>, the <c>ErrorMessage</c> field
        /// contains a description of the error that caused the data source connector to fail.
        /// </para>
        /// </summary>
        public ErrorDetail Error
        {
            get { return this._error; }
            set { this._error = value; }
        }

        // Check to see if Error property is set
        internal bool IsSetError()
        {
            return this._error != null;
        }

        /// <summary>
        /// Gets and sets the property IndexId. 
        /// <para>
        /// The identifier of the index linked to the data source connector.
        /// </para>
        /// </summary>
        [AWSProperty(Min=36, Max=36)]
        public string IndexId
        {
            get { return this._indexId; }
            set { this._indexId = value; }
        }

        // Check to see if IndexId property is set
        internal bool IsSetIndexId()
        {
            return this._indexId != null;
        }

        /// <summary>
        /// Gets and sets the property MediaExtractionConfiguration. 
        /// <para>
        /// The configuration for extracting information from media in documents for the data
        /// source. 
        /// </para>
        /// </summary>
        public MediaExtractionConfiguration MediaExtractionConfiguration
        {
            get { return this._mediaExtractionConfiguration; }
            set { this._mediaExtractionConfiguration = value; }
        }

        // Check to see if MediaExtractionConfiguration property is set
        internal bool IsSetMediaExtractionConfiguration()
        {
            return this._mediaExtractionConfiguration != null;
        }

        /// <summary>
        /// Gets and sets the property RoleArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the role with permission to access the data source
        /// and required resources.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=1284)]
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
        /// Gets and sets the property Status. 
        /// <para>
        /// The current status of the data source connector. When the <c>Status</c> field value
        /// is <c>FAILED</c>, the <c>ErrorMessage</c> field contains a description of the error
        /// that caused the data source connector to fail.
        /// </para>
        /// </summary>
        public DataSourceStatus Status
        {
            get { return this._status; }
            set { this._status = value; }
        }

        // Check to see if Status property is set
        internal bool IsSetStatus()
        {
            return this._status != null;
        }

        /// <summary>
        /// Gets and sets the property SyncSchedule. 
        /// <para>
        /// The schedule for Amazon Q Business to update the index.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=998)]
        public string SyncSchedule
        {
            get { return this._syncSchedule; }
            set { this._syncSchedule = value; }
        }

        // Check to see if SyncSchedule property is set
        internal bool IsSetSyncSchedule()
        {
            return this._syncSchedule != null;
        }

        /// <summary>
        /// Gets and sets the property Type. 
        /// <para>
        /// The type of the data source connector. For example, <c>S3</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=2048)]
        public string Type
        {
            get { return this._type; }
            set { this._type = value; }
        }

        // Check to see if Type property is set
        internal bool IsSetType()
        {
            return this._type != null;
        }

        /// <summary>
        /// Gets and sets the property UpdatedAt. 
        /// <para>
        /// The Unix timestamp when the data source connector was last updated.
        /// </para>
        /// </summary>
        public DateTime? UpdatedAt
        {
            get { return this._updatedAt; }
            set { this._updatedAt = value; }
        }

        // Check to see if UpdatedAt property is set
        internal bool IsSetUpdatedAt()
        {
            return this._updatedAt.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property VpcConfiguration. 
        /// <para>
        /// Configuration information for an Amazon VPC (Virtual Private Cloud) to connect to
        /// your data source.
        /// </para>
        /// </summary>
        public DataSourceVpcConfiguration VpcConfiguration
        {
            get { return this._vpcConfiguration; }
            set { this._vpcConfiguration = value; }
        }

        // Check to see if VpcConfiguration property is set
        internal bool IsSetVpcConfiguration()
        {
            return this._vpcConfiguration != null;
        }

    }
}