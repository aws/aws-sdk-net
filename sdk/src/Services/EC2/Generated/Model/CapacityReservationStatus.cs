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
    /// Describes the availability of capacity for a Capacity Reservation.
    /// </summary>
    public partial class CapacityReservationStatus
    {
        private string _capacityReservationId;
        private int? _totalAvailableCapacity;
        private int? _totalCapacity;
        private int? _totalUnavailableCapacity;

        /// <summary>
        /// Gets and sets the property CapacityReservationId. 
        /// <para>
        /// The ID of the Capacity Reservation.
        /// </para>
        /// </summary>
        public string CapacityReservationId
        {
            get { return this._capacityReservationId; }
            set { this._capacityReservationId = value; }
        }

        // Check to see if CapacityReservationId property is set
        internal bool IsSetCapacityReservationId()
        {
            return this._capacityReservationId != null;
        }

        /// <summary>
        /// Gets and sets the property TotalAvailableCapacity. 
        /// <para>
        /// The remaining capacity. Indicates the amount of resources that can be launched into
        /// the Capacity Reservation.
        /// </para>
        /// </summary>
        public int? TotalAvailableCapacity
        {
            get { return this._totalAvailableCapacity; }
            set { this._totalAvailableCapacity = value; }
        }

        // Check to see if TotalAvailableCapacity property is set
        internal bool IsSetTotalAvailableCapacity()
        {
            return this._totalAvailableCapacity.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property TotalCapacity. 
        /// <para>
        /// The combined amount of <c>Available</c> and <c>Unavailable</c> capacity in the Capacity
        /// Reservation.
        /// </para>
        /// </summary>
        public int? TotalCapacity
        {
            get { return this._totalCapacity; }
            set { this._totalCapacity = value; }
        }

        // Check to see if TotalCapacity property is set
        internal bool IsSetTotalCapacity()
        {
            return this._totalCapacity.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property TotalUnavailableCapacity. 
        /// <para>
        /// The used capacity. Indicates that the capacity is in use by resources that are running
        /// in the Capacity Reservation.
        /// </para>
        /// </summary>
        public int? TotalUnavailableCapacity
        {
            get { return this._totalUnavailableCapacity; }
            set { this._totalUnavailableCapacity = value; }
        }

        // Check to see if TotalUnavailableCapacity property is set
        internal bool IsSetTotalUnavailableCapacity()
        {
            return this._totalUnavailableCapacity.HasValue; 
        }

    }
}