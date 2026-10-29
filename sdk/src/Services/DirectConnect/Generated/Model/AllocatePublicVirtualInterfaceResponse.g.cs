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
    /// This is the response object from the AllocatePublicVirtualInterface operation.
    /// </summary>
    public partial class AllocatePublicVirtualInterfaceResponse : AmazonWebServiceResponse
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
        /// Gets and sets the property AmazonSideAsn. 
        /// <para>
        /// The autonomous system number (AS) for the Amazon side of the connection.
        /// </para>
        /// </summary>
        public long? AmazonSideAsn { get; set; }

        /// <summary>
        /// Checks to see if the AmazonSideAsn property is set.
        /// </summary>
        internal bool IsSetAmazonSideAsn() => this.AmazonSideAsn.HasValue;

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
        /// </summary>
        public int? Asn { get; set; }

        /// <summary>
        /// Checks to see if the Asn property is set.
        /// </summary>
        internal bool IsSetAsn() => this.Asn.HasValue;

        /// <summary>
        /// Gets and sets the property AsnLong. 
        /// <para>
        /// The long ASN for the virtual interface. The valid range is from 1 to 4294967294 for
        /// BGP configuration.
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
        /// Gets and sets the property AwsDeviceV2. 
        /// <para>
        /// The Direct Connect endpoint that terminates the physical connection.
        /// </para>
        /// </summary>
        public string AwsDeviceV2 { get; set; }

        /// <summary>
        /// Checks to see if the AwsDeviceV2 property is set.
        /// </summary>
        internal bool IsSetAwsDeviceV2() => this.AwsDeviceV2 != null;

        /// <summary>
        /// Gets and sets the property AwsLogicalDeviceId. 
        /// <para>
        /// The Direct Connect endpoint that terminates the logical connection. This device might
        /// be different than the device that terminates the physical connection.
        /// </para>
        /// </summary>
        public string AwsLogicalDeviceId { get; set; }

        /// <summary>
        /// Checks to see if the AwsLogicalDeviceId property is set.
        /// </summary>
        internal bool IsSetAwsLogicalDeviceId() => this.AwsLogicalDeviceId != null;

        /// <summary>
        /// Gets and sets the property BgpPeers. 
        /// <para>
        /// The BGP peers configured on this virtual interface.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<BGPPeer> BgpPeers { get; set; } = AWSConfigs.InitializeCollections ? new List<BGPPeer>() : null;

        /// <summary>
        /// Checks to see if the BgpPeers property is set.
        /// </summary>
        internal bool IsSetBgpPeers() => this.BgpPeers != null && (this.BgpPeers.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property ConnectionId. 
        /// <para>
        /// The ID of the connection.
        /// </para>
        /// </summary>
        public string ConnectionId { get; set; }

        /// <summary>
        /// Checks to see if the ConnectionId property is set.
        /// </summary>
        internal bool IsSetConnectionId() => this.ConnectionId != null;

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
        /// Gets and sets the property CustomerRouterConfig. 
        /// <para>
        /// The customer router configuration.
        /// </para>
        /// </summary>
        public string CustomerRouterConfig { get; set; }

        /// <summary>
        /// Checks to see if the CustomerRouterConfig property is set.
        /// </summary>
        internal bool IsSetCustomerRouterConfig() => this.CustomerRouterConfig != null;

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
        /// Gets and sets the property JumboFrameCapable. 
        /// <para>
        /// Indicates whether jumbo frames are supported.
        /// </para>
        /// </summary>
        public bool? JumboFrameCapable { get; set; }

        /// <summary>
        /// Checks to see if the JumboFrameCapable property is set.
        /// </summary>
        internal bool IsSetJumboFrameCapable() => this.JumboFrameCapable.HasValue;

        /// <summary>
        /// Gets and sets the property Location. 
        /// <para>
        /// The location of the connection.
        /// </para>
        /// </summary>
        public string Location { get; set; }

        /// <summary>
        /// Checks to see if the Location property is set.
        /// </summary>
        internal bool IsSetLocation() => this.Location != null;

        /// <summary>
        /// Gets and sets the property Mtu. 
        /// <para>
        /// The maximum transmission unit (MTU), in bytes. The supported values are 1500 and 8500.
        /// The default value is 1500
        /// </para>
        /// </summary>
        public int? Mtu { get; set; }

        /// <summary>
        /// Checks to see if the Mtu property is set.
        /// </summary>
        internal bool IsSetMtu() => this.Mtu.HasValue;

        /// <summary>
        /// Gets and sets the property OwnerAccount. 
        /// <para>
        /// The ID of the Amazon Web Services account that owns the virtual interface.
        /// </para>
        /// </summary>
        public string OwnerAccount { get; set; }

        /// <summary>
        /// Checks to see if the OwnerAccount property is set.
        /// </summary>
        internal bool IsSetOwnerAccount() => this.OwnerAccount != null;

        /// <summary>
        /// Gets and sets the property PrefixPoolAllocatedCountIpv4. 
        /// <para>
        /// The number of inbound IPv4 route prefixes allocated to the virtual interface. Not
        /// applicable to public virtual interfaces.
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
        /// The number of inbound IPv6 route prefixes allocated to the virtual interface. Not
        /// applicable to public virtual interfaces.
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
        /// The rate limit (bandwidth allocation) applied to the virtual interface. The value
        /// must be one of the supported bandwidth values and cannot exceed the bandwidth of the
        /// parent connection or LAG. Supported values: <c>50Mbps</c>, <c>100Mbps</c>, <c>200Mbps</c>,
        /// <c>300Mbps</c>, <c>400Mbps</c>, <c>500Mbps</c>, <c>600Mbps</c>, <c>700Mbps</c>, <c>800Mbps</c>,
        /// <c>900Mbps</c>, <c>1Gbps</c>, <c>1.2Gbps</c>, <c>1.5Gbps</c>, <c>1.8Gbps</c>, <c>2Gbps</c>,
        /// <c>2.1Gbps</c>, <c>2.4Gbps</c>, <c>2.7Gbps</c>, <c>3Gbps</c>, <c>3.2Gbps</c>, <c>3.6Gbps</c>,
        /// <c>4Gbps</c>, <c>5Gbps</c>, <c>6Gbps</c>, <c>7Gbps</c>, <c>8Gbps</c>, <c>9Gbps</c>,
        /// <c>10Gbps</c>, <c>12Gbps</c>, <c>15Gbps</c>, <c>18Gbps</c>, <c>20Gbps</c>, <c>21Gbps</c>,
        /// <c>24Gbps</c>, <c>27Gbps</c>, <c>30Gbps</c>, <c>32Gbps</c>, <c>36Gbps</c>, <c>40Gbps</c>,
        /// <c>50Gbps</c>, <c>60Gbps</c>, <c>70Gbps</c>, <c>80Gbps</c>, <c>100Gbps</c>, <c>120Gbps</c>,
        /// <c>150Gbps</c>, <c>180Gbps</c>, <c>200Gbps</c>, <c>210Gbps</c>, <c>240Gbps</c>, <c>270Gbps</c>,
        /// <c>300Gbps</c>, <c>320Gbps</c>, <c>360Gbps</c>, <c>400Gbps</c>, <c>450Gbps</c>, <c>480Gbps</c>,
        /// <c>500Gbps</c>, <c>540Gbps</c>, <c>600Gbps</c>, <c>700Gbps</c>, <c>800Gbps</c>, <c>900Gbps</c>,
        /// <c>1Tbps</c>, <c>1.1Tbps</c>, <c>1.2Tbps</c>, <c>1.3Tbps</c>, <c>1.4Tbps</c>, <c>1.5Tbps</c>,
        /// <c>1.6Tbps</c>.
        /// </para>
        /// </summary>
        public string RateLimit { get; set; }

        /// <summary>
        /// Checks to see if the RateLimit property is set.
        /// </summary>
        internal bool IsSetRateLimit() => this.RateLimit != null;

        /// <summary>
        /// Gets and sets the property Region. 
        /// <para>
        /// The Amazon Web Services Region where the virtual interface is located.
        /// </para>
        /// </summary>
        public string Region { get; set; }

        /// <summary>
        /// Checks to see if the Region property is set.
        /// </summary>
        internal bool IsSetRegion() => this.Region != null;

        /// <summary>
        /// Gets and sets the property RouteFilterPrefixes. 
        /// <para>
        /// The routes to be advertised to the Amazon Web Services network in this Region. Applies
        /// to public virtual interfaces.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<RouteFilterPrefix> RouteFilterPrefixes { get; set; } = AWSConfigs.InitializeCollections ? new List<RouteFilterPrefix>() : null;

        /// <summary>
        /// Checks to see if the RouteFilterPrefixes property is set.
        /// </summary>
        internal bool IsSetRouteFilterPrefixes() => this.RouteFilterPrefixes != null && (this.RouteFilterPrefixes.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property SiteLinkEnabled. 
        /// <para>
        /// Indicates whether SiteLink is enabled.
        /// </para>
        /// </summary>
        public bool? SiteLinkEnabled { get; set; }

        /// <summary>
        /// Checks to see if the SiteLinkEnabled property is set.
        /// </summary>
        internal bool IsSetSiteLinkEnabled() => this.SiteLinkEnabled.HasValue;

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// The tags associated with the virtual interface.
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
        /// The ID of the virtual private gateway. Applies only to private virtual interfaces.
        /// </para>
        /// </summary>
        public string VirtualGatewayId { get; set; }

        /// <summary>
        /// Checks to see if the VirtualGatewayId property is set.
        /// </summary>
        internal bool IsSetVirtualGatewayId() => this.VirtualGatewayId != null;

        /// <summary>
        /// Gets and sets the property VirtualInterfaceId. 
        /// <para>
        /// The ID of the virtual interface.
        /// </para>
        /// </summary>
        public string VirtualInterfaceId { get; set; }

        /// <summary>
        /// Checks to see if the VirtualInterfaceId property is set.
        /// </summary>
        internal bool IsSetVirtualInterfaceId() => this.VirtualInterfaceId != null;

        /// <summary>
        /// Gets and sets the property VirtualInterfaceName. 
        /// <para>
        /// The name of the virtual interface assigned by the customer network. The name has a
        /// maximum of 100 characters. The following are valid characters: a-z, 0-9 and a hyphen
        /// (-).
        /// </para>
        /// </summary>
        public string VirtualInterfaceName { get; set; }

        /// <summary>
        /// Checks to see if the VirtualInterfaceName property is set.
        /// </summary>
        internal bool IsSetVirtualInterfaceName() => this.VirtualInterfaceName != null;

        /// <summary>
        /// Gets and sets the property VirtualInterfaceState. 
        /// <para>
        /// The state of the virtual interface. The following are the possible values:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>confirming</c>: The creation of the virtual interface is pending confirmation
        /// from the virtual interface owner. If the owner of the virtual interface is different
        /// from the owner of the connection on which it is provisioned, then the virtual interface
        /// will remain in this state until it is confirmed by the virtual interface owner.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>verifying</c>: This state only applies to public virtual interfaces. Each public
        /// virtual interface needs validation before the virtual interface can be created.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>pending</c>: A virtual interface is in this state from the time that it is created
        /// until the virtual interface is ready to forward traffic.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>available</c>: A virtual interface that is able to forward traffic.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>down</c>: A virtual interface that is BGP down.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>testing</c>: A virtual interface is in this state immediately after calling <a>StartBgpFailoverTest</a>
        /// and remains in this state during the duration of the test.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>deleting</c>: A virtual interface is in this state immediately after calling <a>DeleteVirtualInterface</a>
        /// until it can no longer forward traffic.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>deleted</c>: A virtual interface that cannot forward traffic.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>rejected</c>: The virtual interface owner has declined creation of the virtual
        /// interface. If a virtual interface in the <c>Confirming</c> state is deleted by the
        /// virtual interface owner, the virtual interface enters the <c>Rejected</c> state.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>unknown</c>: The state of the virtual interface is not available.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public VirtualInterfaceState VirtualInterfaceState { get; set; }

        /// <summary>
        /// Checks to see if the VirtualInterfaceState property is set.
        /// </summary>
        internal bool IsSetVirtualInterfaceState() => this.VirtualInterfaceState != null;

        /// <summary>
        /// Gets and sets the property VirtualInterfaceType. 
        /// <para>
        /// The type of virtual interface. The possible values are <c>private</c>, <c>public</c>
        /// and <c>transit</c>.
        /// </para>
        /// </summary>
        public string VirtualInterfaceType { get; set; }

        /// <summary>
        /// Checks to see if the VirtualInterfaceType property is set.
        /// </summary>
        internal bool IsSetVirtualInterfaceType() => this.VirtualInterfaceType != null;

        /// <summary>
        /// Gets and sets the property Vlan. 
        /// <para>
        /// The ID of the VLAN.
        /// </para>
        /// </summary>
        public int? Vlan { get; set; }

        /// <summary>
        /// Checks to see if the Vlan property is set.
        /// </summary>
        internal bool IsSetVlan() => this.Vlan.HasValue;
    }
}
