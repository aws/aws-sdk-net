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
    /// An override that applies a connectivity treatment to the subnets that a scope selects,
    /// instead of the policy's <c>defaultSubnetConnectivity</c>.
    /// </summary>
    public partial class SubnetConnectivityOverride
    {
        /// <summary>
        /// Gets and sets the property ConnectivityType. 
        /// <para>
        /// The connectivity treatment to apply to the selected subnets. You select both the override
        /// value as well as the subnets they apply to. The Network Firewall automated internet
        /// firewall applies the override value to the specified subnets, and applies the default
        /// connectivity to the rest of the subnets. Valid values:
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
        ///  </li> <li> 
        /// <para>
        ///  <c>exclude</c> – The Network Firewall automated internet firewall doesn't inspect
        /// traffic for the selected subnets. The subnets bypass the firewall entirely, and their
        /// traffic passes directly through the internet gateway. You can specify this value only
        /// in an override, not as the <c>defaultSubnetConnectivity</c>.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        [AWSProperty(Required = true)]
        public SubnetConnectivity ConnectivityType { get; set; }

        /// <summary>
        /// Checks to see if the ConnectivityType property is set.
        /// </summary>
        internal bool IsSetConnectivityType() => this.ConnectivityType != null;

        /// <summary>
        /// Gets and sets the property Scopes. 
        /// <para>
        /// A list that contains the Amazon Resource Name (ARN) of the scope that selects the
        /// subnets to override. The list must contain exactly one scope ARN. The deployment determines
        /// which accounts are in scope, and the referenced scope selects subnets within those
        /// accounts.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required = true, Max = 1)]
        public List<string> Scopes { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the Scopes property is set.
        /// </summary>
        internal bool IsSetScopes() => this.Scopes != null && (this.Scopes.Count > 0 || !AWSConfigs.InitializeCollections);
    }
}
