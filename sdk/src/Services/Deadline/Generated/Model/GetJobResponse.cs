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
    /// This is the response object from the GetJob operation.
    /// </summary>
    public partial class GetJobResponse : AmazonWebServiceResponse
    {
        private Attachments _attachments;
        private DateTime? _createdAt;
        private string _createdBy;
        private string _description;
        private DateTime? _endedAt;
        private string _jobId;
        private JobLifecycleStatus _lifecycleStatus;
        private string _lifecycleStatusMessage;
        private int? _maxFailedTasksCount;
        private int? _maxRetriesPerTask;
        private int? _maxWorkerCount;
        private string _name;
        private Dictionary<string, JobParameter> _parameters = AWSConfigs.InitializeCollections ? new Dictionary<string, JobParameter>() : null;
        private int? _priority;
        private string _sourceJobId;
        private DateTime? _startedAt;
        private string _storageProfileId;
        private JobTargetTaskRunStatus _targetTaskRunStatus;
        private int? _taskFailureRetryCount;
        private TaskRunStatus _taskRunStatus;
        private Dictionary<string, int> _taskRunStatusCounts = AWSConfigs.InitializeCollections ? new Dictionary<string, int>() : null;
        private DateTime? _updatedAt;
        private string _updatedBy;

        /// <summary>
        /// Gets and sets the property Attachments. 
        /// <para>
        /// The attachments for the job.
        /// </para>
        /// </summary>
        public Attachments Attachments
        {
            get { return this._attachments; }
            set { this._attachments = value; }
        }

        // Check to see if Attachments property is set
        internal bool IsSetAttachments()
        {
            return this._attachments != null;
        }

        /// <summary>
        /// Gets and sets the property CreatedAt. 
        /// <para>
        /// The date and time the resource was created.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public DateTime? CreatedAt
        {
            get { return this._createdAt; }
            set { this._createdAt = value; }
        }

        // Check to see if CreatedAt property is set
        internal bool IsSetCreatedAt()
        {
            return this._createdAt.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property CreatedBy. 
        /// <para>
        /// The user or system that created this resource.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string CreatedBy
        {
            get { return this._createdBy; }
            set { this._createdBy = value; }
        }

        // Check to see if CreatedBy property is set
        internal bool IsSetCreatedBy()
        {
            return this._createdBy != null;
        }

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// The description of the job.
        /// </para>
        ///  <important> 
        /// <para>
        /// This field can store any content. Escape or encode this content before displaying
        /// it on a webpage or any other system that might interpret the content of this field.
        /// </para>
        ///  </important>
        /// </summary>
        [AWSProperty(Sensitive=true, Min=1, Max=2048)]
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
        /// Gets and sets the property EndedAt. 
        /// <para>
        /// The date and time the resource ended running.
        /// </para>
        /// </summary>
        public DateTime? EndedAt
        {
            get { return this._endedAt; }
            set { this._endedAt = value; }
        }

        // Check to see if EndedAt property is set
        internal bool IsSetEndedAt()
        {
            return this._endedAt.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property JobId. 
        /// <para>
        /// The job ID.
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
        /// The life cycle status for the job. 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public JobLifecycleStatus LifecycleStatus
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
        /// Gets and sets the property LifecycleStatusMessage. 
        /// <para>
        /// A message that communicates the status of the life cycle for the job.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string LifecycleStatusMessage
        {
            get { return this._lifecycleStatusMessage; }
            set { this._lifecycleStatusMessage = value; }
        }

        // Check to see if LifecycleStatusMessage property is set
        internal bool IsSetLifecycleStatusMessage()
        {
            return this._lifecycleStatusMessage != null;
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
        /// The maximum number of worker hosts that can concurrently process a job. When the <c>maxWorkerCount</c>
        /// is reached, no more workers will be assigned to process the job, even if the fleets
        /// assigned to the job's queue has available workers.
        /// </para>
        ///  
        /// <para>
        /// If you don't set the <c>maxWorkerCount</c> when you create a job, this value is not
        /// returned in the response.
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
        /// The name of the job.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=128)]
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
        /// Gets and sets the property Parameters. 
        /// <para>
        /// The parameters for the job.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Sensitive=true)]
        public Dictionary<string, JobParameter> Parameters
        {
            get { return this._parameters; }
            set { this._parameters = value; }
        }

        // Check to see if Parameters property is set
        internal bool IsSetParameters()
        {
            return this._parameters != null && (this._parameters.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property Priority. 
        /// <para>
        /// The job priority.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=0, Max=100)]
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
        /// Gets and sets the property SourceJobId. 
        /// <para>
        /// The job ID for the source job.
        /// </para>
        /// </summary>
        public string SourceJobId
        {
            get { return this._sourceJobId; }
            set { this._sourceJobId = value; }
        }

        // Check to see if SourceJobId property is set
        internal bool IsSetSourceJobId()
        {
            return this._sourceJobId != null;
        }

        /// <summary>
        /// Gets and sets the property StartedAt. 
        /// <para>
        /// The date and time the resource started running.
        /// </para>
        /// </summary>
        public DateTime? StartedAt
        {
            get { return this._startedAt; }
            set { this._startedAt = value; }
        }

        // Check to see if StartedAt property is set
        internal bool IsSetStartedAt()
        {
            return this._startedAt.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property StorageProfileId. 
        /// <para>
        /// The storage profile ID associated with the job.
        /// </para>
        /// </summary>
        public string StorageProfileId
        {
            get { return this._storageProfileId; }
            set { this._storageProfileId = value; }
        }

        // Check to see if StorageProfileId property is set
        internal bool IsSetStorageProfileId()
        {
            return this._storageProfileId != null;
        }

        /// <summary>
        /// Gets and sets the property TargetTaskRunStatus. 
        /// <para>
        /// The task status with which the job started.
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

        /// <summary>
        /// Gets and sets the property TaskFailureRetryCount. 
        /// <para>
        /// The total number of times tasks from the job failed and were retried.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=2147483647)]
        public int? TaskFailureRetryCount
        {
            get { return this._taskFailureRetryCount; }
            set { this._taskFailureRetryCount = value; }
        }

        // Check to see if TaskFailureRetryCount property is set
        internal bool IsSetTaskFailureRetryCount()
        {
            return this._taskFailureRetryCount.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property TaskRunStatus. 
        /// <para>
        /// The task run status for the job.
        /// </para>
        /// </summary>
        public TaskRunStatus TaskRunStatus
        {
            get { return this._taskRunStatus; }
            set { this._taskRunStatus = value; }
        }

        // Check to see if TaskRunStatus property is set
        internal bool IsSetTaskRunStatus()
        {
            return this._taskRunStatus != null;
        }

        /// <summary>
        /// Gets and sets the property TaskRunStatusCounts. 
        /// <para>
        /// The number of tasks running on the job.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public Dictionary<string, int> TaskRunStatusCounts
        {
            get { return this._taskRunStatusCounts; }
            set { this._taskRunStatusCounts = value; }
        }

        // Check to see if TaskRunStatusCounts property is set
        internal bool IsSetTaskRunStatusCounts()
        {
            return this._taskRunStatusCounts != null && (this._taskRunStatusCounts.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property UpdatedAt. 
        /// <para>
        /// The date and time the resource was updated.
        /// </para>
        /// </summary>
        public DateTime? UpdatedAt
        {
            get { return this._updatedAt; }
            set { this._updatedAt = value; }
        }

        // Check to see if UpdatedAt property is set
        internal bool IsSetUpdatedAt()
        {
            return this._updatedAt.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property UpdatedBy. 
        /// <para>
        /// The user or system that updated this resource.
        /// </para>
        /// </summary>
        public string UpdatedBy
        {
            get { return this._updatedBy; }
            set { this._updatedBy = value; }
        }

        // Check to see if UpdatedBy property is set
        internal bool IsSetUpdatedBy()
        {
            return this._updatedBy != null;
        }

    }
}