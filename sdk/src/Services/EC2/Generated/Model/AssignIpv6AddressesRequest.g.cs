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
    /// Container for the parameters to the AssignIpv6Addresses operation. Assigns the specified
    /// IPv6 addresses to the specified network interface. You can specify specific IPv6 addresses,
    /// or you can specify the number of IPv6 addresses to be automatically assigned from
    /// the subnet's IPv6 CIDR block range. You can assign as many IPv6 addresses to a network
    /// interface as you can assign private IPv4 addresses, and the limit varies by instance
    /// type. <para> You must specify either the IPv6 addresses or the IPv6 address count
    /// in the request. </para> <para> You can optionally use Prefix Delegation on the network
    /// interface. You must specify either the IPV6 Prefix Delegation prefixes, or the IPv6
    /// Prefix Delegation count. For information, see <a href="https://docs.aws.amazon.com/AWSEC2/latest/UserGuide/ec2-prefix-eni.html">
    /// Assigning prefixes to network interfaces</a> in the <i>Amazon EC2 User Guide</i>.
    /// </para>
    /// </summary>
    public partial class AssignIpv6AddressesRequest : AmazonEC2Request
    {
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
        public int? Ipv6AddressCount { get; set; }

        /// <summary>
        /// Checks to see if the Ipv6AddressCount property is set.
        /// </summary>
        internal bool IsSetIpv6AddressCount() => this.Ipv6AddressCount.HasValue;

        /// <summary>
        /// Gets and sets the property Ipv6Addresses. 
        /// <para>
        /// The IPv6 addresses to be assigned to the network interface. You can't use this option
        /// if you're specifying a number of IPv6 addresses.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> Ipv6Addresses { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the Ipv6Addresses property is set.
        /// </summary>
        internal bool IsSetIpv6Addresses() => this.Ipv6Addresses != null && (this.Ipv6Addresses.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property Ipv6PrefixCount. 
        /// <para>
        /// The number of IPv6 prefixes that Amazon Web Services automatically assigns to the
        /// network interface. You cannot use this option if you use the <c>Ipv6Prefixes</c> option.
        /// </para>
        /// </summary>
        public int? Ipv6PrefixCount { get; set; }

        /// <summary>
        /// Checks to see if the Ipv6PrefixCount property is set.
        /// </summary>
        internal bool IsSetIpv6PrefixCount() => this.Ipv6PrefixCount.HasValue;

        /// <summary>
        /// Gets and sets the property Ipv6Prefixes. 
        /// <para>
        /// One or more IPv6 prefixes assigned to the network interface. You can't use this option
        /// if you use the <c>Ipv6PrefixCount</c> option.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> Ipv6Prefixes { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the Ipv6Prefixes property is set.
        /// </summary>
        internal bool IsSetIpv6Prefixes() => this.Ipv6Prefixes != null && (this.Ipv6Prefixes.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property NetworkInterfaceId. 
        /// <para>
        /// The ID of the network interface.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string NetworkInterfaceId { get; set; }

        /// <summary>
        /// Checks to see if the NetworkInterfaceId property is set.
        /// </summary>
        internal bool IsSetNetworkInterfaceId() => this.NetworkInterfaceId != null;
    }
}
