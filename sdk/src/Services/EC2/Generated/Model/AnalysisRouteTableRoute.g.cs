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
    /// Describes a route table route.
    /// </summary>
    public partial class AnalysisRouteTableRoute
    {
        /// <summary>
        /// Gets and sets the property CarrierGatewayId. 
        /// <para>
        /// The ID of a carrier gateway.
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
        /// The Amazon Resource Name (ARN) of a core network.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 1283)]
        public string CoreNetworkArn { get; set; }

        /// <summary>
        /// Checks to see if the CoreNetworkArn property is set.
        /// </summary>
        internal bool IsSetCoreNetworkArn() => this.CoreNetworkArn != null;

        /// <summary>
        /// Gets and sets the property DestinationCidr. 
        /// <para>
        /// The destination IPv4 address, in CIDR notation.
        /// </para>
        /// </summary>
        public string DestinationCidr { get; set; }

        /// <summary>
        /// Checks to see if the DestinationCidr property is set.
        /// </summary>
        internal bool IsSetDestinationCidr() => this.DestinationCidr != null;

        /// <summary>
        /// Gets and sets the property DestinationPrefixListId. 
        /// <para>
        /// The prefix of the Amazon Web Services service.
        /// </para>
        /// </summary>
        public string DestinationPrefixListId { get; set; }

        /// <summary>
        /// Checks to see if the DestinationPrefixListId property is set.
        /// </summary>
        internal bool IsSetDestinationPrefixListId() => this.DestinationPrefixListId != null;

        /// <summary>
        /// Gets and sets the property EgressOnlyInternetGatewayId. 
        /// <para>
        /// The ID of an egress-only internet gateway.
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
        /// The ID of the gateway, such as an internet gateway or virtual private gateway.
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
        /// The ID of the instance, such as a NAT instance.
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
        /// The ID of a local gateway.
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
        /// The ID of a NAT gateway.
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
        /// Gets and sets the property Origin. 
        /// <para>
        /// Describes how the route was created. The following are the possible values:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// CreateRouteTable - The route was automatically created when the route table was created.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// CreateRoute - The route was manually added to the route table.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// EnableVgwRoutePropagation - The route was propagated by route propagation.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public string Origin { get; set; }

        /// <summary>
        /// Checks to see if the Origin property is set.
        /// </summary>
        internal bool IsSetOrigin() => this.Origin != null;

        /// <summary>
        /// Gets and sets the property State. 
        /// <para>
        /// The state. The following are the possible values:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// active
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// blackhole
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public string State { get; set; }

        /// <summary>
        /// Checks to see if the State property is set.
        /// </summary>
        internal bool IsSetState() => this.State != null;

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
