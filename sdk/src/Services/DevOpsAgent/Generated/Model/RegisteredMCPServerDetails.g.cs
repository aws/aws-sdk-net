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

namespace Amazon.DevOpsAgent.Model
{
    /// <summary>
    /// Details specific to a registered MCP (Model Context Protocol) server.
    /// </summary>
    public partial class RegisteredMCPServerDetails
    {
        /// <summary>
        /// Gets and sets the property ApiKeyHeader. 
        /// <para>
        /// If the MCP server uses API key authentication, these details are provided.
        /// </para>
        /// </summary>
        public string ApiKeyHeader { get; set; }

        /// <summary>
        /// Checks to see if the ApiKeyHeader property is set.
        /// </summary>
        internal bool IsSetApiKeyHeader() => this.ApiKeyHeader != null;

        /// <summary>
        /// Gets and sets the property AuthorizationMethod. 
        /// <para>
        /// The MCP server uses this authorization method.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public MCPServerAuthorizationMethod AuthorizationMethod { get; set; }

        /// <summary>
        /// Checks to see if the AuthorizationMethod property is set.
        /// </summary>
        internal bool IsSetAuthorizationMethod() => this.AuthorizationMethod != null;

        /// <summary>
        /// Gets and sets the property CustomHeaderNames. 
        /// <para>
        /// The configured custom authentication header names when the MCP server uses custom-header
        /// authentication. Secret values are not returned.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Max = 3)]
        public List<string> CustomHeaderNames { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the CustomHeaderNames property is set.
        /// </summary>
        internal bool IsSetCustomHeaderNames() => this.CustomHeaderNames != null && (this.CustomHeaderNames.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// Optional description for the MCP server.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive = true, Min = 1, Max = 1000)]
        public string Description { get; set; }

        /// <summary>
        /// Checks to see if the Description property is set.
        /// </summary>
        internal bool IsSetDescription() => this.Description != null;

        /// <summary>
        /// Gets and sets the property Endpoint. 
        /// <para>
        /// The MCP server endpoint URL.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string Endpoint { get; set; }

        /// <summary>
        /// Checks to see if the Endpoint property is set.
        /// </summary>
        internal bool IsSetEndpoint() => this.Endpoint != null;

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The MCP server name.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string Name { get; set; }

        /// <summary>
        /// Checks to see if the Name property is set.
        /// </summary>
        internal bool IsSetName() => this.Name != null;
    }
}
