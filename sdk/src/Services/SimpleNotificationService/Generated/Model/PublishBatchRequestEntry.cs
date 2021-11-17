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
 * Do not modify this file. This file is generated from the sns-2010-03-31.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.SimpleNotificationService.Model
{
    /// <summary>
    /// Contains the details of a single Amazon SNS message along with an <code>Id</code>
    /// that identifies a message within the batch.
    /// </summary>
    public partial class PublishBatchRequestEntry
    {
        private string _id;
        private string _message;
        private Dictionary<string, MessageAttributeValue> _messageAttributes = new Dictionary<string, MessageAttributeValue>();
        private string _messageDeduplicationId;
        private string _messageGroupId;
        private string _messageStructure;
        private string _subject;

        /// <summary>
        /// Gets and sets the property Id. 
        /// <para>
        /// An identifier for the message in this batch.
        /// </para>
        ///  <note> 
        /// <para>
        /// The <code>Ids</code> of a batch request must be unique within a request. 
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
        /// Gets and sets the property Message. 
        /// <para>
        /// The body of the message.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string Message
        {
            get { return this._message; }
            set { this._message = value; }
        }

        // Check to see if Message property is set
        internal bool IsSetMessage()
        {
            return this._message != null;
        }

        /// <summary>
        /// Gets and sets the property MessageAttributes. 
        /// <para>
        /// Each message attribute consists of a <code>Name</code>, <code>Type</code>, and <code>Value</code>.
        /// For more information, see <a href="https://docs.aws.amazon.com/sns/latest/dg/sns-message-attributes.html">Amazon
        /// SNS message attributes</a> in the Amazon SNS Developer Guide.
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
        /// Gets and sets the property MessageDeduplicationId. 
        /// <para>
        /// This parameter applies only to FIFO (first-in-first-out) topics.
        /// </para>
        ///  
        /// <para>
        /// The token used for deduplication of messages within a 5-minute minimum deduplication
        /// interval. If a message with a particular <code>MessageDeduplicationId</code> is sent
        /// successfully, subsequent messages with the same <code>MessageDeduplicationId</code>
        /// are accepted successfully but aren't delivered.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Every message must have a unique <code>MessageDeduplicationId</code>.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// You may provide a <code>MessageDeduplicationId</code> explicitly.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// If you aren't able to provide a <code>MessageDeduplicationId</code> and you enable
        /// <code>ContentBasedDeduplication</code> for your topic, Amazon SNS uses a SHA-256 hash
        /// to generate the <code>MessageDeduplicationId</code> using the body of the message
        /// (but not the attributes of the message).
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// If you don't provide a <code>MessageDeduplicationId</code> and the topic doesn't have
        /// <code>ContentBasedDeduplication</code> set, the action fails with an error.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// If the topic has a <code>ContentBasedDeduplication</code> set, your <code>MessageDeduplicationId</code>
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
        /// If you send one message with <code>ContentBasedDeduplication</code> enabled, and then
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
        /// interval, Amazon SNS can't detect duplicate messages. 
        /// </para>
        ///  
        /// <para>
        /// Amazon SNS continues to keep track of the message deduplication ID even after the
        /// message is received and deleted. 
        /// </para>
        ///  </note> 
        /// <para>
        /// The length of <code>MessageDeduplicationId</code> is 128 characters.
        /// </para>
        ///  
        /// <para>
        ///  <code>MessageDeduplicationId</code> can contain alphanumeric characters <code>(a-z,
        /// A-Z, 0-9)</code> and punctuation <code>(!"#$%&amp;'()*+,-./:;&lt;=&gt;?@[\]^_`{|}~)</code>.
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
        /// This parameter applies only to FIFO (first-in-first-out) topics.
        /// </para>
        ///  
        /// <para>
        /// The tag that specifies that a message belongs to a specific message group. Messages
        /// that belong to the same message group are processed in a FIFO manner (however, messages
        /// in different message groups might be processed out of order). To interleave multiple
        /// ordered streams within a single topic, use <code>MessageGroupId</code> values (for
        /// example, session data for multiple users). In this scenario, multiple consumers can
        /// process the topic, but the session data of each user is processed in a FIFO fashion.
        /// 
        /// </para>
        ///  
        /// <para>
        /// You must associate a non-empty <code>MessageGroupId</code> with a message. If you
        /// don't provide a <code>MessageGroupId</code>, the action fails. 
        /// </para>
        ///  
        /// <para>
        /// The length of <code>MessageGroupId</code> is 128 characters.
        /// </para>
        ///  
        /// <para>
        ///  <code>MessageGroupId</code> can contain alphanumeric characters <code>(a-z, A-Z,
        /// 0-9)</code> and punctuation <code>(!"#$%&amp;'()*+,-./:;&lt;=&gt;?@[\]^_`{|}~)</code>.
        /// </para>
        ///  <important> 
        /// <para>
        ///  <code>MessageGroupId</code> is required for FIFO topics. You can't use it for standard
        /// topics. 
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
        /// Gets and sets the property MessageStructure. 
        /// <para>
        /// Set <code>MessageStructure</code> to <code>json</code> if you want to send a different
        /// message for each protocol. For example, using one publish action, you can send a short
        /// message to your SMS subscribers and a longer message to your email subscribers. If
        /// you set <code>MessageStructure</code> to <code>json</code>, the value of the <code>Message</code>
        /// parameter must: 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// be a syntactically valid JSON object; and
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// contain at least a top-level JSON key of "default" with a value that is a string.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// You can define other top-level keys that define the message you want to send to a
        /// specific transport protocol (e.g. http). 
        /// </para>
        /// </summary>
        public string MessageStructure
        {
            get { return this._messageStructure; }
            set { this._messageStructure = value; }
        }

        // Check to see if MessageStructure property is set
        internal bool IsSetMessageStructure()
        {
            return this._messageStructure != null;
        }

        /// <summary>
        /// Gets and sets the property Subject. 
        /// <para>
        /// The subject of the batch message.
        /// </para>
        /// </summary>
        public string Subject
        {
            get { return this._subject; }
            set { this._subject = value; }
        }

        // Check to see if Subject property is set
        internal bool IsSetSubject()
        {
            return this._subject != null;
        }

    }
}