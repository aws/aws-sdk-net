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

namespace Amazon.MediaConvert.Model
{
    /// <summary>
    /// Container for the parameters to the UpdateQueue operation. Modify one of your existing
    /// queues.
    /// </summary>
    public partial class UpdateQueueRequest : AmazonMediaConvertRequest
    {
        /// <summary>
        /// Gets and sets the property ConcurrentJobs. Specify the maximum number of jobs your
        /// queue can process concurrently. For on-demand queues, the value you enter is constrained
        /// by your service quotas for Maximum concurrent jobs, per on-demand queue and Maximum
        /// concurrent jobs, per account. For reserved queues, update your reservation plan instead
        /// in order to increase your yearly commitment.
        /// </summary>
        public int? ConcurrentJobs { get; set; }

        /// <summary>
        /// Checks to see if the ConcurrentJobs property is set.
        /// </summary>
        internal bool IsSetConcurrentJobs() => this.ConcurrentJobs.HasValue;

        /// <summary>
        /// Gets and sets the property Description. The new description for the queue, if you
        /// are changing it.
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// Checks to see if the Description property is set.
        /// </summary>
        internal bool IsSetDescription() => this.Description != null;

        /// <summary>
        /// Gets and sets the property MaximumConcurrentFeeds. Specify the maximum number of Elemental
        /// Inference feeds MediaConvert can process concurrently.
        /// </summary>
        [AWSProperty(Min = 0)]
        public int? MaximumConcurrentFeeds { get; set; }

        /// <summary>
        /// Checks to see if the MaximumConcurrentFeeds property is set.
        /// </summary>
        internal bool IsSetMaximumConcurrentFeeds() => this.MaximumConcurrentFeeds.HasValue;

        /// <summary>
        /// Gets and sets the property Name. The name of the queue that you are modifying.
        /// </summary>
        [AWSProperty(Required = true)]
        public string Name { get; set; }

        /// <summary>
        /// Checks to see if the Name property is set.
        /// </summary>
        internal bool IsSetName() => this.Name != null;

        /// <summary>
        /// Gets and sets the property ReservationPlanSettings. The new details of your pricing
        /// plan for your reserved queue. When you set up a new pricing plan to replace an expired
        /// one, you enter into another 12-month commitment. When you add capacity to your queue
        /// by increasing the number of RTS, you extend the term of your commitment to 12 months
        /// from when you add capacity. After you make these commitments, you can't cancel them.
        /// </summary>
        public ReservationPlanSettings ReservationPlanSettings { get; set; }

        /// <summary>
        /// Checks to see if the ReservationPlanSettings property is set.
        /// </summary>
        internal bool IsSetReservationPlanSettings() => this.ReservationPlanSettings != null;

        /// <summary>
        /// Gets and sets the property Status. Pause or activate a queue by changing its status
        /// between ACTIVE and PAUSED. If you pause a queue, jobs in that queue won't begin. Jobs
        /// that are running when you pause the queue continue to run until they finish or result
        /// in an error.
        /// </summary>
        public QueueStatus Status { get; set; }

        /// <summary>
        /// Checks to see if the Status property is set.
        /// </summary>
        internal bool IsSetStatus() => this.Status != null;
    }
}
