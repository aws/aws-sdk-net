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

namespace Amazon.Glue.Model
{
    /// <summary>
    /// Contains information about a job run.
    /// </summary>
    public partial class JobRun
    {
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
        public int? AllocatedCapacity { get; set; }

        /// <summary>
        /// Checks to see if the AllocatedCapacity property is set.
        /// </summary>
        internal bool IsSetAllocatedCapacity() => this.AllocatedCapacity.HasValue;

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
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public Dictionary<string, string> Arguments { get; set; } = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;

        /// <summary>
        /// Checks to see if the Arguments property is set.
        /// </summary>
        internal bool IsSetArguments() => this.Arguments != null && (this.Arguments.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property Attempt. 
        /// <para>
        /// The number of the attempt to run this job.
        /// </para>
        /// </summary>
        public int? Attempt { get; set; }

        /// <summary>
        /// Checks to see if the Attempt property is set.
        /// </summary>
        internal bool IsSetAttempt() => this.Attempt.HasValue;

        /// <summary>
        /// Gets and sets the property CompletedOn. 
        /// <para>
        /// The date and time that this job run completed.
        /// </para>
        /// </summary>
        public DateTime? CompletedOn { get; set; }

        /// <summary>
        /// Checks to see if the CompletedOn property is set.
        /// </summary>
        internal bool IsSetCompletedOn() => this.CompletedOn.HasValue;

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
        public double? DPUSeconds { get; set; }

        /// <summary>
        /// Checks to see if the DPUSeconds property is set.
        /// </summary>
        internal bool IsSetDPUSeconds() => this.DPUSeconds.HasValue;

        /// <summary>
        /// Gets and sets the property ErrorMessage. 
        /// <para>
        /// An error message associated with this job run.
        /// </para>
        /// </summary>
        public string ErrorMessage { get; set; }

        /// <summary>
        /// Checks to see if the ErrorMessage property is set.
        /// </summary>
        internal bool IsSetErrorMessage() => this.ErrorMessage != null;

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
        [AWSProperty(Min = 0, Max = 16)]
        public ExecutionClass ExecutionClass { get; set; }

        /// <summary>
        /// Checks to see if the ExecutionClass property is set.
        /// </summary>
        internal bool IsSetExecutionClass() => this.ExecutionClass != null;

        /// <summary>
        /// Gets and sets the property ExecutionRoleSessionPolicy. 
        /// <para>
        /// This inline session policy to the StartJobRun API allows you to dynamically restrict
        /// the permissions of the specified execution role for the scope of the job, without
        /// requiring the creation of additional IAM roles.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 2, Max = 2048)]
        public string ExecutionRoleSessionPolicy { get; set; }

        /// <summary>
        /// Checks to see if the ExecutionRoleSessionPolicy property is set.
        /// </summary>
        internal bool IsSetExecutionRoleSessionPolicy() => this.ExecutionRoleSessionPolicy != null;

        /// <summary>
        /// Gets and sets the property ExecutionTime. 
        /// <para>
        /// The amount of time (in seconds) that the job run consumed resources.
        /// </para>
        /// </summary>
        public int? ExecutionTime { get; set; }

        /// <summary>
        /// Checks to see if the ExecutionTime property is set.
        /// </summary>
        internal bool IsSetExecutionTime() => this.ExecutionTime.HasValue;

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
        /// Jobs that are created without specifying a Glue version default to Glue 5.1.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 255)]
        public string GlueVersion { get; set; }

        /// <summary>
        /// Checks to see if the GlueVersion property is set.
        /// </summary>
        internal bool IsSetGlueVersion() => this.GlueVersion != null;

        /// <summary>
        /// Gets and sets the property Id. 
        /// <para>
        /// The ID of this job run.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 255)]
        public string Id { get; set; }

        /// <summary>
        /// Checks to see if the Id property is set.
        /// </summary>
        internal bool IsSetId() => this.Id != null;

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
        public JobMode JobMode { get; set; }

        /// <summary>
        /// Checks to see if the JobMode property is set.
        /// </summary>
        internal bool IsSetJobMode() => this.JobMode != null;

        /// <summary>
        /// Gets and sets the property JobName. 
        /// <para>
        /// The name of the job definition being used in this run.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 255)]
        public string JobName { get; set; }

        /// <summary>
        /// Checks to see if the JobName property is set.
        /// </summary>
        internal bool IsSetJobName() => this.JobName != null;

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
        public bool? JobRunQueuingEnabled { get; set; }

        /// <summary>
        /// Checks to see if the JobRunQueuingEnabled property is set.
        /// </summary>
        internal bool IsSetJobRunQueuingEnabled() => this.JobRunQueuingEnabled.HasValue;

        /// <summary>
        /// Gets and sets the property JobRunState. 
        /// <para>
        /// The current state of the job run. For more information about the statuses of jobs
        /// that have terminated abnormally, see <a href="https://docs.aws.amazon.com/glue/latest/dg/job-run-statuses.html">Glue
        /// Job Run Statuses</a>.
        /// </para>
        /// </summary>
        public JobRunState JobRunState { get; set; }

        /// <summary>
        /// Checks to see if the JobRunState property is set.
        /// </summary>
        internal bool IsSetJobRunState() => this.JobRunState != null;

        /// <summary>
        /// Gets and sets the property LastModifiedOn. 
        /// <para>
        /// The last time that this job run was modified.
        /// </para>
        /// </summary>
        public DateTime? LastModifiedOn { get; set; }

        /// <summary>
        /// Checks to see if the LastModifiedOn property is set.
        /// </summary>
        internal bool IsSetLastModifiedOn() => this.LastModifiedOn.HasValue;

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
        public string LogGroupName { get; set; }

        /// <summary>
        /// Checks to see if the LogGroupName property is set.
        /// </summary>
        internal bool IsSetLogGroupName() => this.LogGroupName != null;

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
        public string MaintenanceWindow { get; set; }

        /// <summary>
        /// Checks to see if the MaintenanceWindow property is set.
        /// </summary>
        internal bool IsSetMaintenanceWindow() => this.MaintenanceWindow != null;

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
        public double? MaxCapacity { get; set; }

        /// <summary>
        /// Checks to see if the MaxCapacity property is set.
        /// </summary>
        internal bool IsSetMaxCapacity() => this.MaxCapacity.HasValue;

        /// <summary>
        /// Gets and sets the property NotificationProperty. 
        /// <para>
        /// Specifies configuration properties of a job run notification.
        /// </para>
        /// </summary>
        public NotificationProperty NotificationProperty { get; set; }

        /// <summary>
        /// Checks to see if the NotificationProperty property is set.
        /// </summary>
        internal bool IsSetNotificationProperty() => this.NotificationProperty != null;

        /// <summary>
        /// Gets and sets the property NumberOfWorkers. 
        /// <para>
        /// The number of workers of a defined <c>workerType</c> that are allocated when a job
        /// runs.
        /// </para>
        /// </summary>
        public int? NumberOfWorkers { get; set; }

        /// <summary>
        /// Checks to see if the NumberOfWorkers property is set.
        /// </summary>
        internal bool IsSetNumberOfWorkers() => this.NumberOfWorkers.HasValue;

        /// <summary>
        /// Gets and sets the property PredecessorRuns. 
        /// <para>
        /// A list of predecessors to this job run.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<Predecessor> PredecessorRuns { get; set; } = AWSConfigs.InitializeCollections ? new List<Predecessor>() : null;

        /// <summary>
        /// Checks to see if the PredecessorRuns property is set.
        /// </summary>
        internal bool IsSetPredecessorRuns() => this.PredecessorRuns != null && (this.PredecessorRuns.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property PreviousRunId. 
        /// <para>
        /// The ID of the previous run of this job. For example, the <c>JobRunId</c> specified
        /// in the <c>StartJobRun</c> action.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 255)]
        public string PreviousRunId { get; set; }

        /// <summary>
        /// Checks to see if the PreviousRunId property is set.
        /// </summary>
        internal bool IsSetPreviousRunId() => this.PreviousRunId != null;

        /// <summary>
        /// Gets and sets the property ProfileName. 
        /// <para>
        /// The name of an Glue usage profile associated with the job run.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 255)]
        public string ProfileName { get; set; }

        /// <summary>
        /// Checks to see if the ProfileName property is set.
        /// </summary>
        internal bool IsSetProfileName() => this.ProfileName != null;

        /// <summary>
        /// Gets and sets the property SecurityConfiguration. 
        /// <para>
        /// The name of the <c>SecurityConfiguration</c> structure to be used with this job run.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 255)]
        public string SecurityConfiguration { get; set; }

        /// <summary>
        /// Checks to see if the SecurityConfiguration property is set.
        /// </summary>
        internal bool IsSetSecurityConfiguration() => this.SecurityConfiguration != null;

        /// <summary>
        /// Gets and sets the property StartedOn. 
        /// <para>
        /// The date and time at which this job run was started.
        /// </para>
        /// </summary>
        public DateTime? StartedOn { get; set; }

        /// <summary>
        /// Checks to see if the StartedOn property is set.
        /// </summary>
        internal bool IsSetStartedOn() => this.StartedOn.HasValue;

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
        [AWSProperty(Min = 0, Max = 400000)]
        public string StateDetail { get; set; }

        /// <summary>
        /// Checks to see if the StateDetail property is set.
        /// </summary>
        internal bool IsSetStateDetail() => this.StateDetail != null;

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
        /// When the value is left blank, the timeout is defaulted to 2,880 minutes for Glue version
        /// 4.0 and earlier, or 480 minutes for Glue version 5.0 and later.
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
        [AWSProperty(Min = 1)]
        public int? Timeout { get; set; }

        /// <summary>
        /// Checks to see if the Timeout property is set.
        /// </summary>
        internal bool IsSetTimeout() => this.Timeout.HasValue;

        /// <summary>
        /// Gets and sets the property TriggerName. 
        /// <para>
        /// The name of the trigger that started this job run.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 255)]
        public string TriggerName { get; set; }

        /// <summary>
        /// Checks to see if the TriggerName property is set.
        /// </summary>
        internal bool IsSetTriggerName() => this.TriggerName != null;

        /// <summary>
        /// Gets and sets the property WorkerType. 
        /// <para>
        /// The type of predefined worker that is allocated when a job runs. Accepts a value of
        /// G.025X, G.1X, G.2X, G.4X, G.8X, G.12X, G.16X, R.1X, R.2X, R.4X, or R.8X for Spark
        /// jobs. Accepts the value Z.2X for Ray jobs.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// For the <c>G.025X</c> worker type, each worker maps to 0.25 DPU (2 vCPUs, 4 GB of
        /// memory) with 84GB disk, and provides 1 executor per worker. We recommend this worker
        /// type for low volume streaming jobs. This worker type is only available for Glue version
        /// 3.0 or later streaming jobs.
        /// </para>
        ///  </li> <li> 
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
        /// ETL jobs in select Amazon Web Services Regions. For the supported Regions, see <a
        /// href="https://docs.aws.amazon.com/glue/latest/dg/add-job.html">Configuring job properties
        /// for Spark jobs</a> in the developer guide.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// For the <c>G.8X</c> worker type, each worker maps to 8 DPU (32 vCPUs, 128 GB of memory)
        /// with 512GB disk, and provides 1 executor per worker. We recommend this worker type
        /// for jobs whose workloads contain your most demanding transforms, aggregations, joins,
        /// and queries. This worker type is available only for Glue version 3.0 or later Spark
        /// ETL jobs in select Amazon Web Services Regions. For the supported Regions, see <a
        /// href="https://docs.aws.amazon.com/glue/latest/dg/add-job.html">Configuring job properties
        /// for Spark jobs</a> in the developer guide.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// For the <c>G.12X</c> worker type, each worker maps to 12 DPU (48 vCPUs, 192 GB of
        /// memory) with 768GB disk, and provides 1 executor per worker. We recommend this worker
        /// type for jobs with very large workloads. This worker type is available only for Glue
        /// version 4.0 or later Spark ETL jobs in select Amazon Web Services Regions. For the
        /// supported Regions, see <a href="https://docs.aws.amazon.com/glue/latest/dg/add-job.html">Configuring
        /// job properties for Spark jobs</a> in the developer guide.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// For the <c>G.16X</c> worker type, each worker maps to 16 DPU (64 vCPUs, 256 GB of
        /// memory) with 1024GB disk, and provides 1 executor per worker. We recommend this worker
        /// type for jobs with very large workloads. This worker type is available only for Glue
        /// version 4.0 or later Spark ETL jobs in select Amazon Web Services Regions. For the
        /// supported Regions, see <a href="https://docs.aws.amazon.com/glue/latest/dg/add-job.html">Configuring
        /// job properties for Spark jobs</a> in the developer guide.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// For the <c>R.1X</c> worker type, each worker maps to 1 M-DPU (4 vCPUs, 32 GB of memory)
        /// with 94GB disk, and provides 1 executor per worker. We recommend this worker type
        /// for memory-intensive workloads. This worker type is available only for Glue version
        /// 4.0 or later Spark ETL jobs in select Amazon Web Services Regions. For the supported
        /// Regions, see <a href="https://docs.aws.amazon.com/glue/latest/dg/add-job.html">Configuring
        /// job properties for Spark jobs</a> in the developer guide.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// For the <c>R.2X</c> worker type, each worker maps to 2 M-DPU (8 vCPUs, 64 GB of memory)
        /// with 138GB disk, and provides 1 executor per worker. We recommend this worker type
        /// for memory-intensive workloads. This worker type is available only for Glue version
        /// 4.0 or later Spark ETL jobs in select Amazon Web Services Regions. For the supported
        /// Regions, see <a href="https://docs.aws.amazon.com/glue/latest/dg/add-job.html">Configuring
        /// job properties for Spark jobs</a> in the developer guide.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// For the <c>R.4X</c> worker type, each worker maps to 4 M-DPU (16 vCPUs, 128 GB of
        /// memory) with 256GB disk, and provides 1 executor per worker. We recommend this worker
        /// type for memory-intensive workloads. This worker type is available only for Glue version
        /// 4.0 or later Spark ETL jobs in select Amazon Web Services Regions. For the supported
        /// Regions, see <a href="https://docs.aws.amazon.com/glue/latest/dg/add-job.html">Configuring
        /// job properties for Spark jobs</a> in the developer guide.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// For the <c>R.8X</c> worker type, each worker maps to 8 M-DPU (32 vCPUs, 256 GB of
        /// memory) with 512GB disk, and provides 1 executor per worker. We recommend this worker
        /// type for memory-intensive workloads. This worker type is available only for Glue version
        /// 4.0 or later Spark ETL jobs in select Amazon Web Services Regions. For the supported
        /// Regions, see <a href="https://docs.aws.amazon.com/glue/latest/dg/add-job.html">Configuring
        /// job properties for Spark jobs</a> in the developer guide.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// For the <c>Z.2X</c> worker type, each worker maps to 2 M-DPU (8vCPUs, 64 GB of memory)
        /// with 128 GB disk, and provides up to 8 Ray workers based on the autoscaler.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public WorkerType WorkerType { get; set; }

        /// <summary>
        /// Checks to see if the WorkerType property is set.
        /// </summary>
        internal bool IsSetWorkerType() => this.WorkerType != null;
    }
}
