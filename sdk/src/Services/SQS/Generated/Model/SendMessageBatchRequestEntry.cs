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
    /// Contains the details of a single Amazon SQS message along with an <code>Id</code>.
    /// </summary>
    public partial class SendMessageBatchRequestEntry
    {
        private int? _delaySeconds;
        private string _id;
        private Dictionary<string, MessageAttributeValue> _messageAttributes = new Dictionary<string, MessageAttributeValue>();
        private string _messageBody;
        private string _messageDeduplicationId;
        private string _messageGroupId;

        /// <summary>
        /// Empty constructor used to set  properties independently even when a simple constructor is available
        /// </summary>
        public SendMessageBatchRequestEntry() { }

        /// <summary>
        /// Instantiates SendMessageBatchRequestEntry with the parameterized properties
        /// </summary>
        /// <param name="id">An identifier for a message in this batch used to communicate the result. <note> The <code>Id</code>s of a batch request need to be unique within a request This identifier can have up to 80 characters. The following characters are accepted: alphanumeric characters, hyphens(-), and underscores (_). </note></param>
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
        /// 0 to 900. Maximum: 15 minutes. Messages with a positive <code>DelaySeconds</code>
        /// value become available for processing after the delay period is finished. If you don't
        /// specify a value, the default value for the queue is applied. 
        /// </para>
        ///  <note> 
        /// <para>
        /// When you set <code>FifoQueue</code>, you can't set <code>DelaySeconds</code> per message.
        /// You can set this parameter only on a queue level.
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
        /// The <code>Id</code>s of a batch request need to be unique within a request
        /// </para>
        ///  
        /// <para>
        /// This identifier can have up to 80 characters. The following characters are accepted:
        /// alphanumeric characters, hyphens(-), and underscores (_).
        /// </para>
        ///  </note>
        /// </summary>
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
        /// Each message attribute consists of a <code>Name</code>, <code>Type</code>, and <code>Value</code>.
        /// For more information, see <a href="http://docs.aws.amazon.com/AWSSimpleQueueService/latest/SQSDeveloperGuide/sqs-message-attributes.html">Amazon
        /// SQS Message Attributes</a> in the <i>Amazon Simple Queue Service Developer Guide</i>.
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
        /// Gets and sets the property MessageBody. 
        /// <para>
        /// The body of the message.
        /// </para>
        /// </summary>
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
        /// interval. If a message with a particular <code>MessageDeduplicationId</code> is sent
        /// successfully, subsequent messages with the same <code>MessageDeduplicationId</code>
        /// are accepted successfully but aren't delivered. For more information, see <a href="http://docs.aws.amazon.com/AWSSimpleQueueService/latest/SQSDeveloperGuide/FIFO-queues.html#FIFO-queues-exactly-once-processing">
        /// Exactly-Once Processing</a> in the <i>Amazon Simple Queue Service Developer Guide</i>.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Every message must have a unique <code>MessageDeduplicationId</code>,
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// You may provide a <code>MessageDeduplicationId</code> explicitly.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// If you aren't able to provide a <code>MessageDeduplicationId</code> and you enable
        /// <code>ContentBasedDeduplication</code> for your queue, Amazon SQS uses a SHA-256 hash
        /// to generate the <code>MessageDeduplicationId</code> using the body of the message
        /// (but not the attributes of the message). 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// If you don't provide a <code>MessageDeduplicationId</code> and the queue doesn't have
        /// <code>ContentBasedDeduplication</code> set, the action fails with an error.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// If the queue has <code>ContentBasedDeduplication</code> set, your <code>MessageDeduplicationId</code>
        /// overrides the generated one.
        /// </para>
        ///  </li> </ul> </li> <li> 
        /// <para>
        /// When <code>ContentBasedDeduplication</code> is in effect, messages with identical
        /// content sent within the deduplication interval are treated as duplicates and only
        /// one copy of the message is delivered.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// If you send one message with <code>ContentBasedDeduplication</code> enabled and then
        /// another message with a <code>MessageDeduplicationId</code> that is the same as the
        /// one generated for the first <code>MessageDeduplicationId</code>, the two messages
        /// are treated as duplicates and only one copy of the message is delivered. 
        /// </para>
        ///  </li> </ul> <note> 
        /// <para>
        /// The <code>MessageDeduplicationId</code> is available to the consumer of the message
        /// (this can be useful for troubleshooting delivery issues).
        /// </para>
        ///  
        /// <para>
        /// If a message is sent successfully but the acknowledgement is lost and the message
        /// is resent with the same <code>MessageDeduplicationId</code> after the deduplication
        /// interval, Amazon SQS can't detect duplicate messages.
        /// </para>
        ///  
        /// <para>
        /// Amazon SQS continues to keep track of the message deduplication ID even after the
        /// message is received and deleted.
        /// </para>
        ///  </note> 
        /// <para>
        /// The length of <code>MessageDeduplicationId</code> is 128 characters. <code>MessageDeduplicationId</code>
        /// can contain alphanumeric characters (<code>a-z</code>, <code>A-Z</code>, <code>0-9</code>)
        /// and punctuation (<code>!"#$%&amp;'()*+,-./:;&lt;=&gt;?@[\]^_`{|}~</code>).
        /// </para>
        ///  
        /// <para>
        /// For best practices of using <code>MessageDeduplicationId</code>, see <a href="http://docs.aws.amazon.com/AWSSimpleQueueService/latest/SQSDeveloperGuide/using-messagededuplicationid-property.html">Using
        /// the MessageDeduplicationId Property</a> in the <i>Amazon Simple Queue Service Developer
        /// Guide</i>.
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
        /// ordered streams within a single queue, use <code>MessageGroupId</code> values (for
        /// example, session data for multiple users). In this scenario, multiple consumers can
        /// process the queue, but the session data of each user is processed in a FIFO fashion.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// You must associate a non-empty <code>MessageGroupId</code> with a message. If you
        /// don't provide a <code>MessageGroupId</code>, the action fails.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>ReceiveMessage</code> might return messages with multiple <code>MessageGroupId</code>
        /// values. For each <code>MessageGroupId</code>, the messages are sorted by time sent.
        /// The caller can't specify a <code>MessageGroupId</code>.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// The length of <code>MessageGroupId</code> is 128 characters. Valid values: alphanumeric
        /// characters and punctuation <code>(!"#$%&amp;'()*+,-./:;&lt;=&gt;?@[\]^_`{|}~)</code>.
        /// </para>
        ///  
        /// <para>
        /// For best practices of using <code>MessageGroupId</code>, see <a href="http://docs.aws.amazon.com/AWSSimpleQueueService/latest/SQSDeveloperGuide/using-messagegroupid-property.html">Using
        /// the MessageGroupId Property</a> in the <i>Amazon Simple Queue Service Developer Guide</i>.
        /// </para>
        ///  <important> 
        /// <para>
        ///  <code>MessageGroupId</code> is required for FIFO queues. You can't use it for Standard
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

    }
}