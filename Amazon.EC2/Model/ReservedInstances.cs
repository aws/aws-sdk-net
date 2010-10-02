/*******************************************************************************
 * Copyright 2008-2010 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
 *  API Version: 2010-06-15
 */

using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;

namespace Amazon.EC2.Model
{
    ///<summary>
    ///Reserved Instances
    ///</summary>
    [XmlRootAttribute(Namespace = "http://ec2.amazonaws.com/doc/2010-06-15/", IsNullable = false)]
    public class ReservedInstances
    {    
        private string reservedInstancesIdField;
        private string instanceTypeField;
        private string availabilityZoneField;
        private Decimal? durationField;
        private string usagePriceField;
        private string fixedPriceField;
        private Decimal? instanceCountField;
        private string productDescriptionField;
        private string purchaseStateField;
        private string startTimeField;

        /// <summary>
        /// Gets and sets the ReservedInstancesId property.
        /// The ID of the Reserved Instances.
        /// </summary>
        [XmlElementAttribute(ElementName = "ReservedInstancesId")]
        public string ReservedInstancesId
        {
            get { return this.reservedInstancesIdField; }
            set { this.reservedInstancesIdField = value; }
        }

        /// <summary>
        /// Sets the ReservedInstancesId property
        /// </summary>
        /// <param name="reservedInstancesId">The ID of the Reserved Instances.</param>
        /// <returns>this instance</returns>
        public ReservedInstances WithReservedInstancesId(string reservedInstancesId)
        {
            this.reservedInstancesIdField = reservedInstancesId;
            return this;
        }

        /// <summary>
        /// Checks if ReservedInstancesId property is set
        /// </summary>
        /// <returns>true if ReservedInstancesId property is set</returns>
        public bool IsSetReservedInstancesId()
        {
            return this.reservedInstancesIdField != null;
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
        public ReservedInstances WithInstanceType(string instanceType)
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
        public ReservedInstances WithAvailabilityZone(string availabilityZone)
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
        public ReservedInstances WithDuration(Decimal duration)
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
        public ReservedInstances WithUsagePrice(string usagePrice)
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
        public ReservedInstances WithFixedPrice(string fixedPrice)
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
        /// Gets and sets the InstanceCount property.
        /// The number of Reserved Instances purchased.
        /// </summary>
        [XmlElementAttribute(ElementName = "InstanceCount")]
        public Decimal InstanceCount
        {
            get { return this.instanceCountField.GetValueOrDefault(); }
            set { this.instanceCountField = value; }
        }

        /// <summary>
        /// Sets the InstanceCount property
        /// </summary>
        /// <param name="instanceCount">The number of Reserved Instances purchased.</param>
        /// <returns>this instance</returns>
        public ReservedInstances WithInstanceCount(Decimal instanceCount)
        {
            this.instanceCountField = instanceCount;
            return this;
        }

        /// <summary>
        /// Checks if InstanceCount property is set
        /// </summary>
        /// <returns>true if InstanceCount property is set</returns>
        public bool IsSetInstanceCount()
        {
            return this.instanceCountField.HasValue;
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
        public ReservedInstances WithProductDescription(string productDescription)
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
        /// Gets and sets the PurchaseState property.
        /// The state of the Reserved Instance purchase.
        /// Valid Values:
        /// pending-payment | active | payment-failed | retired
        /// </summary>
        [XmlElementAttribute(ElementName = "PurchaseState")]
        public string PurchaseState
        {
            get { return this.purchaseStateField; }
            set { this.purchaseStateField = value; }
        }

        /// <summary>
        /// Sets the PurchaseState property
        /// </summary>
        /// <param name="purchaseState">The state of the Reserved Instance purchase.
        /// Valid Values:
        /// pending-payment | active | payment-failed | retired</param>
        /// <returns>this instance</returns>
        public ReservedInstances WithPurchaseState(string purchaseState)
        {
            this.purchaseStateField = purchaseState;
            return this;
        }

        /// <summary>
        /// Checks if PurchaseState property is set
        /// </summary>
        /// <returns>true if PurchaseState property is set</returns>
        public bool IsSetPurchaseState()
        {
            return this.purchaseStateField != null;
        }

        /// <summary>
        /// Gets and sets the StartTime property.
        /// The date and time the Reserved Instance
        /// started.
        /// </summary>
        [XmlElementAttribute(ElementName = "StartTime")]
        public string StartTime
        {
            get { return this.startTimeField; }
            set { this.startTimeField = value; }
        }

        /// <summary>
        /// Sets the StartTime property
        /// </summary>
        /// <param name="startTime">The date and time the Reserved Instance
        /// started.</param>
        /// <returns>this instance</returns>
        public ReservedInstances WithStartTime(string startTime)
        {
            this.startTimeField = startTime;
            return this;
        }

        /// <summary>
        /// Checks if StartTime property is set
        /// </summary>
        /// <returns>true if StartTime property is set</returns>
        public bool IsSetStartTime()
        {
            return this.startTimeField != null;
        }

    }
}
