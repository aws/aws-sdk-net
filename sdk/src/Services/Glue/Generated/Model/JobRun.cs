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
 * Do not modify this file. This file is generated from the glue-2017-03-31.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.Glue.Model
{
    /// <summary>
    /// Contains information about a job run.
    /// </summary>
    public partial class JobRun
    {
        private int? _allocatedCapacity;
        private Dictionary<string, string> _arguments = new Dictionary<string, string>();
        private int? _attempt;
        private DateTime? _completedOn;
        private double? _dpuSeconds;
        private string _errorMessage;
        private ExecutionClass _executionClass;
        private int? _executionTime;
        private string _glueVersion;
        private string _id;
        private string _jobName;
        private JobRunState _jobRunState;
        private DateTime? _lastModifiedOn;
        private string _logGroupName;
        private double? _maxCapacity;
        private NotificationProperty _notificationProperty;
        private int? _numberOfWorkers;
        private List<Predecessor> _predecessorRuns = new List<Predecessor>();
        private string _previousRunId;
        private string _securityConfiguration;
        private DateTime? _startedOn;
        private int? _timeout;
        private string _triggerName;
        private WorkerType _workerType;

        /// <summary>
        /// Gets and sets the property AllocatedCapacity. 
        /// <para>
        /// This field is deprecated. Use <code>MaxCapacity</code> instead.
        /// </para>
        ///  
        /// <para>
        /// The number of Glue data processing units (DPUs) allocated to this JobRun. From 2 to
        /// 100 DPUs can be allocated; the default is 10. A DPU is a relative measure of processing
        /// power that consists of 4 vCPUs of compute capacity and 16 GB of memory. For more information,
        /// see the <a href="https://aws.amazon.com/glue/pricing/">Glue pricing page</a>.
        /// </para>
        /// </summary>
        [Obsolete("This property is deprecated, use MaxCapacity instead.")]
        public int AllocatedCapacity
        {
            get { return this._allocatedCapacity.GetValueOrDefault(); }
            set { this._allocatedCapacity = value; }
        }

        // Check to see if AllocatedCapacity property is set
        internal bool IsSetAllocatedCapacity()
        {
            return this._allocatedCapacity.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Arguments. 
        /// <para>
        /// The job arguments associated with this run. For this job run, they replace the default
        /// arguments set in the job definition itself.
        /// </para>
        ///  
        /// <para>
        /// You can specify arguments here that your own job-execution script consumes, as well
        /// as arguments that Glue itself consumes.
        /// </para>
        ///  
        /// <para>
        /// Job arguments may be logged. Do not pass plaintext secrets as arguments. Retrieve
        /// secrets from a Glue Connection, Secrets Manager or other secret management mechanism
        /// if you intend to keep them within the Job. 
        /// </para>
        ///  
        /// <para>
        /// For information about how to specify and consume your own Job arguments, see the <a
        /// href="https://docs.aws.amazon.com/glue/latest/dg/aws-glue-programming-python-calling.html">Calling
        /// Glue APIs in Python</a> topic in the developer guide.
        /// </para>
        ///  
        /// <para>
        /// For information about the arguments you can provide to this field when configuring
        /// Spark jobs, see the <a href="https://docs.aws.amazon.com/glue/latest/dg/aws-glue-programming-etl-glue-arguments.html">Special
        /// Parameters Used by Glue</a> topic in the developer guide.
        /// </para>
        ///  
        /// <para>
        /// For information about the arguments you can provide to this field when configuring
        /// Ray jobs, see <a href="https://docs.aws.amazon.com/glue/latest/dg/author-job-ray-job-parameters.html">Using
        /// job parameters in Ray jobs</a> in the developer guide.
        /// </para>
        /// </summary>
        public Dictionary<string, string> Arguments
        {
            get { return this._arguments; }
            set { this._arguments = value; }
        }

        // Check to see if Arguments property is set
        internal bool IsSetArguments()
        {
            return this._arguments != null && this._arguments.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property Attempt. 
        /// <para>
        /// The number of the attempt to run this job.
        /// </para>
        /// </summary>
        public int Attempt
        {
            get { return this._attempt.GetValueOrDefault(); }
            set { this._attempt = value; }
        }

        // Check to see if Attempt property is set
        internal bool IsSetAttempt()
        {
            return this._attempt.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property CompletedOn. 
        /// <para>
        /// The date and time that this job run completed.
        /// </para>
        /// </summary>
        public DateTime CompletedOn
        {
            get { return this._completedOn.GetValueOrDefault(); }
            set { this._completedOn = value; }
        }

        // Check to see if CompletedOn property is set
        internal bool IsSetCompletedOn()
        {
            return this._completedOn.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property DPUSeconds. 
        /// <para>
        /// This field populates only for Auto Scaling job runs, and represents the total time
        /// each executor ran during the lifecycle of a job run in seconds, multiplied by a DPU
        /// factor (1 for <code>G.1X</code>, 2 for <code>G.2X</code>, or 0.25 for <code>G.025X</code>
        /// workers). This value may be different than the <code>executionEngineRuntime</code>
        /// * <code>MaxCapacity</code> as in the case of Auto Scaling jobs, as the number of executors
        /// running at a given time may be less than the <code>MaxCapacity</code>. Therefore,
        /// it is possible that the value of <code>DPUSeconds</code> is less than <code>executionEngineRuntime</code>
        /// * <code>MaxCapacity</code>.
        /// </para>
        /// </summary>
        public double DPUSeconds
        {
            get { return this._dpuSeconds.GetValueOrDefault(); }
            set { this._dpuSeconds = value; }
        }

        // Check to see if DPUSeconds property is set
        internal bool IsSetDPUSeconds()
        {
            return this._dpuSeconds.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property ErrorMessage. 
        /// <para>
        /// An error message associated with this job run.
        /// </para>
        /// </summary>
        public string ErrorMessage
        {
            get { return this._errorMessage; }
            set { this._errorMessage = value; }
        }

        // Check to see if ErrorMessage property is set
        internal bool IsSetErrorMessage()
        {
            return this._errorMessage != null;
        }

        /// <summary>
        /// Gets and sets the property ExecutionClass. 
        /// <para>
        /// Indicates whether the job is run with a standard or flexible execution class. The
        /// standard execution-class is ideal for time-sensitive workloads that require fast job
        /// startup and dedicated resources.
        /// </para>
        ///  
        /// <para>
        /// The flexible execution class is appropriate for time-insensitive jobs whose start
        /// and completion times may vary. 
        /// </para>
        ///  
        /// <para>
        /// Only jobs with Glue version 3.0 and above and command type <code>glueetl</code> will
        /// be allowed to set <code>ExecutionClass</code> to <code>FLEX</code>. The flexible execution
        /// class is available for Spark jobs.
        /// </para>
        /// </summary>
        [AWSProperty(Max=16)]
        public ExecutionClass ExecutionClass
        {
            get { return this._executionClass; }
            set { this._executionClass = value; }
        }

        // Check to see if ExecutionClass property is set
        internal bool IsSetExecutionClass()
        {
            return this._executionClass != null;
        }

        /// <summary>
        /// Gets and sets the property ExecutionTime. 
        /// <para>
        /// The amount of time (in seconds) that the job run consumed resources.
        /// </para>
        /// </summary>
        public int ExecutionTime
        {
            get { return this._executionTime.GetValueOrDefault(); }
            set { this._executionTime = value; }
        }

        // Check to see if ExecutionTime property is set
        internal bool IsSetExecutionTime()
        {
            return this._executionTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property GlueVersion. 
        /// <para>
        /// In Spark jobs, <code>GlueVersion</code> determines the versions of Apache Spark and
        /// Python that Glue available in a job. The Python version indicates the version supported
        /// for jobs of type Spark. 
        /// </para>
        ///  
        /// <para>
        /// Ray jobs should set <code>GlueVersion</code> to <code>4.0</code> or greater. However,
        /// the versions of Ray, Python and additional libraries available in your Ray job are
        /// determined by the <code>Runtime</code> parameter of the Job command.
        /// </para>
        ///  
        /// <para>
        /// For more information about the available Glue versions and corresponding Spark and
        /// Python versions, see <a href="https://docs.aws.amazon.com/glue/latest/dg/add-job.html">Glue
        /// version</a> in the developer guide.
        /// </para>
        ///  
        /// <para>
        /// Jobs that are created without specifying a Glue version default to Glue 0.9.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=255)]
        public string GlueVersion
        {
            get { return this._glueVersion; }
            set { this._glueVersion = value; }
        }

        // Check to see if GlueVersion property is set
        internal bool IsSetGlueVersion()
        {
            return this._glueVersion != null;
        }

        /// <summary>
        /// Gets and sets the property Id. 
        /// <para>
        /// The ID of this job run.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=255)]
        public string Id
        {
            get { return this._id; }
            set { this._id = value; }
        }

        // Check to see if Id property is set
        internal bool IsSetId()
        {
            return this._id != null;
        }

        /// <summary>
        /// Gets and sets the property JobName. 
        /// <para>
        /// The name of the job definition being used in this run.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=255)]
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
        /// Gets and sets the property JobRunState. 
        /// <para>
        /// The current state of the job run. For more information about the statuses of jobs
        /// that have terminated abnormally, see <a href="https://docs.aws.amazon.com/glue/latest/dg/job-run-statuses.html">Glue
        /// Job Run Statuses</a>.
        /// </para>
        /// </summary>
        public JobRunState JobRunState
        {
            get { return this._jobRunState; }
            set { this._jobRunState = value; }
        }

        // Check to see if JobRunState property is set
        internal bool IsSetJobRunState()
        {
            return this._jobRunState != null;
        }

        /// <summary>
        /// Gets and sets the property LastModifiedOn. 
        /// <para>
        /// The last time that this job run was modified.
        /// </para>
        /// </summary>
        public DateTime LastModifiedOn
        {
            get { return this._lastModifiedOn.GetValueOrDefault(); }
            set { this._lastModifiedOn = value; }
        }

        // Check to see if LastModifiedOn property is set
        internal bool IsSetLastModifiedOn()
        {
            return this._lastModifiedOn.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property LogGroupName. 
        /// <para>
        /// The name of the log group for secure logging that can be server-side encrypted in
        /// Amazon CloudWatch using KMS. This name can be <code>/aws-glue/jobs/</code>, in which
        /// case the default encryption is <code>NONE</code>. If you add a role name and <code>SecurityConfiguration</code>
        /// name (in other words, <code>/aws-glue/jobs-yourRoleName-yourSecurityConfigurationName/</code>),
        /// then that security configuration is used to encrypt the log group.
        /// </para>
        /// </summary>
        public string LogGroupName
        {
            get { return this._logGroupName; }
            set { this._logGroupName = value; }
        }

        // Check to see if LogGroupName property is set
        internal bool IsSetLogGroupName()
        {
            return this._logGroupName != null;
        }

        /// <summary>
        /// Gets and sets the property MaxCapacity. 
        /// <para>
        /// For Glue version 1.0 or earlier jobs, using the standard worker type, the number of
        /// Glue data processing units (DPUs) that can be allocated when this job runs. A DPU
        /// is a relative measure of processing power that consists of 4 vCPUs of compute capacity
        /// and 16 GB of memory. For more information, see the <a href="https://aws.amazon.com/glue/pricing/">
        /// Glue pricing page</a>.
        /// </para>
        ///  
        /// <para>
        /// For Glue version 2.0+ jobs, you cannot specify a <code>Maximum capacity</code>. Instead,
        /// you should specify a <code>Worker type</code> and the <code>Number of workers</code>.
        /// </para>
        ///  
        /// <para>
        /// Do not set <code>MaxCapacity</code> if using <code>WorkerType</code> and <code>NumberOfWorkers</code>.
        /// </para>
        ///  
        /// <para>
        /// The value that can be allocated for <code>MaxCapacity</code> depends on whether you
        /// are running a Python shell job, an Apache Spark ETL job, or an Apache Spark streaming
        /// ETL job:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// When you specify a Python shell job (<code>JobCommand.Name</code>="pythonshell"),
        /// you can allocate either 0.0625 or 1 DPU. The default is 0.0625 DPU.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// When you specify an Apache Spark ETL job (<code>JobCommand.Name</code>="glueetl")
        /// or Apache Spark streaming ETL job (<code>JobCommand.Name</code>="gluestreaming"),
        /// you can allocate from 2 to 100 DPUs. The default is 10 DPUs. This job type cannot
        /// have a fractional DPU allocation.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public double MaxCapacity
        {
            get { return this._maxCapacity.GetValueOrDefault(); }
            set { this._maxCapacity = value; }
        }

        // Check to see if MaxCapacity property is set
        internal bool IsSetMaxCapacity()
        {
            return this._maxCapacity.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property NotificationProperty. 
        /// <para>
        /// Specifies configuration properties of a job run notification.
        /// </para>
        /// </summary>
        public NotificationProperty NotificationProperty
        {
            get { return this._notificationProperty; }
            set { this._notificationProperty = value; }
        }

        // Check to see if NotificationProperty property is set
        internal bool IsSetNotificationProperty()
        {
            return this._notificationProperty != null;
        }

        /// <summary>
        /// Gets and sets the property NumberOfWorkers. 
        /// <para>
        /// The number of workers of a defined <code>workerType</code> that are allocated when
        /// a job runs.
        /// </para>
        /// </summary>
        public int NumberOfWorkers
        {
            get { return this._numberOfWorkers.GetValueOrDefault(); }
            set { this._numberOfWorkers = value; }
        }

        // Check to see if NumberOfWorkers property is set
        internal bool IsSetNumberOfWorkers()
        {
            return this._numberOfWorkers.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property PredecessorRuns. 
        /// <para>
        /// A list of predecessors to this job run.
        /// </para>
        /// </summary>
        public List<Predecessor> PredecessorRuns
        {
            get { return this._predecessorRuns; }
            set { this._predecessorRuns = value; }
        }

        // Check to see if PredecessorRuns property is set
        internal bool IsSetPredecessorRuns()
        {
            return this._predecessorRuns != null && this._predecessorRuns.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property PreviousRunId. 
        /// <para>
        /// The ID of the previous run of this job. For example, the <code>JobRunId</code> specified
        /// in the <code>StartJobRun</code> action.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=255)]
        public string PreviousRunId
        {
            get { return this._previousRunId; }
            set { this._previousRunId = value; }
        }

        // Check to see if PreviousRunId property is set
        internal bool IsSetPreviousRunId()
        {
            return this._previousRunId != null;
        }

        /// <summary>
        /// Gets and sets the property SecurityConfiguration. 
        /// <para>
        /// The name of the <code>SecurityConfiguration</code> structure to be used with this
        /// job run.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=255)]
        public string SecurityConfiguration
        {
            get { return this._securityConfiguration; }
            set { this._securityConfiguration = value; }
        }

        // Check to see if SecurityConfiguration property is set
        internal bool IsSetSecurityConfiguration()
        {
            return this._securityConfiguration != null;
        }

        /// <summary>
        /// Gets and sets the property StartedOn. 
        /// <para>
        /// The date and time at which this job run was started.
        /// </para>
        /// </summary>
        public DateTime StartedOn
        {
            get { return this._startedOn.GetValueOrDefault(); }
            set { this._startedOn = value; }
        }

        // Check to see if StartedOn property is set
        internal bool IsSetStartedOn()
        {
            return this._startedOn.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Timeout. 
        /// <para>
        /// The <code>JobRun</code> timeout in minutes. This is the maximum time that a job run
        /// can consume resources before it is terminated and enters <code>TIMEOUT</code> status.
        /// This value overrides the timeout value set in the parent job.
        /// </para>
        ///  
        /// <para>
        /// Streaming jobs do not have a timeout. The default for non-streaming jobs is 2,880
        /// minutes (48 hours).
        /// </para>
        /// </summary>
        [AWSProperty(Min=1)]
        public int Timeout
        {
            get { return this._timeout.GetValueOrDefault(); }
            set { this._timeout = value; }
        }

        // Check to see if Timeout property is set
        internal bool IsSetTimeout()
        {
            return this._timeout.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property TriggerName. 
        /// <para>
        /// The name of the trigger that started this job run.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=255)]
        public string TriggerName
        {
            get { return this._triggerName; }
            set { this._triggerName = value; }
        }

        // Check to see if TriggerName property is set
        internal bool IsSetTriggerName()
        {
            return this._triggerName != null;
        }

        /// <summary>
        /// Gets and sets the property WorkerType. 
        /// <para>
        /// The type of predefined worker that is allocated when a job runs. Accepts a value of
        /// G.1X, G.2X, G.4X, G.8X or G.025X for Spark jobs. Accepts the value Z.2X for Ray jobs.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// For the <code>G.1X</code> worker type, each worker maps to 1 DPU (4 vCPUs, 16 GB of
        /// memory) with 84GB disk (approximately 34GB free), and provides 1 executor per worker.
        /// We recommend this worker type for workloads such as data transforms, joins, and queries,
        /// to offers a scalable and cost effective way to run most jobs.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// For the <code>G.2X</code> worker type, each worker maps to 2 DPU (8 vCPUs, 32 GB of
        /// memory) with 128GB disk (approximately 77GB free), and provides 1 executor per worker.
        /// We recommend this worker type for workloads such as data transforms, joins, and queries,
        /// to offers a scalable and cost effective way to run most jobs.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// For the <code>G.4X</code> worker type, each worker maps to 4 DPU (16 vCPUs, 64 GB
        /// of memory) with 256GB disk (approximately 235GB free), and provides 1 executor per
        /// worker. We recommend this worker type for jobs whose workloads contain your most demanding
        /// transforms, aggregations, joins, and queries. This worker type is available only for
        /// Glue version 3.0 or later Spark ETL jobs in the following Amazon Web Services Regions:
        /// US East (Ohio), US East (N. Virginia), US West (Oregon), Asia Pacific (Singapore),
        /// Asia Pacific (Sydney), Asia Pacific (Tokyo), Canada (Central), Europe (Frankfurt),
        /// Europe (Ireland), and Europe (Stockholm).
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// For the <code>G.8X</code> worker type, each worker maps to 8 DPU (32 vCPUs, 128 GB
        /// of memory) with 512GB disk (approximately 487GB free), and provides 1 executor per
        /// worker. We recommend this worker type for jobs whose workloads contain your most demanding
        /// transforms, aggregations, joins, and queries. This worker type is available only for
        /// Glue version 3.0 or later Spark ETL jobs, in the same Amazon Web Services Regions
        /// as supported for the <code>G.4X</code> worker type.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// For the <code>G.025X</code> worker type, each worker maps to 0.25 DPU (2 vCPUs, 4
        /// GB of memory) with 84GB disk (approximately 34GB free), and provides 1 executor per
        /// worker. We recommend this worker type for low volume streaming jobs. This worker type
        /// is only available for Glue version 3.0 streaming jobs.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// For the <code>Z.2X</code> worker type, each worker maps to 2 M-DPU (8vCPUs, 64 GB
        /// of memory) with 128 GB disk (approximately 120GB free), and provides up to 8 Ray workers
        /// based on the autoscaler.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public WorkerType WorkerType
        {
            get { return this._workerType; }
            set { this._workerType = value; }
        }

        // Check to see if WorkerType property is set
        internal bool IsSetWorkerType()
        {
            return this._workerType != null;
        }

    }
}