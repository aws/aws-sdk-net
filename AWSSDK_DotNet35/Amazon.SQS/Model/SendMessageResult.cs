/*
 * Copyright 2010-2013 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using Amazon.Runtime;

namespace Amazon.SQS.Model
{
    /// <summary>
    /// 
    /// </summary>
    public partial class SendMessageResult : AmazonWebServiceResponse
    {
        
        private string mD5OfMessageBody;
        private string messageId;


        /// <summary>
        /// An MD5 digest of the non-URL-encoded message body string. This can be used to verify that SQS received the message correctly. SQS first URL
        /// decodes the message before creating the MD5 digest. For information about MD5, go to <a
        /// href="http://faqs.org/rfcs/rfc1321.html">http://faqs.org/rfcs/rfc1321.html</a>.
        ///  
        /// </summary>
        public string MD5OfMessageBody
        {
            get { return this.mD5OfMessageBody; }
            set { this.mD5OfMessageBody = value; }
        }

        // Check to see if MD5OfMessageBody property is set
        internal bool IsSetMD5OfMessageBody()
        {
            return this.mD5OfMessageBody != null;
        }

        /// <summary>
        /// The message ID of the message added to the queue.
        ///  
        /// </summary>
        public string MessageId
        {
            get { return this.messageId; }
            set { this.messageId = value; }
        }

        // Check to see if MessageId property is set
        internal bool IsSetMessageId()
        {
            return this.messageId != null;
        }
    }
}
