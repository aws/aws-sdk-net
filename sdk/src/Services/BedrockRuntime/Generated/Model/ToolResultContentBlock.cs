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
    /// The tool result content block.
    /// </summary>
    public partial class ToolResultContentBlock
    {
        private DocumentBlock _document;
        private ImageBlock _image;
        private Amazon.Runtime.Documents.Document _json;
        private string _text;
        private VideoBlock _video;

        /// <summary>
        /// Gets and sets the property Document. 
        /// <para>
        /// A tool result that is a document.
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
        /// Gets and sets the property Image. 
        /// <para>
        /// A tool result that is an image.
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
        /// Gets and sets the property Json. 
        /// <para>
        /// A tool result that is JSON format data.
        /// </para>
        /// </summary>
        public Amazon.Runtime.Documents.Document Json
        {
            get { return this._json; }
            set { this._json = value; }
        }

        // Check to see if Json property is set
        internal bool IsSetJson()
        {
            return !this._json.IsNull();
        }

        /// <summary>
        /// Gets and sets the property Text. 
        /// <para>
        /// A tool result that is text.
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
        /// Gets and sets the property Video. 
        /// <para>
        /// A tool result that is video.
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