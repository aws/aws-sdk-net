/*
 * Copyright 2010-2013 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using Amazon.Runtime;

namespace Amazon.DirectConnect.Model
{
    /// <summary>
    /// <para>A virtual interface (VLAN) transmits the traffic between the Direct Connect location and the customer.</para>
    /// </summary>
    public partial class AllocatePublicVirtualInterfaceResult : AmazonWebServiceResponse
    {
        
        private string ownerAccount;
        private string virtualInterfaceId;
        private string location;
        private string connectionId;
        private string virtualInterfaceType;
        private string virtualInterfaceName;
        private int? vlan;
        private int? asn;
        private string authKey;
        private string amazonAddress;
        private string customerAddress;
        private VirtualInterfaceState virtualInterfaceState;
        private string customerRouterConfig;
        private string virtualGatewayId;
        private List<RouteFilterPrefix> routeFilterPrefixes = new List<RouteFilterPrefix>();

        public string OwnerAccount
        {
            get { return this.ownerAccount; }
            set { this.ownerAccount = value; }
        }

        // Check to see if OwnerAccount property is set
        internal bool IsSetOwnerAccount()
        {
            return this.ownerAccount != null;
        }

        /// <summary>
        /// ID of the virtual interface. Example: dxvif-123dfg56 Default: None
        ///  
        /// </summary>
        public string VirtualInterfaceId
        {
            get { return this.virtualInterfaceId; }
            set { this.virtualInterfaceId = value; }
        }

        // Check to see if VirtualInterfaceId property is set
        internal bool IsSetVirtualInterfaceId()
        {
            return this.virtualInterfaceId != null;
        }

        /// <summary>
        /// Where the connection is located. Example: EqSV5 Default: None
        ///  
        /// </summary>
        public string Location
        {
            get { return this.location; }
            set { this.location = value; }
        }

        // Check to see if Location property is set
        internal bool IsSetLocation()
        {
            return this.location != null;
        }

        /// <summary>
        /// ID of the connection. Example: dxcon-fg5678gh Default: None
        ///  
        /// </summary>
        public string ConnectionId
        {
            get { return this.connectionId; }
            set { this.connectionId = value; }
        }

        // Check to see if ConnectionId property is set
        internal bool IsSetConnectionId()
        {
            return this.connectionId != null;
        }

        /// <summary>
        /// The type of virtual interface Example: private (Amazon VPC) or public (Amazon S3, Amazon DynamoDB, etc.)
        ///  
        /// </summary>
        public string VirtualInterfaceType
        {
            get { return this.virtualInterfaceType; }
            set { this.virtualInterfaceType = value; }
        }

        // Check to see if VirtualInterfaceType property is set
        internal bool IsSetVirtualInterfaceType()
        {
            return this.virtualInterfaceType != null;
        }

        /// <summary>
        /// The name of the virtual interface assigned by the customer Example: "My VPC"
        ///  
        /// </summary>
        public string VirtualInterfaceName
        {
            get { return this.virtualInterfaceName; }
            set { this.virtualInterfaceName = value; }
        }

        // Check to see if VirtualInterfaceName property is set
        internal bool IsSetVirtualInterfaceName()
        {
            return this.virtualInterfaceName != null;
        }

        /// <summary>
        /// VLAN ID Example: 101
        ///  
        /// </summary>
        public int Vlan
        {
            get { return this.vlan ?? default(int); }
            set { this.vlan = value; }
        }

        // Check to see if Vlan property is set
        internal bool IsSetVlan()
        {
            return this.vlan.HasValue;
        }

        /// <summary>
        /// Autonomous system (AS) number for Border Gateway Protocol (BGP) configuration Example: 65000
        ///  
        /// </summary>
        public int Asn
        {
            get { return this.asn ?? default(int); }
            set { this.asn = value; }
        }

        // Check to see if Asn property is set
        internal bool IsSetAsn()
        {
            return this.asn.HasValue;
        }

        /// <summary>
        /// Authentication key for BGP configuration Example: asdf34example
        ///  
        /// </summary>
        public string AuthKey
        {
            get { return this.authKey; }
            set { this.authKey = value; }
        }

        // Check to see if AuthKey property is set
        internal bool IsSetAuthKey()
        {
            return this.authKey != null;
        }

        /// <summary>
        /// IP address assigned to the Amazon interface. Example: 192.168.1.1/30
        ///  
        /// </summary>
        public string AmazonAddress
        {
            get { return this.amazonAddress; }
            set { this.amazonAddress = value; }
        }

        // Check to see if AmazonAddress property is set
        internal bool IsSetAmazonAddress()
        {
            return this.amazonAddress != null;
        }

        /// <summary>
        /// IP address assigned to the customer interface. Example: 192.168.1.2/30
        ///  
        /// </summary>
        public string CustomerAddress
        {
            get { return this.customerAddress; }
            set { this.customerAddress = value; }
        }

        // Check to see if CustomerAddress property is set
        internal bool IsSetCustomerAddress()
        {
            return this.customerAddress != null;
        }

        /// <summary>
        /// State of the virtual interface. <ul> <li><b>Confirming</b>: The creation of the virtual interface is pending confirmation from the virtual
        /// interface owner. If the owner of the virtual interface is different from the owner of the connection on which it is provisioned, then the
        /// virtual interface will remain in this state until it is confirmed by the virtual interface owner.</li> <li><b>Verifying</b>: This state only
        /// applies to public virtual interfaces. Each public virtual interface needs validation before the virtual interface can be created.</li>
        /// <li><b>Pending</b>: A virtual interface is in this state from the time that it is created until the virtual interface is ready to forward
        /// traffic.</li> <li><b>Available</b>: A virtual interface that is able to forward traffic.</li> <li><b>Deleting</b>: A virtual interface is in
        /// this state immediately after calling <i>DeleteVirtualInterface</i> until it can no longer forward traffic.</li> <li><b>Deleted</b>: A
        /// virtual interface that cannot forward traffic.</li> <li><b>Rejected</b>: The virtual interface owner has declined creation of the virtual
        /// interface. If a virtual interface in the 'Confirming' state is deleted by the virtual interface owner, the virtual interface will enter the
        /// 'Rejected' state.</li> </ul>
        ///  
        /// <para>
        /// <b>Constraints:</b>
        /// <list type="definition">
        ///     <item>
        ///         <term>Allowed Values</term>
        ///         <description>confirming, verifying, pending, available, deleting, deleted, rejected</description>
        ///     </item>
        /// </list>
        /// </para>
        /// </summary>
        public VirtualInterfaceState VirtualInterfaceState
        {
            get { return this.virtualInterfaceState; }
            set { this.virtualInterfaceState = value; }
        }

        // Check to see if VirtualInterfaceState property is set
        internal bool IsSetVirtualInterfaceState()
        {
            return this.virtualInterfaceState != null;
        }

        /// <summary>
        /// Information for generating the customer router configuration.
        ///  
        /// </summary>
        public string CustomerRouterConfig
        {
            get { return this.customerRouterConfig; }
            set { this.customerRouterConfig = value; }
        }

        // Check to see if CustomerRouterConfig property is set
        internal bool IsSetCustomerRouterConfig()
        {
            return this.customerRouterConfig != null;
        }

        /// <summary>
        /// The ID of the virtual private gateway to a VPC. Only applies to private virtual interfaces. Example: vgw-123er56
        ///  
        /// </summary>
        public string VirtualGatewayId
        {
            get { return this.virtualGatewayId; }
            set { this.virtualGatewayId = value; }
        }

        // Check to see if VirtualGatewayId property is set
        internal bool IsSetVirtualGatewayId()
        {
            return this.virtualGatewayId != null;
        }

        /// <summary>
        /// A list of routes to be advertised to the AWS network in this region (public virtual interface) or your VPC (private virtual interface).
        ///  
        /// </summary>
        public List<RouteFilterPrefix> RouteFilterPrefixes
        {
            get { return this.routeFilterPrefixes; }
            set { this.routeFilterPrefixes = value; }
        }

        // Check to see if RouteFilterPrefixes property is set
        internal bool IsSetRouteFilterPrefixes()
        {
            return this.routeFilterPrefixes.Count > 0;
        }
    }
}
