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
    /// Container for the parameters to the CreateJobQueue operation. Creates an Batch job
    /// queue. When you create a job queue, you associate one or more compute environments
    /// to the queue and assign an order of preference for the compute environments. <para>
    /// You also set a priority to the job queue that determines the order that the Batch
    /// scheduler places jobs onto its associated compute environments. For example, if a
    /// compute environment is associated with more than one job queue, the job queue with
    /// a higher priority is given preference for scheduling jobs to that compute environment.
    /// </para>
    /// </summary>
    public partial class CreateJobQueueRequest : AmazonBatchRequest
    {
        /// <summary>
        /// Gets and sets the property ComputeEnvironmentOrder. 
        /// <para>
        /// The set of compute environments mapped to a job queue and their order relative to
        /// each other. The job scheduler uses this parameter to determine which compute environment
        /// runs a specific job. Compute environments must be in the <c>VALID</c> state before
        /// you can associate them with a job queue. You can associate up to three compute environments
        /// with a job queue. All of the compute environments must be either EC2 (<c>EC2</c> or
        /// <c>SPOT</c>) or Fargate (<c>FARGATE</c> or <c>FARGATE_SPOT</c>); EC2 and Fargate compute
        /// environments can't be mixed.
        /// </para>
        ///  <note> 
        /// <para>
        /// All compute environments that are associated with a job queue must share the same
        /// architecture. Batch doesn't support mixing compute environment architecture types
        /// in a single job queue.
        /// </para>
        ///  </note>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<ComputeEnvironmentOrder> ComputeEnvironmentOrder { get; set; } = AWSConfigs.InitializeCollections ? new List<ComputeEnvironmentOrder>() : null;

        /// <summary>
        /// Checks to see if the ComputeEnvironmentOrder property is set.
        /// </summary>
        internal bool IsSetComputeEnvironmentOrder() => this.ComputeEnvironmentOrder != null && (this.ComputeEnvironmentOrder.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property JobQueueName. 
        /// <para>
        /// The name of the job queue. It can be up to 128 letters long. It can contain uppercase
        /// and lowercase letters, numbers, hyphens (-), and underscores (_).
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string JobQueueName { get; set; }

        /// <summary>
        /// Checks to see if the JobQueueName property is set.
        /// </summary>
        internal bool IsSetJobQueueName() => this.JobQueueName != null;

        /// <summary>
        /// Gets and sets the property JobQueueType. 
        /// <para>
        /// The type of job queue. For service jobs that run on SageMaker Training, this value
        /// is <c>SAGEMAKER_TRAINING</c>. For regular container jobs, this value is <c>EKS</c>,
        /// <c>ECS</c>, or <c>ECS_FARGATE</c> depending on the compute environment.
        /// </para>
        /// </summary>
        public JobQueueType JobQueueType { get; set; }

        /// <summary>
        /// Checks to see if the JobQueueType property is set.
        /// </summary>
        internal bool IsSetJobQueueType() => this.JobQueueType != null;

        /// <summary>
        /// Gets and sets the property JobStateTimeLimitActions. 
        /// <para>
        /// The set of actions that Batch performs on jobs that remain at the head of the job
        /// queue in the specified state longer than specified times. Batch will perform each
        /// action after <c>maxTimeSeconds</c> has passed. (<b>Note</b>: The minimum value for
        /// maxTimeSeconds is 600 (10 minutes) and its maximum value is 86,400 (24 hours).)
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<JobStateTimeLimitAction> JobStateTimeLimitActions { get; set; } = AWSConfigs.InitializeCollections ? new List<JobStateTimeLimitAction>() : null;

        /// <summary>
        /// Checks to see if the JobStateTimeLimitActions property is set.
        /// </summary>
        internal bool IsSetJobStateTimeLimitActions() => this.JobStateTimeLimitActions != null && (this.JobStateTimeLimitActions.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property Priority. 
        /// <para>
        /// The priority of the job queue. Job queues with a higher priority (or a higher integer
        /// value for the <c>priority</c> parameter) are evaluated first when associated with
        /// the same compute environment. Priority is determined in descending order. For example,
        /// a job queue with a priority value of <c>10</c> is given scheduling preference over
        /// a job queue with a priority value of <c>1</c>. All of the compute environments must
        /// be either EC2 (<c>EC2</c> or <c>SPOT</c>) or Fargate (<c>FARGATE</c> or <c>FARGATE_SPOT</c>);
        /// EC2 and Fargate compute environments can't be mixed.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public int? Priority { get; set; }

        /// <summary>
        /// Checks to see if the Priority property is set.
        /// </summary>
        internal bool IsSetPriority() => this.Priority.HasValue;

        /// <summary>
        /// Gets and sets the property SchedulingPolicyArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the fair-share scheduling policy. Job queues that
        /// don't have a fair-share scheduling policy are scheduled in a first-in, first-out (FIFO)
        /// model. After a job queue has a fair-share scheduling policy, it can be replaced but
        /// can't be removed.
        /// </para>
        ///  
        /// <para>
        /// The format is <c>aws:<i>Partition</i>:batch:<i>Region</i>:<i>Account</i>:scheduling-policy/<i>Name</i>
        /// </c>.
        /// </para>
        ///  
        /// <para>
        /// An example is <c>aws:aws:batch:us-west-2:123456789012:scheduling-policy/MySchedulingPolicy</c>.
        /// </para>
        ///  
        /// <para>
        /// A job queue without a fair-share scheduling policy is scheduled as a FIFO job queue
        /// and can't have a fair-share scheduling policy added. Jobs queues with a fair-share
        /// scheduling policy can have a maximum of 500 active share identifiers. When the limit
        /// has been reached, submissions of any jobs that add a new share identifier fail.
        /// </para>
        /// </summary>
        public string SchedulingPolicyArn { get; set; }

        /// <summary>
        /// Checks to see if the SchedulingPolicyArn property is set.
        /// </summary>
        internal bool IsSetSchedulingPolicyArn() => this.SchedulingPolicyArn != null;

        /// <summary>
        /// Gets and sets the property ServiceEnvironmentOrder. 
        /// <para>
        /// A list of service environments that this job queue can use to allocate jobs. All serviceEnvironments
        /// must have the same type. A job queue can't have both a serviceEnvironmentOrder and
        /// a computeEnvironmentOrder field.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<ServiceEnvironmentOrder> ServiceEnvironmentOrder { get; set; } = AWSConfigs.InitializeCollections ? new List<ServiceEnvironmentOrder>() : null;

        /// <summary>
        /// Checks to see if the ServiceEnvironmentOrder property is set.
        /// </summary>
        internal bool IsSetServiceEnvironmentOrder() => this.ServiceEnvironmentOrder != null && (this.ServiceEnvironmentOrder.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property State. 
        /// <para>
        /// The state of the job queue. If the job queue state is <c>ENABLED</c>, it is able to
        /// accept jobs. If the job queue state is <c>DISABLED</c>, new jobs can't be added to
        /// the queue, but jobs already in the queue can finish.
        /// </para>
        /// </summary>
        public JQState State { get; set; }

        /// <summary>
        /// Checks to see if the State property is set.
        /// </summary>
        internal bool IsSetState() => this.State != null;

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// The tags that you apply to the job queue to help you categorize and organize your
        /// resources. Each tag consists of a key and an optional value. For more information,
        /// see <a href="https://docs.aws.amazon.com/batch/latest/userguide/using-tags.html">Tagging
        /// your Batch resources</a> in <i>Batch User Guide</i>.
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
    }
}
