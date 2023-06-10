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
    /// Container for the parameters to the SetQueueAttributes operation.
    /// Sets the value of one or more queue attributes. When you change a queue's attributes,
    /// the change can take up to 60 seconds for most of the attributes to propagate throughout
    /// the Amazon SQS system. Changes made to the <code>MessageRetentionPeriod</code> attribute
    /// can take up to 15 minutes and will impact existing messages in the queue potentially
    /// causing them to be expired and deleted if the <code>MessageRetentionPeriod</code>
    /// is reduced below the age of existing messages.
    /// 
    ///  <note> <ul> <li> 
    /// <para>
    /// In the future, new attributes might be added. If you write code that calls this action,
    /// we recommend that you structure your code so that it can handle new attributes gracefully.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// Cross-account permissions don't apply to this action. For more information, see <a
    /// href="https://docs.aws.amazon.com/AWSSimpleQueueService/latest/SQSDeveloperGuide/sqs-customer-managed-policy-examples.html#grant-cross-account-permissions-to-role-and-user-name">Grant
    /// cross-account permissions to a role and a username</a> in the <i>Amazon SQS Developer
    /// Guide</i>.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// To remove the ability to change queue permissions, you must deny permission to the
    /// <code>AddPermission</code>, <code>RemovePermission</code>, and <code>SetQueueAttributes</code>
    /// actions in your IAM policy.
    /// </para>
    ///  </li> </ul> </note>
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
        /// <param name="queueUrl">The URL of the Amazon SQS queue whose attributes are set. Queue URLs and names are case-sensitive.</param>
        /// <param name="attributes">A map of attributes to set. The following lists the names, descriptions, and values of the special request parameters that the <code>SetQueueAttributes</code> action uses: <ul> <li>  <code>DelaySeconds</code> – The length of time, in seconds, for which the delivery of all messages in the queue is delayed. Valid values: An integer from 0 to 900 (15 minutes). Default: 0.  </li> <li>  <code>MaximumMessageSize</code> – The limit of how many bytes a message can contain before Amazon SQS rejects it. Valid values: An integer from 1,024 bytes (1 KiB) up to 262,144 bytes (256 KiB). Default: 262,144 (256 KiB).  </li> <li>  <code>MessageRetentionPeriod</code> – The length of time, in seconds, for which Amazon SQS retains a message. Valid values: An integer representing seconds, from 60 (1 minute) to 1,209,600 (14 days). Default: 345,600 (4 days). When you change a queue's attributes, the change can take up to 60 seconds for most of the attributes to propagate throughout the Amazon SQS system. Changes made to the <code>MessageRetentionPeriod</code> attribute can take up to 15 minutes and will impact existing messages in the queue potentially causing them to be expired and deleted if the <code>MessageRetentionPeriod</code> is reduced below the age of existing messages. </li> <li>  <code>Policy</code> – The queue's policy. A valid Amazon Web Services policy. For more information about policy structure, see <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/PoliciesOverview.html">Overview of Amazon Web Services IAM Policies</a> in the <i>Identity and Access Management User Guide</i>.  </li> <li>  <code>ReceiveMessageWaitTimeSeconds</code> – The length of time, in seconds, for which a <code> <a>ReceiveMessage</a> </code> action waits for a message to arrive. Valid values: An integer from 0 to 20 (seconds). Default: 0.  </li> <li>  <code>VisibilityTimeout</code> – The visibility timeout for the queue, in seconds. Valid values: An integer from 0 to 43,200 (12 hours). Default: 30. For more information about the visibility timeout, see <a href="https://docs.aws.amazon.com/AWSSimpleQueueService/latest/SQSDeveloperGuide/sqs-visibility-timeout.html">Visibility Timeout</a> in the <i>Amazon SQS Developer Guide</i>. </li> </ul> The following attributes apply only to <a href="https://docs.aws.amazon.com/AWSSimpleQueueService/latest/SQSDeveloperGuide/sqs-dead-letter-queues.html">dead-letter queues:</a>  <ul> <li>  <code>RedrivePolicy</code> – The string that includes the parameters for the dead-letter queue functionality of the source queue as a JSON object. The parameters are as follows: <ul> <li>  <code>deadLetterTargetArn</code> – The Amazon Resource Name (ARN) of the dead-letter queue to which Amazon SQS moves messages after the value of <code>maxReceiveCount</code> is exceeded. </li> <li>  <code>maxReceiveCount</code> – The number of times a message is delivered to the source queue before being moved to the dead-letter queue. Default: 10. When the <code>ReceiveCount</code> for a message exceeds the <code>maxReceiveCount</code> for a queue, Amazon SQS moves the message to the dead-letter-queue. </li> </ul> </li> <li>  <code>RedriveAllowPolicy</code> – The string that includes the parameters for the permissions for the dead-letter queue redrive permission and which source queues can specify dead-letter queues as a JSON object. The parameters are as follows: <ul> <li>  <code>redrivePermission</code> – The permission type that defines which source queues can specify the current queue as the dead-letter queue. Valid values are: <ul> <li>  <code>allowAll</code> – (Default) Any source queues in this Amazon Web Services account in the same Region can specify this queue as the dead-letter queue. </li> <li>  <code>denyAll</code> – No source queues can specify this queue as the dead-letter queue. </li> <li>  <code>byQueue</code> – Only queues specified by the <code>sourceQueueArns</code> parameter can specify this queue as the dead-letter queue. </li> </ul> </li> <li>  <code>sourceQueueArns</code> – The Amazon Resource Names (ARN)s of the source queues that can specify this queue as the dead-letter queue and redrive messages. You can specify this parameter only when the <code>redrivePermission</code> parameter is set to <code>byQueue</code>. You can specify up to 10 source queue ARNs. To allow more than 10 source queues to specify dead-letter queues, set the <code>redrivePermission</code> parameter to <code>allowAll</code>. </li> </ul> </li> </ul> <note> The dead-letter queue of a FIFO queue must also be a FIFO queue. Similarly, the dead-letter queue of a standard queue must also be a standard queue. </note> The following attributes apply only to <a href="https://docs.aws.amazon.com/AWSSimpleQueueService/latest/SQSDeveloperGuide/sqs-server-side-encryption.html">server-side-encryption</a>: <ul> <li>  <code>KmsMasterKeyId</code> – The ID of an Amazon Web Services managed customer master key (CMK) for Amazon SQS or a custom CMK. For more information, see <a href="https://docs.aws.amazon.com/AWSSimpleQueueService/latest/SQSDeveloperGuide/sqs-server-side-encryption.html#sqs-sse-key-terms">Key Terms</a>. While the alias of the AWS-managed CMK for Amazon SQS is always <code>alias/aws/sqs</code>, the alias of a custom CMK can, for example, be <code>alias/<i>MyAlias</i> </code>. For more examples, see <a href="https://docs.aws.amazon.com/kms/latest/APIReference/API_DescribeKey.html#API_DescribeKey_RequestParameters">KeyId</a> in the <i>Key Management Service API Reference</i>.  </li> <li>  <code>KmsDataKeyReusePeriodSeconds</code> – The length of time, in seconds, for which Amazon SQS can reuse a <a href="https://docs.aws.amazon.com/kms/latest/developerguide/concepts.html#data-keys">data key</a> to encrypt or decrypt messages before calling KMS again. An integer representing seconds, between 60 seconds (1 minute) and 86,400 seconds (24 hours). Default: 300 (5 minutes). A shorter time period provides better security but results in more calls to KMS which might incur charges after Free Tier. For more information, see <a href="https://docs.aws.amazon.com/AWSSimpleQueueService/latest/SQSDeveloperGuide/sqs-server-side-encryption.html#sqs-how-does-the-data-key-reuse-period-work">How Does the Data Key Reuse Period Work?</a>.  </li> <li>  <code>SqsManagedSseEnabled</code> – Enables server-side queue encryption using SQS owned encryption keys. Only one server-side encryption option is supported per queue (for example, <a href="https://docs.aws.amazon.com/AWSSimpleQueueService/latest/SQSDeveloperGuide/sqs-configure-sse-existing-queue.html">SSE-KMS</a> or <a href="https://docs.aws.amazon.com/AWSSimpleQueueService/latest/SQSDeveloperGuide/sqs-configure-sqs-sse-queue.html">SSE-SQS</a>). </li> </ul> The following attribute applies only to <a href="https://docs.aws.amazon.com/AWSSimpleQueueService/latest/SQSDeveloperGuide/FIFO-queues.html">FIFO (first-in-first-out) queues</a>: <ul> <li>  <code>ContentBasedDeduplication</code> – Enables content-based deduplication. For more information, see <a href="https://docs.aws.amazon.com/AWSSimpleQueueService/latest/SQSDeveloperGuide/FIFO-queues-exactly-once-processing.html">Exactly-once processing</a> in the <i>Amazon SQS Developer Guide</i>. Note the following:  <ul> <li> Every message must have a unique <code>MessageDeduplicationId</code>. <ul> <li> You may provide a <code>MessageDeduplicationId</code> explicitly. </li> <li> If you aren't able to provide a <code>MessageDeduplicationId</code> and you enable <code>ContentBasedDeduplication</code> for your queue, Amazon SQS uses a SHA-256 hash to generate the <code>MessageDeduplicationId</code> using the body of the message (but not the attributes of the message).  </li> <li> If you don't provide a <code>MessageDeduplicationId</code> and the queue doesn't have <code>ContentBasedDeduplication</code> set, the action fails with an error. </li> <li> If the queue has <code>ContentBasedDeduplication</code> set, your <code>MessageDeduplicationId</code> overrides the generated one. </li> </ul> </li> <li> When <code>ContentBasedDeduplication</code> is in effect, messages with identical content sent within the deduplication interval are treated as duplicates and only one copy of the message is delivered. </li> <li> If you send one message with <code>ContentBasedDeduplication</code> enabled and then another message with a <code>MessageDeduplicationId</code> that is the same as the one generated for the first <code>MessageDeduplicationId</code>, the two messages are treated as duplicates and only one copy of the message is delivered.  </li> </ul> </li> </ul> The following attributes apply only to <a href="https://docs.aws.amazon.com/AWSSimpleQueueService/latest/SQSDeveloperGuide/high-throughput-fifo.html">high throughput for FIFO queues</a>: <ul> <li>  <code>DeduplicationScope</code> – Specifies whether message deduplication occurs at the message group or queue level. Valid values are <code>messageGroup</code> and <code>queue</code>. </li> <li>  <code>FifoThroughputLimit</code> – Specifies whether the FIFO queue throughput quota applies to the entire queue or per message group. Valid values are <code>perQueue</code> and <code>perMessageGroupId</code>. The <code>perMessageGroupId</code> value is allowed only when the value for <code>DeduplicationScope</code> is <code>messageGroup</code>. </li> </ul> To enable high throughput for FIFO queues, do the following: <ul> <li> Set <code>DeduplicationScope</code> to <code>messageGroup</code>. </li> <li> Set <code>FifoThroughputLimit</code> to <code>perMessageGroupId</code>. </li> </ul> If you set these attributes to anything other than the values shown for enabling high throughput, normal throughput is in effect and deduplication occurs as specified. For information on throughput quotas, see <a href="https://docs.aws.amazon.com/AWSSimpleQueueService/latest/SQSDeveloperGuide/quotas-messages.html">Quotas related to messages</a> in the <i>Amazon SQS Developer Guide</i>.</param>
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
        ///  <code>DelaySeconds</code> – The length of time, in seconds, for which the delivery
        /// of all messages in the queue is delayed. Valid values: An integer from 0 to 900 (15
        /// minutes). Default: 0. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>MaximumMessageSize</code> – The limit of how many bytes a message can contain
        /// before Amazon SQS rejects it. Valid values: An integer from 1,024 bytes (1 KiB) up
        /// to 262,144 bytes (256 KiB). Default: 262,144 (256 KiB). 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>MessageRetentionPeriod</code> – The length of time, in seconds, for which Amazon
        /// SQS retains a message. Valid values: An integer representing seconds, from 60 (1 minute)
        /// to 1,209,600 (14 days). Default: 345,600 (4 days). When you change a queue's attributes,
        /// the change can take up to 60 seconds for most of the attributes to propagate throughout
        /// the Amazon SQS system. Changes made to the <code>MessageRetentionPeriod</code> attribute
        /// can take up to 15 minutes and will impact existing messages in the queue potentially
        /// causing them to be expired and deleted if the <code>MessageRetentionPeriod</code>
        /// is reduced below the age of existing messages.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>Policy</code> – The queue's policy. A valid Amazon Web Services policy. For
        /// more information about policy structure, see <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/PoliciesOverview.html">Overview
        /// of Amazon Web Services IAM Policies</a> in the <i>Identity and Access Management User
        /// Guide</i>. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>ReceiveMessageWaitTimeSeconds</code> – The length of time, in seconds, for
        /// which a <code> <a>ReceiveMessage</a> </code> action waits for a message to arrive.
        /// Valid values: An integer from 0 to 20 (seconds). Default: 0. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>VisibilityTimeout</code> – The visibility timeout for the queue, in seconds.
        /// Valid values: An integer from 0 to 43,200 (12 hours). Default: 30. For more information
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
        ///  <code>RedrivePolicy</code> – The string that includes the parameters for the dead-letter
        /// queue functionality of the source queue as a JSON object. The parameters are as follows:
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
        /// source queue before being moved to the dead-letter queue. Default: 10. When the <code>ReceiveCount</code>
        /// for a message exceeds the <code>maxReceiveCount</code> for a queue, Amazon SQS moves
        /// the message to the dead-letter-queue.
        /// </para>
        ///  </li> </ul> </li> <li> 
        /// <para>
        ///  <code>RedriveAllowPolicy</code> – The string that includes the parameters for the
        /// permissions for the dead-letter queue redrive permission and which source queues can
        /// specify dead-letter queues as a JSON object. The parameters are as follows:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <code>redrivePermission</code> – The permission type that defines which source queues
        /// can specify the current queue as the dead-letter queue. Valid values are:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <code>allowAll</code> – (Default) Any source queues in this Amazon Web Services account
        /// in the same Region can specify this queue as the dead-letter queue.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>denyAll</code> – No source queues can specify this queue as the dead-letter
        /// queue.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>byQueue</code> – Only queues specified by the <code>sourceQueueArns</code>
        /// parameter can specify this queue as the dead-letter queue.
        /// </para>
        ///  </li> </ul> </li> <li> 
        /// <para>
        ///  <code>sourceQueueArns</code> – The Amazon Resource Names (ARN)s of the source queues
        /// that can specify this queue as the dead-letter queue and redrive messages. You can
        /// specify this parameter only when the <code>redrivePermission</code> parameter is set
        /// to <code>byQueue</code>. You can specify up to 10 source queue ARNs. To allow more
        /// than 10 source queues to specify dead-letter queues, set the <code>redrivePermission</code>
        /// parameter to <code>allowAll</code>.
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
        ///  <code>KmsMasterKeyId</code> – The ID of an Amazon Web Services managed customer master
        /// key (CMK) for Amazon SQS or a custom CMK. For more information, see <a href="https://docs.aws.amazon.com/AWSSimpleQueueService/latest/SQSDeveloperGuide/sqs-server-side-encryption.html#sqs-sse-key-terms">Key
        /// Terms</a>. While the alias of the AWS-managed CMK for Amazon SQS is always <code>alias/aws/sqs</code>,
        /// the alias of a custom CMK can, for example, be <code>alias/<i>MyAlias</i> </code>.
        /// For more examples, see <a href="https://docs.aws.amazon.com/kms/latest/APIReference/API_DescribeKey.html#API_DescribeKey_RequestParameters">KeyId</a>
        /// in the <i>Key Management Service API Reference</i>. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>KmsDataKeyReusePeriodSeconds</code> – The length of time, in seconds, for which
        /// Amazon SQS can reuse a <a href="https://docs.aws.amazon.com/kms/latest/developerguide/concepts.html#data-keys">data
        /// key</a> to encrypt or decrypt messages before calling KMS again. An integer representing
        /// seconds, between 60 seconds (1 minute) and 86,400 seconds (24 hours). Default: 300
        /// (5 minutes). A shorter time period provides better security but results in more calls
        /// to KMS which might incur charges after Free Tier. For more information, see <a href="https://docs.aws.amazon.com/AWSSimpleQueueService/latest/SQSDeveloperGuide/sqs-server-side-encryption.html#sqs-how-does-the-data-key-reuse-period-work">How
        /// Does the Data Key Reuse Period Work?</a>. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>SqsManagedSseEnabled</code> – Enables server-side queue encryption using SQS
        /// owned encryption keys. Only one server-side encryption option is supported per queue
        /// (for example, <a href="https://docs.aws.amazon.com/AWSSimpleQueueService/latest/SQSDeveloperGuide/sqs-configure-sse-existing-queue.html">SSE-KMS</a>
        /// or <a href="https://docs.aws.amazon.com/AWSSimpleQueueService/latest/SQSDeveloperGuide/sqs-configure-sqs-sse-queue.html">SSE-SQS</a>).
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// The following attribute applies only to <a href="https://docs.aws.amazon.com/AWSSimpleQueueService/latest/SQSDeveloperGuide/FIFO-queues.html">FIFO
        /// (first-in-first-out) queues</a>:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <code>ContentBasedDeduplication</code> – Enables content-based deduplication. For
        /// more information, see <a href="https://docs.aws.amazon.com/AWSSimpleQueueService/latest/SQSDeveloperGuide/FIFO-queues-exactly-once-processing.html">Exactly-once
        /// processing</a> in the <i>Amazon SQS Developer Guide</i>. Note the following: 
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
        /// The following attributes apply only to <a href="https://docs.aws.amazon.com/AWSSimpleQueueService/latest/SQSDeveloperGuide/high-throughput-fifo.html">high
        /// throughput for FIFO queues</a>:
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
        /// throughput, normal throughput is in effect and deduplication occurs as specified.
        /// </para>
        ///  
        /// <para>
        /// For information on throughput quotas, see <a href="https://docs.aws.amazon.com/AWSSimpleQueueService/latest/SQSDeveloperGuide/quotas-messages.html">Quotas
        /// related to messages</a> in the <i>Amazon SQS Developer Guide</i>.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
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
        /// Queue URLs and names are case-sensitive.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
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