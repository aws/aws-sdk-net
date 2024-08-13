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
    /// Provides information about an Amazon Q Business data source connector synchronization
    /// job.
    /// </summary>
    public partial class DataSourceSyncJob
    {
        private string _dataSourceErrorCode;
        private DateTime? _endTime;
        private ErrorDetail _error;
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
        /// Gets and sets the property Error. 
        /// <para>
        /// If the <c>Status</c> field is set to <c>FAILED</c>, the <c>ErrorCode</c> field indicates
        /// the reason the synchronization failed. 
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
        /// Gets and sets the property ExecutionId. 
        /// <para>
        /// The identifier of a data source synchronization job.
        /// </para>
        /// </summary>
        [AWSProperty(Min=36, Max=36)]
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
        /// The Unix time stamp when the data source synchronization job started.
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
        /// The status of the synchronization job. When the <c>Status</c> field is set to <c>SUCCEEDED</c>,
        /// the synchronization job is done. If the status code is <c>FAILED</c>, the <c>ErrorCode</c>
        /// and <c>ErrorMessage</c> fields give you the reason for the failure.
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