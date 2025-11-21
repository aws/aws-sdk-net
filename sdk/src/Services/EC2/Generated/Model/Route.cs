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
    /// Describes a route in a route table.
    /// </summary>
    public partial class Route
    {
        private string _carrierGatewayId;
        private string _coreNetworkArn;
        private string _destinationCidrBlock;
        private string _destinationIpv6CidrBlock;
        private string _destinationPrefixListId;
        private string _egressOnlyInternetGatewayId;
        private string _gatewayId;
        private string _instanceId;
        private string _instanceOwnerId;
        private string _ipAddress;
        private string _localGatewayId;
        private string _natGatewayId;
        private string _networkInterfaceId;
        private string _odbNetworkArn;
        private RouteOrigin _origin;
        private RouteState _state;
        private string _transitGatewayId;
        private string _vpcPeeringConnectionId;

        /// <summary>
        /// Gets and sets the property CarrierGatewayId. 
        /// <para>
        /// The ID of the carrier gateway.
        /// </para>
        /// </summary>
        public string CarrierGatewayId
        {
            get { return this._carrierGatewayId; }
            set { this._carrierGatewayId = value; }
        }

        // Check to see if CarrierGatewayId property is set
        internal bool IsSetCarrierGatewayId()
        {
            return this._carrierGatewayId != null;
        }

        /// <summary>
        /// Gets and sets the property CoreNetworkArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the core network.
        /// </para>
        /// </summary>
        public string CoreNetworkArn
        {
            get { return this._coreNetworkArn; }
            set { this._coreNetworkArn = value; }
        }

        // Check to see if CoreNetworkArn property is set
        internal bool IsSetCoreNetworkArn()
        {
            return this._coreNetworkArn != null;
        }

        /// <summary>
        /// Gets and sets the property DestinationCidrBlock. 
        /// <para>
        /// The IPv4 CIDR block used for the destination match.
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
        /// Gets and sets the property DestinationIpv6CidrBlock. 
        /// <para>
        /// The IPv6 CIDR block used for the destination match.
        /// </para>
        /// </summary>
        public string DestinationIpv6CidrBlock
        {
            get { return this._destinationIpv6CidrBlock; }
            set { this._destinationIpv6CidrBlock = value; }
        }

        // Check to see if DestinationIpv6CidrBlock property is set
        internal bool IsSetDestinationIpv6CidrBlock()
        {
            return this._destinationIpv6CidrBlock != null;
        }

        /// <summary>
        /// Gets and sets the property DestinationPrefixListId. 
        /// <para>
        /// The prefix of the Amazon Web Services service.
        /// </para>
        /// </summary>
        public string DestinationPrefixListId
        {
            get { return this._destinationPrefixListId; }
            set { this._destinationPrefixListId = value; }
        }

        // Check to see if DestinationPrefixListId property is set
        internal bool IsSetDestinationPrefixListId()
        {
            return this._destinationPrefixListId != null;
        }

        /// <summary>
        /// Gets and sets the property EgressOnlyInternetGatewayId. 
        /// <para>
        /// The ID of the egress-only internet gateway.
        /// </para>
        /// </summary>
        public string EgressOnlyInternetGatewayId
        {
            get { return this._egressOnlyInternetGatewayId; }
            set { this._egressOnlyInternetGatewayId = value; }
        }

        // Check to see if EgressOnlyInternetGatewayId property is set
        internal bool IsSetEgressOnlyInternetGatewayId()
        {
            return this._egressOnlyInternetGatewayId != null;
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
        /// The ID of Amazon Web Services account that owns the instance.
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
        /// Gets and sets the property IpAddress. 
        /// <para>
        /// The next hop IP address for routes propagated by VPC Route Server into VPC route tables.
        /// </para>
        /// </summary>
        public string IpAddress
        {
            get { return this._ipAddress; }
            set { this._ipAddress = value; }
        }

        // Check to see if IpAddress property is set
        internal bool IsSetIpAddress()
        {
            return this._ipAddress != null;
        }

        /// <summary>
        /// Gets and sets the property LocalGatewayId. 
        /// <para>
        /// The ID of the local gateway.
        /// </para>
        /// </summary>
        public string LocalGatewayId
        {
            get { return this._localGatewayId; }
            set { this._localGatewayId = value; }
        }

        // Check to see if LocalGatewayId property is set
        internal bool IsSetLocalGatewayId()
        {
            return this._localGatewayId != null;
        }

        /// <summary>
        /// Gets and sets the property NatGatewayId. 
        /// <para>
        /// The ID of a NAT gateway.
        /// </para>
        /// </summary>
        public string NatGatewayId
        {
            get { return this._natGatewayId; }
            set { this._natGatewayId = value; }
        }

        // Check to see if NatGatewayId property is set
        internal bool IsSetNatGatewayId()
        {
            return this._natGatewayId != null;
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
        /// Gets and sets the property OdbNetworkArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the ODB network.
        /// </para>
        /// </summary>
        public string OdbNetworkArn
        {
            get { return this._odbNetworkArn; }
            set { this._odbNetworkArn = value; }
        }

        // Check to see if OdbNetworkArn property is set
        internal bool IsSetOdbNetworkArn()
        {
            return this._odbNetworkArn != null;
        }

        /// <summary>
        /// Gets and sets the property Origin. 
        /// <para>
        /// Describes how the route was created.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>CreateRouteTable</c> - The route was automatically created when the route table
        /// was created.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>CreateRoute</c> - The route was manually added to the route table.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>EnableVgwRoutePropagation</c> - The route was propagated by route propagation.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>Advertisement</c> - The route was created dynamically by Amazon VPC Route Server.
        /// </para>
        ///  </li> </ul>
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
        /// The state of the route. The <c>blackhole</c> state indicates that the route's target
        /// isn't available (for example, the specified gateway isn't attached to the VPC, or
        /// the specified NAT instance has been terminated).
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
        /// Gets and sets the property TransitGatewayId. 
        /// <para>
        /// The ID of a transit gateway.
        /// </para>
        /// </summary>
        public string TransitGatewayId
        {
            get { return this._transitGatewayId; }
            set { this._transitGatewayId = value; }
        }

        // Check to see if TransitGatewayId property is set
        internal bool IsSetTransitGatewayId()
        {
            return this._transitGatewayId != null;
        }

        /// <summary>
        /// Gets and sets the property VpcPeeringConnectionId. 
        /// <para>
        /// The ID of a VPC peering connection.
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