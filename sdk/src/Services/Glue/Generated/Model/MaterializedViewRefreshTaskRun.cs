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
 * Do not modify this file. This file is generated from the glue-2017-03-31.normal.json service model.
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
namespace Amazon.Glue.Model
{
    /// <summary>
    /// The object that shows the details of the materialized view refresh task run.
    /// </summary>
    public partial class MaterializedViewRefreshTaskRun
    {
        private string _catalogId;
        private DateTime? _creationTime;
        private string _customerId;
        private string _databaseName;
        private double? _dpuSeconds;
        private DateTime? _endTime;
        private string _errorMessage;
        private DateTime? _lastUpdated;
        private string _materializedViewRefreshTaskRunId;
        private long? _processedBytes;
        private MaterializedViewRefreshType _refreshType;
        private string _role;
        private DateTime? _startTime;
        private MaterializedViewRefreshState _status;
        private string _tableName;

        /// <summary>
        /// Gets and sets the property CatalogId. 
        /// <para>
        /// The ID of the Data Catalog where the table resides. If none is supplied, the account
        /// ID is used by default.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=255)]
        public string CatalogId
        {
            get { return this._catalogId; }
            set { this._catalogId = value; }
        }

        // Check to see if CatalogId property is set
        internal bool IsSetCatalogId()
        {
            return this._catalogId != null;
        }

        /// <summary>
        /// Gets and sets the property CreationTime. 
        /// <para>
        /// The time that this task was created.
        /// </para>
        /// </summary>
        public DateTime? CreationTime
        {
            get { return this._creationTime; }
            set { this._creationTime = value; }
        }

        // Check to see if CreationTime property is set
        internal bool IsSetCreationTime()
        {
            return this._creationTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property CustomerId. 
        /// <para>
        /// The Amazon Web Services account ID.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=12)]
        public string CustomerId
        {
            get { return this._customerId; }
            set { this._customerId = value; }
        }

        // Check to see if CustomerId property is set
        internal bool IsSetCustomerId()
        {
            return this._customerId != null;
        }

        /// <summary>
        /// Gets and sets the property DatabaseName. 
        /// <para>
        /// The database where the table resides.
        /// </para>
        /// </summary>
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
        /// Gets and sets the property DPUSeconds. 
        /// <para>
        /// The calculated DPU usage in seconds for all autoscaled workers.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0)]
        public double? DPUSeconds
        {
            get { return this._dpuSeconds; }
            set { this._dpuSeconds = value; }
        }

        // Check to see if DPUSeconds property is set
        internal bool IsSetDPUSeconds()
        {
            return this._dpuSeconds.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property EndTime. 
        /// <para>
        /// The end time of the task.
        /// </para>
        /// </summary>
        public DateTime? EndTime
        {
            get { return this._endTime; }
            set { this._endTime = value; }
        }

        // Check to see if EndTime property is set
        internal bool IsSetEndTime()
        {
            return this._endTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property ErrorMessage. 
        /// <para>
        /// The error message for the job.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=2048)]
        public string ErrorMessage
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
        /// Gets and sets the property LastUpdated. 
        /// <para>
        /// The last point in time when this task was modified.
        /// </para>
        /// </summary>
        public DateTime? LastUpdated
        {
            get { return this._lastUpdated; }
            set { this._lastUpdated = value; }
        }

        // Check to see if LastUpdated property is set
        internal bool IsSetLastUpdated()
        {
            return this._lastUpdated.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property MaterializedViewRefreshTaskRunId. 
        /// <para>
        /// The identifier of the materialized view refresh task run.
        /// </para>
        /// </summary>
        public string MaterializedViewRefreshTaskRunId
        {
            get { return this._materializedViewRefreshTaskRunId; }
            set { this._materializedViewRefreshTaskRunId = value; }
        }

        // Check to see if MaterializedViewRefreshTaskRunId property is set
        internal bool IsSetMaterializedViewRefreshTaskRunId()
        {
            return this._materializedViewRefreshTaskRunId != null;
        }

        /// <summary>
        /// Gets and sets the property ProcessedBytes. 
        /// <para>
        /// The number of bytes the refresh task run has scanned to refresh the materialized view.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0)]
        public long? ProcessedBytes
        {
            get { return this._processedBytes; }
            set { this._processedBytes = value; }
        }

        // Check to see if ProcessedBytes property is set
        internal bool IsSetProcessedBytes()
        {
            return this._processedBytes.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property RefreshType. 
        /// <para>
        /// The type of the refresh task run. Either FULL or INCREMENTAL.
        /// </para>
        /// </summary>
        public MaterializedViewRefreshType RefreshType
        {
            get { return this._refreshType; }
            set { this._refreshType = value; }
        }

        // Check to see if RefreshType property is set
        internal bool IsSetRefreshType()
        {
            return this._refreshType != null;
        }

        /// <summary>
        /// Gets and sets the property Role. 
        /// <para>
        /// The IAM role that the service assumes to generate statistics.
        /// </para>
        /// </summary>
        public string Role
        {
            get { return this._role; }
            set { this._role = value; }
        }

        // Check to see if Role property is set
        internal bool IsSetRole()
        {
            return this._role != null;
        }

        /// <summary>
        /// Gets and sets the property StartTime. 
        /// <para>
        /// The start time of the task.
        /// </para>
        /// </summary>
        public DateTime? StartTime
        {
            get { return this._startTime; }
            set { this._startTime = value; }
        }

        // Check to see if StartTime property is set
        internal bool IsSetStartTime()
        {
            return this._startTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The status of the task run.
        /// </para>
        /// </summary>
        public MaterializedViewRefreshState Status
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
        /// Gets and sets the property TableName. 
        /// <para>
        /// The name of the table for which statistics is generated.
        /// </para>
        /// </summary>
        public string TableName
        {
            get { return this._tableName; }
            set { this._tableName = value; }
        }

        // Check to see if TableName property is set
        internal bool IsSetTableName()
        {
            return this._tableName != null;
        }

    }
}