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
    /// Describes the availability of capacity for a Capacity Block.
    /// </summary>
    public partial class CapacityBlockStatus
    {
        private string _capacityBlockId;
        private List<CapacityReservationStatus> _capacityReservationStatuses = AWSConfigs.InitializeCollections ? new List<CapacityReservationStatus>() : null;
        private CapacityBlockInterconnectStatus _interconnectStatus;
        private int? _totalAvailableCapacity;
        private int? _totalCapacity;
        private int? _totalUnavailableCapacity;

        /// <summary>
        /// Gets and sets the property CapacityBlockId. 
        /// <para>
        /// The ID of the Capacity Block.
        /// </para>
        /// </summary>
        public string CapacityBlockId
        {
            get { return this._capacityBlockId; }
            set { this._capacityBlockId = value; }
        }

        // Check to see if CapacityBlockId property is set
        internal bool IsSetCapacityBlockId()
        {
            return this._capacityBlockId != null;
        }

        /// <summary>
        /// Gets and sets the property CapacityReservationStatuses. 
        /// <para>
        /// The availability of capacity for the Capacity Block reservations.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<CapacityReservationStatus> CapacityReservationStatuses
        {
            get { return this._capacityReservationStatuses; }
            set { this._capacityReservationStatuses = value; }
        }

        // Check to see if CapacityReservationStatuses property is set
        internal bool IsSetCapacityReservationStatuses()
        {
            return this._capacityReservationStatuses != null && (this._capacityReservationStatuses.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property InterconnectStatus. 
        /// <para>
        /// The status of the high-bandwidth accelerator interconnect. Possible states include:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>ok</c> the accelerator interconnect is healthy.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>impaired</c> - accelerator interconnect communication is impaired.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>insufficient-data</c> - insufficient data to determine accelerator interconnect
        /// status.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public CapacityBlockInterconnectStatus InterconnectStatus
        {
            get { return this._interconnectStatus; }
            set { this._interconnectStatus = value; }
        }

        // Check to see if InterconnectStatus property is set
        internal bool IsSetInterconnectStatus()
        {
            return this._interconnectStatus != null;
        }

        /// <summary>
        /// Gets and sets the property TotalAvailableCapacity. 
        /// <para>
        /// The remaining capacity. Indicates the number of resources that can be launched into
        /// the Capacity Block.
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
        /// Block.
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
        /// The unavailable capacity. Indicates the instance capacity that is unavailable for
        /// use due to a system status check failure.
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