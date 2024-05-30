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
 * Do not modify this file. This file is generated from the bedrock-runtime-2023-09-30.normal.json service model.
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
namespace Amazon.BedrockRuntime.Model
{
    /// <summary>
    /// A block of content for a message.
    /// </summary>
    public partial class ContentBlock
    {
        private ImageBlock _image;
        private string _text;
        private ToolResultBlock _toolResult;
        private ToolUseBlock _toolUse;

        /// <summary>
        /// Gets and sets the property Image. 
        /// <para>
        /// Image to include in the message. 
        /// </para>
        ///  <note> 
        /// <para>
        /// This field is only supported by Anthropic Claude 3 models.
        /// </para>
        ///  </note>
        /// </summary>
        public ImageBlock Image
        {
            get { return this._image; }
            set { this._image = value; }
        }

        // Check to see if Image property is set
        internal bool IsSetImage()
        {
            return this._image != null;
        }

        /// <summary>
        /// Gets and sets the property Text. 
        /// <para>
        /// Text to include in the message.
        /// </para>
        /// </summary>
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
        /// The result for a tool request that a model makes.
        /// </para>
        /// </summary>
        public ToolResultBlock ToolResult
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
        /// Information about a tool use request from a model. 
        /// </para>
        /// </summary>
        public ToolUseBlock ToolUse
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