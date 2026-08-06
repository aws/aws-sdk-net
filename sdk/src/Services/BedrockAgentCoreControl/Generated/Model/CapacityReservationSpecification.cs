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
 * Do not modify this file. This file is generated from the bedrock-agentcore-control-2023-06-05.normal.json service model.
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
namespace Amazon.BedrockAgentCoreControl.Model
{
    /// <summary>
    /// The Capacity Reservation targeting option for the instances.
    /// </summary>
    public partial class CapacityReservationSpecification
    {
        private CapacityReservationPreference _capacityReservationPreference;
        private CapacityReservationTarget _capacityReservationTarget;

        /// <summary>
        /// Gets and sets the property CapacityReservationPreference. 
        /// <para>
        /// The Capacity Reservation preference for the instances.
        /// </para>
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
        /// The target Capacity Reservation or Capacity Reservation group for the instances.
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