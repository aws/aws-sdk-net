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
 *  API Version: 2010-05-02
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Serialization;
using System.IO;

namespace Amazon.SimpleNotificationService.Model
{
    /// <summary>
    /// Encapsulates the metadata and result of the GetEndpointAttributesRequest action.
    /// </summary>
    [XmlRootAttribute(Namespace = "http://sns.amazonaws.com/doc/2010-03-31/", IsNullable = false)]
    public class GetEndpointAttributesResponse
    {
        
        private GetEndpointAttributesResult result;

        
        private ResponseMetadata responseMetadata;

        /// <summary>
        /// Gets or sets the get endpoint attributes result.
        /// </summary>
        /// <value>
        /// The result of the GetEndpointAttributes request.
        /// </value>
        [XmlElement(ElementName = "GetEndpointAttributesResult")]
        public GetEndpointAttributesResult GetEndpointAttributesResult
        {
            get { return this.result; }
            set { this.result = value; }
        }

        /// <summary>
        /// Determines whether the <see cref="GetEndpointAttributesResult"/> property is set.
        /// </summary>
        /// <returns>
        ///   <c>true</c> if the result field of the request is set; otherwise, <c>false</c>.
        /// </returns>
        public bool IsSetGetEndpointAttributesResult()
        {
            return null != this.result;
        }

        /// <summary>
        /// Gets and sets the ResponseMetadata property.
        /// The Metadata used to identify the service request uniquely.
        /// </summary>
        [XmlElementAttribute(ElementName = "ResponseMetadata")]
        public ResponseMetadata ResponseMetadata
        {
            get { return this.responseMetadata; }
            set { this.responseMetadata = value; }
        }

        /// <summary>
        /// Checks if ResponseMetadata property is set
        /// </summary>
        /// <returns>true if ResponseMetadata property is set</returns>
        public bool IsSetResponseMetadata()
        {
            return this.responseMetadata != null;
        }

        /// <summary>
        /// XML Representation of this object
        /// </summary>
        /// <returns>XML String</returns>
        public string ToXML()
        {
            StringBuilder xml = new StringBuilder(1024);
            XmlSerializer serializer = new XmlSerializer(this.GetType());
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
    }
}
