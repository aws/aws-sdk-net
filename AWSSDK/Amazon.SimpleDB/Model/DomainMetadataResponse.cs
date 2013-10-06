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
    /// Returns information about the domain, including when the domain was created, the number of items and
    /// attributes, and the size of attribute names and values.
    /// </summary>
    [XmlRootAttribute(Namespace = "http://sdb.amazonaws.com/doc/2009-04-15/", IsNullable = false)]
    public class DomainMetadataResponse
    {
        private DomainMetadataResult domainMetadataResultField;
        private ResponseMetadata responseMetadataField;

        /// <summary>
        /// Gets and sets the DomainMetadataResult property.
        /// Returns information about the domain, including when the domain was created, the number of items and
        /// attributes, and the size of attribute names and values.
        /// </summary>
        [XmlElementAttribute(ElementName = "DomainMetadataResult")]
        public DomainMetadataResult DomainMetadataResult
        {
            get { return this.domainMetadataResultField; }
            set { this.domainMetadataResultField = value; }
        }

        /// <summary>
        /// Sets the DomainMetadataResult property
        /// </summary>
        /// <param name="domainMetadataResult">Returns information about the domain, including when the domain was created, the number of items and
        /// attributes, and the size of attribute names and values.</param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public DomainMetadataResponse WithDomainMetadataResult(DomainMetadataResult domainMetadataResult)
        {
            this.domainMetadataResultField = domainMetadataResult;
            return this;
        }

        /// <summary>
        /// Checks if DomainMetadataResult property is set
        /// </summary>
        /// <returns>true if DomainMetadataResult property is set</returns>
        public bool IsSetDomainMetadataResult()
        {
            return this.domainMetadataResultField != null;
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
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public DomainMetadataResponse WithResponseMetadata(ResponseMetadata responseMetadata)
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
