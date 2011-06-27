/*******************************************************************************
 * Copyright 2008-2011 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
 *  API Version: 2011-05-15
 */

using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;

namespace Amazon.EC2.Model
{
    ///<summary>
    ///VPN Connection
    ///</summary>
    [XmlRootAttribute(Namespace = "http://ec2.amazonaws.com/doc/2011-05-15/", IsNullable = false)]
    public class VpnConnection
    {    
        private string vpnConnectionIdField;
        private string vpnConnectionStateField;
        private string customerGatewayConfigurationField;
        private string typeField;
        private string customerGatewayIdField;
        private string vpnGatewayIdField;
        private List<Tag> tagField;

        /// <summary>
        /// Gets and sets the VpnConnectionId property.
        /// The ID of the VPN connection
        /// </summary>
        [XmlElementAttribute(ElementName = "VpnConnectionId")]
        public string VpnConnectionId
        {
            get { return this.vpnConnectionIdField; }
            set { this.vpnConnectionIdField = value; }
        }

        /// <summary>
        /// Sets the VpnConnectionId property
        /// </summary>
        /// <param name="vpnConnectionId">The ID of the VPN connection</param>
        /// <returns>this instance</returns>
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
        /// Gets and sets the VpnConnectionState property.
        /// The current state of the VPN connection
        /// (pending, available, deleting, deleted)
        /// </summary>
        [XmlElementAttribute(ElementName = "VpnConnectionState")]
        public string VpnConnectionState
        {
            get { return this.vpnConnectionStateField; }
            set { this.vpnConnectionStateField = value; }
        }

        /// <summary>
        /// Sets the VpnConnectionState property
        /// </summary>
        /// <param name="vpnConnectionState">The current state of the VPN connection
        /// (pending, available, deleting, deleted)</param>
        /// <returns>this instance</returns>
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
        /// Gets and sets the CustomerGatewayConfiguration property.
        /// Configuration information for the VPN
        /// connection's customer gateway (in the
        /// native XML format).
        /// </summary>
        [XmlElementAttribute(ElementName = "CustomerGatewayConfiguration")]
        public string CustomerGatewayConfiguration
        {
            get { return this.customerGatewayConfigurationField; }
            set { this.customerGatewayConfigurationField = value; }
        }

        /// <summary>
        /// Sets the CustomerGatewayConfiguration property
        /// </summary>
        /// <param name="customerGatewayConfiguration">Configuration information for the VPN
        /// connection's customer gateway (in the
        /// native XML format).</param>
        /// <returns>this instance</returns>
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
        /// Gets and sets the Type property.
        /// The type of VPN connection (ipsec.1).
        /// </summary>
        [XmlElementAttribute(ElementName = "Type")]
        public string Type
        {
            get { return this.typeField; }
            set { this.typeField = value; }
        }

        /// <summary>
        /// Sets the Type property
        /// </summary>
        /// <param name="type">The type of VPN connection (ipsec.1).</param>
        /// <returns>this instance</returns>
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
        /// Gets and sets the CustomerGatewayId property.
        /// ID of the customer gateway at your end of the
        /// VPN connection
        /// </summary>
        [XmlElementAttribute(ElementName = "CustomerGatewayId")]
        public string CustomerGatewayId
        {
            get { return this.customerGatewayIdField; }
            set { this.customerGatewayIdField = value; }
        }

        /// <summary>
        /// Sets the CustomerGatewayId property
        /// </summary>
        /// <param name="customerGatewayId">ID of the customer gateway at your end of the
        /// VPN connection</param>
        /// <returns>this instance</returns>
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
        /// Gets and sets the VpnGatewayId property.
        /// ID of the VPN gateway at the VPC end of the VPN
        /// connection
        /// </summary>
        [XmlElementAttribute(ElementName = "VpnGatewayId")]
        public string VpnGatewayId
        {
            get { return this.vpnGatewayIdField; }
            set { this.vpnGatewayIdField = value; }
        }

        /// <summary>
        /// Sets the VpnGatewayId property
        /// </summary>
        /// <param name="vpnGatewayId">ID of the VPN gateway at the VPC end of the VPN
        /// connection</param>
        /// <returns>this instance</returns>
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
        /// Gets and sets the Tag property.
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
        /// Sets the Tag property
        /// </summary>
        /// <param name="list">Tag property</param>
        /// <returns>this instance</returns>
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

    }
}
