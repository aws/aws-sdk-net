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
 *  API Version: 2011-10-01
 */

using System;
using System.Collections.Generic;
using System.IO;
using System.Xml.Serialization;
using System.Text;

namespace Amazon.SQS.Model
{
    /// <summary>
    /// Returns a list of messages and metadata about the request.
    /// </summary>
    [XmlRootAttribute(Namespace = "http://queue.amazonaws.com/doc/2011-10-01/", IsNullable = false)]
    public class ReceiveMessageResponse
    {    
        private ReceiveMessageResult receiveMessageResultField;
        private ResponseMetadata responseMetadataField;

        /// <summary>
        /// Gets and sets the ReceiveMessageResult property.
        /// A list of messages associated with the ReceiveMessageRequest.
        /// </summary>
        [XmlElementAttribute(ElementName = "ReceiveMessageResult")]
        public ReceiveMessageResult ReceiveMessageResult
        {
            get { return this.receiveMessageResultField; }
            set { this.receiveMessageResultField = value; }
        }

        /// <summary>
        /// Checks if ReceiveMessageResult property is set
        /// </summary>
        /// <returns>true if ReceiveMessageResult property is set</returns>
        public bool IsSetReceiveMessageResult()
        {
            return this.receiveMessageResultField != null;
        }

        /// <summary>
        /// Gets and sets the ResponseMetadata property.
        /// Information about the request provided by Amazon SQS.
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
    }
}
