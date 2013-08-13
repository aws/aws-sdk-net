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
    /// VPN Connection
    /// </summary>
    [XmlRootAttribute(IsNullable = false)]
    public class VpnConnection
    {    
        private string vpnConnectionIdField;
        private string vpnConnectionStateField;
        private string customerGatewayConfigurationField;
        private string typeField;
        private string customerGatewayIdField;
        private string vpnGatewayIdField;
        private List<Tag> tagField;
        private List<VpnTunnelTelemetry> vgwTelemetryField;
        private bool? staticRoutesOnlyField;
        private List<VpnStaticRoute> routesField;

        /// <summary>
        /// The ID of the VPN connection
        /// </summary>
        [XmlElementAttribute(ElementName = "VpnConnectionId")]
        public string VpnConnectionId
        {
            get { return this.vpnConnectionIdField; }
            set { this.vpnConnectionIdField = value; }
        }

        /// <summary>
        /// Sets the ID of the VPN connection
        /// </summary>
        /// <param name="vpnConnectionId">The ID of the VPN connection</param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public VpnConnection WithVpnConnectionId(string vpnConnectionId)
        {
            this.vpnConnectionIdField = vpnConnectionId;
            return this;
        }

        /// <summary>
        /// Checks if VpnConnectionId property is set
        /// </summary>
        /// <returns>true if VpnConnectionId property is set</returns>
        public bool IsSetVpnConnectionId()
        {
            return this.vpnConnectionIdField != null;
        }

        /// <summary>
        /// The current state of the VPN connection.
        /// Valid values: pending, available, deleting, deleted
        /// </summary>
        [XmlElementAttribute(ElementName = "VpnConnectionState")]
        public string VpnConnectionState
        {
            get { return this.vpnConnectionStateField; }
            set { this.vpnConnectionStateField = value; }
        }

        /// <summary>
        /// Sets the current state of the VPN connection.
        /// </summary>
        /// <param name="vpnConnectionState">The current state of the VPN connection
        /// (pending, available, deleting, deleted)</param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public VpnConnection WithVpnConnectionState(string vpnConnectionState)
        {
            this.vpnConnectionStateField = vpnConnectionState;
            return this;
        }

        /// <summary>
        /// Checks if VpnConnectionState property is set
        /// </summary>
        /// <returns>true if VpnConnectionState property is set</returns>
        public bool IsSetVpnConnectionState()
        {
            return this.vpnConnectionStateField != null;
        }

        /// <summary>
        /// Configuration information for the VPN connection's customer gateway.
        /// Configuration is in the native XML format.
        /// </summary>
        [XmlElementAttribute(ElementName = "CustomerGatewayConfiguration")]
        public string CustomerGatewayConfiguration
        {
            get { return this.customerGatewayConfigurationField; }
            set { this.customerGatewayConfigurationField = value; }
        }

        /// <summary>
        /// Sets the configuration information for the VPN connection's customer gateway.
        /// </summary>
        /// <param name="customerGatewayConfiguration">Configuration information for the VPN
        /// connection's customer gateway (in the
        /// native XML format).</param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public VpnConnection WithCustomerGatewayConfiguration(string customerGatewayConfiguration)
        {
            this.customerGatewayConfigurationField = customerGatewayConfiguration;
            return this;
        }

        /// <summary>
        /// Checks if CustomerGatewayConfiguration property is set
        /// </summary>
        /// <returns>true if CustomerGatewayConfiguration property is set</returns>
        public bool IsSetCustomerGatewayConfiguration()
        {
            return this.customerGatewayConfigurationField != null;
        }

        /// <summary>
        /// The type of VPN connection (ipsec.1).
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
        /// <param name="type">The type of VPN connection (ipsec.1).</param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public VpnConnection WithType(string type)
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
        /// ID of the customer gateway at your end of the VPN connection.
        /// </summary>
        [XmlElementAttribute(ElementName = "CustomerGatewayId")]
        public string CustomerGatewayId
        {
            get { return this.customerGatewayIdField; }
            set { this.customerGatewayIdField = value; }
        }

        /// <summary>
        /// Sets the ID of the customer gateway at your end of the VPN connection.
        /// </summary>
        /// <param name="customerGatewayId">ID of the customer gateway at your end of the
        /// VPN connection</param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public VpnConnection WithCustomerGatewayId(string customerGatewayId)
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
        /// ID of the VPN gateway at the VPC end of the VPN connection.
        /// </summary>
        [XmlElementAttribute(ElementName = "VpnGatewayId")]
        public string VpnGatewayId
        {
            get { return this.vpnGatewayIdField; }
            set { this.vpnGatewayIdField = value; }
        }

        /// <summary>
        /// Sets the ID of the VPN gateway at the VPC end of the VPN connection.
        /// </summary>
        /// <param name="vpnGatewayId">ID of the VPN gateway at the VPC end of the VPN
        /// connection</param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public VpnConnection WithVpnGatewayId(string vpnGatewayId)
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
        /// Tags assigned to the resource.
        /// </summary>
        [XmlElementAttribute(ElementName = "Tag")]
        public List<Tag> Tag
        {
            get
            {
                if (this.tagField == null)
                {
                    this.tagField = new List<Tag>();
                }
                return this.tagField;
            }
            set { this.tagField = value; }
        }

        /// <summary>
        /// Sets the tags assigned to the resource.
        /// </summary>
        /// <param name="list">Tag property</param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public VpnConnection WithTag(params Tag[] list)
        {
            foreach (Tag item in list)
            {
                Tag.Add(item);
            }
            return this;
        }

        /// <summary>
        /// Checks if Tag property is set
        /// </summary>
        /// <returns>true if Tag property is set</returns>
        public bool IsSetTag()
        {
            return (Tag.Count > 0);
        }

        /// <summary>
        /// Information about the virtual private gateway.
        /// </summary>
        [XmlElementAttribute(ElementName = "VgwTelemetry")]
        public List<VpnTunnelTelemetry> VgwTelemetry
        {
            get 
            {
                if (this.vgwTelemetryField == null)
                {
                    this.vgwTelemetryField = new List<VpnTunnelTelemetry>();
                }
                
                return this.vgwTelemetryField; 
            }
            set { this.vgwTelemetryField = value; }
        }

        /// <summary>
        /// Sets the information about the virtual private gateway.
        /// </summary>
        /// <param name="list">The virtual private gateways.</param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public VpnConnection WithVgwTelemetry(params VpnTunnelTelemetry[] list)
        {
            foreach (VpnTunnelTelemetry item in list)
            {
                VgwTelemetry.Add(item);
            }

            return this;
        }

        /// <summary>
        /// Checks if VgwTelemetry property is set
        /// </summary>
        /// <returns>True if the VgwTelemetry property is set</returns>
        public bool IsSetVgwTelemetry()
        {
            return (VgwTelemetry.Count > 0);
        }

        /// <summary>
        /// Whether or not the VPN connection uses static routes only.
        /// Static routes must be used for devices that do not support BGP.
        /// </summary>
        [XmlElementAttribute(ElementName = "StaticRoutesOnly")]
        public bool StaticRoutesOnly
        {
            get { return this.staticRoutesOnlyField.GetValueOrDefault(); }
            set { this.staticRoutesOnlyField = value; }
        }

        /// <summary>
        /// Sets whether or not the VPN connection uses static routes only.
        /// </summary>
        /// <param name="staticRoutesOnly">Static routes only value</param>
        /// <returns>This instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public VpnConnection WithStaticRoutesOnly(bool staticRoutesOnly)
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

        /// <summary>
        /// Static routes associated with a VPN connection.
        /// </summary>
        [XmlElementAttribute(ElementName = "Routes")]
        public List<VpnStaticRoute> Routes
        {
            get
            {
                if (this.routesField == null)
                {
                    this.routesField = new List<VpnStaticRoute>();
                }
                return this.routesField;
            }
            set { this.routesField = value; }
        }

        /// <summary>
        /// Sets the set of static routes associated with a VPN connection.
        /// </summary>
        /// <param name="list">Set of static routes</param>
        /// <returns>This instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public VpnConnection WithRoutes(params VpnStaticRoute[] list)
        {
            foreach (VpnStaticRoute item in list)
            {
                this.Routes.Add(item);
            }

            return this;
        }

        /// <summary>
        /// Checks if the Routes property is set.
        /// </summary>
        /// <returns>True if the property is set</returns>
        public bool IsSetRoutes()
        {
            return (this.Routes.Count > 0);
        }
    }
}
