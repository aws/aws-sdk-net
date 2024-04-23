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

namespace Amazon.SQS.Model
{
    /// <summary>
    /// Contains the details of a single Amazon SQS message along with an <c>Id</c>.
    /// </summary>
    public partial class SendMessageBatchRequestEntry
    {
        private int? _delaySeconds;
        private string _id;
        private Dictionary<string, MessageAttributeValue> _messageAttributes = AWSConfigs.InitializeCollections ? new Dictionary<string, MessageAttributeValue>() : null;
        private string _messageBody;
        private string _messageDeduplicationId;
        private string _messageGroupId;
        private Dictionary<string, MessageSystemAttributeValue> _messageSystemAttributes = AWSConfigs.InitializeCollections ? new Dictionary<string, MessageSystemAttributeValue>() : null;

        /// <summary>
        /// Empty constructor used to set  properties independently even when a simple constructor is available
        /// </summary>
        public SendMessageBatchRequestEntry() { }

        /// <summary>
        /// Instantiates SendMessageBatchRequestEntry with the parameterized properties
        /// </summary>
        /// <param name="id">An identifier for a message in this batch used to communicate the result. <note> The <c>Id</c>s of a batch request need to be unique within a request. This identifier can have up to 80 characters. The following characters are accepted: alphanumeric characters, hyphens(-), and underscores (_). </note></param>
        /// <param name="messageBody">The body of the message.</param>
        public SendMessageBatchRequestEntry(string id, string messageBody)
        {
            _id = id;
            _messageBody = messageBody;
        }

        /// <summary>
        /// Gets and sets the property DelaySeconds. 
        /// <para>
        /// The length of time, in seconds, for which a specific message is delayed. Valid values:
        /// 0 to 900. Maximum: 15 minutes. Messages with a positive <c>DelaySeconds</c> value
        /// become available for processing after the delay period is finished. If you don't specify
        /// a value, the default value for the queue is applied. 
        /// </para>
        ///  <note> 
        /// <para>
        /// When you set <c>FifoQueue</c>, you can't set <c>DelaySeconds</c> per message. You
        /// can set this parameter only on a queue level.
        /// </para>
        ///  </note>
        /// </summary>
        public int DelaySeconds
        {
            get { return this._delaySeconds.GetValueOrDefault(); }
            set { this._delaySeconds = value; }
        }

        // Check to see if DelaySeconds property is set
        internal bool IsSetDelaySeconds()
        {
            return this._delaySeconds.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Id. 
        /// <para>
        /// An identifier for a message in this batch used to communicate the result.
        /// </para>
        ///  <note> 
        /// <para>
        /// The <c>Id</c>s of a batch request need to be unique within a request.
        /// </para>
        ///  
        /// <para>
        /// This identifier can have up to 80 characters. The following characters are accepted:
        /// alphanumeric characters, hyphens(-), and underscores (_).
        /// </para>
        ///  </note>
        /// </summary>
        [AWSProperty(Required=true)]
        public string Id
        {
            get { return this._id; }
            set { this._id = value; }
        }

        // Check to see if Id property is set
        internal bool IsSetId()
        {
            return this._id != null;
        }

        /// <summary>
        /// Gets and sets the property MessageAttributes. 
        /// <para>
        /// Each message attribute consists of a <c>Name</c>, <c>Type</c>, and <c>Value</c>. For
        /// more information, see <a href="https://docs.aws.amazon.com/AWSSimpleQueueService/latest/SQSDeveloperGuide/sqs-message-metadata.html#sqs-message-attributes">Amazon
        /// SQS message attributes</a> in the <i>Amazon SQS Developer Guide</i>.
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
            return this._messageAttributes != null && (this._messageAttributes.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property MessageBody. 
        /// <para>
        /// The body of the message.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string MessageBody
        {
            get { return this._messageBody; }
            set { this._messageBody = value; }
        }

        // Check to see if MessageBody property is set
        internal bool IsSetMessageBody()
        {
            return this._messageBody != null;
        }

        /// <summary>
        /// Gets and sets the property MessageDeduplicationId. 
        /// <para>
        /// This parameter applies only to FIFO (first-in-first-out) queues.
        /// </para>
        ///  
        /// <para>
        /// The token used for deduplication of messages within a 5-minute minimum deduplication
        /// interval. If a message with a particular <c>MessageDeduplicationId</c> is sent successfully,
        /// subsequent messages with the same <c>MessageDeduplicationId</c> are accepted successfully
        /// but aren't delivered. For more information, see <a href="https://docs.aws.amazon.com/AWSSimpleQueueService/latest/SQSDeveloperGuide/FIFO-queues-exactly-once-processing.html">
        /// Exactly-once processing</a> in the <i>Amazon SQS Developer Guide</i>.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Every message must have a unique <c>MessageDeduplicationId</c>,
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// You may provide a <c>MessageDeduplicationId</c> explicitly.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// If you aren't able to provide a <c>MessageDeduplicationId</c> and you enable <c>ContentBasedDeduplication</c>
        /// for your queue, Amazon SQS uses a SHA-256 hash to generate the <c>MessageDeduplicationId</c>
        /// using the body of the message (but not the attributes of the message). 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// If you don't provide a <c>MessageDeduplicationId</c> and the queue doesn't have <c>ContentBasedDeduplication</c>
        /// set, the action fails with an error.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// If the queue has <c>ContentBasedDeduplication</c> set, your <c>MessageDeduplicationId</c>
        /// overrides the generated one.
        /// </para>
        ///  </li> </ul> </li> <li> 
        /// <para>
        /// When <c>ContentBasedDeduplication</c> is in effect, messages with identical content
        /// sent within the deduplication interval are treated as duplicates and only one copy
        /// of the message is delivered.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// If you send one message with <c>ContentBasedDeduplication</c> enabled and then another
        /// message with a <c>MessageDeduplicationId</c> that is the same as the one generated
        /// for the first <c>MessageDeduplicationId</c>, the two messages are treated as duplicates
        /// and only one copy of the message is delivered. 
        /// </para>
        ///  </li> </ul> <note> 
        /// <para>
        /// The <c>MessageDeduplicationId</c> is available to the consumer of the message (this
        /// can be useful for troubleshooting delivery issues).
        /// </para>
        ///  
        /// <para>
        /// If a message is sent successfully but the acknowledgement is lost and the message
        /// is resent with the same <c>MessageDeduplicationId</c> after the deduplication interval,
        /// Amazon SQS can't detect duplicate messages.
        /// </para>
        ///  
        /// <para>
        /// Amazon SQS continues to keep track of the message deduplication ID even after the
        /// message is received and deleted.
        /// </para>
        ///  </note> 
        /// <para>
        /// The length of <c>MessageDeduplicationId</c> is 128 characters. <c>MessageDeduplicationId</c>
        /// can contain alphanumeric characters (<c>a-z</c>, <c>A-Z</c>, <c>0-9</c>) and punctuation
        /// (<c>!"#$%&amp;'()*+,-./:;&lt;=&gt;?@[\]^_`{|}~</c>).
        /// </para>
        ///  
        /// <para>
        /// For best practices of using <c>MessageDeduplicationId</c>, see <a href="https://docs.aws.amazon.com/AWSSimpleQueueService/latest/SQSDeveloperGuide/using-messagededuplicationid-property.html">Using
        /// the MessageDeduplicationId Property</a> in the <i>Amazon SQS Developer Guide</i>.
        /// </para>
        /// </summary>
        public string MessageDeduplicationId
        {
            get { return this._messageDeduplicationId; }
            set { this._messageDeduplicationId = value; }
        }

        // Check to see if MessageDeduplicationId property is set
        internal bool IsSetMessageDeduplicationId()
        {
            return this._messageDeduplicationId != null;
        }

        /// <summary>
        /// Gets and sets the property MessageGroupId. 
        /// <para>
        /// This parameter applies only to FIFO (first-in-first-out) queues.
        /// </para>
        ///  
        /// <para>
        /// The tag that specifies that a message belongs to a specific message group. Messages
        /// that belong to the same message group are processed in a FIFO manner (however, messages
        /// in different message groups might be processed out of order). To interleave multiple
        /// ordered streams within a single queue, use <c>MessageGroupId</c> values (for example,
        /// session data for multiple users). In this scenario, multiple consumers can process
        /// the queue, but the session data of each user is processed in a FIFO fashion.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// You must associate a non-empty <c>MessageGroupId</c> with a message. If you don't
        /// provide a <c>MessageGroupId</c>, the action fails.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>ReceiveMessage</c> might return messages with multiple <c>MessageGroupId</c> values.
        /// For each <c>MessageGroupId</c>, the messages are sorted by time sent. The caller can't
        /// specify a <c>MessageGroupId</c>.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// The length of <c>MessageGroupId</c> is 128 characters. Valid values: alphanumeric
        /// characters and punctuation <c>(!"#$%&amp;'()*+,-./:;&lt;=&gt;?@[\]^_`{|}~)</c>.
        /// </para>
        ///  
        /// <para>
        /// For best practices of using <c>MessageGroupId</c>, see <a href="https://docs.aws.amazon.com/AWSSimpleQueueService/latest/SQSDeveloperGuide/using-messagegroupid-property.html">Using
        /// the MessageGroupId Property</a> in the <i>Amazon SQS Developer Guide</i>.
        /// </para>
        ///  <important> 
        /// <para>
        ///  <c>MessageGroupId</c> is required for FIFO queues. You can't use it for Standard
        /// queues.
        /// </para>
        ///  </important>
        /// </summary>
        public string MessageGroupId
        {
            get { return this._messageGroupId; }
            set { this._messageGroupId = value; }
        }

        // Check to see if MessageGroupId property is set
        internal bool IsSetMessageGroupId()
        {
            return this._messageGroupId != null;
        }

        /// <summary>
        /// Gets and sets the property MessageSystemAttributes. 
        /// <para>
        /// The message system attribute to send Each message system attribute consists of a <c>Name</c>,
        /// <c>Type</c>, and <c>Value</c>.
        /// </para>
        ///  <important> <ul> <li> 
        /// <para>
        /// Currently, the only supported message system attribute is <c>AWSTraceHeader</c>. Its
        /// type must be <c>String</c> and its value must be a correctly formatted X-Ray trace
        /// header string.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The size of a message system attribute doesn't count towards the total size of a message.
        /// </para>
        ///  </li> </ul> </important>
        /// </summary>
        public Dictionary<string, MessageSystemAttributeValue> MessageSystemAttributes
        {
            get { return this._messageSystemAttributes; }
            set { this._messageSystemAttributes = value; }
        }

        // Check to see if MessageSystemAttributes property is set
        internal bool IsSetMessageSystemAttributes()
        {
            return this._messageSystemAttributes != null && (this._messageSystemAttributes.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}