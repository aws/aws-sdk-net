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

namespace Amazon.NetworkSecurityManager.Model
{
    /// <summary>
    /// Policy configuration settings for Network Firewall automated internet firewall policies.
    /// </summary>
    public partial class IgwFirewallConfig
    {
        /// <summary>
        /// Gets and sets the property DefaultSubnetConnectivity. 
        /// <para>
        /// The default internet connectivity treatment that AWS Network Security Manager applies
        /// to subnets in scope, unless a subnet connectivity override applies. Required for Network
        /// Firewall automated internet firewall policies. Valid values:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>flexible</c> – Sets the connectivity for each network interface in the subnet
        /// based on whether it is associated with a public IP address. A network interface with
        /// a public IP address gets bidirectional internet connectivity. A network interface
        /// without a public IP address gets outbound-only connectivity. All traffic is inspected
        /// against your firewall rules.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>bidirectional</c> – Provides bidirectional internet connectivity to every network
        /// interface that has a public IP association. Any network interface without a public
        /// IP cannot communicate with the internet unless a NAT device is explicitly inserted
        /// in the path. All inbound and outbound traffic is inspected against your firewall rules.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>outbound-only</c> – Provides egress-only connectivity for all network interfaces
        /// in the subnet. All outbound traffic and inbound responses are inspected against your
        /// firewall rules. Unsolicited inbound connections are dropped. For IPv4 traffic, the
        /// Network Firewall automated internet firewall performs NAT.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public DefaultSubnetConnectivity DefaultSubnetConnectivity { get; set; }

        /// <summary>
        /// Checks to see if the DefaultSubnetConnectivity property is set.
        /// </summary>
        internal bool IsSetDefaultSubnetConnectivity() => this.DefaultSubnetConnectivity != null;

        /// <summary>
        /// Gets and sets the property SubnetConnectivityOverrides. 
        /// <para>
        /// An ordered list of overrides that apply a different connectivity treatment to the
        /// subnets that a scope selects. When a subnet matches more than one override, the first
        /// matching override in the list applies. You can specify at most one override for each
        /// connectivity type.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Max = 4)]
        public List<SubnetConnectivityOverride> SubnetConnectivityOverrides { get; set; } = AWSConfigs.InitializeCollections ? new List<SubnetConnectivityOverride>() : null;

        /// <summary>
        /// Checks to see if the SubnetConnectivityOverrides property is set.
        /// </summary>
        internal bool IsSetSubnetConnectivityOverrides() => this.SubnetConnectivityOverrides != null && (this.SubnetConnectivityOverrides.Count > 0 || !AWSConfigs.InitializeCollections);
    }
}
