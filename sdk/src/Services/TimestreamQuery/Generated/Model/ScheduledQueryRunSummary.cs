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
 * Do not modify this file. This file is generated from the timestream-query-2018-11-01.normal.json service model.
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
namespace Amazon.TimestreamQuery.Model
{
    /// <summary>
    /// Run summary for the scheduled query
    /// </summary>
    public partial class ScheduledQueryRunSummary
    {
        private ErrorReportLocation _errorReportLocation;
        private ExecutionStats _executionStats;
        private string _failureReason;
        private DateTime? _invocationTime;
        private ScheduledQueryInsightsResponse _queryInsightsResponse;
        private ScheduledQueryRunStatus _runStatus;
        private DateTime? _triggerTime;

        /// <summary>
        /// Gets and sets the property ErrorReportLocation. 
        /// <para>
        /// S3 location for error report.
        /// </para>
        /// </summary>
        public ErrorReportLocation ErrorReportLocation
        {
            get { return this._errorReportLocation; }
            set { this._errorReportLocation = value; }
        }

        // Check to see if ErrorReportLocation property is set
        internal bool IsSetErrorReportLocation()
        {
            return this._errorReportLocation != null;
        }

        /// <summary>
        /// Gets and sets the property ExecutionStats. 
        /// <para>
        /// Runtime statistics for a scheduled run.
        /// </para>
        /// </summary>
        public ExecutionStats ExecutionStats
        {
            get { return this._executionStats; }
            set { this._executionStats = value; }
        }

        // Check to see if ExecutionStats property is set
        internal bool IsSetExecutionStats()
        {
            return this._executionStats != null;
        }

        /// <summary>
        /// Gets and sets the property FailureReason. 
        /// <para>
        /// Error message for the scheduled query in case of failure. You might have to look at
        /// the error report to get more detailed error reasons. 
        /// </para>
        /// </summary>
        public string FailureReason
        {
            get { return this._failureReason; }
            set { this._failureReason = value; }
        }

        // Check to see if FailureReason property is set
        internal bool IsSetFailureReason()
        {
            return this._failureReason != null;
        }

        /// <summary>
        /// Gets and sets the property InvocationTime. 
        /// <para>
        /// InvocationTime for this run. This is the time at which the query is scheduled to run.
        /// Parameter <c>@scheduled_runtime</c> can be used in the query to get the value. 
        /// </para>
        /// </summary>
        public DateTime? InvocationTime
        {
            get { return this._invocationTime; }
            set { this._invocationTime = value; }
        }

        // Check to see if InvocationTime property is set
        internal bool IsSetInvocationTime()
        {
            return this._invocationTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property QueryInsightsResponse. 
        /// <para>
        /// Provides various insights and metrics related to the run summary of the scheduled
        /// query.
        /// </para>
        /// </summary>
        public ScheduledQueryInsightsResponse QueryInsightsResponse
        {
            get { return this._queryInsightsResponse; }
            set { this._queryInsightsResponse = value; }
        }

        // Check to see if QueryInsightsResponse property is set
        internal bool IsSetQueryInsightsResponse()
        {
            return this._queryInsightsResponse != null;
        }

        /// <summary>
        /// Gets and sets the property RunStatus. 
        /// <para>
        /// The status of a scheduled query run.
        /// </para>
        /// </summary>
        public ScheduledQueryRunStatus RunStatus
        {
            get { return this._runStatus; }
            set { this._runStatus = value; }
        }

        // Check to see if RunStatus property is set
        internal bool IsSetRunStatus()
        {
            return this._runStatus != null;
        }

        /// <summary>
        /// Gets and sets the property TriggerTime. 
        /// <para>
        /// The actual time when the query was run.
        /// </para>
        /// </summary>
        public DateTime? TriggerTime
        {
            get { return this._triggerTime; }
            set { this._triggerTime = value; }
        }

        // Check to see if TriggerTime property is set
        internal bool IsSetTriggerTime()
        {
            return this._triggerTime.HasValue; 
        }

    }
}