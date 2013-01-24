/*******************************************************************************
 * Copyright 2008-2013 Amazon.com, Inc. or its affiliates. All Rights Reserved.
 * Licensed under the Apache License, Version 2.0 (the "License"). You may not use
 * this file except in compliance with the License. A copy of the License is located at
 *
 * http://aws.amazon.com/apache2.0
 *
 * or in the "license" file accompanying this file. This file is distributed on
 * an "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express
 * or implied. See the License for the specific language governing permissions and
 * limitations under the License.
 * *****************************************************************************
 *    __  _    _  ___
 *   (  )( \/\/ )/ __)
 *   /__\ \    / \__ \
 *  (_)(_) \/\/  (___/
 *
 *  AWS SDK for .NET
 */

using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;

namespace Amazon.EC2.Model
{
    /// <summary>
    /// Creates a VPN connection between an existing virtual private gateway and a VPN customer gateway.
    /// The only supported connection type is ipsec.1.
    /// </summary>
    /// <remarks>
    /// The response includes information that you need to configure your customer gateway, in XML format.
    /// 
    /// It is strongly recommend that you use HTTPS when calling this operation because the response
    /// contains sensitive cryptographic information for configuring your customer gateway.
    /// If you shut down your VPN connection for any reason and later create a new VPN connection, you must
    /// reconfigure your customer gateway with the new information returned from CreateVpnConnection.
    /// </remarks>
    [XmlRootAttribute(IsNullable = false)]
    public class CreateVpnConnectionRequest
    {    
        private string typeField;
        private string customerGatewayIdField;
        private string vpnGatewayIdField;
        private bool? staticRoutesOnlyField;

        /// <summary>
        /// The type of VPN connection.
        /// The only supported connection type is ipsec.1.
        /// </summary>
        [XmlElementAttribute(ElementName = "Type")]
        public string Type
        {
            get { return this.typeField; }
            set { this.typeField = value; }
        }

        /// <summary>
        /// Sets the type of VPN connection.
        /// </summary>
        /// <param name="type">The type of VPN connection</param>
        /// <returns>this instance</returns>
        public CreateVpnConnectionRequest WithType(string type)
        {
            this.typeField = type;
            return this;
        }

        /// <summary>
        /// Checks if Type property is set
        /// </summary>
        /// <returns>true if Type property is set</returns>
        public bool IsSetType()
        {
            return this.typeField != null;
        }

        /// <summary>
        /// The ID of the customer gateway.
        /// </summary>
        [XmlElementAttribute(ElementName = "CustomerGatewayId")]
        public string CustomerGatewayId
        {
            get { return this.customerGatewayIdField; }
            set { this.customerGatewayIdField = value; }
        }

        /// <summary>
        /// Sets the ID of the customer gateway.
        /// </summary>
        /// <param name="customerGatewayId">The ID of the customer gateway.</param>
        /// <returns>this instance</returns>
        public CreateVpnConnectionRequest WithCustomerGatewayId(string customerGatewayId)
        {
            this.customerGatewayIdField = customerGatewayId;
            return this;
        }

        /// <summary>
        /// Checks if CustomerGatewayId property is set
        /// </summary>
        /// <returns>true if CustomerGatewayId property is set</returns>
        public bool IsSetCustomerGatewayId()
        {
            return this.customerGatewayIdField != null;
        }

        /// <summary>
        /// The ID of the VPN gateway.
        /// </summary>
        [XmlElementAttribute(ElementName = "VpnGatewayId")]
        public string VpnGatewayId
        {
            get { return this.vpnGatewayIdField; }
            set { this.vpnGatewayIdField = value; }
        }

        /// <summary>
        /// Sets the ID of the VPN gateway.
        /// </summary>
        /// <param name="vpnGatewayId">The ID of the VPN gateway.</param>
        /// <returns>this instance</returns>
        public CreateVpnConnectionRequest WithVpnGatewayId(string vpnGatewayId)
        {
            this.vpnGatewayIdField = vpnGatewayId;
            return this;
        }

        /// <summary>
        /// Checks if VpnGatewayId property is set
        /// </summary>
        /// <returns>true if VpnGatewayId property is set</returns>
        public bool IsSetVpnGatewayId()
        {
            return this.vpnGatewayIdField != null;
        }

        /// <summary>
        /// Whether or not the VPN connection requires static routes.
        /// </summary>
        /// <remarks>
        /// If you are creating a VPN connection for a device that does not support BGP,
        /// you must specify this value as true.
        /// </remarks>
        [XmlElementAttribute(ElementName = "StaticRoutesOnly")]
        public bool StaticRoutesOnly
        {
            get { return this.staticRoutesOnlyField.GetValueOrDefault(); }
            set { this.staticRoutesOnlyField = value; }
        }

        /// <summary>
        /// Sets whether or not the VPN connection requires static routes.
        /// </summary>
        /// <param name="staticRoutesOnly">Static routes only value</param>
        /// <returns>This instance</returns>
        /// <remarks>
        /// A Boolean value indicating whether or not the VPN connection requires static routes. 
        /// If you are creating a VPN connection for a device that does not support BGP, you must 
        /// specify this value as true.
        /// </remarks>
        public CreateVpnConnectionRequest WithStaticRoutesOnly(bool staticRoutesOnly)
        {
            this.staticRoutesOnlyField = staticRoutesOnly;
            return this;
        }

        /// <summary>
        /// Checks if the StaticRoutesOnly property is set.
        /// </summary>
        /// <returns>True if the property is set</returns>
        public bool IsSetStaticRoutesOnly()
        {
            return this.staticRoutesOnlyField != null;
        }
    }
}
