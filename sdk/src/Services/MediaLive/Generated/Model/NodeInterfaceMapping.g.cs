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

namespace Amazon.MediaLive.Model
{
    /// <summary>
    /// A mapping that's used to pair a logical network interface name on a Node with the
    /// physical interface name exposed in the operating system.
    /// </summary>
    public partial class NodeInterfaceMapping
    {
        /// <summary>
        /// Gets and sets the property LogicalInterfaceName. A uniform logical interface name
        /// to address in a MediaLive channel configuration.
        /// </summary>
        public string LogicalInterfaceName { get; set; }

        /// <summary>
        /// Checks to see if the LogicalInterfaceName property is set.
        /// </summary>
        internal bool IsSetLogicalInterfaceName() => this.LogicalInterfaceName != null;

        /// <summary>
        /// Gets and sets the property NetworkInterfaceMode.
        /// </summary>
        public NetworkInterfaceMode NetworkInterfaceMode { get; set; }

        /// <summary>
        /// Checks to see if the NetworkInterfaceMode property is set.
        /// </summary>
        internal bool IsSetNetworkInterfaceMode() => this.NetworkInterfaceMode != null;

        /// <summary>
        /// Gets and sets the property PhysicalInterfaceIpAddresses. The IP addresses associated
        /// with the physical interface on the node hardware.
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> PhysicalInterfaceIpAddresses { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the PhysicalInterfaceIpAddresses property is set.
        /// </summary>
        internal bool IsSetPhysicalInterfaceIpAddresses() => this.PhysicalInterfaceIpAddresses != null && (this.PhysicalInterfaceIpAddresses.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property PhysicalInterfaceName. The name of the physical interface
        /// on the hardware that will be running Elemental anywhere.
        /// </summary>
        public string PhysicalInterfaceName { get; set; }

        /// <summary>
        /// Checks to see if the PhysicalInterfaceName property is set.
        /// </summary>
        internal bool IsSetPhysicalInterfaceName() => this.PhysicalInterfaceName != null;
    }
}
