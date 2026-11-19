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
    /// Describes a Capacity Reservation Fleet that was successfully cancelled.
    /// </summary>
    public partial class CapacityReservationFleetCancellationState
    {
        /// <summary>
        /// Gets and sets the property CapacityReservationFleetId. 
        /// <para>
        /// The ID of the Capacity Reservation Fleet that was successfully cancelled.
        /// </para>
        /// </summary>
        public string CapacityReservationFleetId { get; set; }

        /// <summary>
        /// Checks to see if the CapacityReservationFleetId property is set.
        /// </summary>
        internal bool IsSetCapacityReservationFleetId() => this.CapacityReservationFleetId != null;

        /// <summary>
        /// Gets and sets the property CurrentFleetState. 
        /// <para>
        /// The current state of the Capacity Reservation Fleet.
        /// </para>
        /// </summary>
        public CapacityReservationFleetState CurrentFleetState { get; set; }

        /// <summary>
        /// Checks to see if the CurrentFleetState property is set.
        /// </summary>
        internal bool IsSetCurrentFleetState() => this.CurrentFleetState != null;

        /// <summary>
        /// Gets and sets the property PreviousFleetState. 
        /// <para>
        /// The previous state of the Capacity Reservation Fleet.
        /// </para>
        /// </summary>
        public CapacityReservationFleetState PreviousFleetState { get; set; }

        /// <summary>
        /// Checks to see if the PreviousFleetState property is set.
        /// </summary>
        internal bool IsSetPreviousFleetState() => this.PreviousFleetState != null;
    }
}
