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

using System;
using System.Xml;
using Amazon.S3.Model.Internal.MarshallTransformations;

namespace Amazon.S3.Model
{
    /// <summary>
    /// Describes the serialization format of the object.
    /// </summary>
    public partial class InputSerialization
    {
        internal void Marshall(string memberName, XmlWriter xmlWriter)
        {
            xmlWriter.WriteStartElement(memberName);

            if (IsSetCompressionType())
            {
                xmlWriter.WriteElementString("CompressionType", S3Transforms.ToXmlStringValue(CompressionType.Value));
            }

            if (IsSetCSV())
            {
                CSV.Marshall("CSV", xmlWriter);
            }

            if (IsSetJSON())
            {
                JSON.Marshall("JSON", xmlWriter);
            }

            if (IsSetParquet())
            {
                Parquet.Marshall("Parquet", xmlWriter);
            }

            xmlWriter.WriteEndElement();
        }
    }
}