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
    /// Container for the parameters to the SubmitJob operation. Submits an Batch job from
    /// a job definition. Parameters that are specified during <a>SubmitJob</a> override parameters
    /// defined in the job definition. vCPU and memory requirements that are specified in
    /// the <c>resourceRequirements</c> objects in the job definition are the exception. They
    /// can't be overridden this way using the <c>memory</c> and <c>vcpus</c> parameters.
    /// Rather, you must specify updates to job definition parameters in a <c>resourceRequirements</c>
    /// object that's included in the <c>containerOverrides</c> parameter. <note> <para> Job
    /// queues with a scheduling policy are limited to 500 active share identifiers at a time.
    /// </para> </note> <important> <para> Jobs that run on Fargate resources can't be guaranteed
    /// to run for more than 14 days. This is because, after 14 days, Fargate resources might
    /// become unavailable and job might be terminated. </para> </important>
    /// </summary>
    public partial class SubmitJobRequest : AmazonBatchRequest
    {
        /// <summary>
        /// Gets and sets the property ArrayProperties. 
        /// <para>
        /// The array properties for the submitted job, such as the size of the array. The array
        /// size can be between 2 and 10,000. If you specify array properties for a job, it becomes
        /// an array job. For more information, see <a href="https://docs.aws.amazon.com/batch/latest/userguide/array_jobs.html">Array
        /// Jobs</a> in the <i>Batch User Guide</i>.
        /// </para>
        /// </summary>
        public ArrayProperties ArrayProperties { get; set; }

        /// <summary>
        /// Checks to see if the ArrayProperties property is set.
        /// </summary>
        internal bool IsSetArrayProperties() => this.ArrayProperties != null;

        /// <summary>
        /// Gets and sets the property ConsumableResourcePropertiesOverride. 
        /// <para>
        /// An object that contains overrides for the consumable resources of a job.
        /// </para>
        /// </summary>
        public ConsumableResourceProperties ConsumableResourcePropertiesOverride { get; set; }

        /// <summary>
        /// Checks to see if the ConsumableResourcePropertiesOverride property is set.
        /// </summary>
        internal bool IsSetConsumableResourcePropertiesOverride() => this.ConsumableResourcePropertiesOverride != null;

        /// <summary>
        /// Gets and sets the property ContainerOverrides. 
        /// <para>
        /// An object with properties that override the defaults for the job definition that specify
        /// the name of a container in the specified job definition and the overrides it should
        /// receive. You can override the default command for a container, which is specified
        /// in the job definition or the Docker image, with a <c>command</c> override. You can
        /// also override existing environment variables on a container or add new environment
        /// variables to it with an <c>environment</c> override.
        /// </para>
        /// </summary>
        public ContainerOverrides ContainerOverrides { get; set; }

        /// <summary>
        /// Checks to see if the ContainerOverrides property is set.
        /// </summary>
        internal bool IsSetContainerOverrides() => this.ContainerOverrides != null;

        /// <summary>
        /// Gets and sets the property DependsOn. 
        /// <para>
        /// A list of dependencies for the job. A job can depend upon a maximum of 20 jobs. You
        /// can specify a <c>SEQUENTIAL</c> type dependency without specifying a job ID for array
        /// jobs so that each child array job completes sequentially, starting at index 0. You
        /// can also specify an <c>N_TO_N</c> type dependency with a job ID for array jobs. In
        /// that case, each index child of this job must wait for the corresponding index child
        /// of each dependency to complete before it can begin.
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
        /// Gets and sets the property EcsPropertiesOverride. 
        /// <para>
        /// An object, with properties that override defaults for the job definition, can only
        /// be specified for jobs that are run on Amazon ECS resources.
        /// </para>
        /// </summary>
        public EcsPropertiesOverride EcsPropertiesOverride { get; set; }

        /// <summary>
        /// Checks to see if the EcsPropertiesOverride property is set.
        /// </summary>
        internal bool IsSetEcsPropertiesOverride() => this.EcsPropertiesOverride != null;

        /// <summary>
        /// Gets and sets the property EksPropertiesOverride. 
        /// <para>
        /// An object, with properties that override defaults for the job definition, can only
        /// be specified for jobs that are run on Amazon EKS resources.
        /// </para>
        /// </summary>
        public EksPropertiesOverride EksPropertiesOverride { get; set; }

        /// <summary>
        /// Checks to see if the EksPropertiesOverride property is set.
        /// </summary>
        internal bool IsSetEksPropertiesOverride() => this.EksPropertiesOverride != null;

        /// <summary>
        /// Gets and sets the property JobDefinition. 
        /// <para>
        /// The job definition used by this job. This value can be one of <c>definition-name</c>,
        /// <c>definition-name:revision</c>, or the Amazon Resource Name (ARN) for the job definition,
        /// with or without the revision (<c>arn:aws:batch:<i>region</i>:<i>account</i>:job-definition/<i>definition-name</i>:<i>revision</i>
        /// </c>, or <c>arn:aws:batch:<i>region</i>:<i>account</i>:job-definition/<i>definition-name</i>
        /// </c>).
        /// </para>
        ///  
        /// <para>
        /// If the revision is not specified, then the latest active revision is used.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string JobDefinition { get; set; }

        /// <summary>
        /// Checks to see if the JobDefinition property is set.
        /// </summary>
        internal bool IsSetJobDefinition() => this.JobDefinition != null;

        /// <summary>
        /// Gets and sets the property JobName. 
        /// <para>
        /// The name of the job. It can be up to 128 letters long. The first character must be
        /// alphanumeric, can contain uppercase and lowercase letters, numbers, hyphens (-), and
        /// underscores (_).
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
        /// The job queue where the job is submitted. You can specify either the name or the Amazon
        /// Resource Name (ARN) of the queue.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string JobQueue { get; set; }

        /// <summary>
        /// Checks to see if the JobQueue property is set.
        /// </summary>
        internal bool IsSetJobQueue() => this.JobQueue != null;

        /// <summary>
        /// Gets and sets the property NodeOverrides. 
        /// <para>
        /// A list of node overrides in JSON format that specify the node range to target and
        /// the container overrides for that node range.
        /// </para>
        ///  <note> 
        /// <para>
        /// This parameter isn't applicable to jobs that are running on Fargate resources; use
        /// <c>containerOverrides</c> instead.
        /// </para>
        ///  </note>
        /// </summary>
        public NodeOverrides NodeOverrides { get; set; }

        /// <summary>
        /// Checks to see if the NodeOverrides property is set.
        /// </summary>
        internal bool IsSetNodeOverrides() => this.NodeOverrides != null;

        /// <summary>
        /// Gets and sets the property Parameters. 
        /// <para>
        /// Additional parameters passed to the job that replace parameter substitution placeholders
        /// that are set in the job definition. Parameters are specified as a key and value pair
        /// mapping. Parameters in a <c>SubmitJob</c> request override any corresponding parameter
        /// defaults from the job definition.
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
        /// Gets and sets the property PropagateTags. 
        /// <para>
        /// Specifies whether to propagate the tags from the job or job definition to the corresponding
        /// Amazon ECS task. If no value is specified, the tags aren't propagated. Tags can only
        /// be propagated to the tasks during task creation. For tags with the same name, job
        /// tags are given priority over job definitions tags. If the total number of combined
        /// tags from the job and job definition is over 50, the job is moved to the <c>FAILED</c>
        /// state. When specified, this overrides the tag propagation setting in the job definition.
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
        /// The retry strategy to use for failed jobs from this <a>SubmitJob</a> operation. When
        /// a retry strategy is specified here, it overrides the retry strategy defined in the
        /// job definition.
        /// </para>
        /// </summary>
        public RetryStrategy RetryStrategy { get; set; }

        /// <summary>
        /// Checks to see if the RetryStrategy property is set.
        /// </summary>
        internal bool IsSetRetryStrategy() => this.RetryStrategy != null;

        /// <summary>
        /// Gets and sets the property SchedulingPriorityOverride. 
        /// <para>
        /// The scheduling priority for the job. This only affects jobs in job queues with a fair-share
        /// policy. Jobs with a higher scheduling priority are scheduled before jobs with a lower
        /// scheduling priority. This overrides any scheduling priority in the job definition
        /// and works only within a single share identifier.
        /// </para>
        ///  
        /// <para>
        /// The minimum supported value is 0 and the maximum supported value is 9999.
        /// </para>
        /// </summary>
        public int? SchedulingPriorityOverride { get; set; }

        /// <summary>
        /// Checks to see if the SchedulingPriorityOverride property is set.
        /// </summary>
        internal bool IsSetSchedulingPriorityOverride() => this.SchedulingPriorityOverride.HasValue;

        /// <summary>
        /// Gets and sets the property ShareIdentifier. 
        /// <para>
        /// The share identifier for the job. Don't specify this parameter if the job queue doesn't
        /// have a fair-share scheduling policy. If the job queue has a fair-share scheduling
        /// policy, then this parameter must be specified.
        /// </para>
        ///  
        /// <para>
        /// This string is limited to 255 alphanumeric characters, and can be followed by an asterisk
        /// (*).
        /// </para>
        /// </summary>
        public string ShareIdentifier { get; set; }

        /// <summary>
        /// Checks to see if the ShareIdentifier property is set.
        /// </summary>
        internal bool IsSetShareIdentifier() => this.ShareIdentifier != null;

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// The tags that you apply to the job request to help you categorize and organize your
        /// resources. Each tag consists of a key and an optional value. For more information,
        /// see <a href="https://docs.aws.amazon.com/general/latest/gr/aws_tagging.html">Tagging
        /// Amazon Web Services Resources</a> in <i>Amazon Web Services General Reference</i>.
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
        /// The timeout configuration for this <a>SubmitJob</a> operation. You can specify a timeout
        /// duration after which Batch terminates your jobs if they haven't finished. If a job
        /// is terminated due to a timeout, it isn't retried. The minimum value for the timeout
        /// is 60 seconds. This configuration overrides any timeout configuration specified in
        /// the job definition. For array jobs, child jobs have the same timeout configuration
        /// as the parent job. For more information, see <a href="https://docs.aws.amazon.com/AmazonECS/latest/developerguide/job_timeouts.html">Job
        /// Timeouts</a> in the <i>Amazon Elastic Container Service Developer Guide</i>.
        /// </para>
        /// </summary>
        public JobTimeout Timeout { get; set; }

        /// <summary>
        /// Checks to see if the Timeout property is set.
        /// </summary>
        internal bool IsSetTimeout() => this.Timeout != null;
    }
}
