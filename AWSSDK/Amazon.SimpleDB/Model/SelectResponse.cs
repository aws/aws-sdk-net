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
    /// The Select operation returns a set of Attributes for ItemNames that match the select expression.
    /// The total size of the response cannot exceed 1 MB in total size. Amazon SimpleDB automatically adjusts the number of items
    /// returned per page to enforce this limit. For example, even if you ask to retrieve 2500 items, but each individual
    /// item is 10 kB in size, the system returns 100 items and an appropriate next token so you can get the next page of results.
    /// Operations that run longer than 5 seconds return a time-out error response or a partial or empty result set. Partial
    /// and empty result sets contains a next token which allow you to continue the operation from where it left off.
    /// Responses larger than one megabyte return a partial result set.
    /// </summary>
    [XmlRootAttribute(Namespace = "http://sdb.amazonaws.com/doc/2009-04-15/", IsNullable = false)]
    public class SelectResponse
    {
        private SelectResult selectResultField;
        private ResponseMetadata responseMetadataField;

        /// <summary>
        /// Gets and sets the SelectResult property.
        /// The Select operation returns a set of Attributes for ItemNames that match the select expression.
        /// The total size of the response cannot exceed 1 MB in total size. Amazon SimpleDB automatically adjusts the number of items
        /// returned per page to enforce this limit. For example, even if you ask to retrieve 2500 items, but each individual
        /// item is 10 kB in size, the system returns 100 items and an appropriate next token so you can get the next page of results.
        /// Operations that run longer than 5 seconds return a time-out error response or a partial or empty result set. Partial
        /// and empty result sets contains a next token which allow you to continue the operation from where it left off.
        /// Responses larger than one megabyte return a partial result set.
        /// </summary>
        [XmlElementAttribute(ElementName = "SelectResult")]
        public SelectResult SelectResult
        {
            get { return this.selectResultField; }
            set { this.selectResultField = value; }
        }

        /// <summary>
        /// Sets the SelectResult property
        /// </summary>
        /// <param name="selectResult">The Select operation returns a set of Attributes for ItemNames that match the select expression.
        /// The total size of the response cannot exceed 1 MB in total size. Amazon SimpleDB automatically adjusts the number of items
        /// returned per page to enforce this limit. For example, even if you ask to retrieve 2500 items, but each individual
        /// item is 10 kB in size, the system returns 100 items and an appropriate next token so you can get the next page of results.
        /// Operations that run longer than 5 seconds return a time-out error response or a partial or empty result set. Partial
        /// and empty result sets contains a next token which allow you to continue the operation from where it left off.
        /// Responses larger than one megabyte return a partial result set.</param>
        /// <returns>this instance</returns>
        public SelectResponse WithSelectResult(SelectResult selectResult)
        {
            this.selectResultField = selectResult;
            return this;
        }

        /// <summary>
        /// Checks if SelectResult property is set
        /// </summary>
        /// <returns>true if SelectResult property is set</returns>
        public bool IsSetSelectResult()
        {
            return this.selectResultField != null;
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
        public SelectResponse WithResponseMetadata(ResponseMetadata responseMetadata)
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
