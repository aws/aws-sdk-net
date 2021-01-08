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
    /// Container for the parameters to the ChangeMessageVisibility operation.
    /// Changes the visibility timeout of a specified message in a queue to a new value. The
    /// default visibility timeout for a message is 30 seconds. The minimum is 0 seconds.
    /// The maximum is 12 hours. For more information, see <a href="https://docs.aws.amazon.com/AWSSimpleQueueService/latest/SQSDeveloperGuide/sqs-visibility-timeout.html">Visibility
    /// Timeout</a> in the <i>Amazon Simple Queue Service Developer Guide</i>.
    /// 
    ///  
    /// <para>
    /// For example, you have a message with a visibility timeout of 5 minutes. After 3 minutes,
    /// you call <code>ChangeMessageVisibility</code> with a timeout of 10 minutes. You can
    /// continue to call <code>ChangeMessageVisibility</code> to extend the visibility timeout
    /// to the maximum allowed time. If you try to extend the visibility timeout beyond the
    /// maximum, your request is rejected.
    /// </para>
    ///  
    /// <para>
    /// An Amazon SQS message has three basic states:
    /// </para>
    ///  <ol> <li> 
    /// <para>
    /// Sent to a queue by a producer.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// Received from the queue by a consumer.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// Deleted from the queue.
    /// </para>
    ///  </li> </ol> 
    /// <para>
    /// A message is considered to be <i>stored</i> after it is sent to a queue by a producer,
    /// but not yet received from the queue by a consumer (that is, between states 1 and 2).
    /// There is no limit to the number of stored messages. A message is considered to be
    /// <i>in flight</i> after it is received from a queue by a consumer, but not yet deleted
    /// from the queue (that is, between states 2 and 3). There is a limit to the number of
    /// inflight messages.
    /// </para>
    ///  
    /// <para>
    /// Limits that apply to inflight messages are unrelated to the <i>unlimited</i> number
    /// of stored messages.
    /// </para>
    ///  
    /// <para>
    /// For most standard queues (depending on queue traffic and message backlog), there can
    /// be a maximum of approximately 120,000 inflight messages (received from a queue by
    /// a consumer, but not yet deleted from the queue). If you reach this limit, Amazon SQS
    /// returns the <code>OverLimit</code> error message. To avoid reaching the limit, you
    /// should delete messages from the queue after they're processed. You can also increase
    /// the number of queues you use to process your messages. To request a limit increase,
    /// <a href="https://console.aws.amazon.com/support/home#/case/create?issueType=service-limit-increase&amp;limitType=service-code-sqs">file
    /// a support request</a>.
    /// </para>
    ///  
    /// <para>
    /// For FIFO queues, there can be a maximum of 20,000 inflight messages (received from
    /// a queue by a consumer, but not yet deleted from the queue). If you reach this limit,
    /// Amazon SQS returns no error messages.
    /// </para>
    ///  <important> 
    /// <para>
    /// If you attempt to set the <code>VisibilityTimeout</code> to a value greater than the
    /// maximum time left, Amazon SQS returns an error. Amazon SQS doesn't automatically recalculate
    /// and increase the timeout to the maximum remaining time.
    /// </para>
    ///  
    /// <para>
    /// Unlike with a queue, when you change the visibility timeout for a specific message
    /// the timeout value is applied immediately but isn't saved in memory for that message.
    /// If you don't delete a message after it is received, the visibility timeout for the
    /// message reverts to the original timeout value (not to the value you set using the
    /// <code>ChangeMessageVisibility</code> action) the next time the message is received.
    /// </para>
    ///  </important>
    /// </summary>
    public partial class ChangeMessageVisibilityRequest : AmazonSQSRequest
    {
        private string _queueUrl;
        private string _receiptHandle;
        private int? _visibilityTimeout;

        /// <summary>
        /// Empty constructor used to set  properties independently even when a simple constructor is available
        /// </summary>
        public ChangeMessageVisibilityRequest() { }

        /// <summary>
        /// Instantiates ChangeMessageVisibilityRequest with the parameterized properties
        /// </summary>
        /// <param name="queueUrl">The URL of the Amazon SQS queue whose message's visibility is changed. Queue URLs and names are case-sensitive.</param>
        /// <param name="receiptHandle">The receipt handle associated with the message whose visibility timeout is changed. This parameter is returned by the <code> <a>ReceiveMessage</a> </code> action.</param>
        /// <param name="visibilityTimeout">The new value for the message's visibility timeout (in seconds). Values range: <code>0</code> to <code>43200</code>. Maximum: 12 hours.</param>
        public ChangeMessageVisibilityRequest(string queueUrl, string receiptHandle, int visibilityTimeout)
        {
            _queueUrl = queueUrl;
            _receiptHandle = receiptHandle;
            _visibilityTimeout = visibilityTimeout;
        }

        /// <summary>
        /// Gets and sets the property QueueUrl. 
        /// <para>
        /// The URL of the Amazon SQS queue whose message's visibility is changed.
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

        /// <summary>
        /// Gets and sets the property ReceiptHandle. 
        /// <para>
        /// The receipt handle associated with the message whose visibility timeout is changed.
        /// This parameter is returned by the <code> <a>ReceiveMessage</a> </code> action.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string ReceiptHandle
        {
            get { return this._receiptHandle; }
            set { this._receiptHandle = value; }
        }

        // Check to see if ReceiptHandle property is set
        internal bool IsSetReceiptHandle()
        {
            return this._receiptHandle != null;
        }

        /// <summary>
        /// Gets and sets the property VisibilityTimeout. 
        /// <para>
        /// The new value for the message's visibility timeout (in seconds). Values range: <code>0</code>
        /// to <code>43200</code>. Maximum: 12 hours.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public int VisibilityTimeout
        {
            get { return this._visibilityTimeout.GetValueOrDefault(); }
            set { this._visibilityTimeout = value; }
        }

        // Check to see if VisibilityTimeout property is set
        internal bool IsSetVisibilityTimeout()
        {
            return this._visibilityTimeout.HasValue; 
        }

    }
}