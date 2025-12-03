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
    public partial class CSVOutput
    {
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
