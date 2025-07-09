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
    /// The recommended Capacity Block that fits your search requirements.
    /// </summary>
    public partial class CapacityBlockOffering
    {
        private string _availabilityZone;
        private int? _capacityBlockDurationHours;
        private int? _capacityBlockDurationMinutes;
        private string _capacityBlockOfferingId;
        private string _currencyCode;
        private DateTime? _endDate;
        private int? _instanceCount;
        private string _instanceType;
        private DateTime? _startDate;
        private CapacityReservationTenancy _tenancy;
        private int? _ultraserverCount;
        private string _ultraserverType;
        private string _upfrontFee;

        /// <summary>
        /// Gets and sets the property AvailabilityZone. 
        /// <para>
        /// The Availability Zone of the Capacity Block offering.
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
        /// Gets and sets the property CapacityBlockDurationHours. 
        /// <para>
        /// The number of hours (in addition to <c>capacityBlockDurationMinutes</c>) for the duration
        /// of the Capacity Block reservation. For example, if a Capacity Block starts at <b>04:55</b>
        /// and ends at <b>11:30</b>, the hours field would be <b>6</b>.
        /// </para>
        /// </summary>
        public int? CapacityBlockDurationHours
        {
            get { return this._capacityBlockDurationHours; }
            set { this._capacityBlockDurationHours = value; }
        }

        // Check to see if CapacityBlockDurationHours property is set
        internal bool IsSetCapacityBlockDurationHours()
        {
            return this._capacityBlockDurationHours.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property CapacityBlockDurationMinutes. 
        /// <para>
        /// The number of minutes (in addition to <c>capacityBlockDurationHours</c>) for the duration
        /// of the Capacity Block reservation. For example, if a Capacity Block starts at <b>08:55</b>
        /// and ends at <b>11:30</b>, the minutes field would be <b>35</b>.
        /// </para>
        /// </summary>
        public int? CapacityBlockDurationMinutes
        {
            get { return this._capacityBlockDurationMinutes; }
            set { this._capacityBlockDurationMinutes = value; }
        }

        // Check to see if CapacityBlockDurationMinutes property is set
        internal bool IsSetCapacityBlockDurationMinutes()
        {
            return this._capacityBlockDurationMinutes.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property CapacityBlockOfferingId. 
        /// <para>
        /// The ID of the Capacity Block offering.
        /// </para>
        /// </summary>
        public string CapacityBlockOfferingId
        {
            get { return this._capacityBlockOfferingId; }
            set { this._capacityBlockOfferingId = value; }
        }

        // Check to see if CapacityBlockOfferingId property is set
        internal bool IsSetCapacityBlockOfferingId()
        {
            return this._capacityBlockOfferingId != null;
        }

        /// <summary>
        /// Gets and sets the property CurrencyCode. 
        /// <para>
        /// The currency of the payment for the Capacity Block.
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
        /// Gets and sets the property EndDate. 
        /// <para>
        /// The end date of the Capacity Block offering.
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
        /// Gets and sets the property InstanceCount. 
        /// <para>
        /// The number of instances in the Capacity Block offering.
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
        /// The instance type of the Capacity Block offering.
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
        /// The start date of the Capacity Block offering.
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
        /// The tenancy of the Capacity Block.
        /// </para>
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
        /// Gets and sets the property UltraserverCount. 
        /// <para>
        /// The number of EC2 UltraServers in the offering.
        /// </para>
        /// </summary>
        public int? UltraserverCount
        {
            get { return this._ultraserverCount; }
            set { this._ultraserverCount = value; }
        }

        // Check to see if UltraserverCount property is set
        internal bool IsSetUltraserverCount()
        {
            return this._ultraserverCount.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property UltraserverType. 
        /// <para>
        /// The EC2 UltraServer type of the Capacity Block offering.
        /// </para>
        /// </summary>
        public string UltraserverType
        {
            get { return this._ultraserverType; }
            set { this._ultraserverType = value; }
        }

        // Check to see if UltraserverType property is set
        internal bool IsSetUltraserverType()
        {
            return this._ultraserverType != null;
        }

        /// <summary>
        /// Gets and sets the property UpfrontFee. 
        /// <para>
        /// The total price to be paid up front.
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