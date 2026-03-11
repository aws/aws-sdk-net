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
 * Do not modify this file. This file is generated from the application-signals-2024-04-15.normal.json service model.
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
        private ConnectionType _connectionType;
        private string _destinationNodeId;
        private double? _duration;
        private string _sourceNodeId;

        /// <summary>
        /// Gets and sets the property ConnectionType. 
        /// <para>
        /// The type of connection between the nodes, indicating the nature of the relationship.
        /// </para>
        /// </summary>
        public ConnectionType ConnectionType
        {
            get { return this._connectionType; }
            set { this._connectionType = value; }
        }

        // Check to see if ConnectionType property is set
        internal bool IsSetConnectionType()
        {
            return this._connectionType != null;
        }

        /// <summary>
        /// Gets and sets the property DestinationNodeId. 
        /// <para>
        /// The identifier of the destination node in this edge connection.
        /// </para>
        /// </summary>
        public string DestinationNodeId
        {
            get { return this._destinationNodeId; }
            set { this._destinationNodeId = value; }
        }

        // Check to see if DestinationNodeId property is set
        internal bool IsSetDestinationNodeId()
        {
            return this._destinationNodeId != null;
        }

        /// <summary>
        /// Gets and sets the property Duration. 
        /// <para>
        /// The duration or latency associated with this connection, if applicable.
        /// </para>
        /// </summary>
        public double? Duration
        {
            get { return this._duration; }
            set { this._duration = value; }
        }

        // Check to see if Duration property is set
        internal bool IsSetDuration()
        {
            return this._duration.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property SourceNodeId. 
        /// <para>
        /// The identifier of the source node in this edge connection.
        /// </para>
        /// </summary>
        public string SourceNodeId
        {
            get { return this._sourceNodeId; }
            set { this._sourceNodeId = value; }
        }

        // Check to see if SourceNodeId property is set
        internal bool IsSetSourceNodeId()
        {
            return this._sourceNodeId != null;
        }

    }
}