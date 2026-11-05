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

namespace Amazon.Deadline.Model
{
    /// <summary>
    /// The details of a task.
    /// </summary>
    public partial class TaskSummary
    {
        /// <summary>
        /// Gets and sets the property CreatedAt. The date and time the resource was created.
        /// </summary>
        [AWSProperty(Required = true)]
        public DateTime? CreatedAt { get; set; }

        /// <summary>
        /// Checks to see if the CreatedAt property is set.
        /// </summary>
        internal bool IsSetCreatedAt() => this.CreatedAt.HasValue;

        /// <summary>
        /// Gets and sets the property CreatedBy. The user or system that created this resource.
        /// </summary>
        [AWSProperty(Required = true)]
        public string CreatedBy { get; set; }

        /// <summary>
        /// Checks to see if the CreatedBy property is set.
        /// </summary>
        internal bool IsSetCreatedBy() => this.CreatedBy != null;

        /// <summary>
        /// Gets and sets the property EndedAt. The date and time the resource ended running.
        /// </summary>
        public DateTime? EndedAt { get; set; }

        /// <summary>
        /// Checks to see if the EndedAt property is set.
        /// </summary>
        internal bool IsSetEndedAt() => this.EndedAt.HasValue;

        /// <summary>
        /// Gets and sets the property FailureRetryCount. The number of times that the task failed
        /// and was retried.
        /// </summary>
        [AWSProperty(Min = 0, Max = 2147483647)]
        public int? FailureRetryCount { get; set; }

        /// <summary>
        /// Checks to see if the FailureRetryCount property is set.
        /// </summary>
        internal bool IsSetFailureRetryCount() => this.FailureRetryCount.HasValue;

        /// <summary>
        /// Gets and sets the property LatestSessionActionId. The latest session action ID for
        /// the task.
        /// </summary>
        public string LatestSessionActionId { get; set; }

        /// <summary>
        /// Checks to see if the LatestSessionActionId property is set.
        /// </summary>
        internal bool IsSetLatestSessionActionId() => this.LatestSessionActionId != null;

        /// <summary>
        /// Gets and sets the property Parameters. The task parameters.
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Sensitive = true)]
        public Dictionary<string, TaskParameterValue> Parameters { get; set; } = AWSConfigs.InitializeCollections ? new Dictionary<string, TaskParameterValue>() : null;

        /// <summary>
        /// Checks to see if the Parameters property is set.
        /// </summary>
        internal bool IsSetParameters() => this.Parameters != null && (this.Parameters.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property RunStatus. The run status of the task.
        /// </summary>
        [AWSProperty(Required = true)]
        public TaskRunStatus RunStatus { get; set; }

        /// <summary>
        /// Checks to see if the RunStatus property is set.
        /// </summary>
        internal bool IsSetRunStatus() => this.RunStatus != null;

        /// <summary>
        /// Gets and sets the property StartedAt. The date and time the resource started running.
        /// </summary>
        public DateTime? StartedAt { get; set; }

        /// <summary>
        /// Checks to see if the StartedAt property is set.
        /// </summary>
        internal bool IsSetStartedAt() => this.StartedAt.HasValue;

        /// <summary>
        /// Gets and sets the property TargetRunStatus. The run status on which the started.
        /// </summary>
        public TaskTargetRunStatus TargetRunStatus { get; set; }

        /// <summary>
        /// Checks to see if the TargetRunStatus property is set.
        /// </summary>
        internal bool IsSetTargetRunStatus() => this.TargetRunStatus != null;

        /// <summary>
        /// Gets and sets the property TaskId. The task ID.
        /// </summary>
        [AWSProperty(Required = true)]
        public string TaskId { get; set; }

        /// <summary>
        /// Checks to see if the TaskId property is set.
        /// </summary>
        internal bool IsSetTaskId() => this.TaskId != null;

        /// <summary>
        /// Gets and sets the property UpdatedAt. The date and time the resource was updated.
        /// </summary>
        public DateTime? UpdatedAt { get; set; }

        /// <summary>
        /// Checks to see if the UpdatedAt property is set.
        /// </summary>
        internal bool IsSetUpdatedAt() => this.UpdatedAt.HasValue;

        /// <summary>
        /// Gets and sets the property UpdatedBy. The user or system that updated this resource.
        /// </summary>
        public string UpdatedBy { get; set; }

        /// <summary>
        /// Checks to see if the UpdatedBy property is set.
        /// </summary>
        internal bool IsSetUpdatedBy() => this.UpdatedBy != null;
    }
}
