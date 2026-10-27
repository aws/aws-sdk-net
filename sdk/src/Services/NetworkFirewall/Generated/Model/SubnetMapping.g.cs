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
    /// The ID for a subnet that's used in an association with a firewall. This is used in
    /// <a>CreateFirewall</a>, <a>AssociateSubnets</a>, and <a>CreateVpcEndpointAssociation</a>.
    /// Network Firewall creates an instance of the associated firewall in each subnet that
    /// you specify, to filter traffic in the subnet's Availability Zone.
    /// </summary>
    public partial class SubnetMapping
    {
        /// <summary>
        /// Gets and sets the property IPAddressType. 
        /// <para>
        /// The subnet's IP address type. You can't change the IP address type after you create
        /// the subnet.
        /// </para>
        /// </summary>
        public IPAddressType IPAddressType { get; set; }

        /// <summary>
        /// Checks to see if the IPAddressType property is set.
        /// </summary>
        internal bool IsSetIPAddressType() => this.IPAddressType != null;

        /// <summary>
        /// Gets and sets the property SubnetId. 
        /// <para>
        /// The unique identifier for the subnet. 
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
