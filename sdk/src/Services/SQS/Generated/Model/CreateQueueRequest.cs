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
    /// Container for the parameters to the CreateQueue operation.
    /// Creates a new standard or FIFO queue or returns the URL of an existing queue. You
    /// can pass one or more attributes in the request.
    /// 
    ///  <ul> <li> 
    /// <para>
    /// If you don't specify the <code>FifoQueue</code> attribute, Amazon SQS creates a standard
    /// queue.
    /// </para>
    ///  <note> 
    /// <para>
    ///  You can't change the queue type after you create it and you can't convert an existing
    /// standard queue into a FIFO queue. You must either create a new FIFO queue for your
    /// application or delete your existing standard queue and recreate it as a FIFO queue.
    /// For more information, see <a href="http://docs.aws.amazon.com/AWSSimpleQueueService/latest/SQSDeveloperGuide/FIFO-queues.html#FIFO-queues-moving">
    /// Moving From a Standard Queue to a FIFO Queue</a> in the <i>Amazon SQS Developer Guide</i>.
    /// 
    /// </para>
    ///  </note> </li> <li> 
    /// <para>
    /// If you don't provide a value for an attribute, the queue is created with the default
    /// value for the attribute.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// If you delete a queue, you must wait at least 60 seconds before creating a queue with
    /// the same name.
    /// </para>
    ///  </li> </ul> 
    /// <para>
    /// To successfully create a new queue, you must provide a queue name that adheres to
    /// the <a href="http://docs.aws.amazon.com/AWSSimpleQueueService/latest/SQSDeveloperGuide/limits-queues.html">limits
    /// related to queues</a> and is unique within the scope of your queues.
    /// </para>
    ///  
    /// <para>
    /// To get the queue URL, use the <a>GetQueueUrl</a> action. <a>GetQueueUrl</a> requires
    /// only the <code>QueueName</code> parameter.
    /// </para>
    ///  <ul> <li> 
    /// <para>
    /// If you provide the name of an existing queue along with the exact names and values
    /// of all the queue's attributes, <code>CreateQueue</code> returns the queue URL for
    /// the existing queue.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// If the queue name, attribute names, or attribute values don't match an existing queue,
    /// <code>CreateQueue</code> returns an error.
    /// </para>
    ///  </li> </ul> 
    /// <para>
    /// Some API actions take lists of parameters. Specify these lists using the <code>param.n</code>
    /// notation. Values of <code>n</code> are integers starting from 1. The following is
    /// an example of a parameter list with two elements:
    /// </para>
    ///  
    /// <para>
    ///  <code>&amp;amp;Attribute.1=this</code> 
    /// </para>
    ///  
    /// <para>
    ///  <code>&amp;amp;Attribute.2=that</code> 
    /// </para>
    /// </summary>
    public partial class CreateQueueRequest : AmazonSQSRequest
    {
        private Dictionary<string, string> _attributes = new Dictionary<string, string>();
        private string _queueName;

        /// <summary>
        /// Empty constructor used to set  properties independently even when a simple constructor is available
        /// </summary>
        public CreateQueueRequest() { }

        /// <summary>
        /// Instantiates CreateQueueRequest with the parameterized properties
        /// </summary>
        /// <param name="queueName">The name of the new queue. The following limits apply to this name: <ul> <li> A queue name can have up to 80 characters. </li> <li> The following are accepted: alphanumeric chatacters, hyphens (<code>-</code>), and underscores (<code>_</code>). </li> <li> A FIFO queue name must end with the <code>.fifo</code> suffix. </li> </ul> Queue names are case-sensitive.</param>
        public CreateQueueRequest(string queueName)
        {
            _queueName = queueName;
        }

        /// <summary>
        /// Gets and sets the property Attributes. 
        /// <para>
        /// A map of attributes with their corresponding values.
        /// </para>
        ///  
        /// <para>
        /// The following lists the names, descriptions, and values of the special request parameters
        /// that the <code>CreateQueue</code> action uses:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <code>DelaySeconds</code> - The number of seconds for which the delivery of all messages
        /// in the queue is delayed. An integer from 0 to 900 (15 minutes). The default is 0 (zero).
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>MaximumMessageSize</code> - The limit of how many bytes a message can contain
        /// before Amazon SQS rejects it. An integer from 1,024 bytes (1 KiB) up to 262,144 bytes
        /// (256 KiB). The default is 262,144 (256 KiB). 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>MessageRetentionPeriod</code> - The number of seconds for which Amazon SQS
        /// retains a message. An integer representing seconds, from 60 (1 minute) to 120,9600
        /// (14 days). The default is 345,600 (4 days). 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>Policy</code> - The queue's policy. A valid AWS policy. For more information
        /// about policy structure, see <a href="http://docs.aws.amazon.com/IAM/latest/UserGuide/PoliciesOverview.html">Overview
        /// of AWS IAM Policies</a> in the <i>Amazon IAM User Guide</i>. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>ReceiveMessageWaitTimeSeconds</code> - The number of seconds for which a <a>ReceiveMessage</a>
        /// action will wait for a message to arrive. An integer from 0 to 20 (seconds). The default
        /// is 0. 
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
        ///  <code>VisibilityTimeout</code> - The visibility timeout for the queue. An integer
        /// from 0 to 43200 (12 hours). The default is 30. For more information about the visibility
        /// timeout, see <a href="http://docs.aws.amazon.com/AWSSimpleQueueService/latest/SQSDeveloperGuide/sqs-visibility-timeout.html">Visibility
        /// Timeout</a> in the <i>Amazon SQS Developer Guide</i>.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// The following attributes apply only to <a href="http://docs.aws.amazon.com/AWSSimpleQueueService/latest/SQSDeveloperGuide/FIFO-queues.html">FIFO
        /// (first-in-first-out) queues</a>:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <code>FifoQueue</code> - Designates a queue as FIFO. You can provide this attribute
        /// only during queue creation; you can't change it for an existing queue. When you set
        /// this attribute, you must provide a <code>MessageGroupId</code> explicitly.
        /// </para>
        ///  
        /// <para>
        /// For more information, see <a href="http://docs.aws.amazon.com/AWSSimpleQueueService/latest/SQSDeveloperGuide/FIFO-queues.html#FIFO-queues-understanding-logic">FIFO
        /// Queue Logic</a> in the <i>Amazon SQS Developer Guide</i>.
        /// </para>
        ///  </li> <li> 
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
        /// Any other valid special request parameters that are specified (such as <code>ApproximateNumberOfMessages</code>,
        /// <code>ApproximateNumberOfMessagesDelayed</code>, <code>ApproximateNumberOfMessagesNotVisible</code>,
        /// <code>CreatedTimestamp</code>, <code>LastModifiedTimestamp</code>, and <code>QueueArn</code>)
        /// will be ignored.
        /// </para>
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
        /// Gets and sets the property QueueName. 
        /// <para>
        /// The name of the new queue. The following limits apply to this name:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// A queue name can have up to 80 characters.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The following are accepted: alphanumeric chatacters, hyphens (<code>-</code>), and
        /// underscores (<code>_</code>).
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// A FIFO queue name must end with the <code>.fifo</code> suffix.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// Queue names are case-sensitive.
        /// </para>
        /// </summary>
        public string QueueName
        {
            get { return this._queueName; }
            set { this._queueName = value; }
        }

        // Check to see if QueueName property is set
        internal bool IsSetQueueName()
        {
            return this._queueName != null;
        }

    }
}