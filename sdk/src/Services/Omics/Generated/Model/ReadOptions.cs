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
 * Do not modify this file. This file is generated from the omics-2022-11-28.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.Omics.Model
{
    /// <summary>
    /// Read options for an annotation import job.
    /// </summary>
    public partial class ReadOptions
    {
        private string _comment;
        private string _encoding;
        private string _escape;
        private bool? _escapeQuotes;
        private bool? _header;
        private string _lineSep;
        private string _quote;
        private bool? _quoteAll;
        private string _sep;

        /// <summary>
        /// Gets and sets the property Comment. 
        /// <para>
        /// The file's comment character.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=1)]
        public string Comment
        {
            get { return this._comment; }
            set { this._comment = value; }
        }

        // Check to see if Comment property is set
        internal bool IsSetComment()
        {
            return this._comment != null;
        }

        /// <summary>
        /// Gets and sets the property Encoding. 
        /// <para>
        /// The file's encoding.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=20)]
        public string Encoding
        {
            get { return this._encoding; }
            set { this._encoding = value; }
        }

        // Check to see if Encoding property is set
        internal bool IsSetEncoding()
        {
            return this._encoding != null;
        }

        /// <summary>
        /// Gets and sets the property Escape. 
        /// <para>
        /// A character for escaping quotes in the file.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=1)]
        public string Escape
        {
            get { return this._escape; }
            set { this._escape = value; }
        }

        // Check to see if Escape property is set
        internal bool IsSetEscape()
        {
            return this._escape != null;
        }

        /// <summary>
        /// Gets and sets the property EscapeQuotes. 
        /// <para>
        /// Whether quotes need to be escaped in the file.
        /// </para>
        /// </summary>
        public bool EscapeQuotes
        {
            get { return this._escapeQuotes.GetValueOrDefault(); }
            set { this._escapeQuotes = value; }
        }

        // Check to see if EscapeQuotes property is set
        internal bool IsSetEscapeQuotes()
        {
            return this._escapeQuotes.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Header. 
        /// <para>
        /// Whether the file has a header row.
        /// </para>
        /// </summary>
        public bool Header
        {
            get { return this._header.GetValueOrDefault(); }
            set { this._header = value; }
        }

        // Check to see if Header property is set
        internal bool IsSetHeader()
        {
            return this._header.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property LineSep. 
        /// <para>
        /// A line separator for the file.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=20)]
        public string LineSep
        {
            get { return this._lineSep; }
            set { this._lineSep = value; }
        }

        // Check to see if LineSep property is set
        internal bool IsSetLineSep()
        {
            return this._lineSep != null;
        }

        /// <summary>
        /// Gets and sets the property Quote. 
        /// <para>
        /// The file's quote character.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=1)]
        public string Quote
        {
            get { return this._quote; }
            set { this._quote = value; }
        }

        // Check to see if Quote property is set
        internal bool IsSetQuote()
        {
            return this._quote != null;
        }

        /// <summary>
        /// Gets and sets the property QuoteAll. 
        /// <para>
        /// Whether all values need to be quoted, or just those that contain quotes.
        /// </para>
        /// </summary>
        public bool QuoteAll
        {
            get { return this._quoteAll.GetValueOrDefault(); }
            set { this._quoteAll = value; }
        }

        // Check to see if QuoteAll property is set
        internal bool IsSetQuoteAll()
        {
            return this._quoteAll.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Sep. 
        /// <para>
        /// The file's field separator.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=20)]
        public string Sep
        {
            get { return this._sep; }
            set { this._sep = value; }
        }

        // Check to see if Sep property is set
        internal bool IsSetSep()
        {
            return this._sep != null;
        }

    }
}