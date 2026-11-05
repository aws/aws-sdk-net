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
    /// The details of a job to update in a batch update operation.
    /// </summary>
    public partial class BatchUpdateJobItem
    {
        /// <summary>
        /// Gets and sets the property Description. The description of the job to update.
        /// </summary>
        [AWSProperty(Sensitive = true, Min = 0, Max = 2048)]
        public string Description { get; set; }

        /// <summary>
        /// Checks to see if the Description property is set.
        /// </summary>
        internal bool IsSetDescription() => this.Description != null;

        /// <summary>
        /// Gets and sets the property FarmId. The farm ID of the job to update.
        /// </summary>
        [AWSProperty(Required = true)]
        public string FarmId { get; set; }

        /// <summary>
        /// Checks to see if the FarmId property is set.
        /// </summary>
        internal bool IsSetFarmId() => this.FarmId != null;

        /// <summary>
        /// Gets and sets the property JobId. The job ID of the job to update.
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
        /// The status of a job in its lifecycle. When you change the status of the job to <c>ARCHIVED</c>,
        /// the job can't be scheduled or archived.
        /// </para>
        ///  <important> 
        /// <para>
        /// An archived job and its steps and tasks are deleted after 120 days. The job can't
        /// be recovered.
        /// </para>
        ///  </important>
        /// </summary>
        public UpdateJobLifecycleStatus LifecycleStatus { get; set; }

        /// <summary>
        /// Checks to see if the LifecycleStatus property is set.
        /// </summary>
        internal bool IsSetLifecycleStatus() => this.LifecycleStatus != null;

        /// <summary>
        /// Gets and sets the property MaxFailedTasksCount. The number of task failures before
        /// the job stops running and is marked as <c>FAILED</c>.
        /// </summary>
        [AWSProperty(Min = 0, Max = 2147483647)]
        public int? MaxFailedTasksCount { get; set; }

        /// <summary>
        /// Checks to see if the MaxFailedTasksCount property is set.
        /// </summary>
        internal bool IsSetMaxFailedTasksCount() => this.MaxFailedTasksCount.HasValue;

        /// <summary>
        /// Gets and sets the property MaxRetriesPerTask. The maximum number of retries per failed
        /// tasks.
        /// </summary>
        [AWSProperty(Min = 0, Max = 2147483647)]
        public int? MaxRetriesPerTask { get; set; }

        /// <summary>
        /// Checks to see if the MaxRetriesPerTask property is set.
        /// </summary>
        internal bool IsSetMaxRetriesPerTask() => this.MaxRetriesPerTask.HasValue;

        /// <summary>
        /// Gets and sets the property MaxWorkerCount. The maximum number of worker hosts that
        /// can concurrently process a job.
        /// </summary>
        [AWSProperty(Min = -1, Max = 2147483647)]
        public int? MaxWorkerCount { get; set; }

        /// <summary>
        /// Checks to see if the MaxWorkerCount property is set.
        /// </summary>
        internal bool IsSetMaxWorkerCount() => this.MaxWorkerCount.HasValue;

        /// <summary>
        /// Gets and sets the property Name. The name of the job to update.
        /// </summary>
        [AWSProperty(Min = 1, Max = 512)]
        public string Name { get; set; }

        /// <summary>
        /// Checks to see if the Name property is set.
        /// </summary>
        internal bool IsSetName() => this.Name != null;

        /// <summary>
        /// Gets and sets the property Priority. The job priority to update.
        /// </summary>
        [AWSProperty(Min = 0, Max = 100)]
        public int? Priority { get; set; }

        /// <summary>
        /// Checks to see if the Priority property is set.
        /// </summary>
        internal bool IsSetPriority() => this.Priority.HasValue;

        /// <summary>
        /// Gets and sets the property QueueId. The queue ID of the job to update.
        /// </summary>
        [AWSProperty(Required = true)]
        public string QueueId { get; set; }

        /// <summary>
        /// Checks to see if the QueueId property is set.
        /// </summary>
        internal bool IsSetQueueId() => this.QueueId != null;

        /// <summary>
        /// Gets and sets the property TargetTaskRunStatus. The task status to update the job's
        /// tasks to.
        /// </summary>
        public JobTargetTaskRunStatus TargetTaskRunStatus { get; set; }

        /// <summary>
        /// Checks to see if the TargetTaskRunStatus property is set.
        /// </summary>
        internal bool IsSetTargetTaskRunStatus() => this.TargetTaskRunStatus != null;
    }
}
