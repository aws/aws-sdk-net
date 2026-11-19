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
    /// Information about the Capacity Reservation topology.
    /// </summary>
    public partial class CapacityReservationTopology
    {
        /// <summary>
        /// Gets and sets the property AvailabilityZone. 
        /// <para>
        /// The name of the Availability Zone or Local Zone that the Capacity Reservation is in.
        /// </para>
        /// </summary>
        public string AvailabilityZone { get; set; }

        /// <summary>
        /// Checks to see if the AvailabilityZone property is set.
        /// </summary>
        internal bool IsSetAvailabilityZone() => this.AvailabilityZone != null;

        /// <summary>
        /// Gets and sets the property AvailabilityZoneId. 
        /// <para>
        /// The ID of the Availability Zone or Local Zone that the Capacity Reservation is in.
        /// </para>
        /// </summary>
        public string AvailabilityZoneId { get; set; }

        /// <summary>
        /// Checks to see if the AvailabilityZoneId property is set.
        /// </summary>
        internal bool IsSetAvailabilityZoneId() => this.AvailabilityZoneId != null;

        /// <summary>
        /// Gets and sets the property CapacityBlockId. 
        /// <para>
        /// The ID of the Capacity Block. This parameter is only supported for UltraServer instances
        /// and identifies instances within the UltraServer domain.
        /// </para>
        /// </summary>
        public string CapacityBlockId { get; set; }

        /// <summary>
        /// Checks to see if the CapacityBlockId property is set.
        /// </summary>
        internal bool IsSetCapacityBlockId() => this.CapacityBlockId != null;

        /// <summary>
        /// Gets and sets the property CapacityReservationId. 
        /// <para>
        /// The ID of the Capacity Reservation.
        /// </para>
        /// </summary>
        public string CapacityReservationId { get; set; }

        /// <summary>
        /// Checks to see if the CapacityReservationId property is set.
        /// </summary>
        internal bool IsSetCapacityReservationId() => this.CapacityReservationId != null;

        /// <summary>
        /// Gets and sets the property GroupName. 
        /// <para>
        /// The name of the placement group that the Capacity Reservation is in.
        /// </para>
        /// </summary>
        public string GroupName { get; set; }

        /// <summary>
        /// Checks to see if the GroupName property is set.
        /// </summary>
        internal bool IsSetGroupName() => this.GroupName != null;

        /// <summary>
        /// Gets and sets the property InstanceType. 
        /// <para>
        /// The instance type.
        /// </para>
        /// </summary>
        public string InstanceType { get; set; }

        /// <summary>
        /// Checks to see if the InstanceType property is set.
        /// </summary>
        internal bool IsSetInstanceType() => this.InstanceType != null;

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
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> NetworkNodes { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the NetworkNodes property is set.
        /// </summary>
        internal bool IsSetNetworkNodes() => this.NetworkNodes != null && (this.NetworkNodes.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property State. 
        /// <para>
        /// The current state of the Capacity Reservation. For the list of possible states, see
        /// <a href="https://docs.aws.amazon.com/AWSEC2/latest/APIReference/API_DescribeCapacityReservations.html">DescribeCapacityReservations</a>.
        /// </para>
        /// </summary>
        public string State { get; set; }

        /// <summary>
        /// Checks to see if the State property is set.
        /// </summary>
        internal bool IsSetState() => this.State != null;
    }
}
