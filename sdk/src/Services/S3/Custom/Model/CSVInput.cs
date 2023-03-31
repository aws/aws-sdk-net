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

using System.Xml;
using Amazon.S3.Model.Internal.MarshallTransformations;

namespace Amazon.S3.Model
{
    /// <summary>
    /// Describes how a CSV-formatted input object is formatted.
    /// </summary>
    public class CSVInput
    {
        /// <summary>
        /// Describes the first line of input. Valid values: None, Ignore, Use.
        /// </summary>
        public FileHeaderInfo FileHeaderInfo { get; set; }

        internal bool IsSetFileHeaderInfo()
        {
            return this.FileHeaderInfo != null;
        }

        /// <summary>
        /// <para>
        /// A single character used to indicate that a row should be ignored when the character
        /// is present at the start of that row. You can specify any character to indicate a comment line.
        /// The default character is <code>#</code>.
        /// </para>
        /// <para>
        /// Default: <code>#</code>
        /// </para>
        /// </summary>
        public string Comments { get; set; }

        internal bool IsSetComments()
        {
            return this.Comments != null;
        }

        /// <summary>
        /// Single character used for escaping the quote character inside an already escaped value.
        /// </summary>
        public string QuoteEscapeCharacter { get; set; }

        internal bool IsSetQuoteEscapeCharacter()
        {
            return this.QuoteEscapeCharacter != null;
        }

        /// <summary>
        /// Value used to separate individual records.
        /// </summary>
        public string RecordDelimiter { get; set; }

        internal bool IsSetRecordDelimiter()
        {
            return this.RecordDelimiter != null;
        }

        /// <summary>
        /// Value used to separate individual fields in a record.
        /// </summary>
        public string FieldDelimiter { get; set; }

        internal bool IsSetFieldDelimiter()
        { 
            return this.FieldDelimiter != null;
        }

        /// <summary>
        /// Value used for escaping where the field delimiter is part of the value.
        /// </summary>
        public string QuoteCharacter { get; set; }

        internal bool IsSetQuoteCharacter()
        {
            return this.QuoteCharacter != null;
        }

        private bool? _allowQuotedRecordDelimiter;

        /// <summary>
        /// Specifies that CSV field values may contain quoted record delimiters and such records should be allowed. Default value is FALSE. Setting this value to TRUE may lower performance.
        /// </summary>
        public bool AllowQuotedRecordDelimiter
        {
            get
            {
                return _allowQuotedRecordDelimiter ?? default(bool);
            }
            set
            {
                _allowQuotedRecordDelimiter = value;
            }
        }

        internal bool IsSetAllowQuotedRecordDelimiter()
        {
            return _allowQuotedRecordDelimiter != null;
        }
        
        internal void Marshall(string memberName, XmlWriter xmlWriter)
        {
            xmlWriter.WriteStartElement(memberName);
            {
                if (IsSetFileHeaderInfo())
                    xmlWriter.WriteElementString("FileHeaderInfo", S3Transforms.ToXmlStringValue(FileHeaderInfo.Value));
                if (IsSetComments())
                    xmlWriter.WriteElementString("Comments", S3Transforms.ToXmlStringValue(Comments));
                if (IsSetQuoteEscapeCharacter())
                    xmlWriter.WriteElementString("QuoteEscapeCharacter", S3Transforms.ToXmlStringValue(QuoteEscapeCharacter));
                if (IsSetRecordDelimiter())
                    xmlWriter.WriteElementString("RecordDelimiter", S3Transforms.ToXmlStringValue(RecordDelimiter));
                if (IsSetFieldDelimiter())
                    xmlWriter.WriteElementString("FieldDelimiter", S3Transforms.ToXmlStringValue(FieldDelimiter));
                if (IsSetQuoteCharacter())
                    xmlWriter.WriteElementString("QuoteCharacter", S3Transforms.ToXmlStringValue(QuoteCharacter));
                if (IsSetAllowQuotedRecordDelimiter())
                    xmlWriter.WriteElementString("AllowQuotedRecordDelimiter", S3Transforms.ToXmlStringValue(AllowQuotedRecordDelimiter));
            }
            xmlWriter.WriteEndElement();
        }
    }
}
