/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
 * Do not modify this file. This file is generated from the ec2-2014-10-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.EC2.Model
{
    /// <summary>
    /// Describes a route in a route table.
    /// </summary>
    public partial class Route
    {
        private string _destinationCidrBlock;
        private string _gatewayId;
        private string _instanceId;
        private string _instanceOwnerId;
        private string _networkInterfaceId;
        private RouteOrigin _origin;
        private RouteState _state;
        private string _vpcPeeringConnectionId;

        /// <summary>
        /// Gets and sets the property DestinationCidrBlock. 
        /// <para>
        /// The CIDR block used for the destination match.
        /// </para>
        /// </summary>
        public string DestinationCidrBlock
        {
            get { return this._destinationCidrBlock; }
            set { this._destinationCidrBlock = value; }
        }

        // Check to see if DestinationCidrBlock property is set
        internal bool IsSetDestinationCidrBlock()
        {
            return this._destinationCidrBlock != null;
        }

        /// <summary>
        /// Gets and sets the property GatewayId. 
        /// <para>
        /// The ID of a gateway attached to your VPC.
        /// </para>
        /// </summary>
        public string GatewayId
        {
            get { return this._gatewayId; }
            set { this._gatewayId = value; }
        }

        // Check to see if GatewayId property is set
        internal bool IsSetGatewayId()
        {
            return this._gatewayId != null;
        }

        /// <summary>
        /// Gets and sets the property InstanceId. 
        /// <para>
        /// The ID of a NAT instance in your VPC.
        /// </para>
        /// </summary>
        public string InstanceId
        {
            get { return this._instanceId; }
            set { this._instanceId = value; }
        }

        // Check to see if InstanceId property is set
        internal bool IsSetInstanceId()
        {
            return this._instanceId != null;
        }

        /// <summary>
        /// Gets and sets the property InstanceOwnerId. 
        /// <para>
        /// The AWS account ID of the owner of the instance.
        /// </para>
        /// </summary>
        public string InstanceOwnerId
        {
            get { return this._instanceOwnerId; }
            set { this._instanceOwnerId = value; }
        }

        // Check to see if InstanceOwnerId property is set
        internal bool IsSetInstanceOwnerId()
        {
            return this._instanceOwnerId != null;
        }

        /// <summary>
        /// Gets and sets the property NetworkInterfaceId. 
        /// <para>
        /// The ID of the network interface.
        /// </para>
        /// </summary>
        public string NetworkInterfaceId
        {
            get { return this._networkInterfaceId; }
            set { this._networkInterfaceId = value; }
        }

        // Check to see if NetworkInterfaceId property is set
        internal bool IsSetNetworkInterfaceId()
        {
            return this._networkInterfaceId != null;
        }

        /// <summary>
        /// Gets and sets the property Origin. 
        /// <para>
        /// Describes how the route was created.
        /// </para>
        ///  <ul> <li> <code>CreateRouteTable</code> indicates that route was automatically created
        /// when the route table was created.</li> <li> <code>CreateRoute</code> indicates that
        /// the route was manually added to the route table.</li> <li> <code>EnableVgwRoutePropagation</code>
        /// indicates that the route was propagated by route propagation.</li> </ul>
        /// </summary>
        public RouteOrigin Origin
        {
            get { return this._origin; }
            set { this._origin = value; }
        }

        // Check to see if Origin property is set
        internal bool IsSetOrigin()
        {
            return this._origin != null;
        }

        /// <summary>
        /// Gets and sets the property State. 
        /// <para>
        /// The state of the route. The <code>blackhole</code> state indicates that the route's
        /// target isn't available (for example, the specified gateway isn't attached to the VPC,
        /// or the specified NAT instance has been terminated).
        /// </para>
        /// </summary>
        public RouteState State
        {
            get { return this._state; }
            set { this._state = value; }
        }

        // Check to see if State property is set
        internal bool IsSetState()
        {
            return this._state != null;
        }

        /// <summary>
        /// Gets and sets the property VpcPeeringConnectionId. 
        /// <para>
        /// The ID of the VPC peering connection.
        /// </para>
        /// </summary>
        public string VpcPeeringConnectionId
        {
            get { return this._vpcPeeringConnectionId; }
            set { this._vpcPeeringConnectionId = value; }
        }

        // Check to see if VpcPeeringConnectionId property is set
        internal bool IsSetVpcPeeringConnectionId()
        {
            return this._vpcPeeringConnectionId != null;
        }

    }
}