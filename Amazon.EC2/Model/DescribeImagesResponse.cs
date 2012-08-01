/*******************************************************************************
 * Copyright 2008-2012 Amazon.com, Inc. or its affiliates. All Rights Reserved.
 * Licensed under the Apache License, Version 2.0 (the "License"). You may not use
 * this file except in compliance with the License. A copy of the License is located at
 *
 * http://aws.amazon.com/apache2.0
 *
 * or in the "license" file accompanying this file. This file is distributed on
 * an "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express
 * or implied. See the License for the specific language governing permissions and
 * limitations under the License.
 * *****************************************************************************
 *    __  _    _  ___
 *   (  )( \/\/ )/ __)
 *   /__\ \    / \__ \
 *  (_)(_) \/\/  (___/
 *
 *  AWS SDK for .NET
 */

using System;
using System.Collections.Generic;
using System.IO;
using System.Xml.Serialization;
using System.Text;

namespace Amazon.EC2.Model
{
    /// <summary>
    /// Describe Images Response
    /// </summary>
    [XmlRootAttribute(IsNullable = false)]
    public class DescribeImagesResponse
    {    
        private ResponseMetadata responseMetadataField;
        private DescribeImagesResult describeImagesResultField;

        /// <summary>
        /// Gets and sets the ResponseMetadata property.
        /// Response Metadata
        /// </summary>
        [XmlElementAttribute(ElementName = "ResponseMetadata")]
        public ResponseMetadata ResponseMetadata
        {
            get { return this.responseMetadataField; }
            set { this.responseMetadataField = value; }
        }

        /// <summary>
        /// Checks if ResponseMetadata property is set
        /// </summary>
        /// <returns>true if ResponseMetadata property is set</returns>
        public bool IsSetResponseMetadata()
        {
            return this.responseMetadataField != null;
        }

        /// <summary>
        /// Gets and sets the DescribeImagesResult property.
        /// Describe Images Result
        /// </summary>
        [XmlElementAttribute(ElementName = "DescribeImagesResult")]
        public DescribeImagesResult DescribeImagesResult
        {
            get { return this.describeImagesResultField; }
            set { this.describeImagesResultField = value; }
        }

        /// <summary>
        /// Checks if DescribeImagesResult property is set
        /// </summary>
        /// <returns>true if DescribeImagesResult property is set</returns>
        public bool IsSetDescribeImagesResult()
        {
            return this.describeImagesResultField != null;
        }

        /// <summary>
        /// XML Representation of this object
        /// </summary>
        /// <returns>XML String</returns>
        public string ToXML()
        {
            StringBuilder xml = new StringBuilder(1024);
            System.Xml.Serialization.XmlSerializer serializer = new System.Xml.Serialization.XmlSerializer(this.GetType());
            using (StringWriter sw = new StringWriter(xml))
            {
                serializer.Serialize(sw, this);
            }
            return xml.ToString();
        }

        /// <summary>
        /// String Representation of this object. Overrides Object.ToString()
        /// </summary>
        /// <returns>This object as a string</returns>
        public override string ToString()
        {
            return this.ToXML();
        }
        
        // handles elements tagged as Obsolete which are otherwise ignored by the Xml Serializer
        public static void serializer_UnknownElement(object sender, XmlElementEventArgs e)
        {
            if (e.Element.Name != "ProductCodeId")
                return;

            var target = e.ObjectBeingDeserialized as Image;
            if (target == null)
                return;

#pragma warning disable 0618
            target.ProductCode.Add(e.Element.InnerText);
#pragma warning restore 0618
        }
    }
}
