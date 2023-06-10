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
 * Do not modify this file. This file is generated from the kendra-2019-02-03.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.Kendra.Model
{
    /// <summary>
    /// Provides information about a data source synchronization job.
    /// </summary>
    public partial class DataSourceSyncJob
    {
        private string _dataSourceErrorCode;
        private DateTime? _endTime;
        private ErrorCode _errorCode;
        private string _errorMessage;
        private string _executionId;
        private DataSourceSyncJobMetrics _metrics;
        private DateTime? _startTime;
        private DataSourceSyncJobStatus _status;

        /// <summary>
        /// Gets and sets the property DataSourceErrorCode. 
        /// <para>
        /// If the reason that the synchronization failed is due to an error with the underlying
        /// data source, this field contains a code that identifies the error.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=2048)]
        public string DataSourceErrorCode
        {
            get { return this._dataSourceErrorCode; }
            set { this._dataSourceErrorCode = value; }
        }

        // Check to see if DataSourceErrorCode property is set
        internal bool IsSetDataSourceErrorCode()
        {
            return this._dataSourceErrorCode != null;
        }

        /// <summary>
        /// Gets and sets the property EndTime. 
        /// <para>
        /// The Unix timestamp when the synchronization job completed.
        /// </para>
        /// </summary>
        public DateTime EndTime
        {
            get { return this._endTime.GetValueOrDefault(); }
            set { this._endTime = value; }
        }

        // Check to see if EndTime property is set
        internal bool IsSetEndTime()
        {
            return this._endTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property ErrorCode. 
        /// <para>
        /// If the <code>Status</code> field is set to <code>FAILED</code>, the <code>ErrorCode</code>
        /// field indicates the reason the synchronization failed.
        /// </para>
        /// </summary>
        public ErrorCode ErrorCode
        {
            get { return this._errorCode; }
            set { this._errorCode = value; }
        }

        // Check to see if ErrorCode property is set
        internal bool IsSetErrorCode()
        {
            return this._errorCode != null;
        }

        /// <summary>
        /// Gets and sets the property ErrorMessage. 
        /// <para>
        /// If the <code>Status</code> field is set to <code>ERROR</code>, the <code>ErrorMessage</code>
        /// field contains a description of the error that caused the synchronization to fail.
        /// </para>
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
        /// Gets and sets the property ExecutionId. 
        /// <para>
        /// A identifier for the synchronization job.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=2048)]
        public string ExecutionId
        {
            get { return this._executionId; }
            set { this._executionId = value; }
        }

        // Check to see if ExecutionId property is set
        internal bool IsSetExecutionId()
        {
            return this._executionId != null;
        }

        /// <summary>
        /// Gets and sets the property Metrics. 
        /// <para>
        /// Maps a batch delete document request to a specific data source sync job. This is optional
        /// and should only be supplied when documents are deleted by a data source connector.
        /// </para>
        /// </summary>
        public DataSourceSyncJobMetrics Metrics
        {
            get { return this._metrics; }
            set { this._metrics = value; }
        }

        // Check to see if Metrics property is set
        internal bool IsSetMetrics()
        {
            return this._metrics != null;
        }

        /// <summary>
        /// Gets and sets the property StartTime. 
        /// <para>
        /// The Unix timestamp when the synchronization job started.
        /// </para>
        /// </summary>
        public DateTime StartTime
        {
            get { return this._startTime.GetValueOrDefault(); }
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
        /// The execution status of the synchronization job. When the <code>Status</code> field
        /// is set to <code>SUCCEEDED</code>, the synchronization job is done. If the status code
        /// is set to <code>FAILED</code>, the <code>ErrorCode</code> and <code>ErrorMessage</code>
        /// fields give you the reason for the failure.
        /// </para>
        /// </summary>
        public DataSourceSyncJobStatus Status
        {
            get { return this._status; }
            set { this._status = value; }
        }

        // Check to see if Status property is set
        internal bool IsSetStatus()
        {
            return this._status != null;
        }

    }
}