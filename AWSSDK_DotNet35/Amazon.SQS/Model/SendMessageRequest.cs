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
    /// Container for the parameters to the SendMessage operation.
    /// Delivers a message to the specified      queue. With Amazon SQS, you now have
    /// the ability to send large payload messages that are up      to 256KB (262,144 bytes)
    /// in size. To send large payloads, you must use an AWS SDK that      supports SigV4
    /// signing. To verify whether SigV4 is supported for an AWS SDK, check the SDK      release
    /// notes.    
    /// 
    ///     <important>      
    /// <para>
    ///         The following list shows the characters (in Unicode) allowed in your message,
    /// according        to the W3C XML specification. For more information, go to       
    ///         <a href="http://www.w3.org/TR/REC-xml/#charsets">http://www.w3.org/TR/REC-xml/#charsets</a>
    ///                If you send any characters not included in the list, your request will
    /// be rejected.      
    /// </para>
    ///       
    /// <para>
    ///         #x9 | #xA | #xD | [#x20 to #xD7FF] | [#xE000 to #xFFFD] | [#x10000 to #x10FFFF]
    ///      
    /// </para>
    ///     </important>
    /// </summary>
    public partial class SendMessageRequest : AmazonSQSRequest
    {
        private int? _delaySeconds;
        private Dictionary<string, MessageAttributeValue> _messageAttributes = new Dictionary<string, MessageAttributeValue>();
        private string _messageBody;
        private string _queueUrl;

        /// <summary>
        /// Empty constructor used to set  properties independently even when a simple constructor is available
        /// </summary>
        public SendMessageRequest() { }

        /// <summary>
        /// Instantiates SendMessageRequest with the parameterized properties
        /// </summary>
        /// <param name="queueUrl">The URL of the Amazon SQS queue to take action on.</param>
        /// <param name="messageBody">The message to send. String maximum 256 KB in size. For a list of allowed characters, see the preceding important note.</param>
        public SendMessageRequest(string queueUrl, string messageBody)
        {
            _queueUrl = queueUrl;
            _messageBody = messageBody;
        }

        /// <summary>
        /// Gets and sets the property DelaySeconds. 
        /// <para>
        ///       The number of seconds (0 to 900 - 15 minutes) to delay a specific message. Messages
        /// with a positive <code>DelaySeconds</code> value       become available for processing
        /// after the delay time is finished.      If you don't specify a value, the default value
        /// for the queue applies.    
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
        /// The message to send. String maximum 256 KB in size. For a list of allowed characters,
        /// see the preceding important note.
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
        /// Gets and sets the property QueueUrl. 
        /// <para>
        /// The URL of the Amazon SQS queue to take action on.
        /// </para>
        /// </summary>
        public string QueueUrl
        {
            get { return this._queueUrl; }
            set { this._queueUrl = value; }
        }

        // Check to see if QueueUrl property is set
        internal bool IsSetQueueUrl()
        {
            return this._queueUrl != null;
        }

    }
}