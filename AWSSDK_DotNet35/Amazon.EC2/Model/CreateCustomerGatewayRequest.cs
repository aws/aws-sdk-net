/*
 * Copyright 2010-2013 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
    /// <para> Provides information to AWS about your customer gateway device. The customer gateway is the appliance at your end of the VPN
    /// connection (compared to the VPN gateway, which is the device at the AWS side of the VPN connection). You can have a single active customer
    /// gateway per AWS account (active means that you've created a VPN connection to use with the customer gateway). AWS might delete any customer
    /// gateway that you create with this operation if you leave it inactive for an extended period of time. </para> <para> You must provide the
    /// Internet-routable IP address of the customer gateway's external interface. The IP address must be static. </para> <para> You must also
    /// provide the device's Border Gateway Protocol (BGP) Autonomous System Number (ASN). You can use an existing ASN assigned to your network. If
    /// you don't have an ASN already, you can use a private ASN (in the 64512 - 65534 range). For more information about ASNs, go to <a
    /// href="http://en.wikipedia.org/wiki/Autonomous_system_%28Internet%29" > http://en.wikipedia.org/wiki/Autonomous_system_%28Internet%29</a> .
    /// </para>
    /// </summary>
    public partial class CreateCustomerGatewayRequest : AmazonEC2Request
    {
        private GatewayType type;
        private string publicIp;
        private int? bgpAsn;


        /// <summary>
        /// The type of VPN connection this customer gateway supports.
        ///  
        /// <para>
        /// <b>Constraints:</b>
        /// <list type="definition">
        ///     <item>
        ///         <term>Allowed Values</term>
        ///         <description>ipsec.1</description>
        ///     </item>
        /// </list>
        /// </para>
        /// </summary>
        public GatewayType Type
        {
            get { return this.type; }
            set { this.type = value; }
        }

        // Check to see if Type property is set
        internal bool IsSetType()
        {
            return this.type != null;
        }

        /// <summary>
        /// The Internet-routable IP address for the customer gateway's outside interface. The address must be static
        ///  
        /// </summary>
        public string PublicIp
        {
            get { return this.publicIp; }
            set { this.publicIp = value; }
        }

        // Check to see if PublicIp property is set
        internal bool IsSetPublicIp()
        {
            return this.publicIp != null;
        }

        /// <summary>
        /// The customer gateway's Border Gateway Protocol (BGP) Autonomous System Number (ASN).
        ///  
        /// </summary>
        public int BgpAsn
        {
            get { return this.bgpAsn ?? default(int); }
            set { this.bgpAsn = value; }
        }

        // Check to see if BgpAsn property is set
        internal bool IsSetBgpAsn()
        {
            return this.bgpAsn.HasValue;
        }

    }
}
    
