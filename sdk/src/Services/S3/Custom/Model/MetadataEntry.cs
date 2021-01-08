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
    /// A metadata key-value pair to store with an object.
    /// </summary>
    public class MetadataEntry
    {
        /// <summary>
        /// Key of metadata key-value pair
        /// </summary>
        public string Name { get; set; }

        internal bool IsSetName()
        {
            return this.Name != null;
        }

        /// <summary>
        /// Value of metadata key-value pair
        /// </summary>
        public string Value { get; set; }

        internal bool IsSetValue()
        {
            return this.Value != null;
        }

        internal void Marshall(string memberName, XmlWriter xmlWriter)
        {
            xmlWriter.WriteStartElement(memberName);
            {
                if (IsSetName())
                    xmlWriter.WriteElementString("Name", S3Transforms.ToXmlStringValue(Name));
                if (IsSetValue())
                    xmlWriter.WriteElementString("Value", S3Transforms.ToXmlStringValue(Value));
            }
            xmlWriter.WriteEndElement();
        }
    }
}
