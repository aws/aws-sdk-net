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
    /// Specifies the precise location within a source document where cited content can be
    /// found. This can include character-level positions, page numbers, or document chunks
    /// depending on the document type and indexing method.
    /// </summary>
    public partial class CitationLocation
    {
        private DocumentCharLocation _documentChar;
        private DocumentChunkLocation _documentChunk;
        private DocumentPageLocation _documentPage;

        /// <summary>
        /// Gets and sets the property DocumentChar. 
        /// <para>
        /// The character-level location within the document where the cited content is found.
        /// </para>
        /// </summary>
        public DocumentCharLocation DocumentChar
        {
            get { return this._documentChar; }
            set { this._documentChar = value; }
        }

        // Check to see if DocumentChar property is set
        internal bool IsSetDocumentChar()
        {
            return this._documentChar != null;
        }

        /// <summary>
        /// Gets and sets the property DocumentChunk. 
        /// <para>
        /// The chunk-level location within the document where the cited content is found, typically
        /// used for documents that have been segmented into logical chunks.
        /// </para>
        /// </summary>
        public DocumentChunkLocation DocumentChunk
        {
            get { return this._documentChunk; }
            set { this._documentChunk = value; }
        }

        // Check to see if DocumentChunk property is set
        internal bool IsSetDocumentChunk()
        {
            return this._documentChunk != null;
        }

        /// <summary>
        /// Gets and sets the property DocumentPage. 
        /// <para>
        /// The page-level location within the document where the cited content is found.
        /// </para>
        /// </summary>
        public DocumentPageLocation DocumentPage
        {
            get { return this._documentPage; }
            set { this._documentPage = value; }
        }

        // Check to see if DocumentPage property is set
        internal bool IsSetDocumentPage()
        {
            return this._documentPage != null;
        }

    }
}