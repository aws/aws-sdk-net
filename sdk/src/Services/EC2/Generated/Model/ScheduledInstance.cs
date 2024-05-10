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
    /// Describes a Scheduled Instance.
    /// </summary>
    public partial class ScheduledInstance
    {
        private string _availabilityZone;
        private DateTime? _createDate;
        private string _hourlyPrice;
        private int? _instanceCount;
        private string _instanceType;
        private string _networkPlatform;
        private DateTime? _nextSlotStartTime;
        private string _platform;
        private DateTime? _previousSlotEndTime;
        private ScheduledInstanceRecurrence _recurrence;
        private string _scheduledInstanceId;
        private int? _slotDurationInHours;
        private DateTime? _termEndDate;
        private DateTime? _termStartDate;
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
        /// Gets and sets the property CreateDate. 
        /// <para>
        /// The date when the Scheduled Instance was purchased.
        /// </para>
        /// </summary>
        public DateTime? CreateDate
        {
            get { return this._createDate; }
            set { this._createDate = value; }
        }

        // Check to see if CreateDate property is set
        internal bool IsSetCreateDate()
        {
            return this._createDate.HasValue; 
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
        /// Gets and sets the property InstanceCount. 
        /// <para>
        /// The number of instances.
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
        /// The instance type.
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
        /// Gets and sets the property NextSlotStartTime. 
        /// <para>
        /// The time for the next schedule to start.
        /// </para>
        /// </summary>
        public DateTime? NextSlotStartTime
        {
            get { return this._nextSlotStartTime; }
            set { this._nextSlotStartTime = value; }
        }

        // Check to see if NextSlotStartTime property is set
        internal bool IsSetNextSlotStartTime()
        {
            return this._nextSlotStartTime.HasValue; 
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
        /// Gets and sets the property PreviousSlotEndTime. 
        /// <para>
        /// The time that the previous schedule ended or will end.
        /// </para>
        /// </summary>
        public DateTime? PreviousSlotEndTime
        {
            get { return this._previousSlotEndTime; }
            set { this._previousSlotEndTime = value; }
        }

        // Check to see if PreviousSlotEndTime property is set
        internal bool IsSetPreviousSlotEndTime()
        {
            return this._previousSlotEndTime.HasValue; 
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
        /// Gets and sets the property ScheduledInstanceId. 
        /// <para>
        /// The Scheduled Instance ID.
        /// </para>
        /// </summary>
        public string ScheduledInstanceId
        {
            get { return this._scheduledInstanceId; }
            set { this._scheduledInstanceId = value; }
        }

        // Check to see if ScheduledInstanceId property is set
        internal bool IsSetScheduledInstanceId()
        {
            return this._scheduledInstanceId != null;
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
        /// Gets and sets the property TermEndDate. 
        /// <para>
        /// The end date for the Scheduled Instance.
        /// </para>
        /// </summary>
        public DateTime? TermEndDate
        {
            get { return this._termEndDate; }
            set { this._termEndDate = value; }
        }

        // Check to see if TermEndDate property is set
        internal bool IsSetTermEndDate()
        {
            return this._termEndDate.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property TermStartDate. 
        /// <para>
        /// The start date for the Scheduled Instance.
        /// </para>
        /// </summary>
        public DateTime? TermStartDate
        {
            get { return this._termStartDate; }
            set { this._termStartDate = value; }
        }

        // Check to see if TermStartDate property is set
        internal bool IsSetTermStartDate()
        {
            return this._termStartDate.HasValue; 
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