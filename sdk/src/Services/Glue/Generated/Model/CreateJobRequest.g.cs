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
    /// Container for the parameters to the CreateJob operation. Creates a new job definition.
    /// </summary>
    public partial class CreateJobRequest : AmazonGlueRequest
    {
        /// <summary>
        /// Gets and sets the property AllocatedCapacity. 
        /// <para>
        /// This parameter is deprecated. Use <c>MaxCapacity</c> instead.
        /// </para>
        ///  
        /// <para>
        /// The number of Glue data processing units (DPUs) to allocate to this Job. You can allocate
        /// a minimum of 2 DPUs; the default is 10. A DPU is a relative measure of processing
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
        /// Gets and sets the property CodeGenConfigurationNodes. 
        /// <para>
        /// The representation of a directed acyclic graph on which both the Glue Studio visual
        /// component and Glue Studio code generation is based.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Sensitive = true)]
        public Dictionary<string, CodeGenConfigurationNode> CodeGenConfigurationNodes { get; set; } = AWSConfigs.InitializeCollections ? new Dictionary<string, CodeGenConfigurationNode>() : null;

        /// <summary>
        /// Checks to see if the CodeGenConfigurationNodes property is set.
        /// </summary>
        internal bool IsSetCodeGenConfigurationNodes() => this.CodeGenConfigurationNodes != null && (this.CodeGenConfigurationNodes.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property Command. 
        /// <para>
        /// The <c>JobCommand</c> that runs this job.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public JobCommand Command { get; set; }

        /// <summary>
        /// Checks to see if the Command property is set.
        /// </summary>
        internal bool IsSetCommand() => this.Command != null;

        /// <summary>
        /// Gets and sets the property Connections. 
        /// <para>
        /// The connections used for this job.
        /// </para>
        /// </summary>
        public ConnectionsList Connections { get; set; }

        /// <summary>
        /// Checks to see if the Connections property is set.
        /// </summary>
        internal bool IsSetConnections() => this.Connections != null;

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
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public Dictionary<string, string> DefaultArguments { get; set; } = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;

        /// <summary>
        /// Checks to see if the DefaultArguments property is set.
        /// </summary>
        internal bool IsSetDefaultArguments() => this.DefaultArguments != null && (this.DefaultArguments.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// Description of the job being defined.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 2048)]
        public string Description { get; set; }

        /// <summary>
        /// Checks to see if the Description property is set.
        /// </summary>
        internal bool IsSetDescription() => this.Description != null;

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
        /// Gets and sets the property ExecutionProperty. 
        /// <para>
        /// An <c>ExecutionProperty</c> specifying the maximum number of concurrent runs allowed
        /// for this job.
        /// </para>
        /// </summary>
        public ExecutionProperty ExecutionProperty { get; set; }

        /// <summary>
        /// Checks to see if the ExecutionProperty property is set.
        /// </summary>
        internal bool IsSetExecutionProperty() => this.ExecutionProperty != null;

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
        public bool? JobRunQueuingEnabled { get; set; }

        /// <summary>
        /// Checks to see if the JobRunQueuingEnabled property is set.
        /// </summary>
        internal bool IsSetJobRunQueuingEnabled() => this.JobRunQueuingEnabled.HasValue;

        /// <summary>
        /// Gets and sets the property LogUri. 
        /// <para>
        /// This field is reserved for future use.
        /// </para>
        /// </summary>
        public string LogUri { get; set; }

        /// <summary>
        /// Checks to see if the LogUri property is set.
        /// </summary>
        internal bool IsSetLogUri() => this.LogUri != null;

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
        /// Gets and sets the property MaxRetries. 
        /// <para>
        /// The maximum number of times to retry this job if it fails.
        /// </para>
        /// </summary>
        public int? MaxRetries { get; set; }

        /// <summary>
        /// Checks to see if the MaxRetries property is set.
        /// </summary>
        internal bool IsSetMaxRetries() => this.MaxRetries.HasValue;

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name you assign to this job definition. It must be unique in your account.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 255)]
        public string Name { get; set; }

        /// <summary>
        /// Checks to see if the Name property is set.
        /// </summary>
        internal bool IsSetName() => this.Name != null;

        /// <summary>
        /// Gets and sets the property NonOverridableArguments. 
        /// <para>
        /// Arguments for this job that are not overridden when providing job arguments in a job
        /// run, specified as name-value pairs.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public Dictionary<string, string> NonOverridableArguments { get; set; } = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;

        /// <summary>
        /// Checks to see if the NonOverridableArguments property is set.
        /// </summary>
        internal bool IsSetNonOverridableArguments() => this.NonOverridableArguments != null && (this.NonOverridableArguments.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property NotificationProperty. 
        /// <para>
        /// Specifies configuration properties of a job notification.
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
        /// Gets and sets the property Role. 
        /// <para>
        /// The name or Amazon Resource Name (ARN) of the IAM role associated with this job.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string Role { get; set; }

        /// <summary>
        /// Checks to see if the Role property is set.
        /// </summary>
        internal bool IsSetRole() => this.Role != null;

        /// <summary>
        /// Gets and sets the property SecurityConfiguration. 
        /// <para>
        /// The name of the <c>SecurityConfiguration</c> structure to be used with this job.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 255)]
        public string SecurityConfiguration { get; set; }

        /// <summary>
        /// Checks to see if the SecurityConfiguration property is set.
        /// </summary>
        internal bool IsSetSecurityConfiguration() => this.SecurityConfiguration != null;

        /// <summary>
        /// Gets and sets the property SourceControlDetails. 
        /// <para>
        /// The details for a source control configuration for a job, allowing synchronization
        /// of job artifacts to or from a remote repository.
        /// </para>
        /// </summary>
        public SourceControlDetails SourceControlDetails { get; set; }

        /// <summary>
        /// Checks to see if the SourceControlDetails property is set.
        /// </summary>
        internal bool IsSetSourceControlDetails() => this.SourceControlDetails != null;

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// The tags to use with this job. You may use tags to limit access to the job. For more
        /// information about tags in Glue, see <a href="https://docs.aws.amazon.com/glue/latest/dg/monitor-tags.html">Amazon
        /// Web Services Tags in Glue</a> in the developer guide.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 0, Max = 50)]
        public Dictionary<string, string> Tags { get; set; } = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;

        /// <summary>
        /// Checks to see if the Tags property is set.
        /// </summary>
        internal bool IsSetTags() => this.Tags != null && (this.Tags.Count > 0 || !AWSConfigs.InitializeCollections);

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
