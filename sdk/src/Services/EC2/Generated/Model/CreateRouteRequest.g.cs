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
    /// Container for the parameters to the CreateRoute operation. Creates a route in a route
    /// table within a VPC. <para> You must specify either a destination CIDR block or a prefix
    /// list ID. You must also specify exactly one of the resources from the parameter list.
    /// </para> <para> When determining how to route traffic, we use the route with the most
    /// specific match. For example, traffic is destined for the IPv4 address <c>192.0.2.3</c>,
    /// and the route table includes the following two IPv4 routes: </para> <ul> <li> <para>
    /// <c>192.0.2.0/24</c> (goes to some target A) </para> </li> <li> <para> <c>192.0.2.0/28</c>
    /// (goes to some target B) </para> </li> </ul> <para> Both routes apply to the traffic
    /// destined for <c>192.0.2.3</c>. However, the second route in the list covers a smaller
    /// number of IP addresses and is therefore more specific, so we use that route to determine
    /// where to target the traffic. </para> <para> For more information about route tables,
    /// see <a href="https://docs.aws.amazon.com/vpc/latest/userguide/VPC_Route_Tables.html">Route
    /// tables</a> in the <i>Amazon VPC User Guide</i>. </para>
    /// </summary>
    public partial class CreateRouteRequest : AmazonEC2Request
    {
        /// <summary>
        /// Gets and sets the property CarrierGatewayId. 
        /// <para>
        /// The ID of the carrier gateway.
        /// </para>
        ///  
        /// <para>
        /// You can only use this option when the VPC contains a subnet which is associated with
        /// a Wavelength Zone.
        /// </para>
        /// </summary>
        public string CarrierGatewayId { get; set; }

        /// <summary>
        /// Checks to see if the CarrierGatewayId property is set.
        /// </summary>
        internal bool IsSetCarrierGatewayId() => this.CarrierGatewayId != null;

        /// <summary>
        /// Gets and sets the property CoreNetworkArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the core network.
        /// </para>
        /// </summary>
        public string CoreNetworkArn { get; set; }

        /// <summary>
        /// Checks to see if the CoreNetworkArn property is set.
        /// </summary>
        internal bool IsSetCoreNetworkArn() => this.CoreNetworkArn != null;

        /// <summary>
        /// Gets and sets the property DestinationCidrBlock. 
        /// <para>
        /// The IPv4 CIDR address block used for the destination match. Routing decisions are
        /// based on the most specific match. We modify the specified CIDR block to its canonical
        /// form; for example, if you specify <c>100.68.0.18/18</c>, we modify it to <c>100.68.0.0/18</c>.
        /// </para>
        /// </summary>
        public string DestinationCidrBlock { get; set; }

        /// <summary>
        /// Checks to see if the DestinationCidrBlock property is set.
        /// </summary>
        internal bool IsSetDestinationCidrBlock() => this.DestinationCidrBlock != null;

        /// <summary>
        /// Gets and sets the property DestinationIpv6CidrBlock. 
        /// <para>
        /// The IPv6 CIDR block used for the destination match. Routing decisions are based on
        /// the most specific match.
        /// </para>
        /// </summary>
        public string DestinationIpv6CidrBlock { get; set; }

        /// <summary>
        /// Checks to see if the DestinationIpv6CidrBlock property is set.
        /// </summary>
        internal bool IsSetDestinationIpv6CidrBlock() => this.DestinationIpv6CidrBlock != null;

        /// <summary>
        /// Gets and sets the property DestinationPrefixListId. 
        /// <para>
        /// The ID of a prefix list used for the destination match.
        /// </para>
        /// </summary>
        public string DestinationPrefixListId { get; set; }

        /// <summary>
        /// Checks to see if the DestinationPrefixListId property is set.
        /// </summary>
        internal bool IsSetDestinationPrefixListId() => this.DestinationPrefixListId != null;

        /// <summary>
        /// Gets and sets the property DryRun. 
        /// <para>
        /// Checks whether you have the required permissions for the action, without actually
        /// making the request, and provides an error response. If you have the required permissions,
        /// the error response is <c>DryRunOperation</c>. Otherwise, it is <c>UnauthorizedOperation</c>.
        /// </para>
        /// </summary>
        public bool? DryRun { get; set; }

        /// <summary>
        /// Checks to see if the DryRun property is set.
        /// </summary>
        internal bool IsSetDryRun() => this.DryRun.HasValue;

        /// <summary>
        /// Gets and sets the property EgressOnlyInternetGatewayId. 
        /// <para>
        /// [IPv6 traffic only] The ID of an egress-only internet gateway.
        /// </para>
        /// </summary>
        public string EgressOnlyInternetGatewayId { get; set; }

        /// <summary>
        /// Checks to see if the EgressOnlyInternetGatewayId property is set.
        /// </summary>
        internal bool IsSetEgressOnlyInternetGatewayId() => this.EgressOnlyInternetGatewayId != null;

        /// <summary>
        /// Gets and sets the property GatewayId. 
        /// <para>
        /// The ID of an internet gateway or virtual private gateway attached to your VPC.
        /// </para>
        /// </summary>
        public string GatewayId { get; set; }

        /// <summary>
        /// Checks to see if the GatewayId property is set.
        /// </summary>
        internal bool IsSetGatewayId() => this.GatewayId != null;

        /// <summary>
        /// Gets and sets the property InstanceId. 
        /// <para>
        /// The ID of a NAT instance in your VPC. The operation fails if you specify an instance
        /// ID unless exactly one network interface is attached.
        /// </para>
        /// </summary>
        public string InstanceId { get; set; }

        /// <summary>
        /// Checks to see if the InstanceId property is set.
        /// </summary>
        internal bool IsSetInstanceId() => this.InstanceId != null;

        /// <summary>
        /// Gets and sets the property LocalGatewayId. 
        /// <para>
        /// The ID of the local gateway.
        /// </para>
        /// </summary>
        public string LocalGatewayId { get; set; }

        /// <summary>
        /// Checks to see if the LocalGatewayId property is set.
        /// </summary>
        internal bool IsSetLocalGatewayId() => this.LocalGatewayId != null;

        /// <summary>
        /// Gets and sets the property NatGatewayId. 
        /// <para>
        /// [IPv4 traffic only] The ID of a NAT gateway.
        /// </para>
        /// </summary>
        public string NatGatewayId { get; set; }

        /// <summary>
        /// Checks to see if the NatGatewayId property is set.
        /// </summary>
        internal bool IsSetNatGatewayId() => this.NatGatewayId != null;

        /// <summary>
        /// Gets and sets the property NetworkInterfaceId. 
        /// <para>
        /// The ID of a network interface.
        /// </para>
        /// </summary>
        public string NetworkInterfaceId { get; set; }

        /// <summary>
        /// Checks to see if the NetworkInterfaceId property is set.
        /// </summary>
        internal bool IsSetNetworkInterfaceId() => this.NetworkInterfaceId != null;

        /// <summary>
        /// Gets and sets the property OdbNetworkArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the ODB network.
        /// </para>
        /// </summary>
        public string OdbNetworkArn { get; set; }

        /// <summary>
        /// Checks to see if the OdbNetworkArn property is set.
        /// </summary>
        internal bool IsSetOdbNetworkArn() => this.OdbNetworkArn != null;

        /// <summary>
        /// Gets and sets the property RouteTableId. 
        /// <para>
        /// The ID of the route table for the route.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string RouteTableId { get; set; }

        /// <summary>
        /// Checks to see if the RouteTableId property is set.
        /// </summary>
        internal bool IsSetRouteTableId() => this.RouteTableId != null;

        /// <summary>
        /// Gets and sets the property TransitGatewayId. 
        /// <para>
        /// The ID of a transit gateway.
        /// </para>
        /// </summary>
        public string TransitGatewayId { get; set; }

        /// <summary>
        /// Checks to see if the TransitGatewayId property is set.
        /// </summary>
        internal bool IsSetTransitGatewayId() => this.TransitGatewayId != null;

        /// <summary>
        /// Gets and sets the property VpcEndpointId. 
        /// <para>
        /// The ID of a VPC endpoint. Supported for Gateway Load Balancer endpoints only.
        /// </para>
        /// </summary>
        public string VpcEndpointId { get; set; }

        /// <summary>
        /// Checks to see if the VpcEndpointId property is set.
        /// </summary>
        internal bool IsSetVpcEndpointId() => this.VpcEndpointId != null;

        /// <summary>
        /// Gets and sets the property VpcPeeringConnectionId. 
        /// <para>
        /// The ID of a VPC peering connection.
        /// </para>
        /// </summary>
        public string VpcPeeringConnectionId { get; set; }

        /// <summary>
        /// Checks to see if the VpcPeeringConnectionId property is set.
        /// </summary>
        internal bool IsSetVpcPeeringConnectionId() => this.VpcPeeringConnectionId != null;
    }
}
