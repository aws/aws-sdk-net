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

namespace Amazon.EC2.Model
{
    /// <summary>
    /// Describes a Reserved Instance offering.
    /// </summary>
    public partial class ReservedInstancesOffering
    {
        /// <summary>
        /// Gets and sets the property AvailabilityZone. 
        /// <para>
        /// The Availability Zone in which the Reserved Instance can be used.
        /// </para>
        /// </summary>
        public string AvailabilityZone { get; set; }

        /// <summary>
        /// Checks to see if the AvailabilityZone property is set.
        /// </summary>
        internal bool IsSetAvailabilityZone() => this.AvailabilityZone != null;

        /// <summary>
        /// Gets and sets the property AvailabilityZoneId. 
        /// <para>
        /// The ID of the Availability Zone.
        /// </para>
        /// </summary>
        public string AvailabilityZoneId { get; set; }

        /// <summary>
        /// Checks to see if the AvailabilityZoneId property is set.
        /// </summary>
        internal bool IsSetAvailabilityZoneId() => this.AvailabilityZoneId != null;

        /// <summary>
        /// Gets and sets the property CurrencyCode. 
        /// <para>
        /// The currency of the Reserved Instance offering you are purchasing. It's specified
        /// using ISO 4217 standard currency codes. At this time, the only supported currency
        /// is <c>USD</c>.
        /// </para>
        /// </summary>
        public CurrencyCodeValues CurrencyCode { get; set; }

        /// <summary>
        /// Checks to see if the CurrencyCode property is set.
        /// </summary>
        internal bool IsSetCurrencyCode() => this.CurrencyCode != null;

        /// <summary>
        /// Gets and sets the property Duration. 
        /// <para>
        /// The duration of the Reserved Instance, in seconds.
        /// </para>
        /// </summary>
        public long? Duration { get; set; }

        /// <summary>
        /// Checks to see if the Duration property is set.
        /// </summary>
        internal bool IsSetDuration() => this.Duration.HasValue;

        /// <summary>
        /// Gets and sets the property FixedPrice. 
        /// <para>
        /// The purchase price of the Reserved Instance.
        /// </para>
        /// </summary>
        public float? FixedPrice { get; set; }

        /// <summary>
        /// Checks to see if the FixedPrice property is set.
        /// </summary>
        internal bool IsSetFixedPrice() => this.FixedPrice.HasValue;

        /// <summary>
        /// Gets and sets the property InstanceTenancy. 
        /// <para>
        /// The tenancy of the instance.
        /// </para>
        /// </summary>
        public Tenancy InstanceTenancy { get; set; }

        /// <summary>
        /// Checks to see if the InstanceTenancy property is set.
        /// </summary>
        internal bool IsSetInstanceTenancy() => this.InstanceTenancy != null;

        /// <summary>
        /// Gets and sets the property InstanceType. 
        /// <para>
        /// The instance type on which the Reserved Instance can be used.
        /// </para>
        /// </summary>
        public InstanceType InstanceType { get; set; }

        /// <summary>
        /// Checks to see if the InstanceType property is set.
        /// </summary>
        internal bool IsSetInstanceType() => this.InstanceType != null;

        /// <summary>
        /// Gets and sets the property Marketplace. 
        /// <para>
        /// Indicates whether the offering is available through the Reserved Instance Marketplace
        /// (resale) or Amazon Web Services. If it's a Reserved Instance Marketplace offering,
        /// this is <c>true</c>.
        /// </para>
        /// </summary>
        public bool? Marketplace { get; set; }

        /// <summary>
        /// Checks to see if the Marketplace property is set.
        /// </summary>
        internal bool IsSetMarketplace() => this.Marketplace.HasValue;

        /// <summary>
        /// Gets and sets the property OfferingClass. 
        /// <para>
        /// If <c>convertible</c> it can be exchanged for Reserved Instances of the same or higher
        /// monetary value, with different configurations. If <c>standard</c>, it is not possible
        /// to perform an exchange.
        /// </para>
        /// </summary>
        public OfferingClassType OfferingClass { get; set; }

        /// <summary>
        /// Checks to see if the OfferingClass property is set.
        /// </summary>
        internal bool IsSetOfferingClass() => this.OfferingClass != null;

        /// <summary>
        /// Gets and sets the property OfferingType. 
        /// <para>
        /// The Reserved Instance offering type.
        /// </para>
        /// </summary>
        public OfferingTypeValues OfferingType { get; set; }

        /// <summary>
        /// Checks to see if the OfferingType property is set.
        /// </summary>
        internal bool IsSetOfferingType() => this.OfferingType != null;

        /// <summary>
        /// Gets and sets the property PricingDetails. 
        /// <para>
        /// The pricing details of the Reserved Instance offering.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<PricingDetail> PricingDetails { get; set; } = AWSConfigs.InitializeCollections ? new List<PricingDetail>() : null;

        /// <summary>
        /// Checks to see if the PricingDetails property is set.
        /// </summary>
        internal bool IsSetPricingDetails() => this.PricingDetails != null && (this.PricingDetails.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property ProductDescription. 
        /// <para>
        /// The Reserved Instance product platform description.
        /// </para>
        /// </summary>
        public RIProductDescription ProductDescription { get; set; }

        /// <summary>
        /// Checks to see if the ProductDescription property is set.
        /// </summary>
        internal bool IsSetProductDescription() => this.ProductDescription != null;

        /// <summary>
        /// Gets and sets the property RecurringCharges. 
        /// <para>
        /// The recurring charge tag assigned to the resource.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<RecurringCharge> RecurringCharges { get; set; } = AWSConfigs.InitializeCollections ? new List<RecurringCharge>() : null;

        /// <summary>
        /// Checks to see if the RecurringCharges property is set.
        /// </summary>
        internal bool IsSetRecurringCharges() => this.RecurringCharges != null && (this.RecurringCharges.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property ReservedInstancesOfferingId. 
        /// <para>
        /// The ID of the Reserved Instance offering. This is the offering ID used in <a>GetReservedInstancesExchangeQuote</a>
        /// to confirm that an exchange can be made.
        /// </para>
        /// </summary>
        public string ReservedInstancesOfferingId { get; set; }

        /// <summary>
        /// Checks to see if the ReservedInstancesOfferingId property is set.
        /// </summary>
        internal bool IsSetReservedInstancesOfferingId() => this.ReservedInstancesOfferingId != null;

        /// <summary>
        /// Gets and sets the property Scope. 
        /// <para>
        /// Whether the Reserved Instance is applied to instances in a Region or an Availability
        /// Zone.
        /// </para>
        /// </summary>
        public Scope Scope { get; set; }

        /// <summary>
        /// Checks to see if the Scope property is set.
        /// </summary>
        internal bool IsSetScope() => this.Scope != null;

        /// <summary>
        /// Gets and sets the property UsagePrice. 
        /// <para>
        /// The usage price of the Reserved Instance, per hour.
        /// </para>
        /// </summary>
        public float? UsagePrice { get; set; }

        /// <summary>
        /// Checks to see if the UsagePrice property is set.
        /// </summary>
        internal bool IsSetUsagePrice() => this.UsagePrice.HasValue;
    }
}
