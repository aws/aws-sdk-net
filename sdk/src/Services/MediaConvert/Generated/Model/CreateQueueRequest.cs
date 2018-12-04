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
 * Do not modify this file. This file is generated from the mediaconvert-2017-08-29.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.MediaConvert.Model
{
    /// <summary>
    /// Container for the parameters to the CreateQueue operation.
    /// Create a new transcoding queue. For information about queues, see Working With Queues
    /// in the User Guide at https://docs.aws.amazon.com/mediaconvert/latest/ug/working-with-queues.html
    /// </summary>
    public partial class CreateQueueRequest : AmazonMediaConvertRequest
    {
        private string _description;
        private string _name;
        private PricingPlan _pricingPlan;
        private ReservationPlanSettings _reservationPlanSettings;
        private Dictionary<string, string> _tags = new Dictionary<string, string>();

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
        /// Gets and sets the property Tags. The tags that you want to add to the resource. You
        /// can tag resources with a key-value pair or with only a key.
        /// </summary>
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