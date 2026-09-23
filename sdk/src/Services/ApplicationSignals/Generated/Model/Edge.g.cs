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
    /// A structure that represents a connection between two nodes in a dependency graph,
    /// showing the relationship and characteristics of the connection.
    /// </summary>
    public partial class Edge
    {
        /// <summary>
        /// Gets and sets the property ConnectionType. 
        /// <para>
        /// The type of connection between the nodes, indicating the nature of the relationship.
        /// </para>
        /// </summary>
        public ConnectionType ConnectionType { get; set; }

        /// <summary>
        /// Checks to see if the ConnectionType property is set.
        /// </summary>
        internal bool IsSetConnectionType() => this.ConnectionType != null;

        /// <summary>
        /// Gets and sets the property DestinationNodeId. 
        /// <para>
        /// The identifier of the destination node in this edge connection.
        /// </para>
        /// </summary>
        public string DestinationNodeId { get; set; }

        /// <summary>
        /// Checks to see if the DestinationNodeId property is set.
        /// </summary>
        internal bool IsSetDestinationNodeId() => this.DestinationNodeId != null;

        /// <summary>
        /// Gets and sets the property Duration. 
        /// <para>
        /// The duration or latency associated with this connection, if applicable.
        /// </para>
        /// </summary>
        public double? Duration { get; set; }

        /// <summary>
        /// Checks to see if the Duration property is set.
        /// </summary>
        internal bool IsSetDuration() => this.Duration.HasValue;

        /// <summary>
        /// Gets and sets the property SourceNodeId. 
        /// <para>
        /// The identifier of the source node in this edge connection.
        /// </para>
        /// </summary>
        public string SourceNodeId { get; set; }

        /// <summary>
        /// Checks to see if the SourceNodeId property is set.
        /// </summary>
        internal bool IsSetSourceNodeId() => this.SourceNodeId != null;
    }
}
