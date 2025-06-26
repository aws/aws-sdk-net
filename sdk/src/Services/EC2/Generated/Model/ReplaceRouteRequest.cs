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
    /// Container for the parameters to the ReplaceRoute operation.
    /// Replaces an existing route within a route table in a VPC.
    /// 
    ///  
    /// <para>
    /// You must specify either a destination CIDR block or a prefix list ID. You must also
    /// specify exactly one of the resources from the parameter list, or reset the local route
    /// to its default target.
    /// </para>
    ///  
    /// <para>
    /// For more information, see <a href="https://docs.aws.amazon.com/vpc/latest/userguide/VPC_Route_Tables.html">Route
    /// tables</a> in the <i>Amazon VPC User Guide</i>.
    /// </para>
    /// </summary>
    public partial class ReplaceRouteRequest : AmazonEC2Request
    {
        private string _carrierGatewayId;
        private string _coreNetworkArn;
        private string _destinationCidrBlock;
        private string _destinationIpv6CidrBlock;
        private string _destinationPrefixListId;
        private bool? _dryRun;
        private string _egressOnlyInternetGatewayId;
        private string _gatewayId;
        private string _instanceId;
        private string _localGatewayId;
        private bool? _localTarget;
        private string _natGatewayId;
        private string _networkInterfaceId;
        private string _odbNetworkArn;
        private string _routeTableId;
        private string _transitGatewayId;
        private string _vpcEndpointId;
        private string _vpcPeeringConnectionId;

        /// <summary>
        /// Gets and sets the property CarrierGatewayId. 
        /// <para>
        /// [IPv4 traffic only] The ID of a carrier gateway.
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
        /// The IPv4 CIDR address block used for the destination match. The value that you provide
        /// must match the CIDR of an existing route in the table.
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
        /// The IPv6 CIDR address block used for the destination match. The value that you provide
        /// must match the CIDR of an existing route in the table.
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
        /// The ID of the prefix list for the route.
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
        /// Gets and sets the property DryRun. 
        /// <para>
        /// Checks whether you have the required permissions for the action, without actually
        /// making the request, and provides an error response. If you have the required permissions,
        /// the error response is <c>DryRunOperation</c>. Otherwise, it is <c>UnauthorizedOperation</c>.
        /// </para>
        /// </summary>
        public bool? DryRun
        {
            get { return this._dryRun; }
            set { this._dryRun = value; }
        }

        // Check to see if DryRun property is set
        internal bool IsSetDryRun()
        {
            return this._dryRun.HasValue; 
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
        /// The ID of an internet gateway or virtual private gateway.
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
        /// Gets and sets the property LocalTarget. 
        /// <para>
        /// Specifies whether to reset the local route to its default target (<c>local</c>).
        /// </para>
        /// </summary>
        public bool? LocalTarget
        {
            get { return this._localTarget; }
            set { this._localTarget = value; }
        }

        // Check to see if LocalTarget property is set
        internal bool IsSetLocalTarget()
        {
            return this._localTarget.HasValue; 
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
        /// Gets and sets the property RouteTableId. 
        /// <para>
        /// The ID of the route table.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
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
        /// Gets and sets the property VpcEndpointId. 
        /// <para>
        /// The ID of a VPC endpoint. Supported for Gateway Load Balancer endpoints only.
        /// </para>
        /// </summary>
        public string VpcEndpointId
        {
            get { return this._vpcEndpointId; }
            set { this._vpcEndpointId = value; }
        }

        // Check to see if VpcEndpointId property is set
        internal bool IsSetVpcEndpointId()
        {
            return this._vpcEndpointId != null;
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