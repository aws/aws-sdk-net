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
    /// The tool result content block. For more information, see <a href="https://docs.aws.amazon.com/bedrock/latest/userguide/tool-use.html">Call
    /// a tool with the Converse API</a> in the Amazon Bedrock User Guide.
    /// </summary>
    public partial class ToolResultContentBlock
    {
        /// <summary>
        /// Gets and sets the property Document. 
        /// <para>
        /// A tool result that is a document.
        /// </para>
        /// </summary>
        public DocumentBlock Document { get; set; }

        /// <summary>
        /// Checks to see if the Document property is set.
        /// </summary>
        internal bool IsSetDocument() => this.Document != null;

        /// <summary>
        /// Gets and sets the property Image. 
        /// <para>
        /// A tool result that is an image. 
        /// </para>
        ///  <note> 
        /// <para>
        /// This field is only supported by Amazon Nova and Anthropic Claude 3 and 4 models.
        /// </para>
        ///  </note>
        /// </summary>
        public ImageBlock Image { get; set; }

        /// <summary>
        /// Checks to see if the Image property is set.
        /// </summary>
        internal bool IsSetImage() => this.Image != null;

        /// <summary>
        /// Gets and sets the property Json. 
        /// <para>
        /// A tool result that is JSON format data. 
        /// </para>
        /// </summary>
        public Amazon.Runtime.Documents.Document Json { get; set; }

        /// <summary>
        /// Checks to see if the Json property is set.
        /// </summary>
        internal bool IsSetJson() => !this.Json.IsNull();

        /// <summary>
        /// Gets and sets the property SearchResult. 
        /// <para>
        /// A tool result that is a search result.
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
        /// A tool result that is text. 
        /// </para>
        /// </summary>
        public string Text { get; set; }

        /// <summary>
        /// Checks to see if the Text property is set.
        /// </summary>
        internal bool IsSetText() => this.Text != null;

        /// <summary>
        /// Gets and sets the property Video. 
        /// <para>
        /// A tool result that is video.
        /// </para>
        /// </summary>
        public VideoBlock Video { get; set; }

        /// <summary>
        /// Checks to see if the Video property is set.
        /// </summary>
        internal bool IsSetVideo() => this.Video != null;
    }
}
