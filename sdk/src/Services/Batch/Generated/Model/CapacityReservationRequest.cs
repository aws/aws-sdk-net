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
 * Do not modify this file. This file is generated from the batch-2016-08-10.normal.json service model.
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
namespace Amazon.Batch.Model
{
    /// <summary>
    /// The capacity reservation configuration for Amazon ECS Managed Instances. Use this
    /// to target On-Demand Capacity Reservations or Reserved Instances.
    /// </summary>
    public partial class CapacityReservationRequest
    {
        private string _reservationGroupArn;
        private string _reservationPreference;

        /// <summary>
        /// Gets and sets the property ReservationGroupArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the capacity reservation group to target.
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
        /// The capacity reservation preference. Valid values:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>RESERVATIONS_ONLY</c> — Use only capacity reservations.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>RESERVATIONS_FIRST</c> — Prefer capacity reservations but fall back to On-Demand
        /// if unavailable.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>RESERVATIONS_EXCLUDED</c> — Do not use capacity reservations.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public string ReservationPreference
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