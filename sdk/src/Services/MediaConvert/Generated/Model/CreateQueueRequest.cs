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
 * Do not modify this file. This file is generated from the mediaconvert-2017-08-29.normal.json service model.
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
    /// Container for the parameters to the CreateQueue operation.
    /// Create a new transcoding queue. For information about queues, see Working With Queues
    /// in the User Guide at https://docs.aws.amazon.com/mediaconvert/latest/ug/working-with-queues.html
    /// </summary>
    public partial class CreateQueueRequest : AmazonMediaConvertRequest
    {
        private int? _concurrentJobs;
        private string _description;
        private string _name;
        private PricingPlan _pricingPlan;
        private ReservationPlanSettings _reservationPlanSettings;
        private QueueStatus _status;
        private Dictionary<string, string> _tags = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;

        /// <summary>
        /// Gets and sets the property ConcurrentJobs. Specify the maximum number of jobs your
        /// queue can process concurrently. For on-demand queues, the value you enter is constrained
        /// by your service quotas for Maximum concurrent jobs, per on-demand queue and Maximum
        /// concurrent jobs, per account. For reserved queues, specify the number of jobs you
        /// can process concurrently in your reservation plan instead.
        /// </summary>
        public int? ConcurrentJobs
        {
            get { return this._concurrentJobs; }
            set { this._concurrentJobs = value; }
        }

        // Check to see if ConcurrentJobs property is set
        internal bool IsSetConcurrentJobs()
        {
            return this._concurrentJobs.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Description. Optional. A description of the queue that
        /// you are creating.
        /// </summary>
        public string Description
        {
            get { return this._description; }
            set { this._description = value; }
        }

        // Check to see if Description property is set
        internal bool IsSetDescription()
        {
            return this._description != null;
        }

        /// <summary>
        /// Gets and sets the property Name. The name of the queue that you are creating.
        /// </summary>
        [AWSProperty(Required=true)]
        public string Name
        {
            get { return this._name; }
            set { this._name = value; }
        }

        // Check to see if Name property is set
        internal bool IsSetName()
        {
            return this._name != null;
        }

        /// <summary>
        /// Gets and sets the property PricingPlan. Specifies whether the pricing plan for the
        /// queue is on-demand or reserved. For on-demand, you pay per minute, billed in increments
        /// of .01 minute. For reserved, you pay for the transcoding capacity of the entire queue,
        /// regardless of how much or how little you use it. Reserved pricing requires a 12-month
        /// commitment. When you use the API to create a queue, the default is on-demand.
        /// </summary>
        public PricingPlan PricingPlan
        {
            get { return this._pricingPlan; }
            set { this._pricingPlan = value; }
        }

        // Check to see if PricingPlan property is set
        internal bool IsSetPricingPlan()
        {
            return this._pricingPlan != null;
        }

        /// <summary>
        /// Gets and sets the property ReservationPlanSettings. Details about the pricing plan
        /// for your reserved queue. Required for reserved queues and not applicable to on-demand
        /// queues.
        /// </summary>
        public ReservationPlanSettings ReservationPlanSettings
        {
            get { return this._reservationPlanSettings; }
            set { this._reservationPlanSettings = value; }
        }

        // Check to see if ReservationPlanSettings property is set
        internal bool IsSetReservationPlanSettings()
        {
            return this._reservationPlanSettings != null;
        }

        /// <summary>
        /// Gets and sets the property Status. Initial state of the queue. If you create a paused
        /// queue, then jobs in that queue won't begin.
        /// </summary>
        public QueueStatus Status
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
        /// Gets and sets the property Tags. The tags that you want to add to the resource. You
        /// can tag resources with a key-value pair or with only a key.
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
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