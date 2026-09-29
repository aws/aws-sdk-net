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
    /// The MCP tools definition with a protocol version and inline content. The <c>protocolVersion</c>
    /// identifies the MCP protocol version that the tools conform to. This differs from <c>schemaVersion</c>
    /// in the server definition, which identifies the server configuration schema format.
    /// </summary>
    public partial class ToolsDefinition
    {
        /// <summary>
        /// Gets and sets the property InlineContent. 
        /// <para>
        ///  The inline content of the tools definition.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 409600)]
        public string InlineContent { get; set; }

        /// <summary>
        /// Checks to see if the InlineContent property is set.
        /// </summary>
        internal bool IsSetInlineContent() => this.InlineContent != null;

        /// <summary>
        /// Gets and sets the property ProtocolVersion. 
        /// <para>
        ///  The MCP protocol version that the tools conform to. This differs from the <c>schemaVersion</c>
        /// field in the server definition, which identifies the server configuration schema format.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 255)]
        public string ProtocolVersion { get; set; }

        /// <summary>
        /// Checks to see if the ProtocolVersion property is set.
        /// </summary>
        internal bool IsSetProtocolVersion() => this.ProtocolVersion != null;
    }
}
