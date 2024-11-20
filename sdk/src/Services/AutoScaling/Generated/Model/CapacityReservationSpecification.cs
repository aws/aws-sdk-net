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
 * Do not modify this file. This file is generated from the autoscaling-2011-01-01.normal.json service model.
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
namespace Amazon.AutoScaling.Model
{
    /// <summary>
    /// Describes the Capacity Reservation preference and targeting options. If you specify
    /// <c>open</c> or <c>none</c> for <c>CapacityReservationPreference</c>, do not specify
    /// a <c>CapacityReservationTarget</c>.
    /// </summary>
    public partial class CapacityReservationSpecification
    {
        private CapacityReservationPreference _capacityReservationPreference;
        private CapacityReservationTarget _capacityReservationTarget;

        /// <summary>
        /// Gets and sets the property CapacityReservationPreference. 
        /// <para>
        ///  The capacity reservation preference. The following options are available: 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>capacity-reservations-only</c> - Auto Scaling will only launch instances into
        /// a Capacity Reservation or Capacity Reservation resource group. If capacity isn't available,
        /// instances will fail to launch.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>capacity-reservations-first</c> - Auto Scaling will try to launch instances into
        /// a Capacity Reservation or Capacity Reservation resource group first. If capacity isn't
        /// available, instances will run in On-Demand capacity.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>none</c> - Auto Scaling will not launch instances into a Capacity Reservation.
        /// Instances will run in On-Demand capacity. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>default</c> - Auto Scaling uses the Capacity Reservation preference from your
        /// launch template or an open Capacity Reservation.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public CapacityReservationPreference CapacityReservationPreference
        {
            get { return this._capacityReservationPreference; }
            set { this._capacityReservationPreference = value; }
        }

        // Check to see if CapacityReservationPreference property is set
        internal bool IsSetCapacityReservationPreference()
        {
            return this._capacityReservationPreference != null;
        }

        /// <summary>
        /// Gets and sets the property CapacityReservationTarget. 
        /// <para>
        ///  Describes a target Capacity Reservation or Capacity Reservation resource group. 
        /// </para>
        /// </summary>
        public CapacityReservationTarget CapacityReservationTarget
        {
            get { return this._capacityReservationTarget; }
            set { this._capacityReservationTarget = value; }
        }

        // Check to see if CapacityReservationTarget property is set
        internal bool IsSetCapacityReservationTarget()
        {
            return this._capacityReservationTarget != null;
        }

    }
}