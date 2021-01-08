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
    /// Container for the parameters to the CreateDhcpOptions operation.
    /// Creates a set of DHCP options for your VPC. After creating the set, you must associate
    /// it with the VPC, causing all existing and new instances that you launch in the VPC
    /// to use this set of DHCP options. The following are the individual DHCP options you
    /// can specify. For more information about the options, see <a href="http://www.ietf.org/rfc/rfc2132.txt">RFC
    /// 2132</a>.
    /// 
    ///  <ul> <li> 
    /// <para>
    ///  <code>domain-name-servers</code> - The IP addresses of up to four domain name servers,
    /// or AmazonProvidedDNS. The default DHCP option set specifies AmazonProvidedDNS. If
    /// specifying more than one domain name server, specify the IP addresses in a single
    /// parameter, separated by commas. To have your instance receive a custom DNS hostname
    /// as specified in <code>domain-name</code>, you must set <code>domain-name-servers</code>
    /// to a custom DNS server.
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <code>domain-name</code> - If you're using AmazonProvidedDNS in <code>us-east-1</code>,
    /// specify <code>ec2.internal</code>. If you're using AmazonProvidedDNS in another Region,
    /// specify <code>region.compute.internal</code> (for example, <code>ap-northeast-1.compute.internal</code>).
    /// Otherwise, specify a domain name (for example, <code>ExampleCompany.com</code>). This
    /// value is used to complete unqualified DNS hostnames. <b>Important</b>: Some Linux
    /// operating systems accept multiple domain names separated by spaces. However, Windows
    /// and other Linux operating systems treat the value as a single domain, which results
    /// in unexpected behavior. If your DHCP options set is associated with a VPC that has
    /// instances with multiple operating systems, specify only one domain name.
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <code>ntp-servers</code> - The IP addresses of up to four Network Time Protocol (NTP)
    /// servers.
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <code>netbios-name-servers</code> - The IP addresses of up to four NetBIOS name servers.
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <code>netbios-node-type</code> - The NetBIOS node type (1, 2, 4, or 8). We recommend
    /// that you specify 2 (broadcast and multicast are not currently supported). For more
    /// information about these node types, see <a href="http://www.ietf.org/rfc/rfc2132.txt">RFC
    /// 2132</a>.
    /// </para>
    ///  </li> </ul> 
    /// <para>
    /// Your VPC automatically starts out with a set of DHCP options that includes only a
    /// DNS server that we provide (AmazonProvidedDNS). If you create a set of options, and
    /// if your VPC has an internet gateway, make sure to set the <code>domain-name-servers</code>
    /// option either to <code>AmazonProvidedDNS</code> or to a domain name server of your
    /// choice. For more information, see <a href="https://docs.aws.amazon.com/vpc/latest/userguide/VPC_DHCP_Options.html">DHCP
    /// Options Sets</a> in the <i>Amazon Virtual Private Cloud User Guide</i>.
    /// </para>
    /// </summary>
    public partial class CreateDhcpOptionsRequest : AmazonEC2Request
    {
        private List<DhcpConfiguration> _dhcpConfigurations = new List<DhcpConfiguration>();
        private List<TagSpecification> _tagSpecifications = new List<TagSpecification>();

        /// <summary>
        /// Empty constructor used to set  properties independently even when a simple constructor is available
        /// </summary>
        public CreateDhcpOptionsRequest() { }

        /// <summary>
        /// Instantiates CreateDhcpOptionsRequest with the parameterized properties
        /// </summary>
        /// <param name="dhcpConfigurations">A DHCP configuration option.</param>
        public CreateDhcpOptionsRequest(List<DhcpConfiguration> dhcpConfigurations)
        {
            _dhcpConfigurations = dhcpConfigurations;
        }

        /// <summary>
        /// Gets and sets the property DhcpConfigurations. 
        /// <para>
        /// A DHCP configuration option.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public List<DhcpConfiguration> DhcpConfigurations
        {
            get { return this._dhcpConfigurations; }
            set { this._dhcpConfigurations = value; }
        }

        // Check to see if DhcpConfigurations property is set
        internal bool IsSetDhcpConfigurations()
        {
            return this._dhcpConfigurations != null && this._dhcpConfigurations.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property TagSpecifications. 
        /// <para>
        /// The tags to assign to the DHCP option.
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

    }
}