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
    /// Authorization configuration for SigV4-authenticated MCP server.
    /// </summary>
    public partial class MCPServerSigV4AuthorizationConfig
    {
        /// <summary>
        /// Gets and sets the property CustomHeaders. 
        /// <para>
        /// Custom headers for the SigV4 MCP server.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Max = 10)]
        public Dictionary<string, string> CustomHeaders { get; set; } = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;

        /// <summary>
        /// Checks to see if the CustomHeaders property is set.
        /// </summary>
        internal bool IsSetCustomHeaders() => this.CustomHeaders != null && (this.CustomHeaders.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property McpRoleArn. 
        /// <para>
        /// IAM role ARN to assume for SigV4 signing. Optional — when omitted, credentials are
        /// resolved at runtime via a monitor account association.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 255)]
        public string McpRoleArn { get; set; }

        /// <summary>
        /// Checks to see if the McpRoleArn property is set.
        /// </summary>
        internal bool IsSetMcpRoleArn() => this.McpRoleArn != null;

        /// <summary>
        /// Gets and sets the property Region. 
        /// <para>
        /// AWS region for SigV4 signing. Use '*' for SigV4a multi-region signing.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 50)]
        public string Region { get; set; }

        /// <summary>
        /// Checks to see if the Region property is set.
        /// </summary>
        internal bool IsSetRegion() => this.Region != null;

        /// <summary>
        /// Gets and sets the property RoleArn. 
        /// <para>
        /// Deprecated — use mcpRoleArn instead. IAM role ARN to assume for SigV4 signing.
        /// </para>
        /// </summary>
        [Obsolete("Use mcpRoleArn instead.")]
        [AWSProperty(Min = 0, Max = 255)]
        public string RoleArn { get; set; }

        /// <summary>
        /// Checks to see if the RoleArn property is set.
        /// </summary>
        internal bool IsSetRoleArn() => this.RoleArn != null;

        /// <summary>
        /// Gets and sets the property Service. 
        /// <para>
        /// AWS service name for SigV4 signing.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 100)]
        public string Service { get; set; }

        /// <summary>
        /// Checks to see if the Service property is set.
        /// </summary>
        internal bool IsSetService() => this.Service != null;
    }
}
