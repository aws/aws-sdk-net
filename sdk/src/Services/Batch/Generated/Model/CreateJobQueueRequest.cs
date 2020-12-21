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

namespace Amazon.Batch.Model
{
    /// <summary>
    /// Container for the parameters to the CreateJobQueue operation.
    /// Creates an AWS Batch job queue. When you create a job queue, you associate one or
    /// more compute environments to the queue and assign an order of preference for the compute
    /// environments.
    /// 
    ///  
    /// <para>
    /// You also set a priority to the job queue that determines the order in which the AWS
    /// Batch scheduler places jobs onto its associated compute environments. For example,
    /// if a compute environment is associated with more than one job queue, the job queue
    /// with a higher priority is given preference for scheduling jobs to that compute environment.
    /// </para>
    /// </summary>
    public partial class CreateJobQueueRequest : AmazonBatchRequest
    {
        private List<ComputeEnvironmentOrder> _computeEnvironmentOrder = new List<ComputeEnvironmentOrder>();
        private string _jobQueueName;
        private int? _priority;
        private JQState _state;
        private Dictionary<string, string> _tags = new Dictionary<string, string>();

        /// <summary>
        /// Gets and sets the property ComputeEnvironmentOrder. 
        /// <para>
        /// The set of compute environments mapped to a job queue and their order relative to
        /// each other. The job scheduler uses this parameter to determine which compute environment
        /// should run a specific job. Compute environments must be in the <code>VALID</code>
        /// state before you can associate them with a job queue. You can associate up to three
        /// compute environments with a job queue. All of the compute environments must be either
        /// EC2 (<code>EC2</code> or <code>SPOT</code>) or Fargate (<code>FARGATE</code> or <code>FARGATE_SPOT</code>);
        /// EC2 and Fargate compute environments can't be mixed.
        /// </para>
        ///  <note> 
        /// <para>
        /// All compute environments that are associated with a job queue must share the same
        /// architecture. AWS Batch doesn't support mixing compute environment architecture types
        /// in a single job queue.
        /// </para>
        ///  </note>
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
            return this._computeEnvironmentOrder != null && this._computeEnvironmentOrder.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property JobQueueName. 
        /// <para>
        /// The name of the job queue. Up to 128 letters (uppercase and lowercase), numbers, and
        /// underscores are allowed.
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
        /// Gets and sets the property Priority. 
        /// <para>
        /// The priority of the job queue. Job queues with a higher priority (or a higher integer
        /// value for the <code>priority</code> parameter) are evaluated first when associated
        /// with the same compute environment. Priority is determined in descending order. For
        /// example, a job queue with a priority value of <code>10</code> is given scheduling
        /// preference over a job queue with a priority value of <code>1</code>. All of the compute
        /// environments must be either EC2 (<code>EC2</code> or <code>SPOT</code>) or Fargate
        /// (<code>FARGATE</code> or <code>FARGATE_SPOT</code>); EC2 and Fargate compute environments
        /// cannot be mixed.
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
        /// Gets and sets the property State. 
        /// <para>
        /// The state of the job queue. If the job queue state is <code>ENABLED</code>, it is
        /// able to accept jobs. If the job queue state is <code>DISABLED</code>, new jobs can't
        /// be added to the queue, but jobs already in the queue can finish.
        /// </para>
        /// </summary>
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
        /// Gets and sets the property Tags. 
        /// <para>
        /// The tags that you apply to the job queue to help you categorize and organize your
        /// resources. Each tag consists of a key and an optional value. For more information,
        /// see <a href="https://docs.aws.amazon.com/batch/latest/userguide/using-tags.html">Tagging
        /// your AWS Batch resources</a> in <i>AWS Batch User Guide</i>.
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
            return this._tags != null && this._tags.Count > 0; 
        }

    }
}