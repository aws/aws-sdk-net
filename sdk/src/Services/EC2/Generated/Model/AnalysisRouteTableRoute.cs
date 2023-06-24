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

namespace Amazon.EC2.Model
{
    /// <summary>
    /// Describes a route table route.
    /// </summary>
    public partial class AnalysisRouteTableRoute
    {
        private string _carrierGatewayId;
        private string _coreNetworkArn;
        private string _destinationCidr;
        private string _destinationPrefixListId;
        private string _egressOnlyInternetGatewayId;
        private string _gatewayId;
        private string _instanceId;
        private string _localGatewayId;
        private string _natGatewayId;
        private string _networkInterfaceId;
        private string _origin;
        private string _state;
        private string _transitGatewayId;
        private string _vpcPeeringConnectionId;

        /// <summary>
        /// Gets and sets the property CarrierGatewayId. 
        /// <para>
        /// The ID of a carrier gateway.
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
        /// The Amazon Resource Name (ARN) of a core network.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=1283)]
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
        /// Gets and sets the property DestinationCidr. 
        /// <para>
        /// The destination IPv4 address, in CIDR notation.
        /// </para>
        /// </summary>
        public string DestinationCidr
        {
            get { return this._destinationCidr; }
            set { this._destinationCidr = value; }
        }

        // Check to see if DestinationCidr property is set
        internal bool IsSetDestinationCidr()
        {
            return this._destinationCidr != null;
        }

        /// <summary>
        /// Gets and sets the property DestinationPrefixListId. 
        /// <para>
        /// The prefix of the Amazon Web Service.
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
        /// The ID of an egress-only internet gateway.
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
        /// The ID of the gateway, such as an internet gateway or virtual private gateway.
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
        /// The ID of the instance, such as a NAT instance.
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
        /// The ID of a local gateway.
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
        public string Origin
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