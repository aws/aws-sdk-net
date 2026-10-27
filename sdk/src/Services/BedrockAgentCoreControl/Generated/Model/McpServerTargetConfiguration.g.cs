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

namespace Amazon.BedrockAgentCoreControl.Model
{
    /// <summary>
    /// The target configuration for the MCP server.
    /// </summary>
    public partial class McpServerTargetConfiguration
    {
        /// <summary>
        /// Gets and sets the property Endpoint. 
        /// <para>
        /// The endpoint for the MCP server target configuration.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string Endpoint { get; set; }

        /// <summary>
        /// Checks to see if the Endpoint property is set.
        /// </summary>
        internal bool IsSetEndpoint() => this.Endpoint != null;

        /// <summary>
        /// Gets and sets the property ListingMode. 
        /// <para>
        /// The listing mode for the MCP server target configuration. MCP resources for default
        /// targets are cached at the control plane for faster access. MCP resources for dynamic
        /// targets will be dynamically retrieved when listing tools.
        /// </para>
        /// </summary>
        public ListingMode ListingMode { get; set; }

        /// <summary>
        /// Checks to see if the ListingMode property is set.
        /// </summary>
        internal bool IsSetListingMode() => this.ListingMode != null;

        /// <summary>
        /// Gets and sets the property McpToolSchema. 
        /// <para>
        /// A static tool list for the MCP server target. It is supported for all credential providers.
        /// Dynamic tool discovery/synchronization will be disabled when a target is configured
        /// with mcpToolSchema.
        /// </para>
        /// </summary>
        public McpToolSchemaConfiguration McpToolSchema { get; set; }

        /// <summary>
        /// Checks to see if the McpToolSchema property is set.
        /// </summary>
        internal bool IsSetMcpToolSchema() => this.McpToolSchema != null;

        /// <summary>
        /// Gets and sets the property ResourcePriority. 
        /// <para>
        /// Priority for resolving MCP server targets with shared resource URIs. Lower values
        /// take precedence. Defaults to 1000 when not set.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 1000)]
        public int? ResourcePriority { get; set; }

        /// <summary>
        /// Checks to see if the ResourcePriority property is set.
        /// </summary>
        internal bool IsSetResourcePriority() => this.ResourcePriority.HasValue;
    }
}
