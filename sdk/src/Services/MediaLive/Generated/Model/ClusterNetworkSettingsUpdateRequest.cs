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
 * Do not modify this file. This file is generated from the medialive-2017-10-14.normal.json service model.
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
    /// Placeholder documentation for ClusterNetworkSettingsUpdateRequest
    /// </summary>
    public partial class ClusterNetworkSettingsUpdateRequest
    {
        private string _defaultRoute;
        private List<InterfaceMappingUpdateRequest> _interfaceMappings = AWSConfigs.InitializeCollections ? new List<InterfaceMappingUpdateRequest>() : null;

        /// <summary>
        /// Gets and sets the property DefaultRoute. Include this parameter only if you want to
        /// change the default route for the Cluster. Specify one network interface as the default
        /// route for traffic to and from the node. MediaLive Anywhere uses this default when
        /// the destination for the traffic isn't covered by the route table for any of the networks.
        /// Specify the value of the appropriate logicalInterfaceName parameter that you create
        /// in the interfaceMappings.
        /// </summary>
        public string DefaultRoute
        {
            get { return this._defaultRoute; }
            set { this._defaultRoute = value; }
        }

        // Check to see if DefaultRoute property is set
        internal bool IsSetDefaultRoute()
        {
            return this._defaultRoute != null;
        }

        /// <summary>
        /// Gets and sets the property InterfaceMappings. An array of interfaceMapping objects
        /// for this Cluster. Include this parameter only if you want to change the interface
        /// mappings for the Cluster. Typically, you change the interface mappings only to fix
        /// an error you made when creating the mapping. In an update request, make sure that
        /// you enter the entire set of mappings again, not just the mappings that you want to
        /// add or change. You define this mapping so that the mapping can be used by all the
        /// Nodes. Each mapping logically connects one interface on the nodes with one Network.
        /// Each mapping consists of a pair of parameters. The logicalInterfaceName parameter
        /// creates a logical name for the Node interface that handles a specific type of traffic.
        /// For example, my-Inputs-Interface. The networkID parameter refers to the ID of the
        /// network. When you create the Nodes in this Cluster, you will associate the logicalInterfaceName
        /// with the appropriate physical interface.
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<InterfaceMappingUpdateRequest> InterfaceMappings
        {
            get { return this._interfaceMappings; }
            set { this._interfaceMappings = value; }
        }

        // Check to see if InterfaceMappings property is set
        internal bool IsSetInterfaceMappings()
        {
            return this._interfaceMappings != null && (this._interfaceMappings.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}