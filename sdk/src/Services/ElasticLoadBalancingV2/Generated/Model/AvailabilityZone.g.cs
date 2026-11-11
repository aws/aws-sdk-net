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

namespace Amazon.ElasticLoadBalancingV2.Model
{
    /// <summary>
    /// Information about an Availability Zone.
    /// </summary>
    public partial class AvailabilityZone
    {
        /// <summary>
        /// Gets and sets the property LoadBalancerAddresses. 
        /// <para>
        /// [Network Load Balancers] If you need static IP addresses for your load balancer, you
        /// can specify one Elastic IP address per Availability Zone when you create an internal-facing
        /// load balancer. For internal load balancers, you can specify a private IP address from
        /// the IPv4 range of the subnet.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<LoadBalancerAddress> LoadBalancerAddresses { get; set; } = AWSConfigs.InitializeCollections ? new List<LoadBalancerAddress>() : null;

        /// <summary>
        /// Checks to see if the LoadBalancerAddresses property is set.
        /// </summary>
        internal bool IsSetLoadBalancerAddresses() => this.LoadBalancerAddresses != null && (this.LoadBalancerAddresses.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property OutpostId. 
        /// <para>
        /// [Application Load Balancers on Outposts] The ID of the Outpost.
        /// </para>
        /// </summary>
        public string OutpostId { get; set; }

        /// <summary>
        /// Checks to see if the OutpostId property is set.
        /// </summary>
        internal bool IsSetOutpostId() => this.OutpostId != null;

        /// <summary>
        /// Gets and sets the property SourceNatIpv6Prefixes. 
        /// <para>
        /// [Network Load Balancers with UDP listeners] The IPv6 prefixes to use for source NAT.
        /// For each subnet, specify an IPv6 prefix (/80 netmask) from the subnet CIDR block or
        /// <c>auto_assigned</c> to use an IPv6 prefix selected at random from the subnet CIDR
        /// block.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> SourceNatIpv6Prefixes { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the SourceNatIpv6Prefixes property is set.
        /// </summary>
        internal bool IsSetSourceNatIpv6Prefixes() => this.SourceNatIpv6Prefixes != null && (this.SourceNatIpv6Prefixes.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property SubnetId. 
        /// <para>
        /// The ID of the subnet. You can specify one subnet per Availability Zone.
        /// </para>
        /// </summary>
        public string SubnetId { get; set; }

        /// <summary>
        /// Checks to see if the SubnetId property is set.
        /// </summary>
        internal bool IsSetSubnetId() => this.SubnetId != null;

        /// <summary>
        /// Gets and sets the property ZoneName. 
        /// <para>
        /// The name of the Availability Zone.
        /// </para>
        /// </summary>
        public string ZoneName { get; set; }

        /// <summary>
        /// Checks to see if the ZoneName property is set.
        /// </summary>
        internal bool IsSetZoneName() => this.ZoneName != null;
    }
}
