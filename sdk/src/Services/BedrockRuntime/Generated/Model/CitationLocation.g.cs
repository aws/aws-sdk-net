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
    /// Specifies the precise location within a source document where cited content can be
    /// found. This can include character-level positions, page numbers, or document chunks
    /// depending on the document type and indexing method.
    /// </summary>
    public partial class CitationLocation
    {
        /// <summary>
        /// Gets and sets the property DocumentChar. 
        /// <para>
        /// The character-level location within the document where the cited content is found.
        /// </para>
        /// </summary>
        public DocumentCharLocation DocumentChar { get; set; }

        /// <summary>
        /// Checks to see if the DocumentChar property is set.
        /// </summary>
        internal bool IsSetDocumentChar() => this.DocumentChar != null;

        /// <summary>
        /// Gets and sets the property DocumentChunk. 
        /// <para>
        /// The chunk-level location within the document where the cited content is found, typically
        /// used for documents that have been segmented into logical chunks.
        /// </para>
        /// </summary>
        public DocumentChunkLocation DocumentChunk { get; set; }

        /// <summary>
        /// Checks to see if the DocumentChunk property is set.
        /// </summary>
        internal bool IsSetDocumentChunk() => this.DocumentChunk != null;

        /// <summary>
        /// Gets and sets the property DocumentPage. 
        /// <para>
        /// The page-level location within the document where the cited content is found.
        /// </para>
        /// </summary>
        public DocumentPageLocation DocumentPage { get; set; }

        /// <summary>
        /// Checks to see if the DocumentPage property is set.
        /// </summary>
        internal bool IsSetDocumentPage() => this.DocumentPage != null;

        /// <summary>
        /// Gets and sets the property SearchResultLocation. 
        /// <para>
        /// The search result location where the cited content is found, including the search
        /// result index and block positions within the content array.
        /// </para>
        /// </summary>
        public SearchResultLocation SearchResultLocation { get; set; }

        /// <summary>
        /// Checks to see if the SearchResultLocation property is set.
        /// </summary>
        internal bool IsSetSearchResultLocation() => this.SearchResultLocation != null;

        /// <summary>
        /// Gets and sets the property Web. 
        /// <para>
        /// The web URL that was cited for this reference.
        /// </para>
        /// </summary>
        public WebLocation Web { get; set; }

        /// <summary>
        /// Checks to see if the Web property is set.
        /// </summary>
        internal bool IsSetWeb() => this.Web != null;
    }
}
