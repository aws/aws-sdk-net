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
    /// An Amazon SQS message.
    /// </summary>
    public partial class Message
    {
        private Dictionary<string, string> _attributes = new Dictionary<string, string>();
        private string _body;
        private string _mD5OfBody;
        private string _mD5OfMessageAttributes;
        private Dictionary<string, MessageAttributeValue> _messageAttributes = new Dictionary<string, MessageAttributeValue>();
        private string _messageId;
        private string _receiptHandle;


        /// <summary>
        /// Gets and sets the property Attributes. 
        /// <para>
        /// <code>SenderId</code>, <code>SentTimestamp</code>, <code>ApproximateReceiveCount</code>,
        /// and/or       <code>ApproximateFirstReceiveTimestamp</code>. <code>SentTimestamp</code>
        ///      and <code>ApproximateFirstReceiveTimestamp</code> are each returned as an integer
        /// representing the             <a href="http://en.wikipedia.org/wiki/Unix_time">epoch
        /// time</a> in milliseconds.
        /// </para>
        /// </summary>
        public Dictionary<string, string> Attributes
        {
            get { return this._attributes; }
            set { this._attributes = value; }
        }

        // Check to see if Attributes property is set
        internal bool IsSetAttributes()
        {
            return this._attributes != null && this._attributes.Count > 0; 
        }


        /// <summary>
        /// Gets and sets the property Body. 
        /// <para>
        /// The message's contents (not URL-encoded).
        /// </para>
        /// </summary>
        public string Body
        {
            get { return this._body; }
            set { this._body = value; }
        }

        // Check to see if Body property is set
        internal bool IsSetBody()
        {
            return this._body != null;
        }


        /// <summary>
        /// Gets and sets the property MD5OfBody. 
        /// <para>
        /// An MD5 digest of the non-URL-encoded message body string.
        /// </para>
        /// </summary>
        public string MD5OfBody
        {
            get { return this._mD5OfBody; }
            set { this._mD5OfBody = value; }
        }

        // Check to see if MD5OfBody property is set
        internal bool IsSetMD5OfBody()
        {
            return this._mD5OfBody != null;
        }


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
        /// Gets and sets the property MessageAttributes. 
        /// <para>
        /// Each message attribute consists of a Name, Type, and Value. For more information,
        /// see <a href="http://docs.aws.amazon.com/AWSSimpleQueueService/latest/SQSDeveloperGuide/SQSMessageAttributes.html#SQSMessageAttributesNTV">Message
        /// Attribute Items</a>.
        /// </para>
        /// </summary>
        public Dictionary<string, MessageAttributeValue> MessageAttributes
        {
            get { return this._messageAttributes; }
            set { this._messageAttributes = value; }
        }

        // Check to see if MessageAttributes property is set
        internal bool IsSetMessageAttributes()
        {
            return this._messageAttributes != null && this._messageAttributes.Count > 0; 
        }


        /// <summary>
        /// Gets and sets the property MessageId. 
        /// <para>
        /// A unique identifier for the message. Message IDs are considered unique across all
        /// AWS accounts for an extended period of time.
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


        /// <summary>
        /// Gets and sets the property ReceiptHandle. 
        /// <para>
        /// An identifier associated with the act of receiving the message.       A new receipt
        /// handle is returned every time you receive a message.       When deleting a message,
        /// you provide the last received receipt handle to delete the message.
        /// </para>
        /// </summary>
        public string ReceiptHandle
        {
            get { return this._receiptHandle; }
            set { this._receiptHandle = value; }
        }

        // Check to see if ReceiptHandle property is set
        internal bool IsSetReceiptHandle()
        {
            return this._receiptHandle != null;
        }

    }
}