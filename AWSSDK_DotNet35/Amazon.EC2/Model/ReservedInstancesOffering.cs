/*
 * Copyright 2010-2013 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

namespace Amazon.EC2.Model
{
    /// <summary>
    /// <para> An active offer for Amazon EC2 Reserved Instances. </para>
    /// </summary>
    public class ReservedInstancesOffering
    {
        
        private string reservedInstancesOfferingId;
        private InstanceType instanceType;
        private string availabilityZone;
        private long? duration;
        private float? usagePrice;
        private float? fixedPrice;
        private RIProductDescription productDescription;
        private Tenancy instanceTenancy;
        private CurrencyCodeValues currencyCode;
        private OfferingTypeValues offeringType;
        private List<RecurringCharge> recurringCharges = new List<RecurringCharge>();
        private bool? marketplace;
        private List<PricingDetail> pricingDetails = new List<PricingDetail>();


        /// <summary>
        /// The unique ID of this Reserved Instances offering.
        ///  
        /// </summary>
        public string ReservedInstancesOfferingId
        {
            get { return this.reservedInstancesOfferingId; }
            set { this.reservedInstancesOfferingId = value; }
        }

        // Check to see if ReservedInstancesOfferingId property is set
        internal bool IsSetReservedInstancesOfferingId()
        {
            return this.reservedInstancesOfferingId != null;
        }

        /// <summary>
        /// The instance type on which the Reserved Instances can be used.
        ///  
        /// <para>
        /// <b>Constraints:</b>
        /// <list type="definition">
        ///     <item>
        ///         <term>Allowed Values</term>
        ///         <description>t1.micro, m1.small, m1.medium, m1.large, m1.xlarge, m2.xlarge, m2.2xlarge, m2.4xlarge, m3.xlarge, m3.2xlarge, c1.medium, c1.xlarge, hi1.4xlarge, hs1.8xlarge, cc1.4xlarge, cc2.8xlarge, cg1.4xlarge, cr1.8xlarge</description>
        ///     </item>
        /// </list>
        /// </para>
        /// </summary>
        public InstanceType InstanceType
        {
            get { return this.instanceType; }
            set { this.instanceType = value; }
        }

        // Check to see if InstanceType property is set
        internal bool IsSetInstanceType()
        {
            return this.instanceType != null;
        }

        /// <summary>
        /// The Availability Zone in which the Reserved Instances can be used.
        ///  
        /// </summary>
        public string AvailabilityZone
        {
            get { return this.availabilityZone; }
            set { this.availabilityZone = value; }
        }

        // Check to see if AvailabilityZone property is set
        internal bool IsSetAvailabilityZone()
        {
            return this.availabilityZone != null;
        }

        /// <summary>
        /// The duration of the Reserved Instance, in seconds.
        ///  
        /// </summary>
        public long Duration
        {
            get { return this.duration ?? default(long); }
            set { this.duration = value; }
        }

        // Check to see if Duration property is set
        internal bool IsSetDuration()
        {
            return this.duration.HasValue;
        }

        /// <summary>
        /// The usage price of the Reserved Instance, per hour.
        ///  
        /// </summary>
        public float UsagePrice
        {
            get { return this.usagePrice ?? default(float); }
            set { this.usagePrice = value; }
        }

        // Check to see if UsagePrice property is set
        internal bool IsSetUsagePrice()
        {
            return this.usagePrice.HasValue;
        }

        /// <summary>
        /// The purchase price of the Reserved Instance.
        ///  
        /// </summary>
        public float FixedPrice
        {
            get { return this.fixedPrice ?? default(float); }
            set { this.fixedPrice = value; }
        }

        // Check to see if FixedPrice property is set
        internal bool IsSetFixedPrice()
        {
            return this.fixedPrice.HasValue;
        }

        /// <summary>
        /// The Reserved Instances description (ex: Windows or Unix/Linux).
        ///  
        /// <para>
        /// <b>Constraints:</b>
        /// <list type="definition">
        ///     <item>
        ///         <term>Allowed Values</term>
        ///         <description>Linux/UNIX, Linux/UNIX (Amazon VPC), Windows, Windows (Amazon VPC)</description>
        ///     </item>
        /// </list>
        /// </para>
        /// </summary>
        public RIProductDescription ProductDescription
        {
            get { return this.productDescription; }
            set { this.productDescription = value; }
        }

        // Check to see if ProductDescription property is set
        internal bool IsSetProductDescription()
        {
            return this.productDescription != null;
        }

        /// <summary>
        /// The tenancy of the reserved instance (ex: default or dedicated).
        ///  
        /// <para>
        /// <b>Constraints:</b>
        /// <list type="definition">
        ///     <item>
        ///         <term>Allowed Values</term>
        ///         <description>default, dedicated</description>
        ///     </item>
        /// </list>
        /// </para>
        /// </summary>
        public Tenancy InstanceTenancy
        {
            get { return this.instanceTenancy; }
            set { this.instanceTenancy = value; }
        }

        // Check to see if InstanceTenancy property is set
        internal bool IsSetInstanceTenancy()
        {
            return this.instanceTenancy != null;
        }

        /// <summary>
        /// The currency of the reserved instance. Specified using ISO 4217 standard (e.g., USD, JPY).
        ///  
        /// <para>
        /// <b>Constraints:</b>
        /// <list type="definition">
        ///     <item>
        ///         <term>Allowed Values</term>
        ///         <description>USD</description>
        ///     </item>
        /// </list>
        /// </para>
        /// </summary>
        public CurrencyCodeValues CurrencyCode
        {
            get { return this.currencyCode; }
            set { this.currencyCode = value; }
        }

        // Check to see if CurrencyCode property is set
        internal bool IsSetCurrencyCode()
        {
            return this.currencyCode != null;
        }

        /// <summary>
        /// The Reserved Instance offering type.
        ///  
        /// <para>
        /// <b>Constraints:</b>
        /// <list type="definition">
        ///     <item>
        ///         <term>Allowed Values</term>
        ///         <description>Heavy Utilization, Medium Utilization, Light Utilization</description>
        ///     </item>
        /// </list>
        /// </para>
        /// </summary>
        public OfferingTypeValues OfferingType
        {
            get { return this.offeringType; }
            set { this.offeringType = value; }
        }

        // Check to see if OfferingType property is set
        internal bool IsSetOfferingType()
        {
            return this.offeringType != null;
        }

        /// <summary>
        /// The recurring charge tag assigned to the resource.
        ///  
        /// </summary>
        public List<RecurringCharge> RecurringCharges
        {
            get { return this.recurringCharges; }
            set { this.recurringCharges = value; }
        }

        // Check to see if RecurringCharges property is set
        internal bool IsSetRecurringCharges()
        {
            return this.recurringCharges.Count > 0;
        }
        public bool Marketplace
        {
            get { return this.marketplace ?? default(bool); }
            set { this.marketplace = value; }
        }

        // Check to see if Marketplace property is set
        internal bool IsSetMarketplace()
        {
            return this.marketplace.HasValue;
        }
        public List<PricingDetail> PricingDetails
        {
            get { return this.pricingDetails; }
            set { this.pricingDetails = value; }
        }

        // Check to see if PricingDetails property is set
        internal bool IsSetPricingDetails()
        {
            return this.pricingDetails.Count > 0;
        }
    }
}
