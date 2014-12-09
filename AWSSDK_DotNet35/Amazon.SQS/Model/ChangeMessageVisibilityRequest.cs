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
    /// maximum allowed timeout value you can set the value to is 12 hours. This means you
    /// can't extend the timeout of a message in an existing queue to more than a total visibility
    /// timeout of 12 hours. (For more information visibility timeout, see <a href="http://docs.aws.amazon.com/AWSSimpleQueueService/latest/SQSDeveloperGuide/AboutVT.html">Visibility
    /// Timeout</a> in the <i>Amazon SQS Developer Guide</i>.)
    /// 
    ///  
    /// <para>
    /// For example, let's say you have a message and its default message visibility timeout
    /// is 30 minutes. You could call <code>ChangeMessageVisiblity</code> with a value of
    /// two hours and the effective timeout would be two hours and 30 minutes. When that time
    /// comes near you could again extend the time out by calling ChangeMessageVisiblity,
    /// but this time the maximum allowed timeout would be 9 hours and 30 minutes.
    /// </para>
    ///  <note>
    /// <para>
    /// There is a 120,000 limit for the number of inflight messages per queue. Messages are
    /// inflight after they have been received from the queue by a consuming component, but
    /// have not yet been deleted from the queue. If you reach the 120,000 limit, you will
    /// receive an OverLimit error message from Amazon SQS. To help avoid reaching the limit,
    /// you should delete the messages from the queue after they have been processed. You
    /// can also increase the number of queues you use to process the messages. 
    /// </para>
    /// </note> <important>If you attempt to set the <code>VisibilityTimeout</code> to an
    /// amount more than the maximum time left, Amazon SQS returns an error. It will not automatically
    /// recalculate and increase the timeout to the maximum time remaining.</important> <important>Unlike
    /// with a queue, when you change the visibility timeout for a specific message, that
    /// timeout value is applied immediately but is not saved in memory for that message.
    /// If you don't delete a message after it is received, the visibility timeout for the
    /// message the next time it is received reverts to the original timeout value, not the
    /// value you set with the <code>ChangeMessageVisibility</code> action.</important>
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
        /// <param name="queueUrl">The URL of the Amazon SQS queue to take action on.</param>
        /// <param name="receiptHandle">The receipt handle associated with the message whose visibility timeout should be changed. This parameter is returned by the <a>ReceiveMessage</a> action.</param>
        /// <param name="visibilityTimeout">The new value (in seconds - from 0 to 43200 - maximum 12 hours) for the message's visibility timeout.</param>
        public ChangeMessageVisibilityRequest(string queueUrl, string receiptHandle, int visibilityTimeout)
        {
            _queueUrl = queueUrl;
            _receiptHandle = receiptHandle;
            _visibilityTimeout = visibilityTimeout;
        }

        /// <summary>
        /// Gets and sets the property QueueUrl. 
        /// <para>
        /// The URL of the Amazon SQS queue to take action on.
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
        /// The receipt handle associated with the message whose visibility timeout should be
        /// changed. This parameter is returned by the <a>ReceiveMessage</a> action.
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
        /// The new value (in seconds - from 0 to 43200 - maximum 12 hours) for the message's
        /// visibility timeout.
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