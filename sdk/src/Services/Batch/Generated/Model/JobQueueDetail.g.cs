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
    /// An object that represents the details for an Batch job queue.
    /// </summary>
    public partial class JobQueueDetail
    {
        /// <summary>
        /// Gets and sets the property ComputeEnvironmentOrder. 
        /// <para>
        /// The compute environments that are attached to the job queue and the order that job
        /// placement is preferred. Compute environments are selected for job placement in ascending
        /// order.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required = true)]
        public List<ComputeEnvironmentOrder> ComputeEnvironmentOrder { get; set; } = AWSConfigs.InitializeCollections ? new List<ComputeEnvironmentOrder>() : null;

        /// <summary>
        /// Checks to see if the ComputeEnvironmentOrder property is set.
        /// </summary>
        internal bool IsSetComputeEnvironmentOrder() => this.ComputeEnvironmentOrder != null && (this.ComputeEnvironmentOrder.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property JobQueueArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the job queue.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string JobQueueArn { get; set; }

        /// <summary>
        /// Checks to see if the JobQueueArn property is set.
        /// </summary>
        internal bool IsSetJobQueueArn() => this.JobQueueArn != null;

        /// <summary>
        /// Gets and sets the property JobQueueName. 
        /// <para>
        /// The job queue name.
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
        /// The set of actions that Batch perform on jobs that remain at the head of the job queue
        /// in the specified state longer than specified times. Batch will perform each action
        /// after <c>maxTimeSeconds</c> has passed.
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
        /// The priority of the job queue. Job queue priority determines the order that job queues
        /// are evaluated when multiple queues dispatch jobs within a shared compute environment.
        /// A higher value for <c>priority</c> indicates a higher priority. Queues are evaluated
        /// in cycles, in descending order by priority. For example, a job queue with a priority
        /// value of <c>10</c> is evaluated before a queue with a priority value of <c>1</c>.
        /// All of the compute environments must be either Amazon EC2 (<c>EC2</c> or <c>SPOT</c>)
        /// or Fargate (<c>FARGATE</c> or <c>FARGATE_SPOT</c>). Amazon EC2 and Fargate compute
        /// environments can't be mixed.
        /// </para>
        ///  <note> 
        /// <para>
        /// Job queue priority doesn't guarantee that a particular job executes before a job in
        /// a lower priority queue. Jobs added to higher priority queues during the queue evaluation
        /// cycle might not be evaluated until the next cycle. A job is dispatched from a queue
        /// only if resources are available when the queue is evaluated. If there are insufficient
        /// resources available at that time, the cycle proceeds to the next queue. This means
        /// that jobs added to higher priority queues might have to wait for jobs in multiple
        /// lower priority queues to complete before they are dispatched. You can use job dependencies
        /// to control the order for jobs from queues with different priorities. For more information,
        /// see <a href="https://docs.aws.amazon.com/batch/latest/userguide/job_dependencies.html">Job
        /// Dependencies</a> in the <i>Batch User Guide</i>.
        /// </para>
        ///  </note>
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
        /// The Amazon Resource Name (ARN) of the scheduling policy. The format is <c>aws:<i>Partition</i>:batch:<i>Region</i>:<i>Account</i>:scheduling-policy/<i>Name</i>
        /// </c>. For example, <c>aws:aws:batch:us-west-2:123456789012:scheduling-policy/MySchedulingPolicy</c>.
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
        /// The order of the service environment associated with the job queue. Job queues with
        /// a higher priority are evaluated first when associated with the same service environment.
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
        /// Describes the ability of the queue to accept new jobs. If the job queue state is <c>ENABLED</c>,
        /// it can accept jobs. If the job queue state is <c>DISABLED</c>, new jobs can't be added
        /// to the queue, but jobs already in the queue can finish.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public JQState State { get; set; }

        /// <summary>
        /// Checks to see if the State property is set.
        /// </summary>
        internal bool IsSetState() => this.State != null;

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The status of the job queue (for example, <c>CREATING</c> or <c>VALID</c>).
        /// </para>
        /// </summary>
        public JQStatus Status { get; set; }

        /// <summary>
        /// Checks to see if the Status property is set.
        /// </summary>
        internal bool IsSetStatus() => this.Status != null;

        /// <summary>
        /// Gets and sets the property StatusReason. 
        /// <para>
        /// A short, human-readable string to provide additional details for the current status
        /// of the job queue.
        /// </para>
        /// </summary>
        public string StatusReason { get; set; }

        /// <summary>
        /// Checks to see if the StatusReason property is set.
        /// </summary>
        internal bool IsSetStatusReason() => this.StatusReason != null;

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// The tags that are applied to the job queue. For more information, see <a href="https://docs.aws.amazon.com/batch/latest/userguide/using-tags.html">Tagging
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
