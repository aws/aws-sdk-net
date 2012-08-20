/*******************************************************************************
 * Copyright 2008-2012 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
    /// Provides information to AWS about your customer gateway device. The
    /// customer gateway is the appliance at your end of the VPN connection
    /// (compared to the VPN gateway, which is the device at the AWS side of the
    /// VPN connection). AWS might delete any customer gateway that you create
    /// with this operation if you leave it inactive for an extended period of
    /// time (inactive means that there's no VPN connection in use with the customer
    /// gateway).
    ///
    /// You must provide the Internet-routable IP address of the customer
    /// gateway's external interface. The IP address must be static and can't be
    /// behind a device performing network address translation (NAT).
    ///
    /// You must also provide the device's Border Gateway Protocol (BGP)
    /// Autonomous System Number (ASN). You can use an existing ASN
    /// assigned to your network. If you don't have an ASN already, you can
    /// use a private ASN (in the 64512 - 65534 range)
    /// </summary>
    [XmlRootAttribute(IsNullable = false)]
    public class CreateCustomerGatewayRequest
    {    
        private string typeField;
        private string ipAddressField;
        private Decimal? bgpAsnField;

        /// <summary>
        /// Gets and sets the Type property.
        /// The type of VPN connection this customer gateway supports.
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
        /// <param name="type">The type of VPN connection this customer gateway supports.</param>
        /// <returns>this instance</returns>
        public CreateCustomerGatewayRequest WithType(string type)
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
        /// Gets and sets the IpAddress property.
        /// The Internet-routable IP address for the customer gateway's
        /// outside interface. The address must be static.
        /// </summary>
        [XmlElementAttribute(ElementName = "IpAddress")]
        public string IpAddress
        {
            get { return this.ipAddressField; }
            set { this.ipAddressField = value; }
        }

        /// <summary>
        /// Sets the IpAddress property
        /// </summary>
        /// <param name="ipAddress">The Internet-routable IP address for the customer gateway's
        /// outside interface. The address must be static.</param>
        /// <returns>this instance</returns>
        public CreateCustomerGatewayRequest WithIpAddress(string ipAddress)
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
        /// Gets and sets the BgpAsn property.
        /// The customer gateway's Border Gateway Protocol
        /// (BGP) Autonomous System Number (ASN).
        /// </summary>
        [XmlElementAttribute(ElementName = "BgpAsn")]
        public Decimal BgpAsn
        {
            get { return this.bgpAsnField.GetValueOrDefault(); }
            set { this.bgpAsnField = value; }
        }

        /// <summary>
        /// Sets the BgpAsn property
        /// </summary>
        /// <param name="bgpAsn">The customer gateway's Border Gateway Protocol
        /// (BGP) Autonomous System Number (ASN).</param>
        /// <returns>this instance</returns>
        public CreateCustomerGatewayRequest WithBgpAsn(Decimal bgpAsn)
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
            return this.bgpAsnField.HasValue;
        }

    }
}
