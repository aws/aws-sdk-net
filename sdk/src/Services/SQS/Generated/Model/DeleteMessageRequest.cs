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
    /// Container for the parameters to the DeleteMessage operation.
    /// Deletes the specified message from the specified queue. To select the message to delete,
    /// use the <c>ReceiptHandle</c> of the message (<i>not</i> the <c>MessageId</c> which
    /// you receive when you send the message). Amazon SQS can delete a message from a queue
    /// even if a visibility timeout setting causes the message to be locked by another consumer.
    /// Amazon SQS automatically deletes messages left in a queue longer than the retention
    /// period configured for the queue. 
    /// 
    ///  <note> 
    /// <para>
    /// Each time you receive a message, meaning when a consumer retrieves a message from
    /// the queue, it comes with a unique <c>ReceiptHandle</c>. If you receive the same message
    /// more than once, you will get a different <c>ReceiptHandle</c> each time. When you
    /// want to delete a message using the <c>DeleteMessage</c> action, you must use the <c>ReceiptHandle</c>
    /// from the most recent time you received the message. If you use an old <c>ReceiptHandle</c>,
    /// the request will succeed, but the message might not be deleted. 
    /// </para>
    ///  
    /// <para>
    /// For standard queues, it is possible to receive a message even after you delete it.
    /// This might happen on rare occasions if one of the servers which stores a copy of the
    /// message is unavailable when you send the request to delete the message. The copy remains
    /// on the server and might be returned to you during a subsequent receive request. You
    /// should ensure that your application is idempotent, so that receiving a message more
    /// than once does not cause issues.
    /// </para>
    ///  </note>
    /// </summary>
    public partial class DeleteMessageRequest : AmazonSQSRequest
    {
        private string _queueUrl;
        private string _receiptHandle;

        /// <summary>
        /// Empty constructor used to set  properties independently even when a simple constructor is available
        /// </summary>
        public DeleteMessageRequest() { }

        /// <summary>
        /// Instantiates DeleteMessageRequest with the parameterized properties
        /// </summary>
        /// <param name="queueUrl">The URL of the Amazon SQS queue from which messages are deleted. Queue URLs and names are case-sensitive.</param>
        /// <param name="receiptHandle">The receipt handle associated with the message to delete.</param>
        public DeleteMessageRequest(string queueUrl, string receiptHandle)
        {
            _queueUrl = queueUrl;
            _receiptHandle = receiptHandle;
        }

        /// <summary>
        /// Gets and sets the property QueueUrl. 
        /// <para>
        /// The URL of the Amazon SQS queue from which messages are deleted.
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
        /// The receipt handle associated with the message to delete.
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

    }
}