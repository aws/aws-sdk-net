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
 * Do not modify this file. This file is generated from the s3-2006-03-01.normal.json service model.
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
namespace Amazon.S3.Model
{
    /// <summary>
    /// Describes how an uncompressed comma-separated values (CSV)-formatted input object
    /// is formatted.
    /// </summary>
    public partial class CSVInput
    {
        private bool? _allowQuotedRecordDelimiter;
        private string _comments;
        private string _fieldDelimiter;
        private FileHeaderInfo _fileHeaderInfo;
        private string _quoteCharacter;
        private string _quoteEscapeCharacter;
        private string _recordDelimiter;

        /// <summary>
        /// Gets and sets the property AllowQuotedRecordDelimiter. 
        /// <para>
        /// Specifies that CSV field values may contain quoted record delimiters and such records
        /// should be allowed. Default value is FALSE. Setting this value to TRUE may lower performance.
        /// </para>
        /// </summary>
        public bool? AllowQuotedRecordDelimiter
        {
            get { return this._allowQuotedRecordDelimiter; }
            set { this._allowQuotedRecordDelimiter = value; }
        }

        // Check to see if AllowQuotedRecordDelimiter property is set
        internal bool IsSetAllowQuotedRecordDelimiter()
        {
            return this._allowQuotedRecordDelimiter.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Comments. 
        /// <para>
        /// A single character used to indicate that a row should be ignored when the character
        /// is present at the start of that row. You can specify any character to indicate a comment
        /// line. The default character is <c>#</c>.
        /// </para>
        ///  
        /// <para>
        /// Default: <c>#</c> 
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
        /// A single character used to separate individual fields in a record. You can specify
        /// an arbitrary delimiter.
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
        /// Describes the first line of input. Valid values are:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>NONE</c>: First line is not a header.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>IGNORE</c>: First line is a header, but you can't use the header values to indicate
        /// the column in an expression. You can use column position (such as _1, _2, …) to indicate
        /// the column (<c>SELECT s._1 FROM OBJECT s</c>).
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>Use</c>: First line is a header, and you can use the header value to identify
        /// a column in an expression (<c>SELECT "name" FROM OBJECT</c>). 
        /// </para>
        ///  </li> </ul>
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
        /// A single character used for escaping when the field delimiter is part of the value.
        /// For example, if the value is <c>a, b</c>, Amazon S3 wraps this field value in quotation
        /// marks, as follows: <c>" a , b "</c>.
        /// </para>
        ///  
        /// <para>
        /// Type: String
        /// </para>
        ///  
        /// <para>
        /// Default: <c>"</c> 
        /// </para>
        ///  
        /// <para>
        /// Ancestors: <c>CSV</c> 
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
        /// A single character used for escaping the quotation mark character inside an already
        /// escaped value. For example, the value <c>""" a , b """</c> is parsed as <c>" a , b
        /// "</c>.
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
        /// A single character used to separate individual records in the input. Instead of the
        /// default value, you can specify an arbitrary delimiter.
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