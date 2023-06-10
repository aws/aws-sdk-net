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
 * Do not modify this file. This file is generated from the timestream-write-2018-11-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.TimestreamWrite.Model
{
    /// <summary>
    /// Details about a batch load task.
    /// </summary>
    public partial class BatchLoadTaskDescription
    {
        private DateTime? _creationTime;
        private DataModelConfiguration _dataModelConfiguration;
        private DataSourceConfiguration _dataSourceConfiguration;
        private string _errorMessage;
        private DateTime? _lastUpdatedTime;
        private BatchLoadProgressReport _progressReport;
        private long? _recordVersion;
        private ReportConfiguration _reportConfiguration;
        private DateTime? _resumableUntil;
        private string _targetDatabaseName;
        private string _targetTableName;
        private string _taskId;
        private BatchLoadStatus _taskStatus;

        /// <summary>
        /// Gets and sets the property CreationTime. 
        /// <para>
        /// The time when the Timestream batch load task was created.
        /// </para>
        /// </summary>
        public DateTime CreationTime
        {
            get { return this._creationTime.GetValueOrDefault(); }
            set { this._creationTime = value; }
        }

        // Check to see if CreationTime property is set
        internal bool IsSetCreationTime()
        {
            return this._creationTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property DataModelConfiguration. 
        /// <para>
        /// Data model configuration for a batch load task. This contains details about where
        /// a data model for a batch load task is stored.
        /// </para>
        /// </summary>
        public DataModelConfiguration DataModelConfiguration
        {
            get { return this._dataModelConfiguration; }
            set { this._dataModelConfiguration = value; }
        }

        // Check to see if DataModelConfiguration property is set
        internal bool IsSetDataModelConfiguration()
        {
            return this._dataModelConfiguration != null;
        }

        /// <summary>
        /// Gets and sets the property DataSourceConfiguration. 
        /// <para>
        /// Configuration details about the data source for a batch load task.
        /// </para>
        /// </summary>
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
        /// Gets and sets the property ErrorMessage.
        /// </summary>
        [AWSProperty(Min=1, Max=2048)]
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
        /// Gets and sets the property LastUpdatedTime. 
        /// <para>
        /// The time when the Timestream batch load task was last updated.
        /// </para>
        /// </summary>
        public DateTime LastUpdatedTime
        {
            get { return this._lastUpdatedTime.GetValueOrDefault(); }
            set { this._lastUpdatedTime = value; }
        }

        // Check to see if LastUpdatedTime property is set
        internal bool IsSetLastUpdatedTime()
        {
            return this._lastUpdatedTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property ProgressReport.
        /// </summary>
        public BatchLoadProgressReport ProgressReport
        {
            get { return this._progressReport; }
            set { this._progressReport = value; }
        }

        // Check to see if ProgressReport property is set
        internal bool IsSetProgressReport()
        {
            return this._progressReport != null;
        }

        /// <summary>
        /// Gets and sets the property RecordVersion.
        /// </summary>
        public long RecordVersion
        {
            get { return this._recordVersion.GetValueOrDefault(); }
            set { this._recordVersion = value; }
        }

        // Check to see if RecordVersion property is set
        internal bool IsSetRecordVersion()
        {
            return this._recordVersion.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property ReportConfiguration. 
        /// <para>
        /// Report configuration for a batch load task. This contains details about where error
        /// reports are stored.
        /// </para>
        /// </summary>
        public ReportConfiguration ReportConfiguration
        {
            get { return this._reportConfiguration; }
            set { this._reportConfiguration = value; }
        }

        // Check to see if ReportConfiguration property is set
        internal bool IsSetReportConfiguration()
        {
            return this._reportConfiguration != null;
        }

        /// <summary>
        /// Gets and sets the property ResumableUntil. 
        /// <para>
        ///  
        /// </para>
        /// </summary>
        public DateTime ResumableUntil
        {
            get { return this._resumableUntil.GetValueOrDefault(); }
            set { this._resumableUntil = value; }
        }

        // Check to see if ResumableUntil property is set
        internal bool IsSetResumableUntil()
        {
            return this._resumableUntil.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property TargetDatabaseName.
        /// </summary>
        public string TargetDatabaseName
        {
            get { return this._targetDatabaseName; }
            set { this._targetDatabaseName = value; }
        }

        // Check to see if TargetDatabaseName property is set
        internal bool IsSetTargetDatabaseName()
        {
            return this._targetDatabaseName != null;
        }

        /// <summary>
        /// Gets and sets the property TargetTableName.
        /// </summary>
        public string TargetTableName
        {
            get { return this._targetTableName; }
            set { this._targetTableName = value; }
        }

        // Check to see if TargetTableName property is set
        internal bool IsSetTargetTableName()
        {
            return this._targetTableName != null;
        }

        /// <summary>
        /// Gets and sets the property TaskId. 
        /// <para>
        /// The ID of the batch load task.
        /// </para>
        /// </summary>
        [AWSProperty(Min=3, Max=32)]
        public string TaskId
        {
            get { return this._taskId; }
            set { this._taskId = value; }
        }

        // Check to see if TaskId property is set
        internal bool IsSetTaskId()
        {
            return this._taskId != null;
        }

        /// <summary>
        /// Gets and sets the property TaskStatus. 
        /// <para>
        /// Status of the batch load task.
        /// </para>
        /// </summary>
        public BatchLoadStatus TaskStatus
        {
            get { return this._taskStatus; }
            set { this._taskStatus = value; }
        }

        // Check to see if TaskStatus property is set
        internal bool IsSetTaskStatus()
        {
            return this._taskStatus != null;
        }

    }
}