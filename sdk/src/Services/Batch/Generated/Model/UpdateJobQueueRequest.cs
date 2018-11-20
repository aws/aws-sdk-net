/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.Batch.Model
{
    /// <summary>
    /// Container for the parameters to the UpdateJobQueue operation.
    /// Updates a job queue.
    /// </summary>
    public partial class UpdateJobQueueRequest : AmazonBatchRequest
    {
        private List<ComputeEnvironmentOrder> _computeEnvironmentOrder = new List<ComputeEnvironmentOrder>();
        private string _jobQueue;
        private int? _priority;
        private JQState _state;

        /// <summary>
        /// Gets and sets the property ComputeEnvironmentOrder. 
        /// <para>
        /// Details the set of compute environments mapped to a job queue and their order relative
        /// to each other. This is one of the parameters used by the job scheduler to determine
        /// which compute environment should execute a given job. 
        /// </para>
        /// </summary>
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
        /// Gets and sets the property JobQueue. 
        /// <para>
        /// The name or the Amazon Resource Name (ARN) of the job queue.
        /// </para>
        /// </summary>
        public string JobQueue
        {
            get { return this._jobQueue; }
            set { this._jobQueue = value; }
        }

        // Check to see if JobQueue property is set
        internal bool IsSetJobQueue()
        {
            return this._jobQueue != null;
        }

        /// <summary>
        /// Gets and sets the property Priority. 
        /// <para>
        /// The priority of the job queue. Job queues with a higher priority (or a higher integer
        /// value for the <code>priority</code> parameter) are evaluated first when associated
        /// with the same compute environment. Priority is determined in descending order, for
        /// example, a job queue with a priority value of <code>10</code> is given scheduling
        /// preference over a job queue with a priority value of <code>1</code>.
        /// </para>
        /// </summary>
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
        /// Describes the queue's ability to accept new jobs.
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

    }
}