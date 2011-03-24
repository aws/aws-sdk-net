/*******************************************************************************
 * Copyright 2008-2011 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
 *  API Version: 2011-01-01
 */

using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;

namespace Amazon.EC2.Model
{
    ///<summary>
    ///Reserved Instances Offering
    ///</summary>
    [XmlRootAttribute(Namespace = "http://ec2.amazonaws.com/doc/2011-01-01/", IsNullable = false)]
    public class ReservedInstancesOffering
    {    
        private string reservedInstancesOfferingIdField;
        private string instanceTypeField;
        private string availabilityZoneField;
        private Decimal? durationField;
        private string usagePriceField;
        private string fixedPriceField;
        private string productDescriptionField;

        /// <summary>
        /// Gets and sets the ReservedInstancesOfferingId property.
        /// The ID of the Reserved Instance offering.
        /// </summary>
        [XmlElementAttribute(ElementName = "ReservedInstancesOfferingId")]
        public string ReservedInstancesOfferingId
        {
            get { return this.reservedInstancesOfferingIdField; }
            set { this.reservedInstancesOfferingIdField = value; }
        }

        /// <summary>
        /// Sets the ReservedInstancesOfferingId property
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
        /// Gets and sets the InstanceType property.
        /// The instance type on which the Reserved
        /// Instance can be used.
        /// </summary>
        [XmlElementAttribute(ElementName = "InstanceType")]
        public string InstanceType
        {
            get { return this.instanceTypeField; }
            set { this.instanceTypeField = value; }
        }

        /// <summary>
        /// Sets the InstanceType property
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
        /// Gets and sets the AvailabilityZone property.
        /// The Availability Zone in which the Reserved
        /// Instance can be used.
        /// </summary>
        [XmlElementAttribute(ElementName = "AvailabilityZone")]
        public string AvailabilityZone
        {
            get { return this.availabilityZoneField; }
            set { this.availabilityZoneField = value; }
        }

        /// <summary>
        /// Sets the AvailabilityZone property
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
        /// Gets and sets the Duration property.
        /// The duration of the Reserved Instance, in
        /// seconds.
        /// </summary>
        [XmlElementAttribute(ElementName = "Duration")]
        public Decimal Duration
        {
            get { return this.durationField.GetValueOrDefault(); }
            set { this.durationField = value; }
        }

        /// <summary>
        /// Sets the Duration property
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
        /// Gets and sets the UsagePrice property.
        /// The usage price of the Reserved Instance, per
        /// hour.
        /// </summary>
        [XmlElementAttribute(ElementName = "UsagePrice")]
        public string UsagePrice
        {
            get { return this.usagePriceField; }
            set { this.usagePriceField = value; }
        }

        /// <summary>
        /// Sets the UsagePrice property
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
        /// Gets and sets the FixedPrice property.
        /// The purchase price of the Reserved Instance.
        /// </summary>
        [XmlElementAttribute(ElementName = "FixedPrice")]
        public string FixedPrice
        {
            get { return this.fixedPriceField; }
            set { this.fixedPriceField = value; }
        }

        /// <summary>
        /// Sets the FixedPrice property
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
        /// Gets and sets the ProductDescription property.
        /// The Reserved Instance description.
        /// </summary>
        [XmlElementAttribute(ElementName = "ProductDescription")]
        public string ProductDescription
        {
            get { return this.productDescriptionField; }
            set { this.productDescriptionField = value; }
        }

        /// <summary>
        /// Sets the ProductDescription property
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

    }
}
