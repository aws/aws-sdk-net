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
    /// Describes an IPv6 address associated with a network interface.
    /// </summary>
    public partial class NetworkInterfaceIpv6Address
    {
        private string _ipv6Address;
        private bool? _isPrimaryIpv6;
        private string _publicIpv6DnsName;

        /// <summary>
        /// Gets and sets the property Ipv6Address. 
        /// <para>
        /// The IPv6 address.
        /// </para>
        /// </summary>
        public string Ipv6Address
        {
            get { return this._ipv6Address; }
            set { this._ipv6Address = value; }
        }

        // Check to see if Ipv6Address property is set
        internal bool IsSetIpv6Address()
        {
            return this._ipv6Address != null;
        }

        /// <summary>
        /// Gets and sets the property IsPrimaryIpv6. 
        /// <para>
        /// Determines if an IPv6 address associated with a network interface is the primary IPv6
        /// address. When you enable an IPv6 GUA address to be a primary IPv6, the first IPv6
        /// GUA will be made the primary IPv6 address until the instance is terminated or the
        /// network interface is detached. For more information, see <a href="https://docs.aws.amazon.com/AWSEC2/latest/APIReference/API_ModifyNetworkInterfaceAttribute.html">ModifyNetworkInterfaceAttribute</a>.
        /// </para>
        /// </summary>
        public bool? IsPrimaryIpv6
        {
            get { return this._isPrimaryIpv6; }
            set { this._isPrimaryIpv6 = value; }
        }

        // Check to see if IsPrimaryIpv6 property is set
        internal bool IsSetIsPrimaryIpv6()
        {
            return this._isPrimaryIpv6.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property PublicIpv6DnsName. 
        /// <para>
        /// An IPv6-enabled public hostname for a network interface. Requests from within the
        /// VPC or from the internet resolve to the IPv6 GUA of the network interface. For more
        /// information, see <a href="https://docs.aws.amazon.com/AWSEC2/latest/UserGuide/ec2-instance-naming.html">EC2
        /// instance hostnames, DNS names, and domains</a> in the <i>Amazon EC2 User Guide</i>.
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