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
    /// Container for the parameters to the GetQueueUrl operation.
    /// Returns the URL of an existing queue.       This action provides a simple way
    /// to retrieve the URL of an Amazon SQS queue.    
    /// 
    ///     
    /// <para>
    ///       To access a queue that belongs to another AWS account, use the <code>QueueOwnerAWSAccountId</code>
    ///      parameter to specify the account ID of the queue's owner. The queue's owner must
    /// grant you permission to       access the queue. For more information about shared
    /// queue access, see <a>AddPermission</a> or go to      <a href="http://docs.aws.amazon.com/AWSSimpleQueueService/latest/SQSDeveloperGuide/acp-overview.html">Shared
    /// Queues</a>      in the <i>Amazon SQS Developer Guide</i>.    
    /// </para>
    /// </summary>
    public partial class GetQueueUrlRequest : AmazonSQSRequest
    {
        private string _queueName;
        private string _queueOwnerAWSAccountId;

        /// <summary>
        /// Empty constructor used to set  properties independently even when a simple constructor is available
        /// </summary>
        public GetQueueUrlRequest() { }

        /// <summary>
        /// Instantiates GetQueueUrlRequest with the parameterized properties
        /// </summary>
        /// <param name="queueName">The name of the queue whose URL must be fetched.    Maximum 80 characters; alphanumeric characters, hyphens (-), and underscores (_) are allowed.</param>
        public GetQueueUrlRequest(string queueName)
        {
            _queueName = queueName;
        }

        /// <summary>
        /// Gets and sets the property QueueName. 
        /// <para>
        /// The name of the queue whose URL must be fetched.       Maximum 80 characters; alphanumeric
        /// characters, hyphens (-), and underscores (_) are allowed.
        /// </para>
        /// </summary>
        public string QueueName
        {
            get { return this._queueName; }
            set { this._queueName = value; }
        }

        // Check to see if QueueName property is set
        internal bool IsSetQueueName()
        {
            return this._queueName != null;
        }

        /// <summary>
        /// Gets and sets the property QueueOwnerAWSAccountId. 
        /// <para>
        /// The AWS account ID of the account that created the queue.
        /// </para>
        /// </summary>
        public string QueueOwnerAWSAccountId
        {
            get { return this._queueOwnerAWSAccountId; }
            set { this._queueOwnerAWSAccountId = value; }
        }

        // Check to see if QueueOwnerAWSAccountId property is set
        internal bool IsSetQueueOwnerAWSAccountId()
        {
            return this._queueOwnerAWSAccountId != null;
        }

    }
}