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
 * Do not modify this file. This file is generated from the batch-2016-08-10.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.Batch.Model
{
    /// <summary>
    /// An object that represents an Batch job.
    /// </summary>
    public partial class JobDetail
    {
        private ArrayPropertiesDetail _arrayProperties;
        private List<AttemptDetail> _attempts = new List<AttemptDetail>();
        private ContainerDetail _container;
        private long? _createdAt;
        private List<JobDependency> _dependsOn = new List<JobDependency>();
        private List<EksAttemptDetail> _eksAttempts = new List<EksAttemptDetail>();
        private EksPropertiesDetail _eksProperties;
        private bool? _isCancelled;
        private bool? _isTerminated;
        private string _jobArn;
        private string _jobDefinition;
        private string _jobId;
        private string _jobName;
        private string _jobQueue;
        private NodeDetails _nodeDetails;
        private NodeProperties _nodeProperties;
        private Dictionary<string, string> _parameters = new Dictionary<string, string>();
        private List<string> _platformCapabilities = new List<string>();
        private bool? _propagateTags;
        private RetryStrategy _retryStrategy;
        private int? _schedulingPriority;
        private string _shareIdentifier;
        private long? _startedAt;
        private JobStatus _status;
        private string _statusReason;
        private long? _stoppedAt;
        private Dictionary<string, string> _tags = new Dictionary<string, string>();
        private JobTimeout _timeout;

        /// <summary>
        /// Gets and sets the property ArrayProperties. 
        /// <para>
        /// The array properties of the job, if it's an array job.
        /// </para>
        /// </summary>
        public ArrayPropertiesDetail ArrayProperties
        {
            get { return this._arrayProperties; }
            set { this._arrayProperties = value; }
        }

        // Check to see if ArrayProperties property is set
        internal bool IsSetArrayProperties()
        {
            return this._arrayProperties != null;
        }

        /// <summary>
        /// Gets and sets the property Attempts. 
        /// <para>
        /// A list of job attempts that are associated with this job.
        /// </para>
        /// </summary>
        public List<AttemptDetail> Attempts
        {
            get { return this._attempts; }
            set { this._attempts = value; }
        }

        // Check to see if Attempts property is set
        internal bool IsSetAttempts()
        {
            return this._attempts != null && this._attempts.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property Container. 
        /// <para>
        /// An object that represents the details for the container that's associated with the
        /// job.
        /// </para>
        /// </summary>
        public ContainerDetail Container
        {
            get { return this._container; }
            set { this._container = value; }
        }

        // Check to see if Container property is set
        internal bool IsSetContainer()
        {
            return this._container != null;
        }

        /// <summary>
        /// Gets and sets the property CreatedAt. 
        /// <para>
        /// The Unix timestamp (in milliseconds) for when the job was created. For non-array jobs
        /// and parent array jobs, this is when the job entered the <code>SUBMITTED</code> state.
        /// This is specifically at the time <a>SubmitJob</a> was called. For array child jobs,
        /// this is when the child job was spawned by its parent and entered the <code>PENDING</code>
        /// state.
        /// </para>
        /// </summary>
        public long CreatedAt
        {
            get { return this._createdAt.GetValueOrDefault(); }
            set { this._createdAt = value; }
        }

        // Check to see if CreatedAt property is set
        internal bool IsSetCreatedAt()
        {
            return this._createdAt.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property DependsOn. 
        /// <para>
        /// A list of job IDs that this job depends on.
        /// </para>
        /// </summary>
        public List<JobDependency> DependsOn
        {
            get { return this._dependsOn; }
            set { this._dependsOn = value; }
        }

        // Check to see if DependsOn property is set
        internal bool IsSetDependsOn()
        {
            return this._dependsOn != null && this._dependsOn.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property EksAttempts. 
        /// <para>
        /// A list of job attempts that are associated with this job.
        /// </para>
        /// </summary>
        public List<EksAttemptDetail> EksAttempts
        {
            get { return this._eksAttempts; }
            set { this._eksAttempts = value; }
        }

        // Check to see if EksAttempts property is set
        internal bool IsSetEksAttempts()
        {
            return this._eksAttempts != null && this._eksAttempts.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property EksProperties. 
        /// <para>
        /// An object with various properties that are specific to Amazon EKS based jobs. Only
        /// one of <code>container</code>, <code>eksProperties</code>, or <code>nodeDetails</code>
        /// is specified.
        /// </para>
        /// </summary>
        public EksPropertiesDetail EksProperties
        {
            get { return this._eksProperties; }
            set { this._eksProperties = value; }
        }

        // Check to see if EksProperties property is set
        internal bool IsSetEksProperties()
        {
            return this._eksProperties != null;
        }

        /// <summary>
        /// Gets and sets the property IsCancelled. 
        /// <para>
        /// Indicates whether the job is canceled.
        /// </para>
        /// </summary>
        public bool IsCancelled
        {
            get { return this._isCancelled.GetValueOrDefault(); }
            set { this._isCancelled = value; }
        }

        // Check to see if IsCancelled property is set
        internal bool IsSetIsCancelled()
        {
            return this._isCancelled.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property IsTerminated. 
        /// <para>
        /// Indicates whether the job is terminated.
        /// </para>
        /// </summary>
        public bool IsTerminated
        {
            get { return this._isTerminated.GetValueOrDefault(); }
            set { this._isTerminated = value; }
        }

        // Check to see if IsTerminated property is set
        internal bool IsSetIsTerminated()
        {
            return this._isTerminated.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property JobArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the job.
        /// </para>
        /// </summary>
        public string JobArn
        {
            get { return this._jobArn; }
            set { this._jobArn = value; }
        }

        // Check to see if JobArn property is set
        internal bool IsSetJobArn()
        {
            return this._jobArn != null;
        }

        /// <summary>
        /// Gets and sets the property JobDefinition. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the job definition that this job uses.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string JobDefinition
        {
            get { return this._jobDefinition; }
            set { this._jobDefinition = value; }
        }

        // Check to see if JobDefinition property is set
        internal bool IsSetJobDefinition()
        {
            return this._jobDefinition != null;
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
        /// Gets and sets the property JobName. 
        /// <para>
        /// The job name.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string JobName
        {
            get { return this._jobName; }
            set { this._jobName = value; }
        }

        // Check to see if JobName property is set
        internal bool IsSetJobName()
        {
            return this._jobName != null;
        }

        /// <summary>
        /// Gets and sets the property JobQueue. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the job queue that the job is associated with.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string JobQueue
        {
            get { return this._jobQueue; }
            set { this._jobQueue = value; }
        }

        // Check to see if JobQueue property is set
        internal bool IsSetJobQueue()
        {
            return this._jobQueue != null;
        }

        /// <summary>
        /// Gets and sets the property NodeDetails. 
        /// <para>
        /// An object that represents the details of a node that's associated with a multi-node
        /// parallel job.
        /// </para>
        /// </summary>
        public NodeDetails NodeDetails
        {
            get { return this._nodeDetails; }
            set { this._nodeDetails = value; }
        }

        // Check to see if NodeDetails property is set
        internal bool IsSetNodeDetails()
        {
            return this._nodeDetails != null;
        }

        /// <summary>
        /// Gets and sets the property NodeProperties. 
        /// <para>
        /// An object that represents the node properties of a multi-node parallel job.
        /// </para>
        ///  <note> 
        /// <para>
        /// This isn't applicable to jobs that are running on Fargate resources.
        /// </para>
        ///  </note>
        /// </summary>
        public NodeProperties NodeProperties
        {
            get { return this._nodeProperties; }
            set { this._nodeProperties = value; }
        }

        // Check to see if NodeProperties property is set
        internal bool IsSetNodeProperties()
        {
            return this._nodeProperties != null;
        }

        /// <summary>
        /// Gets and sets the property Parameters. 
        /// <para>
        /// Additional parameters that are passed to the job that replace parameter substitution
        /// placeholders or override any corresponding parameter defaults from the job definition.
        /// </para>
        /// </summary>
        public Dictionary<string, string> Parameters
        {
            get { return this._parameters; }
            set { this._parameters = value; }
        }

        // Check to see if Parameters property is set
        internal bool IsSetParameters()
        {
            return this._parameters != null && this._parameters.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property PlatformCapabilities. 
        /// <para>
        /// The platform capabilities required by the job definition. If no value is specified,
        /// it defaults to <code>EC2</code>. Jobs run on Fargate resources specify <code>FARGATE</code>.
        /// </para>
        /// </summary>
        public List<string> PlatformCapabilities
        {
            get { return this._platformCapabilities; }
            set { this._platformCapabilities = value; }
        }

        // Check to see if PlatformCapabilities property is set
        internal bool IsSetPlatformCapabilities()
        {
            return this._platformCapabilities != null && this._platformCapabilities.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property PropagateTags. 
        /// <para>
        /// Specifies whether to propagate the tags from the job or job definition to the corresponding
        /// Amazon ECS task. If no value is specified, the tags aren't propagated. Tags can only
        /// be propagated to the tasks when the tasks are created. For tags with the same name,
        /// job tags are given priority over job definitions tags. If the total number of combined
        /// tags from the job and job definition is over 50, the job is moved to the <code>FAILED</code>
        /// state.
        /// </para>
        /// </summary>
        public bool PropagateTags
        {
            get { return this._propagateTags.GetValueOrDefault(); }
            set { this._propagateTags = value; }
        }

        // Check to see if PropagateTags property is set
        internal bool IsSetPropagateTags()
        {
            return this._propagateTags.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property RetryStrategy. 
        /// <para>
        /// The retry strategy to use for this job if an attempt fails.
        /// </para>
        /// </summary>
        public RetryStrategy RetryStrategy
        {
            get { return this._retryStrategy; }
            set { this._retryStrategy = value; }
        }

        // Check to see if RetryStrategy property is set
        internal bool IsSetRetryStrategy()
        {
            return this._retryStrategy != null;
        }

        /// <summary>
        /// Gets and sets the property SchedulingPriority. 
        /// <para>
        /// The scheduling policy of the job definition. This only affects jobs in job queues
        /// with a fair share policy. Jobs with a higher scheduling priority are scheduled before
        /// jobs with a lower scheduling priority.
        /// </para>
        /// </summary>
        public int SchedulingPriority
        {
            get { return this._schedulingPriority.GetValueOrDefault(); }
            set { this._schedulingPriority = value; }
        }

        // Check to see if SchedulingPriority property is set
        internal bool IsSetSchedulingPriority()
        {
            return this._schedulingPriority.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property ShareIdentifier. 
        /// <para>
        /// The share identifier for the job.
        /// </para>
        /// </summary>
        public string ShareIdentifier
        {
            get { return this._shareIdentifier; }
            set { this._shareIdentifier = value; }
        }

        // Check to see if ShareIdentifier property is set
        internal bool IsSetShareIdentifier()
        {
            return this._shareIdentifier != null;
        }

        /// <summary>
        /// Gets and sets the property StartedAt. 
        /// <para>
        /// The Unix timestamp (in milliseconds) for when the job was started. More specifically,
        /// it's when the job transitioned from the <code>STARTING</code> state to the <code>RUNNING</code>
        /// state. This parameter isn't provided for child jobs of array jobs or multi-node parallel
        /// jobs.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public long StartedAt
        {
            get { return this._startedAt.GetValueOrDefault(); }
            set { this._startedAt = value; }
        }

        // Check to see if StartedAt property is set
        internal bool IsSetStartedAt()
        {
            return this._startedAt.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The current status for the job.
        /// </para>
        ///  <note> 
        /// <para>
        /// If your jobs don't progress to <code>STARTING</code>, see <a href="https://docs.aws.amazon.com/batch/latest/userguide/troubleshooting.html#job_stuck_in_runnable">Jobs
        /// stuck in RUNNABLE status</a> in the troubleshooting section of the <i>Batch User Guide</i>.
        /// </para>
        ///  </note>
        /// </summary>
        [AWSProperty(Required=true)]
        public JobStatus Status
        {
            get { return this._status; }
            set { this._status = value; }
        }

        // Check to see if Status property is set
        internal bool IsSetStatus()
        {
            return this._status != null;
        }

        /// <summary>
        /// Gets and sets the property StatusReason. 
        /// <para>
        /// A short, human-readable string to provide more details for the current status of the
        /// job.
        /// </para>
        /// </summary>
        public string StatusReason
        {
            get { return this._statusReason; }
            set { this._statusReason = value; }
        }

        // Check to see if StatusReason property is set
        internal bool IsSetStatusReason()
        {
            return this._statusReason != null;
        }

        /// <summary>
        /// Gets and sets the property StoppedAt. 
        /// <para>
        /// The Unix timestamp (in milliseconds) for when the job was stopped. More specifically,
        /// it's when the job transitioned from the <code>RUNNING</code> state to a terminal state,
        /// such as <code>SUCCEEDED</code> or <code>FAILED</code>.
        /// </para>
        /// </summary>
        public long StoppedAt
        {
            get { return this._stoppedAt.GetValueOrDefault(); }
            set { this._stoppedAt = value; }
        }

        // Check to see if StoppedAt property is set
        internal bool IsSetStoppedAt()
        {
            return this._stoppedAt.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// The tags that are applied to the job.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=50)]
        public Dictionary<string, string> Tags
        {
            get { return this._tags; }
            set { this._tags = value; }
        }

        // Check to see if Tags property is set
        internal bool IsSetTags()
        {
            return this._tags != null && this._tags.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property Timeout. 
        /// <para>
        /// The timeout configuration for the job.
        /// </para>
        /// </summary>
        public JobTimeout Timeout
        {
            get { return this._timeout; }
            set { this._timeout = value; }
        }

        // Check to see if Timeout property is set
        internal bool IsSetTimeout()
        {
            return this._timeout != null;
        }

    }
}