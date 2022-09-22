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
    /// Container for the parameters to the AssignIpv6Addresses operation.
    /// Assigns one or more IPv6 addresses to the specified network interface. You can specify
    /// one or more specific IPv6 addresses, or you can specify the number of IPv6 addresses
    /// to be automatically assigned from within the subnet's IPv6 CIDR block range. You can
    /// assign as many IPv6 addresses to a network interface as you can assign private IPv4
    /// addresses, and the limit varies per instance type. For information, see <a href="https://docs.aws.amazon.com/AWSEC2/latest/UserGuide/using-eni.html#AvailableIpPerENI">IP
    /// Addresses Per Network Interface Per Instance Type</a> in the <i>Amazon Elastic Compute
    /// Cloud User Guide</i>.
    /// 
    ///  
    /// <para>
    /// You must specify either the IPv6 addresses or the IPv6 address count in the request.
    /// 
    /// </para>
    ///  
    /// <para>
    /// You can optionally use Prefix Delegation on the network interface. You must specify
    /// either the IPV6 Prefix Delegation prefixes, or the IPv6 Prefix Delegation count. For
    /// information, see <a href="https://docs.aws.amazon.com/AWSEC2/latest/UserGuide/ec2-prefix-eni.html">
    /// Assigning prefixes to Amazon EC2 network interfaces</a> in the <i>Amazon Elastic Compute
    /// Cloud User Guide</i>.
    /// </para>
    /// </summary>
    public partial class AssignIpv6AddressesRequest : AmazonEC2Request
    {
        private int? _ipv6AddressCount;
        private List<string> _ipv6Addresses = new List<string>();
        private int? _ipv6PrefixCount;
        private List<string> _ipv6Prefixes = new List<string>();
        private string _networkInterfaceId;

        /// <summary>
        /// Gets and sets the property Ipv6AddressCount. 
        /// <para>
        /// The number of additional IPv6 addresses to assign to the network interface. The specified
        /// number of IPv6 addresses are assigned in addition to the existing IPv6 addresses that
        /// are already assigned to the network interface. Amazon EC2 automatically selects the
        /// IPv6 addresses from the subnet range. You can't use this option if specifying specific
        /// IPv6 addresses.
        /// </para>
        /// </summary>
        public int Ipv6AddressCount
        {
            get { return this._ipv6AddressCount.GetValueOrDefault(); }
            set { this._ipv6AddressCount = value; }
        }

        // Check to see if Ipv6AddressCount property is set
        internal bool IsSetIpv6AddressCount()
        {
            return this._ipv6AddressCount.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Ipv6Addresses. 
        /// <para>
        /// The IPv6 addresses to be assigned to the network interface. You can't use this option
        /// if you're specifying a number of IPv6 addresses.
        /// </para>
        /// </summary>
        public List<string> Ipv6Addresses
        {
            get { return this._ipv6Addresses; }
            set { this._ipv6Addresses = value; }
        }

        // Check to see if Ipv6Addresses property is set
        internal bool IsSetIpv6Addresses()
        {
            return this._ipv6Addresses != null && this._ipv6Addresses.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property Ipv6PrefixCount. 
        /// <para>
        /// The number of IPv6 prefixes that Amazon Web Services automatically assigns to the
        /// network interface. You cannot use this option if you use the <code>Ipv6Prefixes</code>
        /// option.
        /// </para>
        /// </summary>
        public int Ipv6PrefixCount
        {
            get { return this._ipv6PrefixCount.GetValueOrDefault(); }
            set { this._ipv6PrefixCount = value; }
        }

        // Check to see if Ipv6PrefixCount property is set
        internal bool IsSetIpv6PrefixCount()
        {
            return this._ipv6PrefixCount.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Ipv6Prefixes. 
        /// <para>
        /// One or more IPv6 prefixes assigned to the network interface. You cannot use this option
        /// if you use the <code>Ipv6PrefixCount</code> option.
        /// </para>
        /// </summary>
        public List<string> Ipv6Prefixes
        {
            get { return this._ipv6Prefixes; }
            set { this._ipv6Prefixes = value; }
        }

        // Check to see if Ipv6Prefixes property is set
        internal bool IsSetIpv6Prefixes()
        {
            return this._ipv6Prefixes != null && this._ipv6Prefixes.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property NetworkInterfaceId. 
        /// <para>
        /// The ID of the network interface.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string NetworkInterfaceId
        {
            get { return this._networkInterfaceId; }
            set { this._networkInterfaceId = value; }
        }

        // Check to see if NetworkInterfaceId property is set
        internal bool IsSetNetworkInterfaceId()
        {
            return this._networkInterfaceId != null;
        }

    }
}