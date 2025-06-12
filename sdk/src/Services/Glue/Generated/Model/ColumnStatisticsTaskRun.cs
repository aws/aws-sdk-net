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
    /// The object that shows the details of the column stats run.
    /// </summary>
    public partial class ColumnStatisticsTaskRun
    {
        private string _catalogID;
        private List<string> _columnNameList = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private string _columnStatisticsTaskRunId;
        private ComputationType _computationType;
        private DateTime? _creationTime;
        private string _customerId;
        private string _databaseName;
        private double? _dpuSeconds;
        private DateTime? _endTime;
        private string _errorMessage;
        private DateTime? _lastUpdated;
        private int? _numberOfWorkers;
        private string _role;
        private double? _sampleSize;
        private string _securityConfiguration;
        private DateTime? _startTime;
        private ColumnStatisticsState _status;
        private string _tableName;
        private string _workerType;

        /// <summary>
        /// Gets and sets the property CatalogID. 
        /// <para>
        /// The ID of the Data Catalog where the table resides. If none is supplied, the Amazon
        /// Web Services account ID is used by default.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=255)]
        public string CatalogID
        {
            get { return this._catalogID; }
            set { this._catalogID = value; }
        }

        // Check to see if CatalogID property is set
        internal bool IsSetCatalogID()
        {
            return this._catalogID != null;
        }

        /// <summary>
        /// Gets and sets the property ColumnNameList. 
        /// <para>
        /// A list of the column names. If none is supplied, all column names for the table will
        /// be used by default.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> ColumnNameList
        {
            get { return this._columnNameList; }
            set { this._columnNameList = value; }
        }

        // Check to see if ColumnNameList property is set
        internal bool IsSetColumnNameList()
        {
            return this._columnNameList != null && (this._columnNameList.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property ColumnStatisticsTaskRunId. 
        /// <para>
        /// The identifier for the particular column statistics task run.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=255)]
        public string ColumnStatisticsTaskRunId
        {
            get { return this._columnStatisticsTaskRunId; }
            set { this._columnStatisticsTaskRunId = value; }
        }

        // Check to see if ColumnStatisticsTaskRunId property is set
        internal bool IsSetColumnStatisticsTaskRunId()
        {
            return this._columnStatisticsTaskRunId != null;
        }

        /// <summary>
        /// Gets and sets the property ComputationType. 
        /// <para>
        /// The type of column statistics computation.
        /// </para>
        /// </summary>
        public ComputationType ComputationType
        {
            get { return this._computationType; }
            set { this._computationType = value; }
        }

        // Check to see if ComputationType property is set
        internal bool IsSetComputationType()
        {
            return this._computationType != null;
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
        /// Gets and sets the property NumberOfWorkers. 
        /// <para>
        /// The number of workers used to generate column statistics. The job is preconfigured
        /// to autoscale up to 25 instances.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1)]
        public int? NumberOfWorkers
        {
            get { return this._numberOfWorkers; }
            set { this._numberOfWorkers = value; }
        }

        // Check to see if NumberOfWorkers property is set
        internal bool IsSetNumberOfWorkers()
        {
            return this._numberOfWorkers.HasValue; 
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
        /// Gets and sets the property SampleSize. 
        /// <para>
        /// The percentage of rows used to generate statistics. If none is supplied, the entire
        /// table will be used to generate stats.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=100)]
        public double? SampleSize
        {
            get { return this._sampleSize; }
            set { this._sampleSize = value; }
        }

        // Check to see if SampleSize property is set
        internal bool IsSetSampleSize()
        {
            return this._sampleSize.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property SecurityConfiguration. 
        /// <para>
        /// Name of the security configuration that is used to encrypt CloudWatch logs for the
        /// column stats task run.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=128)]
        public string SecurityConfiguration
        {
            get { return this._securityConfiguration; }
            set { this._securityConfiguration = value; }
        }

        // Check to see if SecurityConfiguration property is set
        internal bool IsSetSecurityConfiguration()
        {
            return this._securityConfiguration != null;
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
        public ColumnStatisticsState Status
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
        /// The name of the table for which column statistics is generated.
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

        /// <summary>
        /// Gets and sets the property WorkerType. 
        /// <para>
        /// The type of workers being used for generating stats. The default is <c>g.1x</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=255)]
        public string WorkerType
        {
            get { return this._workerType; }
            set { this._workerType = value; }
        }

        // Check to see if WorkerType property is set
        internal bool IsSetWorkerType()
        {
            return this._workerType != null;
        }

    }
}