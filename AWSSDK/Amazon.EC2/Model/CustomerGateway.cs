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
    /// Customer Gateway
    /// </summary>
    [XmlRootAttribute(IsNullable = false)]
    public class CustomerGateway
    {    
        private string customerGatewayIdField;
        private string customerGatewayStateField;
        private string typeField;
        private string ipAddressField;
        private string bgpAsnField;
        private List<Tag> tagField;

        /// <summary>
        /// The ID of the customer gateway
        /// </summary>
        [XmlElementAttribute(ElementName = "CustomerGatewayId")]
        public string CustomerGatewayId
        {
            get { return this.customerGatewayIdField; }
            set { this.customerGatewayIdField = value; }
        }

        /// <summary>
        /// Sets the ID of the customer gateway
        /// </summary>
        /// <param name="customerGatewayId">The ID of the customer gateway</param>
        /// <returns>this instance</returns>
        public CustomerGateway WithCustomerGatewayId(string customerGatewayId)
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
        /// The current state of the customer gateway
        /// (pending, available, deleting, deleted)
        /// </summary>
        [XmlElementAttribute(ElementName = "CustomerGatewayState")]
        public string CustomerGatewayState
        {
            get { return this.customerGatewayStateField; }
            set { this.customerGatewayStateField = value; }
        }

        /// <summary>
        /// Sets the current state of the customer gateway.
        /// </summary>
        /// <param name="customerGatewayState">The current state of the customer gateway
        /// (pending, available, deleting, deleted)</param>
        /// <returns>this instance</returns>
        public CustomerGateway WithCustomerGatewayState(string customerGatewayState)
        {
            this.customerGatewayStateField = customerGatewayState;
            return this;
        }

        /// <summary>
        /// Checks if CustomerGatewayState property is set
        /// </summary>
        /// <returns>true if CustomerGatewayState property is set</returns>
        public bool IsSetCustomerGatewayState()
        {
            return this.customerGatewayStateField != null;
        }

        /// <summary>
        /// The type of VPN connection the customer gateway supports (ipsec.1).
        /// </summary>
        [XmlElementAttribute(ElementName = "Type")]
        public string Type
        {
            get { return this.typeField; }
            set { this.typeField = value; }
        }

        /// <summary>
        /// Sets the type of VPN connection the customer gateway supports.
        /// </summary>
        /// <param name="type">The type of VPN connection the customer gateway
        /// supports (ipsec.1).</param>
        /// <returns>this instance</returns>
        public CustomerGateway WithType(string type)
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
        /// The Internet-routable IP address of the customer gateway's outside
        /// interface
        /// </summary>
        [XmlElementAttribute(ElementName = "IpAddress")]
        public string IpAddress
        {
            get { return this.ipAddressField; }
            set { this.ipAddressField = value; }
        }

        /// <summary>
        /// Sets the Internet-routable IP address of the customer gateway's outside
        /// interface
        /// </summary>
        /// <param name="ipAddress">The Internet-routable IP address of the
        /// customer gateway's outside
        /// interface</param>
        /// <returns>this instance</returns>
        public CustomerGateway WithIpAddress(string ipAddress)
        {
            this.ipAddressField = ipAddress;
            return this;
        }

        /// <summary>
        /// Checks if IpAddress property is set
        /// </summary>
        /// <returns>true if IpAddress property is set</returns>
        public bool IsSetIpAddress()
        {
            return this.ipAddressField != null;
        }

        /// <summary>
        /// The customer gateway's Border Gateway Protocol
        /// (BGP) Autonomous System Number (ASN).
        /// </summary>
        [XmlElementAttribute(ElementName = "BgpAsn")]
        public string BgpAsn
        {
            get { return this.bgpAsnField; }
            set { this.bgpAsnField = value; }
        }

        /// <summary>
        /// Sets the customer gateway's Border Gateway Protocol
        /// (BGP) Autonomous System Number (ASN).
        /// </summary>
        /// <param name="bgpAsn">The customer gateway's Border Gateway Protocol
        /// (BGP) Autonomous System Number (ASN).</param>
        /// <returns>this instance</returns>
        public CustomerGateway WithBgpAsn(string bgpAsn)
        {
            this.bgpAsnField = bgpAsn;
            return this;
        }

        /// <summary>
        /// Checks if BgpAsn property is set
        /// </summary>
        /// <returns>true if BgpAsn property is set</returns>
        public bool IsSetBgpAsn()
        {
            return this.bgpAsnField != null;
        }

        /// <summary>
        /// List of tags for the CustomerGateway.
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
        /// Sets the list of tags for the CustomerGateway.
        /// </summary>
        /// <param name="list">A list of tags for the CustomerGateway.</param>
        /// <returns>this instance</returns>
        public CustomerGateway WithTag(params Tag[] list)
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
