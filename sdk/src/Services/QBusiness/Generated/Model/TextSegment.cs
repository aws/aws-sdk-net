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
 * Do not modify this file. This file is generated from the qbusiness-2023-11-27.normal.json service model.
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
namespace Amazon.QBusiness.Model
{
    /// <summary>
    /// Provides information about a text extract in a chat response that can be attributed
    /// to a source document.
    /// </summary>
    public partial class TextSegment
    {
        private int? _beginOffset;
        private int? _endOffset;
        private string _mediaId;
        private string _mediaMimeType;
        private SnippetExcerpt _snippetExcerpt;
        private SourceDetails _sourceDetails;

        /// <summary>
        /// Gets and sets the property BeginOffset. 
        /// <para>
        /// The zero-based location in the response string where the source attribution starts.
        /// </para>
        /// </summary>
        public int? BeginOffset
        {
            get { return this._beginOffset; }
            set { this._beginOffset = value; }
        }

        // Check to see if BeginOffset property is set
        internal bool IsSetBeginOffset()
        {
            return this._beginOffset.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property EndOffset. 
        /// <para>
        /// The zero-based location in the response string where the source attribution ends.
        /// </para>
        /// </summary>
        public int? EndOffset
        {
            get { return this._endOffset; }
            set { this._endOffset = value; }
        }

        // Check to see if EndOffset property is set
        internal bool IsSetEndOffset()
        {
            return this._endOffset.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property MediaId. 
        /// <para>
        /// The identifier of the media object associated with the text segment in the source
        /// attribution.
        /// </para>
        /// </summary>
        [Obsolete("Deprecated in favor of using mediaId within the respective sourceDetails field.")]
        [AWSProperty(Min=36, Max=36)]
        public string MediaId
        {
            get { return this._mediaId; }
            set { this._mediaId = value; }
        }

        // Check to see if MediaId property is set
        internal bool IsSetMediaId()
        {
            return this._mediaId != null;
        }

        /// <summary>
        /// Gets and sets the property MediaMimeType. 
        /// <para>
        /// The MIME type (image/png) of the media object associated with the text segment in
        /// the source attribution.
        /// </para>
        /// </summary>
        [Obsolete("Deprecated in favor of using mediaMimeType within the respective sourceDetails field.")]
        [AWSProperty(Min=1, Max=2048)]
        public string MediaMimeType
        {
            get { return this._mediaMimeType; }
            set { this._mediaMimeType = value; }
        }

        // Check to see if MediaMimeType property is set
        internal bool IsSetMediaMimeType()
        {
            return this._mediaMimeType != null;
        }

        /// <summary>
        /// Gets and sets the property SnippetExcerpt. 
        /// <para>
        /// The relevant text excerpt from a source that was used to generate a citation text
        /// segment in an Amazon Q Business chat response.
        /// </para>
        /// </summary>
        public SnippetExcerpt SnippetExcerpt
        {
            get { return this._snippetExcerpt; }
            set { this._snippetExcerpt = value; }
        }

        // Check to see if SnippetExcerpt property is set
        internal bool IsSetSnippetExcerpt()
        {
            return this._snippetExcerpt != null;
        }

        /// <summary>
        /// Gets and sets the property SourceDetails. 
        /// <para>
        /// Source information for a segment of extracted text, including its media type.
        /// </para>
        /// </summary>
        public SourceDetails SourceDetails
        {
            get { return this._sourceDetails; }
            set { this._sourceDetails = value; }
        }

        // Check to see if SourceDetails property is set
        internal bool IsSetSourceDetails()
        {
            return this._sourceDetails != null;
        }

    }
}