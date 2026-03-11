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
    /// Information about the Capacity Reservation topology.
    /// </summary>
    public partial class CapacityReservationTopology
    {
        private string _availabilityZone;
        private string _availabilityZoneId;
        private string _capacityBlockId;
        private string _capacityReservationId;
        private string _groupName;
        private string _instanceType;
        private List<string> _networkNodes = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private string _state;

        /// <summary>
        /// Gets and sets the property AvailabilityZone. 
        /// <para>
        /// The name of the Availability Zone or Local Zone that the Capacity Reservation is in.
        /// </para>
        /// </summary>
        public string AvailabilityZone
        {
            get { return this._availabilityZone; }
            set { this._availabilityZone = value; }
        }

        // Check to see if AvailabilityZone property is set
        internal bool IsSetAvailabilityZone()
        {
            return this._availabilityZone != null;
        }

        /// <summary>
        /// Gets and sets the property AvailabilityZoneId. 
        /// <para>
        /// The ID of the Availability Zone or Local Zone that the Capacity Reservation is in.
        /// </para>
        /// </summary>
        public string AvailabilityZoneId
        {
            get { return this._availabilityZoneId; }
            set { this._availabilityZoneId = value; }
        }

        // Check to see if AvailabilityZoneId property is set
        internal bool IsSetAvailabilityZoneId()
        {
            return this._availabilityZoneId != null;
        }

        /// <summary>
        /// Gets and sets the property CapacityBlockId. 
        /// <para>
        /// The ID of the Capacity Block. This parameter is only supported for UltraServer instances
        /// and identifies instances within the UltraServer domain.
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
        /// Gets and sets the property GroupName. 
        /// <para>
        /// The name of the placement group that the Capacity Reservation is in.
        /// </para>
        /// </summary>
        public string GroupName
        {
            get { return this._groupName; }
            set { this._groupName = value; }
        }

        // Check to see if GroupName property is set
        internal bool IsSetGroupName()
        {
            return this._groupName != null;
        }

        /// <summary>
        /// Gets and sets the property InstanceType. 
        /// <para>
        /// The instance type.
        /// </para>
        /// </summary>
        public string InstanceType
        {
            get { return this._instanceType; }
            set { this._instanceType = value; }
        }

        // Check to see if InstanceType property is set
        internal bool IsSetInstanceType()
        {
            return this._instanceType != null;
        }

        /// <summary>
        /// Gets and sets the property NetworkNodes. 
        /// <para>
        /// The network nodes. The nodes are hashed based on your account. Capacity Reservations
        /// from different accounts running under the same server will return a different hashed
        /// list of strings.
        /// </para>
        ///  
        /// <para>
        /// The value is <c>null</c> or empty if:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// The instance type is not supported.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The Capacity Reservation is in a state other than <c>active</c> or <c>pending</c>.
        /// </para>
        ///  </li> </ul>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> NetworkNodes
        {
            get { return this._networkNodes; }
            set { this._networkNodes = value; }
        }

        // Check to see if NetworkNodes property is set
        internal bool IsSetNetworkNodes()
        {
            return this._networkNodes != null && (this._networkNodes.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property State. 
        /// <para>
        /// The current state of the Capacity Reservation. For the list of possible states, see
        /// <a href="https://docs.aws.amazon.com/AWSEC2/latest/APIReference/API_DescribeCapacityReservations.html">DescribeCapacityReservations</a>.
        /// </para>
        /// </summary>
        public string State
        {
            get { return this._state; }
            set { this._state = value; }
        }

        // Check to see if State property is set
        internal bool IsSetState()
        {
            return this._state != null;
        }

    }
}