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
 * Do not modify this file. This file is generated from the ecs-2014-11-13.normal.json service model.
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
namespace Amazon.ECS.Model
{
    /// <summary>
    /// The Capacity Reservation configurations to be used when using the <c>RESERVED</c>
    /// capacity option type.
    /// </summary>
    public partial class CapacityReservationRequest
    {
        private string _reservationGroupArn;
        private CapacityReservationPreference _reservationPreference;

        /// <summary>
        /// Gets and sets the property ReservationGroupArn. 
        /// <para>
        /// The ARN of the Capacity Reservation resource group in which to run the instance.
        /// </para>
        /// </summary>
        public string ReservationGroupArn
        {
            get { return this._reservationGroupArn; }
            set { this._reservationGroupArn = value; }
        }

        // Check to see if ReservationGroupArn property is set
        internal bool IsSetReservationGroupArn()
        {
            return this._reservationGroupArn != null;
        }

        /// <summary>
        /// Gets and sets the property ReservationPreference. 
        /// <para>
        /// The preference on when capacity reservations should be used.
        /// </para>
        ///  
        /// <para>
        /// Valid values are:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>RESERVATIONS_ONLY</c> - Exclusively launch instances into capacity reservations
        /// that match the instance requirements configured for the capacity provider. If none
        /// exist, instances will fail to provision.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>RESERVATIONS_FIRST</c> - Prefer to launch instances into a capacity reservation
        /// if any exist that match the instance requirements configured for the capacity provider.
        /// If none exist, fall back to launching instances On-Demand.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>RESERVATIONS_EXCLUDED</c> - Avoid using capacity reservations and launch exclusively
        /// On-Demand.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public CapacityReservationPreference ReservationPreference
        {
            get { return this._reservationPreference; }
            set { this._reservationPreference = value; }
        }

        // Check to see if ReservationPreference property is set
        internal bool IsSetReservationPreference()
        {
            return this._reservationPreference != null;
        }

    }
}