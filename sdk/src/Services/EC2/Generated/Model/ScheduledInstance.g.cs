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
    /// Describes a Scheduled Instance.
    /// </summary>
    public partial class ScheduledInstance
    {
        /// <summary>
        /// Gets and sets the property AvailabilityZone. 
        /// <para>
        /// The Availability Zone.
        /// </para>
        /// </summary>
        public string AvailabilityZone { get; set; }

        /// <summary>
        /// Checks to see if the AvailabilityZone property is set.
        /// </summary>
        internal bool IsSetAvailabilityZone() => this.AvailabilityZone != null;

        /// <summary>
        /// Gets and sets the property CreateDate. 
        /// <para>
        /// The date when the Scheduled Instance was purchased.
        /// </para>
        /// </summary>
        public DateTime? CreateDate { get; set; }

        /// <summary>
        /// Checks to see if the CreateDate property is set.
        /// </summary>
        internal bool IsSetCreateDate() => this.CreateDate.HasValue;

        /// <summary>
        /// Gets and sets the property HourlyPrice. 
        /// <para>
        /// The hourly price for a single instance.
        /// </para>
        /// </summary>
        public string HourlyPrice { get; set; }

        /// <summary>
        /// Checks to see if the HourlyPrice property is set.
        /// </summary>
        internal bool IsSetHourlyPrice() => this.HourlyPrice != null;

        /// <summary>
        /// Gets and sets the property InstanceCount. 
        /// <para>
        /// The number of instances.
        /// </para>
        /// </summary>
        public int? InstanceCount { get; set; }

        /// <summary>
        /// Checks to see if the InstanceCount property is set.
        /// </summary>
        internal bool IsSetInstanceCount() => this.InstanceCount.HasValue;

        /// <summary>
        /// Gets and sets the property InstanceType. 
        /// <para>
        /// The instance type.
        /// </para>
        /// </summary>
        public string InstanceType { get; set; }

        /// <summary>
        /// Checks to see if the InstanceType property is set.
        /// </summary>
        internal bool IsSetInstanceType() => this.InstanceType != null;

        /// <summary>
        /// Gets and sets the property NetworkPlatform. 
        /// <para>
        /// The network platform.
        /// </para>
        /// </summary>
        public string NetworkPlatform { get; set; }

        /// <summary>
        /// Checks to see if the NetworkPlatform property is set.
        /// </summary>
        internal bool IsSetNetworkPlatform() => this.NetworkPlatform != null;

        /// <summary>
        /// Gets and sets the property NextSlotStartTime. 
        /// <para>
        /// The time for the next schedule to start.
        /// </para>
        /// </summary>
        public DateTime? NextSlotStartTime { get; set; }

        /// <summary>
        /// Checks to see if the NextSlotStartTime property is set.
        /// </summary>
        internal bool IsSetNextSlotStartTime() => this.NextSlotStartTime.HasValue;

        /// <summary>
        /// Gets and sets the property Platform. 
        /// <para>
        /// The platform (<c>Linux/UNIX</c> or <c>Windows</c>).
        /// </para>
        /// </summary>
        public string Platform { get; set; }

        /// <summary>
        /// Checks to see if the Platform property is set.
        /// </summary>
        internal bool IsSetPlatform() => this.Platform != null;

        /// <summary>
        /// Gets and sets the property PreviousSlotEndTime. 
        /// <para>
        /// The time that the previous schedule ended or will end.
        /// </para>
        /// </summary>
        public DateTime? PreviousSlotEndTime { get; set; }

        /// <summary>
        /// Checks to see if the PreviousSlotEndTime property is set.
        /// </summary>
        internal bool IsSetPreviousSlotEndTime() => this.PreviousSlotEndTime.HasValue;

        /// <summary>
        /// Gets and sets the property Recurrence. 
        /// <para>
        /// The schedule recurrence.
        /// </para>
        /// </summary>
        public ScheduledInstanceRecurrence Recurrence { get; set; }

        /// <summary>
        /// Checks to see if the Recurrence property is set.
        /// </summary>
        internal bool IsSetRecurrence() => this.Recurrence != null;

        /// <summary>
        /// Gets and sets the property ScheduledInstanceId. 
        /// <para>
        /// The Scheduled Instance ID.
        /// </para>
        /// </summary>
        public string ScheduledInstanceId { get; set; }

        /// <summary>
        /// Checks to see if the ScheduledInstanceId property is set.
        /// </summary>
        internal bool IsSetScheduledInstanceId() => this.ScheduledInstanceId != null;

        /// <summary>
        /// Gets and sets the property SlotDurationInHours. 
        /// <para>
        /// The number of hours in the schedule.
        /// </para>
        /// </summary>
        public int? SlotDurationInHours { get; set; }

        /// <summary>
        /// Checks to see if the SlotDurationInHours property is set.
        /// </summary>
        internal bool IsSetSlotDurationInHours() => this.SlotDurationInHours.HasValue;

        /// <summary>
        /// Gets and sets the property TermEndDate. 
        /// <para>
        /// The end date for the Scheduled Instance.
        /// </para>
        /// </summary>
        public DateTime? TermEndDate { get; set; }

        /// <summary>
        /// Checks to see if the TermEndDate property is set.
        /// </summary>
        internal bool IsSetTermEndDate() => this.TermEndDate.HasValue;

        /// <summary>
        /// Gets and sets the property TermStartDate. 
        /// <para>
        /// The start date for the Scheduled Instance.
        /// </para>
        /// </summary>
        public DateTime? TermStartDate { get; set; }

        /// <summary>
        /// Checks to see if the TermStartDate property is set.
        /// </summary>
        internal bool IsSetTermStartDate() => this.TermStartDate.HasValue;

        /// <summary>
        /// Gets and sets the property TotalScheduledInstanceHours. 
        /// <para>
        /// The total number of hours for a single instance for the entire term.
        /// </para>
        /// </summary>
        public int? TotalScheduledInstanceHours { get; set; }

        /// <summary>
        /// Checks to see if the TotalScheduledInstanceHours property is set.
        /// </summary>
        internal bool IsSetTotalScheduledInstanceHours() => this.TotalScheduledInstanceHours.HasValue;
    }
}
