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

namespace Amazon.EC2.Model
{
    /// <summary>
    /// Container for the parameters to the CreateCustomerGateway operation. Provides information
    /// to Amazon Web Services about your customer gateway device. The customer gateway device
    /// is the appliance at your end of the VPN connection. You must provide the IP address
    /// of the customer gateway device’s external interface. The IP address must be static
    /// and can be behind a device performing network address translation (NAT). <para> For
    /// devices that use Border Gateway Protocol (BGP), you can also provide the device's
    /// BGP Autonomous System Number (ASN). You can use an existing ASN assigned to your network.
    /// If you don't have an ASN already, you can use a private ASN. For more information,
    /// see <a href="https://docs.aws.amazon.com/vpn/latest/s2svpn/cgw-options.html">Customer
    /// gateway options for your Site-to-Site VPN connection</a> in the <i>Amazon Web Services
    /// Site-to-Site VPN User Guide</i>. </para> <para> To create more than one customer gateway
    /// with the same VPN type, IP address, and BGP ASN, specify a unique device name for
    /// each customer gateway. An identical request returns information about the existing
    /// customer gateway; it doesn't create a new customer gateway. </para>
    /// </summary>
    public partial class CreateCustomerGatewayRequest : AmazonEC2Request
    {
        /// <summary>
        /// Empty constructor used to set properties independently even when a simple constructor is available
        /// </summary>
        public CreateCustomerGatewayRequest() { }

        /// <summary>
        /// Instantiates CreateCustomerGatewayRequest with the parameterized properties
        /// </summary>
        /// <param name="type">The type of VPN connection that this customer gateway supports   (<c>ipsec.1</c>).</param>
        /// <param name="publicIp">   <i>This member has been deprecated.</i> The Internet-routable IP address for the customer gateway's outside interface. The   address must be static.</param>
        /// <param name="bgpAsn">For customer gateway devices that support BGP, specify the device's ASN. You must specify either <c>BgpAsn</c> or <c>BgpAsnExtended</c> when creating the customer gateway. If the ASN is larger than <c>2,147,483,647</c>, you must use <c>BgpAsnExtended</c>.   Default: 65000   Valid values: <c>1</c> to <c>2,147,483,647</c>   </param>
        public CreateCustomerGatewayRequest(GatewayType type, string publicIp, int? bgpAsn)
        {
            this.Type = type;
            this.PublicIp = publicIp;
            this.BgpAsn = bgpAsn;
        }

        /// <summary>
        /// Gets and sets the property BgpAsn. 
        /// <para>
        /// For customer gateway devices that support BGP, specify the device's ASN. You must
        /// specify either <c>BgpAsn</c> or <c>BgpAsnExtended</c> when creating the customer gateway.
        /// If the ASN is larger than <c>2,147,483,647</c>, you must use <c>BgpAsnExtended</c>.
        /// </para>
        ///  
        /// <para>
        /// Default: 65000
        /// </para>
        ///  
        /// <para>
        /// Valid values: <c>1</c> to <c>2,147,483,647</c> 
        /// </para>
        /// </summary>
        public int? BgpAsn { get; set; }

        /// <summary>
        /// Checks to see if the BgpAsn property is set.
        /// </summary>
        internal bool IsSetBgpAsn() => this.BgpAsn.HasValue;

        /// <summary>
        /// Gets and sets the property BgpAsnExtended. 
        /// <para>
        /// For customer gateway devices that support BGP, specify the device's ASN. You must
        /// specify either <c>BgpAsn</c> or <c>BgpAsnExtended</c> when creating the customer gateway.
        /// If the ASN is larger than <c>2,147,483,647</c>, you must use <c>BgpAsnExtended</c>.
        /// </para>
        ///  
        /// <para>
        /// Valid values: <c>2,147,483,648</c> to <c>4,294,967,295</c> 
        /// </para>
        /// </summary>
        public long? BgpAsnExtended { get; set; }

        /// <summary>
        /// Checks to see if the BgpAsnExtended property is set.
        /// </summary>
        internal bool IsSetBgpAsnExtended() => this.BgpAsnExtended.HasValue;

        /// <summary>
        /// Gets and sets the property CertificateArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) for the customer gateway certificate.
        /// </para>
        /// </summary>
        public string CertificateArn { get; set; }

        /// <summary>
        /// Checks to see if the CertificateArn property is set.
        /// </summary>
        internal bool IsSetCertificateArn() => this.CertificateArn != null;

        /// <summary>
        /// Gets and sets the property DeviceName. 
        /// <para>
        /// A name for the customer gateway device.
        /// </para>
        ///  
        /// <para>
        /// Length Constraints: Up to 255 characters.
        /// </para>
        /// </summary>
        public string DeviceName { get; set; }

        /// <summary>
        /// Checks to see if the DeviceName property is set.
        /// </summary>
        internal bool IsSetDeviceName() => this.DeviceName != null;

        /// <summary>
        /// Gets and sets the property DryRun. 
        /// <para>
        /// Checks whether you have the required permissions for the action, without actually
        /// making the request, and provides an error response. If you have the required permissions,
        /// the error response is <c>DryRunOperation</c>. Otherwise, it is <c>UnauthorizedOperation</c>.
        /// </para>
        /// </summary>
        public bool? DryRun { get; set; }

        /// <summary>
        /// Checks to see if the DryRun property is set.
        /// </summary>
        internal bool IsSetDryRun() => this.DryRun.HasValue;

        /// <summary>
        /// Gets and sets the property IpAddress. 
        /// <para>
        /// The IP address for the customer gateway device's outside interface. The address must
        /// be static. If <c>OutsideIpAddressType</c> in your VPN connection options is set to
        /// <c>PrivateIpv4</c>, you can use an RFC6598 or RFC1918 private IPv4 address. If <c>OutsideIpAddressType</c>
        /// is set to <c>Ipv6</c>, you can use an IPv6 address. 
        /// </para>
        /// </summary>
        public string IpAddress { get; set; }

        /// <summary>
        /// Checks to see if the IpAddress property is set.
        /// </summary>
        internal bool IsSetIpAddress() => this.IpAddress != null;

        /// <summary>
        /// Gets and sets the property PublicIp. 
        /// <para>
        ///  <i>This member has been deprecated.</i> The Internet-routable IP address for the
        /// customer gateway's outside interface. The address must be static.
        /// </para>
        /// </summary>
        public string PublicIp { get; set; }

        /// <summary>
        /// Checks to see if the PublicIp property is set.
        /// </summary>
        internal bool IsSetPublicIp() => this.PublicIp != null;

        /// <summary>
        /// Gets and sets the property TagSpecifications. 
        /// <para>
        /// The tags to apply to the customer gateway.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<TagSpecification> TagSpecifications { get; set; } = AWSConfigs.InitializeCollections ? new List<TagSpecification>() : null;

        /// <summary>
        /// Checks to see if the TagSpecifications property is set.
        /// </summary>
        internal bool IsSetTagSpecifications() => this.TagSpecifications != null && (this.TagSpecifications.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property Type. 
        /// <para>
        /// The type of VPN connection that this customer gateway supports (<c>ipsec.1</c>).
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public GatewayType Type { get; set; }

        /// <summary>
        /// Checks to see if the Type property is set.
        /// </summary>
        internal bool IsSetType() => this.Type != null;
    }
}
