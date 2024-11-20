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
    /// Information about a request to assign billing of the unused capacity of a Capacity
    /// Reservation.
    /// </summary>
    public partial class CapacityReservationBillingRequest
    {
        private string _capacityReservationId;
        private CapacityReservationInfo _capacityReservationInfo;
        private DateTime? _lastUpdateTime;
        private string _requestedBy;
        private CapacityReservationBillingRequestStatus _status;
        private string _statusMessage;
        private string _unusedReservationBillingOwnerId;

        /// <summary>
        /// Gets and sets the property CapacityReservationId. 
        /// <para>
        /// The ID of the Capacity Reservation.
        /// </para>
        /// </summary>
        public string CapacityReservationId
        {
            get { return this._capacityReservationId; }
            set { this._capacityReservationId = value; }
        }

        // Check to see if CapacityReservationId property is set
        internal bool IsSetCapacityReservationId()
        {
            return this._capacityReservationId != null;
        }

        /// <summary>
        /// Gets and sets the property CapacityReservationInfo. 
        /// <para>
        /// Information about the Capacity Reservation.
        /// </para>
        /// </summary>
        public CapacityReservationInfo CapacityReservationInfo
        {
            get { return this._capacityReservationInfo; }
            set { this._capacityReservationInfo = value; }
        }

        // Check to see if CapacityReservationInfo property is set
        internal bool IsSetCapacityReservationInfo()
        {
            return this._capacityReservationInfo != null;
        }

        /// <summary>
        /// Gets and sets the property LastUpdateTime. 
        /// <para>
        /// The date and time, in UTC time format, at which the request was initiated.
        /// </para>
        /// </summary>
        public DateTime? LastUpdateTime
        {
            get { return this._lastUpdateTime; }
            set { this._lastUpdateTime = value; }
        }

        // Check to see if LastUpdateTime property is set
        internal bool IsSetLastUpdateTime()
        {
            return this._lastUpdateTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property RequestedBy. 
        /// <para>
        /// The ID of the Amazon Web Services account that initiated the request.
        /// </para>
        /// </summary>
        public string RequestedBy
        {
            get { return this._requestedBy; }
            set { this._requestedBy = value; }
        }

        // Check to see if RequestedBy property is set
        internal bool IsSetRequestedBy()
        {
            return this._requestedBy != null;
        }

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The status of the request. For more information, see <a href="https://docs.aws.amazon.com/AWSEC2/latest/UserGuide/view-billing-transfers.html">
        /// View billing assignment requests for a shared Amazon EC2 Capacity Reservation</a>.
        /// </para>
        /// </summary>
        public CapacityReservationBillingRequestStatus Status
        {
            get { return this._status; }
            set { this._status = value; }
        }

        // Check to see if Status property is set
        internal bool IsSetStatus()
        {
            return this._status != null;
        }

        /// <summary>
        /// Gets and sets the property StatusMessage. 
        /// <para>
        /// Information about the status.
        /// </para>
        /// </summary>
        public string StatusMessage
        {
            get { return this._statusMessage; }
            set { this._statusMessage = value; }
        }

        // Check to see if StatusMessage property is set
        internal bool IsSetStatusMessage()
        {
            return this._statusMessage != null;
        }

        /// <summary>
        /// Gets and sets the property UnusedReservationBillingOwnerId. 
        /// <para>
        /// The ID of the Amazon Web Services account to which the request was sent.
        /// </para>
        /// </summary>
        [AWSProperty(Min=12, Max=12)]
        public string UnusedReservationBillingOwnerId
        {
            get { return this._unusedReservationBillingOwnerId; }
            set { this._unusedReservationBillingOwnerId = value; }
        }

        // Check to see if UnusedReservationBillingOwnerId property is set
        internal bool IsSetUnusedReservationBillingOwnerId()
        {
            return this._unusedReservationBillingOwnerId != null;
        }

    }
}