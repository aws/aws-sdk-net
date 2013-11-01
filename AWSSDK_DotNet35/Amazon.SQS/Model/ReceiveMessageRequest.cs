/*
 * Copyright 2010-2013 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
    /// Container for the parameters to the ReceiveMessage operation.
    /// <para>Retrieves one or more messages from the specified queue, including the message body and message ID of each message. Messages returned
    /// by this action stay in the queue until you delete them. However, once a message is returned to a <c>ReceiveMessage</c> request, it is not
    /// returned on subsequent <c>ReceiveMessage</c> requests for the duration of the <c>VisibilityTimeout</c> . If you do not specify a
    /// <c>VisibilityTimeout</c> in the request, the overall visibility timeout for the queue is used for the returned messages.</para> <para>If a
    /// message is available in the queue, the call will return immediately. Otherwise, it will wait up to <c>WaitTimeSeconds</c> for a message to
    /// arrive. If you do not specify <c>WaitTimeSeconds</c> in the request, the queue attribute ReceiveMessageWaitTimeSeconds is used to determine
    /// how long to wait.</para> <para>You could ask for additional information about each message through the attributes. Attributes that can be
    /// requested are <c>[SenderId, ApproximateFirstReceiveTimestamp, ApproximateReceiveCount, SentTimestamp]</c> .</para>
    /// </summary>
    public partial class ReceiveMessageRequest : AmazonSQSRequest
    {
        private string queueUrl;
        private List<string> attributeNames = new List<string>();
        private int? maxNumberOfMessages;
        private int? visibilityTimeout;
        private int? waitTimeSeconds;


        /// <summary>
        /// The URL of the SQS queue to take action on.
        ///  
        /// </summary>
        public string QueueUrl
        {
            get { return this.queueUrl; }
            set { this.queueUrl = value; }
        }

        // Check to see if QueueUrl property is set
        internal bool IsSetQueueUrl()
        {
            return this.queueUrl != null;
        }

        /// <summary>
        /// A list of attributes that need to be returned along with each message. The set of valid attributes are [SenderId,
        /// ApproximateFirstReceiveTimestamp, ApproximateReceiveCount, SentTimestamp].
        ///  
        /// </summary>
        public List<string> AttributeNames
        {
            get { return this.attributeNames; }
            set { this.attributeNames = value; }
        }

        // Check to see if AttributeNames property is set
        internal bool IsSetAttributeNames()
        {
            return this.attributeNames.Count > 0;
        }

        /// <summary>
        /// The maximum number of messages to return. Amazon SQS never returns more messages than this value but may return fewer. All of the messages
        /// are not necessarily returned.
        ///  
        /// </summary>
        public int MaxNumberOfMessages
        {
            get { return this.maxNumberOfMessages ?? default(int); }
            set { this.maxNumberOfMessages = value; }
        }

        // Check to see if MaxNumberOfMessages property is set
        internal bool IsSetMaxNumberOfMessages()
        {
            return this.maxNumberOfMessages.HasValue;
        }

        /// <summary>
        /// The duration (in seconds) that the received messages are hidden from subsequent retrieve requests after being retrieved by a
        /// <c>ReceiveMessage</c> request.
        ///  
        /// </summary>
        public int VisibilityTimeout
        {
            get { return this.visibilityTimeout ?? default(int); }
            set { this.visibilityTimeout = value; }
        }

        // Check to see if VisibilityTimeout property is set
        internal bool IsSetVisibilityTimeout()
        {
            return this.visibilityTimeout.HasValue;
        }

        /// <summary>
        /// The duration (in seconds) for which the call will wait for a message to arrive in the queue before returning. If a message is available, the
        /// call will return sooner than WaitTimeSeconds.
        ///  
        /// </summary>
        public int WaitTimeSeconds
        {
            get { return this.waitTimeSeconds ?? default(int); }
            set { this.waitTimeSeconds = value; }
        }

        // Check to see if WaitTimeSeconds property is set
        internal bool IsSetWaitTimeSeconds()
        {
            return this.waitTimeSeconds.HasValue;
        }

    }
}
    
