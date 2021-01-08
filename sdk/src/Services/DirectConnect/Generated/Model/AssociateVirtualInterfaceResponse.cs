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
 * Do not modify this file. This file is generated from the directconnect-2012-10-25.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.DirectConnect.Model
{
    /// <summary>
    /// Information about a virtual interface.
    /// </summary>
    public partial class AssociateVirtualInterfaceResponse : AmazonWebServiceResponse
    {
        private AddressFamily _addressFamily;
        private string _amazonAddress;
        private long? _amazonSideAsn;
        private int? _asn;
        private string _authKey;
        private string _awsDeviceV2;
        private List<BGPPeer> _bgpPeers = new List<BGPPeer>();
        private string _connectionId;
        private string _customerAddress;
        private string _customerRouterConfig;
        private string _directConnectGatewayId;
        private bool? _jumboFrameCapable;
        private string _location;
        private int? _mtu;
        private string _ownerAccount;
        private string _region;
        private List<RouteFilterPrefix> _routeFilterPrefixes = new List<RouteFilterPrefix>();
        private List<Tag> _tags = new List<Tag>();
        private string _virtualGatewayId;
        private string _virtualInterfaceId;
        private string _virtualInterfaceName;
        private VirtualInterfaceState _virtualInterfaceState;
        private string _virtualInterfaceType;
        private int? _vlan;

        /// <summary>
        /// Gets and sets the property AddressFamily. 
        /// <para>
        /// The address family for the BGP peer.
        /// </para>
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
        /// <para>
        /// The IP address assigned to the Amazon interface.
        /// </para>
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
        /// Gets and sets the property AmazonSideAsn. 
        /// <para>
        /// The autonomous system number (ASN) for the Amazon side of the connection.
        /// </para>
        /// </summary>
        public long AmazonSideAsn
        {
            get { return this._amazonSideAsn.GetValueOrDefault(); }
            set { this._amazonSideAsn = value; }
        }

        // Check to see if AmazonSideAsn property is set
        internal bool IsSetAmazonSideAsn()
        {
            return this._amazonSideAsn.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Asn. 
        /// <para>
        /// The autonomous system (AS) number for Border Gateway Protocol (BGP) configuration.
        /// </para>
        ///  
        /// <para>
        /// The valid values are 1-2147483647.
        /// </para>
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
        /// <para>
        /// The authentication key for BGP configuration. This string has a minimum length of
        /// 6 characters and and a maximun lenth of 80 characters.
        /// </para>
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
        /// Gets and sets the property AwsDeviceV2. 
        /// <para>
        /// The Direct Connect endpoint on which the virtual interface terminates.
        /// </para>
        /// </summary>
        public string AwsDeviceV2
        {
            get { return this._awsDeviceV2; }
            set { this._awsDeviceV2 = value; }
        }

        // Check to see if AwsDeviceV2 property is set
        internal bool IsSetAwsDeviceV2()
        {
            return this._awsDeviceV2 != null;
        }

        /// <summary>
        /// Gets and sets the property BgpPeers. 
        /// <para>
        /// The BGP peers configured on this virtual interface.
        /// </para>
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
        /// <para>
        /// The ID of the connection.
        /// </para>
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
        /// <para>
        /// The IP address assigned to the customer interface.
        /// </para>
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
        /// The customer router configuration.
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
        /// Gets and sets the property DirectConnectGatewayId. 
        /// <para>
        /// The ID of the Direct Connect gateway.
        /// </para>
        /// </summary>
        public string DirectConnectGatewayId
        {
            get { return this._directConnectGatewayId; }
            set { this._directConnectGatewayId = value; }
        }

        // Check to see if DirectConnectGatewayId property is set
        internal bool IsSetDirectConnectGatewayId()
        {
            return this._directConnectGatewayId != null;
        }

        /// <summary>
        /// Gets and sets the property JumboFrameCapable. 
        /// <para>
        /// Indicates whether jumbo frames (9001 MTU) are supported.
        /// </para>
        /// </summary>
        public bool JumboFrameCapable
        {
            get { return this._jumboFrameCapable.GetValueOrDefault(); }
            set { this._jumboFrameCapable = value; }
        }

        // Check to see if JumboFrameCapable property is set
        internal bool IsSetJumboFrameCapable()
        {
            return this._jumboFrameCapable.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Location. 
        /// <para>
        /// The location of the connection.
        /// </para>
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
        /// Gets and sets the property Mtu. 
        /// <para>
        /// The maximum transmission unit (MTU), in bytes. The supported values are 1500 and 9001.
        /// The default value is 1500.
        /// </para>
        /// </summary>
        public int Mtu
        {
            get { return this._mtu.GetValueOrDefault(); }
            set { this._mtu = value; }
        }

        // Check to see if Mtu property is set
        internal bool IsSetMtu()
        {
            return this._mtu.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property OwnerAccount. 
        /// <para>
        /// The ID of the AWS account that owns the virtual interface.
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
        /// Gets and sets the property Region. 
        /// <para>
        /// The AWS Region where the virtual interface is located.
        /// </para>
        /// </summary>
        public string Region
        {
            get { return this._region; }
            set { this._region = value; }
        }

        // Check to see if Region property is set
        internal bool IsSetRegion()
        {
            return this._region != null;
        }

        /// <summary>
        /// Gets and sets the property RouteFilterPrefixes. 
        /// <para>
        /// The routes to be advertised to the AWS network in this Region. Applies to public virtual
        /// interfaces.
        /// </para>
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
        /// Gets and sets the property Tags. 
        /// <para>
        /// The tags associated with the virtual interface.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1)]
        public List<Tag> Tags
        {
            get { return this._tags; }
            set { this._tags = value; }
        }

        // Check to see if Tags property is set
        internal bool IsSetTags()
        {
            return this._tags != null && this._tags.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property VirtualGatewayId. 
        /// <para>
        /// The ID of the virtual private gateway. Applies only to private virtual interfaces.
        /// </para>
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
        /// <para>
        /// The ID of the virtual interface.
        /// </para>
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
        /// <para>
        /// The name of the virtual interface assigned by the customer network. The name has a
        /// maximum of 100 characters. The following are valid characters: a-z, 0-9 and a hyphen
        /// (-).
        /// </para>
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
        /// <para>
        /// The state of the virtual interface. The following are the possible values:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <code>confirming</code>: The creation of the virtual interface is pending confirmation
        /// from the virtual interface owner. If the owner of the virtual interface is different
        /// from the owner of the connection on which it is provisioned, then the virtual interface
        /// will remain in this state until it is confirmed by the virtual interface owner.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>verifying</code>: This state only applies to public virtual interfaces. Each
        /// public virtual interface needs validation before the virtual interface can be created.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>pending</code>: A virtual interface is in this state from the time that it
        /// is created until the virtual interface is ready to forward traffic.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>available</code>: A virtual interface that is able to forward traffic.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>down</code>: A virtual interface that is BGP down.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>deleting</code>: A virtual interface is in this state immediately after calling
        /// <a>DeleteVirtualInterface</a> until it can no longer forward traffic.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>deleted</code>: A virtual interface that cannot forward traffic.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>rejected</code>: The virtual interface owner has declined creation of the virtual
        /// interface. If a virtual interface in the <code>Confirming</code> state is deleted
        /// by the virtual interface owner, the virtual interface enters the <code>Rejected</code>
        /// state.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>unknown</code>: The state of the virtual interface is not available.
        /// </para>
        ///  </li> </ul>
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
        /// <para>
        /// The type of virtual interface. The possible values are <code>private</code> and <code>public</code>.
        /// </para>
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
        /// <para>
        /// The ID of the VLAN.
        /// </para>
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