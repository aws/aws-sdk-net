/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
 * Do not modify this file. This file is generated from the ec2-2014-10-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.EC2.Model
{
    /// <summary>
    /// Container for the parameters to the CreateCustomerGateway operation.
    /// Provides information to AWS about your VPN customer gateway device. The customer gateway
    /// is the appliance at your end of the VPN connection. (The device on the AWS side of
    /// the VPN connection is the virtual private gateway.) You must provide the Internet-routable
    /// IP address of the customer gateway's external interface. The IP address must be static
    /// and can't be behind a device performing network address translation (NAT).
    /// 
    ///  
    /// <para>
    /// For devices that use Border Gateway Protocol (BGP), you can also provide the device's
    /// BGP Autonomous System Number (ASN). You can use an existing ASN assigned to your network.
    /// If you don't have an ASN already, you can use a private ASN (in the 64512 - 65534
    /// range).
    /// </para>
    ///  <note> 
    /// <para>
    /// Amazon EC2 supports all 2-byte ASN numbers in the range of 1 - 65534, with the exception
    /// of 7224, which is reserved in the <code>us-east-1</code> region, and 9059, which is
    /// reserved in the <code>eu-west-1</code> region.
    /// </para>
    ///  </note> 
    /// <para>
    /// For more information about VPN customer gateways, see <a href="http://docs.aws.amazon.com/AmazonVPC/latest/UserGuide/VPC_VPN.html">Adding
    /// a Hardware Virtual Private Gateway to Your VPC</a> in the <i>Amazon Virtual Private
    /// Cloud User Guide</i>.
    /// </para>
    /// </summary>
    public partial class CreateCustomerGatewayRequest : AmazonEC2Request
    {
        private int? _bgpAsn;
        private string _publicIp;
        private GatewayType _type;

        /// <summary>
        /// Empty constructor used to set  properties independently even when a simple constructor is available
        /// </summary>
        public CreateCustomerGatewayRequest() { }

        /// <summary>
        /// Instantiates CreateCustomerGatewayRequest with the parameterized properties
        /// </summary>
        /// <param name="type">The type of VPN connection that this customer gateway supports (<code>ipsec.1</code>).</param>
        /// <param name="publicIp">The Internet-routable IP address for the customer gateway's outside interface. The address must be static.</param>
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
        /// Gets and sets the property PublicIp. 
        /// <para>
        /// The Internet-routable IP address for the customer gateway's outside interface. The
        /// address must be static.
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
        /// Gets and sets the property Type. 
        /// <para>
        /// The type of VPN connection that this customer gateway supports (<code>ipsec.1</code>).
        /// </para>
        /// </summary>
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