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
    /// Describes a Capacity Block extension. With an extension, you can extend the duration
    /// of time for an existing Capacity Block.
    /// </summary>
    public partial class CapacityBlockExtension
    {
        /// <summary>
        /// Gets and sets the property AvailabilityZone. 
        /// <para>
        /// The Availability Zone of the Capacity Block extension.
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
        /// The Availability Zone ID of the Capacity Block extension.
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
        /// The duration of the Capacity Block extension in hours.
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
        /// The end date of the Capacity Block extension.
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
        /// Gets and sets the property CapacityBlockExtensionPurchaseDate. 
        /// <para>
        /// The date when the Capacity Block extension was purchased.
        /// </para>
        /// </summary>
        public DateTime? CapacityBlockExtensionPurchaseDate { get; set; }

        /// <summary>
        /// Checks to see if the CapacityBlockExtensionPurchaseDate property is set.
        /// </summary>
        internal bool IsSetCapacityBlockExtensionPurchaseDate() => this.CapacityBlockExtensionPurchaseDate.HasValue;

        /// <summary>
        /// Gets and sets the property CapacityBlockExtensionStartDate. 
        /// <para>
        /// The start date of the Capacity Block extension.
        /// </para>
        /// </summary>
        public DateTime? CapacityBlockExtensionStartDate { get; set; }

        /// <summary>
        /// Checks to see if the CapacityBlockExtensionStartDate property is set.
        /// </summary>
        internal bool IsSetCapacityBlockExtensionStartDate() => this.CapacityBlockExtensionStartDate.HasValue;

        /// <summary>
        /// Gets and sets the property CapacityBlockExtensionStatus. 
        /// <para>
        /// The status of the Capacity Block extension. A Capacity Block extension can have one
        /// of the following statuses:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>payment-pending</c> - The Capacity Block extension payment is processing. If your
        /// payment can't be processed within 12 hours, the Capacity Block extension is failed.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>payment-failed</c> - Payment for the Capacity Block extension request was not
        /// successful.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>payment-succeeded</c> - Payment for the Capacity Block extension request was successful.
        /// You receive an invoice that reflects the one-time upfront payment. In the invoice,
        /// you can associate the paid amount with the Capacity Block reservation ID.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public CapacityBlockExtensionStatus CapacityBlockExtensionStatus { get; set; }

        /// <summary>
        /// Checks to see if the CapacityBlockExtensionStatus property is set.
        /// </summary>
        internal bool IsSetCapacityBlockExtensionStatus() => this.CapacityBlockExtensionStatus != null;

        /// <summary>
        /// Gets and sets the property CapacityReservationId. 
        /// <para>
        /// The reservation ID of the Capacity Block extension.
        /// </para>
        /// </summary>
        public string CapacityReservationId { get; set; }

        /// <summary>
        /// Checks to see if the CapacityReservationId property is set.
        /// </summary>
        internal bool IsSetCapacityReservationId() => this.CapacityReservationId != null;

        /// <summary>
        /// Gets and sets the property CurrencyCode. 
        /// <para>
        /// The currency of the payment for the Capacity Block extension.
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
        /// The number of instances in the Capacity Block extension.
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
        /// The instance type of the Capacity Block extension.
        /// </para>
        /// </summary>
        public string InstanceType { get; set; }

        /// <summary>
        /// Checks to see if the InstanceType property is set.
        /// </summary>
        internal bool IsSetInstanceType() => this.InstanceType != null;

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
        /// The type of zone where the Capacity Block extension is located.
        /// </para>
        /// </summary>
        public string ZoneType { get; set; }

        /// <summary>
        /// Checks to see if the ZoneType property is set.
        /// </summary>
        internal bool IsSetZoneType() => this.ZoneType != null;
    }
}
