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
 *  API Version: 2012-11-05
 */

using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;

namespace Amazon.SQS.Model
{
    /// <summary>
    /// Encloses a message ID for successfully enqueued message of a <c>SendMessageBatchRequest</c>.
    /// </summary>
    [XmlRootAttribute(Namespace = "http://queue.amazonaws.com/doc/2012-11-05/", IsNullable = false)]
    public class SendMessageBatchResultEntry
    {
        private string idField;
        private string messageIdField;
        private string md5OfMessageBody;

        /// <summary>
        /// User-supplied Id of the sent message.
        /// </summary>
        public string Id
        {
            get { return this.idField; }
            set { this.idField = value; }
        }

        /// <summary>
        /// Checks if Id property is set
        /// </summary>
        /// <returns>true if Id property is set</returns>
        public bool IsSetId()
        {
            return this.idField != null;
        }

        /// <summary>
        /// An identifier for the message.
        /// </summary>
        public string MessageId
        {
            get { return this.messageIdField; }
            set { this.messageIdField = value; }
        }

        /// <summary>
        /// Checks if MessageId property is set
        /// </summary>
        /// <returns>true if MessageId property is set</returns>
        public bool IsSetMessageId()
        {
            return this.messageIdField != null;
        }

        /// <summary>
        /// An MD5 digest of the non-URL-encoded message body string.
        /// </summary>
        /// <remarks>
        /// This can be used to verify that SQS received the message correctly.
        /// SQS first URL decodes the message before creating the MD5 digest.
        /// For information about MD5, go to
        /// <a href="http://faqs.org/rfcs/rfc1321.html">http://faqs.org/rfcs/rfc1321.html</a>.
        /// </remarks>
        public string MD5OfMessageBody
        {
            get { return this.md5OfMessageBody; }
            set { this.md5OfMessageBody = value; }
        }

        /// <summary>
        /// Checks if MD5OfMessageBody property is set
        /// </summary>
        /// <returns>true if MD5OfMessageBody property is set</returns>
        public bool IsSetMD5OfMessageBody()
        {
            return this.md5OfMessageBody != null;
        }
    }
}
