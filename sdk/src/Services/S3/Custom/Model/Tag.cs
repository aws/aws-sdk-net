/*
 * Copyright 2010-2018 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
    public class Tag
    {
        private string key;
        private string value;

        /// <summary>
        /// Name of the tag.
        /// </summary>
        public string Key
        {
            get { return this.key; }
            set { this.key = value; }
        }

        // Check to see if Key property is set
        internal bool IsSetKey()
        {
            return this.key != null;
        }

        /// <summary>
        /// Value of the tag.
        /// </summary>
        public string Value
        {
            get { return this.value; }
            set { this.value = value; }
        }

        // Check to see if Value property is set
        internal bool IsSetValue()
        {
            return this.value != null;
        }

        internal void Marshall(string memberName, XmlWriter xmlWriter)
        {
            xmlWriter.WriteStartElement(memberName);
            {
                if (IsSetKey())
                {
                    xmlWriter.WriteElementString("Key", S3Transforms.ToXmlStringValue(key));
                }
                if (IsSetValue())
                {
                    xmlWriter.WriteElementString("Value", S3Transforms.ToXmlStringValue(value));
                }
            }
            xmlWriter.WriteEndElement();
        }
    }

    /// <summary>
    /// Structure that contains list of Tags
    /// </summary>
    public class Tagging
    {
        private List<Tag> tagSet = new List<Tag>();

        /// <summary>
        /// TagSet
        /// </summary>
        public List<Tag> TagSet
        {
            get { return this.tagSet; }
            set { this.tagSet = value; }
        }

        internal void Marshall(string memberName, XmlWriter xmlWriter)
        {
            xmlWriter.WriteStartElement(memberName);
            {
                xmlWriter.WriteStartElement("TagSet");
                {
                    foreach (var tag in tagSet)
                    {
                        tag.Marshall("Tag", xmlWriter);
                    }
                }
                xmlWriter.WriteEndElement();
            }
            xmlWriter.WriteEndElement();
        }
    }
}
