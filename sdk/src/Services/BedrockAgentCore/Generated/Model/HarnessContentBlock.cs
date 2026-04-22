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
    /// A content block within a message.
    /// </summary>
    public partial class HarnessContentBlock
    {
        private HarnessReasoningContentBlock _reasoningContent;
        private string _text;
        private HarnessToolResultBlock _toolResult;
        private HarnessToolUseBlock _toolUse;

        /// <summary>
        /// Gets and sets the property ReasoningContent. 
        /// <para>
        /// Model reasoning content.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive=true)]
        public HarnessReasoningContentBlock ReasoningContent
        {
            get { return this._reasoningContent; }
            set { this._reasoningContent = value; }
        }

        // Check to see if ReasoningContent property is set
        internal bool IsSetReasoningContent()
        {
            return this._reasoningContent != null;
        }

        /// <summary>
        /// Gets and sets the property Text. 
        /// <para>
        /// Text content.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive=true, Min=1)]
        public string Text
        {
            get { return this._text; }
            set { this._text = value; }
        }

        // Check to see if Text property is set
        internal bool IsSetText()
        {
            return this._text != null;
        }

        /// <summary>
        /// Gets and sets the property ToolResult. 
        /// <para>
        /// A tool execution result.
        /// </para>
        /// </summary>
        public HarnessToolResultBlock ToolResult
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
        /// A tool use request from the model.
        /// </para>
        /// </summary>
        public HarnessToolUseBlock ToolUse
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