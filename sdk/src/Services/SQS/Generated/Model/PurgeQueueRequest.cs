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
    /// Container for the parameters to the PurgeQueue operation.
    /// Deletes the messages in a queue specified by the <code>QueueURL</code> parameter.
    /// 
    ///  <important> 
    /// <para>
    /// When you use the <code>PurgeQueue</code> action, you can't retrieve a message deleted
    /// from a queue.
    /// </para>
    ///  </important> 
    /// <para>
    /// When you purge a queue, the message deletion process takes up to 60 seconds. All messages
    /// sent to the queue before calling the <code>PurgeQueue</code> action are deleted. Messages
    /// sent to the queue while it is being purged might be deleted. While the queue is being
    /// purged, messages sent to the queue before <code>PurgeQueue</code> is called might
    /// be received, but are deleted within the next minute.
    /// </para>
    /// </summary>
    public partial class PurgeQueueRequest : AmazonSQSRequest
    {
        private string _queueUrl;

        /// <summary>
        /// Gets and sets the property QueueUrl. 
        /// <para>
        /// The URL of the queue from which the <code>PurgeQueue</code> action deletes messages.
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

    }
}