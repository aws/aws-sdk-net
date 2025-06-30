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
    /// A block of content for a message that you pass to, or receive from, a model with the
    /// <a href="https://docs.aws.amazon.com/bedrock/latest/APIReference/API_runtime_Converse.html">Converse</a>
    /// or <a href="https://docs.aws.amazon.com/bedrock/latest/APIReference/API_runtime_ConverseStream.html">ConverseStream</a>
    /// API operations.
    /// </summary>
    public partial class ContentBlock
    {
        private CachePointBlock _cachePoint;
        private CitationsContentBlock _citationsContent;
        private DocumentBlock _document;
        private GuardrailConverseContentBlock _guardContent;
        private ImageBlock _image;
        private ReasoningContentBlock _reasoningContent;
        private string _text;
        private ToolResultBlock _toolResult;
        private ToolUseBlock _toolUse;
        private VideoBlock _video;

        /// <summary>
        /// Gets and sets the property CachePoint. 
        /// <para>
        /// CachePoint to include in the message.
        /// </para>
        /// </summary>
        public CachePointBlock CachePoint
        {
            get { return this._cachePoint; }
            set { this._cachePoint = value; }
        }

        // Check to see if CachePoint property is set
        internal bool IsSetCachePoint()
        {
            return this._cachePoint != null;
        }

        /// <summary>
        /// Gets and sets the property CitationsContent. 
        /// <para>
        /// A content block that contains both generated text and associated citation information,
        /// providing traceability between the response and source documents.
        /// </para>
        /// </summary>
        public CitationsContentBlock CitationsContent
        {
            get { return this._citationsContent; }
            set { this._citationsContent = value; }
        }

        // Check to see if CitationsContent property is set
        internal bool IsSetCitationsContent()
        {
            return this._citationsContent != null;
        }

        /// <summary>
        /// Gets and sets the property Document. 
        /// <para>
        /// A document to include in the message.
        /// </para>
        /// </summary>
        public DocumentBlock Document
        {
            get { return this._document; }
            set { this._document = value; }
        }

        // Check to see if Document property is set
        internal bool IsSetDocument()
        {
            return this._document != null;
        }

        /// <summary>
        /// Gets and sets the property GuardContent. 
        /// <para>
        /// Contains the content to assess with the guardrail. If you don't specify <c>guardContent</c>
        /// in a call to the Converse API, the guardrail (if passed in the Converse API) assesses
        /// the entire message.
        /// </para>
        ///  
        /// <para>
        /// For more information, see <i>Use a guardrail with the Converse API</i> in the <i>Amazon
        /// Bedrock User Guide</i>. 
        /// </para>
        /// </summary>
        public GuardrailConverseContentBlock GuardContent
        {
            get { return this._guardContent; }
            set { this._guardContent = value; }
        }

        // Check to see if GuardContent property is set
        internal bool IsSetGuardContent()
        {
            return this._guardContent != null;
        }

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
        /// Gets and sets the property ReasoningContent. 
        /// <para>
        /// Contains content regarding the reasoning that is carried out by the model. Reasoning
        /// refers to a Chain of Thought (CoT) that the model generates to enhance the accuracy
        /// of its final response.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive=true)]
        public ReasoningContentBlock ReasoningContent
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

        /// <summary>
        /// Gets and sets the property Video. 
        /// <para>
        /// Video to include in the message. 
        /// </para>
        /// </summary>
        public VideoBlock Video
        {
            get { return this._video; }
            set { this._video = value; }
        }

        // Check to see if Video property is set
        internal bool IsSetVideo()
        {
            return this._video != null;
        }

    }
}