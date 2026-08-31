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

namespace Amazon.Batch.Model
{
    /// <summary>
    /// An object that represents an Batch job.
    /// </summary>
    public partial class JobDetail
    {
        /// <summary>
        /// Gets and sets the property ArrayProperties. 
        /// <para>
        /// The array properties of the job, if it's an array job.
        /// </para>
        /// </summary>
        public ArrayPropertiesDetail ArrayProperties { get; set; }

        /// <summary>
        /// Checks to see if the ArrayProperties property is set.
        /// </summary>
        internal bool IsSetArrayProperties() => this.ArrayProperties != null;

        /// <summary>
        /// Gets and sets the property Attempts. 
        /// <para>
        /// A list of job attempts that are associated with this job.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<AttemptDetail> Attempts { get; set; } = AWSConfigs.InitializeCollections ? new List<AttemptDetail>() : null;

        /// <summary>
        /// Checks to see if the Attempts property is set.
        /// </summary>
        internal bool IsSetAttempts() => this.Attempts != null && (this.Attempts.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property ConsumableResourceProperties. 
        /// <para>
        /// Contains a list of consumable resources required by the job.
        /// </para>
        /// </summary>
        public ConsumableResourceProperties ConsumableResourceProperties { get; set; }

        /// <summary>
        /// Checks to see if the ConsumableResourceProperties property is set.
        /// </summary>
        internal bool IsSetConsumableResourceProperties() => this.ConsumableResourceProperties != null;

        /// <summary>
        /// Gets and sets the property Container. 
        /// <para>
        /// An object that represents the details for the container that's associated with the
        /// job. If the details are for a multiple-container job, this object will be empty. 
        /// </para>
        /// </summary>
        public ContainerDetail Container { get; set; }

        /// <summary>
        /// Checks to see if the Container property is set.
        /// </summary>
        internal bool IsSetContainer() => this.Container != null;

        /// <summary>
        /// Gets and sets the property CreatedAt. 
        /// <para>
        /// The Unix timestamp (in milliseconds) for when the job was created. For non-array jobs
        /// and parent array jobs, this is when the job entered the <c>SUBMITTED</c> state. This
        /// is specifically at the time <a href="https://docs.aws.amazon.com/batch/latest/APIReference/API_SubmitJob.html">SubmitJob</a>
        /// was called. For array child jobs, this is when the child job was spawned by its parent
        /// and entered the <c>PENDING</c> state.
        /// </para>
        /// </summary>
        public long? CreatedAt { get; set; }

        /// <summary>
        /// Checks to see if the CreatedAt property is set.
        /// </summary>
        internal bool IsSetCreatedAt() => this.CreatedAt.HasValue;

        /// <summary>
        /// Gets and sets the property DependsOn. 
        /// <para>
        /// A list of job IDs that this job depends on.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<JobDependency> DependsOn { get; set; } = AWSConfigs.InitializeCollections ? new List<JobDependency>() : null;

        /// <summary>
        /// Checks to see if the DependsOn property is set.
        /// </summary>
        internal bool IsSetDependsOn() => this.DependsOn != null && (this.DependsOn.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property EcsProperties. 
        /// <para>
        /// An object with properties that are specific to Amazon ECS-based jobs. 
        /// </para>
        /// </summary>
        public EcsPropertiesDetail EcsProperties { get; set; }

        /// <summary>
        /// Checks to see if the EcsProperties property is set.
        /// </summary>
        internal bool IsSetEcsProperties() => this.EcsProperties != null;

        /// <summary>
        /// Gets and sets the property EksAttempts. 
        /// <para>
        /// A list of job attempts that are associated with this job.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<EksAttemptDetail> EksAttempts { get; set; } = AWSConfigs.InitializeCollections ? new List<EksAttemptDetail>() : null;

        /// <summary>
        /// Checks to see if the EksAttempts property is set.
        /// </summary>
        internal bool IsSetEksAttempts() => this.EksAttempts != null && (this.EksAttempts.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property EksProperties. 
        /// <para>
        /// An object with various properties that are specific to Amazon EKS based jobs. 
        /// </para>
        /// </summary>
        public EksPropertiesDetail EksProperties { get; set; }

        /// <summary>
        /// Checks to see if the EksProperties property is set.
        /// </summary>
        internal bool IsSetEksProperties() => this.EksProperties != null;

        /// <summary>
        /// Gets and sets the property IsCancelled. 
        /// <para>
        /// Indicates whether the job is canceled.
        /// </para>
        /// </summary>
        public bool? IsCancelled { get; set; }

        /// <summary>
        /// Checks to see if the IsCancelled property is set.
        /// </summary>
        internal bool IsSetIsCancelled() => this.IsCancelled.HasValue;

        /// <summary>
        /// Gets and sets the property IsTerminated. 
        /// <para>
        /// Indicates whether the job is terminated.
        /// </para>
        /// </summary>
        public bool? IsTerminated { get; set; }

        /// <summary>
        /// Checks to see if the IsTerminated property is set.
        /// </summary>
        internal bool IsSetIsTerminated() => this.IsTerminated.HasValue;

        /// <summary>
        /// Gets and sets the property JobArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the job.
        /// </para>
        /// </summary>
        public string JobArn { get; set; }

        /// <summary>
        /// Checks to see if the JobArn property is set.
        /// </summary>
        internal bool IsSetJobArn() => this.JobArn != null;

        /// <summary>
        /// Gets and sets the property JobDefinition. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the job definition that this job uses.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string JobDefinition { get; set; }

        /// <summary>
        /// Checks to see if the JobDefinition property is set.
        /// </summary>
        internal bool IsSetJobDefinition() => this.JobDefinition != null;

        /// <summary>
        /// Gets and sets the property JobId. 
        /// <para>
        /// The job ID.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string JobId { get; set; }

        /// <summary>
        /// Checks to see if the JobId property is set.
        /// </summary>
        internal bool IsSetJobId() => this.JobId != null;

        /// <summary>
        /// Gets and sets the property JobName. 
        /// <para>
        /// The job name.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string JobName { get; set; }

        /// <summary>
        /// Checks to see if the JobName property is set.
        /// </summary>
        internal bool IsSetJobName() => this.JobName != null;

        /// <summary>
        /// Gets and sets the property JobQueue. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the job queue that the job is associated with.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string JobQueue { get; set; }

        /// <summary>
        /// Checks to see if the JobQueue property is set.
        /// </summary>
        internal bool IsSetJobQueue() => this.JobQueue != null;

        /// <summary>
        /// Gets and sets the property NodeDetails. 
        /// <para>
        /// An object that represents the details of a node that's associated with a multi-node
        /// parallel job.
        /// </para>
        /// </summary>
        public NodeDetails NodeDetails { get; set; }

        /// <summary>
        /// Checks to see if the NodeDetails property is set.
        /// </summary>
        internal bool IsSetNodeDetails() => this.NodeDetails != null;

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
        public NodeProperties NodeProperties { get; set; }

        /// <summary>
        /// Checks to see if the NodeProperties property is set.
        /// </summary>
        internal bool IsSetNodeProperties() => this.NodeProperties != null;

        /// <summary>
        /// Gets and sets the property Parameters. 
        /// <para>
        /// Additional parameters that are passed to the job that replace parameter substitution
        /// placeholders or override any corresponding parameter defaults from the job definition.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public Dictionary<string, string> Parameters { get; set; } = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;

        /// <summary>
        /// Checks to see if the Parameters property is set.
        /// </summary>
        internal bool IsSetParameters() => this.Parameters != null && (this.Parameters.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property PlatformCapabilities. 
        /// <para>
        /// The platform capabilities required by the job definition. If no value is specified,
        /// it defaults to <c>EC2</c>. Jobs run on Fargate resources specify <c>FARGATE</c>. Jobs
        /// run on Amazon ECS Managed Instances specify <c>MANAGED_INSTANCES</c>.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> PlatformCapabilities { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the PlatformCapabilities property is set.
        /// </summary>
        internal bool IsSetPlatformCapabilities() => this.PlatformCapabilities != null && (this.PlatformCapabilities.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property PropagateTags. 
        /// <para>
        /// Specifies whether to propagate the tags from the job or job definition to the corresponding
        /// Amazon ECS task. If no value is specified, the tags aren't propagated. Tags can only
        /// be propagated to the tasks when the tasks are created. For tags with the same name,
        /// job tags are given priority over job definitions tags. If the total number of combined
        /// tags from the job and job definition is over 50, the job is moved to the <c>FAILED</c>
        /// state.
        /// </para>
        /// </summary>
        public bool? PropagateTags { get; set; }

        /// <summary>
        /// Checks to see if the PropagateTags property is set.
        /// </summary>
        internal bool IsSetPropagateTags() => this.PropagateTags.HasValue;

        /// <summary>
        /// Gets and sets the property RetryStrategy. 
        /// <para>
        /// The retry strategy to use for this job if an attempt fails.
        /// </para>
        /// </summary>
        public RetryStrategy RetryStrategy { get; set; }

        /// <summary>
        /// Checks to see if the RetryStrategy property is set.
        /// </summary>
        internal bool IsSetRetryStrategy() => this.RetryStrategy != null;

        /// <summary>
        /// Gets and sets the property SchedulingPriority. 
        /// <para>
        /// The scheduling policy of the job definition. This only affects jobs in job queues
        /// with a fair-share policy. Jobs with a higher scheduling priority are scheduled before
        /// jobs with a lower scheduling priority.
        /// </para>
        /// </summary>
        public int? SchedulingPriority { get; set; }

        /// <summary>
        /// Checks to see if the SchedulingPriority property is set.
        /// </summary>
        internal bool IsSetSchedulingPriority() => this.SchedulingPriority.HasValue;

        /// <summary>
        /// Gets and sets the property ShareIdentifier. 
        /// <para>
        /// The share identifier for the job.
        /// </para>
        /// </summary>
        public string ShareIdentifier { get; set; }

        /// <summary>
        /// Checks to see if the ShareIdentifier property is set.
        /// </summary>
        internal bool IsSetShareIdentifier() => this.ShareIdentifier != null;

        /// <summary>
        /// Gets and sets the property StartedAt. 
        /// <para>
        /// The Unix timestamp (in milliseconds) for when the job was started. More specifically,
        /// it's when the job transitioned from the <c>STARTING</c> state to the <c>RUNNING</c>
        /// state. 
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public long? StartedAt { get; set; }

        /// <summary>
        /// Checks to see if the StartedAt property is set.
        /// </summary>
        internal bool IsSetStartedAt() => this.StartedAt.HasValue;

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The current status for the job.
        /// </para>
        ///  <note> 
        /// <para>
        /// If your jobs don't progress to <c>STARTING</c>, see <a href="https://docs.aws.amazon.com/batch/latest/userguide/troubleshooting.html#job_stuck_in_runnable">Jobs
        /// stuck in RUNNABLE status</a> in the troubleshooting section of the <i>Batch User Guide</i>.
        /// </para>
        ///  </note>
        /// </summary>
        [AWSProperty(Required = true)]
        public JobStatus Status { get; set; }

        /// <summary>
        /// Checks to see if the Status property is set.
        /// </summary>
        internal bool IsSetStatus() => this.Status != null;

        /// <summary>
        /// Gets and sets the property StatusReason. 
        /// <para>
        /// A short, human-readable string to provide more details for the current status of the
        /// job.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>CAPACITY:INSUFFICIENT_INSTANCE_CAPACITY</c> - All compute environments have insufficient
        /// capacity to service the job.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>MISCONFIGURATION:COMPUTE_ENVIRONMENT_MAX_RESOURCE</c> - All compute environments
        /// have a <c>maxVcpu</c> setting that is smaller than the job requirements.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>MISCONFIGURATION:JOB_RESOURCE_REQUIREMENT</c> - All compute environments have
        /// no connected instances that meet the job requirements.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>MISCONFIGURATION:SERVICE_ROLE_PERMISSIONS</c> - All compute environments have
        /// problems with the service role permissions.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public string StatusReason { get; set; }

        /// <summary>
        /// Checks to see if the StatusReason property is set.
        /// </summary>
        internal bool IsSetStatusReason() => this.StatusReason != null;

        /// <summary>
        /// Gets and sets the property StoppedAt. 
        /// <para>
        /// The Unix timestamp (in milliseconds) for when the job was stopped. More specifically,
        /// it's when the job transitioned from the <c>RUNNING</c> state to a terminal state,
        /// such as <c>SUCCEEDED</c> or <c>FAILED</c>.
        /// </para>
        /// </summary>
        public long? StoppedAt { get; set; }

        /// <summary>
        /// Checks to see if the StoppedAt property is set.
        /// </summary>
        internal bool IsSetStoppedAt() => this.StoppedAt.HasValue;

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// The tags that are applied to the job.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 1, Max = 50)]
        public Dictionary<string, string> Tags { get; set; } = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;

        /// <summary>
        /// Checks to see if the Tags property is set.
        /// </summary>
        internal bool IsSetTags() => this.Tags != null && (this.Tags.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property Timeout. 
        /// <para>
        /// The timeout configuration for the job.
        /// </para>
        /// </summary>
        public JobTimeout Timeout { get; set; }

        /// <summary>
        /// Checks to see if the Timeout property is set.
        /// </summary>
        internal bool IsSetTimeout() => this.Timeout != null;
    }
}
