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

namespace Amazon.S3.Model
{
    /// <summary>
    /// Describes how results of the Select job are serialized.
    /// </summary>
    public class OutputSerialization
    {
        /// <summary>
        /// Describes the serialization of CSV-encoded Select results.
        /// </summary>
        public CSVOutput CSV { get; set; }
        /// <summary>
        /// Specifies JSON as request's output serialization format.
        /// </summary>
        public JSONOutput JSON { get; set; }

        internal bool IsSetCSV() => CSV != null;

        internal bool IsSetJSON() => JSON != null;

        internal void Marshall(string propertyName, XmlWriter xmlWriter)
        {
            xmlWriter.WriteStartElement(propertyName);

            if (IsSetCSV())
            {
                CSV.Marshall("CSV", xmlWriter);
            }
            if(IsSetJSON())
            {
                JSON.Marshall("JSON", xmlWriter);
            }

            xmlWriter.WriteEndElement();
        }
    }
}
