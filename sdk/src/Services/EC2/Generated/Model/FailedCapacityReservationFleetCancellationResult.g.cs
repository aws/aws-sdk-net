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
    /// Describes a Capacity Reservation Fleet that could not be cancelled.
    /// </summary>
    public partial class FailedCapacityReservationFleetCancellationResult
    {
        /// <summary>
        /// Gets and sets the property CancelCapacityReservationFleetError. 
        /// <para>
        /// Information about the Capacity Reservation Fleet cancellation error.
        /// </para>
        /// </summary>
        public CancelCapacityReservationFleetError CancelCapacityReservationFleetError { get; set; }

        /// <summary>
        /// Checks to see if the CancelCapacityReservationFleetError property is set.
        /// </summary>
        internal bool IsSetCancelCapacityReservationFleetError() => this.CancelCapacityReservationFleetError != null;

        /// <summary>
        /// Gets and sets the property CapacityReservationFleetId. 
        /// <para>
        /// The ID of the Capacity Reservation Fleet that could not be cancelled.
        /// </para>
        /// </summary>
        public string CapacityReservationFleetId { get; set; }

        /// <summary>
        /// Checks to see if the CapacityReservationFleetId property is set.
        /// </summary>
        internal bool IsSetCapacityReservationFleetId() => this.CapacityReservationFleetId != null;
    }
}
