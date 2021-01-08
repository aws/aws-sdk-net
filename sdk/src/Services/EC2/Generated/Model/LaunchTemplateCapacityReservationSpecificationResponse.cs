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
    /// Information about the Capacity Reservation targeting option.
    /// </summary>
    public partial class LaunchTemplateCapacityReservationSpecificationResponse
    {
        private CapacityReservationPreference _capacityReservationPreference;
        private CapacityReservationTargetResponse _capacityReservationTarget;

        /// <summary>
        /// Gets and sets the property CapacityReservationPreference. 
        /// <para>
        /// Indicates the instance's Capacity Reservation preferences. Possible preferences include:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <code>open</code> - The instance can run in any <code>open</code> Capacity Reservation
        /// that has matching attributes (instance type, platform, Availability Zone).
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>none</code> - The instance avoids running in a Capacity Reservation even if
        /// one is available. The instance runs in On-Demand capacity.
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
        public CapacityReservationTargetResponse CapacityReservationTarget
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