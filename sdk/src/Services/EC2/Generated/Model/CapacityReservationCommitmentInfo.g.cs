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
    /// Information about your commitment for a future-dated Capacity Reservation.
    /// </summary>
    public partial class CapacityReservationCommitmentInfo
    {
        /// <summary>
        /// Gets and sets the property CommitmentDuration. 
        /// <para>
        /// The commitment duration, in seconds, for the future-dated Capacity Reservation. This
        /// is the minimum duration for which you commit to having the Capacity Reservation in
        /// the <c>active</c> state in your account after it has been delivered.
        /// </para>
        /// </summary>
        public long? CommitmentDuration { get; set; }

        /// <summary>
        /// Checks to see if the CommitmentDuration property is set.
        /// </summary>
        internal bool IsSetCommitmentDuration() => this.CommitmentDuration.HasValue;

        /// <summary>
        /// Gets and sets the property CommitmentEndDate. 
        /// <para>
        /// The date and time at which the commitment duration expires, in the ISO8601 format
        /// in the UTC time zone (<c>YYYY-MM-DDThh:mm:ss.sssZ</c>). You can't decrease the instance
        /// count or cancel the Capacity Reservation before this date and time.
        /// </para>
        /// </summary>
        public DateTime? CommitmentEndDate { get; set; }

        /// <summary>
        /// Checks to see if the CommitmentEndDate property is set.
        /// </summary>
        internal bool IsSetCommitmentEndDate() => this.CommitmentEndDate.HasValue;

        /// <summary>
        /// Gets and sets the property CommittedInstanceCount. 
        /// <para>
        /// The instance capacity that you committed to when you requested the future-dated Capacity
        /// Reservation.
        /// </para>
        /// </summary>
        public int? CommittedInstanceCount { get; set; }

        /// <summary>
        /// Checks to see if the CommittedInstanceCount property is set.
        /// </summary>
        internal bool IsSetCommittedInstanceCount() => this.CommittedInstanceCount.HasValue;
    }
}
