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
    /// Specifies a job definition.
    /// </summary>
    public partial class Job
    {
        private int? _allocatedCapacity;
        private Dictionary<string, CodeGenConfigurationNode> _codeGenConfigurationNodes = new Dictionary<string, CodeGenConfigurationNode>();
        private JobCommand _command;
        private ConnectionsList _connections;
        private DateTime? _createdOn;
        private Dictionary<string, string> _defaultArguments = new Dictionary<string, string>();
        private string _description;
        private ExecutionClass _executionClass;
        private ExecutionProperty _executionProperty;
        private string _glueVersion;
        private DateTime? _lastModifiedOn;
        private string _logUri;
        private double? _maxCapacity;
        private int? _maxRetries;
        private string _name;
        private Dictionary<string, string> _nonOverridableArguments = new Dictionary<string, string>();
        private NotificationProperty _notificationProperty;
        private int? _numberOfWorkers;
        private string _role;
        private string _securityConfiguration;
        private SourceControlDetails _sourceControlDetails;
        private int? _timeout;
        private WorkerType _workerType;

        /// <summary>
        /// Gets and sets the property AllocatedCapacity. 
        /// <para>
        /// This field is deprecated. Use <code>MaxCapacity</code> instead.
        /// </para>
        ///  
        /// <para>
        /// The number of Glue data processing units (DPUs) allocated to runs of this job. You
        /// can allocate a minimum of 2 DPUs; the default is 10. A DPU is a relative measure of
        /// processing power that consists of 4 vCPUs of compute capacity and 16 GB of memory.
        /// For more information, see the <a href="https://aws.amazon.com/glue/pricing/">Glue
        /// pricing page</a>.
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
        /// Gets and sets the property CodeGenConfigurationNodes. 
        /// <para>
        /// The representation of a directed acyclic graph on which both the Glue Studio visual
        /// component and Glue Studio code generation is based.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive=true)]
        public Dictionary<string, CodeGenConfigurationNode> CodeGenConfigurationNodes
        {
            get { return this._codeGenConfigurationNodes; }
            set { this._codeGenConfigurationNodes = value; }
        }

        // Check to see if CodeGenConfigurationNodes property is set
        internal bool IsSetCodeGenConfigurationNodes()
        {
            return this._codeGenConfigurationNodes != null && this._codeGenConfigurationNodes.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property Command. 
        /// <para>
        /// The <code>JobCommand</code> that runs this job.
        /// </para>
        /// </summary>
        public JobCommand Command
        {
            get { return this._command; }
            set { this._command = value; }
        }

        // Check to see if Command property is set
        internal bool IsSetCommand()
        {
            return this._command != null;
        }

        /// <summary>
        /// Gets and sets the property Connections. 
        /// <para>
        /// The connections used for this job.
        /// </para>
        /// </summary>
        public ConnectionsList Connections
        {
            get { return this._connections; }
            set { this._connections = value; }
        }

        // Check to see if Connections property is set
        internal bool IsSetConnections()
        {
            return this._connections != null;
        }

        /// <summary>
        /// Gets and sets the property CreatedOn. 
        /// <para>
        /// The time and date that this job definition was created.
        /// </para>
        /// </summary>
        public DateTime CreatedOn
        {
            get { return this._createdOn.GetValueOrDefault(); }
            set { this._createdOn = value; }
        }

        // Check to see if CreatedOn property is set
        internal bool IsSetCreatedOn()
        {
            return this._createdOn.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property DefaultArguments. 
        /// <para>
        /// The default arguments for this job, specified as name-value pairs.
        /// </para>
        ///  
        /// <para>
        /// You can specify arguments here that your own job-execution script consumes, as well
        /// as arguments that Glue itself consumes.
        /// </para>
        ///  
        /// <para>
        /// For information about how to specify and consume your own Job arguments, see the <a
        /// href="https://docs.aws.amazon.com/glue/latest/dg/aws-glue-programming-python-calling.html">Calling
        /// Glue APIs in Python</a> topic in the developer guide.
        /// </para>
        ///  
        /// <para>
        /// For information about the key-value pairs that Glue consumes to set up your job, see
        /// the <a href="https://docs.aws.amazon.com/glue/latest/dg/aws-glue-programming-etl-glue-arguments.html">Special
        /// Parameters Used by Glue</a> topic in the developer guide.
        /// </para>
        /// </summary>
        public Dictionary<string, string> DefaultArguments
        {
            get { return this._defaultArguments; }
            set { this._defaultArguments = value; }
        }

        // Check to see if DefaultArguments property is set
        internal bool IsSetDefaultArguments()
        {
            return this._defaultArguments != null && this._defaultArguments.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// A description of the job.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=2048)]
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
        /// Gets and sets the property ExecutionClass. 
        /// <para>
        /// Indicates whether the job is run with a standard or flexible execution class. The
        /// standard execution class is ideal for time-sensitive workloads that require fast job
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
        /// Gets and sets the property ExecutionProperty. 
        /// <para>
        /// An <code>ExecutionProperty</code> specifying the maximum number of concurrent runs
        /// allowed for this job.
        /// </para>
        /// </summary>
        public ExecutionProperty ExecutionProperty
        {
            get { return this._executionProperty; }
            set { this._executionProperty = value; }
        }

        // Check to see if ExecutionProperty property is set
        internal bool IsSetExecutionProperty()
        {
            return this._executionProperty != null;
        }

        /// <summary>
        /// Gets and sets the property GlueVersion. 
        /// <para>
        /// Glue version determines the versions of Apache Spark and Python that Glue supports.
        /// The Python version indicates the version supported for jobs of type Spark. 
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
        /// Gets and sets the property LastModifiedOn. 
        /// <para>
        /// The last point in time when this job definition was modified.
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
        /// Gets and sets the property LogUri. 
        /// <para>
        /// This field is reserved for future use.
        /// </para>
        /// </summary>
        public string LogUri
        {
            get { return this._logUri; }
            set { this._logUri = value; }
        }

        // Check to see if LogUri property is set
        internal bool IsSetLogUri()
        {
            return this._logUri != null;
        }

        /// <summary>
        /// Gets and sets the property MaxCapacity. 
        /// <para>
        /// For Glue version 1.0 or earlier jobs, using the standard worker type, the number of
        /// Glue data processing units (DPUs) that can be allocated when this job runs. A DPU
        /// is a relative measure of processing power that consists of 4 vCPUs of compute capacity
        /// and 16 GB of memory. For more information, see the <a href="https://aws.amazon.com/glue/pricing/">Glue
        /// pricing page</a>.
        /// </para>
        ///  
        /// <para>
        /// Do not set <code>Max Capacity</code> if using <code>WorkerType</code> and <code>NumberOfWorkers</code>.
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
        /// <para>
        /// For Glue version 2.0 jobs, you cannot instead specify a <code>Maximum capacity</code>.
        /// Instead, you should specify a <code>Worker type</code> and the <code>Number of workers</code>.
        /// </para>
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
        /// Gets and sets the property MaxRetries. 
        /// <para>
        /// The maximum number of times to retry this job after a JobRun fails.
        /// </para>
        /// </summary>
        public int MaxRetries
        {
            get { return this._maxRetries.GetValueOrDefault(); }
            set { this._maxRetries = value; }
        }

        // Check to see if MaxRetries property is set
        internal bool IsSetMaxRetries()
        {
            return this._maxRetries.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name you assign to this job definition.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=255)]
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
        /// Gets and sets the property NonOverridableArguments. 
        /// <para>
        /// Non-overridable arguments for this job, specified as name-value pairs.
        /// </para>
        /// </summary>
        public Dictionary<string, string> NonOverridableArguments
        {
            get { return this._nonOverridableArguments; }
            set { this._nonOverridableArguments = value; }
        }

        // Check to see if NonOverridableArguments property is set
        internal bool IsSetNonOverridableArguments()
        {
            return this._nonOverridableArguments != null && this._nonOverridableArguments.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property NotificationProperty. 
        /// <para>
        /// Specifies configuration properties of a job notification.
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
        /// Gets and sets the property Role. 
        /// <para>
        /// The name or Amazon Resource Name (ARN) of the IAM role associated with this job.
        /// </para>
        /// </summary>
        public string Role
        {
            get { return this._role; }
            set { this._role = value; }
        }

        // Check to see if Role property is set
        internal bool IsSetRole()
        {
            return this._role != null;
        }

        /// <summary>
        /// Gets and sets the property SecurityConfiguration. 
        /// <para>
        /// The name of the <code>SecurityConfiguration</code> structure to be used with this
        /// job.
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
        /// Gets and sets the property SourceControlDetails. 
        /// <para>
        /// The details for a source control configuration for a job, allowing synchronization
        /// of job artifacts to or from a remote repository.
        /// </para>
        /// </summary>
        public SourceControlDetails SourceControlDetails
        {
            get { return this._sourceControlDetails; }
            set { this._sourceControlDetails = value; }
        }

        // Check to see if SourceControlDetails property is set
        internal bool IsSetSourceControlDetails()
        {
            return this._sourceControlDetails != null;
        }

        /// <summary>
        /// Gets and sets the property Timeout. 
        /// <para>
        /// The job timeout in minutes. This is the maximum time that a job run can consume resources
        /// before it is terminated and enters <code>TIMEOUT</code> status. The default is 2,880
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
        /// Gets and sets the property WorkerType. 
        /// <para>
        /// The type of predefined worker that is allocated when a job runs. Accepts a value of
        /// Standard, G.1X, G.2X, or G.025X.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// For the <code>Standard</code> worker type, each worker provides 4 vCPU, 16 GB of memory
        /// and a 50GB disk, and 2 executors per worker.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// For the <code>G.1X</code> worker type, each worker maps to 1 DPU (4 vCPU, 16 GB of
        /// memory, 64 GB disk), and provides 1 executor per worker. We recommend this worker
        /// type for memory-intensive jobs.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// For the <code>G.2X</code> worker type, each worker maps to 2 DPU (8 vCPU, 32 GB of
        /// memory, 128 GB disk), and provides 1 executor per worker. We recommend this worker
        /// type for memory-intensive jobs.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// For the <code>G.025X</code> worker type, each worker maps to 0.25 DPU (2 vCPU, 4 GB
        /// of memory, 64 GB disk), and provides 1 executor per worker. We recommend this worker
        /// type for low volume streaming jobs. This worker type is only available for Glue version
        /// 3.0 streaming jobs.
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