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

namespace Amazon.DirectConnect.Model
{
    /// <summary>
    /// <para> A virtual interface (VLAN) transmits the traffic between the Direct Connect location and the customer. </para>
    /// </summary>
    public class CreatePrivateVirtualInterfaceResult  
    {
        
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
        private string virtualInterfaceState;
        private string customerRouterConfig;
        private string virtualGatewayId;
        private List<RouteFilterPrefix> routeFilterPrefixes = new List<RouteFilterPrefix>();

        /// <summary>
        /// ID of the virtual interface. Example: dxvif-123dfg56 Default: None
        ///  
        /// </summary>
        public string VirtualInterfaceId
        {
            get { return this.virtualInterfaceId; }
            set { this.virtualInterfaceId = value; }
        }

        /// <summary>
        /// Sets the VirtualInterfaceId property
        /// </summary>
        /// <param name="virtualInterfaceId">The value to set for the VirtualInterfaceId property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public CreatePrivateVirtualInterfaceResult WithVirtualInterfaceId(string virtualInterfaceId)
        {
            this.virtualInterfaceId = virtualInterfaceId;
            return this;
        }
            

        // Check to see if VirtualInterfaceId property is set
        internal bool IsSetVirtualInterfaceId()
        {
            return this.virtualInterfaceId != null;       
        }

        /// <summary>
        /// The AWS Direct Connect location where the offering is located. Example: EqSV5 Default: None
        ///  
        /// </summary>
        public string Location
        {
            get { return this.location; }
            set { this.location = value; }
        }

        /// <summary>
        /// Sets the Location property
        /// </summary>
        /// <param name="location">The value to set for the Location property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public CreatePrivateVirtualInterfaceResult WithLocation(string location)
        {
            this.location = location;
            return this;
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

        /// <summary>
        /// Sets the ConnectionId property
        /// </summary>
        /// <param name="connectionId">The value to set for the ConnectionId property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public CreatePrivateVirtualInterfaceResult WithConnectionId(string connectionId)
        {
            this.connectionId = connectionId;
            return this;
        }
            

        // Check to see if ConnectionId property is set
        internal bool IsSetConnectionId()
        {
            return this.connectionId != null;       
        }

        /// <summary>
        /// The type of virtual interface Example: private (VPC) or public (S3, DynamoDB, etc.)
        ///  
        /// </summary>
        public string VirtualInterfaceType
        {
            get { return this.virtualInterfaceType; }
            set { this.virtualInterfaceType = value; }
        }

        /// <summary>
        /// Sets the VirtualInterfaceType property
        /// </summary>
        /// <param name="virtualInterfaceType">The value to set for the VirtualInterfaceType property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public CreatePrivateVirtualInterfaceResult WithVirtualInterfaceType(string virtualInterfaceType)
        {
            this.virtualInterfaceType = virtualInterfaceType;
            return this;
        }
            

        // Check to see if VirtualInterfaceType property is set
        internal bool IsSetVirtualInterfaceType()
        {
            return this.virtualInterfaceType != null;       
        }

        /// <summary>
        /// The name of the virtual interface assigned by the customer Example: "Dev VPC"
        ///  
        /// </summary>
        public string VirtualInterfaceName
        {
            get { return this.virtualInterfaceName; }
            set { this.virtualInterfaceName = value; }
        }

        /// <summary>
        /// Sets the VirtualInterfaceName property
        /// </summary>
        /// <param name="virtualInterfaceName">The value to set for the VirtualInterfaceName property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public CreatePrivateVirtualInterfaceResult WithVirtualInterfaceName(string virtualInterfaceName)
        {
            this.virtualInterfaceName = virtualInterfaceName;
            return this;
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

        /// <summary>
        /// Sets the Vlan property
        /// </summary>
        /// <param name="vlan">The value to set for the Vlan property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public CreatePrivateVirtualInterfaceResult WithVlan(int vlan)
        {
            this.vlan = vlan;
            return this;
        }
            

        // Check to see if Vlan property is set
        internal bool IsSetVlan()
        {
            return this.vlan.HasValue;       
        }

        /// <summary>
        /// AS number for BGP configuration Example: 65000
        ///  
        /// </summary>
        public int Asn
        {
            get { return this.asn ?? default(int); }
            set { this.asn = value; }
        }

        /// <summary>
        /// Sets the Asn property
        /// </summary>
        /// <param name="asn">The value to set for the Asn property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public CreatePrivateVirtualInterfaceResult WithAsn(int asn)
        {
            this.asn = asn;
            return this;
        }
            

        // Check to see if Asn property is set
        internal bool IsSetAsn()
        {
            return this.asn.HasValue;       
        }

        /// <summary>
        /// Authentication key for BGP configuration Example: asdf345vjkl12
        ///  
        /// </summary>
        public string AuthKey
        {
            get { return this.authKey; }
            set { this.authKey = value; }
        }

        /// <summary>
        /// Sets the AuthKey property
        /// </summary>
        /// <param name="authKey">The value to set for the AuthKey property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public CreatePrivateVirtualInterfaceResult WithAuthKey(string authKey)
        {
            this.authKey = authKey;
            return this;
        }
            

        // Check to see if AuthKey property is set
        internal bool IsSetAuthKey()
        {
            return this.authKey != null;       
        }

        /// <summary>
        /// Address assigned to the Amazon interface. Example: 192.168.1.1
        ///  
        /// </summary>
        public string AmazonAddress
        {
            get { return this.amazonAddress; }
            set { this.amazonAddress = value; }
        }

        /// <summary>
        /// Sets the AmazonAddress property
        /// </summary>
        /// <param name="amazonAddress">The value to set for the AmazonAddress property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public CreatePrivateVirtualInterfaceResult WithAmazonAddress(string amazonAddress)
        {
            this.amazonAddress = amazonAddress;
            return this;
        }
            

        // Check to see if AmazonAddress property is set
        internal bool IsSetAmazonAddress()
        {
            return this.amazonAddress != null;       
        }

        /// <summary>
        /// Address assigned to the customer interface. Example: 192.168.1.2
        ///  
        /// </summary>
        public string CustomerAddress
        {
            get { return this.customerAddress; }
            set { this.customerAddress = value; }
        }

        /// <summary>
        /// Sets the CustomerAddress property
        /// </summary>
        /// <param name="customerAddress">The value to set for the CustomerAddress property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public CreatePrivateVirtualInterfaceResult WithCustomerAddress(string customerAddress)
        {
            this.customerAddress = customerAddress;
            return this;
        }
            

        // Check to see if CustomerAddress property is set
        internal bool IsSetCustomerAddress()
        {
            return this.customerAddress != null;       
        }

        /// <summary>
        /// State of the virtual interface. <ul> <li><b>Verifying</b>: This state only applies to public virtual interfaces. Each public virtual
        /// interface need validation before the virtual interface can be created.</li> <li><b>Pending</b>: A virtual interface is in this state from
        /// the time that it is created until the virtual interface is ready to forward traffic.</li> <li><b>Available</b>: A virtual interface that is
        /// able to forward traffic.</li> <li><b>Deleting</b>: A virtual interface is in this state immediately after calling
        /// <i>DeleteVirtualInterface</i> until it can no longer forward traffic.</li> <li><b>Deleted</b>: A virtual interface that cannot forward
        /// traffic.</li> </ul>
        ///  
        /// <para>
        /// <b>Constraints:</b>
        /// <list type="definition">
        ///     <item>
        ///         <term>Allowed Values</term>
        ///         <description>verifying, pending, available, deleting, deleted</description>
        ///     </item>
        /// </list>
        /// </para>
        /// </summary>
        public string VirtualInterfaceState
        {
            get { return this.virtualInterfaceState; }
            set { this.virtualInterfaceState = value; }
        }

        /// <summary>
        /// Sets the VirtualInterfaceState property
        /// </summary>
        /// <param name="virtualInterfaceState">The value to set for the VirtualInterfaceState property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public CreatePrivateVirtualInterfaceResult WithVirtualInterfaceState(string virtualInterfaceState)
        {
            this.virtualInterfaceState = virtualInterfaceState;
            return this;
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

        /// <summary>
        /// Sets the CustomerRouterConfig property
        /// </summary>
        /// <param name="customerRouterConfig">The value to set for the CustomerRouterConfig property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public CreatePrivateVirtualInterfaceResult WithCustomerRouterConfig(string customerRouterConfig)
        {
            this.customerRouterConfig = customerRouterConfig;
            return this;
        }
            

        // Check to see if CustomerRouterConfig property is set
        internal bool IsSetCustomerRouterConfig()
        {
            return this.customerRouterConfig != null;       
        }

        /// <summary>
        /// Virtual private gateway to a VPC. Example: vgw-123er56
        ///  
        /// </summary>
        public string VirtualGatewayId
        {
            get { return this.virtualGatewayId; }
            set { this.virtualGatewayId = value; }
        }

        /// <summary>
        /// Sets the VirtualGatewayId property
        /// </summary>
        /// <param name="virtualGatewayId">The value to set for the VirtualGatewayId property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public CreatePrivateVirtualInterfaceResult WithVirtualGatewayId(string virtualGatewayId)
        {
            this.virtualGatewayId = virtualGatewayId;
            return this;
        }
            

        // Check to see if VirtualGatewayId property is set
        internal bool IsSetVirtualGatewayId()
        {
            return this.virtualGatewayId != null;       
        }

        /// <summary>
        /// A list of route filter prefixes.
        ///  
        /// </summary>
        public List<RouteFilterPrefix> RouteFilterPrefixes
        {
            get { return this.routeFilterPrefixes; }
            set { this.routeFilterPrefixes = value; }
        }
        /// <summary>
        /// Adds elements to the RouteFilterPrefixes collection
        /// </summary>
        /// <param name="routeFilterPrefixes">The values to add to the RouteFilterPrefixes collection </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public CreatePrivateVirtualInterfaceResult WithRouteFilterPrefixes(params RouteFilterPrefix[] routeFilterPrefixes)
        {
            foreach (RouteFilterPrefix element in routeFilterPrefixes)
            {
                this.routeFilterPrefixes.Add(element);
            }

            return this;
        }
        
        /// <summary>
        /// Adds elements to the RouteFilterPrefixes collection
        /// </summary>
        /// <param name="routeFilterPrefixes">The values to add to the RouteFilterPrefixes collection </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public CreatePrivateVirtualInterfaceResult WithRouteFilterPrefixes(IEnumerable<RouteFilterPrefix> routeFilterPrefixes)
        {
            foreach (RouteFilterPrefix element in routeFilterPrefixes)
            {
                this.routeFilterPrefixes.Add(element);
            }

            return this;
        }

        // Check to see if RouteFilterPrefixes property is set
        internal bool IsSetRouteFilterPrefixes()
        {
            return this.routeFilterPrefixes.Count > 0;       
        }
    }
}
