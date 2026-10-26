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
    /// Used in DescribeClusterResult, DescribeClusterSummary, UpdateClusterResult.
    /// </summary>
    public partial class ClusterNetworkSettings
    {
        /// <summary>
        /// Gets and sets the property DefaultRoute. The network interface that is the default
        /// route for traffic to and from the node. MediaLive Anywhere uses this default when
        /// the destination for the traffic isn't covered by the route table for any of the networks.
        /// Specify the value of the appropriate logicalInterfaceName parameter that you create
        /// in the interfaceMappings.
        /// </summary>
        public string DefaultRoute { get; set; }

        /// <summary>
        /// Checks to see if the DefaultRoute property is set.
        /// </summary>
        internal bool IsSetDefaultRoute() => this.DefaultRoute != null;

        /// <summary>
        /// Gets and sets the property InterfaceMappings. An array of interfaceMapping objects
        /// for this Cluster. Each mapping logically connects one interface on the nodes with
        /// one Network. You need only one mapping for each interface because all the Nodes share
        /// the mapping.
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<InterfaceMapping> InterfaceMappings { get; set; } = AWSConfigs.InitializeCollections ? new List<InterfaceMapping>() : null;

        /// <summary>
        /// Checks to see if the InterfaceMappings property is set.
        /// </summary>
        internal bool IsSetInterfaceMappings() => this.InterfaceMappings != null && (this.InterfaceMappings.Count > 0 || !AWSConfigs.InitializeCollections);
    }
}
