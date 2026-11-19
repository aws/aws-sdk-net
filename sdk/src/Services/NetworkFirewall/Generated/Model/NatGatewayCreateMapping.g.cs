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

namespace Amazon.NetworkFirewall.Model
{
    /// <summary>
    /// A NAT gateway that Network Firewall creates for a proxy mode firewall in one Availability
    /// Zone. You use this in <c>CreateFirewall</c> and <c>AssociateSubnets</c>.
    /// 
    ///  
    /// <para>
    /// To create a public NAT gateway, specify <c>AllocationIds</c>, and one <c>PrivateIps</c>
    /// address for each Elastic IP address. To create a private NAT gateway, specify only
    /// <c>PrivateIps</c>. You must specify at least one of them. Each Elastic IP address
    /// and private IP address can appear only once in a request.
    /// </para>
    ///  
    /// <para>
    /// The NAT gateway is a resource in your account. To change its IP addresses, use Amazon
    /// EC2 NAT gateway actions.
    /// </para>
    /// </summary>
    public partial class NatGatewayCreateMapping
    {
        /// <summary>
        /// Gets and sets the property AllocationIds. 
        /// <para>
        /// The allocation IDs of the Elastic IP addresses for a public NAT gateway, from 1 to
        /// 8. For each allocation ID, specify one address in <c>PrivateIps</c>. If you don't
        /// specify this, Network Firewall creates a private NAT gateway.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 1, Max = 32)]
        public List<string> AllocationIds { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the AllocationIds property is set.
        /// </summary>
        internal bool IsSetAllocationIds() => this.AllocationIds != null && (this.AllocationIds.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property PrivateIps. 
        /// <para>
        /// The private IPv4 addresses of the NAT gateway. The addresses must be in the subnet
        /// that you specify and can't be the subnet's reserved addresses.
        /// </para>
        ///  
        /// <para>
        /// For a public NAT gateway, you must specify exactly one address for each Elastic IP
        /// address in <c>AllocationIds</c>, even if you specify only one. For a private NAT gateway,
        /// specify from 1 to 8 addresses. The first address is the primary address.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 1, Max = 32)]
        public List<string> PrivateIps { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the PrivateIps property is set.
        /// </summary>
        internal bool IsSetPrivateIps() => this.PrivateIps != null && (this.PrivateIps.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property SubnetId. 
        /// <para>
        /// The ID of the subnet where Network Firewall creates the NAT gateway. The subnet must
        /// be in the firewall's VPC and can't be one of the firewall endpoint subnets. Each mapping
        /// must be in a different Availability Zone.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string SubnetId { get; set; }

        /// <summary>
        /// Checks to see if the SubnetId property is set.
        /// </summary>
        internal bool IsSetSubnetId() => this.SubnetId != null;
    }
}
