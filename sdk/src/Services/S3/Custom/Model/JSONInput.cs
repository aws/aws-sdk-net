// /*******************************************************************************
//  *  Copyright Amazon.com, Inc. or its affiliates. All Rights Reserved.
//  *  Licensed under the Apache License, Version 2.0 (the "License"). You may not use
//  *  this file except in compliance with the License. A copy of the License is located at
//  *
//  *  http://aws.amazon.com/apache2.0
//  *
//  *  or in the "license" file accompanying this file.
//  *  This file is distributed on an "AS IS" BASIS, WITHOUT WARRANTIES OR
//  *  CONDITIONS OF ANY KIND, either express or implied. See the License for the
//  *  specific language governing permissions and limitations under the License.
//  * *****************************************************************************
//  *    __  _    _  ___
//  *   (  )( \/\/ )/ __)
//  *   /__\ \    / \__ \
//  *  (_)(_) \/\/  (___/
//  *
//  *  AWS SDK for .NET
//  *
//  */

using System.Xml;
using Amazon.S3.Model.Internal.MarshallTransformations;

namespace Amazon.S3.Model
{
    /// <summary>
    /// Specifies JSON as object's input serialization format.
    /// </summary>
    public class JSONInput
    {
        /// <summary>
        /// The type of JSON. Valid values: Document, Lines.
        /// </summary>
        public JsonType JsonType { get; set; }

        internal bool IsSetType() => JsonType != null;

        internal void Marshall(string memberName, XmlWriter xmlWriter)
        {
            xmlWriter.WriteStartElement(memberName);

            if (IsSetType())
            {
                xmlWriter.WriteElementString("Type", S3Transforms.ToXmlStringValue(JsonType.Value));
            }

            xmlWriter.WriteEndElement();
        }
    }
}