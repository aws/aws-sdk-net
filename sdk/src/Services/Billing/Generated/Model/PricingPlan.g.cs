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
    /// A pricing plan for Enterprise Support billing.
    /// </summary>
    public partial class PricingPlan
    {
        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// A description of the pricing plan.
        /// </para>
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// Checks to see if the Description property is set.
        /// </summary>
        internal bool IsSetDescription() => this.Description != null;

        /// <summary>
        /// Gets and sets the property DiscountAppliesToMinimumCharge. 
        /// <para>
        /// Whether the discount applies to the minimum Support charge.
        /// </para>
        /// </summary>
        public bool? DiscountAppliesToMinimumCharge { get; set; }

        /// <summary>
        /// Checks to see if the DiscountAppliesToMinimumCharge property is set.
        /// </summary>
        internal bool IsSetDiscountAppliesToMinimumCharge() => this.DiscountAppliesToMinimumCharge.HasValue;

        /// <summary>
        /// Gets and sets the property EndDate. 
        /// <para>
        /// The end date of the pricing plan.
        /// </para>
        /// </summary>
        public DateTime? EndDate { get; set; }

        /// <summary>
        /// Checks to see if the EndDate property is set.
        /// </summary>
        internal bool IsSetEndDate() => this.EndDate.HasValue;

        /// <summary>
        /// Gets and sets the property MinimumCharge. 
        /// <para>
        /// The minimum Support charge amount for this pricing plan.
        /// </para>
        /// </summary>
        public string MinimumCharge { get; set; }

        /// <summary>
        /// Checks to see if the MinimumCharge property is set.
        /// </summary>
        internal bool IsSetMinimumCharge() => this.MinimumCharge != null;

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the pricing plan.
        /// </para>
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Checks to see if the Name property is set.
        /// </summary>
        internal bool IsSetName() => this.Name != null;

        /// <summary>
        /// Gets and sets the property PlanDiscountPercent. 
        /// <para>
        /// The discount percentage applied by this pricing plan.
        /// </para>
        /// </summary>
        public string PlanDiscountPercent { get; set; }

        /// <summary>
        /// Checks to see if the PlanDiscountPercent property is set.
        /// </summary>
        internal bool IsSetPlanDiscountPercent() => this.PlanDiscountPercent != null;

        /// <summary>
        /// Gets and sets the property PricingPlanId. 
        /// <para>
        /// The unique identifier for the pricing plan.
        /// </para>
        /// </summary>
        public string PricingPlanId { get; set; }

        /// <summary>
        /// Checks to see if the PricingPlanId property is set.
        /// </summary>
        internal bool IsSetPricingPlanId() => this.PricingPlanId != null;

        /// <summary>
        /// Gets and sets the property StartDate. 
        /// <para>
        /// The start date of the pricing plan.
        /// </para>
        /// </summary>
        public DateTime? StartDate { get; set; }

        /// <summary>
        /// Checks to see if the StartDate property is set.
        /// </summary>
        internal bool IsSetStartDate() => this.StartDate.HasValue;

        /// <summary>
        /// Gets and sets the property Tiered. 
        /// <para>
        /// Whether the pricing plan uses tiered pricing.
        /// </para>
        /// </summary>
        public string Tiered { get; set; }

        /// <summary>
        /// Checks to see if the Tiered property is set.
        /// </summary>
        internal bool IsSetTiered() => this.Tiered != null;

        /// <summary>
        /// Gets and sets the property Tiers. 
        /// <para>
        /// The pricing tiers within this plan.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required = true, Max = 20)]
        public List<PricingPlanTier> Tiers { get; set; } = AWSConfigs.InitializeCollections ? new List<PricingPlanTier>() : null;

        /// <summary>
        /// Checks to see if the Tiers property is set.
        /// </summary>
        internal bool IsSetTiers() => this.Tiers != null && (this.Tiers.Count > 0 || !AWSConfigs.InitializeCollections);
    }
}
