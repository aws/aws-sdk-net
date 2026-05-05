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
 * Do not modify this file. This file is generated from the bedrock-agentcore-2024-02-28.normal.json service model.
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
    /// The start payload for a content block.
    /// </summary>
    public partial class HarnessContentBlockStart
    {
        private HarnessToolResultBlockStart _toolResult;
        private HarnessToolUseBlockStart _toolUse;

        /// <summary>
        /// Gets and sets the property ToolResult. 
        /// <para>
        /// Start of a tool result content block.
        /// </para>
        /// </summary>
        public HarnessToolResultBlockStart ToolResult
        {
            get { return this._toolResult; }
            set { this._toolResult = value; }
        }

        // Check to see if ToolResult property is set
        internal bool IsSetToolResult()
        {
            return this._toolResult != null;
        }

        /// <summary>
        /// Gets and sets the property ToolUse. 
        /// <para>
        /// Start of a tool use content block.
        /// </para>
        /// </summary>
        public HarnessToolUseBlockStart ToolUse
        {
            get { return this._toolUse; }
            set { this._toolUse = value; }
        }

        // Check to see if ToolUse property is set
        internal bool IsSetToolUse()
        {
            return this._toolUse != null;
        }

    }
}