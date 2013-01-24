/*******************************************************************************
 * Copyright 2008-2013 Amazon.com, Inc. or its affiliates. All Rights Reserved.
 * Licensed under the Apache License, Version 2.0 (the "License"). You may not use
 * this file except in compliance with the License. A copy of the License is located at
 *
 * http://aws.amazon.com/apache2.0
 *
 * or in the "license" file accompanying this file. This file is distributed on
 * an "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express
 * or implied. See the License for the specific language governing permissions and
 * limitations under the License.
 * *****************************************************************************
 *    __  _    _  ___
 *   (  )( \/\/ )/ __)
 *   /__\ \    / \__ \
 *  (_)(_) \/\/  (___/
 *
 *  AWS SDK for .NET
 */

using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;

namespace Amazon.EC2.Model
{
    /// <summary>
    /// Reserved Instances Offering
    /// </summary>
    [XmlRootAttribute(IsNullable = false)]
    public class ReservedInstancesOffering
    {    
        private string reservedInstancesOfferingIdField;
        private string instanceTypeField;
        private string availabilityZoneField;
        private Decimal? durationField;
        private string usagePriceField;
        private string fixedPriceField;
        private string productDescriptionField;
        private string instanceTenancyField;
        private string currencyCodeField;
        private string offeringTypeField;
        private List<RecurringCharges> recurringChargesField;
        private bool? isMarketplaceField;
        private List<PricingDetails> pricingDetailsField;

        /// <summary>
        /// The ID of the Reserved Instance offering.
        /// </summary>
        [XmlElementAttribute(ElementName = "ReservedInstancesOfferingId")]
        public string ReservedInstancesOfferingId
        {
            get { return this.reservedInstancesOfferingIdField; }
            set { this.reservedInstancesOfferingIdField = value; }
        }

        /// <summary>
        /// Sets the ID of the Reserved Instance offering.
        /// </summary>
        /// <param name="reservedInstancesOfferingId">The ID of the Reserved Instance offering.</param>
        /// <returns>this instance</returns>
        public ReservedInstancesOffering WithReservedInstancesOfferingId(string reservedInstancesOfferingId)
        {
            this.reservedInstancesOfferingIdField = reservedInstancesOfferingId;
            return this;
        }

        /// <summary>
        /// Checks if ReservedInstancesOfferingId property is set
        /// </summary>
        /// <returns>true if ReservedInstancesOfferingId property is set</returns>
        public bool IsSetReservedInstancesOfferingId()
        {
            return this.reservedInstancesOfferingIdField != null;
        }

        /// <summary>
        /// The instance type on which the Reserved Instance can be used.
        /// </summary>
        [XmlElementAttribute(ElementName = "InstanceType")]
        public string InstanceType
        {
            get { return this.instanceTypeField; }
            set { this.instanceTypeField = value; }
        }

        /// <summary>
        /// Sets the instance type on which the Reserved Instance can be used.
        /// </summary>
        /// <param name="instanceType">The instance type on which the Reserved
        /// Instance can be used.</param>
        /// <returns>this instance</returns>
        public ReservedInstancesOffering WithInstanceType(string instanceType)
        {
            this.instanceTypeField = instanceType;
            return this;
        }

        /// <summary>
        /// Checks if InstanceType property is set
        /// </summary>
        /// <returns>true if InstanceType property is set</returns>
        public bool IsSetInstanceType()
        {
            return this.instanceTypeField != null;
        }

        /// <summary>
        /// The Availability Zone in which the Reserved Instance can be used.
        /// </summary>
        [XmlElementAttribute(ElementName = "AvailabilityZone")]
        public string AvailabilityZone
        {
            get { return this.availabilityZoneField; }
            set { this.availabilityZoneField = value; }
        }

        /// <summary>
        /// Sets the Availability Zone in which the Reserved Instance can be used.
        /// </summary>
        /// <param name="availabilityZone">The Availability Zone in which the Reserved
        /// Instance can be used.</param>
        /// <returns>this instance</returns>
        public ReservedInstancesOffering WithAvailabilityZone(string availabilityZone)
        {
            this.availabilityZoneField = availabilityZone;
            return this;
        }

        /// <summary>
        /// Checks if AvailabilityZone property is set
        /// </summary>
        /// <returns>true if AvailabilityZone property is set</returns>
        public bool IsSetAvailabilityZone()
        {
            return this.availabilityZoneField != null;
        }

        /// <summary>
        /// The duration of the Reserved Instance, in seconds.
        /// </summary>
        [XmlElementAttribute(ElementName = "Duration")]
        public Decimal Duration
        {
            get { return this.durationField.GetValueOrDefault(); }
            set { this.durationField = value; }
        }

        /// <summary>
        /// Sets the duration of the Reserved Instance, in seconds.
        /// </summary>
        /// <param name="duration">The duration of the Reserved Instance, in
        /// seconds.</param>
        /// <returns>this instance</returns>
        public ReservedInstancesOffering WithDuration(Decimal duration)
        {
            this.durationField = duration;
            return this;
        }

        /// <summary>
        /// Checks if Duration property is set
        /// </summary>
        /// <returns>true if Duration property is set</returns>
        public bool IsSetDuration()
        {
            return this.durationField.HasValue;
        }

        /// <summary>
        /// The usage price of the Reserved Instance, per hour.
        /// </summary>
        [XmlElementAttribute(ElementName = "UsagePrice")]
        public string UsagePrice
        {
            get { return this.usagePriceField; }
            set { this.usagePriceField = value; }
        }

        /// <summary>
        /// Sets the usage price of the Reserved Instance, per hour.
        /// </summary>
        /// <param name="usagePrice">The usage price of the Reserved Instance, per
        /// hour.</param>
        /// <returns>this instance</returns>
        public ReservedInstancesOffering WithUsagePrice(string usagePrice)
        {
            this.usagePriceField = usagePrice;
            return this;
        }

        /// <summary>
        /// Checks if UsagePrice property is set
        /// </summary>
        /// <returns>true if UsagePrice property is set</returns>
        public bool IsSetUsagePrice()
        {
            return this.usagePriceField != null;
        }

        /// <summary>
        /// The purchase price of the Reserved Instance.
        /// </summary>
        [XmlElementAttribute(ElementName = "FixedPrice")]
        public string FixedPrice
        {
            get { return this.fixedPriceField; }
            set { this.fixedPriceField = value; }
        }

        /// <summary>
        /// Sets the purchase price of the Reserved Instance.
        /// </summary>
        /// <param name="fixedPrice">The purchase price of the Reserved Instance.</param>
        /// <returns>this instance</returns>
        public ReservedInstancesOffering WithFixedPrice(string fixedPrice)
        {
            this.fixedPriceField = fixedPrice;
            return this;
        }

        /// <summary>
        /// Checks if FixedPrice property is set
        /// </summary>
        /// <returns>true if FixedPrice property is set</returns>
        public bool IsSetFixedPrice()
        {
            return this.fixedPriceField != null;
        }

        /// <summary>
        /// The Reserved Instance description.
        /// </summary>
        [XmlElementAttribute(ElementName = "ProductDescription")]
        public string ProductDescription
        {
            get { return this.productDescriptionField; }
            set { this.productDescriptionField = value; }
        }

        /// <summary>
        /// Sets the Reserved Instance description.
        /// </summary>
        /// <param name="productDescription">The Reserved Instance description.</param>
        /// <returns>this instance</returns>
        public ReservedInstancesOffering WithProductDescription(string productDescription)
        {
            this.productDescriptionField = productDescription;
            return this;
        }

        /// <summary>
        /// Checks if ProductDescription property is set
        /// </summary>
        /// <returns>true if ProductDescription property is set</returns>
        public bool IsSetProductDescription()
        {
            return this.productDescriptionField != null;
        }


        /// <summary>
        /// The tenancy of the reserved instance.
        /// </summary>
        [XmlElementAttribute(ElementName = "InstanceTenancy")]
        public string InstanceTenancy
        {
            get { return this.instanceTenancyField; }
            set { this.instanceTenancyField = value; }
        }

        /// <summary>
        /// Checks if InstanceTenancy property is set
        /// </summary>
        /// <returns>true if InstanceTenancy property is set</returns>
        public bool IsSetInstanceTenancy()
        {
            return this.instanceTenancyField != null;
        }

        /// <summary>
        /// Sets the tenancy of the reserved instance.
        /// </summary>
        /// <param name="instanceTenancy">The tenancy of the reserved instance.</param>
        /// <returns>this instance</returns>
        public ReservedInstancesOffering WithInstanceTenancy(string instanceTenancy)
        {
            this.instanceTenancyField = instanceTenancy;
            return this;
        }

        /// <summary>
        /// The currency of the Reserved Instance offering you are purchasing.
        /// It's specified using ISO 4217 standard (e.g., USD, JPY).
        /// </summary>
        [XmlElementAttribute(ElementName = "CurrencyCode")]
        public string CurrencyCode
        {
            get { return this.currencyCodeField; }
            set { this.currencyCodeField = value; }
        }

        /// <summary>
        /// Checks if CurrencyCode property is set
        /// </summary>
        /// <returns>true if CurrencyCode property is set</returns>
        public bool IsSetCurrencyCode()
        {
            return this.currencyCodeField != null;
        }

        /// <summary>
        /// Sets the currency of the Reserved Instance offering you are purchasing.
        /// </summary>
        /// <param name="currencyCode">The ISO 4217 CurrencyCode (e.g., USD, JPY).</param>
        /// <returns>this instance</returns>
        public ReservedInstancesOffering WithCurrencyCode(string currencyCode)
        {
            this.currencyCodeField = currencyCode;
            return this;
        }

        /// <summary>
        /// The Reserved Instance Offering type.
        /// </summary>
        [XmlElementAttribute(ElementName = "OfferingType")]
        public string OfferingType
        {
            get { return this.offeringTypeField; }
            set { this.offeringTypeField = value; }
        }

        /// <summary>
        /// Checks if OfferingType property is set
        /// </summary>
        /// <returns>true if OfferingType property is set</returns>
        public bool IsSetOfferingType()
        {
            return this.offeringTypeField != null;
        }

        /// <summary>
        /// Sets the Reserved Instance Offering type.
        /// </summary>
        /// <param name="offeringType">The Reserved Instance Offering type</param>
        /// <returns>this instance</returns>
        public ReservedInstancesOffering WithOfferingType(string offeringType)
        {
            this.offeringTypeField = offeringType;
            return this;
        }

        /// <summary>
        /// Zero or more recurring charges associated with the Reserved Instance offering.
        /// </summary>
        [XmlElementAttribute(ElementName = "RecurringCharges")]
        public List<RecurringCharges> RecurringCharges
        {
            get
            {
                if (this.recurringChargesField == null)
                {
                    this.recurringChargesField = new List<RecurringCharges>();
                }
                return this.recurringChargesField;
            }
            set { this.recurringChargesField = value; }
        }

        /// <summary>
        /// Sets recurring charges associated with the Reserved Instance offering.
        /// </summary>
        /// <param name="list">Zero or more recurring charges associated with the Reserved Instance offering.</param>
        /// <returns>this instance</returns>
        public ReservedInstancesOffering WithRecurringCharges(params RecurringCharges[] list)
        {
            foreach (RecurringCharges item in list)
            {
                this.RecurringCharges.Add(item);
            }
            return this;
        }

        /// <summary>
        /// Checks if RecurringCharges property is set
        /// </summary>
        /// <returns>true if RecurringCharges property is set</returns>
        public bool IsSetRecurringCharges()
        {
            return (RecurringCharges.Count > 0);
        }

        /// <summary>
        /// Whether the offering is available through the Reserved Instance
        /// Marketplace (resale) or AWS. True if it is a Marketplace offering.
        /// </summary>
        [XmlElementAttribute(ElementName = "IsMarketPlace")]
        public bool IsMarketPlace
        {
            get { return this.isMarketplaceField.GetValueOrDefault(); }
            set { this.isMarketplaceField = value; }
        }

        /// <summary>
        /// Sets whether the offering is available through the Reserved Instance
        /// Marketplace (resale) or AWS. 
        /// </summary>
        /// <param name="isMarketplace">True if it is a Marketplace offering.</param>
        /// <returns>this instance</returns>
        public ReservedInstancesOffering WithIsMarketplace(bool isMarketplace)
        {
            this.isMarketplaceField = isMarketplace;
            return this;
        }

        /// <summary>
        /// Checks if the IsMarketplace property is set.
        /// </summary>
        /// <returns>True if the property is set</returns>
        public bool IsSetIsMarketplace()
        {
            return this.isMarketplaceField != null;
        }

        /// <summary>
        /// The pricing details of the Reserved Instance offering.
        /// </summary>
        [XmlElementAttribute(ElementName = "PricingDetails")]
        public List<PricingDetails> PricingDetails
        {
            get
            {
                if (this.pricingDetailsField == null)
                {
                    this.pricingDetailsField = new List<PricingDetails>();
                }
                return this.pricingDetailsField;
            }
            set { this.pricingDetailsField = value; }
        }

        /// <summary>
        /// Sets the pricing details of the Reserved Instance offering.
        /// </summary>
        /// <param name="list">Pricing details for the offering</param>
        /// <returns>this instance</returns>
        public ReservedInstancesOffering WithPricingDetails(params PricingDetails[] list)
        {
            foreach (PricingDetails item in list)
            {
                this.PricingDetails.Add(item);
            }
            return this;
        }

        /// <summary>
        /// Checks if the PricingDetails property is set.
        /// </summary>
        /// <returns>True if the property is set</returns>
        public bool IsSetPricingDetails()
        {
            return (this.PricingDetails.Count > 0);
        }
    }
}
