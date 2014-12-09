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
    /// Container for the parameters to the DeleteQueue operation.
    /// Deletes the queue specified by the <b>queue URL</b>, regardless of whether the queue
    /// is empty. If the specified queue does not exist, Amazon SQS returns a successful response.
    /// 
    /// 
    ///  <important> 
    /// <para>
    ///  Use <code>DeleteQueue</code> with care; once you delete your queue, any messages
    /// in the queue are no longer available. 
    /// </para>
    ///  </important> 
    /// <para>
    ///  When you delete a queue, the deletion process takes up to 60 seconds. Requests you
    /// send involving that queue during the 60 seconds might succeed. For example, a <a>SendMessage</a>
    /// request might succeed, but after the 60 seconds, the queue and that message you sent
    /// no longer exist. Also, when you delete a queue, you must wait at least 60 seconds
    /// before creating a queue with the same name. 
    /// </para>
    ///  
    /// <para>
    ///  We reserve the right to delete queues that have had no activity for more than 30
    /// days. For more information, see <a href="http://docs.aws.amazon.com/AWSSimpleQueueService/latest/SQSDeveloperGuide/SQSConcepts.html">How
    /// Amazon SQS Queues Work</a> in the <i>Amazon SQS Developer Guide</i>. 
    /// </para>
    /// </summary>
    public partial class DeleteQueueRequest : AmazonSQSRequest
    {
        private string _queueUrl;

        /// <summary>
        /// Empty constructor used to set  properties independently even when a simple constructor is available
        /// </summary>
        public DeleteQueueRequest() { }

        /// <summary>
        /// Instantiates DeleteQueueRequest with the parameterized properties
        /// </summary>
        /// <param name="queueUrl">The URL of the Amazon SQS queue to take action on.</param>
        public DeleteQueueRequest(string queueUrl)
        {
            _queueUrl = queueUrl;
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

    }
}