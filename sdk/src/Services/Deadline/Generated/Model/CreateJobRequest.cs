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
    /// Container for the parameters to the CreateJob operation.
    /// Creates a job. A job is a set of instructions that Deadline Cloud uses to schedule
    /// and run work on available workers. For more information, see <a href="https://docs.aws.amazon.com/deadline-cloud/latest/userguide/deadline-cloud-jobs.html">Deadline
    /// Cloud jobs</a>.
    /// </summary>
    public partial class CreateJobRequest : AmazonDeadlineRequest
    {
        private Attachments _attachments;
        private string _clientToken;
        private string _farmId;
        private int? _maxFailedTasksCount;
        private int? _maxRetriesPerTask;
        private int? _maxWorkerCount;
        private Dictionary<string, JobParameter> _parameters = AWSConfigs.InitializeCollections ? new Dictionary<string, JobParameter>() : null;
        private int? _priority;
        private string _queueId;
        private string _sourceJobId;
        private string _storageProfileId;
        private CreateJobTargetTaskRunStatus _targetTaskRunStatus;
        private string _template;
        private JobTemplateType _templateType;

        /// <summary>
        /// Gets and sets the property Attachments. 
        /// <para>
        /// The attachments for the job. Attach files required for the job to run to a render
        /// job.
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
        /// The farm ID of the farm to connect to the job.
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
        /// The maximum number of retries for each task.
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
        /// You can't set the <c>maxWorkerCount</c> to 0. If you set it to -1, there is no maximum
        /// number of workers.
        /// </para>
        ///  
        /// <para>
        /// If you don't specify the <c>maxWorkerCount</c>, Deadline Cloud won't throttle the
        /// number of workers used to process the job.
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
        /// The priority of the job. The highest priority (first scheduled) is 100. When two jobs
        /// have the same priority, the oldest job is scheduled first.
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
        /// Gets and sets the property QueueId. 
        /// <para>
        /// The ID of the queue that the job is submitted to.
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
        /// Gets and sets the property StorageProfileId. 
        /// <para>
        /// The storage profile ID for the storage profile to connect to the job.
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
        /// The initial job status when it is created. Jobs that are created with a <c>SUSPENDED</c>
        /// status will not run until manually requeued.
        /// </para>
        /// </summary>
        public CreateJobTargetTaskRunStatus TargetTaskRunStatus
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
        /// Gets and sets the property Template. 
        /// <para>
        /// The job template to use for this job.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive=true, Min=1, Max=1000000)]
        public string Template
        {
            get { return this._template; }
            set { this._template = value; }
        }

        // Check to see if Template property is set
        internal bool IsSetTemplate()
        {
            return this._template != null;
        }

        /// <summary>
        /// Gets and sets the property TemplateType. 
        /// <para>
        /// The file type for the job template.
        /// </para>
        /// </summary>
        public JobTemplateType TemplateType
        {
            get { return this._templateType; }
            set { this._templateType = value; }
        }

        // Check to see if TemplateType property is set
        internal bool IsSetTemplateType()
        {
            return this._templateType != null;
        }

    }
}