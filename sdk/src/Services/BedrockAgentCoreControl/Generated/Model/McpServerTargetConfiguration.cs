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
    /// The target configuration for the MCP server.
    /// </summary>
    public partial class McpServerTargetConfiguration
    {
        private string _endpoint;
        private ListingMode _listingMode;
        private McpToolSchemaConfiguration _mcpToolSchema;
        private int? _resourcePriority;

        /// <summary>
        /// Gets and sets the property Endpoint. 
        /// <para>
        /// The endpoint for the MCP server target configuration.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string Endpoint
        {
            get { return this._endpoint; }
            set { this._endpoint = value; }
        }

        // Check to see if Endpoint property is set
        internal bool IsSetEndpoint()
        {
            return this._endpoint != null;
        }

        /// <summary>
        /// Gets and sets the property ListingMode. 
        /// <para>
        /// The listing mode for the MCP server target configuration. MCP resources for default
        /// targets are cached at the control plane for faster access. MCP resources for dynamic
        /// targets will be dynamically retrieved when listing tools.
        /// </para>
        /// </summary>
        public ListingMode ListingMode
        {
            get { return this._listingMode; }
            set { this._listingMode = value; }
        }

        // Check to see if ListingMode property is set
        internal bool IsSetListingMode()
        {
            return this._listingMode != null;
        }

        /// <summary>
        /// Gets and sets the property McpToolSchema. 
        /// <para>
        /// The tool schema configuration for the MCP server target. Supported only when the credential
        /// provider is configured with an authorization code grant type. Dynamic tool discovery/synchronization
        /// will be disabled when target is configured with mcpToolSchema.
        /// </para>
        /// </summary>
        public McpToolSchemaConfiguration McpToolSchema
        {
            get { return this._mcpToolSchema; }
            set { this._mcpToolSchema = value; }
        }

        // Check to see if McpToolSchema property is set
        internal bool IsSetMcpToolSchema()
        {
            return this._mcpToolSchema != null;
        }

        /// <summary>
        /// Gets and sets the property ResourcePriority. 
        /// <para>
        /// Priority for resolving MCP server targets with shared resource URIs. Lower values
        /// take precedence. Defaults to 1000 when not set.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=1000)]
        public int? ResourcePriority
        {
            get { return this._resourcePriority; }
            set { this._resourcePriority = value; }
        }

        // Check to see if ResourcePriority property is set
        internal bool IsSetResourcePriority()
        {
            return this._resourcePriority.HasValue; 
        }

    }
}