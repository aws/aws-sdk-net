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
    /// Describes the configuration that a Capacity Reservation has at the time a modification
    /// quote is generated.
    /// </summary>
    public partial class ModificationQuoteCurrentConfiguration
    {
        /// <summary>
        /// Gets and sets the property InstanceCount. 
        /// <para>
        /// The number of instances in the Capacity Reservation.
        /// </para>
        /// </summary>
        public int? InstanceCount { get; set; }

        /// <summary>
        /// Checks to see if the InstanceCount property is set.
        /// </summary>
        internal bool IsSetInstanceCount() => this.InstanceCount.HasValue;

        /// <summary>
        /// Gets and sets the property OriginalStartDate. 
        /// <para>
        /// The start date that the Capacity Reservation was originally requested with. This value
        /// does not change when you push out the start date.
        /// </para>
        /// </summary>
        public DateTime? OriginalStartDate { get; set; }

        /// <summary>
        /// Checks to see if the OriginalStartDate property is set.
        /// </summary>
        internal bool IsSetOriginalStartDate() => this.OriginalStartDate.HasValue;

        /// <summary>
        /// Gets and sets the property ReservationState. 
        /// <para>
        /// The current state of the Capacity Reservation.
        /// </para>
        /// </summary>
        public string ReservationState { get; set; }

        /// <summary>
        /// Checks to see if the ReservationState property is set.
        /// </summary>
        internal bool IsSetReservationState() => this.ReservationState != null;

        /// <summary>
        /// Gets and sets the property StartDate. 
        /// <para>
        /// The start date that the Capacity Reservation has before the quoted modification is
        /// applied.
        /// </para>
        /// </summary>
        public DateTime? StartDate { get; set; }

        /// <summary>
        /// Checks to see if the StartDate property is set.
        /// </summary>
        internal bool IsSetStartDate() => this.StartDate.HasValue;
    }
}
