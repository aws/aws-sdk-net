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
 * Do not modify this file. This file is generated from the deadline-2023-10-12.normal.json service model.
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
namespace Amazon.Deadline.Model
{
    /// <summary>
    /// The scheduling configuration for a queue. Defines the strategy used to assign workers
    /// to jobs.
    /// </summary>
    public partial class SchedulingConfiguration
    {
        private PriorityBalancedSchedulingConfiguration _priorityBalanced;
        private PriorityFifoSchedulingConfiguration _priorityFifo;
        private WeightedBalancedSchedulingConfiguration _weightedBalanced;

        /// <summary>
        /// Gets and sets the property PriorityBalanced. 
        /// <para>
        /// Workers are distributed evenly across all jobs at the highest priority level. When
        /// workers cannot be evenly divided, the extra workers are assigned to the jobs submitted
        /// earliest. If a job has fewer remaining tasks than its share of workers, the surplus
        /// workers are redistributed to other jobs at the same priority level.
        /// </para>
        /// </summary>
        public PriorityBalancedSchedulingConfiguration PriorityBalanced
        {
            get { return this._priorityBalanced; }
            set { this._priorityBalanced = value; }
        }

        // Check to see if PriorityBalanced property is set
        internal bool IsSetPriorityBalanced()
        {
            return this._priorityBalanced != null;
        }

        /// <summary>
        /// Gets and sets the property PriorityFifo. 
        /// <para>
        /// Workers are assigned to the highest-priority job first. When multiple jobs share the
        /// same priority, the job submitted earliest receives workers first. This is the default
        /// scheduling configuration for new queues.
        /// </para>
        /// </summary>
        public PriorityFifoSchedulingConfiguration PriorityFifo
        {
            get { return this._priorityFifo; }
            set { this._priorityFifo = value; }
        }

        // Check to see if PriorityFifo property is set
        internal bool IsSetPriorityFifo()
        {
            return this._priorityFifo != null;
        }

        /// <summary>
        /// Gets and sets the property WeightedBalanced. 
        /// <para>
        /// Workers are assigned to jobs based on a weighted formula that considers job priority,
        /// error count, submission time, and the number of tasks currently rendering. Each factor
        /// has a configurable weight that determines its influence on scheduling decisions.
        /// </para>
        /// </summary>
        public WeightedBalancedSchedulingConfiguration WeightedBalanced
        {
            get { return this._weightedBalanced; }
            set { this._weightedBalanced = value; }
        }

        // Check to see if WeightedBalanced property is set
        internal bool IsSetWeightedBalanced()
        {
            return this._weightedBalanced != null;
        }

    }
}