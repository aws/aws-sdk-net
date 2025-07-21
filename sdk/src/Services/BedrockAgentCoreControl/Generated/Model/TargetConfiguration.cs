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
 * Do not modify this file. This file is generated from the bedrock-agentcore-control-2023-06-05.normal.json service model.
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
namespace Amazon.BedrockAgentCoreControl.Model
{
    /// <summary>
    /// The configuration for a gateway target. This structure defines how the gateway connects
    /// to and interacts with the target endpoint.
    /// </summary>
    public partial class TargetConfiguration
    {
        private McpTargetConfiguration _mcp;

        /// <summary>
        /// Gets and sets the property Mcp. 
        /// <para>
        /// The Model Context Protocol (MCP) configuration for the target. This configuration
        /// defines how the gateway uses MCP to communicate with the target.
        /// </para>
        /// </summary>
        public McpTargetConfiguration Mcp
        {
            get { return this._mcp; }
            set { this._mcp = value; }
        }

        // Check to see if Mcp property is set
        internal bool IsSetMcp()
        {
            return this._mcp != null;
        }

    }
}