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

namespace Amazon.ApplicationSignals.Model
{
    /// <summary>
    /// A structure that represents the dependency relationships relevant to an audit finding,
    /// containing nodes and edges that show how services and resources are connected.
    /// </summary>
    public partial class DependencyGraph
    {
        /// <summary>
        /// Gets and sets the property Edges. 
        /// <para>
        /// An array of edges representing the connections and relationships between the nodes
        /// in the dependency graph.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<Edge> Edges { get; set; } = AWSConfigs.InitializeCollections ? new List<Edge>() : null;

        /// <summary>
        /// Checks to see if the Edges property is set.
        /// </summary>
        internal bool IsSetEdges() => this.Edges != null && (this.Edges.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property Nodes. 
        /// <para>
        /// An array of nodes representing the services, resources, or other entities in the dependency
        /// graph.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Max = 4)]
        public List<Node> Nodes { get; set; } = AWSConfigs.InitializeCollections ? new List<Node>() : null;

        /// <summary>
        /// Checks to see if the Nodes property is set.
        /// </summary>
        internal bool IsSetNodes() => this.Nodes != null && (this.Nodes.Count > 0 || !AWSConfigs.InitializeCollections);
    }
}
