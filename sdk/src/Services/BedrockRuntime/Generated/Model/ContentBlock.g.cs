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
        /// <summary>
        /// Gets and sets the property Audio. 
        /// <para>
        /// An audio content block containing audio data in the conversation.
        /// </para>
        /// </summary>
        public AudioBlock Audio { get; set; }

        /// <summary>
        /// Checks to see if the Audio property is set.
        /// </summary>
        internal bool IsSetAudio() => this.Audio != null;

        /// <summary>
        /// Gets and sets the property CachePoint. 
        /// <para>
        /// CachePoint to include in the message.
        /// </para>
        /// </summary>
        public CachePointBlock CachePoint { get; set; }

        /// <summary>
        /// Checks to see if the CachePoint property is set.
        /// </summary>
        internal bool IsSetCachePoint() => this.CachePoint != null;

        /// <summary>
        /// Gets and sets the property CitationsContent. 
        /// <para>
        /// A content block that contains both generated text and associated citation information,
        /// providing traceability between the response and source documents.
        /// </para>
        /// </summary>
        public CitationsContentBlock CitationsContent { get; set; }

        /// <summary>
        /// Checks to see if the CitationsContent property is set.
        /// </summary>
        internal bool IsSetCitationsContent() => this.CitationsContent != null;

        /// <summary>
        /// Gets and sets the property Document. 
        /// <para>
        /// A document to include in the message.
        /// </para>
        /// </summary>
        public DocumentBlock Document { get; set; }

        /// <summary>
        /// Checks to see if the Document property is set.
        /// </summary>
        internal bool IsSetDocument() => this.Document != null;

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
        public GuardrailConverseContentBlock GuardContent { get; set; }

        /// <summary>
        /// Checks to see if the GuardContent property is set.
        /// </summary>
        internal bool IsSetGuardContent() => this.GuardContent != null;

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
        public ImageBlock Image { get; set; }

        /// <summary>
        /// Checks to see if the Image property is set.
        /// </summary>
        internal bool IsSetImage() => this.Image != null;

        /// <summary>
        /// Gets and sets the property ReasoningContent. 
        /// <para>
        /// Contains content regarding the reasoning that is carried out by the model. Reasoning
        /// refers to a Chain of Thought (CoT) that the model generates to enhance the accuracy
        /// of its final response.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive = true)]
        public ReasoningContentBlock ReasoningContent { get; set; }

        /// <summary>
        /// Checks to see if the ReasoningContent property is set.
        /// </summary>
        internal bool IsSetReasoningContent() => this.ReasoningContent != null;

        /// <summary>
        /// Gets and sets the property SearchResult. 
        /// <para>
        /// Search result to include in the message.
        /// </para>
        /// </summary>
        public SearchResultBlock SearchResult { get; set; }

        /// <summary>
        /// Checks to see if the SearchResult property is set.
        /// </summary>
        internal bool IsSetSearchResult() => this.SearchResult != null;

        /// <summary>
        /// Gets and sets the property Text. 
        /// <para>
        /// Text to include in the message.
        /// </para>
        /// </summary>
        public string Text { get; set; }

        /// <summary>
        /// Checks to see if the Text property is set.
        /// </summary>
        internal bool IsSetText() => this.Text != null;

        /// <summary>
        /// Gets and sets the property ToolAddition.
        /// </summary>
        public ToolAdditionBlock ToolAddition { get; set; }

        /// <summary>
        /// Checks to see if the ToolAddition property is set.
        /// </summary>
        internal bool IsSetToolAddition() => this.ToolAddition != null;

        /// <summary>
        /// Gets and sets the property ToolRemoval.
        /// </summary>
        public ToolRemovalBlock ToolRemoval { get; set; }

        /// <summary>
        /// Checks to see if the ToolRemoval property is set.
        /// </summary>
        internal bool IsSetToolRemoval() => this.ToolRemoval != null;

        /// <summary>
        /// Gets and sets the property ToolResult. 
        /// <para>
        /// The result for a tool request that a model makes.
        /// </para>
        /// </summary>
        public ToolResultBlock ToolResult { get; set; }

        /// <summary>
        /// Checks to see if the ToolResult property is set.
        /// </summary>
        internal bool IsSetToolResult() => this.ToolResult != null;

        /// <summary>
        /// Gets and sets the property ToolUse. 
        /// <para>
        /// Information about a tool use request from a model.
        /// </para>
        /// </summary>
        public ToolUseBlock ToolUse { get; set; }

        /// <summary>
        /// Checks to see if the ToolUse property is set.
        /// </summary>
        internal bool IsSetToolUse() => this.ToolUse != null;

        /// <summary>
        /// Gets and sets the property Video. 
        /// <para>
        /// Video to include in the message. 
        /// </para>
        /// </summary>
        public VideoBlock Video { get; set; }

        /// <summary>
        /// Checks to see if the Video property is set.
        /// </summary>
        internal bool IsSetVideo() => this.Video != null;
    }
}
