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

namespace Amazon.QBusiness.Model
{
    /// <summary>
    /// Provides information about a text extract in a chat response that can be attributed
    /// to a source document.
    /// </summary>
    public partial class TextSegment
    {
        /// <summary>
        /// Gets and sets the property BeginOffset. 
        /// <para>
        /// The zero-based location in the response string where the source attribution starts.
        /// </para>
        /// </summary>
        public int? BeginOffset { get; set; }

        /// <summary>
        /// Checks to see if the BeginOffset property is set.
        /// </summary>
        internal bool IsSetBeginOffset() => this.BeginOffset.HasValue;

        /// <summary>
        /// Gets and sets the property EndOffset. 
        /// <para>
        /// The zero-based location in the response string where the source attribution ends.
        /// </para>
        /// </summary>
        public int? EndOffset { get; set; }

        /// <summary>
        /// Checks to see if the EndOffset property is set.
        /// </summary>
        internal bool IsSetEndOffset() => this.EndOffset.HasValue;

        /// <summary>
        /// Gets and sets the property MediaId. 
        /// <para>
        /// The identifier of the media object associated with the text segment in the source
        /// attribution.
        /// </para>
        /// </summary>
        [Obsolete("Deprecated in favor of using mediaId within the respective sourceDetails field.")]
        [AWSProperty(Min = 36, Max = 36)]
        public string MediaId { get; set; }

        /// <summary>
        /// Checks to see if the MediaId property is set.
        /// </summary>
        internal bool IsSetMediaId() => this.MediaId != null;

        /// <summary>
        /// Gets and sets the property MediaMimeType. 
        /// <para>
        /// The MIME type (image/png) of the media object associated with the text segment in
        /// the source attribution.
        /// </para>
        /// </summary>
        [Obsolete("Deprecated in favor of using mediaMimeType within the respective sourceDetails field.")]
        [AWSProperty(Min = 1, Max = 2048)]
        public string MediaMimeType { get; set; }

        /// <summary>
        /// Checks to see if the MediaMimeType property is set.
        /// </summary>
        internal bool IsSetMediaMimeType() => this.MediaMimeType != null;

        /// <summary>
        /// Gets and sets the property SnippetExcerpt. 
        /// <para>
        /// The relevant text excerpt from a source that was used to generate a citation text
        /// segment in an Amazon Q Business chat response.
        /// </para>
        /// </summary>
        public SnippetExcerpt SnippetExcerpt { get; set; }

        /// <summary>
        /// Checks to see if the SnippetExcerpt property is set.
        /// </summary>
        internal bool IsSetSnippetExcerpt() => this.SnippetExcerpt != null;

        /// <summary>
        /// Gets and sets the property SourceDetails. 
        /// <para>
        /// Source information for a segment of extracted text, including its media type.
        /// </para>
        /// </summary>
        public SourceDetails SourceDetails { get; set; }

        /// <summary>
        /// Checks to see if the SourceDetails property is set.
        /// </summary>
        internal bool IsSetSourceDetails() => this.SourceDetails != null;
    }
}
