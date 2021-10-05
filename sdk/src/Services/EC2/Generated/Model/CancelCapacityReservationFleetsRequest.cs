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

namespace Amazon.EC2.Model
{
    /// <summary>
    /// Container for the parameters to the CancelCapacityReservationFleets operation.
    /// Cancels one or more Capacity Reservation Fleets. When you cancel a Capacity Reservation
    /// Fleet, the following happens:
    /// 
    ///  <ul> <li> 
    /// <para>
    /// The Capacity Reservation Fleet's status changes to <code>cancelled</code>.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// The individual Capacity Reservations in the Fleet are cancelled. Instances running
    /// in the Capacity Reservations at the time of cancelling the Fleet continue to run in
    /// shared capacity.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// The Fleet stops creating new Capacity Reservations.
    /// </para>
    ///  </li> </ul>
    /// </summary>
    public partial class CancelCapacityReservationFleetsRequest : AmazonEC2Request
    {
        private List<string> _capacityReservationFleetIds = new List<string>();

        /// <summary>
        /// Gets and sets the property CapacityReservationFleetIds. 
        /// <para>
        /// The IDs of the Capacity Reservation Fleets to cancel.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public List<string> CapacityReservationFleetIds
        {
            get { return this._capacityReservationFleetIds; }
            set { this._capacityReservationFleetIds = value; }
        }

        // Check to see if CapacityReservationFleetIds property is set
        internal bool IsSetCapacityReservationFleetIds()
        {
            return this._capacityReservationFleetIds != null && this._capacityReservationFleetIds.Count > 0; 
        }

    }
}