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
    /// Describes an individual segment within a Capacity Block offering. Each segment represents
    /// a distinct block of capacity with its own Availability Zone, instance type, duration,
    /// pricing, and schedule.
    /// </summary>
    public partial class CapacityBlockOfferingSegment
    {
        /// <summary>
        /// Gets and sets the property AvailabilityZone. 
        /// <para>
        /// The Availability Zone of the Capacity Block offering segment.
        /// </para>
        /// </summary>
        public string AvailabilityZone { get; set; }

        /// <summary>
        /// Checks to see if the AvailabilityZone property is set.
        /// </summary>
        internal bool IsSetAvailabilityZone() => this.AvailabilityZone != null;

        /// <summary>
        /// Gets and sets the property AvailabilityZoneId. 
        /// <para>
        /// The ID of the Availability Zone for the Capacity Block offering segment.
        /// </para>
        /// </summary>
        public string AvailabilityZoneId { get; set; }

        /// <summary>
        /// Checks to see if the AvailabilityZoneId property is set.
        /// </summary>
        internal bool IsSetAvailabilityZoneId() => this.AvailabilityZoneId != null;

        /// <summary>
        /// Gets and sets the property CapacityBlockDurationHours. 
        /// <para>
        /// The number of hours for the duration of the Capacity Block offering segment.
        /// </para>
        /// </summary>
        public int? CapacityBlockDurationHours { get; set; }

        /// <summary>
        /// Checks to see if the CapacityBlockDurationHours property is set.
        /// </summary>
        internal bool IsSetCapacityBlockDurationHours() => this.CapacityBlockDurationHours.HasValue;

        /// <summary>
        /// Gets and sets the property CapacityBlockDurationMinutes. 
        /// <para>
        /// The number of minutes for the duration of the Capacity Block offering segment.
        /// </para>
        /// </summary>
        public int? CapacityBlockDurationMinutes { get; set; }

        /// <summary>
        /// Checks to see if the CapacityBlockDurationMinutes property is set.
        /// </summary>
        internal bool IsSetCapacityBlockDurationMinutes() => this.CapacityBlockDurationMinutes.HasValue;

        /// <summary>
        /// Gets and sets the property CurrencyCode. 
        /// <para>
        /// The currency of the payment for the Capacity Block offering segment.
        /// </para>
        /// </summary>
        public string CurrencyCode { get; set; }

        /// <summary>
        /// Checks to see if the CurrencyCode property is set.
        /// </summary>
        internal bool IsSetCurrencyCode() => this.CurrencyCode != null;

        /// <summary>
        /// Gets and sets the property EndDate. 
        /// <para>
        /// The end date of the Capacity Block offering segment.
        /// </para>
        /// </summary>
        public DateTime? EndDate { get; set; }

        /// <summary>
        /// Checks to see if the EndDate property is set.
        /// </summary>
        internal bool IsSetEndDate() => this.EndDate.HasValue;

        /// <summary>
        /// Gets and sets the property InstanceCount. 
        /// <para>
        /// The number of instances in the Capacity Block offering segment.
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
        /// The instance type of the Capacity Block offering segment.
        /// </para>
        /// </summary>
        public string InstanceType { get; set; }

        /// <summary>
        /// Checks to see if the InstanceType property is set.
        /// </summary>
        internal bool IsSetInstanceType() => this.InstanceType != null;

        /// <summary>
        /// Gets and sets the property StartDate. 
        /// <para>
        /// The start date of the Capacity Block offering segment.
        /// </para>
        /// </summary>
        public DateTime? StartDate { get; set; }

        /// <summary>
        /// Checks to see if the StartDate property is set.
        /// </summary>
        internal bool IsSetStartDate() => this.StartDate.HasValue;

        /// <summary>
        /// Gets and sets the property UpfrontFee. 
        /// <para>
        /// The total price to be paid up front for the Capacity Block offering segment.
        /// </para>
        /// </summary>
        public string UpfrontFee { get; set; }

        /// <summary>
        /// Checks to see if the UpfrontFee property is set.
        /// </summary>
        internal bool IsSetUpfrontFee() => this.UpfrontFee != null;

        /// <summary>
        /// Gets and sets the property ZoneType. 
        /// <para>
        /// The type of zone where the Capacity Block offering segment is available.
        /// </para>
        /// </summary>
        public string ZoneType { get; set; }

        /// <summary>
        /// Checks to see if the ZoneType property is set.
        /// </summary>
        internal bool IsSetZoneType() => this.ZoneType != null;
    }
}
