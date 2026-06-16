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
    /// The tools definition for an MCP descriptor. Contains the protocol version and inline
    /// content describing the available tools.
    /// </summary>
    public partial class ToolsDefinition
    {
        private string _inlineContent;
        private string _protocolVersion;

        /// <summary>
        /// Gets and sets the property InlineContent. 
        /// <para>
        /// The JSON content containing the MCP tools definition, conforming to the MCP protocol
        /// specification.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=102400)]
        public string InlineContent
        {
            get { return this._inlineContent; }
            set { this._inlineContent = value; }
        }

        // Check to see if InlineContent property is set
        internal bool IsSetInlineContent()
        {
            return this._inlineContent != null;
        }

        /// <summary>
        /// Gets and sets the property ProtocolVersion. 
        /// <para>
        /// The protocol version of the tools definition based on the MCP protocol specification.
        /// If not specified, the version is auto-detected from the content.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=255)]
        public string ProtocolVersion
        {
            get { return this._protocolVersion; }
            set { this._protocolVersion = value; }
        }

        // Check to see if ProtocolVersion property is set
        internal bool IsSetProtocolVersion()
        {
            return this._protocolVersion != null;
        }

    }
}