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

#pragma warning disable CS0612,CS0618,CS1570
namespace Amazon.Glue.Model
{
    /// <summary>
    /// Contains information about a job run.
    /// </summary>
    public partial class JobRun
    {
        private int? _allocatedCapacity;
        private Dictionary<string, string> _arguments = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;
        private int? _attempt;
        private DateTime? _completedOn;
        private double? _dpuSeconds;
        private string _errorMessage;
        private ExecutionClass _executionClass;
        private string _executionRoleSessionPolicy;
        private int? _executionTime;
        private string _glueVersion;
        private string _id;
        private JobMode _jobMode;
        private string _jobName;
        private bool? _jobRunQueuingEnabled;
        private JobRunState _jobRunState;
        private DateTime? _lastModifiedOn;
        private string _logGroupName;
        private string _maintenanceWindow;
        private double? _maxCapacity;
        private NotificationProperty _notificationProperty;
        private int? _numberOfWorkers;
        private List<Predecessor> _predecessorRuns = AWSConfigs.InitializeCollections ? new List<Predecessor>() : null;
        private string _previousRunId;
        private string _profileName;
        private string _securityConfiguration;
        private DateTime? _startedOn;
        private string _stateDetail;
        private int? _timeout;
        private string _triggerName;
        private WorkerType _workerType;

        /// <summary>
        /// Gets and sets the property AllocatedCapacity. 
        /// <para>
        /// This field is deprecated. Use <c>MaxCapacity</c> instead.
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
        public int? AllocatedCapacity
        {
            get { return this._allocatedCapacity; }
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
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public Dictionary<string, string> Arguments
        {
            get { return this._arguments; }
            set { this._arguments = value; }
        }

        // Check to see if Arguments property is set
        internal bool IsSetArguments()
        {
            return this._arguments != null && (this._arguments.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property Attempt. 
        /// <para>
        /// The number of the attempt to run this job.
        /// </para>
        /// </summary>
        public int? Attempt
        {
            get { return this._attempt; }
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
        public DateTime? CompletedOn
        {
            get { return this._completedOn; }
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
        /// This field can be set for either job runs with execution class <c>FLEX</c> or when
        /// Auto Scaling is enabled, and represents the total time each executor ran during the
        /// lifecycle of a job run in seconds, multiplied by a DPU factor (1 for <c>G.1X</c>,
        /// 2 for <c>G.2X</c>, or 0.25 for <c>G.025X</c> workers). This value may be different
        /// than the <c>executionEngineRuntime</c> * <c>MaxCapacity</c> as in the case of Auto
        /// Scaling jobs, as the number of executors running at a given time may be less than
        /// the <c>MaxCapacity</c>. Therefore, it is possible that the value of <c>DPUSeconds</c>
        /// is less than <c>executionEngineRuntime</c> * <c>MaxCapacity</c>.
        /// </para>
        /// </summary>
        public double? DPUSeconds
        {
            get { return this._dpuSeconds; }
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
        /// Only jobs with Glue version 3.0 and above and command type <c>glueetl</c> will be
        /// allowed to set <c>ExecutionClass</c> to <c>FLEX</c>. The flexible execution class
        /// is available for Spark jobs.
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
        /// Gets and sets the property ExecutionRoleSessionPolicy. 
        /// <para>
        /// This inline session policy to the StartJobRun API allows you to dynamically restrict
        /// the permissions of the specified execution role for the scope of the job, without
        /// requiring the creation of additional IAM roles.
        /// </para>
        /// </summary>
        [AWSProperty(Min=2, Max=2048)]
        public string ExecutionRoleSessionPolicy
        {
            get { return this._executionRoleSessionPolicy; }
            set { this._executionRoleSessionPolicy = value; }
        }

        // Check to see if ExecutionRoleSessionPolicy property is set
        internal bool IsSetExecutionRoleSessionPolicy()
        {
            return this._executionRoleSessionPolicy != null;
        }

        /// <summary>
        /// Gets and sets the property ExecutionTime. 
        /// <para>
        /// The amount of time (in seconds) that the job run consumed resources.
        /// </para>
        /// </summary>
        public int? ExecutionTime
        {
            get { return this._executionTime; }
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
        /// In Spark jobs, <c>GlueVersion</c> determines the versions of Apache Spark and Python
        /// that Glue available in a job. The Python version indicates the version supported for
        /// jobs of type Spark. 
        /// </para>
        ///  
        /// <para>
        /// Ray jobs should set <c>GlueVersion</c> to <c>4.0</c> or greater. However, the versions
        /// of Ray, Python and additional libraries available in your Ray job are determined by
        /// the <c>Runtime</c> parameter of the Job command.
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
        /// Gets and sets the property JobMode. 
        /// <para>
        /// A mode that describes how a job was created. Valid values are:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>SCRIPT</c> - The job was created using the Glue Studio script editor.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>VISUAL</c> - The job was created using the Glue Studio visual editor.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>NOTEBOOK</c> - The job was created using an interactive sessions notebook.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// When the <c>JobMode</c> field is missing or null, <c>SCRIPT</c> is assigned as the
        /// default value.
        /// </para>
        /// </summary>
        public JobMode JobMode
        {
            get { return this._jobMode; }
            set { this._jobMode = value; }
        }

        // Check to see if JobMode property is set
        internal bool IsSetJobMode()
        {
            return this._jobMode != null;
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
        /// Gets and sets the property JobRunQueuingEnabled. 
        /// <para>
        /// Specifies whether job run queuing is enabled for the job run.
        /// </para>
        ///  
        /// <para>
        /// A value of true means job run queuing is enabled for the job run. If false or not
        /// populated, the job run will not be considered for queueing.
        /// </para>
        /// </summary>
        public bool? JobRunQueuingEnabled
        {
            get { return this._jobRunQueuingEnabled; }
            set { this._jobRunQueuingEnabled = value; }
        }

        // Check to see if JobRunQueuingEnabled property is set
        internal bool IsSetJobRunQueuingEnabled()
        {
            return this._jobRunQueuingEnabled.HasValue; 
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
        public DateTime? LastModifiedOn
        {
            get { return this._lastModifiedOn; }
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
        /// Amazon CloudWatch using KMS. This name can be <c>/aws-glue/jobs/</c>, in which case
        /// the default encryption is <c>NONE</c>. If you add a role name and <c>SecurityConfiguration</c>
        /// name (in other words, <c>/aws-glue/jobs-yourRoleName-yourSecurityConfigurationName/</c>),
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
        /// Gets and sets the property MaintenanceWindow. 
        /// <para>
        /// This field specifies a day of the week and hour for a maintenance window for streaming
        /// jobs. Glue periodically performs maintenance activities. During these maintenance
        /// windows, Glue will need to restart your streaming jobs.
        /// </para>
        ///  
        /// <para>
        /// Glue will restart the job within 3 hours of the specified maintenance window. For
        /// instance, if you set up the maintenance window for Monday at 10:00AM GMT, your jobs
        /// will be restarted between 10:00AM GMT to 1:00PM GMT.
        /// </para>
        /// </summary>
        public string MaintenanceWindow
        {
            get { return this._maintenanceWindow; }
            set { this._maintenanceWindow = value; }
        }

        // Check to see if MaintenanceWindow property is set
        internal bool IsSetMaintenanceWindow()
        {
            return this._maintenanceWindow != null;
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
        /// For Glue version 2.0+ jobs, you cannot specify a <c>Maximum capacity</c>. Instead,
        /// you should specify a <c>Worker type</c> and the <c>Number of workers</c>.
        /// </para>
        ///  
        /// <para>
        /// Do not set <c>MaxCapacity</c> if using <c>WorkerType</c> and <c>NumberOfWorkers</c>.
        /// </para>
        ///  
        /// <para>
        /// The value that can be allocated for <c>MaxCapacity</c> depends on whether you are
        /// running a Python shell job, an Apache Spark ETL job, or an Apache Spark streaming
        /// ETL job:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// When you specify a Python shell job (<c>JobCommand.Name</c>="pythonshell"), you can
        /// allocate either 0.0625 or 1 DPU. The default is 0.0625 DPU.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// When you specify an Apache Spark ETL job (<c>JobCommand.Name</c>="glueetl") or Apache
        /// Spark streaming ETL job (<c>JobCommand.Name</c>="gluestreaming"), you can allocate
        /// from 2 to 100 DPUs. The default is 10 DPUs. This job type cannot have a fractional
        /// DPU allocation.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public double? MaxCapacity
        {
            get { return this._maxCapacity; }
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
        /// The number of workers of a defined <c>workerType</c> that are allocated when a job
        /// runs.
        /// </para>
        /// </summary>
        public int? NumberOfWorkers
        {
            get { return this._numberOfWorkers; }
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
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<Predecessor> PredecessorRuns
        {
            get { return this._predecessorRuns; }
            set { this._predecessorRuns = value; }
        }

        // Check to see if PredecessorRuns property is set
        internal bool IsSetPredecessorRuns()
        {
            return this._predecessorRuns != null && (this._predecessorRuns.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property PreviousRunId. 
        /// <para>
        /// The ID of the previous run of this job. For example, the <c>JobRunId</c> specified
        /// in the <c>StartJobRun</c> action.
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
        /// Gets and sets the property ProfileName. 
        /// <para>
        /// The name of an Glue usage profile associated with the job run.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=255)]
        public string ProfileName
        {
            get { return this._profileName; }
            set { this._profileName = value; }
        }

        // Check to see if ProfileName property is set
        internal bool IsSetProfileName()
        {
            return this._profileName != null;
        }

        /// <summary>
        /// Gets and sets the property SecurityConfiguration. 
        /// <para>
        /// The name of the <c>SecurityConfiguration</c> structure to be used with this job run.
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
        public DateTime? StartedOn
        {
            get { return this._startedOn; }
            set { this._startedOn = value; }
        }

        // Check to see if StartedOn property is set
        internal bool IsSetStartedOn()
        {
            return this._startedOn.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property StateDetail. 
        /// <para>
        /// This field holds details that pertain to the state of a job run. The field is nullable.
        /// </para>
        ///  
        /// <para>
        /// For example, when a job run is in a WAITING state as a result of job run queuing,
        /// the field has the reason why the job run is in that state.
        /// </para>
        /// </summary>
        [AWSProperty(Max=400000)]
        public string StateDetail
        {
            get { return this._stateDetail; }
            set { this._stateDetail = value; }
        }

        // Check to see if StateDetail property is set
        internal bool IsSetStateDetail()
        {
            return this._stateDetail != null;
        }

        /// <summary>
        /// Gets and sets the property Timeout. 
        /// <para>
        /// The <c>JobRun</c> timeout in minutes. This is the maximum time that a job run can
        /// consume resources before it is terminated and enters <c>TIMEOUT</c> status. This value
        /// overrides the timeout value set in the parent job.
        /// </para>
        ///  
        /// <para>
        /// Jobs must have timeout values less than 7 days or 10080 minutes. Otherwise, the jobs
        /// will throw an exception.
        /// </para>
        ///  
        /// <para>
        /// When the value is left blank, the timeout is defaulted to 2880 minutes.
        /// </para>
        ///  
        /// <para>
        /// Any existing Glue jobs that had a timeout value greater than 7 days will be defaulted
        /// to 7 days. For instance if you have specified a timeout of 20 days for a batch job,
        /// it will be stopped on the 7th day.
        /// </para>
        ///  
        /// <para>
        /// For streaming jobs, if you have set up a maintenance window, it will be restarted
        /// during the maintenance window after 7 days.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1)]
        public int? Timeout
        {
            get { return this._timeout; }
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
        /// For the <c>G.1X</c> worker type, each worker maps to 1 DPU (4 vCPUs, 16 GB of memory)
        /// with 94GB disk, and provides 1 executor per worker. We recommend this worker type
        /// for workloads such as data transforms, joins, and queries, to offers a scalable and
        /// cost effective way to run most jobs.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// For the <c>G.2X</c> worker type, each worker maps to 2 DPU (8 vCPUs, 32 GB of memory)
        /// with 138GB disk, and provides 1 executor per worker. We recommend this worker type
        /// for workloads such as data transforms, joins, and queries, to offers a scalable and
        /// cost effective way to run most jobs.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// For the <c>G.4X</c> worker type, each worker maps to 4 DPU (16 vCPUs, 64 GB of memory)
        /// with 256GB disk, and provides 1 executor per worker. We recommend this worker type
        /// for jobs whose workloads contain your most demanding transforms, aggregations, joins,
        /// and queries. This worker type is available only for Glue version 3.0 or later Spark
        /// ETL jobs in the following Amazon Web Services Regions: US East (Ohio), US East (N.
        /// Virginia), US West (Oregon), Asia Pacific (Singapore), Asia Pacific (Sydney), Asia
        /// Pacific (Tokyo), Canada (Central), Europe (Frankfurt), Europe (Ireland), and Europe
        /// (Stockholm).
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// For the <c>G.8X</c> worker type, each worker maps to 8 DPU (32 vCPUs, 128 GB of memory)
        /// with 512GB disk, and provides 1 executor per worker. We recommend this worker type
        /// for jobs whose workloads contain your most demanding transforms, aggregations, joins,
        /// and queries. This worker type is available only for Glue version 3.0 or later Spark
        /// ETL jobs, in the same Amazon Web Services Regions as supported for the <c>G.4X</c>
        /// worker type.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// For the <c>G.025X</c> worker type, each worker maps to 0.25 DPU (2 vCPUs, 4 GB of
        /// memory) with 84GB disk, and provides 1 executor per worker. We recommend this worker
        /// type for low volume streaming jobs. This worker type is only available for Glue version
        /// 3.0 or later streaming jobs.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// For the <c>Z.2X</c> worker type, each worker maps to 2 M-DPU (8vCPUs, 64 GB of memory)
        /// with 128 GB disk, and provides up to 8 Ray workers based on the autoscaler.
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