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
 * Do not modify this file. This file is generated from the billing-2023-09-07.normal.json service model.
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
        private string _additionalPercentageOfAggregateCharges;
        private string _aggregateChargesAdjustment;
        private string _baseCharge;
        private string _increment;
        private bool? _incremental;
        private string _incrementCharge;
        private string _tierMaximum;
        private string _tierMinimum;

        /// <summary>
        /// Gets and sets the property AdditionalPercentageOfAggregateCharges. 
        /// <para>
        /// The additional percentage applied to aggregate charges in this tier.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string AdditionalPercentageOfAggregateCharges
        {
            get { return this._additionalPercentageOfAggregateCharges; }
            set { this._additionalPercentageOfAggregateCharges = value; }
        }

        // Check to see if AdditionalPercentageOfAggregateCharges property is set
        internal bool IsSetAdditionalPercentageOfAggregateCharges()
        {
            return this._additionalPercentageOfAggregateCharges != null;
        }

        /// <summary>
        /// Gets and sets the property AggregateChargesAdjustment. 
        /// <para>
        /// The adjustment applied to aggregate charges.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string AggregateChargesAdjustment
        {
            get { return this._aggregateChargesAdjustment; }
            set { this._aggregateChargesAdjustment = value; }
        }

        // Check to see if AggregateChargesAdjustment property is set
        internal bool IsSetAggregateChargesAdjustment()
        {
            return this._aggregateChargesAdjustment != null;
        }

        /// <summary>
        /// Gets and sets the property BaseCharge. 
        /// <para>
        /// The base charge for this tier.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string BaseCharge
        {
            get { return this._baseCharge; }
            set { this._baseCharge = value; }
        }

        // Check to see if BaseCharge property is set
        internal bool IsSetBaseCharge()
        {
            return this._baseCharge != null;
        }

        /// <summary>
        /// Gets and sets the property Increment. 
        /// <para>
        /// The increment amount for incremental tier calculations.
        /// </para>
        /// </summary>
        public string Increment
        {
            get { return this._increment; }
            set { this._increment = value; }
        }

        // Check to see if Increment property is set
        internal bool IsSetIncrement()
        {
            return this._increment != null;
        }

        /// <summary>
        /// Gets and sets the property Incremental. 
        /// <para>
        /// Whether the tier charges are calculated incrementally.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public bool? Incremental
        {
            get { return this._incremental; }
            set { this._incremental = value; }
        }

        // Check to see if Incremental property is set
        internal bool IsSetIncremental()
        {
            return this._incremental.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property IncrementCharge. 
        /// <para>
        /// The charge per increment.
        /// </para>
        /// </summary>
        public string IncrementCharge
        {
            get { return this._incrementCharge; }
            set { this._incrementCharge = value; }
        }

        // Check to see if IncrementCharge property is set
        internal bool IsSetIncrementCharge()
        {
            return this._incrementCharge != null;
        }

        /// <summary>
        /// Gets and sets the property TierMaximum. 
        /// <para>
        /// The maximum spend threshold for this tier.
        /// </para>
        /// </summary>
        public string TierMaximum
        {
            get { return this._tierMaximum; }
            set { this._tierMaximum = value; }
        }

        // Check to see if TierMaximum property is set
        internal bool IsSetTierMaximum()
        {
            return this._tierMaximum != null;
        }

        /// <summary>
        /// Gets and sets the property TierMinimum. 
        /// <para>
        /// The minimum spend threshold for this tier.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string TierMinimum
        {
            get { return this._tierMinimum; }
            set { this._tierMinimum = value; }
        }

        // Check to see if TierMinimum property is set
        internal bool IsSetTierMinimum()
        {
            return this._tierMinimum != null;
        }

    }
}