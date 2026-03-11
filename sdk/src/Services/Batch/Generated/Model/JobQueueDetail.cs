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
 * Do not modify this file. This file is generated from the batch-2016-08-10.normal.json service model.
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
        private List<ComputeEnvironmentOrder> _computeEnvironmentOrder = AWSConfigs.InitializeCollections ? new List<ComputeEnvironmentOrder>() : null;
        private string _jobQueueArn;
        private string _jobQueueName;
        private JobQueueType _jobQueueType;
        private List<JobStateTimeLimitAction> _jobStateTimeLimitActions = AWSConfigs.InitializeCollections ? new List<JobStateTimeLimitAction>() : null;
        private int? _priority;
        private string _schedulingPolicyArn;
        private List<ServiceEnvironmentOrder> _serviceEnvironmentOrder = AWSConfigs.InitializeCollections ? new List<ServiceEnvironmentOrder>() : null;
        private JQState _state;
        private JQStatus _status;
        private string _statusReason;
        private Dictionary<string, string> _tags = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;

        /// <summary>
        /// Gets and sets the property ComputeEnvironmentOrder. 
        /// <para>
        /// The compute environments that are attached to the job queue and the order that job
        /// placement is preferred. Compute environments are selected for job placement in ascending
        /// order.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required=true)]
        public List<ComputeEnvironmentOrder> ComputeEnvironmentOrder
        {
            get { return this._computeEnvironmentOrder; }
            set { this._computeEnvironmentOrder = value; }
        }

        // Check to see if ComputeEnvironmentOrder property is set
        internal bool IsSetComputeEnvironmentOrder()
        {
            return this._computeEnvironmentOrder != null && (this._computeEnvironmentOrder.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property JobQueueArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the job queue.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string JobQueueArn
        {
            get { return this._jobQueueArn; }
            set { this._jobQueueArn = value; }
        }

        // Check to see if JobQueueArn property is set
        internal bool IsSetJobQueueArn()
        {
            return this._jobQueueArn != null;
        }

        /// <summary>
        /// Gets and sets the property JobQueueName. 
        /// <para>
        /// The job queue name.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string JobQueueName
        {
            get { return this._jobQueueName; }
            set { this._jobQueueName = value; }
        }

        // Check to see if JobQueueName property is set
        internal bool IsSetJobQueueName()
        {
            return this._jobQueueName != null;
        }

        /// <summary>
        /// Gets and sets the property JobQueueType. 
        /// <para>
        /// The type of job queue. For service jobs that run on SageMaker Training, this value
        /// is <c>SAGEMAKER_TRAINING</c>. For regular container jobs, this value is <c>EKS</c>,
        /// <c>ECS</c>, or <c>ECS_FARGATE</c> depending on the compute environment.
        /// </para>
        /// </summary>
        public JobQueueType JobQueueType
        {
            get { return this._jobQueueType; }
            set { this._jobQueueType = value; }
        }

        // Check to see if JobQueueType property is set
        internal bool IsSetJobQueueType()
        {
            return this._jobQueueType != null;
        }

        /// <summary>
        /// Gets and sets the property JobStateTimeLimitActions. 
        /// <para>
        /// The set of actions that Batch perform on jobs that remain at the head of the job queue
        /// in the specified state longer than specified times. Batch will perform each action
        /// after <c>maxTimeSeconds</c> has passed.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<JobStateTimeLimitAction> JobStateTimeLimitActions
        {
            get { return this._jobStateTimeLimitActions; }
            set { this._jobStateTimeLimitActions = value; }
        }

        // Check to see if JobStateTimeLimitActions property is set
        internal bool IsSetJobStateTimeLimitActions()
        {
            return this._jobStateTimeLimitActions != null && (this._jobStateTimeLimitActions.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

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
        [AWSProperty(Required=true)]
        public int? Priority
        {
            get { return this._priority; }
            set { this._priority = value; }
        }

        // Check to see if Priority property is set
        internal bool IsSetPriority()
        {
            return this._priority.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property SchedulingPolicyArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the scheduling policy. The format is <c>aws:<i>Partition</i>:batch:<i>Region</i>:<i>Account</i>:scheduling-policy/<i>Name</i>
        /// </c>. For example, <c>aws:aws:batch:us-west-2:123456789012:scheduling-policy/MySchedulingPolicy</c>.
        /// </para>
        /// </summary>
        public string SchedulingPolicyArn
        {
            get { return this._schedulingPolicyArn; }
            set { this._schedulingPolicyArn = value; }
        }

        // Check to see if SchedulingPolicyArn property is set
        internal bool IsSetSchedulingPolicyArn()
        {
            return this._schedulingPolicyArn != null;
        }

        /// <summary>
        /// Gets and sets the property ServiceEnvironmentOrder. 
        /// <para>
        /// The order of the service environment associated with the job queue. Job queues with
        /// a higher priority are evaluated first when associated with the same service environment.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<ServiceEnvironmentOrder> ServiceEnvironmentOrder
        {
            get { return this._serviceEnvironmentOrder; }
            set { this._serviceEnvironmentOrder = value; }
        }

        // Check to see if ServiceEnvironmentOrder property is set
        internal bool IsSetServiceEnvironmentOrder()
        {
            return this._serviceEnvironmentOrder != null && (this._serviceEnvironmentOrder.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property State. 
        /// <para>
        /// Describes the ability of the queue to accept new jobs. If the job queue state is <c>ENABLED</c>,
        /// it can accept jobs. If the job queue state is <c>DISABLED</c>, new jobs can't be added
        /// to the queue, but jobs already in the queue can finish.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public JQState State
        {
            get { return this._state; }
            set { this._state = value; }
        }

        // Check to see if State property is set
        internal bool IsSetState()
        {
            return this._state != null;
        }

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The status of the job queue (for example, <c>CREATING</c> or <c>VALID</c>).
        /// </para>
        /// </summary>
        public JQStatus Status
        {
            get { return this._status; }
            set { this._status = value; }
        }

        // Check to see if Status property is set
        internal bool IsSetStatus()
        {
            return this._status != null;
        }

        /// <summary>
        /// Gets and sets the property StatusReason. 
        /// <para>
        /// A short, human-readable string to provide additional details for the current status
        /// of the job queue.
        /// </para>
        /// </summary>
        public string StatusReason
        {
            get { return this._statusReason; }
            set { this._statusReason = value; }
        }

        // Check to see if StatusReason property is set
        internal bool IsSetStatusReason()
        {
            return this._statusReason != null;
        }

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// The tags that are applied to the job queue. For more information, see <a href="https://docs.aws.amazon.com/batch/latest/userguide/using-tags.html">Tagging
        /// your Batch resources</a> in <i>Batch User Guide</i>.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=1, Max=50)]
        public Dictionary<string, string> Tags
        {
            get { return this._tags; }
            set { this._tags = value; }
        }

        // Check to see if Tags property is set
        internal bool IsSetTags()
        {
            return this._tags != null && (this._tags.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}