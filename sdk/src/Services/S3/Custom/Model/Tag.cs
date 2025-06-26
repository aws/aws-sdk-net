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
using System.Collections.Generic;
using Amazon.S3.Model.Internal.MarshallTransformations;

namespace Amazon.S3.Model
{
    /// <summary>
    /// Tag is a key-value pair of metadata associated with an S3Object
    /// </summary>
    public partial class Tag
    {
        internal void Marshall(string memberName, XmlWriter xmlWriter)
        {
            xmlWriter.WriteStartElement(memberName);
            {
                if (IsSetKey())
                {
                    xmlWriter.WriteElementString("Key", S3Transforms.ToXmlStringValue(_key));
                }
                if (IsSetValue())
                {
                    xmlWriter.WriteElementString("Value", S3Transforms.ToXmlStringValue(_value));
                }
            }
            xmlWriter.WriteEndElement();
        }
    }
}
