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

#pragma warning disable CS0612,CS0618,CS1570
namespace Amazon.SQS.Model
{
    /// <summary>
    /// Container for the parameters to the CreateQueue operation.
    /// Creates a new standard or FIFO queue. You can pass one or more attributes in the request.
    /// Keep the following in mind:
    /// 
    ///  <ul> <li> 
    /// <para>
    /// If you don't specify the <c>FifoQueue</c> attribute, Amazon SQS creates a standard
    /// queue.
    /// </para>
    ///  <note> 
    /// <para>
    /// You can't change the queue type after you create it and you can't convert an existing
    /// standard queue into a FIFO queue. You must either create a new FIFO queue for your
    /// application or delete your existing standard queue and recreate it as a FIFO queue.
    /// For more information, see <a href="https://docs.aws.amazon.com/AWSSimpleQueueService/latest/SQSDeveloperGuide/FIFO-queues.html#FIFO-queues-moving">Moving
    /// From a Standard Queue to a FIFO Queue</a> in the <i>Amazon SQS Developer Guide</i>.
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
    /// To get the queue URL, use the <c> <a>GetQueueUrl</a> </c> action. <c> <a>GetQueueUrl</a>
    /// </c> requires only the <c>QueueName</c> parameter. be aware of existing queue names:
    /// </para>
    ///  <ul> <li> 
    /// <para>
    /// If you provide the name of an existing queue along with the exact names and values
    /// of all the queue's attributes, <c>CreateQueue</c> returns the queue URL for the existing
    /// queue.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// If the queue name, attribute names, or attribute values don't match an existing queue,
    /// <c>CreateQueue</c> returns an error.
    /// </para>
    ///  </li> </ul> <note> 
    /// <para>
    /// Cross-account permissions don't apply to this action. For more information, see <a
    /// href="https://docs.aws.amazon.com/AWSSimpleQueueService/latest/SQSDeveloperGuide/sqs-customer-managed-policy-examples.html#grant-cross-account-permissions-to-role-and-user-name">Grant
    /// cross-account permissions to a role and a username</a> in the <i>Amazon SQS Developer
    /// Guide</i>.
    /// </para>
    ///  </note>
    /// </summary>
    public partial class CreateQueueRequest : AmazonSQSRequest
    {
        private Dictionary<string, string> _attributes = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;
        private string _queueName;
        private Dictionary<string, string> _tags = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;

        /// <summary>
        /// Empty constructor used to set  properties independently even when a simple constructor is available
        /// </summary>
        public CreateQueueRequest() { }

        /// <summary>
        /// Instantiates CreateQueueRequest with the parameterized properties
        /// </summary>
        /// <param name="queueName">The name of the new queue. The following limits apply to this name: <ul> <li> A queue name can have up to 80 characters. </li> <li> Valid values: alphanumeric characters, hyphens (<c>-</c>), and underscores (<c>_</c>). </li> <li> A FIFO queue name must end with the <c>.fifo</c> suffix. </li> </ul> Queue URLs and names are case-sensitive.</param>
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
        /// that the <c>CreateQueue</c> action uses:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>DelaySeconds</c> – The length of time, in seconds, for which the delivery of all
        /// messages in the queue is delayed. Valid values: An integer from 0 to 900 seconds (15
        /// minutes). Default: 0. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>MaximumMessageSize</c> – The limit of how many bytes a message can contain before
        /// Amazon SQS rejects it. Valid values: An integer from 1,024 bytes (1 KiB) to 262,144
        /// bytes (256 KiB). Default: 262,144 (256 KiB). 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>MessageRetentionPeriod</c> – The length of time, in seconds, for which Amazon
        /// SQS retains a message. Valid values: An integer from 60 seconds (1 minute) to 1,209,600
        /// seconds (14 days). Default: 345,600 (4 days). When you change a queue's attributes,
        /// the change can take up to 60 seconds for most of the attributes to propagate throughout
        /// the Amazon SQS system. Changes made to the <c>MessageRetentionPeriod</c> attribute
        /// can take up to 15 minutes and will impact existing messages in the queue potentially
        /// causing them to be expired and deleted if the <c>MessageRetentionPeriod</c> is reduced
        /// below the age of existing messages.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>Policy</c> – The queue's policy. A valid Amazon Web Services policy. For more
        /// information about policy structure, see <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/PoliciesOverview.html">Overview
        /// of Amazon Web Services IAM Policies</a> in the <i>IAM User Guide</i>. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>ReceiveMessageWaitTimeSeconds</c> – The length of time, in seconds, for which
        /// a <c> <a>ReceiveMessage</a> </c> action waits for a message to arrive. Valid values:
        /// An integer from 0 to 20 (seconds). Default: 0. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>VisibilityTimeout</c> – The visibility timeout for the queue, in seconds. Valid
        /// values: An integer from 0 to 43,200 (12 hours). Default: 30. For more information
        /// about the visibility timeout, see <a href="https://docs.aws.amazon.com/AWSSimpleQueueService/latest/SQSDeveloperGuide/sqs-visibility-timeout.html">Visibility
        /// Timeout</a> in the <i>Amazon SQS Developer Guide</i>.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// The following attributes apply only to <a href="https://docs.aws.amazon.com/AWSSimpleQueueService/latest/SQSDeveloperGuide/sqs-dead-letter-queues.html">dead-letter
        /// queues:</a> 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>RedrivePolicy</c> – The string that includes the parameters for the dead-letter
        /// queue functionality of the source queue as a JSON object. The parameters are as follows:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>deadLetterTargetArn</c> – The Amazon Resource Name (ARN) of the dead-letter queue
        /// to which Amazon SQS moves messages after the value of <c>maxReceiveCount</c> is exceeded.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>maxReceiveCount</c> – The number of times a message is delivered to the source
        /// queue before being moved to the dead-letter queue. Default: 10. When the <c>ReceiveCount</c>
        /// for a message exceeds the <c>maxReceiveCount</c> for a queue, Amazon SQS moves the
        /// message to the dead-letter-queue.
        /// </para>
        ///  </li> </ul> </li> <li> 
        /// <para>
        ///  <c>RedriveAllowPolicy</c> – The string that includes the parameters for the permissions
        /// for the dead-letter queue redrive permission and which source queues can specify dead-letter
        /// queues as a JSON object. The parameters are as follows:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>redrivePermission</c> – The permission type that defines which source queues can
        /// specify the current queue as the dead-letter queue. Valid values are:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>allowAll</c> – (Default) Any source queues in this Amazon Web Services account
        /// in the same Region can specify this queue as the dead-letter queue.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>denyAll</c> – No source queues can specify this queue as the dead-letter queue.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>byQueue</c> – Only queues specified by the <c>sourceQueueArns</c> parameter can
        /// specify this queue as the dead-letter queue.
        /// </para>
        ///  </li> </ul> </li> <li> 
        /// <para>
        ///  <c>sourceQueueArns</c> – The Amazon Resource Names (ARN)s of the source queues that
        /// can specify this queue as the dead-letter queue and redrive messages. You can specify
        /// this parameter only when the <c>redrivePermission</c> parameter is set to <c>byQueue</c>.
        /// You can specify up to 10 source queue ARNs. To allow more than 10 source queues to
        /// specify dead-letter queues, set the <c>redrivePermission</c> parameter to <c>allowAll</c>.
        /// </para>
        ///  </li> </ul> </li> </ul> <note> 
        /// <para>
        /// The dead-letter queue of a FIFO queue must also be a FIFO queue. Similarly, the dead-letter
        /// queue of a standard queue must also be a standard queue.
        /// </para>
        ///  </note> 
        /// <para>
        /// The following attributes apply only to <a href="https://docs.aws.amazon.com/AWSSimpleQueueService/latest/SQSDeveloperGuide/sqs-server-side-encryption.html">server-side-encryption</a>:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>KmsMasterKeyId</c> – The ID of an Amazon Web Services managed customer master
        /// key (CMK) for Amazon SQS or a custom CMK. For more information, see <a href="https://docs.aws.amazon.com/AWSSimpleQueueService/latest/SQSDeveloperGuide/sqs-server-side-encryption.html#sqs-sse-key-terms">Key
        /// Terms</a>. While the alias of the Amazon Web Services managed CMK for Amazon SQS is
        /// always <c>alias/aws/sqs</c>, the alias of a custom CMK can, for example, be <c>alias/<i>MyAlias</i>
        /// </c>. For more examples, see <a href="https://docs.aws.amazon.com/kms/latest/APIReference/API_DescribeKey.html#API_DescribeKey_RequestParameters">KeyId</a>
        /// in the <i>Key Management Service API Reference</i>. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>KmsDataKeyReusePeriodSeconds</c> – The length of time, in seconds, for which Amazon
        /// SQS can reuse a <a href="https://docs.aws.amazon.com/kms/latest/developerguide/concepts.html#data-keys">data
        /// key</a> to encrypt or decrypt messages before calling KMS again. An integer representing
        /// seconds, between 60 seconds (1 minute) and 86,400 seconds (24 hours). Default: 300
        /// (5 minutes). A shorter time period provides better security but results in more calls
        /// to KMS which might incur charges after Free Tier. For more information, see <a href="https://docs.aws.amazon.com/AWSSimpleQueueService/latest/SQSDeveloperGuide/sqs-server-side-encryption.html#sqs-how-does-the-data-key-reuse-period-work">How
        /// Does the Data Key Reuse Period Work?</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>SqsManagedSseEnabled</c> – Enables server-side queue encryption using SQS owned
        /// encryption keys. Only one server-side encryption option is supported per queue (for
        /// example, <a href="https://docs.aws.amazon.com/AWSSimpleQueueService/latest/SQSDeveloperGuide/sqs-configure-sse-existing-queue.html">SSE-KMS</a>
        /// or <a href="https://docs.aws.amazon.com/AWSSimpleQueueService/latest/SQSDeveloperGuide/sqs-configure-sqs-sse-queue.html">SSE-SQS</a>).
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// The following attributes apply only to <a href="https://docs.aws.amazon.com/AWSSimpleQueueService/latest/SQSDeveloperGuide/FIFO-queues.html">FIFO
        /// (first-in-first-out) queues</a>:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>FifoQueue</c> – Designates a queue as FIFO. Valid values are <c>true</c> and <c>false</c>.
        /// If you don't specify the <c>FifoQueue</c> attribute, Amazon SQS creates a standard
        /// queue. You can provide this attribute only during queue creation. You can't change
        /// it for an existing queue. When you set this attribute, you must also provide the <c>MessageGroupId</c>
        /// for your messages explicitly.
        /// </para>
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/AWSSimpleQueueService/latest/SQSDeveloperGuide/FIFO-queues-understanding-logic.html">FIFO
        /// queue logic</a> in the <i>Amazon SQS Developer Guide</i>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>ContentBasedDeduplication</c> – Enables content-based deduplication. Valid values
        /// are <c>true</c> and <c>false</c>. For more information, see <a href="https://docs.aws.amazon.com/AWSSimpleQueueService/latest/SQSDeveloperGuide/FIFO-queues-exactly-once-processing.html">Exactly-once
        /// processing</a> in the <i>Amazon SQS Developer Guide</i>. Note the following: 
        /// </para>
        ///  <ul> <li> 
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
        /// for your queue, Amazon SQS uses a SHA-256 hash to generate the <c>MessageDeduplicationId</c>
        /// using the body of the message (but not the attributes of the message). 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// If you don't provide a <c>MessageDeduplicationId</c> and the queue doesn't have <c>ContentBasedDeduplication</c>
        /// set, the action fails with an error.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// If the queue has <c>ContentBasedDeduplication</c> set, your <c>MessageDeduplicationId</c>
        /// overrides the generated one.
        /// </para>
        ///  </li> </ul> </li> <li> 
        /// <para>
        /// When <c>ContentBasedDeduplication</c> is in effect, messages with identical content
        /// sent within the deduplication interval are treated as duplicates and only one copy
        /// of the message is delivered.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// If you send one message with <c>ContentBasedDeduplication</c> enabled and then another
        /// message with a <c>MessageDeduplicationId</c> that is the same as the one generated
        /// for the first <c>MessageDeduplicationId</c>, the two messages are treated as duplicates
        /// and only one copy of the message is delivered. 
        /// </para>
        ///  </li> </ul> </li> </ul> 
        /// <para>
        /// The following attributes apply only to <a href="https://docs.aws.amazon.com/AWSSimpleQueueService/latest/SQSDeveloperGuide/high-throughput-fifo.html">high
        /// throughput for FIFO queues</a>:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>DeduplicationScope</c> – Specifies whether message deduplication occurs at the
        /// message group or queue level. Valid values are <c>messageGroup</c> and <c>queue</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>FifoThroughputLimit</c> – Specifies whether the FIFO queue throughput quota applies
        /// to the entire queue or per message group. Valid values are <c>perQueue</c> and <c>perMessageGroupId</c>.
        /// The <c>perMessageGroupId</c> value is allowed only when the value for <c>DeduplicationScope</c>
        /// is <c>messageGroup</c>.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// To enable high throughput for FIFO queues, do the following:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Set <c>DeduplicationScope</c> to <c>messageGroup</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Set <c>FifoThroughputLimit</c> to <c>perMessageGroupId</c>.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// If you set these attributes to anything other than the values shown for enabling high
        /// throughput, normal throughput is in effect and deduplication occurs as specified.
        /// </para>
        ///  
        /// <para>
        /// For information on throughput quotas, see <a href="https://docs.aws.amazon.com/AWSSimpleQueueService/latest/SQSDeveloperGuide/quotas-messages.html">Quotas
        /// related to messages</a> in the <i>Amazon SQS Developer Guide</i>.
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
            return this._attributes != null && (this._attributes.Count > 0 || !AWSConfigs.InitializeCollections); 
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
        /// Valid values: alphanumeric characters, hyphens (<c>-</c>), and underscores (<c>_</c>).
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// A FIFO queue name must end with the <c>.fifo</c> suffix.
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
        /// Your Amazon SQS Queues</a> in the <i>Amazon SQS Developer Guide</i>.
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
        /// For a full list of tag restrictions, see <a href="https://docs.aws.amazon.com/AWSSimpleQueueService/latest/SQSDeveloperGuide/sqs-limits.html#limits-queues">Quotas
        /// related to queues</a> in the <i>Amazon SQS Developer Guide</i>.
        /// </para>
        ///  <note> 
        /// <para>
        /// To be able to tag a queue on creation, you must have the <c>sqs:CreateQueue</c> and
        /// <c>sqs:TagQueue</c> permissions.
        /// </para>
        ///  
        /// <para>
        /// Cross-account permissions don't apply to this action. For more information, see <a
        /// href="https://docs.aws.amazon.com/AWSSimpleQueueService/latest/SQSDeveloperGuide/sqs-customer-managed-policy-examples.html#grant-cross-account-permissions-to-role-and-user-name">Grant
        /// cross-account permissions to a role and a username</a> in the <i>Amazon SQS Developer
        /// Guide</i>.
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
            return this._tags != null && (this._tags.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}