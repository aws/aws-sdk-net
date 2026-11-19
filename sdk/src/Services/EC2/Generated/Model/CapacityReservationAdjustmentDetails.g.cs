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
    /// Describes the configuration that a Capacity Reservation will have after a pending
    /// adjustment is applied.
    /// </summary>
    public partial class CapacityReservationAdjustmentDetails
    {
        /// <summary>
        /// Gets and sets the property CommitmentDuration. 
        /// <para>
        /// The commitment duration, in seconds, that the Capacity Reservation will have after
        /// the adjustment.
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
        /// The date and time at which the commitment duration will expire after the adjustment.
        /// </para>
        /// </summary>
        public DateTime? CommitmentEndDate { get; set; }

        /// <summary>
        /// Checks to see if the CommitmentEndDate property is set.
        /// </summary>
        internal bool IsSetCommitmentEndDate() => this.CommitmentEndDate.HasValue;

        /// <summary>
        /// Gets and sets the property EndDate. 
        /// <para>
        /// The end date that the Capacity Reservation will have after the adjustment.
        /// </para>
        /// </summary>
        public DateTime? EndDate { get; set; }

        /// <summary>
        /// Checks to see if the EndDate property is set.
        /// </summary>
        internal bool IsSetEndDate() => this.EndDate.HasValue;

        /// <summary>
        /// Gets and sets the property EndDateType. 
        /// <para>
        /// Indicates the way in which the Capacity Reservation will end after the adjustment.
        /// Possible values are:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>unlimited</c> - The Capacity Reservation remains active until you explicitly cancel
        /// it.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>limited</c> - The Capacity Reservation expires automatically at the date and time
        /// given by <c>endDate</c>.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public string EndDateType { get; set; }

        /// <summary>
        /// Checks to see if the EndDateType property is set.
        /// </summary>
        internal bool IsSetEndDateType() => this.EndDateType != null;

        /// <summary>
        /// Gets and sets the property StartDate. 
        /// <para>
        /// The start date that the Capacity Reservation will have after the adjustment.
        /// </para>
        /// </summary>
        public DateTime? StartDate { get; set; }

        /// <summary>
        /// Checks to see if the StartDate property is set.
        /// </summary>
        internal bool IsSetStartDate() => this.StartDate.HasValue;
    }
}
