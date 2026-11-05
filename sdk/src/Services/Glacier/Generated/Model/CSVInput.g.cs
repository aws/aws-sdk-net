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

namespace Amazon.Glacier.Model
{
    /// <summary>
    /// Contains information about the comma-separated value (CSV) file to select from.
    /// </summary>
    public partial class CSVInput
    {
        /// <summary>
        /// Gets and sets the property Comments. 
        /// <para>
        /// A single character used to indicate that a row should be ignored when the character
        /// is present at the start of that row.
        /// </para>
        /// </summary>
        public string Comments { get; set; }

        /// <summary>
        /// Checks to see if the Comments property is set.
        /// </summary>
        internal bool IsSetComments() => this.Comments != null;

        /// <summary>
        /// Gets and sets the property FieldDelimiter. 
        /// <para>
        /// A value used to separate individual fields from each other within a record.
        /// </para>
        /// </summary>
        public string FieldDelimiter { get; set; }

        /// <summary>
        /// Checks to see if the FieldDelimiter property is set.
        /// </summary>
        internal bool IsSetFieldDelimiter() => this.FieldDelimiter != null;

        /// <summary>
        /// Gets and sets the property FileHeaderInfo. 
        /// <para>
        /// Describes the first line of input. Valid values are <c>None</c>, <c>Ignore</c>, and
        /// <c>Use</c>.
        /// </para>
        /// </summary>
        public FileHeaderInfo FileHeaderInfo { get; set; }

        /// <summary>
        /// Checks to see if the FileHeaderInfo property is set.
        /// </summary>
        internal bool IsSetFileHeaderInfo() => this.FileHeaderInfo != null;

        /// <summary>
        /// Gets and sets the property QuoteCharacter. 
        /// <para>
        /// A value used as an escape character where the field delimiter is part of the value.
        /// </para>
        /// </summary>
        public string QuoteCharacter { get; set; }

        /// <summary>
        /// Checks to see if the QuoteCharacter property is set.
        /// </summary>
        internal bool IsSetQuoteCharacter() => this.QuoteCharacter != null;

        /// <summary>
        /// Gets and sets the property QuoteEscapeCharacter. 
        /// <para>
        /// A single character used for escaping the quotation-mark character inside an already
        /// escaped value.
        /// </para>
        /// </summary>
        public string QuoteEscapeCharacter { get; set; }

        /// <summary>
        /// Checks to see if the QuoteEscapeCharacter property is set.
        /// </summary>
        internal bool IsSetQuoteEscapeCharacter() => this.QuoteEscapeCharacter != null;

        /// <summary>
        /// Gets and sets the property RecordDelimiter. 
        /// <para>
        /// A value used to separate individual records from each other.
        /// </para>
        /// </summary>
        public string RecordDelimiter { get; set; }

        /// <summary>
        /// Checks to see if the RecordDelimiter property is set.
        /// </summary>
        internal bool IsSetRecordDelimiter() => this.RecordDelimiter != null;
    }
}
