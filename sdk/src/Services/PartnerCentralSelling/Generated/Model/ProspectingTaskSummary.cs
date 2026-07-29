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
 * Do not modify this file. This file is generated from the partnercentral-selling-2022-07-26.normal.json service model.
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
namespace Amazon.PartnerCentralSelling.Model
{
    /// <summary>
    /// A summary of a single prospecting task, returned by <c>ListProspectingFromEngagementTasks</c>.
    /// Contains key metrics and status information without the full per-engagement detail
    /// available from <c>GetProspectingFromEngagementTask</c>.
    /// </summary>
    public partial class ProspectingTaskSummary
    {
        private int? _completedEngagementCount;
        private DateTime? _endTime;
        private int? _failedEngagementCount;
        private DateTime? _startTime;
        private string _taskArn;
        private string _taskId;
        private string _taskName;
        private int? _totalEngagementCount;

        /// <summary>
        /// Gets and sets the property CompletedEngagementCount. 
        /// <para>
        /// The number of engagements that have been successfully converted into prospecting leads.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public int? CompletedEngagementCount
        {
            get { return this._completedEngagementCount; }
            set { this._completedEngagementCount = value; }
        }

        // Check to see if CompletedEngagementCount property is set
        internal bool IsSetCompletedEngagementCount()
        {
            return this._completedEngagementCount.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property EndTime. 
        /// <para>
        /// The timestamp indicating when the task finished processing. This field is absent if
        /// the task is still in progress. The format follows ISO 8601 date-time notation.
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
        /// Gets and sets the property FailedEngagementCount. 
        /// <para>
        /// The number of engagements that failed to be converted. Retrieve the full task details
        /// using <c>GetProspectingFromEngagementTask</c> for per-engagement error information.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public int? FailedEngagementCount
        {
            get { return this._failedEngagementCount; }
            set { this._failedEngagementCount = value; }
        }

        // Check to see if FailedEngagementCount property is set
        internal bool IsSetFailedEngagementCount()
        {
            return this._failedEngagementCount.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property StartTime. 
        /// <para>
        /// The timestamp indicating when the task was initiated. The format follows ISO 8601
        /// date-time notation.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
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
        /// Gets and sets the property TaskArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the task.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string TaskArn
        {
            get { return this._taskArn; }
            set { this._taskArn = value; }
        }

        // Check to see if TaskArn property is set
        internal bool IsSetTaskArn()
        {
            return this._taskArn != null;
        }

        /// <summary>
        /// Gets and sets the property TaskId. 
        /// <para>
        /// The unique identifier of the task. Use this value with <c>GetProspectingFromEngagementTask</c>
        /// to retrieve full task details.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
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
        /// Gets and sets the property TaskName. 
        /// <para>
        /// The descriptive name of the task provided when it was created.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=128)]
        public string TaskName
        {
            get { return this._taskName; }
            set { this._taskName = value; }
        }

        // Check to see if TaskName property is set
        internal bool IsSetTaskName()
        {
            return this._taskName != null;
        }

        /// <summary>
        /// Gets and sets the property TotalEngagementCount. 
        /// <para>
        /// The total number of engagements included in the task.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public int? TotalEngagementCount
        {
            get { return this._totalEngagementCount; }
            set { this._totalEngagementCount = value; }
        }

        // Check to see if TotalEngagementCount property is set
        internal bool IsSetTotalEngagementCount()
        {
            return this._totalEngagementCount.HasValue; 
        }

    }
}