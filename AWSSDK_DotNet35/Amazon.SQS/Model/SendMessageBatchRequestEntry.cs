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
    /// Contains the details of a single Amazon SQS message along with a <code>Id</code>.
    /// </summary>
    public partial class SendMessageBatchRequestEntry
    {
        private int? _delaySeconds;
        private string _id;
        private Dictionary<string, MessageAttributeValue> _messageAttributes = new Dictionary<string, MessageAttributeValue>();
        private string _messageBody;

        /// <summary>
        /// Empty constructor used to set  properties independently even when a simple constructor is available
        /// </summary>
        public SendMessageBatchRequestEntry() { }

        /// <summary>
        /// Instantiates SendMessageBatchRequestEntry with the parameterized properties
        /// </summary>
        /// <param name="id">An identifier for the message in this batch. This is used to communicate   the result. Note that the <code>Id</code>s of a batch request need to   be unique within the request.</param>
        /// <param name="messageBody">Body of the message.</param>
        public SendMessageBatchRequestEntry(string id, string messageBody)
        {
            _id = id;
            _messageBody = messageBody;
        }

        /// <summary>
        /// Gets and sets the property DelaySeconds. 
        /// <para>
        /// The number of seconds for which the message has to be delayed.
        /// </para>
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
        /// An identifier for the message in this batch. This is used to communicate      the
        /// result. Note that the <code>Id</code>s of a batch request need to      be unique within
        /// the request.
        /// </para>
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
        /// Gets and sets the property MessageBody. 
        /// <para>
        /// Body of the message.
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

    }
}