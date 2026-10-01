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
    /// Describes the configuration that a Capacity Reservation has at the time a modification
    /// quote is generated.
    /// </summary>
    public partial class ModificationQuoteCurrentConfiguration
    {
        private int? _instanceCount;
        private DateTime? _originalStartDate;
        private string _reservationState;
        private DateTime? _startDate;

        /// <summary>
        /// Gets and sets the property InstanceCount. 
        /// <para>
        /// The number of instances in the Capacity Reservation.
        /// </para>
        /// </summary>
        public int? InstanceCount
        {
            get { return this._instanceCount; }
            set { this._instanceCount = value; }
        }

        // Check to see if InstanceCount property is set
        internal bool IsSetInstanceCount()
        {
            return this._instanceCount.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property OriginalStartDate. 
        /// <para>
        /// The start date that the Capacity Reservation was originally requested with. This value
        /// does not change when you push out the start date.
        /// </para>
        /// </summary>
        public DateTime? OriginalStartDate
        {
            get { return this._originalStartDate; }
            set { this._originalStartDate = value; }
        }

        // Check to see if OriginalStartDate property is set
        internal bool IsSetOriginalStartDate()
        {
            return this._originalStartDate.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property ReservationState. 
        /// <para>
        /// The current state of the Capacity Reservation.
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

        /// <summary>
        /// Gets and sets the property StartDate. 
        /// <para>
        /// The start date that the Capacity Reservation has before the quoted modification is
        /// applied.
        /// </para>
        /// </summary>
        public DateTime? StartDate
        {
            get { return this._startDate; }
            set { this._startDate = value; }
        }

        // Check to see if StartDate property is set
        internal bool IsSetStartDate()
        {
            return this._startDate.HasValue; 
        }

    }
}