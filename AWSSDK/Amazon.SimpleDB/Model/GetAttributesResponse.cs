/*******************************************************************************
 * Copyright 2008-2013 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
 *  API Version: 2009-04-15
 */

using System;
using System.Collections.Generic;
using System.IO;
using System.Xml.Serialization;
using System.Text;

namespace Amazon.SimpleDB.Model
{
    /// <summary>
    /// Returns all of the attributes associated with the item. Optionally, the attributes returned can
    /// be limited to one or more specified attribute name parameters. If the item does not exist on the
    /// replica that was accessed for this operation, an empty set is returned. The system does not return
    /// an error as it cannot guarantee the item does not exist on other replicas.
    /// </summary>
    [XmlRootAttribute(Namespace = "http://sdb.amazonaws.com/doc/2009-04-15/", IsNullable = false)]
    public class GetAttributesResponse
    {
        private GetAttributesResult getAttributesResultField;
        private ResponseMetadata responseMetadataField;

        /// <summary>
        /// Gets and sets the GetAttributesResult property.
        /// Returns all of the attributes associated with the item. Optionally, the attributes returned can
        /// be limited to one or more specified attribute name parameters. If the item does not exist on the
        /// replica that was accessed for this operation, an empty set is returned. The system does not return
        /// an error as it cannot guarantee the item does not exist on other replicas.
        /// </summary>
        [XmlElementAttribute(ElementName = "GetAttributesResult")]
        public GetAttributesResult GetAttributesResult
        {
            get { return this.getAttributesResultField; }
            set { this.getAttributesResultField = value; }
        }

        /// <summary>
        /// Sets the GetAttributesResult property
        /// </summary>
        /// <param name="getAttributesResult">Returns all of the attributes associated with the item. Optionally, the attributes returned can
        /// be limited to one or more specified attribute name parameters. If the item does not exist on the
        /// replica that was accessed for this operation, an empty set is returned. The system does not return
        /// an error as it cannot guarantee the item does not exist on other replicas.</param>
        /// <returns>this instance</returns>
        public GetAttributesResponse WithGetAttributesResult(GetAttributesResult getAttributesResult)
        {
            this.getAttributesResultField = getAttributesResult;
            return this;
        }

        /// <summary>
        /// Checks if GetAttributesResult property is set
        /// </summary>
        /// <returns>true if GetAttributesResult property is set</returns>
        public bool IsSetGetAttributesResult()
        {
            return this.getAttributesResultField != null;
        }

        /// <summary>
        /// Gets and sets the ResponseMetadata property.
        /// Information about the request provided by Amazon SimpleDB.
        /// </summary>
        [XmlElementAttribute(ElementName = "ResponseMetadata")]
        public ResponseMetadata ResponseMetadata
        {
            get { return this.responseMetadataField; }
            set { this.responseMetadataField = value; }
        }

        /// <summary>
        /// Sets the ResponseMetadata property
        /// </summary>
        /// <param name="responseMetadata">Information about the request provided by Amazon SimpleDB.</param>
        /// <returns>this instance</returns>
        public GetAttributesResponse WithResponseMetadata(ResponseMetadata responseMetadata)
        {
            this.responseMetadataField = responseMetadata;
            return this;
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
        /// XML Representation for this object
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
    }
}
