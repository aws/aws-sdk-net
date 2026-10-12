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

namespace Amazon.PartnerCentralSelling.Model
{
    /// <summary>
    /// A summary of a single prospecting task, returned by <c>ListProspectingFromEngagementTasks</c>.
    /// Contains key metrics and status information without the full per-engagement detail
    /// available from <c>GetProspectingFromEngagementTask</c>.
    /// </summary>
    public partial class ProspectingTaskSummary
    {
        /// <summary>
        /// Gets and sets the property CompletedEngagementCount. 
        /// <para>
        /// The number of engagements that have been successfully converted into prospecting leads.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public int? CompletedEngagementCount { get; set; }

        /// <summary>
        /// Checks to see if the CompletedEngagementCount property is set.
        /// </summary>
        internal bool IsSetCompletedEngagementCount() => this.CompletedEngagementCount.HasValue;

        /// <summary>
        /// Gets and sets the property EndTime. 
        /// <para>
        /// The timestamp indicating when the task finished processing. This field is absent if
        /// the task is still in progress. The format follows ISO 8601 date-time notation.
        /// </para>
        /// </summary>
        public DateTime? EndTime { get; set; }

        /// <summary>
        /// Checks to see if the EndTime property is set.
        /// </summary>
        internal bool IsSetEndTime() => this.EndTime.HasValue;

        /// <summary>
        /// Gets and sets the property FailedEngagementCount. 
        /// <para>
        /// The number of engagements that failed to be converted. Retrieve the full task details
        /// using <c>GetProspectingFromEngagementTask</c> for per-engagement error information.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public int? FailedEngagementCount { get; set; }

        /// <summary>
        /// Checks to see if the FailedEngagementCount property is set.
        /// </summary>
        internal bool IsSetFailedEngagementCount() => this.FailedEngagementCount.HasValue;

        /// <summary>
        /// Gets and sets the property StartTime. 
        /// <para>
        /// The timestamp indicating when the task was initiated. The format follows ISO 8601
        /// date-time notation.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public DateTime? StartTime { get; set; }

        /// <summary>
        /// Checks to see if the StartTime property is set.
        /// </summary>
        internal bool IsSetStartTime() => this.StartTime.HasValue;

        /// <summary>
        /// Gets and sets the property TaskArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the task.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string TaskArn { get; set; }

        /// <summary>
        /// Checks to see if the TaskArn property is set.
        /// </summary>
        internal bool IsSetTaskArn() => this.TaskArn != null;

        /// <summary>
        /// Gets and sets the property TaskId. 
        /// <para>
        /// The unique identifier of the task. Use this value with <c>GetProspectingFromEngagementTask</c>
        /// to retrieve full task details.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string TaskId { get; set; }

        /// <summary>
        /// Checks to see if the TaskId property is set.
        /// </summary>
        internal bool IsSetTaskId() => this.TaskId != null;

        /// <summary>
        /// Gets and sets the property TaskName. 
        /// <para>
        /// The descriptive name of the task provided when it was created.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 128)]
        public string TaskName { get; set; }

        /// <summary>
        /// Checks to see if the TaskName property is set.
        /// </summary>
        internal bool IsSetTaskName() => this.TaskName != null;

        /// <summary>
        /// Gets and sets the property TotalEngagementCount. 
        /// <para>
        /// The total number of engagements included in the task.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public int? TotalEngagementCount { get; set; }

        /// <summary>
        /// Checks to see if the TotalEngagementCount property is set.
        /// </summary>
        internal bool IsSetTotalEngagementCount() => this.TotalEngagementCount.HasValue;
    }
}
