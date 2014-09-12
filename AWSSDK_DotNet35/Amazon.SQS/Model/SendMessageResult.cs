/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
 * 
 * Licensed under the Apache License, Version 2.0 (the "License").
 * You may not use this file except in compliance with the License.
 * A copy of the License is located at
 * 
 *  http://aws.amazon.com/apache2.0
 * 
 * or in the "license" file accompanying this file. This file is distributed
 * on an "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either
 * express or implied. See the License for the specific language governing
 * permissions and limitations under the License.
 */

/*
 * Do not modify this file. This file is generated from the sqs-2012-11-05.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.SQS.Model
{
    /// <summary>
    /// The MD5OfMessageBody and MessageId elements.
    /// </summary>
    public partial class SendMessageResult : AmazonWebServiceResponse
    {
        private string _mD5OfMessageAttributes;
        private string _mD5OfMessageBody;
        private string _messageId;

        /// <summary>
        /// Gets and sets the property MD5OfMessageAttributes. 
        /// <para>
        /// An MD5 digest of the non-URL-encoded message attribute string. This can be used to
        /// verify that Amazon SQS received the message correctly. Amazon SQS first URL decodes
        /// the message before creating the MD5 digest. For information about MD5, go to <a href="http://www.faqs.org/rfcs/rfc1321.html">http://www.faqs.org/rfcs/rfc1321.html</a>.
        /// </para>
        /// </summary>
        public string MD5OfMessageAttributes
        {
            get { return this._mD5OfMessageAttributes; }
            set { this._mD5OfMessageAttributes = value; }
        }

        // Check to see if MD5OfMessageAttributes property is set
        internal bool IsSetMD5OfMessageAttributes()
        {
            return this._mD5OfMessageAttributes != null;
        }

        /// <summary>
        /// Gets and sets the property MD5OfMessageBody. 
        /// <para>
        /// An MD5 digest of the non-URL-encoded message body string. This can be used to    
        ///  verify that Amazon SQS received the message correctly. Amazon SQS first URL decodes
        /// the      message before creating the MD5 digest. For information about MD5, go to
        /// <a href="http://www.faqs.org/rfcs/rfc1321.html">http://www.faqs.org/rfcs/rfc1321.html</a>.
        /// </para>
        /// </summary>
        public string MD5OfMessageBody
        {
            get { return this._mD5OfMessageBody; }
            set { this._mD5OfMessageBody = value; }
        }

        // Check to see if MD5OfMessageBody property is set
        internal bool IsSetMD5OfMessageBody()
        {
            return this._mD5OfMessageBody != null;
        }

        /// <summary>
        /// Gets and sets the property MessageId. 
        /// <para>
        ///             An element containing the message ID of the message sent to the queue.
        ///             For more information, see       <a href="http://docs.aws.amazon.com/AWSSimpleQueueService/latest/SQSDeveloperGuide/ImportantIdentifiers.html">Queue
        /// and Message Identifiers</a>       in the <i>Amazon SQS Developer Guide</i>.    
        /// </para>
        /// </summary>
        public string MessageId
        {
            get { return this._messageId; }
            set { this._messageId = value; }
        }

        // Check to see if MessageId property is set
        internal bool IsSetMessageId()
        {
            return this._messageId != null;
        }

    }
}