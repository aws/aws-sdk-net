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
    /// Container for the parameters to the GetQueueAttributes operation.
    /// Gets attributes for the specified queue.
    /// 
    ///  <note> 
    /// <para>
    /// Some API actions take lists of parameters. These lists are specified using the <code>param.n</code>
    /// notation. Values of <code>n</code> are integers starting from 1. For example, a parameter
    /// list with two elements looks like this:
    /// </para>
    ///  </note> 
    /// <para>
    ///  <code>&amp;amp;Attribute.1=this</code> 
    /// </para>
    ///  
    /// <para>
    ///  <code>&amp;amp;Attribute.2=that</code> 
    /// </para>
    /// </summary>
    public partial class GetQueueAttributesRequest : AmazonSQSRequest
    {
        private List<string> _attributeNames = new List<string>();
        private string _queueUrl;

        /// <summary>
        /// Empty constructor used to set  properties independently even when a simple constructor is available
        /// </summary>
        public GetQueueAttributesRequest() { }

        /// <summary>
        /// Instantiates GetQueueAttributesRequest with the parameterized properties
        /// </summary>
        /// <param name="queueUrl">The URL of the Amazon SQS queue to take action on. Queue URLs are case-sensitive.</param>
        /// <param name="attributeNames">A list of attributes for which to retrieve information. <note> Going forward, new attributes might be added. If you are writing code that calls this action, we recommend that you structure your code so that it can handle new attributes gracefully. </note> The following attributes are supported: <ul> <li>  <code>All</code> - Returns all values.  </li> <li>  <code>ApproximateNumberOfMessages</code> - Returns the approximate number of visible messages in a queue. For more information, see <a href="http://docs.aws.amazon.com/AWSSimpleQueueService/latest/SQSDeveloperGuide/sqs-resources-required-process-messages.html">Resources Required to Process Messages</a> in the <i>Amazon SQS Developer Guide</i>.  </li> <li>  <code>ApproximateNumberOfMessagesDelayed</code> - Returns the approximate number of messages that are waiting to be added to the queue.  </li> <li>  <code>ApproximateNumberOfMessagesNotVisible</code> - Returns the approximate number of messages that have not timed-out and are not deleted. For more information, see <a href="http://docs.aws.amazon.com/AWSSimpleQueueService/latest/SQSDeveloperGuide/sqs-resources-required-process-messages.html">Resources Required to Process Messages</a> in the <i>Amazon SQS Developer Guide</i>.  </li> <li>  <code>CreatedTimestamp</code> - Returns the time when the queue was created in seconds (epoch time). </li> <li>  <code>DelaySeconds</code> - Returns the default delay on the queue in seconds. </li> <li>  <code>LastModifiedTimestamp</code> - Returns the time when the queue was last changed in seconds (epoch time). </li> <li>  <code>MaximumMessageSize</code> - Returns the limit of how many bytes a message can contain before Amazon SQS rejects it. </li> <li>  <code>MessageRetentionPeriod</code> - Returns the number of seconds for which Amazon SQS retains a message. </li> <li>  <code>Policy</code> - Returns the policy of the queue. </li> <li>  <code>QueueArn</code> - Returns the Amazon resource name (ARN) of the queue. </li> <li>  <code>ReceiveMessageWaitTimeSeconds</code> - Returns the number of seconds for which ReceiveMessage call will wait for a message to arrive.  </li> <li>  <code>RedrivePolicy</code> - Returns the parameters for dead letter queue functionality of the source queue. For more information about the redrive policy and dead letter queues, see <a href="http://docs.aws.amazon.com/AWSSimpleQueueService/latest/SQSDeveloperGuide/sqs-dead-letter-queues.html">Using Amazon SQS Dead Letter Queues</a> in the <i>Amazon SQS Developer Guide</i>.  </li> <li>  <code>VisibilityTimeout</code> - Returns the visibility timeout for the queue. For more information about the visibility timeout, see <a href="http://docs.aws.amazon.com/AWSSimpleQueueService/latest/SQSDeveloperGuide/sqs-visibility-timeout.html">Visibility Timeout</a> in the <i>Amazon SQS Developer Guide</i>.  </li> </ul> The following attributes apply only to <a href="http://docs.aws.amazon.com/AWSSimpleQueueService/latest/SQSDeveloperGuide/FIFO-queues.html">FIFO (first-in-first-out) queues</a>: <ul> <li>  <code>FifoQueue</code> - Returns whether the queue is FIFO. For more information, see <a href="http://docs.aws.amazon.com/AWSSimpleQueueService/latest/SQSDeveloperGuide/FIFO-queues.html#FIFO-queues-understanding-logic">FIFO Queue Logic</a> in the <i>Amazon SQS Developer Guide</i>. </li> <li>  <code>ContentBasedDeduplication</code> - Returns whether content-based deduplication is enabled for the queue. For more information, see <a href="http://docs.aws.amazon.com/AWSSimpleQueueService/latest/SQSDeveloperGuide/FIFO-queues.html#FIFO-queues-exactly-once-processing">Exactly-Once Processing</a> in the <i>Amazon SQS Developer Guide</i>.  </li> </ul></param>
        public GetQueueAttributesRequest(string queueUrl, List<string> attributeNames)
        {
            _queueUrl = queueUrl;
            _attributeNames = attributeNames;
        }

        /// <summary>
        /// Gets and sets the property AttributeNames. 
        /// <para>
        /// A list of attributes for which to retrieve information.
        /// </para>
        ///  <note> 
        /// <para>
        /// Going forward, new attributes might be added. If you are writing code that calls this
        /// action, we recommend that you structure your code so that it can handle new attributes
        /// gracefully.
        /// </para>
        ///  </note> 
        /// <para>
        /// The following attributes are supported:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <code>All</code> - Returns all values. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>ApproximateNumberOfMessages</code> - Returns the approximate number of visible
        /// messages in a queue. For more information, see <a href="http://docs.aws.amazon.com/AWSSimpleQueueService/latest/SQSDeveloperGuide/sqs-resources-required-process-messages.html">Resources
        /// Required to Process Messages</a> in the <i>Amazon SQS Developer Guide</i>. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>ApproximateNumberOfMessagesDelayed</code> - Returns the approximate number
        /// of messages that are waiting to be added to the queue. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>ApproximateNumberOfMessagesNotVisible</code> - Returns the approximate number
        /// of messages that have not timed-out and are not deleted. For more information, see
        /// <a href="http://docs.aws.amazon.com/AWSSimpleQueueService/latest/SQSDeveloperGuide/sqs-resources-required-process-messages.html">Resources
        /// Required to Process Messages</a> in the <i>Amazon SQS Developer Guide</i>. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>CreatedTimestamp</code> - Returns the time when the queue was created in seconds
        /// (epoch time).
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>DelaySeconds</code> - Returns the default delay on the queue in seconds.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>LastModifiedTimestamp</code> - Returns the time when the queue was last changed
        /// in seconds (epoch time).
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>MaximumMessageSize</code> - Returns the limit of how many bytes a message can
        /// contain before Amazon SQS rejects it.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>MessageRetentionPeriod</code> - Returns the number of seconds for which Amazon
        /// SQS retains a message.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>Policy</code> - Returns the policy of the queue.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>QueueArn</code> - Returns the Amazon resource name (ARN) of the queue.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>ReceiveMessageWaitTimeSeconds</code> - Returns the number of seconds for which
        /// ReceiveMessage call will wait for a message to arrive. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>RedrivePolicy</code> - Returns the parameters for dead letter queue functionality
        /// of the source queue. For more information about the redrive policy and dead letter
        /// queues, see <a href="http://docs.aws.amazon.com/AWSSimpleQueueService/latest/SQSDeveloperGuide/sqs-dead-letter-queues.html">Using
        /// Amazon SQS Dead Letter Queues</a> in the <i>Amazon SQS Developer Guide</i>. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>VisibilityTimeout</code> - Returns the visibility timeout for the queue. For
        /// more information about the visibility timeout, see <a href="http://docs.aws.amazon.com/AWSSimpleQueueService/latest/SQSDeveloperGuide/sqs-visibility-timeout.html">Visibility
        /// Timeout</a> in the <i>Amazon SQS Developer Guide</i>. 
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// The following attributes apply only to <a href="http://docs.aws.amazon.com/AWSSimpleQueueService/latest/SQSDeveloperGuide/FIFO-queues.html">FIFO
        /// (first-in-first-out) queues</a>:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <code>FifoQueue</code> - Returns whether the queue is FIFO. For more information,
        /// see <a href="http://docs.aws.amazon.com/AWSSimpleQueueService/latest/SQSDeveloperGuide/FIFO-queues.html#FIFO-queues-understanding-logic">FIFO
        /// Queue Logic</a> in the <i>Amazon SQS Developer Guide</i>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>ContentBasedDeduplication</code> - Returns whether content-based deduplication
        /// is enabled for the queue. For more information, see <a href="http://docs.aws.amazon.com/AWSSimpleQueueService/latest/SQSDeveloperGuide/FIFO-queues.html#FIFO-queues-exactly-once-processing">Exactly-Once
        /// Processing</a> in the <i>Amazon SQS Developer Guide</i>. 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public List<string> AttributeNames
        {
            get { return this._attributeNames; }
            set { this._attributeNames = value; }
        }

        // Check to see if AttributeNames property is set
        internal bool IsSetAttributeNames()
        {
            return this._attributeNames != null && this._attributeNames.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property QueueUrl. 
        /// <para>
        /// The URL of the Amazon SQS queue to take action on.
        /// </para>
        ///  
        /// <para>
        /// Queue URLs are case-sensitive.
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