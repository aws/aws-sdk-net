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
    /// An Amazon SQS message.
    /// </summary>
    public partial class Message
    {
        /// <summary>
        /// Empty constructor used to set properties independently even when a simple constructor is available
        /// </summary>
        public Message() { }

        /// <summary>
        /// Gets and sets the property Attributes. 
        /// <para>
        /// A map of the attributes requested in <c> <a>ReceiveMessage</a> </c> to their respective
        /// values. Supported attributes:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>ApproximateReceiveCount</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>ApproximateFirstReceiveTimestamp</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>MessageDeduplicationId</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>MessageGroupId</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>SenderId</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>SentTimestamp</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>SequenceNumber</c> 
        /// </para>
        ///  </li> </ul> 
        /// <para>
        ///  <c>ApproximateFirstReceiveTimestamp</c> and <c>SentTimestamp</c> are each returned
        /// as an integer representing the <a href="http://en.wikipedia.org/wiki/Unix_time">epoch
        /// time</a> in milliseconds.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public Dictionary<string, string> Attributes { get; set; } = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;

        /// <summary>
        /// Checks to see if the Attributes property is set.
        /// </summary>
        internal bool IsSetAttributes() => this.Attributes != null && (this.Attributes.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property Body. 
        /// <para>
        /// The message's contents (not URL-encoded).
        /// </para>
        /// </summary>
        public string Body { get; set; }

        /// <summary>
        /// Checks to see if the Body property is set.
        /// </summary>
        internal bool IsSetBody() => this.Body != null;

        /// <summary>
        /// Gets and sets the property MD5OfBody. 
        /// <para>
        /// An MD5 digest of the non-URL-encoded message body string.
        /// </para>
        /// </summary>
        public string MD5OfBody { get; set; }

        /// <summary>
        /// Checks to see if the MD5OfBody property is set.
        /// </summary>
        internal bool IsSetMD5OfBody() => this.MD5OfBody != null;

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
        /// Gets and sets the property MessageAttributes. 
        /// <para>
        /// Each message attribute consists of a <c>Name</c>, <c>Type</c>, and <c>Value</c>. For
        /// more information, see <a href="https://docs.aws.amazon.com/AWSSimpleQueueService/latest/SQSDeveloperGuide/sqs-message-metadata.html#sqs-message-attributes">Amazon
        /// SQS message attributes</a> in the <i>Amazon SQS Developer Guide</i>.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public Dictionary<string, MessageAttributeValue> MessageAttributes { get; set; } = AWSConfigs.InitializeCollections ? new Dictionary<string, MessageAttributeValue>() : null;

        /// <summary>
        /// Checks to see if the MessageAttributes property is set.
        /// </summary>
        internal bool IsSetMessageAttributes() => this.MessageAttributes != null && (this.MessageAttributes.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property MessageId. 
        /// <para>
        /// A unique identifier for the message. A <c>MessageId</c>is considered unique across
        /// all Amazon Web Services accounts for an extended period of time.
        /// </para>
        /// </summary>
        public string MessageId { get; set; }

        /// <summary>
        /// Checks to see if the MessageId property is set.
        /// </summary>
        internal bool IsSetMessageId() => this.MessageId != null;

        /// <summary>
        /// Gets and sets the property ReceiptHandle. 
        /// <para>
        /// An identifier associated with the act of receiving the message. A new receipt handle
        /// is returned every time you receive a message. When deleting a message, you provide
        /// the last received receipt handle to delete the message.
        /// </para>
        /// </summary>
        public string ReceiptHandle { get; set; }

        /// <summary>
        /// Checks to see if the ReceiptHandle property is set.
        /// </summary>
        internal bool IsSetReceiptHandle() => this.ReceiptHandle != null;
    }
}
