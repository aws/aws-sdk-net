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
    /// Container for the parameters to the GetQueueAttributes operation.
    /// Gets attributes for the specified queue.
    /// 
    ///  <note> 
    /// <para>
    /// To determine whether a queue is <a href="https://docs.aws.amazon.com/AWSSimpleQueueService/latest/SQSDeveloperGuide/FIFO-queues.html">FIFO</a>,
    /// you can check whether <c>QueueName</c> ends with the <c>.fifo</c> suffix.
    /// </para>
    ///  </note>
    /// </summary>
    public partial class GetQueueAttributesRequest : AmazonSQSRequest
    {
        private List<string> _attributeNames = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private string _queueUrl;

        /// <summary>
        /// Empty constructor used to set  properties independently even when a simple constructor is available
        /// </summary>
        public GetQueueAttributesRequest() { }

        /// <summary>
        /// Instantiates GetQueueAttributesRequest with the parameterized properties
        /// </summary>
        /// <param name="queueUrl">The URL of the Amazon SQS queue whose attribute information is retrieved. Queue URLs and names are case-sensitive.</param>
        /// <param name="attributeNames">A list of attributes for which to retrieve information. The <c>AttributeNames</c> parameter is optional, but if you don't specify values for this parameter, the request returns empty results. <note> In the future, new attributes might be added. If you write code that calls this action, we recommend that you structure your code so that it can handle new attributes gracefully. </note> The following attributes are supported: <important> The <c>ApproximateNumberOfMessagesDelayed</c>, <c>ApproximateNumberOfMessagesNotVisible</c>, and <c>ApproximateNumberOfMessages</c> metrics may not achieve consistency until at least 1 minute after the producers stop sending messages. This period is required for the queue metadata to reach eventual consistency.  </important> <ul> <li>  <c>All</c> – Returns all values.  </li> <li>  <c>ApproximateNumberOfMessages</c> – Returns the approximate number of messages available for retrieval from the queue. </li> <li>  <c>ApproximateNumberOfMessagesDelayed</c> – Returns the approximate number of messages in the queue that are delayed and not available for reading immediately. This can happen when the queue is configured as a delay queue or when a message has been sent with a delay parameter. </li> <li>  <c>ApproximateNumberOfMessagesNotVisible</c> – Returns the approximate number of messages that are in flight. Messages are considered to be <i>in flight</i> if they have been sent to a client but have not yet been deleted or have not yet reached the end of their visibility window.  </li> <li>  <c>CreatedTimestamp</c> – Returns the time when the queue was created in seconds (<a href="http://en.wikipedia.org/wiki/Unix_time">epoch time</a>). </li> <li>  <c>DelaySeconds</c> – Returns the default delay on the queue in seconds. </li> <li>  <c>LastModifiedTimestamp</c> – Returns the time when the queue was last changed in seconds (<a href="http://en.wikipedia.org/wiki/Unix_time">epoch time</a>). </li> <li>  <c>MaximumMessageSize</c> – Returns the limit of how many bytes a message can contain before Amazon SQS rejects it. </li> <li>  <c>MessageRetentionPeriod</c> – Returns the length of time, in seconds, for which Amazon SQS retains a message. When you change a queue's attributes, the change can take up to 60 seconds for most of the attributes to propagate throughout the Amazon SQS system. Changes made to the <c>MessageRetentionPeriod</c> attribute can take up to 15 minutes and will impact existing messages in the queue potentially causing them to be expired and deleted if the <c>MessageRetentionPeriod</c> is reduced below the age of existing messages. </li> <li>  <c>Policy</c> – Returns the policy of the queue. </li> <li>  <c>QueueArn</c> – Returns the Amazon resource name (ARN) of the queue. </li> <li>  <c>ReceiveMessageWaitTimeSeconds</c> – Returns the length of time, in seconds, for which the <c>ReceiveMessage</c> action waits for a message to arrive.  </li> <li>  <c>VisibilityTimeout</c> – Returns the visibility timeout for the queue. For more information about the visibility timeout, see <a href="https://docs.aws.amazon.com/AWSSimpleQueueService/latest/SQSDeveloperGuide/sqs-visibility-timeout.html">Visibility Timeout</a> in the <i>Amazon SQS Developer Guide</i>.  </li> </ul> The following attributes apply only to <a href="https://docs.aws.amazon.com/AWSSimpleQueueService/latest/SQSDeveloperGuide/sqs-dead-letter-queues.html">dead-letter queues:</a>  <ul> <li>  <c>RedrivePolicy</c> – The string that includes the parameters for the dead-letter queue functionality of the source queue as a JSON object. The parameters are as follows: <ul> <li>  <c>deadLetterTargetArn</c> – The Amazon Resource Name (ARN) of the dead-letter queue to which Amazon SQS moves messages after the value of <c>maxReceiveCount</c> is exceeded. </li> <li>  <c>maxReceiveCount</c> – The number of times a message is delivered to the source queue before being moved to the dead-letter queue. Default: 10. When the <c>ReceiveCount</c> for a message exceeds the <c>maxReceiveCount</c> for a queue, Amazon SQS moves the message to the dead-letter-queue. </li> </ul> </li> <li>  <c>RedriveAllowPolicy</c> – The string that includes the parameters for the permissions for the dead-letter queue redrive permission and which source queues can specify dead-letter queues as a JSON object. The parameters are as follows: <ul> <li>  <c>redrivePermission</c> – The permission type that defines which source queues can specify the current queue as the dead-letter queue. Valid values are: <ul> <li>  <c>allowAll</c> – (Default) Any source queues in this Amazon Web Services account in the same Region can specify this queue as the dead-letter queue. </li> <li>  <c>denyAll</c> – No source queues can specify this queue as the dead-letter queue. </li> <li>  <c>byQueue</c> – Only queues specified by the <c>sourceQueueArns</c> parameter can specify this queue as the dead-letter queue. </li> </ul> </li> <li>  <c>sourceQueueArns</c> – The Amazon Resource Names (ARN)s of the source queues that can specify this queue as the dead-letter queue and redrive messages. You can specify this parameter only when the <c>redrivePermission</c> parameter is set to <c>byQueue</c>. You can specify up to 10 source queue ARNs. To allow more than 10 source queues to specify dead-letter queues, set the <c>redrivePermission</c> parameter to <c>allowAll</c>. </li> </ul> </li> </ul> <note> The dead-letter queue of a FIFO queue must also be a FIFO queue. Similarly, the dead-letter queue of a standard queue must also be a standard queue. </note> The following attributes apply only to <a href="https://docs.aws.amazon.com/AWSSimpleQueueService/latest/SQSDeveloperGuide/sqs-server-side-encryption.html">server-side-encryption</a>: <ul> <li>  <c>KmsMasterKeyId</c> – Returns the ID of an Amazon Web Services managed customer master key (CMK) for Amazon SQS or a custom CMK. For more information, see <a href="https://docs.aws.amazon.com/AWSSimpleQueueService/latest/SQSDeveloperGuide/sqs-server-side-encryption.html#sqs-sse-key-terms">Key Terms</a>.  </li> <li>  <c>KmsDataKeyReusePeriodSeconds</c> – Returns the length of time, in seconds, for which Amazon SQS can reuse a data key to encrypt or decrypt messages before calling KMS again. For more information, see <a href="https://docs.aws.amazon.com/AWSSimpleQueueService/latest/SQSDeveloperGuide/sqs-server-side-encryption.html#sqs-how-does-the-data-key-reuse-period-work">How Does the Data Key Reuse Period Work?</a>.  </li> <li>  <c>SqsManagedSseEnabled</c> – Returns information about whether the queue is using SSE-SQS encryption using SQS owned encryption keys. Only one server-side encryption option is supported per queue (for example, <a href="https://docs.aws.amazon.com/AWSSimpleQueueService/latest/SQSDeveloperGuide/sqs-configure-sse-existing-queue.html">SSE-KMS</a> or <a href="https://docs.aws.amazon.com/AWSSimpleQueueService/latest/SQSDeveloperGuide/sqs-configure-sqs-sse-queue.html">SSE-SQS</a>). </li> </ul> The following attributes apply only to <a href="https://docs.aws.amazon.com/AWSSimpleQueueService/latest/SQSDeveloperGuide/FIFO-queues.html">FIFO (first-in-first-out) queues</a>: <ul> <li>  <c>FifoQueue</c> – Returns information about whether the queue is FIFO. For more information, see <a href="https://docs.aws.amazon.com/AWSSimpleQueueService/latest/SQSDeveloperGuide/FIFO-queues-understanding-logic.html">FIFO queue logic</a> in the <i>Amazon SQS Developer Guide</i>. <note> To determine whether a queue is <a href="https://docs.aws.amazon.com/AWSSimpleQueueService/latest/SQSDeveloperGuide/FIFO-queues.html">FIFO</a>, you can check whether <c>QueueName</c> ends with the <c>.fifo</c> suffix. </note> </li> <li>  <c>ContentBasedDeduplication</c> – Returns whether content-based deduplication is enabled for the queue. For more information, see <a href="https://docs.aws.amazon.com/AWSSimpleQueueService/latest/SQSDeveloperGuide/FIFO-queues-exactly-once-processing.html">Exactly-once processing</a> in the <i>Amazon SQS Developer Guide</i>.  </li> </ul> The following attributes apply only to <a href="https://docs.aws.amazon.com/AWSSimpleQueueService/latest/SQSDeveloperGuide/high-throughput-fifo.html">high throughput for FIFO queues</a>: <ul> <li>  <c>DeduplicationScope</c> – Specifies whether message deduplication occurs at the message group or queue level. Valid values are <c>messageGroup</c> and <c>queue</c>. </li> <li>  <c>FifoThroughputLimit</c> – Specifies whether the FIFO queue throughput quota applies to the entire queue or per message group. Valid values are <c>perQueue</c> and <c>perMessageGroupId</c>. The <c>perMessageGroupId</c> value is allowed only when the value for <c>DeduplicationScope</c> is <c>messageGroup</c>. </li> </ul> To enable high throughput for FIFO queues, do the following: <ul> <li> Set <c>DeduplicationScope</c> to <c>messageGroup</c>. </li> <li> Set <c>FifoThroughputLimit</c> to <c>perMessageGroupId</c>. </li> </ul> If you set these attributes to anything other than the values shown for enabling high throughput, normal throughput is in effect and deduplication occurs as specified. For information on throughput quotas, see <a href="https://docs.aws.amazon.com/AWSSimpleQueueService/latest/SQSDeveloperGuide/quotas-messages.html">Quotas related to messages</a> in the <i>Amazon SQS Developer Guide</i>.</param>
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
        ///  
        /// <para>
        /// The <c>AttributeNames</c> parameter is optional, but if you don't specify values for
        /// this parameter, the request returns empty results.
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
        ///  <important> 
        /// <para>
        /// The <c>ApproximateNumberOfMessagesDelayed</c>, <c>ApproximateNumberOfMessagesNotVisible</c>,
        /// and <c>ApproximateNumberOfMessages</c> metrics may not achieve consistency until at
        /// least 1 minute after the producers stop sending messages. This period is required
        /// for the queue metadata to reach eventual consistency. 
        /// </para>
        ///  </important> <ul> <li> 
        /// <para>
        ///  <c>All</c> – Returns all values. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>ApproximateNumberOfMessages</c> – Returns the approximate number of messages available
        /// for retrieval from the queue.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>ApproximateNumberOfMessagesDelayed</c> – Returns the approximate number of messages
        /// in the queue that are delayed and not available for reading immediately. This can
        /// happen when the queue is configured as a delay queue or when a message has been sent
        /// with a delay parameter.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>ApproximateNumberOfMessagesNotVisible</c> – Returns the approximate number of
        /// messages that are in flight. Messages are considered to be <i>in flight</i> if they
        /// have been sent to a client but have not yet been deleted or have not yet reached the
        /// end of their visibility window. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>CreatedTimestamp</c> – Returns the time when the queue was created in seconds
        /// (<a href="http://en.wikipedia.org/wiki/Unix_time">epoch time</a>).
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>DelaySeconds</c> – Returns the default delay on the queue in seconds.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>LastModifiedTimestamp</c> – Returns the time when the queue was last changed in
        /// seconds (<a href="http://en.wikipedia.org/wiki/Unix_time">epoch time</a>).
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>MaximumMessageSize</c> – Returns the limit of how many bytes a message can contain
        /// before Amazon SQS rejects it.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>MessageRetentionPeriod</c> – Returns the length of time, in seconds, for which
        /// Amazon SQS retains a message. When you change a queue's attributes, the change can
        /// take up to 60 seconds for most of the attributes to propagate throughout the Amazon
        /// SQS system. Changes made to the <c>MessageRetentionPeriod</c> attribute can take up
        /// to 15 minutes and will impact existing messages in the queue potentially causing them
        /// to be expired and deleted if the <c>MessageRetentionPeriod</c> is reduced below the
        /// age of existing messages.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>Policy</c> – Returns the policy of the queue.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>QueueArn</c> – Returns the Amazon resource name (ARN) of the queue.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>ReceiveMessageWaitTimeSeconds</c> – Returns the length of time, in seconds, for
        /// which the <c>ReceiveMessage</c> action waits for a message to arrive. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>VisibilityTimeout</c> – Returns the visibility timeout for the queue. For more
        /// information about the visibility timeout, see <a href="https://docs.aws.amazon.com/AWSSimpleQueueService/latest/SQSDeveloperGuide/sqs-visibility-timeout.html">Visibility
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
        ///  <c>KmsMasterKeyId</c> – Returns the ID of an Amazon Web Services managed customer
        /// master key (CMK) for Amazon SQS or a custom CMK. For more information, see <a href="https://docs.aws.amazon.com/AWSSimpleQueueService/latest/SQSDeveloperGuide/sqs-server-side-encryption.html#sqs-sse-key-terms">Key
        /// Terms</a>. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>KmsDataKeyReusePeriodSeconds</c> – Returns the length of time, in seconds, for
        /// which Amazon SQS can reuse a data key to encrypt or decrypt messages before calling
        /// KMS again. For more information, see <a href="https://docs.aws.amazon.com/AWSSimpleQueueService/latest/SQSDeveloperGuide/sqs-server-side-encryption.html#sqs-how-does-the-data-key-reuse-period-work">How
        /// Does the Data Key Reuse Period Work?</a>. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>SqsManagedSseEnabled</c> – Returns information about whether the queue is using
        /// SSE-SQS encryption using SQS owned encryption keys. Only one server-side encryption
        /// option is supported per queue (for example, <a href="https://docs.aws.amazon.com/AWSSimpleQueueService/latest/SQSDeveloperGuide/sqs-configure-sse-existing-queue.html">SSE-KMS</a>
        /// or <a href="https://docs.aws.amazon.com/AWSSimpleQueueService/latest/SQSDeveloperGuide/sqs-configure-sqs-sse-queue.html">SSE-SQS</a>).
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// The following attributes apply only to <a href="https://docs.aws.amazon.com/AWSSimpleQueueService/latest/SQSDeveloperGuide/FIFO-queues.html">FIFO
        /// (first-in-first-out) queues</a>:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>FifoQueue</c> – Returns information about whether the queue is FIFO. For more
        /// information, see <a href="https://docs.aws.amazon.com/AWSSimpleQueueService/latest/SQSDeveloperGuide/FIFO-queues-understanding-logic.html">FIFO
        /// queue logic</a> in the <i>Amazon SQS Developer Guide</i>.
        /// </para>
        ///  <note> 
        /// <para>
        /// To determine whether a queue is <a href="https://docs.aws.amazon.com/AWSSimpleQueueService/latest/SQSDeveloperGuide/FIFO-queues.html">FIFO</a>,
        /// you can check whether <c>QueueName</c> ends with the <c>.fifo</c> suffix.
        /// </para>
        ///  </note> </li> <li> 
        /// <para>
        ///  <c>ContentBasedDeduplication</c> – Returns whether content-based deduplication is
        /// enabled for the queue. For more information, see <a href="https://docs.aws.amazon.com/AWSSimpleQueueService/latest/SQSDeveloperGuide/FIFO-queues-exactly-once-processing.html">Exactly-once
        /// processing</a> in the <i>Amazon SQS Developer Guide</i>. 
        /// </para>
        ///  </li> </ul> 
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
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> AttributeNames
        {
            get { return this._attributeNames; }
            set { this._attributeNames = value; }
        }

        // Check to see if AttributeNames property is set
        internal bool IsSetAttributeNames()
        {
            return this._attributeNames != null && (this._attributeNames.Count > 0 || !AWSConfigs.InitializeCollections); 
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