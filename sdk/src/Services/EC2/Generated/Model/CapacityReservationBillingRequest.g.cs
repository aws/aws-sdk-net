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
    /// Information about a request to assign billing of the unused capacity of a Capacity
    /// Reservation.
    /// </summary>
    public partial class CapacityReservationBillingRequest
    {
        /// <summary>
        /// Gets and sets the property CapacityReservationId. 
        /// <para>
        /// The ID of the Capacity Reservation.
        /// </para>
        /// </summary>
        public string CapacityReservationId { get; set; }

        /// <summary>
        /// Checks to see if the CapacityReservationId property is set.
        /// </summary>
        internal bool IsSetCapacityReservationId() => this.CapacityReservationId != null;

        /// <summary>
        /// Gets and sets the property CapacityReservationInfo. 
        /// <para>
        /// Information about the Capacity Reservation.
        /// </para>
        /// </summary>
        public CapacityReservationInfo CapacityReservationInfo { get; set; }

        /// <summary>
        /// Checks to see if the CapacityReservationInfo property is set.
        /// </summary>
        internal bool IsSetCapacityReservationInfo() => this.CapacityReservationInfo != null;

        /// <summary>
        /// Gets and sets the property LastUpdateTime. 
        /// <para>
        /// The date and time, in UTC time format, at which the request was initiated.
        /// </para>
        /// </summary>
        public DateTime? LastUpdateTime { get; set; }

        /// <summary>
        /// Checks to see if the LastUpdateTime property is set.
        /// </summary>
        internal bool IsSetLastUpdateTime() => this.LastUpdateTime.HasValue;

        /// <summary>
        /// Gets and sets the property RequestedBy. 
        /// <para>
        /// The ID of the Amazon Web Services account that initiated the request.
        /// </para>
        /// </summary>
        public string RequestedBy { get; set; }

        /// <summary>
        /// Checks to see if the RequestedBy property is set.
        /// </summary>
        internal bool IsSetRequestedBy() => this.RequestedBy != null;

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The status of the request. For more information, see <a href="https://docs.aws.amazon.com/AWSEC2/latest/UserGuide/view-billing-transfers.html">
        /// View billing assignment requests for a shared Amazon EC2 Capacity Reservation</a>.
        /// </para>
        /// </summary>
        public CapacityReservationBillingRequestStatus Status { get; set; }

        /// <summary>
        /// Checks to see if the Status property is set.
        /// </summary>
        internal bool IsSetStatus() => this.Status != null;

        /// <summary>
        /// Gets and sets the property StatusMessage. 
        /// <para>
        /// Information about the status.
        /// </para>
        /// </summary>
        public string StatusMessage { get; set; }

        /// <summary>
        /// Checks to see if the StatusMessage property is set.
        /// </summary>
        internal bool IsSetStatusMessage() => this.StatusMessage != null;

        /// <summary>
        /// Gets and sets the property UnusedReservationBillingOwnerId. 
        /// <para>
        /// The ID of the Amazon Web Services account to which the request was sent.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 12, Max = 12)]
        public string UnusedReservationBillingOwnerId { get; set; }

        /// <summary>
        /// Checks to see if the UnusedReservationBillingOwnerId property is set.
        /// </summary>
        internal bool IsSetUnusedReservationBillingOwnerId() => this.UnusedReservationBillingOwnerId != null;
    }
}
