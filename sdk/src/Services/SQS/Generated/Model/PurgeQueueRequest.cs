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
    /// Container for the parameters to the PurgeQueue operation.
    /// Deletes available messages in a queue (including in-flight messages) specified by
    /// the <c>QueueURL</c> parameter.
    /// 
    ///  <important> 
    /// <para>
    /// When you use the <c>PurgeQueue</c> action, you can't retrieve any messages deleted
    /// from a queue.
    /// </para>
    ///  
    /// <para>
    /// The message deletion process takes up to 60 seconds. We recommend waiting for 60 seconds
    /// regardless of your queue's size. 
    /// </para>
    ///  </important> 
    /// <para>
    /// Messages sent to the queue <i>before</i> you call <c>PurgeQueue</c> might be received
    /// but are deleted within the next minute.
    /// </para>
    ///  
    /// <para>
    /// Messages sent to the queue <i>after</i> you call <c>PurgeQueue</c> might be deleted
    /// while the queue is being purged.
    /// </para>
    /// </summary>
    public partial class PurgeQueueRequest : AmazonSQSRequest
    {
        private string _queueUrl;

        /// <summary>
        /// Gets and sets the property QueueUrl. 
        /// <para>
        /// The URL of the queue from which the <c>PurgeQueue</c> action deletes messages.
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