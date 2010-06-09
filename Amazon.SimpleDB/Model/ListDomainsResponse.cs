/*******************************************************************************
 * Copyright 2008-2010 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
    /// Lists all domains associated with the account. It returns domain names up to the limit set by MaxNumberOfDomains.
    /// A NextToken is returned if there are more than MaxNumberOfDomains domains. Calling ListDomains successive times
    /// with the NextToken returns up to MaxNumberOfDomains more domain names each time.
    /// </summary>
    [XmlRootAttribute(Namespace = "http://sdb.amazonaws.com/doc/2009-04-15/", IsNullable = false)]
    public class ListDomainsResponse
    {
        private ListDomainsResult listDomainsResultField;
        private ResponseMetadata responseMetadataField;

        /// <summary>
        /// Gets and sets the ListDomainsResult property.
        /// Lists all domains associated with the account. It returns domain names up to the limit set by MaxNumberOfDomains.
        /// A NextToken is returned if there are more than MaxNumberOfDomains domains. Calling ListDomains successive times
        /// with the NextToken returns up to MaxNumberOfDomains more domain names each time.
        /// </summary>
        [XmlElementAttribute(ElementName = "ListDomainsResult")]
        public ListDomainsResult ListDomainsResult
        {
            get { return this.listDomainsResultField; }
            set { this.listDomainsResultField = value; }
        }

        /// <summary>
        /// Sets the ListDomainsResult property
        /// </summary>
        /// <param name="listDomainsResult">Lists all domains associated with the account. It returns domain names up to the limit set by MaxNumberOfDomains.
        /// A NextToken is returned if there are more than MaxNumberOfDomains domains. Calling ListDomains successive times
        /// with the NextToken returns up to MaxNumberOfDomains more domain names each time.</param>
        /// <returns>this instance</returns>
        public ListDomainsResponse WithListDomainsResult(ListDomainsResult listDomainsResult)
        {
            this.listDomainsResultField = listDomainsResult;
            return this;
        }

        /// <summary>
        /// Checks if ListDomainsResult property is set
        /// </summary>
        /// <returns>true if ListDomainsResult property is set</returns>
        public bool IsSetListDomainsResult()
        {
            return this.listDomainsResultField != null;
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
        public ListDomainsResponse WithResponseMetadata(ResponseMetadata responseMetadata)
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
