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
 * Do not modify this file. This file is generated from the ec2-2016-11-15.normal.json service model.
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
    /// The recommended Capacity Block extension that fits your search requirements.
    /// </summary>
    public partial class CapacityBlockExtensionOffering
    {
        private string _availabilityZone;
        private string _availabilityZoneId;
        private int? _capacityBlockExtensionDurationHours;
        private DateTime? _capacityBlockExtensionEndDate;
        private string _capacityBlockExtensionOfferingId;
        private DateTime? _capacityBlockExtensionStartDate;
        private string _currencyCode;
        private int? _instanceCount;
        private string _instanceType;
        private DateTime? _startDate;
        private CapacityReservationTenancy _tenancy;
        private string _upfrontFee;

        /// <summary>
        /// Gets and sets the property AvailabilityZone. 
        /// <para>
        /// The Availability Zone of the Capacity Block that will be extended.
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
        /// Gets and sets the property AvailabilityZoneId. 
        /// <para>
        /// The Availability Zone ID of the Capacity Block that will be extended.
        /// </para>
        /// </summary>
        public string AvailabilityZoneId
        {
            get { return this._availabilityZoneId; }
            set { this._availabilityZoneId = value; }
        }

        // Check to see if AvailabilityZoneId property is set
        internal bool IsSetAvailabilityZoneId()
        {
            return this._availabilityZoneId != null;
        }

        /// <summary>
        /// Gets and sets the property CapacityBlockExtensionDurationHours. 
        /// <para>
        /// The amount of time of the Capacity Block extension offering in hours.
        /// </para>
        /// </summary>
        public int? CapacityBlockExtensionDurationHours
        {
            get { return this._capacityBlockExtensionDurationHours; }
            set { this._capacityBlockExtensionDurationHours = value; }
        }

        // Check to see if CapacityBlockExtensionDurationHours property is set
        internal bool IsSetCapacityBlockExtensionDurationHours()
        {
            return this._capacityBlockExtensionDurationHours.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property CapacityBlockExtensionEndDate. 
        /// <para>
        /// The date and time at which the Capacity Block extension expires. When a Capacity Block
        /// expires, the reserved capacity is released and you can no longer launch instances
        /// into it. The Capacity Block's state changes to <c>expired</c> when it reaches its
        /// end date
        /// </para>
        /// </summary>
        public DateTime? CapacityBlockExtensionEndDate
        {
            get { return this._capacityBlockExtensionEndDate; }
            set { this._capacityBlockExtensionEndDate = value; }
        }

        // Check to see if CapacityBlockExtensionEndDate property is set
        internal bool IsSetCapacityBlockExtensionEndDate()
        {
            return this._capacityBlockExtensionEndDate.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property CapacityBlockExtensionOfferingId. 
        /// <para>
        /// The ID of the Capacity Block extension offering.
        /// </para>
        /// </summary>
        public string CapacityBlockExtensionOfferingId
        {
            get { return this._capacityBlockExtensionOfferingId; }
            set { this._capacityBlockExtensionOfferingId = value; }
        }

        // Check to see if CapacityBlockExtensionOfferingId property is set
        internal bool IsSetCapacityBlockExtensionOfferingId()
        {
            return this._capacityBlockExtensionOfferingId != null;
        }

        /// <summary>
        /// Gets and sets the property CapacityBlockExtensionStartDate. 
        /// <para>
        /// The date and time at which the Capacity Block extension will start. This date is also
        /// the same as the end date of the Capacity Block that will be extended.
        /// </para>
        /// </summary>
        public DateTime? CapacityBlockExtensionStartDate
        {
            get { return this._capacityBlockExtensionStartDate; }
            set { this._capacityBlockExtensionStartDate = value; }
        }

        // Check to see if CapacityBlockExtensionStartDate property is set
        internal bool IsSetCapacityBlockExtensionStartDate()
        {
            return this._capacityBlockExtensionStartDate.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property CurrencyCode. 
        /// <para>
        /// The currency of the payment for the Capacity Block extension offering.
        /// </para>
        /// </summary>
        public string CurrencyCode
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
        /// Gets and sets the property InstanceCount. 
        /// <para>
        /// The number of instances in the Capacity Block extension offering.
        /// </para>
        /// </summary>
        public int? InstanceCount
        {
            get { return this._instanceCount; }
            set { this._instanceCount = value; }
        }

        // Check to see if InstanceCount property is set
        internal bool IsSetInstanceCount()
        {
            return this._instanceCount.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property InstanceType. 
        /// <para>
        /// The instance type of the Capacity Block that will be extended.
        /// </para>
        /// </summary>
        public string InstanceType
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
        /// Gets and sets the property StartDate. 
        /// <para>
        /// The start date of the Capacity Block that will be extended.
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
        /// Gets and sets the property Tenancy. 
        /// <para>
        /// Indicates the tenancy of the Capacity Block extension offering. A Capacity Block can
        /// have one of the following tenancy settings:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>default</c> - The Capacity Block is created on hardware that is shared with other
        /// Amazon Web Services accounts.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>dedicated</c> - The Capacity Block is created on single-tenant hardware that is
        /// dedicated to a single Amazon Web Services account.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public CapacityReservationTenancy Tenancy
        {
            get { return this._tenancy; }
            set { this._tenancy = value; }
        }

        // Check to see if Tenancy property is set
        internal bool IsSetTenancy()
        {
            return this._tenancy != null;
        }

        /// <summary>
        /// Gets and sets the property UpfrontFee. 
        /// <para>
        /// The total price of the Capacity Block extension offering, to be paid up front.
        /// </para>
        /// </summary>
        public string UpfrontFee
        {
            get { return this._upfrontFee; }
            set { this._upfrontFee = value; }
        }

        // Check to see if UpfrontFee property is set
        internal bool IsSetUpfrontFee()
        {
            return this._upfrontFee != null;
        }

    }
}