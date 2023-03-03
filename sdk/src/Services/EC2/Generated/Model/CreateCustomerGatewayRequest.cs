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
 * Do not modify this file. This file is generated from the ec2-2016-11-15.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.EC2.Model
{
    /// <summary>
    /// Container for the parameters to the CreateCustomerGateway operation.
    /// Provides information to Amazon Web Services about your customer gateway device. The
    /// customer gateway device is the appliance at your end of the VPN connection. You must
    /// provide the IP address of the customer gateway device’s external interface. The IP
    /// address must be static and can be behind a device performing network address translation
    /// (NAT).
    /// 
    ///  
    /// <para>
    /// For devices that use Border Gateway Protocol (BGP), you can also provide the device's
    /// BGP Autonomous System Number (ASN). You can use an existing ASN assigned to your network.
    /// If you don't have an ASN already, you can use a private ASN. For more information,
    /// see <a href="https://docs.aws.amazon.com/vpn/latest/s2svpn/cgw-options.html">Customer
    /// gateway options for your Site-to-Site VPN connection</a> in the <i>Amazon Web Services
    /// Site-to-Site VPN User Guide</i>.
    /// </para>
    ///  
    /// <para>
    /// To create more than one customer gateway with the same VPN type, IP address, and BGP
    /// ASN, specify a unique device name for each customer gateway. An identical request
    /// returns information about the existing customer gateway; it doesn't create a new customer
    /// gateway.
    /// </para>
    /// </summary>
    public partial class CreateCustomerGatewayRequest : AmazonEC2Request
    {
        private int? _bgpAsn;
        private string _certificateArn;
        private string _deviceName;
        private string _ipAddress;
        private string _publicIp;
        private List<TagSpecification> _tagSpecifications = new List<TagSpecification>();
        private GatewayType _type;

        /// <summary>
        /// Empty constructor used to set  properties independently even when a simple constructor is available
        /// </summary>
        public CreateCustomerGatewayRequest() { }

        /// <summary>
        /// Instantiates CreateCustomerGatewayRequest with the parameterized properties
        /// </summary>
        /// <param name="type">The type of VPN connection that this customer gateway supports (<code>ipsec.1</code>).</param>
        /// <param name="publicIp"> <i>This member has been deprecated.</i> The Internet-routable IP address for the customer gateway's outside interface. The address must be static.</param>
        /// <param name="bgpAsn">For devices that support BGP, the customer gateway's BGP ASN. Default: 65000</param>
        public CreateCustomerGatewayRequest(GatewayType type, string publicIp, int bgpAsn)
        {
            _type = type;
            _publicIp = publicIp;
            _bgpAsn = bgpAsn;
        }

        /// <summary>
        /// Gets and sets the property BgpAsn. 
        /// <para>
        /// For devices that support BGP, the customer gateway's BGP ASN.
        /// </para>
        ///  
        /// <para>
        /// Default: 65000
        /// </para>
        /// </summary>
        public int BgpAsn
        {
            get { return this._bgpAsn.GetValueOrDefault(); }
            set { this._bgpAsn = value; }
        }

        // Check to see if BgpAsn property is set
        internal bool IsSetBgpAsn()
        {
            return this._bgpAsn.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property CertificateArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) for the customer gateway certificate.
        /// </para>
        /// </summary>
        public string CertificateArn
        {
            get { return this._certificateArn; }
            set { this._certificateArn = value; }
        }

        // Check to see if CertificateArn property is set
        internal bool IsSetCertificateArn()
        {
            return this._certificateArn != null;
        }

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
        public string DeviceName
        {
            get { return this._deviceName; }
            set { this._deviceName = value; }
        }

        // Check to see if DeviceName property is set
        internal bool IsSetDeviceName()
        {
            return this._deviceName != null;
        }

        /// <summary>
        /// Gets and sets the property IpAddress. 
        /// <para>
        ///  IPv4 address for the customer gateway device's outside interface. The address must
        /// be static. 
        /// </para>
        /// </summary>
        public string IpAddress
        {
            get { return this._ipAddress; }
            set { this._ipAddress = value; }
        }

        // Check to see if IpAddress property is set
        internal bool IsSetIpAddress()
        {
            return this._ipAddress != null;
        }

        /// <summary>
        /// Gets and sets the property PublicIp. 
        /// <para>
        ///  <i>This member has been deprecated.</i> The Internet-routable IP address for the
        /// customer gateway's outside interface. The address must be static.
        /// </para>
        /// </summary>
        public string PublicIp
        {
            get { return this._publicIp; }
            set { this._publicIp = value; }
        }

        // Check to see if PublicIp property is set
        internal bool IsSetPublicIp()
        {
            return this._publicIp != null;
        }

        /// <summary>
        /// Gets and sets the property TagSpecifications. 
        /// <para>
        /// The tags to apply to the customer gateway.
        /// </para>
        /// </summary>
        public List<TagSpecification> TagSpecifications
        {
            get { return this._tagSpecifications; }
            set { this._tagSpecifications = value; }
        }

        // Check to see if TagSpecifications property is set
        internal bool IsSetTagSpecifications()
        {
            return this._tagSpecifications != null && this._tagSpecifications.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property Type. 
        /// <para>
        /// The type of VPN connection that this customer gateway supports (<code>ipsec.1</code>).
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public GatewayType Type
        {
            get { return this._type; }
            set { this._type = value; }
        }

        // Check to see if Type property is set
        internal bool IsSetType()
        {
            return this._type != null;
        }

    }
}