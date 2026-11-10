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
    /// The recommended Capacity Block extension that fits your search requirements.
    /// </summary>
    public partial class CapacityBlockExtensionOffering
    {
        /// <summary>
        /// Gets and sets the property AvailabilityZone. 
        /// <para>
        /// The Availability Zone of the Capacity Block that will be extended.
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
        /// The Availability Zone ID of the Capacity Block that will be extended.
        /// </para>
        /// </summary>
        public string AvailabilityZoneId { get; set; }

        /// <summary>
        /// Checks to see if the AvailabilityZoneId property is set.
        /// </summary>
        internal bool IsSetAvailabilityZoneId() => this.AvailabilityZoneId != null;

        /// <summary>
        /// Gets and sets the property CapacityBlockExtensionDurationHours. 
        /// <para>
        /// The amount of time of the Capacity Block extension offering in hours.
        /// </para>
        /// </summary>
        public int? CapacityBlockExtensionDurationHours { get; set; }

        /// <summary>
        /// Checks to see if the CapacityBlockExtensionDurationHours property is set.
        /// </summary>
        internal bool IsSetCapacityBlockExtensionDurationHours() => this.CapacityBlockExtensionDurationHours.HasValue;

        /// <summary>
        /// Gets and sets the property CapacityBlockExtensionEndDate. 
        /// <para>
        /// The date and time at which the Capacity Block extension expires. When a Capacity Block
        /// expires, the reserved capacity is released and you can no longer launch instances
        /// into it. The Capacity Block's state changes to <c>expired</c> when it reaches its
        /// end date
        /// </para>
        /// </summary>
        public DateTime? CapacityBlockExtensionEndDate { get; set; }

        /// <summary>
        /// Checks to see if the CapacityBlockExtensionEndDate property is set.
        /// </summary>
        internal bool IsSetCapacityBlockExtensionEndDate() => this.CapacityBlockExtensionEndDate.HasValue;

        /// <summary>
        /// Gets and sets the property CapacityBlockExtensionOfferingId. 
        /// <para>
        /// The ID of the Capacity Block extension offering.
        /// </para>
        /// </summary>
        public string CapacityBlockExtensionOfferingId { get; set; }

        /// <summary>
        /// Checks to see if the CapacityBlockExtensionOfferingId property is set.
        /// </summary>
        internal bool IsSetCapacityBlockExtensionOfferingId() => this.CapacityBlockExtensionOfferingId != null;

        /// <summary>
        /// Gets and sets the property CapacityBlockExtensionStartDate. 
        /// <para>
        /// The date and time at which the Capacity Block extension will start. This date is also
        /// the same as the end date of the Capacity Block that will be extended.
        /// </para>
        /// </summary>
        public DateTime? CapacityBlockExtensionStartDate { get; set; }

        /// <summary>
        /// Checks to see if the CapacityBlockExtensionStartDate property is set.
        /// </summary>
        internal bool IsSetCapacityBlockExtensionStartDate() => this.CapacityBlockExtensionStartDate.HasValue;

        /// <summary>
        /// Gets and sets the property CurrencyCode. 
        /// <para>
        /// The currency of the payment for the Capacity Block extension offering.
        /// </para>
        /// </summary>
        public string CurrencyCode { get; set; }

        /// <summary>
        /// Checks to see if the CurrencyCode property is set.
        /// </summary>
        internal bool IsSetCurrencyCode() => this.CurrencyCode != null;

        /// <summary>
        /// Gets and sets the property InstanceCount. 
        /// <para>
        /// The number of instances in the Capacity Block extension offering.
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
        /// The instance type of the Capacity Block that will be extended.
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
        /// The start date of the Capacity Block that will be extended.
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
        public CapacityReservationTenancy Tenancy { get; set; }

        /// <summary>
        /// Checks to see if the Tenancy property is set.
        /// </summary>
        internal bool IsSetTenancy() => this.Tenancy != null;

        /// <summary>
        /// Gets and sets the property UpfrontFee. 
        /// <para>
        /// The total price of the Capacity Block extension offering, to be paid up front.
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
        /// The type of zone where the Capacity Block extension offering is available.
        /// </para>
        /// </summary>
        public string ZoneType { get; set; }

        /// <summary>
        /// Checks to see if the ZoneType property is set.
        /// </summary>
        internal bool IsSetZoneType() => this.ZoneType != null;
    }
}
