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

#pragma warning disable CS0612,CS0618,CS1570
namespace Amazon.SimpleNotificationService.Model
{
    /// <summary>
    /// Contains the details of a single Amazon SNS message along with an <c>Id</c> that identifies
    /// a message within the batch.
    /// </summary>
    public partial class PublishBatchRequestEntry
    {
        private string _id;
        private string _message;
        private Dictionary<string, MessageAttributeValue> _messageAttributes = AWSConfigs.InitializeCollections ? new Dictionary<string, MessageAttributeValue>() : null;
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
        /// The <c>Ids</c> of a batch request must be unique within a request. 
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
        /// Each message attribute consists of a <c>Name</c>, <c>Type</c>, and <c>Value</c>. For
        /// more information, see <a href="https://docs.aws.amazon.com/sns/latest/dg/sns-message-attributes.html">Amazon
        /// SNS message attributes</a> in the Amazon SNS Developer Guide.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
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
        /// Gets and sets the property MessageDeduplicationId. 
        /// <para>
        /// This parameter applies only to FIFO (first-in-first-out) topics.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// This parameter applies only to FIFO (first-in-first-out) topics. The <c>MessageDeduplicationId</c>
        /// can contain up to 128 alphanumeric characters <c>(a-z, A-Z, 0-9)</c> and punctuation
        /// <c>(!"#$%&amp;'()*+,-./:;&lt;=&gt;?@[\]^_`{|}~)</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Every message must have a unique <c>MessageDeduplicationId</c>, which is a token used
        /// for deduplication of sent messages within the 5 minute minimum deduplication interval.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The scope of deduplication depends on the <c>FifoThroughputScope</c> attribute, when
        /// set to <c>Topic</c> the message deduplication scope is across the entire topic, when
        /// set to <c>MessageGroup</c> the message deduplication scope is within each individual
        /// message group. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// If a message with a particular <c>MessageDeduplicationId</c> is sent successfully,
        /// subsequent messages within the deduplication scope and interval, with the same <c>MessageDeduplicationId</c>,
        /// are accepted successfully but aren't delivered.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Every message must have a unique <c>MessageDeduplicationId</c>.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// You may provide a <c>MessageDeduplicationId</c> explicitly.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// If you aren't able to provide a <c>MessageDeduplicationId</c> and you enable <c>ContentBasedDeduplication</c>
        /// for your topic, Amazon SNS uses a SHA-256 hash to generate the <c>MessageDeduplicationId</c>
        /// using the body of the message (but not the attributes of the message).
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// If you don't provide a <c>MessageDeduplicationId</c> and the topic doesn't have <c>ContentBasedDeduplication</c>
        /// set, the action fails with an error.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// If the topic has a <c>ContentBasedDeduplication</c> set, your <c>MessageDeduplicationId</c>
        /// overrides the generated one. 
        /// </para>
        ///  </li> </ul> </li> <li> 
        /// <para>
        /// When <c>ContentBasedDeduplication</c> is in effect, messages with identical content
        /// sent within the deduplication scope and interval are treated as duplicates and only
        /// one copy of the message is delivered.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// If you send one message with <c>ContentBasedDeduplication</c> enabled, and then another
        /// message with a <c>MessageDeduplicationId</c> that is the same as the one generated
        /// for the first <c>MessageDeduplicationId</c>, the two messages are treated as duplicates,
        /// within the deduplication scope and interval, and only one copy of the message is delivered.
        /// 
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
        /// Amazon SNS can't detect duplicate messages. 
        /// </para>
        ///  
        /// <para>
        /// Amazon SNS continues to keep track of the message deduplication ID even after the
        /// message is received and deleted. 
        /// </para>
        ///  </note>
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
        /// FIFO topics: The tag that specifies that a message belongs to a specific message group.
        /// Messages that belong to the same message group are processed in a FIFO manner (however,
        /// messages in different message groups might be processed out of order). To interleave
        /// multiple ordered streams within a single topic, use <c>MessageGroupId</c> values (for
        /// example, session data for multiple users). In this scenario, multiple consumers can
        /// process the topic, but the session data of each user is processed in a FIFO fashion.
        /// You must associate a non-empty <c>MessageGroupId</c> with a message. If you do not
        /// provide a <c>MessageGroupId</c>, the action fails. 
        /// </para>
        ///  
        /// <para>
        /// Standard topics: The <c>MessageGroupId</c> is optional and is forwarded only to Amazon
        /// SQS standard subscriptions to activate <a href="https://docs.aws.amazon.com/AWSSimpleQueueService/latest/SQSDeveloperGuide/sqs-fair-queues.html">fair
        /// queues</a>. The <c>MessageGroupId</c> is not used for, or sent to, any other endpoint
        /// types.
        /// </para>
        ///  
        /// <para>
        /// The length of <c>MessageGroupId</c> is 128 characters.
        /// </para>
        ///  
        /// <para>
        ///  <c>MessageGroupId</c> can contain alphanumeric characters <c>(a-z, A-Z, 0-9)</c>
        /// and punctuation <c>(!"#$%&amp;'()*+,-./:;&lt;=&gt;?@[\]^_`{|}~)</c>.
        /// </para>
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
        /// Set <c>MessageStructure</c> to <c>json</c> if you want to send a different message
        /// for each protocol. For example, using one publish action, you can send a short message
        /// to your SMS subscribers and a longer message to your email subscribers. If you set
        /// <c>MessageStructure</c> to <c>json</c>, the value of the <c>Message</c> parameter
        /// must: 
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
        /// specific transport protocol (for example, http). 
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