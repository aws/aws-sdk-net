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
    /// Specifies a job definition.
    /// </summary>
    public partial class Job
    {
        private int? _allocatedCapacity;
        private Dictionary<string, CodeGenConfigurationNode> _codeGenConfigurationNodes = AWSConfigs.InitializeCollections ? new Dictionary<string, CodeGenConfigurationNode>() : null;
        private JobCommand _command;
        private ConnectionsList _connections;
        private DateTime? _createdOn;
        private Dictionary<string, string> _defaultArguments = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;
        private string _description;
        private ExecutionClass _executionClass;
        private ExecutionProperty _executionProperty;
        private string _glueVersion;
        private JobMode _jobMode;
        private bool? _jobRunQueuingEnabled;
        private DateTime? _lastModifiedOn;
        private string _logUri;
        private string _maintenanceWindow;
        private double? _maxCapacity;
        private int? _maxRetries;
        private string _name;
        private Dictionary<string, string> _nonOverridableArguments = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;
        private NotificationProperty _notificationProperty;
        private int? _numberOfWorkers;
        private string _profileName;
        private string _role;
        private string _securityConfiguration;
        private SourceControlDetails _sourceControlDetails;
        private int? _timeout;
        private WorkerType _workerType;

        /// <summary>
        /// Gets and sets the property AllocatedCapacity. 
        /// <para>
        /// This field is deprecated. Use <c>MaxCapacity</c> instead.
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
        /// Gets and sets the property CodeGenConfigurationNodes. 
        /// <para>
        /// The representation of a directed acyclic graph on which both the Glue Studio visual
        /// component and Glue Studio code generation is based.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
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
            return this._codeGenConfigurationNodes != null && (this._codeGenConfigurationNodes.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property Command. 
        /// <para>
        /// The <c>JobCommand</c> that runs this job.
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
        public DateTime? CreatedOn
        {
            get { return this._createdOn; }
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
        /// The default arguments for every run of this job, specified as name-value pairs.
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
        public Dictionary<string, string> DefaultArguments
        {
            get { return this._defaultArguments; }
            set { this._defaultArguments = value; }
        }

        // Check to see if DefaultArguments property is set
        internal bool IsSetDefaultArguments()
        {
            return this._defaultArguments != null && (this._defaultArguments.Count > 0 || !AWSConfigs.InitializeCollections); 
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
        /// Gets and sets the property ExecutionProperty. 
        /// <para>
        /// An <c>ExecutionProperty</c> specifying the maximum number of concurrent runs allowed
        /// for this job.
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
        /// Gets and sets the property JobRunQueuingEnabled. 
        /// <para>
        /// Specifies whether job run queuing is enabled for the job runs for this job.
        /// </para>
        ///  
        /// <para>
        /// A value of true means job run queuing is enabled for the job runs. If false or not
        /// populated, the job runs will not be considered for queueing.
        /// </para>
        ///  
        /// <para>
        /// If this field does not match the value set in the job run, then the value from the
        /// job run field will be used.
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
        /// Gets and sets the property LastModifiedOn. 
        /// <para>
        /// The last point in time when this job definition was modified.
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
        /// For Glue version 2.0 or later jobs, you cannot specify a <c>Maximum capacity</c>.
        /// Instead, you should specify a <c>Worker type</c> and the <c>Number of workers</c>.
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
        /// Gets and sets the property MaxRetries. 
        /// <para>
        /// The maximum number of times to retry this job after a JobRun fails.
        /// </para>
        /// </summary>
        public int? MaxRetries
        {
            get { return this._maxRetries; }
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
        /// Arguments for this job that are not overridden when providing job arguments in a job
        /// run, specified as name-value pairs.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public Dictionary<string, string> NonOverridableArguments
        {
            get { return this._nonOverridableArguments; }
            set { this._nonOverridableArguments = value; }
        }

        // Check to see if NonOverridableArguments property is set
        internal bool IsSetNonOverridableArguments()
        {
            return this._nonOverridableArguments != null && (this._nonOverridableArguments.Count > 0 || !AWSConfigs.InitializeCollections); 
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
        /// Gets and sets the property ProfileName. 
        /// <para>
        /// The name of an Glue usage profile associated with the job.
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
        /// The name of the <c>SecurityConfiguration</c> structure to be used with this job.
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
        /// before it is terminated and enters <c>TIMEOUT</c> status.
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
        /// Gets and sets the property WorkerType. 
        /// <para>
        /// The type of predefined worker that is allocated when a job runs.
        /// </para>
        ///  
        /// <para>
        /// Glue provides multiple worker types to accommodate different workload requirements:
        /// </para>
        ///  
        /// <para>
        /// G Worker Types (General-purpose compute workers):
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// G.1X: 1 DPU (4 vCPUs, 16 GB memory, 94GB disk)
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// G.2X: 2 DPU (8 vCPUs, 32 GB memory, 138GB disk)
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// G.4X: 4 DPU (16 vCPUs, 64 GB memory, 256GB disk)
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// G.8X: 8 DPU (32 vCPUs, 128 GB memory, 512GB disk)
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// G.12X: 12 DPU (48 vCPUs, 192 GB memory, 768GB disk)
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// G.16X: 16 DPU (64 vCPUs, 256 GB memory, 1024GB disk)
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// R Worker Types (Memory-optimized workers):
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// R.1X: 1 M-DPU (4 vCPUs, 32 GB memory)
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// R.2X: 2 M-DPU (8 vCPUs, 64 GB memory)
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// R.4X: 4 M-DPU (16 vCPUs, 128 GB memory)
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// R.8X: 8 M-DPU (32 vCPUs, 256 GB memory)
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