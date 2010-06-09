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
 *  API Version: 2009-02-01
 */

using System;
using System.Collections.Generic;
using System.IO;
using System.Xml.Serialization;
using System.Text;

namespace Amazon.SQS.Model
{
    /// <summary>
    /// Returns information about the message, including an MD5 of the message body, message ID, and request metadata.
    /// </summary>
    [XmlRootAttribute(Namespace = "http://queue.amazonaws.com/doc/2009-02-01/", IsNullable = false)]
    public class SendMessageResponse
    {
        private SendMessageResult sendMessageResultField;
        private ResponseMetadata responseMetadataField;

        /// <summary>
        /// Gets and sets the SendMessageResult property.
        /// Information about the message sent to Amazon SQS.
        /// </summary>
        [XmlElementAttribute(ElementName = "SendMessageResult")]
        public SendMessageResult SendMessageResult
        {
            get { return this.sendMessageResultField ; }
            set { this.sendMessageResultField = value; }
        }

        /// <summary>
        /// Sets the SendMessageResult property
        /// </summary>
        /// <param name="sendMessageResult">Information about the message sent to Amazon SQS.</param>
        /// <returns>this instance</returns>
        public SendMessageResponse WithSendMessageResult(SendMessageResult sendMessageResult)
        {
            this.sendMessageResultField = sendMessageResult;
            return this;
        }

        /// <summary>
        /// Checks if SendMessageResult property is set
        /// </summary>
        /// <returns>true if SendMessageResult property is set</returns>
        public bool IsSetSendMessageResult()
        {
            return this.sendMessageResultField != null;
        }

        /// <summary>
        /// Gets and sets the ResponseMetadata property.
        /// Information about the request provided by Amazon SQS.
        /// </summary>
        [XmlElementAttribute(ElementName = "ResponseMetadata")]
        public ResponseMetadata ResponseMetadata
        {
            get { return this.responseMetadataField ; }
            set { this.responseMetadataField = value; }
        }

        /// <summary>
        /// Sets the ResponseMetadata property
        /// </summary>
        /// <param name="responseMetadata">Information about the request provided by Amazon SQS.</param>
        /// <returns>this instance</returns>
        public SendMessageResponse WithResponseMetadata(ResponseMetadata responseMetadata)
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
