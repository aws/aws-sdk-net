/*
 * Copyright Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

#pragma warning disable CS0612,CS0618,CS1570
namespace Amazon.SQS.Model
{
    /// <summary>
    /// The <c>MD5OfMessageBody</c> and <c>MessageId</c> elements.
    /// </summary>
    public partial class SendMessageResponse : AmazonWebServiceResponse
    {
        private string _md5OfMessageAttributes;
        private string _md5OfMessageBody;
        private string _md5OfMessageSystemAttributes;
        private string _messageId;
        private string _sequenceNumber;

        /// <summary>
        /// Gets and sets the property MD5OfMessageAttributes. 
        /// <para>
        /// An MD5 digest of the non-URL-encoded message attribute string. You can use this attribute
        /// to verify that Amazon SQS received the message correctly. Amazon SQS URL-decodes the
        /// message before creating the MD5 digest. For information about MD5, see <a href="https://www.ietf.org/rfc/rfc1321.txt">RFC1321</a>.
        /// </para>
        /// </summary>
        public string MD5OfMessageAttributes
        {
            get { return this._md5OfMessageAttributes; }
            set { this._md5OfMessageAttributes = value; }
        }

        // Check to see if MD5OfMessageAttributes property is set
        internal bool IsSetMD5OfMessageAttributes()
        {
            return this._md5OfMessageAttributes != null;
        }

        /// <summary>
        /// Gets and sets the property MD5OfMessageBody. 
        /// <para>
        /// An MD5 digest of the non-URL-encoded message body string. You can use this attribute
        /// to verify that Amazon SQS received the message correctly. Amazon SQS URL-decodes the
        /// message before creating the MD5 digest. For information about MD5, see <a href="https://www.ietf.org/rfc/rfc1321.txt">RFC1321</a>.
        /// </para>
        /// </summary>
        public string MD5OfMessageBody
        {
            get { return this._md5OfMessageBody; }
            set { this._md5OfMessageBody = value; }
        }

        // Check to see if MD5OfMessageBody property is set
        internal bool IsSetMD5OfMessageBody()
        {
            return this._md5OfMessageBody != null;
        }

        /// <summary>
        /// Gets and sets the property MD5OfMessageSystemAttributes. 
        /// <para>
        /// An MD5 digest of the non-URL-encoded message system attribute string. You can use
        /// this attribute to verify that Amazon SQS received the message correctly. Amazon SQS
        /// URL-decodes the message before creating the MD5 digest.
        /// </para>
        /// </summary>
        public string MD5OfMessageSystemAttributes
        {
            get { return this._md5OfMessageSystemAttributes; }
            set { this._md5OfMessageSystemAttributes = value; }
        }

        // Check to see if MD5OfMessageSystemAttributes property is set
        internal bool IsSetMD5OfMessageSystemAttributes()
        {
            return this._md5OfMessageSystemAttributes != null;
        }

        /// <summary>
        /// Gets and sets the property MessageId. 
        /// <para>
        /// An attribute containing the <c>MessageId</c> of the message sent to the queue. For
        /// more information, see <a href="https://docs.aws.amazon.com/AWSSimpleQueueService/latest/SQSDeveloperGuide/sqs-queue-message-identifiers.html">Queue
        /// and Message Identifiers</a> in the <i>Amazon SQS Developer Guide</i>. 
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
        /// Gets and sets the property SequenceNumber. 
        /// <para>
        /// This parameter applies only to FIFO (first-in-first-out) queues.
        /// </para>
        ///  
        /// <para>
        /// The large, non-consecutive number that Amazon SQS assigns to each message.
        /// </para>
        ///  
        /// <para>
        /// The length of <c>SequenceNumber</c> is 128 bits. <c>SequenceNumber</c> continues to
        /// increase for a particular <c>MessageGroupId</c>.
        /// </para>
        /// </summary>
        public string SequenceNumber
        {
            get { return this._sequenceNumber; }
            set { this._sequenceNumber = value; }
        }

        // Check to see if SequenceNumber property is set
        internal bool IsSetSequenceNumber()
        {
            return this._sequenceNumber != null;
        }

    }
}