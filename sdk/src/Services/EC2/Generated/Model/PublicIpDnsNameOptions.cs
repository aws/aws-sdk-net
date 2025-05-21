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
    /// Public hostname type options. For more information, see <a href="https://docs.aws.amazon.com/AWSEC2/latest/UserGuide/ec2-instance-naming.html">EC2
    /// instance hostnames, DNS names, and domains</a> in the <i>Amazon EC2 User Guide</i>.
    /// </summary>
    public partial class PublicIpDnsNameOptions
    {
        private string _dnsHostnameType;
        private string _publicDualStackDnsName;
        private string _publicIpv4DnsName;
        private string _publicIpv6DnsName;

        /// <summary>
        /// Gets and sets the property DnsHostnameType. 
        /// <para>
        /// The public hostname type. For more information, see <a href="https://docs.aws.amazon.com/AWSEC2/latest/UserGuide/ec2-instance-naming.html">EC2
        /// instance hostnames, DNS names, and domains</a> in the <i>Amazon EC2 User Guide</i>.
        /// </para>
        /// </summary>
        public string DnsHostnameType
        {
            get { return this._dnsHostnameType; }
            set { this._dnsHostnameType = value; }
        }

        // Check to see if DnsHostnameType property is set
        internal bool IsSetDnsHostnameType()
        {
            return this._dnsHostnameType != null;
        }

        /// <summary>
        /// Gets and sets the property PublicDualStackDnsName. 
        /// <para>
        /// A dual-stack public hostname for a network interface. Requests from within the VPC
        /// resolve to both the private IPv4 address and the IPv6 Global Unicast Address of the
        /// network interface. Requests from the internet resolve to both the public IPv4 and
        /// the IPv6 GUA address of the network interface.
        /// </para>
        /// </summary>
        public string PublicDualStackDnsName
        {
            get { return this._publicDualStackDnsName; }
            set { this._publicDualStackDnsName = value; }
        }

        // Check to see if PublicDualStackDnsName property is set
        internal bool IsSetPublicDualStackDnsName()
        {
            return this._publicDualStackDnsName != null;
        }

        /// <summary>
        /// Gets and sets the property PublicIpv4DnsName. 
        /// <para>
        /// An IPv4-enabled public hostname for a network interface. Requests from within the
        /// VPC resolve to the private primary IPv4 address of the network interface. Requests
        /// from the internet resolve to the public IPv4 address of the network interface.
        /// </para>
        /// </summary>
        public string PublicIpv4DnsName
        {
            get { return this._publicIpv4DnsName; }
            set { this._publicIpv4DnsName = value; }
        }

        // Check to see if PublicIpv4DnsName property is set
        internal bool IsSetPublicIpv4DnsName()
        {
            return this._publicIpv4DnsName != null;
        }

        /// <summary>
        /// Gets and sets the property PublicIpv6DnsName. 
        /// <para>
        /// An IPv6-enabled public hostname for a network interface. Requests from within the
        /// VPC or from the internet resolve to the IPv6 GUA of the network interface.
        /// </para>
        /// </summary>
        public string PublicIpv6DnsName
        {
            get { return this._publicIpv6DnsName; }
            set { this._publicIpv6DnsName = value; }
        }

        // Check to see if PublicIpv6DnsName property is set
        internal bool IsSetPublicIpv6DnsName()
        {
            return this._publicIpv6DnsName != null;
        }

    }
}