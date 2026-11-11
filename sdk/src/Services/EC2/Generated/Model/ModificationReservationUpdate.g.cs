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
    /// Describes the changes that a Capacity Reservation modification quote will apply to
    /// a Capacity Reservation.
    /// </summary>
    public partial class ModificationReservationUpdate
    {
        /// <summary>
        /// Gets and sets the property NewCommitmentDuration. 
        /// <para>
        /// The commitment duration, in seconds, that the Capacity Reservation will have after
        /// the modification.
        /// </para>
        /// </summary>
        public int? NewCommitmentDuration { get; set; }

        /// <summary>
        /// Checks to see if the NewCommitmentDuration property is set.
        /// </summary>
        internal bool IsSetNewCommitmentDuration() => this.NewCommitmentDuration.HasValue;

        /// <summary>
        /// Gets and sets the property NewCommitmentEndDate. 
        /// <para>
        /// The date and time at which the commitment duration will expire after the modification,
        /// in the ISO8601 format in the UTC time zone (<c>YYYY-MM-DDThh:mm:ss.sssZ</c>).
        /// </para>
        /// </summary>
        public DateTime? NewCommitmentEndDate { get; set; }

        /// <summary>
        /// Checks to see if the NewCommitmentEndDate property is set.
        /// </summary>
        internal bool IsSetNewCommitmentEndDate() => this.NewCommitmentEndDate.HasValue;

        /// <summary>
        /// Gets and sets the property NewStartDate. 
        /// <para>
        /// The start date that the Capacity Reservation will have after the modification, in
        /// the ISO8601 format in the UTC time zone (<c>YYYY-MM-DDThh:mm:ss.sssZ</c>).
        /// </para>
        /// </summary>
        public DateTime? NewStartDate { get; set; }

        /// <summary>
        /// Checks to see if the NewStartDate property is set.
        /// </summary>
        internal bool IsSetNewStartDate() => this.NewStartDate.HasValue;
    }
}
