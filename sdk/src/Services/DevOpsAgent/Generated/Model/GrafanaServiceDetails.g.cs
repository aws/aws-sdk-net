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
    /// Complete service details for Grafana MCP server integration.
    /// </summary>
    public partial class GrafanaServiceDetails
    {
        /// <summary>
        /// Gets and sets the property AuthorizationConfig. 
        /// <para>
        /// Grafana MCP server authorization configuration (experimental).
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public MCPServerAuthorizationConfig AuthorizationConfig { get; set; }

        /// <summary>
        /// Checks to see if the AuthorizationConfig property is set.
        /// </summary>
        internal bool IsSetAuthorizationConfig() => this.AuthorizationConfig != null;

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// Optional description for the MCP server.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive = true, Max = 500)]
        public string Description { get; set; }

        /// <summary>
        /// Checks to see if the Description property is set.
        /// </summary>
        internal bool IsSetDescription() => this.Description != null;

        /// <summary>
        /// Gets and sets the property Endpoint. 
        /// <para>
        /// MCP server endpoint URL.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 2048)]
        public string Endpoint { get; set; }

        /// <summary>
        /// Checks to see if the Endpoint property is set.
        /// </summary>
        internal bool IsSetEndpoint() => this.Endpoint != null;

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// MCP server name.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 128)]
        public string Name { get; set; }

        /// <summary>
        /// Checks to see if the Name property is set.
        /// </summary>
        internal bool IsSetName() => this.Name != null;
    }
}
