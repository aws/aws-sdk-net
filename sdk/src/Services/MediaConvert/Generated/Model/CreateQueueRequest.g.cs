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
    /// Container for the parameters to the CreateQueue operation. Create a new transcoding
    /// queue. For information about queues, see Working With Queues in the User Guide at
    /// https://docs.aws.amazon.com/mediaconvert/latest/ug/working-with-queues.html
    /// </summary>
    public partial class CreateQueueRequest : AmazonMediaConvertRequest
    {
        /// <summary>
        /// Gets and sets the property ConcurrentJobs. Specify the maximum number of jobs your
        /// queue can process concurrently. For on-demand queues, the value you enter is constrained
        /// by your service quotas for Maximum concurrent jobs, per on-demand queue and Maximum
        /// concurrent jobs, per account. For reserved queues, specify the number of jobs you
        /// can process concurrently in your reservation plan instead.
        /// </summary>
        public int? ConcurrentJobs { get; set; }

        /// <summary>
        /// Checks to see if the ConcurrentJobs property is set.
        /// </summary>
        internal bool IsSetConcurrentJobs() => this.ConcurrentJobs.HasValue;

        /// <summary>
        /// Gets and sets the property Description. Optional. A description of the queue that
        /// you are creating.
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
        /// Gets and sets the property Name. The name of the queue that you are creating.
        /// </summary>
        [AWSProperty(Required = true)]
        public string Name { get; set; }

        /// <summary>
        /// Checks to see if the Name property is set.
        /// </summary>
        internal bool IsSetName() => this.Name != null;

        /// <summary>
        /// Gets and sets the property PricingPlan. Specifies whether the pricing plan for the
        /// queue is on-demand or reserved. For on-demand, you pay per minute, billed in increments
        /// of .01 minute. For reserved, you pay for the transcoding capacity of the entire queue,
        /// regardless of how much or how little you use it. Reserved pricing requires a 12-month
        /// commitment. When you use the API to create a queue, the default is on-demand.
        /// </summary>
        public PricingPlan PricingPlan { get; set; }

        /// <summary>
        /// Checks to see if the PricingPlan property is set.
        /// </summary>
        internal bool IsSetPricingPlan() => this.PricingPlan != null;

        /// <summary>
        /// Gets and sets the property ReservationPlanSettings. Details about the pricing plan
        /// for your reserved queue. Required for reserved queues and not applicable to on-demand
        /// queues.
        /// </summary>
        public ReservationPlanSettings ReservationPlanSettings { get; set; }

        /// <summary>
        /// Checks to see if the ReservationPlanSettings property is set.
        /// </summary>
        internal bool IsSetReservationPlanSettings() => this.ReservationPlanSettings != null;

        /// <summary>
        /// Gets and sets the property Status. Initial state of the queue. If you create a paused
        /// queue, then jobs in that queue won't begin.
        /// </summary>
        public QueueStatus Status { get; set; }

        /// <summary>
        /// Checks to see if the Status property is set.
        /// </summary>
        internal bool IsSetStatus() => this.Status != null;

        /// <summary>
        /// Gets and sets the property Tags. The tags that you want to add to the resource. You
        /// can tag resources with a key-value pair or with only a key.
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public Dictionary<string, string> Tags { get; set; } = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;

        /// <summary>
        /// Checks to see if the Tags property is set.
        /// </summary>
        internal bool IsSetTags() => this.Tags != null && (this.Tags.Count > 0 || !AWSConfigs.InitializeCollections);
    }
}
