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

namespace Amazon.SQS.Model
{
    /// <summary>
    /// <para>An Amazon SQS message.</para>
    /// </summary>
    public class Message
    {
        
        private string messageId;
        private string receiptHandle;
        private string mD5OfBody;
        private string body;
        private Dictionary<string,string> attributes = new Dictionary<string,string>();


        /// <summary>
        /// A unique identifier for the message. Message IDs are considered unique across all AWS accounts for an extended period of time.
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

        /// <summary>
        /// An identifier associated with the act of receiving the message. A new receipt handle is returned every time you receive a message. When
        /// deleting a message, you provide the last received receipt handle to delete the message.
        ///  
        /// </summary>
        public string ReceiptHandle
        {
            get { return this.receiptHandle; }
            set { this.receiptHandle = value; }
        }

        // Check to see if ReceiptHandle property is set
        internal bool IsSetReceiptHandle()
        {
            return this.receiptHandle != null;
        }

        /// <summary>
        /// An MD5 digest of the non-URL-encoded message body string.
        ///  
        /// </summary>
        public string MD5OfBody
        {
            get { return this.mD5OfBody; }
            set { this.mD5OfBody = value; }
        }

        // Check to see if MD5OfBody property is set
        internal bool IsSetMD5OfBody()
        {
            return this.mD5OfBody != null;
        }

        /// <summary>
        /// The message's contents (not URL-encoded).
        ///  
        /// </summary>
        public string Body
        {
            get { return this.body; }
            set { this.body = value; }
        }

        // Check to see if Body property is set
        internal bool IsSetBody()
        {
            return this.body != null;
        }

        /// <summary>
        /// <c>SenderId</c>, <c>SentTimestamp</c>, <c>ApproximateReceiveCount</c>, and/or <c>ApproximateFirstReceiveTimestamp</c>. <c>SentTimestamp</c>
        /// and <c>ApproximateFirstReceiveTimestamp</c> are each returned as an integer representing the <a
        /// href="http://en.wikipedia.org/wiki/Unix_time">epoch time</a> in milliseconds.
        ///  
        /// </summary>
        public Dictionary<string,string> Attributes
        {
            get { return this.attributes; }
            set { this.attributes = value; }
        }

        // Check to see if Attributes property is set
        internal bool IsSetAttributes()
        {
            return this.attributes != null;
        }
    }
}
