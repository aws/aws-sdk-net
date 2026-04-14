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
 * Do not modify this file. This file is generated from the deadline-2023-10-12.normal.json service model.
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
        private string _description;
        private string _farmId;
        private string _jobId;
        private UpdateJobLifecycleStatus _lifecycleStatus;
        private int? _maxFailedTasksCount;
        private int? _maxRetriesPerTask;
        private int? _maxWorkerCount;
        private string _name;
        private int? _priority;
        private string _queueId;
        private JobTargetTaskRunStatus _targetTaskRunStatus;

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// The description of the job to update.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive=true, Min=0, Max=2048)]
        public string Description
        {
            get { return this._description; }
            set { this._description = value; }
        }

        // Check to see if Description property is set
        internal bool IsSetDescription()
        {
            return this._description != null;
        }

        /// <summary>
        /// Gets and sets the property FarmId. 
        /// <para>
        /// The farm ID of the job to update.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string FarmId
        {
            get { return this._farmId; }
            set { this._farmId = value; }
        }

        // Check to see if FarmId property is set
        internal bool IsSetFarmId()
        {
            return this._farmId != null;
        }

        /// <summary>
        /// Gets and sets the property JobId. 
        /// <para>
        /// The job ID of the job to update.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string JobId
        {
            get { return this._jobId; }
            set { this._jobId = value; }
        }

        // Check to see if JobId property is set
        internal bool IsSetJobId()
        {
            return this._jobId != null;
        }

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
        public UpdateJobLifecycleStatus LifecycleStatus
        {
            get { return this._lifecycleStatus; }
            set { this._lifecycleStatus = value; }
        }

        // Check to see if LifecycleStatus property is set
        internal bool IsSetLifecycleStatus()
        {
            return this._lifecycleStatus != null;
        }

        /// <summary>
        /// Gets and sets the property MaxFailedTasksCount. 
        /// <para>
        /// The number of task failures before the job stops running and is marked as <c>FAILED</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=2147483647)]
        public int? MaxFailedTasksCount
        {
            get { return this._maxFailedTasksCount; }
            set { this._maxFailedTasksCount = value; }
        }

        // Check to see if MaxFailedTasksCount property is set
        internal bool IsSetMaxFailedTasksCount()
        {
            return this._maxFailedTasksCount.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property MaxRetriesPerTask. 
        /// <para>
        /// The maximum number of retries per failed tasks.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=2147483647)]
        public int? MaxRetriesPerTask
        {
            get { return this._maxRetriesPerTask; }
            set { this._maxRetriesPerTask = value; }
        }

        // Check to see if MaxRetriesPerTask property is set
        internal bool IsSetMaxRetriesPerTask()
        {
            return this._maxRetriesPerTask.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property MaxWorkerCount. 
        /// <para>
        /// The maximum number of worker hosts that can concurrently process a job.
        /// </para>
        /// </summary>
        [AWSProperty(Min=-1, Max=2147483647)]
        public int? MaxWorkerCount
        {
            get { return this._maxWorkerCount; }
            set { this._maxWorkerCount = value; }
        }

        // Check to see if MaxWorkerCount property is set
        internal bool IsSetMaxWorkerCount()
        {
            return this._maxWorkerCount.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the job to update.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=128)]
        public string Name
        {
            get { return this._name; }
            set { this._name = value; }
        }

        // Check to see if Name property is set
        internal bool IsSetName()
        {
            return this._name != null;
        }

        /// <summary>
        /// Gets and sets the property Priority. 
        /// <para>
        /// The job priority to update.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=100)]
        public int? Priority
        {
            get { return this._priority; }
            set { this._priority = value; }
        }

        // Check to see if Priority property is set
        internal bool IsSetPriority()
        {
            return this._priority.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property QueueId. 
        /// <para>
        /// The queue ID of the job to update.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string QueueId
        {
            get { return this._queueId; }
            set { this._queueId = value; }
        }

        // Check to see if QueueId property is set
        internal bool IsSetQueueId()
        {
            return this._queueId != null;
        }

        /// <summary>
        /// Gets and sets the property TargetTaskRunStatus. 
        /// <para>
        /// The task status to update the job's tasks to.
        /// </para>
        /// </summary>
        public JobTargetTaskRunStatus TargetTaskRunStatus
        {
            get { return this._targetTaskRunStatus; }
            set { this._targetTaskRunStatus = value; }
        }

        // Check to see if TargetTaskRunStatus property is set
        internal bool IsSetTargetTaskRunStatus()
        {
            return this._targetTaskRunStatus != null;
        }

    }
}