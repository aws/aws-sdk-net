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
    /// Describes a schedule that is available for your Scheduled Instances.
    /// </summary>
    public partial class ScheduledInstanceAvailability
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
        /// Gets and sets the property AvailableInstanceCount. 
        /// <para>
        /// The number of available instances.
        /// </para>
        /// </summary>
        public int? AvailableInstanceCount { get; set; }

        /// <summary>
        /// Checks to see if the AvailableInstanceCount property is set.
        /// </summary>
        internal bool IsSetAvailableInstanceCount() => this.AvailableInstanceCount.HasValue;

        /// <summary>
        /// Gets and sets the property FirstSlotStartTime. 
        /// <para>
        /// The time period for the first schedule to start.
        /// </para>
        /// </summary>
        public DateTime? FirstSlotStartTime { get; set; }

        /// <summary>
        /// Checks to see if the FirstSlotStartTime property is set.
        /// </summary>
        internal bool IsSetFirstSlotStartTime() => this.FirstSlotStartTime.HasValue;

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
        /// Gets and sets the property InstanceType. 
        /// <para>
        /// The instance type. You can specify one of the C3, C4, M4, or R3 instance types.
        /// </para>
        /// </summary>
        public string InstanceType { get; set; }

        /// <summary>
        /// Checks to see if the InstanceType property is set.
        /// </summary>
        internal bool IsSetInstanceType() => this.InstanceType != null;

        /// <summary>
        /// Gets and sets the property MaxTermDurationInDays. 
        /// <para>
        /// The maximum term. The only possible value is 365 days.
        /// </para>
        /// </summary>
        public int? MaxTermDurationInDays { get; set; }

        /// <summary>
        /// Checks to see if the MaxTermDurationInDays property is set.
        /// </summary>
        internal bool IsSetMaxTermDurationInDays() => this.MaxTermDurationInDays.HasValue;

        /// <summary>
        /// Gets and sets the property MinTermDurationInDays. 
        /// <para>
        /// The minimum term. The only possible value is 365 days.
        /// </para>
        /// </summary>
        public int? MinTermDurationInDays { get; set; }

        /// <summary>
        /// Checks to see if the MinTermDurationInDays property is set.
        /// </summary>
        internal bool IsSetMinTermDurationInDays() => this.MinTermDurationInDays.HasValue;

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
        /// Gets and sets the property PurchaseToken. 
        /// <para>
        /// The purchase token. This token expires in two hours.
        /// </para>
        /// </summary>
        public string PurchaseToken { get; set; }

        /// <summary>
        /// Checks to see if the PurchaseToken property is set.
        /// </summary>
        internal bool IsSetPurchaseToken() => this.PurchaseToken != null;

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
