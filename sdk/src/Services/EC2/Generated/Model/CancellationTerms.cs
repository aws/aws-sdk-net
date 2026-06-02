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
    /// Describes the cancellation terms for cancelling a future-dated Capacity Reservation
    /// during its commitment duration.
    /// </summary>
    public partial class CancellationTerms
    {
        private ApplyCancellationCharges _cancellationType;
        private long? _chargeCommitmentDurationHours;
        private DateTime? _chargeEndDate;
        private int? _committedInstanceCount;
        private string _reservationState;

        /// <summary>
        /// Gets and sets the property CancellationType. 
        /// <para>
        /// The type of cancellation charge. Possible values include <c>commitment-wind-down</c>.
        /// </para>
        /// </summary>
        public ApplyCancellationCharges CancellationType
        {
            get { return this._cancellationType; }
            set { this._cancellationType = value; }
        }

        // Check to see if CancellationType property is set
        internal bool IsSetCancellationType()
        {
            return this._cancellationType != null;
        }

        /// <summary>
        /// Gets and sets the property ChargeCommitmentDurationHours. 
        /// <para>
        /// The number of hours for which cancellation charges will apply.
        /// </para>
        /// </summary>
        public long? ChargeCommitmentDurationHours
        {
            get { return this._chargeCommitmentDurationHours; }
            set { this._chargeCommitmentDurationHours = value; }
        }

        // Check to see if ChargeCommitmentDurationHours property is set
        internal bool IsSetChargeCommitmentDurationHours()
        {
            return this._chargeCommitmentDurationHours.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property ChargeEndDate. 
        /// <para>
        /// The date and time at which cancellation charges will stop.
        /// </para>
        /// </summary>
        public DateTime? ChargeEndDate
        {
            get { return this._chargeEndDate; }
            set { this._chargeEndDate = value; }
        }

        // Check to see if ChargeEndDate property is set
        internal bool IsSetChargeEndDate()
        {
            return this._chargeEndDate.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property CommittedInstanceCount. 
        /// <para>
        /// The number of instances under commitment after cancellation.
        /// </para>
        /// </summary>
        public int? CommittedInstanceCount
        {
            get { return this._committedInstanceCount; }
            set { this._committedInstanceCount = value; }
        }

        // Check to see if CommittedInstanceCount property is set
        internal bool IsSetCommittedInstanceCount()
        {
            return this._committedInstanceCount.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property ReservationState. 
        /// <para>
        /// The state that the Capacity Reservation will transition to after cancellation.
        /// </para>
        /// </summary>
        public string ReservationState
        {
            get { return this._reservationState; }
            set { this._reservationState = value; }
        }

        // Check to see if ReservationState property is set
        internal bool IsSetReservationState()
        {
            return this._reservationState != null;
        }

    }
}