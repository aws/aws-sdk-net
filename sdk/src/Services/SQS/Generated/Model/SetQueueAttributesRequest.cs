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
    /// Container for the parameters to the SetQueueAttributes operation.
    /// Sets the value of one or more queue attributes. When you change a queue's attributes,
    /// the change can take up to 60 seconds for most of the attributes to propagate throughout
    /// the Amazon SQS system. Changes made to the <code>MessageRetentionPeriod</code> attribute
    /// can take up to 15 minutes.
    /// 
    ///  <note> 
    /// <para>
    /// In the future, new attributes might be added. If you write code that calls this action,
    /// we recommend that you structure your code so that it can handle new attributes gracefully.
    /// </para>
    ///  </note>
    /// </summary>
    public partial class SetQueueAttributesRequest : AmazonSQSRequest
    {
        private Dictionary<string, string> _attributes = new Dictionary<string, string>();
        private string _queueUrl;

        /// <summary>
        /// Empty constructor used to set  properties independently even when a simple constructor is available
        /// </summary>
        public SetQueueAttributesRequest() { }

        /// <summary>
        /// Instantiates SetQueueAttributesRequest with the parameterized properties
        /// </summary>
        /// <param name="queueUrl">The URL of the Amazon SQS queue whose attributes are set. Queue URLs are case-sensitive.</param>
        /// <param name="attributes">A map of attributes to set. The following lists the names, descriptions, and values of the special request parameters that the <code>SetQueueAttributes</code> action uses: <ul> <li>  <code>DelaySeconds</code> - The number of seconds for which the delivery of all messages in the queue is delayed. Valid values: An integer from 0 to 900 (15 minutes). The default is 0 (zero).  </li> <li>  <code>MaximumMessageSize</code> - The limit of how many bytes a message can contain before Amazon SQS rejects it. Valid values: An integer from 1,024 bytes (1 KiB) up to 262,144 bytes (256 KiB). The default is 262,144 (256 KiB).  </li> <li>  <code>MessageRetentionPeriod</code> - The number of seconds for which Amazon SQS retains a message. Valid values: An integer representing seconds, from 60 (1 minute) to 1,209,600 (14 days). The default is 345,600 (4 days).  </li> <li>  <code>Policy</code> - The queue's policy. A valid AWS policy. For more information about policy structure, see <a href="http://docs.aws.amazon.com/IAM/latest/UserGuide/PoliciesOverview.html">Overview of AWS IAM Policies</a> in the <i>Amazon IAM User Guide</i>.  </li> <li>  <code>ReceiveMessageWaitTimeSeconds</code> - The number of seconds for which a <code> <a>ReceiveMessage</a> </code> action waits for a message to arrive. Valid values: an integer from 0 to 20 (seconds). The default is 0.  </li> <li>  <code>RedrivePolicy</code> - The parameters for the dead letter queue functionality of the source queue. For more information about the redrive policy and dead letter queues, see <a href="http://docs.aws.amazon.com/AWSSimpleQueueService/latest/SQSDeveloperGuide/sqs-dead-letter-queues.html">Using Amazon SQS Dead Letter Queues</a> in the <i>Amazon SQS Developer Guide</i>.  <note> The dead letter queue of a FIFO queue must also be a FIFO queue. Similarly, the dead letter queue of a standard queue must also be a standard queue. </note> </li> <li>  <code>VisibilityTimeout</code> - The visibility timeout for the queue. Valid values: an integer from 0 to 43,200 (12 hours). The default is 30. For more information about the visibility timeout, see <a href="http://docs.aws.amazon.com/AWSSimpleQueueService/latest/SQSDeveloperGuide/sqs-visibility-timeout.html">Visibility Timeout</a> in the <i>Amazon SQS Developer Guide</i>. </li> </ul> The following attribute applies only to <a href="http://docs.aws.amazon.com/AWSSimpleQueueService/latest/SQSDeveloperGuide/FIFO-queues.html">FIFO (first-in-first-out) queues</a>: <ul> <li>  <code>ContentBasedDeduplication</code> - Enables content-based deduplication. For more information, see <a href="http://docs.aws.amazon.com/AWSSimpleQueueService/latest/SQSDeveloperGuide/FIFO-queues.html#FIFO-queues-exactly-once-processing">Exactly-Once Processing</a> in the <i>Amazon SQS Developer Guide</i>.  <ul> <li> Every message must have a unique <code>MessageDeduplicationId</code>, <ul> <li> You may provide a <code>MessageDeduplicationId</code> explicitly. </li> <li> If you aren't able to provide a <code>MessageDeduplicationId</code> and you enable <code>ContentBasedDeduplication</code> for your queue, Amazon SQS uses a SHA-256 hash to generate the <code>MessageDeduplicationId</code> using the body of the message (but not the attributes of the message).  </li> <li> If you don't provide a <code>MessageDeduplicationId</code> and the queue doesn't have <code>ContentBasedDeduplication</code> set, the action fails with an error. </li> <li> If the queue has <code>ContentBasedDeduplication</code> set, your <code>MessageDeduplicationId</code> overrides the generated one. </li> </ul> </li> <li> When <code>ContentBasedDeduplication</code> is in effect, messages with identical content sent within the deduplication interval are treated as duplicates and only one copy of the message is delivered. </li> <li> You can also use <code>ContentBasedDeduplication</code> for messages with identical content to be treated as duplicates. </li> <li> If you send one message with <code>ContentBasedDeduplication</code> enabled and then another message with a <code>MessageDeduplicationId</code> that is the same as the one generated for the first <code>MessageDeduplicationId</code>, the two messages are treated as duplicates and only one copy of the message is delivered.  </li> </ul> </li> </ul> Any other valid special request parameters (such as the following) are ignored: <ul> <li>  <code>ApproximateNumberOfMessages</code>  </li> <li>  <code>ApproximateNumberOfMessagesDelayed</code>  </li> <li>  <code>ApproximateNumberOfMessagesNotVisible</code>  </li> <li>  <code>CreatedTimestamp</code>  </li> <li>  <code>LastModifiedTimestamp</code>  </li> <li>  <code>QueueArn</code>  </li> </ul></param>
        public SetQueueAttributesRequest(string queueUrl, Dictionary<string, string> attributes)
        {
            _queueUrl = queueUrl;
            _attributes = attributes;
        }

        /// <summary>
        /// Gets and sets the property Attributes. 
        /// <para>
        /// A map of attributes to set.
        /// </para>
        ///  
        /// <para>
        /// The following lists the names, descriptions, and values of the special request parameters
        /// that the <code>SetQueueAttributes</code> action uses:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <code>DelaySeconds</code> - The number of seconds for which the delivery of all messages
        /// in the queue is delayed. Valid values: An integer from 0 to 900 (15 minutes). The
        /// default is 0 (zero). 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>MaximumMessageSize</code> - The limit of how many bytes a message can contain
        /// before Amazon SQS rejects it. Valid values: An integer from 1,024 bytes (1 KiB) up
        /// to 262,144 bytes (256 KiB). The default is 262,144 (256 KiB). 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>MessageRetentionPeriod</code> - The number of seconds for which Amazon SQS
        /// retains a message. Valid values: An integer representing seconds, from 60 (1 minute)
        /// to 1,209,600 (14 days). The default is 345,600 (4 days). 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>Policy</code> - The queue's policy. A valid AWS policy. For more information
        /// about policy structure, see <a href="http://docs.aws.amazon.com/IAM/latest/UserGuide/PoliciesOverview.html">Overview
        /// of AWS IAM Policies</a> in the <i>Amazon IAM User Guide</i>. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>ReceiveMessageWaitTimeSeconds</code> - The number of seconds for which a <code>
        /// <a>ReceiveMessage</a> </code> action waits for a message to arrive. Valid values:
        /// an integer from 0 to 20 (seconds). The default is 0. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>RedrivePolicy</code> - The parameters for the dead letter queue functionality
        /// of the source queue. For more information about the redrive policy and dead letter
        /// queues, see <a href="http://docs.aws.amazon.com/AWSSimpleQueueService/latest/SQSDeveloperGuide/sqs-dead-letter-queues.html">Using
        /// Amazon SQS Dead Letter Queues</a> in the <i>Amazon SQS Developer Guide</i>. 
        /// </para>
        ///  <note> 
        /// <para>
        /// The dead letter queue of a FIFO queue must also be a FIFO queue. Similarly, the dead
        /// letter queue of a standard queue must also be a standard queue.
        /// </para>
        ///  </note> </li> <li> 
        /// <para>
        ///  <code>VisibilityTimeout</code> - The visibility timeout for the queue. Valid values:
        /// an integer from 0 to 43,200 (12 hours). The default is 30. For more information about
        /// the visibility timeout, see <a href="http://docs.aws.amazon.com/AWSSimpleQueueService/latest/SQSDeveloperGuide/sqs-visibility-timeout.html">Visibility
        /// Timeout</a> in the <i>Amazon SQS Developer Guide</i>.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// The following attribute applies only to <a href="http://docs.aws.amazon.com/AWSSimpleQueueService/latest/SQSDeveloperGuide/FIFO-queues.html">FIFO
        /// (first-in-first-out) queues</a>:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <code>ContentBasedDeduplication</code> - Enables content-based deduplication. For
        /// more information, see <a href="http://docs.aws.amazon.com/AWSSimpleQueueService/latest/SQSDeveloperGuide/FIFO-queues.html#FIFO-queues-exactly-once-processing">Exactly-Once
        /// Processing</a> in the <i>Amazon SQS Developer Guide</i>. 
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
        /// You can also use <code>ContentBasedDeduplication</code> for messages with identical
        /// content to be treated as duplicates.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// If you send one message with <code>ContentBasedDeduplication</code> enabled and then
        /// another message with a <code>MessageDeduplicationId</code> that is the same as the
        /// one generated for the first <code>MessageDeduplicationId</code>, the two messages
        /// are treated as duplicates and only one copy of the message is delivered. 
        /// </para>
        ///  </li> </ul> </li> </ul> 
        /// <para>
        /// Any other valid special request parameters (such as the following) are ignored:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <code>ApproximateNumberOfMessages</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>ApproximateNumberOfMessagesDelayed</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>ApproximateNumberOfMessagesNotVisible</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>CreatedTimestamp</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>LastModifiedTimestamp</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>QueueArn</code> 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public Dictionary<string, string> Attributes
        {
            get { return this._attributes; }
            set { this._attributes = value; }
        }

        // Check to see if Attributes property is set
        internal bool IsSetAttributes()
        {
            return this._attributes != null && this._attributes.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property QueueUrl. 
        /// <para>
        /// The URL of the Amazon SQS queue whose attributes are set.
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