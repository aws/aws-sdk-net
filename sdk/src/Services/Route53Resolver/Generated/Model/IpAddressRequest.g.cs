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

namespace Amazon.Route53Resolver.Model
{
    /// <summary>
    /// In a <a href="https://docs.aws.amazon.com/Route53/latest/APIReference/API_route53resolver_CreateResolverEndpoint.html">CreateResolverEndpoint</a>
    /// request, the IP address that DNS queries originate from (for outbound endpoints) or
    /// that you forward DNS queries to (for inbound endpoints). <c>IpAddressRequest</c> also
    /// includes the ID of the subnet that contains the IP address.
    /// </summary>
    public partial class IpAddressRequest
    {
        /// <summary>
        /// Gets and sets the property Ip. 
        /// <para>
        /// The IPv4 address that you want to use for DNS queries.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 7, Max = 36)]
        public string Ip { get; set; }

        /// <summary>
        /// Checks to see if the Ip property is set.
        /// </summary>
        internal bool IsSetIp() => this.Ip != null;

        /// <summary>
        /// Gets and sets the property Ipv6. 
        /// <para>
        ///  The IPv6 address that you want to use for DNS queries. 
        /// </para>
        /// </summary>
        [AWSProperty(Min = 7, Max = 39)]
        public string Ipv6 { get; set; }

        /// <summary>
        /// Checks to see if the Ipv6 property is set.
        /// </summary>
        internal bool IsSetIpv6() => this.Ipv6 != null;

        /// <summary>
        /// Gets and sets the property SubnetId. 
        /// <para>
        /// The ID of the subnet that contains the IP address. 
        /// </para>
        ///  
        /// <para>
        /// We recommend using <a href="https://docs.aws.amazon.com/Route53/latest/DeveloperGuide/outpost-resolver-getting-started.html">VPC
        /// Resolver on Outposts</a> to create endpoints on Outposts Racks.
        /// </para>
        ///  <important> 
        /// <para>
        /// Outposts subnets with <a href="https://docs.aws.amazon.com/outposts/latest/server-userguide/local-network-interface.html">Local
        /// Network Interface (LNI)</a> enabled are not compatible with Route 53 Resolver endpoints.
        /// If you enable LNI on a subnet that contains Route 53 Resolver endpoint elastic network
        /// interfaces (ENIs), those ENIs will stop functioning. For more information, see <a
        /// href="https://docs.aws.amazon.com/Route53/latest/DeveloperGuide/best-practices-resolver.html#best-practices-resolver-subnet-compatibility">Subnet
        /// compatibility for Resolver endpoints</a> in the <i>Amazon Route 53 Developer Guide</i>.
        /// </para>
        ///  </important>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 32)]
        public string SubnetId { get; set; }

        /// <summary>
        /// Checks to see if the SubnetId property is set.
        /// </summary>
        internal bool IsSetSubnetId() => this.SubnetId != null;
    }
}
