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
    /// Container for the parameters to the AssociateCapacityReservationBillingOwner operation.
    /// Initiates a request to assign billing of the unused capacity of a shared Capacity
    /// Reservation to a consumer account that is consolidated under the same Amazon Web Services
    /// organizations payer account. For more information, see <a href="https://docs.aws.amazon.com/AWSEC2/latest/UserGuide/assign-billing.html">Billing
    /// assignment for shared Amazon EC2 Capacity Reservations</a>.
    /// </summary>
    public partial class AssociateCapacityReservationBillingOwnerRequest : AmazonEC2Request
    {
        private string _capacityReservationId;
        private string _unusedReservationBillingOwnerId;

        /// <summary>
        /// Gets and sets the property CapacityReservationId. 
        /// <para>
        /// The ID of the Capacity Reservation.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
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
        /// Gets and sets the property UnusedReservationBillingOwnerId. 
        /// <para>
        /// The ID of the consumer account to which to assign billing.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=12, Max=12)]
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