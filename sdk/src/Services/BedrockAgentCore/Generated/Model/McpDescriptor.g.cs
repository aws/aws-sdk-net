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

namespace Amazon.BedrockAgentCore.Model
{
    /// <summary>
    /// The MCP (Model Context Protocol) descriptor configuration for a registry record.
    /// Contains the server definition and tools definition.
    /// </summary>
    public partial class McpDescriptor
    {
        /// <summary>
        /// Gets and sets the property Server. 
        /// <para>
        ///  The MCP server definition that describes the server configuration.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public ServerDefinition Server { get; set; }

        /// <summary>
        /// Checks to see if the Server property is set.
        /// </summary>
        internal bool IsSetServer() => this.Server != null;

        /// <summary>
        /// Gets and sets the property Tools. 
        /// <para>
        ///  The MCP tools definition that describes the available tools.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public ToolsDefinition Tools { get; set; }

        /// <summary>
        /// Checks to see if the Tools property is set.
        /// </summary>
        internal bool IsSetTools() => this.Tools != null;
    }
}
