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
    /// The recommended Capacity Block that fits your search requirements.
    /// </summary>
    public partial class CapacityBlockOffering
    {
        /// <summary>
        /// Gets and sets the property AvailabilityZone. 
        /// <para>
        /// The Availability Zone of the Capacity Block offering.
        /// </para>
        /// </summary>
        public string AvailabilityZone { get; set; }

        /// <summary>
        /// Checks to see if the AvailabilityZone property is set.
        /// </summary>
        internal bool IsSetAvailabilityZone() => this.AvailabilityZone != null;

        /// <summary>
        /// Gets and sets the property CapacityBlockDurationHours. 
        /// <para>
        /// The number of hours (in addition to <c>capacityBlockDurationMinutes</c>) for the duration
        /// of the Capacity Block reservation. For example, if a Capacity Block starts at <b>04:55</b>
        /// and ends at <b>11:30</b>, the hours field would be <b>6</b>.
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
        /// The number of minutes (in addition to <c>capacityBlockDurationHours</c>) for the duration
        /// of the Capacity Block reservation. For example, if a Capacity Block starts at <b>08:55</b>
        /// and ends at <b>11:30</b>, the minutes field would be <b>35</b>.
        /// </para>
        /// </summary>
        public int? CapacityBlockDurationMinutes { get; set; }

        /// <summary>
        /// Checks to see if the CapacityBlockDurationMinutes property is set.
        /// </summary>
        internal bool IsSetCapacityBlockDurationMinutes() => this.CapacityBlockDurationMinutes.HasValue;

        /// <summary>
        /// Gets and sets the property CapacityBlockOfferingId. 
        /// <para>
        /// The ID of the Capacity Block offering.
        /// </para>
        /// </summary>
        public string CapacityBlockOfferingId { get; set; }

        /// <summary>
        /// Checks to see if the CapacityBlockOfferingId property is set.
        /// </summary>
        internal bool IsSetCapacityBlockOfferingId() => this.CapacityBlockOfferingId != null;

        /// <summary>
        /// Gets and sets the property CurrencyCode. 
        /// <para>
        /// The currency of the payment for the Capacity Block.
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
        /// The end date of the Capacity Block offering.
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
        /// The number of instances in the Capacity Block offering.
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
        /// The instance type of the Capacity Block offering.
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
        /// The start date of the Capacity Block offering.
        /// </para>
        /// </summary>
        public DateTime? StartDate { get; set; }

        /// <summary>
        /// Checks to see if the StartDate property is set.
        /// </summary>
        internal bool IsSetStartDate() => this.StartDate.HasValue;

        /// <summary>
        /// Gets and sets the property Tenancy. 
        /// <para>
        /// The tenancy of the Capacity Block.
        /// </para>
        /// </summary>
        public CapacityReservationTenancy Tenancy { get; set; }

        /// <summary>
        /// Checks to see if the Tenancy property is set.
        /// </summary>
        internal bool IsSetTenancy() => this.Tenancy != null;

        /// <summary>
        /// Gets and sets the property UltraserverCount. 
        /// <para>
        /// The number of EC2 UltraServers in the offering.
        /// </para>
        /// </summary>
        public int? UltraserverCount { get; set; }

        /// <summary>
        /// Checks to see if the UltraserverCount property is set.
        /// </summary>
        internal bool IsSetUltraserverCount() => this.UltraserverCount.HasValue;

        /// <summary>
        /// Gets and sets the property UltraserverType. 
        /// <para>
        /// The EC2 UltraServer type of the Capacity Block offering.
        /// </para>
        /// </summary>
        public string UltraserverType { get; set; }

        /// <summary>
        /// Checks to see if the UltraserverType property is set.
        /// </summary>
        internal bool IsSetUltraserverType() => this.UltraserverType != null;

        /// <summary>
        /// Gets and sets the property UpfrontFee. 
        /// <para>
        /// The total price to be paid up front.
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
        /// The type of zone where the Capacity Block offering is available.
        /// </para>
        /// </summary>
        public string ZoneType { get; set; }

        /// <summary>
        /// Checks to see if the ZoneType property is set.
        /// </summary>
        internal bool IsSetZoneType() => this.ZoneType != null;
    }
}
