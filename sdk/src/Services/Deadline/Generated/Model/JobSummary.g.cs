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
    /// A summary of job details.
    /// </summary>
    public partial class JobSummary
    {
        /// <summary>
        /// Gets and sets the property CreatedAt. 
        /// <para>
        /// The date and time the resource was created.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public DateTime? CreatedAt { get; set; }

        /// <summary>
        /// Checks to see if the CreatedAt property is set.
        /// </summary>
        internal bool IsSetCreatedAt() => this.CreatedAt.HasValue;

        /// <summary>
        /// Gets and sets the property CreatedBy. 
        /// <para>
        /// The user or system that created this resource.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string CreatedBy { get; set; }

        /// <summary>
        /// Checks to see if the CreatedBy property is set.
        /// </summary>
        internal bool IsSetCreatedBy() => this.CreatedBy != null;

        /// <summary>
        /// Gets and sets the property EndedAt. 
        /// <para>
        /// The date and time the resource ended running.
        /// </para>
        /// </summary>
        public DateTime? EndedAt { get; set; }

        /// <summary>
        /// Checks to see if the EndedAt property is set.
        /// </summary>
        internal bool IsSetEndedAt() => this.EndedAt.HasValue;

        /// <summary>
        /// Gets and sets the property JobId. 
        /// <para>
        /// The job ID.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string JobId { get; set; }

        /// <summary>
        /// Checks to see if the JobId property is set.
        /// </summary>
        internal bool IsSetJobId() => this.JobId != null;

        /// <summary>
        /// Gets and sets the property LifecycleStatus. 
        /// <para>
        /// The life cycle status.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public JobLifecycleStatus LifecycleStatus { get; set; }

        /// <summary>
        /// Checks to see if the LifecycleStatus property is set.
        /// </summary>
        internal bool IsSetLifecycleStatus() => this.LifecycleStatus != null;

        /// <summary>
        /// Gets and sets the property LifecycleStatusMessage. 
        /// <para>
        /// The life cycle status message.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string LifecycleStatusMessage { get; set; }

        /// <summary>
        /// Checks to see if the LifecycleStatusMessage property is set.
        /// </summary>
        internal bool IsSetLifecycleStatusMessage() => this.LifecycleStatusMessage != null;

        /// <summary>
        /// Gets and sets the property MaxFailedTasksCount. 
        /// <para>
        /// The number of task failures before the job stops running and is marked as <c>FAILED</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 2147483647)]
        public int? MaxFailedTasksCount { get; set; }

        /// <summary>
        /// Checks to see if the MaxFailedTasksCount property is set.
        /// </summary>
        internal bool IsSetMaxFailedTasksCount() => this.MaxFailedTasksCount.HasValue;

        /// <summary>
        /// Gets and sets the property MaxRetriesPerTask. 
        /// <para>
        /// The maximum number of retries for a job.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 2147483647)]
        public int? MaxRetriesPerTask { get; set; }

        /// <summary>
        /// Checks to see if the MaxRetriesPerTask property is set.
        /// </summary>
        internal bool IsSetMaxRetriesPerTask() => this.MaxRetriesPerTask.HasValue;

        /// <summary>
        /// Gets and sets the property MaxWorkerCount. 
        /// <para>
        /// The maximum number of worker hosts that can concurrently process a job. When the <c>maxWorkerCount</c>
        /// is reached, no more workers will be assigned to process the job, even if the fleets
        /// assigned to the job's queue has available workers.
        /// </para>
        ///  
        /// <para>
        /// You can't set the <c>maxWorkerCount</c> to 0. If you set it to -1, there is no maximum
        /// number of workers.
        /// </para>
        ///  
        /// <para>
        /// If you don't specify the <c>maxWorkerCount</c>, the default is -1.
        /// </para>
        /// </summary>
        [AWSProperty(Min = -1, Max = 2147483647)]
        public int? MaxWorkerCount { get; set; }

        /// <summary>
        /// Checks to see if the MaxWorkerCount property is set.
        /// </summary>
        internal bool IsSetMaxWorkerCount() => this.MaxWorkerCount.HasValue;

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The job name.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 512)]
        public string Name { get; set; }

        /// <summary>
        /// Checks to see if the Name property is set.
        /// </summary>
        internal bool IsSetName() => this.Name != null;

        /// <summary>
        /// Gets and sets the property Priority. 
        /// <para>
        /// The job priority.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 0, Max = 100)]
        public int? Priority { get; set; }

        /// <summary>
        /// Checks to see if the Priority property is set.
        /// </summary>
        internal bool IsSetPriority() => this.Priority.HasValue;

        /// <summary>
        /// Gets and sets the property SourceJobId. 
        /// <para>
        /// The job ID for the source job.
        /// </para>
        /// </summary>
        public string SourceJobId { get; set; }

        /// <summary>
        /// Checks to see if the SourceJobId property is set.
        /// </summary>
        internal bool IsSetSourceJobId() => this.SourceJobId != null;

        /// <summary>
        /// Gets and sets the property StartedAt. 
        /// <para>
        /// The date and time the resource started running.
        /// </para>
        /// </summary>
        public DateTime? StartedAt { get; set; }

        /// <summary>
        /// Checks to see if the StartedAt property is set.
        /// </summary>
        internal bool IsSetStartedAt() => this.StartedAt.HasValue;

        /// <summary>
        /// Gets and sets the property TargetTaskRunStatus. 
        /// <para>
        /// The task status to update the job's tasks to.
        /// </para>
        /// </summary>
        public JobTargetTaskRunStatus TargetTaskRunStatus { get; set; }

        /// <summary>
        /// Checks to see if the TargetTaskRunStatus property is set.
        /// </summary>
        internal bool IsSetTargetTaskRunStatus() => this.TargetTaskRunStatus != null;

        /// <summary>
        /// Gets and sets the property TaskFailureRetryCount. 
        /// <para>
        /// The total number of times tasks from the job failed and were retried.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 2147483647)]
        public int? TaskFailureRetryCount { get; set; }

        /// <summary>
        /// Checks to see if the TaskFailureRetryCount property is set.
        /// </summary>
        internal bool IsSetTaskFailureRetryCount() => this.TaskFailureRetryCount.HasValue;

        /// <summary>
        /// Gets and sets the property TaskRunStatus. 
        /// <para>
        /// The task run status for the job.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>PENDING</c>–pending and waiting for resources.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>READY</c>–ready to be processed.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>ASSIGNED</c>–assigned and will run next on a worker.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>SCHEDULED</c>–scheduled to be run on a worker.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>INTERRUPTING</c>–being interrupted.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>RUNNING</c>–running on a worker.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>SUSPENDED</c>–the task is suspended.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>CANCELED</c>–the task has been canceled.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>FAILED</c>–the task has failed.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>SUCCEEDED</c>–the task has succeeded.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public TaskRunStatus TaskRunStatus { get; set; }

        /// <summary>
        /// Checks to see if the TaskRunStatus property is set.
        /// </summary>
        internal bool IsSetTaskRunStatus() => this.TaskRunStatus != null;

        /// <summary>
        /// Gets and sets the property TaskRunStatusCounts. 
        /// <para>
        /// The number of tasks running on the job.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public Dictionary<string, int> TaskRunStatusCounts { get; set; } = AWSConfigs.InitializeCollections ? new Dictionary<string, int>() : null;

        /// <summary>
        /// Checks to see if the TaskRunStatusCounts property is set.
        /// </summary>
        internal bool IsSetTaskRunStatusCounts() => this.TaskRunStatusCounts != null && (this.TaskRunStatusCounts.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property UpdatedAt. 
        /// <para>
        /// The date and time the resource was updated.
        /// </para>
        /// </summary>
        public DateTime? UpdatedAt { get; set; }

        /// <summary>
        /// Checks to see if the UpdatedAt property is set.
        /// </summary>
        internal bool IsSetUpdatedAt() => this.UpdatedAt.HasValue;

        /// <summary>
        /// Gets and sets the property UpdatedBy. 
        /// <para>
        /// The user or system that updated this resource.
        /// </para>
        /// </summary>
        public string UpdatedBy { get; set; }

        /// <summary>
        /// Checks to see if the UpdatedBy property is set.
        /// </summary>
        internal bool IsSetUpdatedBy() => this.UpdatedBy != null;
    }
}
