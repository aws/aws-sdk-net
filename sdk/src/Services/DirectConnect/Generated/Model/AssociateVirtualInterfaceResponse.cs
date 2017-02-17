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
 * Do not modify this file. This file is generated from the directconnect-2012-10-25.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.DirectConnect.Model
{
    /// <summary>
    /// A virtual interface (VLAN) transmits the traffic between the AWS Direct Connect location
    /// and the customer.
    /// </summary>
    public partial class AssociateVirtualInterfaceResponse : AmazonWebServiceResponse
    {
        private AddressFamily _addressFamily;
        private string _amazonAddress;
        private int? _asn;
        private string _authKey;
        private List<BGPPeer> _bgpPeers = new List<BGPPeer>();
        private string _connectionId;
        private string _customerAddress;
        private string _customerRouterConfig;
        private string _location;
        private string _ownerAccount;
        private List<RouteFilterPrefix> _routeFilterPrefixes = new List<RouteFilterPrefix>();
        private string _virtualGatewayId;
        private string _virtualInterfaceId;
        private string _virtualInterfaceName;
        private VirtualInterfaceState _virtualInterfaceState;
        private string _virtualInterfaceType;
        private int? _vlan;

        /// <summary>
        /// Gets and sets the property AddressFamily.
        /// </summary>
        public AddressFamily AddressFamily
        {
            get { return this._addressFamily; }
            set { this._addressFamily = value; }
        }

        // Check to see if AddressFamily property is set
        internal bool IsSetAddressFamily()
        {
            return this._addressFamily != null;
        }

        /// <summary>
        /// Gets and sets the property AmazonAddress.
        /// </summary>
        public string AmazonAddress
        {
            get { return this._amazonAddress; }
            set { this._amazonAddress = value; }
        }

        // Check to see if AmazonAddress property is set
        internal bool IsSetAmazonAddress()
        {
            return this._amazonAddress != null;
        }

        /// <summary>
        /// Gets and sets the property Asn.
        /// </summary>
        public int Asn
        {
            get { return this._asn.GetValueOrDefault(); }
            set { this._asn = value; }
        }

        // Check to see if Asn property is set
        internal bool IsSetAsn()
        {
            return this._asn.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property AuthKey.
        /// </summary>
        public string AuthKey
        {
            get { return this._authKey; }
            set { this._authKey = value; }
        }

        // Check to see if AuthKey property is set
        internal bool IsSetAuthKey()
        {
            return this._authKey != null;
        }

        /// <summary>
        /// Gets and sets the property BgpPeers.
        /// </summary>
        public List<BGPPeer> BgpPeers
        {
            get { return this._bgpPeers; }
            set { this._bgpPeers = value; }
        }

        // Check to see if BgpPeers property is set
        internal bool IsSetBgpPeers()
        {
            return this._bgpPeers != null && this._bgpPeers.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property ConnectionId.
        /// </summary>
        public string ConnectionId
        {
            get { return this._connectionId; }
            set { this._connectionId = value; }
        }

        // Check to see if ConnectionId property is set
        internal bool IsSetConnectionId()
        {
            return this._connectionId != null;
        }

        /// <summary>
        /// Gets and sets the property CustomerAddress.
        /// </summary>
        public string CustomerAddress
        {
            get { return this._customerAddress; }
            set { this._customerAddress = value; }
        }

        // Check to see if CustomerAddress property is set
        internal bool IsSetCustomerAddress()
        {
            return this._customerAddress != null;
        }

        /// <summary>
        /// Gets and sets the property CustomerRouterConfig. 
        /// <para>
        /// Information for generating the customer router configuration.
        /// </para>
        /// </summary>
        public string CustomerRouterConfig
        {
            get { return this._customerRouterConfig; }
            set { this._customerRouterConfig = value; }
        }

        // Check to see if CustomerRouterConfig property is set
        internal bool IsSetCustomerRouterConfig()
        {
            return this._customerRouterConfig != null;
        }

        /// <summary>
        /// Gets and sets the property Location.
        /// </summary>
        public string Location
        {
            get { return this._location; }
            set { this._location = value; }
        }

        // Check to see if Location property is set
        internal bool IsSetLocation()
        {
            return this._location != null;
        }

        /// <summary>
        /// Gets and sets the property OwnerAccount. 
        /// <para>
        /// The AWS account that will own the new virtual interface.
        /// </para>
        /// </summary>
        public string OwnerAccount
        {
            get { return this._ownerAccount; }
            set { this._ownerAccount = value; }
        }

        // Check to see if OwnerAccount property is set
        internal bool IsSetOwnerAccount()
        {
            return this._ownerAccount != null;
        }

        /// <summary>
        /// Gets and sets the property RouteFilterPrefixes.
        /// </summary>
        public List<RouteFilterPrefix> RouteFilterPrefixes
        {
            get { return this._routeFilterPrefixes; }
            set { this._routeFilterPrefixes = value; }
        }

        // Check to see if RouteFilterPrefixes property is set
        internal bool IsSetRouteFilterPrefixes()
        {
            return this._routeFilterPrefixes != null && this._routeFilterPrefixes.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property VirtualGatewayId.
        /// </summary>
        public string VirtualGatewayId
        {
            get { return this._virtualGatewayId; }
            set { this._virtualGatewayId = value; }
        }

        // Check to see if VirtualGatewayId property is set
        internal bool IsSetVirtualGatewayId()
        {
            return this._virtualGatewayId != null;
        }

        /// <summary>
        /// Gets and sets the property VirtualInterfaceId.
        /// </summary>
        public string VirtualInterfaceId
        {
            get { return this._virtualInterfaceId; }
            set { this._virtualInterfaceId = value; }
        }

        // Check to see if VirtualInterfaceId property is set
        internal bool IsSetVirtualInterfaceId()
        {
            return this._virtualInterfaceId != null;
        }

        /// <summary>
        /// Gets and sets the property VirtualInterfaceName.
        /// </summary>
        public string VirtualInterfaceName
        {
            get { return this._virtualInterfaceName; }
            set { this._virtualInterfaceName = value; }
        }

        // Check to see if VirtualInterfaceName property is set
        internal bool IsSetVirtualInterfaceName()
        {
            return this._virtualInterfaceName != null;
        }

        /// <summary>
        /// Gets and sets the property VirtualInterfaceState.
        /// </summary>
        public VirtualInterfaceState VirtualInterfaceState
        {
            get { return this._virtualInterfaceState; }
            set { this._virtualInterfaceState = value; }
        }

        // Check to see if VirtualInterfaceState property is set
        internal bool IsSetVirtualInterfaceState()
        {
            return this._virtualInterfaceState != null;
        }

        /// <summary>
        /// Gets and sets the property VirtualInterfaceType.
        /// </summary>
        public string VirtualInterfaceType
        {
            get { return this._virtualInterfaceType; }
            set { this._virtualInterfaceType = value; }
        }

        // Check to see if VirtualInterfaceType property is set
        internal bool IsSetVirtualInterfaceType()
        {
            return this._virtualInterfaceType != null;
        }

        /// <summary>
        /// Gets and sets the property Vlan.
        /// </summary>
        public int Vlan
        {
            get { return this._vlan.GetValueOrDefault(); }
            set { this._vlan = value; }
        }

        // Check to see if Vlan property is set
        internal bool IsSetVlan()
        {
            return this._vlan.HasValue; 
        }

    }
}