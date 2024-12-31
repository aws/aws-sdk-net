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
    /// Describes an instance's Capacity Reservation targeting option. You can specify only
    /// one option at a time. Use the <c>CapacityReservationPreference</c> parameter to configure
    /// the instance to run in On-Demand capacity or to run in any <c>open</c> Capacity Reservation
    /// that has matching attributes (instance type, platform, Availability Zone). Use the
    /// <c>CapacityReservationTarget</c> parameter to explicitly target a specific Capacity
    /// Reservation or a Capacity Reservation group.
    /// </summary>
    public partial class LaunchTemplateCapacityReservationSpecificationRequest
    {
        private CapacityReservationPreference _capacityReservationPreference;
        private CapacityReservationTarget _capacityReservationTarget;

        /// <summary>
        /// Gets and sets the property CapacityReservationPreference. 
        /// <para>
        /// Indicates the instance's Capacity Reservation preferences. Possible preferences include:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>capacity-reservations-only</c> - The instance will only run in a Capacity Reservation
        /// or Capacity Reservation group. If capacity isn't available, the instance will fail
        /// to launch.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>open</c> - The instance can run in any <c>open</c> Capacity Reservation that has
        /// matching attributes (instance type, platform, Availability Zone, tenancy).
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>none</c> - The instance avoids running in a Capacity Reservation even if one is
        /// available. The instance runs in On-Demand capacity.
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
        /// Information about the target Capacity Reservation or Capacity Reservation group.
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