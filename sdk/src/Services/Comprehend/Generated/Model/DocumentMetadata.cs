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
 * Do not modify this file. This file is generated from the comprehend-2017-11-27.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.Comprehend.Model
{
    /// <summary>
    /// Information about the document, discovered during text extraction.
    /// </summary>
    public partial class DocumentMetadata
    {
        private List<ExtractedCharactersListItem> _extractedCharacters = new List<ExtractedCharactersListItem>();
        private int? _pages;

        /// <summary>
        /// Gets and sets the property ExtractedCharacters. 
        /// <para>
        /// List of pages in the document, with the number of characters extracted from each page.
        /// </para>
        /// </summary>
        public List<ExtractedCharactersListItem> ExtractedCharacters
        {
            get { return this._extractedCharacters; }
            set { this._extractedCharacters = value; }
        }

        // Check to see if ExtractedCharacters property is set
        internal bool IsSetExtractedCharacters()
        {
            return this._extractedCharacters != null && this._extractedCharacters.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property Pages. 
        /// <para>
        /// Number of pages in the document.
        /// </para>
        /// </summary>
        public int Pages
        {
            get { return this._pages.GetValueOrDefault(); }
            set { this._pages = value; }
        }

        // Check to see if Pages property is set
        internal bool IsSetPages()
        {
            return this._pages.HasValue; 
        }

    }
}