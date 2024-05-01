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
    /// Describes a Capacity Reservation Fleet that could not be cancelled.
    /// </summary>
    public partial class FailedCapacityReservationFleetCancellationResult
    {
        private CancelCapacityReservationFleetError _cancelCapacityReservationFleetError;
        private string _capacityReservationFleetId;

        /// <summary>
        /// Gets and sets the property CancelCapacityReservationFleetError. 
        /// <para>
        /// Information about the Capacity Reservation Fleet cancellation error.
        /// </para>
        /// </summary>
        public CancelCapacityReservationFleetError CancelCapacityReservationFleetError
        {
            get { return this._cancelCapacityReservationFleetError; }
            set { this._cancelCapacityReservationFleetError = value; }
        }

        // Check to see if CancelCapacityReservationFleetError property is set
        internal bool IsSetCancelCapacityReservationFleetError()
        {
            return this._cancelCapacityReservationFleetError != null;
        }

        /// <summary>
        /// Gets and sets the property CapacityReservationFleetId. 
        /// <para>
        /// The ID of the Capacity Reservation Fleet that could not be cancelled.
        /// </para>
        /// </summary>
        public string CapacityReservationFleetId
        {
            get { return this._capacityReservationFleetId; }
            set { this._capacityReservationFleetId = value; }
        }

        // Check to see if CapacityReservationFleetId property is set
        internal bool IsSetCapacityReservationFleetId()
        {
            return this._capacityReservationFleetId != null;
        }

    }
}