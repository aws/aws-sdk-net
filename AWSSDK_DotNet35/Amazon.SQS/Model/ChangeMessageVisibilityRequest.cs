/*
 * Copyright 2010-2013 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
    /// <para>Changes the visibility timeout of a specified message in a queue to a new value. The maximum allowed timeout value you can set the
    /// value to is 12 hours. This means you can't extend the timeout of a message in an existing queue to more than a total visibility timeout of
    /// 12 hours. (For more information visibility timeout, see <a
    /// href="http://docs.aws.amazon.com/AWSSimpleQueueService/latest/SQSDeveloperGuide/AboutVT.html" >Visibility Timeout</a> in the <i>Amazon SQS
    /// Developer Guide</i> .)</para> <para>For example, let's say you have a message and its default message visibility timeout is 30 minutes. You
    /// could call <c>ChangeMessageVisiblity</c> with a value of two hours and the effective timeout would be two hours and 30 minutes. When that
    /// time comes near you could again extend the time out by calling ChangeMessageVisiblity, but this time the maximum allowed timeout would be 9
    /// hours and 30 minutes.</para> <para><b>IMPORTANT:</b>If you attempt to set the VisibilityTimeout to an amount more than the maximum time
    /// left, Amazon SQS returns an error. It will not automatically recalculate and increase the timeout to the maximum time remaining.</para>
    /// <para><b>IMPORTANT:</b>Unlike with a queue, when you change the visibility timeout for a specific message, that timeout value is applied
    /// immediately but is not saved in memory for that message. If you don't delete a message after it is received, the visibility timeout for the
    /// message the next time it is received reverts to the original timeout value, not the value you set with the ChangeMessageVisibility
    /// action.</para>
    /// </summary>
    public partial class ChangeMessageVisibilityRequest : AmazonSQSRequest
    {
        private string queueUrl;
        private string receiptHandle;
        private int? visibilityTimeout;


        /// <summary>
        /// The URL of the Amazon SQS queue to take action on.
        ///  
        /// </summary>
        public string QueueUrl
        {
            get { return this.queueUrl; }
            set { this.queueUrl = value; }
        }

        // Check to see if QueueUrl property is set
        internal bool IsSetQueueUrl()
        {
            return this.queueUrl != null;
        }

        /// <summary>
        /// The receipt handle associated with the message whose visibility timeout should be changed. This parameter is returned by the
        /// <a>ReceiveMessage</a> action.
        ///  
        /// </summary>
        public string ReceiptHandle
        {
            get { return this.receiptHandle; }
            set { this.receiptHandle = value; }
        }

        // Check to see if ReceiptHandle property is set
        internal bool IsSetReceiptHandle()
        {
            return this.receiptHandle != null;
        }

        /// <summary>
        /// The new value (in seconds - from 0 to 43200 - maximum 12 hours) for the message's visibility timeout.
        ///  
        /// </summary>
        public int VisibilityTimeout
        {
            get { return this.visibilityTimeout ?? default(int); }
            set { this.visibilityTimeout = value; }
        }

        // Check to see if VisibilityTimeout property is set
        internal bool IsSetVisibilityTimeout()
        {
            return this.visibilityTimeout.HasValue;
        }

    }
}
    
