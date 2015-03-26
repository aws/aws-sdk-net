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
 * Do not modify this file. This file is generated from the ec2-2014-10-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.EC2.Model
{
    /// <summary>
    /// Describes a Reserved Instance offering.
    /// </summary>
    public partial class ReservedInstancesOffering
    {
        private string _availabilityZone;
        private CurrencyCodeValues _currencyCode;
        private long? _duration;
        private float? _fixedPrice;
        private Tenancy _instanceTenancy;
        private InstanceType _instanceType;
        private bool? _marketplace;
        private OfferingTypeValues _offeringType;
        private List<PricingDetail> _pricingDetails = new List<PricingDetail>();
        private RIProductDescription _productDescription;
        private List<RecurringCharge> _recurringCharges = new List<RecurringCharge>();
        private string _reservedInstancesOfferingId;
        private float? _usagePrice;

        /// <summary>
        /// Gets and sets the property AvailabilityZone. 
        /// <para>
        /// The Availability Zone in which the Reserved Instance can be used.
        /// </para>
        /// </summary>
        public string AvailabilityZone
        {
            get { return this._availabilityZone; }
            set { this._availabilityZone = value; }
        }

        // Check to see if AvailabilityZone property is set
        internal bool IsSetAvailabilityZone()
        {
            return this._availabilityZone != null;
        }

        /// <summary>
        /// Gets and sets the property CurrencyCode. 
        /// <para>
        /// The currency of the Reserved Instance offering you are purchasing. It's specified
        /// using ISO 4217 standard currency codes. At this time, the only supported currency
        /// is <code>USD</code>.
        /// </para>
        /// </summary>
        public CurrencyCodeValues CurrencyCode
        {
            get { return this._currencyCode; }
            set { this._currencyCode = value; }
        }

        // Check to see if CurrencyCode property is set
        internal bool IsSetCurrencyCode()
        {
            return this._currencyCode != null;
        }

        /// <summary>
        /// Gets and sets the property Duration. 
        /// <para>
        /// The duration of the Reserved Instance, in seconds.
        /// </para>
        /// </summary>
        public long Duration
        {
            get { return this._duration.GetValueOrDefault(); }
            set { this._duration = value; }
        }

        // Check to see if Duration property is set
        internal bool IsSetDuration()
        {
            return this._duration.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property FixedPrice. 
        /// <para>
        /// The purchase price of the Reserved Instance.
        /// </para>
        /// </summary>
        public float FixedPrice
        {
            get { return this._fixedPrice.GetValueOrDefault(); }
            set { this._fixedPrice = value; }
        }

        // Check to see if FixedPrice property is set
        internal bool IsSetFixedPrice()
        {
            return this._fixedPrice.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property InstanceTenancy. 
        /// <para>
        /// The tenancy of the reserved instance.
        /// </para>
        /// </summary>
        public Tenancy InstanceTenancy
        {
            get { return this._instanceTenancy; }
            set { this._instanceTenancy = value; }
        }

        // Check to see if InstanceTenancy property is set
        internal bool IsSetInstanceTenancy()
        {
            return this._instanceTenancy != null;
        }

        /// <summary>
        /// Gets and sets the property InstanceType. 
        /// <para>
        /// The instance type on which the Reserved Instance can be used.
        /// </para>
        /// </summary>
        public InstanceType InstanceType
        {
            get { return this._instanceType; }
            set { this._instanceType = value; }
        }

        // Check to see if InstanceType property is set
        internal bool IsSetInstanceType()
        {
            return this._instanceType != null;
        }

        /// <summary>
        /// Gets and sets the property Marketplace. 
        /// <para>
        /// Indicates whether the offering is available through the Reserved Instance Marketplace
        /// (resale) or AWS. If it's a Reserved Instance Marketplace offering, this is <code>true</code>.
        /// </para>
        /// </summary>
        public bool Marketplace
        {
            get { return this._marketplace.GetValueOrDefault(); }
            set { this._marketplace = value; }
        }

        // Check to see if Marketplace property is set
        internal bool IsSetMarketplace()
        {
            return this._marketplace.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property OfferingType. 
        /// <para>
        /// The Reserved Instance offering type.
        /// </para>
        /// </summary>
        public OfferingTypeValues OfferingType
        {
            get { return this._offeringType; }
            set { this._offeringType = value; }
        }

        // Check to see if OfferingType property is set
        internal bool IsSetOfferingType()
        {
            return this._offeringType != null;
        }

        /// <summary>
        /// Gets and sets the property PricingDetails. 
        /// <para>
        /// The pricing details of the Reserved Instance offering.
        /// </para>
        /// </summary>
        public List<PricingDetail> PricingDetails
        {
            get { return this._pricingDetails; }
            set { this._pricingDetails = value; }
        }

        // Check to see if PricingDetails property is set
        internal bool IsSetPricingDetails()
        {
            return this._pricingDetails != null && this._pricingDetails.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property ProductDescription. 
        /// <para>
        /// The Reserved Instance description.
        /// </para>
        /// </summary>
        public RIProductDescription ProductDescription
        {
            get { return this._productDescription; }
            set { this._productDescription = value; }
        }

        // Check to see if ProductDescription property is set
        internal bool IsSetProductDescription()
        {
            return this._productDescription != null;
        }

        /// <summary>
        /// Gets and sets the property RecurringCharges. 
        /// <para>
        /// The recurring charge tag assigned to the resource.
        /// </para>
        /// </summary>
        public List<RecurringCharge> RecurringCharges
        {
            get { return this._recurringCharges; }
            set { this._recurringCharges = value; }
        }

        // Check to see if RecurringCharges property is set
        internal bool IsSetRecurringCharges()
        {
            return this._recurringCharges != null && this._recurringCharges.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property ReservedInstancesOfferingId. 
        /// <para>
        /// The ID of the Reserved Instance offering.
        /// </para>
        /// </summary>
        public string ReservedInstancesOfferingId
        {
            get { return this._reservedInstancesOfferingId; }
            set { this._reservedInstancesOfferingId = value; }
        }

        // Check to see if ReservedInstancesOfferingId property is set
        internal bool IsSetReservedInstancesOfferingId()
        {
            return this._reservedInstancesOfferingId != null;
        }

        /// <summary>
        /// Gets and sets the property UsagePrice. 
        /// <para>
        /// The usage price of the Reserved Instance, per hour.
        /// </para>
        /// </summary>
        public float UsagePrice
        {
            get { return this._usagePrice.GetValueOrDefault(); }
            set { this._usagePrice = value; }
        }

        // Check to see if UsagePrice property is set
        internal bool IsSetUsagePrice()
        {
            return this._usagePrice.HasValue; 
        }

    }
}