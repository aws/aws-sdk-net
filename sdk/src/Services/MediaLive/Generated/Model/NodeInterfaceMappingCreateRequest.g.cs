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
    /// Used in CreateNodeRequest.
    /// </summary>
    public partial class NodeInterfaceMappingCreateRequest
    {
        /// <summary>
        /// Gets and sets the property LogicalInterfaceName. Specify one of the logicalInterfaceNames
        /// that you created in the Cluster that this node belongs to. For example, my-Inputs-Interface.
        /// </summary>
        public string LogicalInterfaceName { get; set; }

        /// <summary>
        /// Checks to see if the LogicalInterfaceName property is set.
        /// </summary>
        internal bool IsSetLogicalInterfaceName() => this.LogicalInterfaceName != null;

        /// <summary>
        /// Gets and sets the property NetworkInterfaceMode. The style of the network -- NAT or
        /// BRIDGE.
        /// </summary>
        public NetworkInterfaceMode NetworkInterfaceMode { get; set; }

        /// <summary>
        /// Checks to see if the NetworkInterfaceMode property is set.
        /// </summary>
        internal bool IsSetNetworkInterfaceMode() => this.NetworkInterfaceMode != null;

        /// <summary>
        /// Gets and sets the property PhysicalInterfaceName. Specify the physical name that corresponds
        /// to the logicalInterfaceName that you specified in this interface mapping. For example,
        /// Eth1 or ENO1234EXAMPLE.
        /// </summary>
        public string PhysicalInterfaceName { get; set; }

        /// <summary>
        /// Checks to see if the PhysicalInterfaceName property is set.
        /// </summary>
        internal bool IsSetPhysicalInterfaceName() => this.PhysicalInterfaceName != null;
    }
}
