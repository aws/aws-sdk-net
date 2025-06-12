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
 * Do not modify this file. This file is generated from the bedrock-agent-2023-06-05.normal.json service model.
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
namespace Amazon.BedrockAgent.Model
{
    /// <summary>
    /// The definition of the nodes and connections between nodes in the flow.
    /// </summary>
    public partial class FlowDefinition
    {
        private List<FlowConnection> _connections = AWSConfigs.InitializeCollections ? new List<FlowConnection>() : null;
        private List<FlowNode> _nodes = AWSConfigs.InitializeCollections ? new List<FlowNode>() : null;

        /// <summary>
        /// Gets and sets the property Connections. 
        /// <para>
        /// An array of connection definitions in the flow.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=0, Max=20)]
        public List<FlowConnection> Connections
        {
            get { return this._connections; }
            set { this._connections = value; }
        }

        // Check to see if Connections property is set
        internal bool IsSetConnections()
        {
            return this._connections != null && (this._connections.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property Nodes. 
        /// <para>
        /// An array of node definitions in the flow.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=0, Max=40)]
        public List<FlowNode> Nodes
        {
            get { return this._nodes; }
            set { this._nodes = value; }
        }

        // Check to see if Nodes property is set
        internal bool IsSetNodes()
        {
            return this._nodes != null && (this._nodes.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}