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

namespace Amazon.Billing.Model
{
    /// <summary>
    /// A tier within an Enterprise Support pricing plan.
    /// </summary>
    public partial class PricingPlanTier
    {
        /// <summary>
        /// Gets and sets the property AdditionalPercentageOfAggregateCharges. 
        /// <para>
        /// The additional percentage applied to aggregate charges in this tier.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string AdditionalPercentageOfAggregateCharges { get; set; }

        /// <summary>
        /// Checks to see if the AdditionalPercentageOfAggregateCharges property is set.
        /// </summary>
        internal bool IsSetAdditionalPercentageOfAggregateCharges() => this.AdditionalPercentageOfAggregateCharges != null;

        /// <summary>
        /// Gets and sets the property AggregateChargesAdjustment. 
        /// <para>
        /// The adjustment applied to aggregate charges.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string AggregateChargesAdjustment { get; set; }

        /// <summary>
        /// Checks to see if the AggregateChargesAdjustment property is set.
        /// </summary>
        internal bool IsSetAggregateChargesAdjustment() => this.AggregateChargesAdjustment != null;

        /// <summary>
        /// Gets and sets the property BaseCharge. 
        /// <para>
        /// The base charge for this tier.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string BaseCharge { get; set; }

        /// <summary>
        /// Checks to see if the BaseCharge property is set.
        /// </summary>
        internal bool IsSetBaseCharge() => this.BaseCharge != null;

        /// <summary>
        /// Gets and sets the property Increment. 
        /// <para>
        /// The increment amount for incremental tier calculations.
        /// </para>
        /// </summary>
        public string Increment { get; set; }

        /// <summary>
        /// Checks to see if the Increment property is set.
        /// </summary>
        internal bool IsSetIncrement() => this.Increment != null;

        /// <summary>
        /// Gets and sets the property IncrementCharge. 
        /// <para>
        /// The charge per increment.
        /// </para>
        /// </summary>
        public string IncrementCharge { get; set; }

        /// <summary>
        /// Checks to see if the IncrementCharge property is set.
        /// </summary>
        internal bool IsSetIncrementCharge() => this.IncrementCharge != null;

        /// <summary>
        /// Gets and sets the property Incremental. 
        /// <para>
        /// Whether the tier charges are calculated incrementally.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public bool? Incremental { get; set; }

        /// <summary>
        /// Checks to see if the Incremental property is set.
        /// </summary>
        internal bool IsSetIncremental() => this.Incremental.HasValue;

        /// <summary>
        /// Gets and sets the property TierMaximum. 
        /// <para>
        /// The maximum spend threshold for this tier.
        /// </para>
        /// </summary>
        public string TierMaximum { get; set; }

        /// <summary>
        /// Checks to see if the TierMaximum property is set.
        /// </summary>
        internal bool IsSetTierMaximum() => this.TierMaximum != null;

        /// <summary>
        /// Gets and sets the property TierMinimum. 
        /// <para>
        /// The minimum spend threshold for this tier.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string TierMinimum { get; set; }

        /// <summary>
        /// Checks to see if the TierMinimum property is set.
        /// </summary>
        internal bool IsSetTierMinimum() => this.TierMinimum != null;
    }
}
