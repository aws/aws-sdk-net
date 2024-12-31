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
    /// The activity details of the data source run.
    /// </summary>
    public partial class DataSourceRunActivity
    {
        private DateTime? _createdAt;
        private string _dataAssetId;
        private DataAssetActivityStatus _dataAssetStatus;
        private string _database;
        private string _dataSourceRunId;
        private DataSourceErrorMessage _errorMessage;
        private LineageInfo _lineageSummary;
        private string _projectId;
        private string _technicalDescription;
        private string _technicalName;
        private DateTime? _updatedAt;

        /// <summary>
        /// Gets and sets the property CreatedAt. 
        /// <para>
        /// The timestamp of when data source run activity was created.
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
        /// Gets and sets the property DataAssetId. 
        /// <para>
        /// The identifier of the asset included in the data source run activity.
        /// </para>
        /// </summary>
        public string DataAssetId
        {
            get { return this._dataAssetId; }
            set { this._dataAssetId = value; }
        }

        // Check to see if DataAssetId property is set
        internal bool IsSetDataAssetId()
        {
            return this._dataAssetId != null;
        }

        /// <summary>
        /// Gets and sets the property DataAssetStatus. 
        /// <para>
        /// The status of the asset included in the data source run activity.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public DataAssetActivityStatus DataAssetStatus
        {
            get { return this._dataAssetStatus; }
            set { this._dataAssetStatus = value; }
        }

        // Check to see if DataAssetStatus property is set
        internal bool IsSetDataAssetStatus()
        {
            return this._dataAssetStatus != null;
        }

        /// <summary>
        /// Gets and sets the property Database. 
        /// <para>
        /// The database included in the data source run activity.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Sensitive=true, Min=1, Max=256)]
        public string Database
        {
            get { return this._database; }
            set { this._database = value; }
        }

        // Check to see if Database property is set
        internal bool IsSetDatabase()
        {
            return this._database != null;
        }

        /// <summary>
        /// Gets and sets the property DataSourceRunId. 
        /// <para>
        /// The identifier of the data source for the data source run activity.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string DataSourceRunId
        {
            get { return this._dataSourceRunId; }
            set { this._dataSourceRunId = value; }
        }

        // Check to see if DataSourceRunId property is set
        internal bool IsSetDataSourceRunId()
        {
            return this._dataSourceRunId != null;
        }

        /// <summary>
        /// Gets and sets the property ErrorMessage.
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
        /// Gets and sets the property LineageSummary. 
        /// <para>
        /// The data lineage summary.
        /// </para>
        /// </summary>
        public LineageInfo LineageSummary
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
        /// The project ID included in the data source run activity.
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
        /// Gets and sets the property TechnicalDescription. 
        /// <para>
        /// The technical description included in the data source run activity.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive=true, Min=0, Max=2048)]
        public string TechnicalDescription
        {
            get { return this._technicalDescription; }
            set { this._technicalDescription = value; }
        }

        // Check to see if TechnicalDescription property is set
        internal bool IsSetTechnicalDescription()
        {
            return this._technicalDescription != null;
        }

        /// <summary>
        /// Gets and sets the property TechnicalName. 
        /// <para>
        /// The technical name included in the data source run activity.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Sensitive=true, Min=1, Max=256)]
        public string TechnicalName
        {
            get { return this._technicalName; }
            set { this._technicalName = value; }
        }

        // Check to see if TechnicalName property is set
        internal bool IsSetTechnicalName()
        {
            return this._technicalName != null;
        }

        /// <summary>
        /// Gets and sets the property UpdatedAt. 
        /// <para>
        /// The timestamp of when data source run activity was updated.
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