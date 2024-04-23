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

namespace Amazon.Deadline.Model
{
    /// <summary>
    /// Container for the parameters to the UpdateJob operation.
    /// Updates a job.
    /// </summary>
    public partial class UpdateJobRequest : AmazonDeadlineRequest
    {
        private string _clientToken;
        private string _farmId;
        private string _jobId;
        private UpdateJobLifecycleStatus _lifecycleStatus;
        private int? _maxFailedTasksCount;
        private int? _maxRetriesPerTask;
        private int? _priority;
        private string _queueId;
        private JobTargetTaskRunStatus _targetTaskRunStatus;

        /// <summary>
        /// Gets and sets the property ClientToken. 
        /// <para>
        /// The unique token which the server uses to recognize retries of the same request.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=64)]
        public string ClientToken
        {
            get { return this._clientToken; }
            set { this._clientToken = value; }
        }

        // Check to see if ClientToken property is set
        internal bool IsSetClientToken()
        {
            return this._clientToken != null;
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
        /// The job ID to update.
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
        /// The status of a job in its lifecycle.
        /// </para>
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
        public int MaxFailedTasksCount
        {
            get { return this._maxFailedTasksCount.GetValueOrDefault(); }
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
        /// The maximum number of retries for a job.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=2147483647)]
        public int MaxRetriesPerTask
        {
            get { return this._maxRetriesPerTask.GetValueOrDefault(); }
            set { this._maxRetriesPerTask = value; }
        }

        // Check to see if MaxRetriesPerTask property is set
        internal bool IsSetMaxRetriesPerTask()
        {
            return this._maxRetriesPerTask.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Priority. 
        /// <para>
        /// The job priority to update.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=100)]
        public int Priority
        {
            get { return this._priority.GetValueOrDefault(); }
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