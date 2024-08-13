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
    /// Describes a schedule that is available for your Scheduled Instances.
    /// </summary>
    public partial class ScheduledInstanceAvailability
    {
        private string _availabilityZone;
        private int? _availableInstanceCount;
        private DateTime? _firstSlotStartTime;
        private string _hourlyPrice;
        private string _instanceType;
        private int? _maxTermDurationInDays;
        private int? _minTermDurationInDays;
        private string _networkPlatform;
        private string _platform;
        private string _purchaseToken;
        private ScheduledInstanceRecurrence _recurrence;
        private int? _slotDurationInHours;
        private int? _totalScheduledInstanceHours;

        /// <summary>
        /// Gets and sets the property AvailabilityZone. 
        /// <para>
        /// The Availability Zone.
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
        /// Gets and sets the property AvailableInstanceCount. 
        /// <para>
        /// The number of available instances.
        /// </para>
        /// </summary>
        public int? AvailableInstanceCount
        {
            get { return this._availableInstanceCount; }
            set { this._availableInstanceCount = value; }
        }

        // Check to see if AvailableInstanceCount property is set
        internal bool IsSetAvailableInstanceCount()
        {
            return this._availableInstanceCount.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property FirstSlotStartTime. 
        /// <para>
        /// The time period for the first schedule to start.
        /// </para>
        /// </summary>
        public DateTime? FirstSlotStartTime
        {
            get { return this._firstSlotStartTime; }
            set { this._firstSlotStartTime = value; }
        }

        // Check to see if FirstSlotStartTime property is set
        internal bool IsSetFirstSlotStartTime()
        {
            return this._firstSlotStartTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property HourlyPrice. 
        /// <para>
        /// The hourly price for a single instance.
        /// </para>
        /// </summary>
        public string HourlyPrice
        {
            get { return this._hourlyPrice; }
            set { this._hourlyPrice = value; }
        }

        // Check to see if HourlyPrice property is set
        internal bool IsSetHourlyPrice()
        {
            return this._hourlyPrice != null;
        }

        /// <summary>
        /// Gets and sets the property InstanceType. 
        /// <para>
        /// The instance type. You can specify one of the C3, C4, M4, or R3 instance types.
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
        /// Gets and sets the property MaxTermDurationInDays. 
        /// <para>
        /// The maximum term. The only possible value is 365 days.
        /// </para>
        /// </summary>
        public int? MaxTermDurationInDays
        {
            get { return this._maxTermDurationInDays; }
            set { this._maxTermDurationInDays = value; }
        }

        // Check to see if MaxTermDurationInDays property is set
        internal bool IsSetMaxTermDurationInDays()
        {
            return this._maxTermDurationInDays.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property MinTermDurationInDays. 
        /// <para>
        /// The minimum term. The only possible value is 365 days.
        /// </para>
        /// </summary>
        public int? MinTermDurationInDays
        {
            get { return this._minTermDurationInDays; }
            set { this._minTermDurationInDays = value; }
        }

        // Check to see if MinTermDurationInDays property is set
        internal bool IsSetMinTermDurationInDays()
        {
            return this._minTermDurationInDays.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property NetworkPlatform. 
        /// <para>
        /// The network platform.
        /// </para>
        /// </summary>
        public string NetworkPlatform
        {
            get { return this._networkPlatform; }
            set { this._networkPlatform = value; }
        }

        // Check to see if NetworkPlatform property is set
        internal bool IsSetNetworkPlatform()
        {
            return this._networkPlatform != null;
        }

        /// <summary>
        /// Gets and sets the property Platform. 
        /// <para>
        /// The platform (<c>Linux/UNIX</c> or <c>Windows</c>).
        /// </para>
        /// </summary>
        public string Platform
        {
            get { return this._platform; }
            set { this._platform = value; }
        }

        // Check to see if Platform property is set
        internal bool IsSetPlatform()
        {
            return this._platform != null;
        }

        /// <summary>
        /// Gets and sets the property PurchaseToken. 
        /// <para>
        /// The purchase token. This token expires in two hours.
        /// </para>
        /// </summary>
        public string PurchaseToken
        {
            get { return this._purchaseToken; }
            set { this._purchaseToken = value; }
        }

        // Check to see if PurchaseToken property is set
        internal bool IsSetPurchaseToken()
        {
            return this._purchaseToken != null;
        }

        /// <summary>
        /// Gets and sets the property Recurrence. 
        /// <para>
        /// The schedule recurrence.
        /// </para>
        /// </summary>
        public ScheduledInstanceRecurrence Recurrence
        {
            get { return this._recurrence; }
            set { this._recurrence = value; }
        }

        // Check to see if Recurrence property is set
        internal bool IsSetRecurrence()
        {
            return this._recurrence != null;
        }

        /// <summary>
        /// Gets and sets the property SlotDurationInHours. 
        /// <para>
        /// The number of hours in the schedule.
        /// </para>
        /// </summary>
        public int? SlotDurationInHours
        {
            get { return this._slotDurationInHours; }
            set { this._slotDurationInHours = value; }
        }

        // Check to see if SlotDurationInHours property is set
        internal bool IsSetSlotDurationInHours()
        {
            return this._slotDurationInHours.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property TotalScheduledInstanceHours. 
        /// <para>
        /// The total number of hours for a single instance for the entire term.
        /// </para>
        /// </summary>
        public int? TotalScheduledInstanceHours
        {
            get { return this._totalScheduledInstanceHours; }
            set { this._totalScheduledInstanceHours = value; }
        }

        // Check to see if TotalScheduledInstanceHours property is set
        internal bool IsSetTotalScheduledInstanceHours()
        {
            return this._totalScheduledInstanceHours.HasValue; 
        }

    }
}