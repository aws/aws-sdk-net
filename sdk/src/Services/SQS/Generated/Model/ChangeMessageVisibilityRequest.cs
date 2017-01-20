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
    /// Container for the parameters to the ChangeMessageVisibility operation.
    /// Changes the visibility timeout of a specified message in a queue to a new value. The
    /// maximum allowed timeout value is 12 hours. Thus, you can't extend the timeout of a
    /// message in an existing queue to more than a total visibility timeout of 12 hours.
    /// For more information, see <a href="http://docs.aws.amazon.com/AWSSimpleQueueService/latest/SQSDeveloperGuide/sqs-visibility-timeout.html">Visibility
    /// Timeout</a> in the <i>Amazon SQS Developer Guide</i>.
    /// 
    ///  
    /// <para>
    /// For example, you have a message and with the default visibility timeout of 5 minutes.
    /// After 3 minutes, you call <code>ChangeMessageVisiblity</code> with a timeout of 10
    /// minutes. At that time, the timeout for the message is extended by 10 minutes beyond
    /// the time of the <code>ChangeMessageVisibility</code> action. This results in a total
    /// visibility timeout of 13 minutes. You can continue to call the <code>ChangeMessageVisibility</code>
    /// to extend the visibility timeout to a maximum of 12 hours. If you try to extend the
    /// visibility timeout beyond 12 hours, your request is rejected.
    /// </para>
    ///  
    /// <para>
    /// A message is considered to be <i>in flight</i> after it's received from a queue by
    /// a consumer, but not yet deleted from the queue.
    /// </para>
    ///  
    /// <para>
    /// For standard queues, there can be a maximum of 120,000 inflight messages per queue.
    /// If you reach this limit, Amazon SQS returns the <code>OverLimit</code> error message.
    /// To avoid reaching the limit, you should delete messages from the queue after they're
    /// processed. You can also increase the number of queues you use to process your messages.
    /// </para>
    ///  
    /// <para>
    /// For FIFO queues, there can be a maximum of 20,000 inflight messages per queue. If
    /// you reach this limit, Amazon SQS returns no error messages.
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
        /// <param name="queueUrl">The URL of the Amazon SQS queue whose message's visibility is changed. Queue URLs are case-sensitive.</param>
        /// <param name="receiptHandle">The receipt handle associated with the message whose visibility timeout is changed. This parameter is returned by the <code> <a>ReceiveMessage</a> </code> action.</param>
        /// <param name="visibilityTimeout">The new value for the message's visibility timeout (in seconds). Values values: <code>0</code> to <code>43200</code>. Maximum: 12 hours.</param>
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

        /// <summary>
        /// Gets and sets the property ReceiptHandle. 
        /// <para>
        /// The receipt handle associated with the message whose visibility timeout is changed.
        /// This parameter is returned by the <code> <a>ReceiveMessage</a> </code> action.
        /// </para>
        /// </summary>
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
        /// The new value for the message's visibility timeout (in seconds). Values values: <code>0</code>
        /// to <code>43200</code>. Maximum: 12 hours.
        /// </para>
        /// </summary>
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