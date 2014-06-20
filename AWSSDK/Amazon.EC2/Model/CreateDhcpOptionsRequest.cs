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
    /// Container for the parameters to the CreateDhcpOptions operation.
    /// <para>Creates a set of DHCP options for your VPC. After creating the set, you must associate it with the VPC, causing all existing and new
    /// instances that you launch in the VPC to use this set of DHCP options. The following are the individual DHCP options you can specify. For
    /// more information about the options, see <a href="http://www.ietf.org/rfc/rfc2132.txt" >RFC 2132</a> .</para>
    /// <ul>
    /// <li> <c>domain-name-servers</c> - The IP addresses of up to four domain name servers, or <c>AmazonProvidedDNS</c> . The default DHCP option
    /// set specifies <c>AmazonProvidedDNS</c> . If specifying more than one domain name server, specify the IP addresses in a single parameter,
    /// separated by commas.</li>
    /// <li> <c>domain-name</c> - If you're using AmazonProvidedDNS in <c>us-east-1</c> ,
    /// specify <c>ec2.internal</c> . If you're using AmazonProvidedDNS in another region, specify <c>region.compute.internal</c> (for
    /// example, <c>ap-northeast-1.compute.internal</c> ). Otherwise, specify a domain name (for example, <c>MyCompany.com</c> ).</li>
    /// <li> <c>ntp-servers</c> - The IP addresses of up to four Network Time Protocol (NTP) servers.</li>
    /// <li> <c>netbios-name-servers</c> - The IP addresses of up to four NetBIOS name servers.</li>
    /// <li> <c>netbios-node-type</c> - The NetBIOS node type (1, 2, 4, or 8). We recommend that you specify 2 (broadcast and multicast are not
    /// currently supported). For more information about these node types, see <a href="http://www.ietf.org/rfc/rfc2132.txt" >RFC 2132</a> . </li>
    /// 
    /// </ul>
    /// <para>For more information about DHCP options, see <a href="http://docs.aws.amazon.com/AmazonVPC/latest/UserGuide/VPC_DHCP_Options.html"
    /// >DHCP Options Sets</a> in the <i>Amazon Virtual Private Cloud User Guide</i> .</para>
    /// </summary>
    [XmlRootAttribute(IsNullable = false)]
    public class CreateDhcpOptionsRequest : EC2Request
    {    
        private List<DhcpConfiguration> dhcpConfigurationField;

        /// <summary>
        /// DHCP Configuration
        /// </summary>
        [XmlElementAttribute(ElementName = "DhcpConfiguration")]
        public List<DhcpConfiguration> DhcpConfiguration
        {
            get
            {
                if (this.dhcpConfigurationField == null)
                {
                    this.dhcpConfigurationField = new List<DhcpConfiguration>();
                }
                return this.dhcpConfigurationField;
            }
            set { this.dhcpConfigurationField = value; }
        }

        /// <summary>
        /// Sets the DHCP Configuration
        /// </summary>
        /// <param name="list">DHCP Configuration</param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public CreateDhcpOptionsRequest WithDhcpConfiguration(params DhcpConfiguration[] list)
        {
            foreach (DhcpConfiguration item in list)
            {
                DhcpConfiguration.Add(item);
            }
            return this;
        }

        /// <summary>
        /// Checks if DhcpConfiguration property is set
        /// </summary>
        /// <returns>true if DhcpConfiguration property is set</returns>
        public bool IsSetDhcpConfiguration()
        {
            return (DhcpConfiguration.Count > 0);
        }

    }
}
