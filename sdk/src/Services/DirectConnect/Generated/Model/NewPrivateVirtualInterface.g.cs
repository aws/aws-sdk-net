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
 * Do not modify this file. This file is generated from the smithy.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;
using Amazon.Runtime;
using Amazon.Runtime.Internal;

#pragma warning disable CS0612,CS0618,CS1570

namespace Amazon.DirectConnect.Model
{
    /// <summary>
    /// Information about a private virtual interface.
    /// </summary>
    public partial class NewPrivateVirtualInterface
    {
        /// <summary>
        /// Gets and sets the property AddressFamily. 
        /// <para>
        /// The address family for the BGP peer.
        /// </para>
        /// </summary>
        public AddressFamily AddressFamily { get; set; }

        /// <summary>
        /// Checks to see if the AddressFamily property is set.
        /// </summary>
        internal bool IsSetAddressFamily() => this.AddressFamily != null;

        /// <summary>
        /// Gets and sets the property AmazonAddress. 
        /// <para>
        /// The IP address assigned to the Amazon interface.
        /// </para>
        /// </summary>
        public string AmazonAddress { get; set; }

        /// <summary>
        /// Checks to see if the AmazonAddress property is set.
        /// </summary>
        internal bool IsSetAmazonAddress() => this.AmazonAddress != null;

        /// <summary>
        /// Gets and sets the property Asn. 
        /// <para>
        /// The autonomous system number (ASN). The valid range is from 1 to 2147483646 for Border
        /// Gateway Protocol (BGP) configuration. If you provide a number greater than the maximum,
        /// an error is returned. Use <c>asnLong</c> instead.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// You can use <c>asnLong</c> or <c>asn</c>, but not both. We recommend using <c>asnLong</c>
        /// as it supports a greater pool of numbers. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// If you provide a value in the same API call for both <c>asn</c> and <c>asnLong</c>,
        /// the API will only accept the value for <c>asnLong</c>. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// If you enter a 4-byte ASN for the <c>asn</c> parameter, the API returns an error.
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// If you are using a 2-byte ASN, the API response will include the 2-byte value for
        /// both the <c>asn</c> and <c>asnLong</c> fields.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// The valid values are 1-2147483646.
        /// </para>
        /// </summary>
        public int? Asn { get; set; }

        /// <summary>
        /// Checks to see if the Asn property is set.
        /// </summary>
        internal bool IsSetAsn() => this.Asn.HasValue;

        /// <summary>
        /// Gets and sets the property AsnLong. 
        /// <para>
        /// The long ASN for a new private virtual interface. The valid range is from 1 to 4294967294
        /// for BGP configuration.
        /// </para>
        ///  
        /// <para>
        /// Note the following limitations when using <c>asnLong</c>:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// You can use <c>asnLong</c> or <c>asn</c>, but not both. We recommend using <c>asnLong</c>
        /// as it supports a greater pool of numbers. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>asnLong</c> accepts any valid ASN value, regardless if it's 2-byte or 4-byte.
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// When using a 4-byte <c>asnLong</c>, the API response returns <c>0</c> for the legacy
        /// <c>asn</c> attribute since 4-byte ASN values exceed the maximum supported value of
        /// 2,147,483,647.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// If you are using a 2-byte ASN, the API response will include the 2-byte value for
        /// both the <c>asn</c> and <c>asnLong</c> fields.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// If you provide a value in the same API call for both <c>asn</c> and <c>asnLong</c>,
        /// the API will only accept the value for <c>asnLong</c>.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public long? AsnLong { get; set; }

        /// <summary>
        /// Checks to see if the AsnLong property is set.
        /// </summary>
        internal bool IsSetAsnLong() => this.AsnLong.HasValue;

        /// <summary>
        /// Gets and sets the property AuthKey. 
        /// <para>
        /// The authentication key for BGP configuration. This string has a minimum length of
        /// 6 characters and and a maximun lenth of 80 characters.
        /// </para>
        /// </summary>
        public string AuthKey { get; set; }

        /// <summary>
        /// Checks to see if the AuthKey property is set.
        /// </summary>
        internal bool IsSetAuthKey() => this.AuthKey != null;

        /// <summary>
        /// Gets and sets the property CustomerAddress. 
        /// <para>
        /// The IP address assigned to the customer interface.
        /// </para>
        /// </summary>
        public string CustomerAddress { get; set; }

        /// <summary>
        /// Checks to see if the CustomerAddress property is set.
        /// </summary>
        internal bool IsSetCustomerAddress() => this.CustomerAddress != null;

        /// <summary>
        /// Gets and sets the property DirectConnectGatewayId. 
        /// <para>
        /// The ID of the Direct Connect gateway.
        /// </para>
        /// </summary>
        public string DirectConnectGatewayId { get; set; }

        /// <summary>
        /// Checks to see if the DirectConnectGatewayId property is set.
        /// </summary>
        internal bool IsSetDirectConnectGatewayId() => this.DirectConnectGatewayId != null;

        /// <summary>
        /// Gets and sets the property EnableSiteLink. 
        /// <para>
        /// Indicates whether to enable or disable SiteLink.
        /// </para>
        /// </summary>
        public bool? EnableSiteLink { get; set; }

        /// <summary>
        /// Checks to see if the EnableSiteLink property is set.
        /// </summary>
        internal bool IsSetEnableSiteLink() => this.EnableSiteLink.HasValue;

        /// <summary>
        /// Gets and sets the property Mtu. 
        /// <para>
        /// The maximum transmission unit (MTU), in bytes. The supported values are 1500 and 8500.
        /// The default value is 1500.
        /// </para>
        /// </summary>
        public int? Mtu { get; set; }

        /// <summary>
        /// Checks to see if the Mtu property is set.
        /// </summary>
        internal bool IsSetMtu() => this.Mtu.HasValue;

        /// <summary>
        /// Gets and sets the property PrefixPoolAllocatedCountIpv4. 
        /// <para>
        /// The number of inbound IPv4 route prefixes to allocate to the virtual interface.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0)]
        public int? PrefixPoolAllocatedCountIpv4 { get; set; }

        /// <summary>
        /// Checks to see if the PrefixPoolAllocatedCountIpv4 property is set.
        /// </summary>
        internal bool IsSetPrefixPoolAllocatedCountIpv4() => this.PrefixPoolAllocatedCountIpv4.HasValue;

        /// <summary>
        /// Gets and sets the property PrefixPoolAllocatedCountIpv6. 
        /// <para>
        /// The number of inbound IPv6 route prefixes to allocate to the virtual interface.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0)]
        public int? PrefixPoolAllocatedCountIpv6 { get; set; }

        /// <summary>
        /// Checks to see if the PrefixPoolAllocatedCountIpv6 property is set.
        /// </summary>
        internal bool IsSetPrefixPoolAllocatedCountIpv6() => this.PrefixPoolAllocatedCountIpv6.HasValue;

        /// <summary>
        /// Gets and sets the property RateLimit. 
        /// <para>
        /// The rate limit (bandwidth allocation) to apply to the virtual interface. The rate
        /// limit restricts the maximum bandwidth that the virtual interface can use on the parent
        /// connection.
        /// </para>
        /// </summary>
        public string RateLimit { get; set; }

        /// <summary>
        /// Checks to see if the RateLimit property is set.
        /// </summary>
        internal bool IsSetRateLimit() => this.RateLimit != null;

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// The tags associated with the private virtual interface.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 1)]
        public List<Tag> Tags { get; set; } = AWSConfigs.InitializeCollections ? new List<Tag>() : null;

        /// <summary>
        /// Checks to see if the Tags property is set.
        /// </summary>
        internal bool IsSetTags() => this.Tags != null && (this.Tags.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property VirtualGatewayId. 
        /// <para>
        /// The ID of the virtual private gateway.
        /// </para>
        /// </summary>
        public string VirtualGatewayId { get; set; }

        /// <summary>
        /// Checks to see if the VirtualGatewayId property is set.
        /// </summary>
        internal bool IsSetVirtualGatewayId() => this.VirtualGatewayId != null;

        /// <summary>
        /// Gets and sets the property VirtualInterfaceName. 
        /// <para>
        /// The name of the virtual interface assigned by the customer network. The name has a
        /// maximum of 100 characters. The following are valid characters: a-z, 0-9 and a hyphen
        /// (-).
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string VirtualInterfaceName { get; set; }

        /// <summary>
        /// Checks to see if the VirtualInterfaceName property is set.
        /// </summary>
        internal bool IsSetVirtualInterfaceName() => this.VirtualInterfaceName != null;

        /// <summary>
        /// Gets and sets the property Vlan. 
        /// <para>
        /// The ID of the VLAN.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public int? Vlan { get; set; }

        /// <summary>
        /// Checks to see if the Vlan property is set.
        /// </summary>
        internal bool IsSetVlan() => this.Vlan.HasValue;
    }
}
