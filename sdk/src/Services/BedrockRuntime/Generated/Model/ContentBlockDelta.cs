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
    /// A block of content in a streaming response.
    /// </summary>
    public partial class ContentBlockDelta
    {
        private CitationsDelta _citation;
        private ReasoningContentBlockDelta _reasoningContent;
        private string _text;
        private ToolUseBlockDelta _toolUse;

        /// <summary>
        /// Gets and sets the property Citation. 
        /// <para>
        /// Incremental citation information that is streamed as part of the response generation
        /// process.
        /// </para>
        /// </summary>
        public CitationsDelta Citation
        {
            get { return this._citation; }
            set { this._citation = value; }
        }

        // Check to see if Citation property is set
        internal bool IsSetCitation()
        {
            return this._citation != null;
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
        public ReasoningContentBlockDelta ReasoningContent
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
        /// The content text.
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
        /// Gets and sets the property ToolUse. 
        /// <para>
        /// Information about a tool that the model is requesting to use.
        /// </para>
        /// </summary>
        public ToolUseBlockDelta ToolUse
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