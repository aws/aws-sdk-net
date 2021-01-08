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
 * Do not modify this file. This file is generated from the glacier-2012-06-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.Glacier.Model
{
    /// <summary>
    /// Contains information about the comma-separated value (CSV) file to select from.
    /// </summary>
    public partial class CSVInput
    {
        private string _comments;
        private string _fieldDelimiter;
        private FileHeaderInfo _fileHeaderInfo;
        private string _quoteCharacter;
        private string _quoteEscapeCharacter;
        private string _recordDelimiter;

        /// <summary>
        /// Gets and sets the property Comments. 
        /// <para>
        /// A single character used to indicate that a row should be ignored when the character
        /// is present at the start of that row.
        /// </para>
        /// </summary>
        public string Comments
        {
            get { return this._comments; }
            set { this._comments = value; }
        }

        // Check to see if Comments property is set
        internal bool IsSetComments()
        {
            return this._comments != null;
        }

        /// <summary>
        /// Gets and sets the property FieldDelimiter. 
        /// <para>
        /// A value used to separate individual fields from each other within a record.
        /// </para>
        /// </summary>
        public string FieldDelimiter
        {
            get { return this._fieldDelimiter; }
            set { this._fieldDelimiter = value; }
        }

        // Check to see if FieldDelimiter property is set
        internal bool IsSetFieldDelimiter()
        {
            return this._fieldDelimiter != null;
        }

        /// <summary>
        /// Gets and sets the property FileHeaderInfo. 
        /// <para>
        /// Describes the first line of input. Valid values are <code>None</code>, <code>Ignore</code>,
        /// and <code>Use</code>.
        /// </para>
        /// </summary>
        public FileHeaderInfo FileHeaderInfo
        {
            get { return this._fileHeaderInfo; }
            set { this._fileHeaderInfo = value; }
        }

        // Check to see if FileHeaderInfo property is set
        internal bool IsSetFileHeaderInfo()
        {
            return this._fileHeaderInfo != null;
        }

        /// <summary>
        /// Gets and sets the property QuoteCharacter. 
        /// <para>
        /// A value used as an escape character where the field delimiter is part of the value.
        /// </para>
        /// </summary>
        public string QuoteCharacter
        {
            get { return this._quoteCharacter; }
            set { this._quoteCharacter = value; }
        }

        // Check to see if QuoteCharacter property is set
        internal bool IsSetQuoteCharacter()
        {
            return this._quoteCharacter != null;
        }

        /// <summary>
        /// Gets and sets the property QuoteEscapeCharacter. 
        /// <para>
        /// A single character used for escaping the quotation-mark character inside an already
        /// escaped value.
        /// </para>
        /// </summary>
        public string QuoteEscapeCharacter
        {
            get { return this._quoteEscapeCharacter; }
            set { this._quoteEscapeCharacter = value; }
        }

        // Check to see if QuoteEscapeCharacter property is set
        internal bool IsSetQuoteEscapeCharacter()
        {
            return this._quoteEscapeCharacter != null;
        }

        /// <summary>
        /// Gets and sets the property RecordDelimiter. 
        /// <para>
        /// A value used to separate individual records from each other.
        /// </para>
        /// </summary>
        public string RecordDelimiter
        {
            get { return this._recordDelimiter; }
            set { this._recordDelimiter = value; }
        }

        // Check to see if RecordDelimiter property is set
        internal bool IsSetRecordDelimiter()
        {
            return this._recordDelimiter != null;
        }

    }
}