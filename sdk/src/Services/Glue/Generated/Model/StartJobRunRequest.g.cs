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
    /// Container for the parameters to the StartJobRun operation. Starts a job run using
    /// a job definition.
    /// </summary>
    public partial class StartJobRunRequest : AmazonGlueRequest
    {
        /// <summary>
        /// Gets and sets the property AllocatedCapacity. 
        /// <para>
        /// This field is deprecated. Use <c>MaxCapacity</c> instead.
        /// </para>
        ///  
        /// <para>
        /// The number of Glue data processing units (DPUs) to allocate to this JobRun. You can
        /// allocate a minimum of 2 DPUs; the default is 10. A DPU is a relative measure of processing
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
        /// Gets and sets the property JobName. 
        /// <para>
        /// The name of the job definition to use.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 255)]
        public string JobName { get; set; }

        /// <summary>
        /// Checks to see if the JobName property is set.
        /// </summary>
        internal bool IsSetJobName() => this.JobName != null;

        /// <summary>
        /// Gets and sets the property JobRunId. 
        /// <para>
        /// The ID of a previous <c>JobRun</c> to retry.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 255)]
        public string JobRunId { get; set; }

        /// <summary>
        /// Checks to see if the JobRunId property is set.
        /// </summary>
        internal bool IsSetJobRunId() => this.JobRunId != null;

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
        public WorkerType WorkerType { get; set; }

        /// <summary>
        /// Checks to see if the WorkerType property is set.
        /// </summary>
        internal bool IsSetWorkerType() => this.WorkerType != null;
    }
}
