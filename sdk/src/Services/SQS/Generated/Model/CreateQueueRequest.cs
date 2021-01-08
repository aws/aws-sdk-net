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
 * Do not modify this file. This file is generated from the sqs-2012-11-05.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.SQS.Model
{
    /// <summary>
    /// Container for the parameters to the CreateQueue operation.
    /// Creates a new standard or FIFO queue. You can pass one or more attributes in the request.
    /// Keep the following in mind:
    /// 
    ///  <ul> <li> 
    /// <para>
    /// If you don't specify the <code>FifoQueue</code> attribute, Amazon SQS creates a standard
    /// queue.
    /// </para>
    ///  <note> 
    /// <para>
    /// You can't change the queue type after you create it and you can't convert an existing
    /// standard queue into a FIFO queue. You must either create a new FIFO queue for your
    /// application or delete your existing standard queue and recreate it as a FIFO queue.
    /// For more information, see <a href="https://docs.aws.amazon.com/AWSSimpleQueueService/latest/SQSDeveloperGuide/FIFO-queues.html#FIFO-queues-moving">Moving
    /// From a Standard Queue to a FIFO Queue</a> in the <i>Amazon Simple Queue Service Developer
    /// Guide</i>. 
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
    /// the <a href="https://docs.aws.amazon.com/AWSSimpleQueueService/latest/SQSDeveloperGuide/limits-queues.html">limits
    /// related to queues</a> and is unique within the scope of your queues.
    /// </para>
    ///  <note> 
    /// <para>
    /// After you create a queue, you must wait at least one second after the queue is created
    /// to be able to use the queue.
    /// </para>
    ///  </note> 
    /// <para>
    /// To get the queue URL, use the <code> <a>GetQueueUrl</a> </code> action. <code> <a>GetQueueUrl</a>
    /// </code> requires only the <code>QueueName</code> parameter. be aware of existing queue
    /// names:
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
    /// Some actions take lists of parameters. These lists are specified using the <code>param.n</code>
    /// notation. Values of <code>n</code> are integers starting from 1. For example, a parameter
    /// list with two elements looks like this:
    /// </para>
    ///  
    /// <para>
    ///  <code>&amp;AttributeName.1=first</code> 
    /// </para>
    ///  
    /// <para>
    ///  <code>&amp;AttributeName.2=second</code> 
    /// </para>
    ///  <note> 
    /// <para>
    /// Cross-account permissions don't apply to this action. For more information, see <a
    /// href="https://docs.aws.amazon.com/AWSSimpleQueueService/latest/SQSDeveloperGuide/sqs-customer-managed-policy-examples.html#grant-cross-account-permissions-to-role-and-user-name">Grant
    /// cross-account permissions to a role and a user name</a> in the <i>Amazon Simple Queue
    /// Service Developer Guide</i>.
    /// </para>
    ///  </note>
    /// </summary>
    public partial class CreateQueueRequest : AmazonSQSRequest
    {
        private Dictionary<string, string> _attributes = new Dictionary<string, string>();
        private string _queueName;
        private Dictionary<string, string> _tags = new Dictionary<string, string>();

        /// <summary>
        /// Empty constructor used to set  properties independently even when a simple constructor is available
        /// </summary>
        public CreateQueueRequest() { }

        /// <summary>
        /// Instantiates CreateQueueRequest with the parameterized properties
        /// </summary>
        /// <param name="queueName">The name of the new queue. The following limits apply to this name: <ul> <li> A queue name can have up to 80 characters. </li> <li> Valid values: alphanumeric characters, hyphens (<code>-</code>), and underscores (<code>_</code>). </li> <li> A FIFO queue name must end with the <code>.fifo</code> suffix. </li> </ul> Queue URLs and names are case-sensitive.</param>
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
        ///  <code>DelaySeconds</code> – The length of time, in seconds, for which the delivery
        /// of all messages in the queue is delayed. Valid values: An integer from 0 to 900 seconds
        /// (15 minutes). Default: 0. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>MaximumMessageSize</code> – The limit of how many bytes a message can contain
        /// before Amazon SQS rejects it. Valid values: An integer from 1,024 bytes (1 KiB) to
        /// 262,144 bytes (256 KiB). Default: 262,144 (256 KiB). 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>MessageRetentionPeriod</code> – The length of time, in seconds, for which Amazon
        /// SQS retains a message. Valid values: An integer from 60 seconds (1 minute) to 1,209,600
        /// seconds (14 days). Default: 345,600 (4 days). 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>Policy</code> – The queue's policy. A valid AWS policy. For more information
        /// about policy structure, see <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/PoliciesOverview.html">Overview
        /// of AWS IAM Policies</a> in the <i>Amazon IAM User Guide</i>. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>ReceiveMessageWaitTimeSeconds</code> – The length of time, in seconds, for
        /// which a <code> <a>ReceiveMessage</a> </code> action waits for a message to arrive.
        /// Valid values: An integer from 0 to 20 (seconds). Default: 0. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>RedrivePolicy</code> – The string that includes the parameters for the dead-letter
        /// queue functionality of the source queue as a JSON object. For more information about
        /// the redrive policy and dead-letter queues, see <a href="https://docs.aws.amazon.com/AWSSimpleQueueService/latest/SQSDeveloperGuide/sqs-dead-letter-queues.html">Using
        /// Amazon SQS Dead-Letter Queues</a> in the <i>Amazon Simple Queue Service Developer
        /// Guide</i>.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <code>deadLetterTargetArn</code> – The Amazon Resource Name (ARN) of the dead-letter
        /// queue to which Amazon SQS moves messages after the value of <code>maxReceiveCount</code>
        /// is exceeded.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>maxReceiveCount</code> – The number of times a message is delivered to the
        /// source queue before being moved to the dead-letter queue. When the <code>ReceiveCount</code>
        /// for a message exceeds the <code>maxReceiveCount</code> for a queue, Amazon SQS moves
        /// the message to the dead-letter-queue.
        /// </para>
        ///  </li> </ul> <note> 
        /// <para>
        /// The dead-letter queue of a FIFO queue must also be a FIFO queue. Similarly, the dead-letter
        /// queue of a standard queue must also be a standard queue.
        /// </para>
        ///  </note> </li> <li> 
        /// <para>
        ///  <code>VisibilityTimeout</code> – The visibility timeout for the queue, in seconds.
        /// Valid values: An integer from 0 to 43,200 (12 hours). Default: 30. For more information
        /// about the visibility timeout, see <a href="https://docs.aws.amazon.com/AWSSimpleQueueService/latest/SQSDeveloperGuide/sqs-visibility-timeout.html">Visibility
        /// Timeout</a> in the <i>Amazon Simple Queue Service Developer Guide</i>.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// The following attributes apply only to <a href="https://docs.aws.amazon.com/AWSSimpleQueueService/latest/SQSDeveloperGuide/sqs-server-side-encryption.html">server-side-encryption</a>:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <code>KmsMasterKeyId</code> – The ID of an AWS-managed customer master key (CMK)
        /// for Amazon SQS or a custom CMK. For more information, see <a href="https://docs.aws.amazon.com/AWSSimpleQueueService/latest/SQSDeveloperGuide/sqs-server-side-encryption.html#sqs-sse-key-terms">Key
        /// Terms</a>. While the alias of the AWS-managed CMK for Amazon SQS is always <code>alias/aws/sqs</code>,
        /// the alias of a custom CMK can, for example, be <code>alias/<i>MyAlias</i> </code>.
        /// For more examples, see <a href="https://docs.aws.amazon.com/kms/latest/APIReference/API_DescribeKey.html#API_DescribeKey_RequestParameters">KeyId</a>
        /// in the <i>AWS Key Management Service API Reference</i>. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>KmsDataKeyReusePeriodSeconds</code> – The length of time, in seconds, for which
        /// Amazon SQS can reuse a <a href="https://docs.aws.amazon.com/kms/latest/developerguide/concepts.html#data-keys">data
        /// key</a> to encrypt or decrypt messages before calling AWS KMS again. An integer representing
        /// seconds, between 60 seconds (1 minute) and 86,400 seconds (24 hours). Default: 300
        /// (5 minutes). A shorter time period provides better security but results in more calls
        /// to KMS which might incur charges after Free Tier. For more information, see <a href="https://docs.aws.amazon.com/AWSSimpleQueueService/latest/SQSDeveloperGuide/sqs-server-side-encryption.html#sqs-how-does-the-data-key-reuse-period-work">How
        /// Does the Data Key Reuse Period Work?</a>. 
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// The following attributes apply only to <a href="https://docs.aws.amazon.com/AWSSimpleQueueService/latest/SQSDeveloperGuide/FIFO-queues.html">FIFO
        /// (first-in-first-out) queues</a>:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <code>FifoQueue</code> – Designates a queue as FIFO. Valid values are <code>true</code>
        /// and <code>false</code>. If you don't specify the <code>FifoQueue</code> attribute,
        /// Amazon SQS creates a standard queue. You can provide this attribute only during queue
        /// creation. You can't change it for an existing queue. When you set this attribute,
        /// you must also provide the <code>MessageGroupId</code> for your messages explicitly.
        /// </para>
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/AWSSimpleQueueService/latest/SQSDeveloperGuide/FIFO-queues.html#FIFO-queues-understanding-logic">FIFO
        /// Queue Logic</a> in the <i>Amazon Simple Queue Service Developer Guide</i>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>ContentBasedDeduplication</code> – Enables content-based deduplication. Valid
        /// values are <code>true</code> and <code>false</code>. For more information, see <a
        /// href="https://docs.aws.amazon.com/AWSSimpleQueueService/latest/SQSDeveloperGuide/FIFO-queues.html#FIFO-queues-exactly-once-processing">Exactly-Once
        /// Processing</a> in the <i>Amazon Simple Queue Service Developer Guide</i>. Note the
        /// following: 
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
        /// If you send one message with <code>ContentBasedDeduplication</code> enabled and then
        /// another message with a <code>MessageDeduplicationId</code> that is the same as the
        /// one generated for the first <code>MessageDeduplicationId</code>, the two messages
        /// are treated as duplicates and only one copy of the message is delivered. 
        /// </para>
        ///  </li> </ul> </li> </ul> 
        /// <para>
        ///  <b>Preview: High throughput for FIFO queues</b> 
        /// </para>
        ///  
        /// <para>
        ///  <b>High throughput for Amazon SQS FIFO queues is in preview release and is subject
        /// to change.</b> This feature provides a high number of transactions per second (TPS)
        /// for messages in FIFO queues. For information on throughput quotas, see <a href="https://docs.aws.amazon.com/AWSSimpleQueueService/latest/SQSDeveloperGuide/quotas-messages.html">Quotas
        /// related to messages</a> in the <i>Amazon Simple Queue Service Developer Guide</i>.
        /// </para>
        ///  
        /// <para>
        /// This preview includes two new attributes:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <code>DeduplicationScope</code> – Specifies whether message deduplication occurs
        /// at the message group or queue level. Valid values are <code>messageGroup</code> and
        /// <code>queue</code>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>FifoThroughputLimit</code> – Specifies whether the FIFO queue throughput quota
        /// applies to the entire queue or per message group. Valid values are <code>perQueue</code>
        /// and <code>perMessageGroupId</code>. The <code>perMessageGroupId</code> value is allowed
        /// only when the value for <code>DeduplicationScope</code> is <code>messageGroup</code>.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// To enable high throughput for FIFO queues, do the following:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Set <code>DeduplicationScope</code> to <code>messageGroup</code>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Set <code>FifoThroughputLimit</code> to <code>perMessageGroupId</code>.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// If you set these attributes to anything other than the values shown for enabling high
        /// throughput, standard throughput is in effect and deduplication occurs as specified.
        /// </para>
        ///  
        /// <para>
        /// This preview is available in the following AWS Regions:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// US East (Ohio); us-east-2
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// US East (N. Virginia); us-east-1
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// US West (Oregon); us-west-2
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Europe (Ireland); eu-west-1
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// For more information about high throughput for FIFO queues, see <a href="https://docs.aws.amazon.com/AWSSimpleQueueService/latest/SQSDeveloperGuide/high-throughput-fifo.html">Preview:
        /// High throughput for FIFO queues</a> in the <i>Amazon Simple Queue Service Developer
        /// Guide</i>.
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
        /// Valid values: alphanumeric characters, hyphens (<code>-</code>), and underscores (<code>_</code>).
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// A FIFO queue name must end with the <code>.fifo</code> suffix.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// Queue URLs and names are case-sensitive.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
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

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// Add cost allocation tags to the specified Amazon SQS queue. For an overview, see <a
        /// href="https://docs.aws.amazon.com/AWSSimpleQueueService/latest/SQSDeveloperGuide/sqs-queue-tags.html">Tagging
        /// Your Amazon SQS Queues</a> in the <i>Amazon Simple Queue Service Developer Guide</i>.
        /// </para>
        ///  
        /// <para>
        /// When you use queue tags, keep the following guidelines in mind:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Adding more than 50 tags to a queue isn't recommended.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Tags don't have any semantic meaning. Amazon SQS interprets tags as character strings.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Tags are case-sensitive.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// A new tag with a key identical to that of an existing tag overwrites the existing
        /// tag.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// For a full list of tag restrictions, see <a href="https://docs.aws.amazon.com/AWSSimpleQueueService/latest/SQSDeveloperGuide/sqs-limits.html#limits-queues">Limits
        /// Related to Queues</a> in the <i>Amazon Simple Queue Service Developer Guide</i>.
        /// </para>
        ///  <note> 
        /// <para>
        /// To be able to tag a queue on creation, you must have the <code>sqs:CreateQueue</code>
        /// and <code>sqs:TagQueue</code> permissions.
        /// </para>
        ///  
        /// <para>
        /// Cross-account permissions don't apply to this action. For more information, see <a
        /// href="https://docs.aws.amazon.com/AWSSimpleQueueService/latest/SQSDeveloperGuide/sqs-customer-managed-policy-examples.html#grant-cross-account-permissions-to-role-and-user-name">Grant
        /// cross-account permissions to a role and a user name</a> in the <i>Amazon Simple Queue
        /// Service Developer Guide</i>.
        /// </para>
        ///  </note>
        /// </summary>
        public Dictionary<string, string> Tags
        {
            get { return this._tags; }
            set { this._tags = value; }
        }

        // Check to see if Tags property is set
        internal bool IsSetTags()
        {
            return this._tags != null && this._tags.Count > 0; 
        }

    }
}