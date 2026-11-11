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
    /// Describes the cancellation terms for cancelling a future-dated Capacity Reservation
    /// during its commitment duration.
    /// </summary>
    public partial class CancellationTerms
    {
        /// <summary>
        /// Gets and sets the property CancellationType. 
        /// <para>
        /// The type of cancellation charge. Possible values include <c>commitment-wind-down</c>.
        /// </para>
        /// </summary>
        public ApplyCancellationCharges CancellationType { get; set; }

        /// <summary>
        /// Checks to see if the CancellationType property is set.
        /// </summary>
        internal bool IsSetCancellationType() => this.CancellationType != null;

        /// <summary>
        /// Gets and sets the property ChargeCommitmentDurationHours. 
        /// <para>
        /// The number of hours for which cancellation charges will apply.
        /// </para>
        /// </summary>
        public long? ChargeCommitmentDurationHours { get; set; }

        /// <summary>
        /// Checks to see if the ChargeCommitmentDurationHours property is set.
        /// </summary>
        internal bool IsSetChargeCommitmentDurationHours() => this.ChargeCommitmentDurationHours.HasValue;

        /// <summary>
        /// Gets and sets the property ChargeEndDate. 
        /// <para>
        /// The date and time at which cancellation charges will stop.
        /// </para>
        /// </summary>
        public DateTime? ChargeEndDate { get; set; }

        /// <summary>
        /// Checks to see if the ChargeEndDate property is set.
        /// </summary>
        internal bool IsSetChargeEndDate() => this.ChargeEndDate.HasValue;

        /// <summary>
        /// Gets and sets the property CommittedInstanceCount. 
        /// <para>
        /// The number of instances under commitment after cancellation.
        /// </para>
        /// </summary>
        public int? CommittedInstanceCount { get; set; }

        /// <summary>
        /// Checks to see if the CommittedInstanceCount property is set.
        /// </summary>
        internal bool IsSetCommittedInstanceCount() => this.CommittedInstanceCount.HasValue;

        /// <summary>
        /// Gets and sets the property ReservationState. 
        /// <para>
        /// The state that the Capacity Reservation will transition to after cancellation.
        /// </para>
        /// </summary>
        public string ReservationState { get; set; }

        /// <summary>
        /// Checks to see if the ReservationState property is set.
        /// </summary>
        internal bool IsSetReservationState() => this.ReservationState != null;
    }
}
