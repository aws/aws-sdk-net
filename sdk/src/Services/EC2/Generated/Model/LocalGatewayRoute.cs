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
    /// Describes a route for a local gateway route table.
    /// </summary>
    public partial class LocalGatewayRoute
    {
        private string _coipPoolId;
        private string _destinationCidrBlock;
        private string _destinationPrefixListId;
        private string _localGatewayRouteTableArn;
        private string _localGatewayRouteTableId;
        private string _localGatewayVirtualInterfaceGroupId;
        private string _networkInterfaceId;
        private string _ownerId;
        private LocalGatewayRouteState _state;
        private string _subnetId;
        private LocalGatewayRouteType _type;

        /// <summary>
        /// Gets and sets the property CoipPoolId. 
        /// <para>
        /// The ID of the customer-owned address pool.
        /// </para>
        /// </summary>
        public string CoipPoolId
        {
            get { return this._coipPoolId; }
            set { this._coipPoolId = value; }
        }

        // Check to see if CoipPoolId property is set
        internal bool IsSetCoipPoolId()
        {
            return this._coipPoolId != null;
        }

        /// <summary>
        /// Gets and sets the property DestinationCidrBlock. 
        /// <para>
        /// The CIDR block used for destination matches.
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
        /// Gets and sets the property DestinationPrefixListId. 
        /// <para>
        ///  The ID of the prefix list. 
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
        /// Gets and sets the property LocalGatewayRouteTableArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the local gateway route table.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=1283)]
        public string LocalGatewayRouteTableArn
        {
            get { return this._localGatewayRouteTableArn; }
            set { this._localGatewayRouteTableArn = value; }
        }

        // Check to see if LocalGatewayRouteTableArn property is set
        internal bool IsSetLocalGatewayRouteTableArn()
        {
            return this._localGatewayRouteTableArn != null;
        }

        /// <summary>
        /// Gets and sets the property LocalGatewayRouteTableId. 
        /// <para>
        /// The ID of the local gateway route table.
        /// </para>
        /// </summary>
        public string LocalGatewayRouteTableId
        {
            get { return this._localGatewayRouteTableId; }
            set { this._localGatewayRouteTableId = value; }
        }

        // Check to see if LocalGatewayRouteTableId property is set
        internal bool IsSetLocalGatewayRouteTableId()
        {
            return this._localGatewayRouteTableId != null;
        }

        /// <summary>
        /// Gets and sets the property LocalGatewayVirtualInterfaceGroupId. 
        /// <para>
        /// The ID of the virtual interface group.
        /// </para>
        /// </summary>
        public string LocalGatewayVirtualInterfaceGroupId
        {
            get { return this._localGatewayVirtualInterfaceGroupId; }
            set { this._localGatewayVirtualInterfaceGroupId = value; }
        }

        // Check to see if LocalGatewayVirtualInterfaceGroupId property is set
        internal bool IsSetLocalGatewayVirtualInterfaceGroupId()
        {
            return this._localGatewayVirtualInterfaceGroupId != null;
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
        /// Gets and sets the property OwnerId. 
        /// <para>
        /// The ID of the Amazon Web Services account that owns the local gateway route.
        /// </para>
        /// </summary>
        public string OwnerId
        {
            get { return this._ownerId; }
            set { this._ownerId = value; }
        }

        // Check to see if OwnerId property is set
        internal bool IsSetOwnerId()
        {
            return this._ownerId != null;
        }

        /// <summary>
        /// Gets and sets the property State. 
        /// <para>
        /// The state of the route.
        /// </para>
        /// </summary>
        public LocalGatewayRouteState State
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
        /// Gets and sets the property SubnetId. 
        /// <para>
        /// The ID of the subnet.
        /// </para>
        /// </summary>
        public string SubnetId
        {
            get { return this._subnetId; }
            set { this._subnetId = value; }
        }

        // Check to see if SubnetId property is set
        internal bool IsSetSubnetId()
        {
            return this._subnetId != null;
        }

        /// <summary>
        /// Gets and sets the property Type. 
        /// <para>
        /// The route type.
        /// </para>
        /// </summary>
        public LocalGatewayRouteType Type
        {
            get { return this._type; }
            set { this._type = value; }
        }

        // Check to see if Type property is set
        internal bool IsSetType()
        {
            return this._type != null;
        }

    }
}