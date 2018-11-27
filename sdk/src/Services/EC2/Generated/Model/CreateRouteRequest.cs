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
 * Do not modify this file. This file is generated from the ec2-2016-11-15.normal.json service model.
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
    /// Container for the parameters to the CreateRoute operation.
    /// Creates a route in a route table within a VPC.
    /// 
    ///  
    /// <para>
    /// You must specify one of the following targets: internet gateway or virtual private
    /// gateway, NAT instance, NAT gateway, VPC peering connection, network interface, or
    /// egress-only internet gateway.
    /// </para>
    ///  
    /// <para>
    /// When determining how to route traffic, we use the route with the most specific match.
    /// For example, traffic is destined for the IPv4 address <code>192.0.2.3</code>, and
    /// the route table includes the following two IPv4 routes:
    /// </para>
    ///  <ul> <li> 
    /// <para>
    ///  <code>192.0.2.0/24</code> (goes to some target A)
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <code>192.0.2.0/28</code> (goes to some target B)
    /// </para>
    ///  </li> </ul> 
    /// <para>
    /// Both routes apply to the traffic destined for <code>192.0.2.3</code>. However, the
    /// second route in the list covers a smaller number of IP addresses and is therefore
    /// more specific, so we use that route to determine where to target the traffic.
    /// </para>
    ///  
    /// <para>
    /// For more information about route tables, see <a href="http://docs.aws.amazon.com/AmazonVPC/latest/UserGuide/VPC_Route_Tables.html">Route
    /// Tables</a> in the <i>Amazon Virtual Private Cloud User Guide</i>.
    /// </para>
    /// </summary>
    public partial class CreateRouteRequest : AmazonEC2Request
    {
        private string _destinationCidrBlock;
        private string _destinationIpv6CidrBlock;
        private string _egressOnlyInternetGatewayId;
        private string _gatewayId;
        private string _instanceId;
        private string _natGatewayId;
        private string _networkInterfaceId;
        private string _routeTableId;
        private string _transitGatewayId;
        private string _vpcPeeringConnectionId;

        /// <summary>
        /// Gets and sets the property DestinationCidrBlock. 
        /// <para>
        /// The IPv4 CIDR address block used for the destination match. Routing decisions are
        /// based on the most specific match.
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
        /// The IPv6 CIDR block used for the destination match. Routing decisions are based on
        /// the most specific match.
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
        /// Gets and sets the property EgressOnlyInternetGatewayId. 
        /// <para>
        /// [IPv6 traffic only] The ID of an egress-only internet gateway.
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
        /// The ID of an internet gateway or virtual private gateway attached to your VPC.
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
        /// The ID of a NAT instance in your VPC. The operation fails if you specify an instance
        /// ID unless exactly one network interface is attached.
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
        /// Gets and sets the property NatGatewayId. 
        /// <para>
        /// [IPv4 traffic only] The ID of a NAT gateway.
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
        /// The ID of a network interface.
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
        /// Gets and sets the property RouteTableId. 
        /// <para>
        /// The ID of the route table for the route.
        /// </para>
        /// </summary>
        public string RouteTableId
        {
            get { return this._routeTableId; }
            set { this._routeTableId = value; }
        }

        // Check to see if RouteTableId property is set
        internal bool IsSetRouteTableId()
        {
            return this._routeTableId != null;
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