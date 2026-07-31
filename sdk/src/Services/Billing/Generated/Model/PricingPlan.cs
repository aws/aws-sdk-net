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
    /// A pricing plan for Enterprise Support billing.
    /// </summary>
    public partial class PricingPlan
    {
        private string _description;
        private bool? _discountAppliesToMinimumCharge;
        private DateTime? _endDate;
        private string _minimumCharge;
        private string _name;
        private string _planDiscountPercent;
        private string _pricingPlanId;
        private DateTime? _startDate;
        private string _tiered;
        private List<PricingPlanTier> _tiers = AWSConfigs.InitializeCollections ? new List<PricingPlanTier>() : null;

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// A description of the pricing plan.
        /// </para>
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
        /// Gets and sets the property DiscountAppliesToMinimumCharge. 
        /// <para>
        /// Whether the discount applies to the minimum Support charge.
        /// </para>
        /// </summary>
        public bool? DiscountAppliesToMinimumCharge
        {
            get { return this._discountAppliesToMinimumCharge; }
            set { this._discountAppliesToMinimumCharge = value; }
        }

        // Check to see if DiscountAppliesToMinimumCharge property is set
        internal bool IsSetDiscountAppliesToMinimumCharge()
        {
            return this._discountAppliesToMinimumCharge.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property EndDate. 
        /// <para>
        /// The end date of the pricing plan.
        /// </para>
        /// </summary>
        public DateTime? EndDate
        {
            get { return this._endDate; }
            set { this._endDate = value; }
        }

        // Check to see if EndDate property is set
        internal bool IsSetEndDate()
        {
            return this._endDate.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property MinimumCharge. 
        /// <para>
        /// The minimum Support charge amount for this pricing plan.
        /// </para>
        /// </summary>
        public string MinimumCharge
        {
            get { return this._minimumCharge; }
            set { this._minimumCharge = value; }
        }

        // Check to see if MinimumCharge property is set
        internal bool IsSetMinimumCharge()
        {
            return this._minimumCharge != null;
        }

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the pricing plan.
        /// </para>
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
        /// Gets and sets the property PlanDiscountPercent. 
        /// <para>
        /// The discount percentage applied by this pricing plan.
        /// </para>
        /// </summary>
        public string PlanDiscountPercent
        {
            get { return this._planDiscountPercent; }
            set { this._planDiscountPercent = value; }
        }

        // Check to see if PlanDiscountPercent property is set
        internal bool IsSetPlanDiscountPercent()
        {
            return this._planDiscountPercent != null;
        }

        /// <summary>
        /// Gets and sets the property PricingPlanId. 
        /// <para>
        /// The unique identifier for the pricing plan.
        /// </para>
        /// </summary>
        public string PricingPlanId
        {
            get { return this._pricingPlanId; }
            set { this._pricingPlanId = value; }
        }

        // Check to see if PricingPlanId property is set
        internal bool IsSetPricingPlanId()
        {
            return this._pricingPlanId != null;
        }

        /// <summary>
        /// Gets and sets the property StartDate. 
        /// <para>
        /// The start date of the pricing plan.
        /// </para>
        /// </summary>
        public DateTime? StartDate
        {
            get { return this._startDate; }
            set { this._startDate = value; }
        }

        // Check to see if StartDate property is set
        internal bool IsSetStartDate()
        {
            return this._startDate.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Tiered. 
        /// <para>
        /// Whether the pricing plan uses tiered pricing.
        /// </para>
        /// </summary>
        public string Tiered
        {
            get { return this._tiered; }
            set { this._tiered = value; }
        }

        // Check to see if Tiered property is set
        internal bool IsSetTiered()
        {
            return this._tiered != null;
        }

        /// <summary>
        /// Gets and sets the property Tiers. 
        /// <para>
        /// The pricing tiers within this plan.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required=true, Min=0, Max=20)]
        public List<PricingPlanTier> Tiers
        {
            get { return this._tiers; }
            set { this._tiers = value; }
        }

        // Check to see if Tiers property is set
        internal bool IsSetTiers()
        {
            return this._tiers != null && (this._tiers.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}