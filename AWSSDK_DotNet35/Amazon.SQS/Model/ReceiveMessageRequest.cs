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
    /// <para> Retrieves one or more messages from the specified queue. Long poll support is enabled by using the <c>WaitTimeSeconds</c> parameter.
    /// For more information, see <a href="http://docs.aws.amazon.com/AWSSimpleQueueService/latest/SQSDeveloperGuide/sqs-long-polling.html" >Amazon
    /// SQS Long Poll</a> in the <i>Amazon SQS Developer Guide</i> .
    /// </para> <para> Short poll is the default behavior where a weighted random set of machines is sampled on a <c>ReceiveMessage</c> call.
    /// This means only the messages on the sampled machines are returned. If the number of messages in the queue is small (less than 1000), it is
    /// likely you will get fewer messages than you requested per <c>ReceiveMessage</c> call. If the number of messages in the queue is extremely
    /// small, you might not receive any messages in a particular <c>ReceiveMessage</c> response; in which case you should repeat the request.
    /// </para> <para> For each message returned, the response includes the following: </para>
    /// <ul>
    /// <li> <para> Message body </para> </li>
    /// <li> <para> MD5 digest of the message body. For information about MD5, go to <a href="http://www.faqs.org/rfcs/rfc1321.html"
    /// >http://www.faqs.org/rfcs/rfc1321.html</a> .
    /// </para> </li>
    /// <li> <para> Message ID you received when you sent the message to the queue. </para> </li>
    /// <li> <para> Receipt handle. </para> </li>
    /// 
    /// </ul>
    /// <para> The receipt handle is the identifier you must provide when deleting the message. For more information, see <a
    /// href="http://docs.aws.amazon.com/AWSSimpleQueueService/latest/SQSDeveloperGuide/ImportantIdentifiers.html" >Queue and Message
    /// Identifiers</a> in the <i>Amazon SQS Developer Guide</i> .
    /// </para> <para> You can provide the <c>VisibilityTimeout</c> parameter in your request, which will be applied to the messages that Amazon
    /// SQS returns in the response. If you do not include the parameter, the overall visibility timeout for the queue is used for the returned
    /// messages. For more information, see <a href="http://docs.aws.amazon.com/AWSSimpleQueueService/latest/SQSDeveloperGuide/AboutVT.html"
    /// >Visibility Timeout</a> in the <i>Amazon SQS Developer Guide</i> .
    /// </para> <para><b>NOTE:</b> Going forward, new attributes might be added. If you are writing code that calls this action, we recommend
    /// that you structure your code so that it can handle new attributes gracefully. </para>
    /// </summary>
    public partial class ReceiveMessageRequest : AmazonSQSRequest
    {
        private string queueUrl;
        private List<string> attributeNames = new List<string>();
        private int? maxNumberOfMessages;
        private int? visibilityTimeout;
        private int? waitTimeSeconds;


        /// <summary>
        /// The URL of the Amazon SQS queue to take action on.
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
        /// A list of attributes that need to be returned along with each message. The following lists the names and descriptions of the attributes that
        /// can be returned: <ul> <li><c>All</c> - returns all values.</li> <li><c>ApproximateFirstReceiveTimestamp</c> - returns the time when the
        /// message was first received (epoch time in milliseconds).</li> <li><c>ApproximateReceiveCount</c> - returns the number of times a message has
        /// been received but not deleted.</li> <li><c>SenderId</c> - returns the AWS account number (or the IP address, if anonymous access is allowed)
        /// of the sender.</li> <li><c>SentTimestamp</c> - returns the time when the message was sent (epoch time in milliseconds).</li> </ul>
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
    
