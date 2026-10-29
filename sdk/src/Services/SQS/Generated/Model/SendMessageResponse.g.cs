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
 * Do not modify this file. This file is generated from the smithy.json service model.
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
    /// This is the response object from the SendMessage operation.
    /// </summary>
    public partial class SendMessageResponse : AmazonWebServiceResponse
    {
        /// <summary>
        /// Gets and sets the property MD5OfMessageAttributes. 
        /// <para>
        /// An MD5 digest of the non-URL-encoded message attribute string. You can use this attribute
        /// to verify that Amazon SQS received the message correctly. Amazon SQS URL-decodes the
        /// message before creating the MD5 digest. For information about MD5, see <a href="https://www.ietf.org/rfc/rfc1321.txt">RFC1321</a>.
        /// </para>
        /// </summary>
        public string MD5OfMessageAttributes { get; set; }

        /// <summary>
        /// Checks to see if the MD5OfMessageAttributes property is set.
        /// </summary>
        internal bool IsSetMD5OfMessageAttributes() => this.MD5OfMessageAttributes != null;

        /// <summary>
        /// Gets and sets the property MD5OfMessageBody. 
        /// <para>
        /// An MD5 digest of the non-URL-encoded message body string. You can use this attribute
        /// to verify that Amazon SQS received the message correctly. Amazon SQS URL-decodes the
        /// message before creating the MD5 digest. For information about MD5, see <a href="https://www.ietf.org/rfc/rfc1321.txt">RFC1321</a>.
        /// </para>
        /// </summary>
        public string MD5OfMessageBody { get; set; }

        /// <summary>
        /// Checks to see if the MD5OfMessageBody property is set.
        /// </summary>
        internal bool IsSetMD5OfMessageBody() => this.MD5OfMessageBody != null;

        /// <summary>
        /// Gets and sets the property MD5OfMessageSystemAttributes. 
        /// <para>
        /// An MD5 digest of the non-URL-encoded message system attribute string. You can use
        /// this attribute to verify that Amazon SQS received the message correctly. Amazon SQS
        /// URL-decodes the message before creating the MD5 digest.
        /// </para>
        /// </summary>
        public string MD5OfMessageSystemAttributes { get; set; }

        /// <summary>
        /// Checks to see if the MD5OfMessageSystemAttributes property is set.
        /// </summary>
        internal bool IsSetMD5OfMessageSystemAttributes() => this.MD5OfMessageSystemAttributes != null;

        /// <summary>
        /// Gets and sets the property MessageId. 
        /// <para>
        /// An attribute containing the <c>MessageId</c> of the message sent to the queue. For
        /// more information, see <a href="https://docs.aws.amazon.com/AWSSimpleQueueService/latest/SQSDeveloperGuide/sqs-queue-message-identifiers.html">Queue
        /// and Message Identifiers</a> in the <i>Amazon SQS Developer Guide</i>. 
        /// </para>
        /// </summary>
        public string MessageId { get; set; }

        /// <summary>
        /// Checks to see if the MessageId property is set.
        /// </summary>
        internal bool IsSetMessageId() => this.MessageId != null;

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
        public string SequenceNumber { get; set; }

        /// <summary>
        /// Checks to see if the SequenceNumber property is set.
        /// </summary>
        internal bool IsSetSequenceNumber() => this.SequenceNumber != null;
    }
}
