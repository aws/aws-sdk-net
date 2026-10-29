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

namespace Amazon.TimestreamQuery.Model
{
    /// <summary>
    /// Run summary for the scheduled query
    /// </summary>
    public partial class ScheduledQueryRunSummary
    {
        /// <summary>
        /// Gets and sets the property ErrorReportLocation. 
        /// <para>
        /// S3 location for error report.
        /// </para>
        /// </summary>
        public ErrorReportLocation ErrorReportLocation { get; set; }

        /// <summary>
        /// Checks to see if the ErrorReportLocation property is set.
        /// </summary>
        internal bool IsSetErrorReportLocation() => this.ErrorReportLocation != null;

        /// <summary>
        /// Gets and sets the property ExecutionStats. 
        /// <para>
        /// Runtime statistics for a scheduled run.
        /// </para>
        /// </summary>
        public ExecutionStats ExecutionStats { get; set; }

        /// <summary>
        /// Checks to see if the ExecutionStats property is set.
        /// </summary>
        internal bool IsSetExecutionStats() => this.ExecutionStats != null;

        /// <summary>
        /// Gets and sets the property FailureReason. 
        /// <para>
        /// Error message for the scheduled query in case of failure. You might have to look at
        /// the error report to get more detailed error reasons. 
        /// </para>
        /// </summary>
        public string FailureReason { get; set; }

        /// <summary>
        /// Checks to see if the FailureReason property is set.
        /// </summary>
        internal bool IsSetFailureReason() => this.FailureReason != null;

        /// <summary>
        /// Gets and sets the property InvocationTime. 
        /// <para>
        /// InvocationTime for this run. This is the time at which the query is scheduled to run.
        /// Parameter <c>@scheduled_runtime</c> can be used in the query to get the value. 
        /// </para>
        /// </summary>
        public DateTime? InvocationTime { get; set; }

        /// <summary>
        /// Checks to see if the InvocationTime property is set.
        /// </summary>
        internal bool IsSetInvocationTime() => this.InvocationTime.HasValue;

        /// <summary>
        /// Gets and sets the property QueryInsightsResponse. 
        /// <para>
        /// Provides various insights and metrics related to the run summary of the scheduled
        /// query.
        /// </para>
        /// </summary>
        public ScheduledQueryInsightsResponse QueryInsightsResponse { get; set; }

        /// <summary>
        /// Checks to see if the QueryInsightsResponse property is set.
        /// </summary>
        internal bool IsSetQueryInsightsResponse() => this.QueryInsightsResponse != null;

        /// <summary>
        /// Gets and sets the property RunStatus. 
        /// <para>
        /// The status of a scheduled query run.
        /// </para>
        /// </summary>
        public ScheduledQueryRunStatus RunStatus { get; set; }

        /// <summary>
        /// Checks to see if the RunStatus property is set.
        /// </summary>
        internal bool IsSetRunStatus() => this.RunStatus != null;

        /// <summary>
        /// Gets and sets the property TriggerTime. 
        /// <para>
        /// The actual time when the query was run.
        /// </para>
        /// </summary>
        public DateTime? TriggerTime { get; set; }

        /// <summary>
        /// Checks to see if the TriggerTime property is set.
        /// </summary>
        internal bool IsSetTriggerTime() => this.TriggerTime.HasValue;
    }
}
