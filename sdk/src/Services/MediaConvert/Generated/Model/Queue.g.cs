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
    /// You can use queues to manage the resources that are available to your AWS account
    /// for running multiple transcoding jobs at the same time. If you don't specify a queue,
    /// the service sends all jobs through the default queue. For more information, see https://docs.aws.amazon.com/mediaconvert/latest/ug/working-with-queues.html.
    /// </summary>
    public partial class Queue
    {
        /// <summary>
        /// Gets and sets the property Arn. An identifier for this resource that is unique within
        /// all of AWS.
        /// </summary>
        public string Arn { get; set; }

        /// <summary>
        /// Checks to see if the Arn property is set.
        /// </summary>
        internal bool IsSetArn() => this.Arn != null;

        /// <summary>
        /// Gets and sets the property ConcurrentJobs. The maximum number of jobs your queue can
        /// process concurrently.
        /// </summary>
        public int? ConcurrentJobs { get; set; }

        /// <summary>
        /// Checks to see if the ConcurrentJobs property is set.
        /// </summary>
        internal bool IsSetConcurrentJobs() => this.ConcurrentJobs.HasValue;

        /// <summary>
        /// Gets and sets the property CreatedAt. The timestamp in epoch seconds for when you
        /// created the queue.
        /// </summary>
        public DateTime? CreatedAt { get; set; }

        /// <summary>
        /// Checks to see if the CreatedAt property is set.
        /// </summary>
        internal bool IsSetCreatedAt() => this.CreatedAt.HasValue;

        /// <summary>
        /// Gets and sets the property Description. An optional description that you create for
        /// each queue.
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// Checks to see if the Description property is set.
        /// </summary>
        internal bool IsSetDescription() => this.Description != null;

        /// <summary>
        /// Gets and sets the property LastUpdated. The timestamp in epoch seconds for when you
        /// most recently updated the queue.
        /// </summary>
        public DateTime? LastUpdated { get; set; }

        /// <summary>
        /// Checks to see if the LastUpdated property is set.
        /// </summary>
        internal bool IsSetLastUpdated() => this.LastUpdated.HasValue;

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
        /// Gets and sets the property Name. A name that you create for each queue. Each name
        /// must be unique within your account.
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
        /// commitment.
        /// </summary>
        public PricingPlan PricingPlan { get; set; }

        /// <summary>
        /// Checks to see if the PricingPlan property is set.
        /// </summary>
        internal bool IsSetPricingPlan() => this.PricingPlan != null;

        /// <summary>
        /// Gets and sets the property ProgressingJobsCount. The estimated number of jobs with
        /// a PROGRESSING status.
        /// </summary>
        public int? ProgressingJobsCount { get; set; }

        /// <summary>
        /// Checks to see if the ProgressingJobsCount property is set.
        /// </summary>
        internal bool IsSetProgressingJobsCount() => this.ProgressingJobsCount.HasValue;

        /// <summary>
        /// Gets and sets the property ReservationPlan. Details about the pricing plan for your
        /// reserved queue. Required for reserved queues and not applicable to on-demand queues.
        /// </summary>
        public ReservationPlan ReservationPlan { get; set; }

        /// <summary>
        /// Checks to see if the ReservationPlan property is set.
        /// </summary>
        internal bool IsSetReservationPlan() => this.ReservationPlan != null;

        /// <summary>
        /// Gets and sets the property ServiceOverrides. A list of any service overrides applied
        /// by MediaConvert to the settings that you have configured. If you see any overrides,
        /// we recommend that you contact AWS Support.
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<ServiceOverride> ServiceOverrides { get; set; } = AWSConfigs.InitializeCollections ? new List<ServiceOverride>() : null;

        /// <summary>
        /// Checks to see if the ServiceOverrides property is set.
        /// </summary>
        internal bool IsSetServiceOverrides() => this.ServiceOverrides != null && (this.ServiceOverrides.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property Status. Queues can be ACTIVE or PAUSED. If you pause a
        /// queue, the service won't begin processing jobs in that queue. Jobs that are running
        /// when you pause the queue continue to run until they finish or result in an error.
        /// </summary>
        public QueueStatus Status { get; set; }

        /// <summary>
        /// Checks to see if the Status property is set.
        /// </summary>
        internal bool IsSetStatus() => this.Status != null;

        /// <summary>
        /// Gets and sets the property SubmittedJobsCount. The estimated number of jobs with a
        /// SUBMITTED status.
        /// </summary>
        public int? SubmittedJobsCount { get; set; }

        /// <summary>
        /// Checks to see if the SubmittedJobsCount property is set.
        /// </summary>
        internal bool IsSetSubmittedJobsCount() => this.SubmittedJobsCount.HasValue;

        /// <summary>
        /// Gets and sets the property Type. Specifies whether this on-demand queue is system
        /// or custom. System queues are built in. You can't modify or delete system queues. You
        /// can create and modify custom queues.
        /// </summary>
        public Type Type { get; set; }

        /// <summary>
        /// Checks to see if the Type property is set.
        /// </summary>
        internal bool IsSetType() => this.Type != null;
    }
}
