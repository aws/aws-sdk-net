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
 * Do not modify this file. This file is generated from the datazone-2018-05-10.normal.json service model.
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
namespace Amazon.DataZone.Model
{
    /// <summary>
    /// This is the response object from the GetDataSourceRun operation.
    /// </summary>
    public partial class GetDataSourceRunResponse : AmazonWebServiceResponse
    {
        private DateTime? _createdAt;
        private string _dataSourceConfigurationSnapshot;
        private string _dataSourceId;
        private string _domainId;
        private DataSourceErrorMessage _errorMessage;
        private string _id;
        private DataSourceRunLineageSummary _lineageSummary;
        private string _projectId;
        private RunStatisticsForAssets _runStatisticsForAssets;
        private DateTime? _startedAt;
        private DataSourceRunStatus _status;
        private DateTime? _stoppedAt;
        private DataSourceRunType _type;
        private DateTime? _updatedAt;

        /// <summary>
        /// Gets and sets the property CreatedAt. 
        /// <para>
        /// The timestamp of when the data source run was created.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
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
        /// Gets and sets the property DataSourceConfigurationSnapshot. 
        /// <para>
        /// The configuration snapshot of the data source run.
        /// </para>
        /// </summary>
        public string DataSourceConfigurationSnapshot
        {
            get { return this._dataSourceConfigurationSnapshot; }
            set { this._dataSourceConfigurationSnapshot = value; }
        }

        // Check to see if DataSourceConfigurationSnapshot property is set
        internal bool IsSetDataSourceConfigurationSnapshot()
        {
            return this._dataSourceConfigurationSnapshot != null;
        }

        /// <summary>
        /// Gets and sets the property DataSourceId. 
        /// <para>
        /// The ID of the data source for this data source run.
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
        /// Gets and sets the property DomainId. 
        /// <para>
        /// The ID of the domain in which this data source run was performed.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string DomainId
        {
            get { return this._domainId; }
            set { this._domainId = value; }
        }

        // Check to see if DomainId property is set
        internal bool IsSetDomainId()
        {
            return this._domainId != null;
        }

        /// <summary>
        /// Gets and sets the property ErrorMessage. 
        /// <para>
        /// Specifies the error message that is returned if the operation cannot be successfully
        /// completed.
        /// </para>
        /// </summary>
        public DataSourceErrorMessage ErrorMessage
        {
            get { return this._errorMessage; }
            set { this._errorMessage = value; }
        }

        // Check to see if ErrorMessage property is set
        internal bool IsSetErrorMessage()
        {
            return this._errorMessage != null;
        }

        /// <summary>
        /// Gets and sets the property Id. 
        /// <para>
        /// The ID of the data source run.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string Id
        {
            get { return this._id; }
            set { this._id = value; }
        }

        // Check to see if Id property is set
        internal bool IsSetId()
        {
            return this._id != null;
        }

        /// <summary>
        /// Gets and sets the property LineageSummary. 
        /// <para>
        /// The summary of the data lineage.
        /// </para>
        /// </summary>
        public DataSourceRunLineageSummary LineageSummary
        {
            get { return this._lineageSummary; }
            set { this._lineageSummary = value; }
        }

        // Check to see if LineageSummary property is set
        internal bool IsSetLineageSummary()
        {
            return this._lineageSummary != null;
        }

        /// <summary>
        /// Gets and sets the property ProjectId. 
        /// <para>
        /// The ID of the project in which this data source run occured.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string ProjectId
        {
            get { return this._projectId; }
            set { this._projectId = value; }
        }

        // Check to see if ProjectId property is set
        internal bool IsSetProjectId()
        {
            return this._projectId != null;
        }

        /// <summary>
        /// Gets and sets the property RunStatisticsForAssets. 
        /// <para>
        /// The asset statistics from this data source run.
        /// </para>
        /// </summary>
        public RunStatisticsForAssets RunStatisticsForAssets
        {
            get { return this._runStatisticsForAssets; }
            set { this._runStatisticsForAssets = value; }
        }

        // Check to see if RunStatisticsForAssets property is set
        internal bool IsSetRunStatisticsForAssets()
        {
            return this._runStatisticsForAssets != null;
        }

        /// <summary>
        /// Gets and sets the property StartedAt. 
        /// <para>
        /// The timestamp of when this data source run started.
        /// </para>
        /// </summary>
        public DateTime? StartedAt
        {
            get { return this._startedAt; }
            set { this._startedAt = value; }
        }

        // Check to see if StartedAt property is set
        internal bool IsSetStartedAt()
        {
            return this._startedAt.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The status of this data source run.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public DataSourceRunStatus Status
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
        /// Gets and sets the property StoppedAt. 
        /// <para>
        /// The timestamp of when this data source run stopped.
        /// </para>
        /// </summary>
        public DateTime? StoppedAt
        {
            get { return this._stoppedAt; }
            set { this._stoppedAt = value; }
        }

        // Check to see if StoppedAt property is set
        internal bool IsSetStoppedAt()
        {
            return this._stoppedAt.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Type. 
        /// <para>
        /// The type of this data source run.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public DataSourceRunType Type
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
        /// The timestamp of when this data source run was updated.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
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

    }
}