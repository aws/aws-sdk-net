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

namespace Amazon.Deadline.Model
{
    /// <summary>
    /// The scheduling configuration for a queue. Defines the strategy used to assign workers
    /// to jobs.
    /// </summary>
    public partial class SchedulingConfiguration
    {
        /// <summary>
        /// Gets and sets the property PriorityBalanced. Workers are distributed evenly across
        /// all jobs at the highest priority level. When workers cannot be evenly divided, the
        /// extra workers are assigned to the jobs submitted earliest. If a job has fewer remaining
        /// tasks than its share of workers, the surplus workers are redistributed to other jobs
        /// at the same priority level.
        /// </summary>
        public PriorityBalancedSchedulingConfiguration PriorityBalanced { get; set; }

        /// <summary>
        /// Checks to see if the PriorityBalanced property is set.
        /// </summary>
        internal bool IsSetPriorityBalanced() => this.PriorityBalanced != null;

        /// <summary>
        /// Gets and sets the property PriorityFifo. Workers are assigned to the highest-priority
        /// job first. When multiple jobs share the same priority, the job submitted earliest
        /// receives workers first. This is the default scheduling configuration for new queues.
        /// </summary>
        public PriorityFifoSchedulingConfiguration PriorityFifo { get; set; }

        /// <summary>
        /// Checks to see if the PriorityFifo property is set.
        /// </summary>
        internal bool IsSetPriorityFifo() => this.PriorityFifo != null;

        /// <summary>
        /// Gets and sets the property WeightedBalanced. Workers are assigned to jobs based on
        /// a weighted formula that considers job priority, error count, submission time, and
        /// the number of tasks currently rendering. Each factor has a configurable weight that
        /// determines its influence on scheduling decisions.
        /// </summary>
        public WeightedBalancedSchedulingConfiguration WeightedBalanced { get; set; }

        /// <summary>
        /// Checks to see if the WeightedBalanced property is set.
        /// </summary>
        internal bool IsSetWeightedBalanced() => this.WeightedBalanced != null;
    }
}
