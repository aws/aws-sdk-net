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
    /// Describes the configuration of a subnet for a VPC endpoint.
    /// </summary>
    public partial class SubnetConfiguration
    {
        /// <summary>
        /// Gets and sets the property Ipv4. 
        /// <para>
        /// The IPv4 address to assign to the endpoint network interface in the subnet. You must
        /// provide an IPv4 address if the VPC endpoint supports IPv4.
        /// </para>
        ///  
        /// <para>
        /// If you specify an IPv4 address when modifying a VPC endpoint, we replace the existing
        /// endpoint network interface with a new endpoint network interface with this IP address.
        /// This process temporarily disconnects the subnet and the VPC endpoint.
        /// </para>
        /// </summary>
        public string Ipv4 { get; set; }

        /// <summary>
        /// Checks to see if the Ipv4 property is set.
        /// </summary>
        internal bool IsSetIpv4() => this.Ipv4 != null;

        /// <summary>
        /// Gets and sets the property Ipv6. 
        /// <para>
        /// The IPv6 address to assign to the endpoint network interface in the subnet. You must
        /// provide an IPv6 address if the VPC endpoint supports IPv6.
        /// </para>
        ///  
        /// <para>
        /// If you specify an IPv6 address when modifying a VPC endpoint, we replace the existing
        /// endpoint network interface with a new endpoint network interface with this IP address.
        /// This process temporarily disconnects the subnet and the VPC endpoint.
        /// </para>
        /// </summary>
        public string Ipv6 { get; set; }

        /// <summary>
        /// Checks to see if the Ipv6 property is set.
        /// </summary>
        internal bool IsSetIpv6() => this.Ipv6 != null;

        /// <summary>
        /// Gets and sets the property SubnetId. 
        /// <para>
        /// The ID of the subnet.
        /// </para>
        /// </summary>
        public string SubnetId { get; set; }

        /// <summary>
        /// Checks to see if the SubnetId property is set.
        /// </summary>
        internal bool IsSetSubnetId() => this.SubnetId != null;
    }
}
