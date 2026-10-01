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
    /// Details specific to a registered Grafana server, used by the built-in MCP server.
    /// </summary>
    public partial class RegisteredGrafanaServerDetails
    {
        /// <summary>
        /// Gets and sets the property AuthorizationMethod. 
        /// <para>
        /// The authz method used by the MCP server.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public MCPServerAuthorizationMethod AuthorizationMethod { get; set; }

        /// <summary>
        /// Checks to see if the AuthorizationMethod property is set.
        /// </summary>
        internal bool IsSetAuthorizationMethod() => this.AuthorizationMethod != null;

        /// <summary>
        /// Gets and sets the property Endpoint. 
        /// <para>
        /// Grafana instance URL (e.g., https://your-instance.grafana.net)
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 2048)]
        public string Endpoint { get; set; }

        /// <summary>
        /// Checks to see if the Endpoint property is set.
        /// </summary>
        internal bool IsSetEndpoint() => this.Endpoint != null;
    }
}
