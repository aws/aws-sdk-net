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
        private List<JobStateTimeLimitAction> _jobStateTimeLimitActions = AWSConfigs.InitializeCollections ? new List<JobStateTimeLimitAction>() : null;
        private int? _priority;
        private string _schedulingPolicyArn;
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
        /// Gets and sets the property JobStateTimeLimitActions. 
        /// <para>
        /// The set of actions that Batch perform on jobs that remain at the head of the job queue
        /// in the specified state longer than specified times. Batch will perform each action
        /// after <c>maxTimeSeconds</c> has passed.
        /// </para>
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
        /// The priority of the job queue. Job queues with a higher priority (or a higher integer
        /// value for the <c>priority</c> parameter) are evaluated first when associated with
        /// the same compute environment. Priority is determined in descending order. For example,
        /// a job queue with a priority value of <c>10</c> is given scheduling preference over
        /// a job queue with a priority value of <c>1</c>. All of the compute environments must
        /// be either Amazon EC2 (<c>EC2</c> or <c>SPOT</c>) or Fargate (<c>FARGATE</c> or <c>FARGATE_SPOT</c>).
        /// Amazon EC2 and Fargate compute environments can't be mixed.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public int Priority
        {
            get { return this._priority.GetValueOrDefault(); }
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