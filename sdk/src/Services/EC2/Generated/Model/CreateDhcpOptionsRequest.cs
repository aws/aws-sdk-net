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

#pragma warning disable CS0612,CS0618,CS1570
namespace Amazon.EC2.Model
{
    /// <summary>
    /// Container for the parameters to the CreateDhcpOptions operation.
    /// Creates a custom set of DHCP options. After you create a DHCP option set, you associate
    /// it with a VPC. After you associate a DHCP option set with a VPC, all existing and
    /// newly launched instances in the VPC use this set of DHCP options.
    /// 
    ///  
    /// <para>
    /// The following are the individual DHCP options you can specify. For more information,
    /// see <a href="https://docs.aws.amazon.com/vpc/latest/userguide/VPC_DHCP_Options.html">DHCP
    /// option sets</a> in the <i>Amazon VPC User Guide</i>.
    /// </para>
    ///  <ul> <li> 
    /// <para>
    ///  <c>domain-name</c> - If you're using AmazonProvidedDNS in <c>us-east-1</c>, specify
    /// <c>ec2.internal</c>. If you're using AmazonProvidedDNS in any other Region, specify
    /// <c>region.compute.internal</c>. Otherwise, specify a custom domain name. This value
    /// is used to complete unqualified DNS hostnames.
    /// </para>
    ///  
    /// <para>
    /// Some Linux operating systems accept multiple domain names separated by spaces. However,
    /// Windows and other Linux operating systems treat the value as a single domain, which
    /// results in unexpected behavior. If your DHCP option set is associated with a VPC that
    /// has instances running operating systems that treat the value as a single domain, specify
    /// only one domain name.
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <c>domain-name-servers</c> - The IP addresses of up to four DNS servers, or AmazonProvidedDNS.
    /// To specify multiple domain name servers in a single parameter, separate the IP addresses
    /// using commas. To have your instances receive custom DNS hostnames as specified in
    /// <c>domain-name</c>, you must specify a custom DNS server.
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <c>ntp-servers</c> - The IP addresses of up to eight Network Time Protocol (NTP)
    /// servers (four IPv4 addresses and four IPv6 addresses).
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <c>netbios-name-servers</c> - The IP addresses of up to four NetBIOS name servers.
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <c>netbios-node-type</c> - The NetBIOS node type (1, 2, 4, or 8). We recommend that
    /// you specify 2. Broadcast and multicast are not supported. For more information about
    /// NetBIOS node types, see <a href="https://www.ietf.org/rfc/rfc2132.txt">RFC 2132</a>.
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <c>ipv6-address-preferred-lease-time</c> - A value (in seconds, minutes, hours, or
    /// years) for how frequently a running instance with an IPv6 assigned to it goes through
    /// DHCPv6 lease renewal. Acceptable values are between 140 and 2147483647 seconds (approximately
    /// 68 years). If no value is entered, the default lease time is 140 seconds. If you use
    /// long-term addressing for EC2 instances, you can increase the lease time and avoid
    /// frequent lease renewal requests. Lease renewal typically occurs when half of the lease
    /// time has elapsed.
    /// </para>
    ///  </li> </ul>
    /// </summary>
    public partial class CreateDhcpOptionsRequest : AmazonEC2Request
    {
        private List<DhcpConfiguration> _dhcpConfigurations = AWSConfigs.InitializeCollections ? new List<DhcpConfiguration>() : null;
        private bool? _dryRun;
        private List<TagSpecification> _tagSpecifications = AWSConfigs.InitializeCollections ? new List<TagSpecification>() : null;

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
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
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
            return this._dhcpConfigurations != null && (this._dhcpConfigurations.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property DryRun. 
        /// <para>
        /// Checks whether you have the required permissions for the action, without actually
        /// making the request, and provides an error response. If you have the required permissions,
        /// the error response is <c>DryRunOperation</c>. Otherwise, it is <c>UnauthorizedOperation</c>.
        /// </para>
        /// </summary>
        public bool? DryRun
        {
            get { return this._dryRun; }
            set { this._dryRun = value; }
        }

        // Check to see if DryRun property is set
        internal bool IsSetDryRun()
        {
            return this._dryRun.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property TagSpecifications. 
        /// <para>
        /// The tags to assign to the DHCP option.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<TagSpecification> TagSpecifications
        {
            get { return this._tagSpecifications; }
            set { this._tagSpecifications = value; }
        }

        // Check to see if TagSpecifications property is set
        internal bool IsSetTagSpecifications()
        {
            return this._tagSpecifications != null && (this._tagSpecifications.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}