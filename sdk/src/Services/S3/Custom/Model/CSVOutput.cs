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
    /// Describes how CSV-formatted results are formatted.
    /// </summary>
    public class CSVOutput
    {
        /// <summary>
        /// Indicates whether or not all output fields should be quoted.
        /// </summary>
        public QuoteFields QuoteFields { get; set; }

        internal bool IsSetQuoteFields()
        {
            return this.QuoteFields != null;
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

        internal void Marshall(string memberName, XmlWriter xmlWriter)
        {
            xmlWriter.WriteStartElement(memberName);
            {
                if (IsSetQuoteFields())
                    xmlWriter.WriteElementString("QuoteFields", S3Transforms.ToXmlStringValue(QuoteFields.Value));
                if (IsSetQuoteEscapeCharacter())
                    xmlWriter.WriteElementString("QuoteEscapeCharacter", S3Transforms.ToXmlStringValue(QuoteEscapeCharacter));
                if (IsSetRecordDelimiter())
                    xmlWriter.WriteElementString("RecordDelimiter", S3Transforms.ToXmlStringValue(RecordDelimiter));
                if (IsSetFieldDelimiter())
                    xmlWriter.WriteElementString("FieldDelimiter", S3Transforms.ToXmlStringValue(FieldDelimiter));
                if (IsSetQuoteCharacter())
                    xmlWriter.WriteElementString("QuoteCharacter", S3Transforms.ToXmlStringValue(QuoteCharacter));
            }
            xmlWriter.WriteEndElement();
        }
    }
}
