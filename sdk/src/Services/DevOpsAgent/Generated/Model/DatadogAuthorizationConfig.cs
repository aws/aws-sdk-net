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
 * Do not modify this file. This file is generated from the devops-agent-2026-01-01.normal.json service model.
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
    /// Authorization configuration for Datadog MCP server (uses authorization discovery only).
    /// </summary>
    public partial class DatadogAuthorizationConfig
    {
        private MCPServerAuthorizationDiscoveryConfig _authorizationDiscovery;

        /// <summary>
        /// Gets and sets the property AuthorizationDiscovery. 
        /// <para>
        /// Datadog MCP server authorization discovery configuration.
        /// </para>
        /// </summary>
        public MCPServerAuthorizationDiscoveryConfig AuthorizationDiscovery
        {
            get { return this._authorizationDiscovery; }
            set { this._authorizationDiscovery = value; }
        }

        // Check to see if AuthorizationDiscovery property is set
        internal bool IsSetAuthorizationDiscovery()
        {
            return this._authorizationDiscovery != null;
        }

    }
}