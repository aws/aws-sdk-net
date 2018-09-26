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
    /// To determine whether a queue is <a href="http://docs.aws.amazon.com/AWSSimpleQueueService/latest/SQSDeveloperGuide/FIFO-queues.html">FIFO</a>,
    /// you can check whether <code>QueueName</code> ends with the <code>.fifo</code> suffix.
    /// </para>
    ///  </note> 
    /// <para>
    /// Some actions take lists of parameters. These lists are specified using the <code>param.n</code>
    /// notation. Values of <code>n</code> are integers starting from 1. For example, a parameter
    /// list with two elements looks like this:
    /// </para>
    ///  
    /// <para>
    ///  <code>&amp;Attribute.1=first</code> 
    /// </para>
    ///  
    /// <para>
    ///  <code>&amp;Attribute.2=second</code> 
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
        /// <param name="queueUrl">The URL of the Amazon SQS queue whose attribute information is retrieved. Queue URLs and names are case-sensitive.</param>
        /// <param name="attributeNames">A list of attributes for which to retrieve information. <note> In the future, new attributes might be added. If you write code that calls this action, we recommend that you structure your code so that it can handle new attributes gracefully. </note> The following attributes are supported: <ul> <li>  <code>All</code> - Returns all values.  </li> <li>  <code>ApproximateNumberOfMessages</code> - Returns the approximate number of messages available for retrieval from the queue. </li> <li>  <code>ApproximateNumberOfMessagesDelayed</code> - Returns the approximate number of messages in the queue that are delayed and not available for reading immediately. This can happen when the queue is configured as a delay queue or when a message has been sent with a delay parameter. </li> <li>  <code>ApproximateNumberOfMessagesNotVisible</code> - Returns the approximate number of messages that are in flight. Messages are considered to be <i>in flight</i> if they have been sent to a client but have not yet been deleted or have not yet reached the end of their visibility window.  </li> <li>  <code>CreatedTimestamp</code> - Returns the time when the queue was created in seconds (<a href="http://en.wikipedia.org/wiki/Unix_time">epoch time</a>). </li> <li>  <code>DelaySeconds</code> - Returns the default delay on the queue in seconds. </li> <li>  <code>LastModifiedTimestamp</code> - Returns the time when the queue was last changed in seconds (<a href="http://en.wikipedia.org/wiki/Unix_time">epoch time</a>). </li> <li>  <code>MaximumMessageSize</code> - Returns the limit of how many bytes a message can contain before Amazon SQS rejects it. </li> <li>  <code>MessageRetentionPeriod</code> - Returns the length of time, in seconds, for which Amazon SQS retains a message. </li> <li>  <code>Policy</code> - Returns the policy of the queue. </li> <li>  <code>QueueArn</code> - Returns the Amazon resource name (ARN) of the queue. </li> <li>  <code>ReceiveMessageWaitTimeSeconds</code> - Returns the length of time, in seconds, for which the <code>ReceiveMessage</code> action waits for a message to arrive.  </li> <li>  <code>RedrivePolicy</code> - Returns the string that includes the parameters for dead-letter queue functionality of the source queue. For more information about the redrive policy and dead-letter queues, see <a href="http://docs.aws.amazon.com/AWSSimpleQueueService/latest/SQSDeveloperGuide/sqs-dead-letter-queues.html">Using Amazon SQS Dead-Letter Queues</a> in the <i>Amazon Simple Queue Service Developer Guide</i>.  <ul> <li>  <code>deadLetterTargetArn</code> - The Amazon Resource Name (ARN) of the dead-letter queue to which Amazon SQS moves messages after the value of <code>maxReceiveCount</code> is exceeded. </li> <li>  <code>maxReceiveCount</code> - The number of times a message is delivered to the source queue before being moved to the dead-letter queue. When the <code>ReceiveCount</code> for a message exceeds the <code>maxReceiveCount</code> for a queue, Amazon SQS moves the message to the dead-letter-queue. </li> </ul> </li> <li>  <code>VisibilityTimeout</code> - Returns the visibility timeout for the queue. For more information about the visibility timeout, see <a href="http://docs.aws.amazon.com/AWSSimpleQueueService/latest/SQSDeveloperGuide/sqs-visibility-timeout.html">Visibility Timeout</a> in the <i>Amazon Simple Queue Service Developer Guide</i>.  </li> </ul> The following attributes apply only to <a href="http://docs.aws.amazon.com/AWSSimpleQueueService/latest/SQSDeveloperGuide/sqs-server-side-encryption.html">server-side-encryption</a>: <ul> <li>  <code>KmsMasterKeyId</code> - Returns the ID of an AWS-managed customer master key (CMK) for Amazon SQS or a custom CMK. For more information, see <a href="http://docs.aws.amazon.com/AWSSimpleQueueService/latest/SQSDeveloperGuide/sqs-server-side-encryption.html#sqs-sse-key-terms">Key Terms</a>.  </li> <li>  <code>KmsDataKeyReusePeriodSeconds</code> - Returns the length of time, in seconds, for which Amazon SQS can reuse a data key to encrypt or decrypt messages before calling AWS KMS again. For more information, see <a href="http://docs.aws.amazon.com/AWSSimpleQueueService/latest/SQSDeveloperGuide/sqs-server-side-encryption.html#sqs-how-does-the-data-key-reuse-period-work">How Does the Data Key Reuse Period Work?</a>.  </li> </ul> The following attributes apply only to <a href="http://docs.aws.amazon.com/AWSSimpleQueueService/latest/SQSDeveloperGuide/FIFO-queues.html">FIFO (first-in-first-out) queues</a>: <ul> <li>  <code>FifoQueue</code> - Returns whether the queue is FIFO. For more information, see <a href="http://docs.aws.amazon.com/AWSSimpleQueueService/latest/SQSDeveloperGuide/FIFO-queues.html#FIFO-queues-understanding-logic">FIFO Queue Logic</a> in the <i>Amazon Simple Queue Service Developer Guide</i>. <note> To determine whether a queue is <a href="http://docs.aws.amazon.com/AWSSimpleQueueService/latest/SQSDeveloperGuide/FIFO-queues.html">FIFO</a>, you can check whether <code>QueueName</code> ends with the <code>.fifo</code> suffix. </note> </li> <li>  <code>ContentBasedDeduplication</code> - Returns whether content-based deduplication is enabled for the queue. For more information, see <a href="http://docs.aws.amazon.com/AWSSimpleQueueService/latest/SQSDeveloperGuide/FIFO-queues.html#FIFO-queues-exactly-once-processing">Exactly-Once Processing</a> in the <i>Amazon Simple Queue Service Developer Guide</i>.  </li> </ul></param>
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
        /// In the future, new attributes might be added. If you write code that calls this action,
        /// we recommend that you structure your code so that it can handle new attributes gracefully.
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
        ///  <code>ApproximateNumberOfMessages</code> - Returns the approximate number of messages
        /// available for retrieval from the queue.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>ApproximateNumberOfMessagesDelayed</code> - Returns the approximate number
        /// of messages in the queue that are delayed and not available for reading immediately.
        /// This can happen when the queue is configured as a delay queue or when a message has
        /// been sent with a delay parameter.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>ApproximateNumberOfMessagesNotVisible</code> - Returns the approximate number
        /// of messages that are in flight. Messages are considered to be <i>in flight</i> if
        /// they have been sent to a client but have not yet been deleted or have not yet reached
        /// the end of their visibility window. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>CreatedTimestamp</code> - Returns the time when the queue was created in seconds
        /// (<a href="http://en.wikipedia.org/wiki/Unix_time">epoch time</a>).
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>DelaySeconds</code> - Returns the default delay on the queue in seconds.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>LastModifiedTimestamp</code> - Returns the time when the queue was last changed
        /// in seconds (<a href="http://en.wikipedia.org/wiki/Unix_time">epoch time</a>).
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>MaximumMessageSize</code> - Returns the limit of how many bytes a message can
        /// contain before Amazon SQS rejects it.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>MessageRetentionPeriod</code> - Returns the length of time, in seconds, for
        /// which Amazon SQS retains a message.
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
        ///  <code>ReceiveMessageWaitTimeSeconds</code> - Returns the length of time, in seconds,
        /// for which the <code>ReceiveMessage</code> action waits for a message to arrive. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>RedrivePolicy</code> - Returns the string that includes the parameters for
        /// dead-letter queue functionality of the source queue. For more information about the
        /// redrive policy and dead-letter queues, see <a href="http://docs.aws.amazon.com/AWSSimpleQueueService/latest/SQSDeveloperGuide/sqs-dead-letter-queues.html">Using
        /// Amazon SQS Dead-Letter Queues</a> in the <i>Amazon Simple Queue Service Developer
        /// Guide</i>. 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <code>deadLetterTargetArn</code> - The Amazon Resource Name (ARN) of the dead-letter
        /// queue to which Amazon SQS moves messages after the value of <code>maxReceiveCount</code>
        /// is exceeded.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>maxReceiveCount</code> - The number of times a message is delivered to the
        /// source queue before being moved to the dead-letter queue. When the <code>ReceiveCount</code>
        /// for a message exceeds the <code>maxReceiveCount</code> for a queue, Amazon SQS moves
        /// the message to the dead-letter-queue.
        /// </para>
        ///  </li> </ul> </li> <li> 
        /// <para>
        ///  <code>VisibilityTimeout</code> - Returns the visibility timeout for the queue. For
        /// more information about the visibility timeout, see <a href="http://docs.aws.amazon.com/AWSSimpleQueueService/latest/SQSDeveloperGuide/sqs-visibility-timeout.html">Visibility
        /// Timeout</a> in the <i>Amazon Simple Queue Service Developer Guide</i>. 
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// The following attributes apply only to <a href="http://docs.aws.amazon.com/AWSSimpleQueueService/latest/SQSDeveloperGuide/sqs-server-side-encryption.html">server-side-encryption</a>:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <code>KmsMasterKeyId</code> - Returns the ID of an AWS-managed customer master key
        /// (CMK) for Amazon SQS or a custom CMK. For more information, see <a href="http://docs.aws.amazon.com/AWSSimpleQueueService/latest/SQSDeveloperGuide/sqs-server-side-encryption.html#sqs-sse-key-terms">Key
        /// Terms</a>. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>KmsDataKeyReusePeriodSeconds</code> - Returns the length of time, in seconds,
        /// for which Amazon SQS can reuse a data key to encrypt or decrypt messages before calling
        /// AWS KMS again. For more information, see <a href="http://docs.aws.amazon.com/AWSSimpleQueueService/latest/SQSDeveloperGuide/sqs-server-side-encryption.html#sqs-how-does-the-data-key-reuse-period-work">How
        /// Does the Data Key Reuse Period Work?</a>. 
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
        /// Queue Logic</a> in the <i>Amazon Simple Queue Service Developer Guide</i>.
        /// </para>
        ///  <note> 
        /// <para>
        /// To determine whether a queue is <a href="http://docs.aws.amazon.com/AWSSimpleQueueService/latest/SQSDeveloperGuide/FIFO-queues.html">FIFO</a>,
        /// you can check whether <code>QueueName</code> ends with the <code>.fifo</code> suffix.
        /// </para>
        ///  </note> </li> <li> 
        /// <para>
        ///  <code>ContentBasedDeduplication</code> - Returns whether content-based deduplication
        /// is enabled for the queue. For more information, see <a href="http://docs.aws.amazon.com/AWSSimpleQueueService/latest/SQSDeveloperGuide/FIFO-queues.html#FIFO-queues-exactly-once-processing">Exactly-Once
        /// Processing</a> in the <i>Amazon Simple Queue Service Developer Guide</i>. 
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
        /// The URL of the Amazon SQS queue whose attribute information is retrieved.
        /// </para>
        ///  
        /// <para>
        /// Queue URLs and names are case-sensitive.
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