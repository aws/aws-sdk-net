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
using System.Xml.Serialization;
using System.Text;

namespace Amazon.SQS.Model
{
    /// <summary>
    /// Information about the message sent to Amazon SQS.
    /// </summary>
    [XmlRootAttribute(Namespace = "http://queue.amazonaws.com/doc/2009-02-01/", IsNullable = false)]
    public class SendMessageResult
    {
        private string messageIdField;
        private string MD5OfMessageBodyField;

        /// <summary>
        /// Gets and sets the MessageId property.
        /// An element containing the message ID of the message sent to the queue.
        /// </summary>
        [XmlElementAttribute(ElementName = "MessageId")]
        public string MessageId
        {
            get { return this.messageIdField ; }
            set { this.messageIdField= value; }
        }

        /// <summary>
        /// Sets the MessageId property
        /// </summary>
        /// <param name="messageId">An element containing the message ID of the message sent to the queue.</param>
        /// <returns>this instance</returns>
        public SendMessageResult WithMessageId(string messageId)
        {
            this.messageIdField = messageId;
            return this;
        }

        /// <summary>
        /// Checks if MessageId property is set
        /// </summary>
        /// <returns>true if MessageId property is set</returns>
        public bool IsSetMessageId()
        {
            return  this.messageIdField != null;
        }

        /// <summary>
        /// Gets and sets the MD5OfMessageBody property.
        /// An MD5 digest of the non-URL-encoded message body string. You can use this to verify that SQS received the message
        /// correctly. SQS first URL decodes the message before creating the MD5 digest. For information about MD5, go to
        /// http://faqs.org/rfcs/rfc1321.html.
        /// </summary>
        [XmlElementAttribute(ElementName = "MD5OfMessageBody")]
        public string MD5OfMessageBody
        {
            get { return this.MD5OfMessageBodyField ; }
            set { this.MD5OfMessageBodyField= value; }
        }

        /// <summary>
        /// Sets the MD5OfMessageBody property
        /// </summary>
        /// <param name="MD5OfMessageBody">An MD5 digest of the non-URL-encoded message body string. You can use this to verify that SQS received the message
        /// correctly. SQS first URL decodes the message before creating the MD5 digest. For information about MD5, go to
        /// http://faqs.org/rfcs/rfc1321.html.</param>
        /// <returns>this instance</returns>
        public SendMessageResult WithMD5OfMessageBody(string MD5OfMessageBody)
        {
            this.MD5OfMessageBodyField = MD5OfMessageBody;
            return this;
        }

        /// <summary>
        /// Checks if MD5OfMessageBody property is set
        /// </summary>
        /// <returns>true if MD5OfMessageBody property is set</returns>
        public bool IsSetMD5OfMessageBody()
        {
            return  this.MD5OfMessageBodyField != null;
        }

    }
}
