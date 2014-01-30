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
    /// Container for the parameters to the GetQueueUrl operation.
    /// <para> Returns the URL of an existing queue. This action provides a simple way to retrieve the URL of an Amazon SQS queue. </para> <para> To
    /// access a queue that belongs to another AWS account, use the <c>QueueOwnerAWSAccountId</c> parameter to specify the account ID of the queue's
    /// owner. The queue's owner must grant you permission to access the queue. For more information about shared queue access, see AddPermission or
    /// go to <a href="http://docs.aws.amazon.com/AWSSimpleQueueService/latest/SQSDeveloperGuide/acp-overview.html" >Shared Queues</a> in the
    /// <i>Amazon SQS Developer Guide</i> .
    /// </para>
    /// </summary>
    public partial class GetQueueUrlRequest : AmazonSQSRequest
    {
        private string queueName;
        private string queueOwnerAWSAccountId;


        /// <summary>
        /// The name of the queue whose URL must be fetched. Maximum 80 characters; alphanumeric characters, hyphens (-), and underscores (_) are
        /// allowed.
        ///  
        /// </summary>
        public string QueueName
        {
            get { return this.queueName; }
            set { this.queueName = value; }
        }

        // Check to see if QueueName property is set
        internal bool IsSetQueueName()
        {
            return this.queueName != null;
        }

        /// <summary>
        /// The AWS account ID of the account that created the queue.
        ///  
        /// </summary>
        public string QueueOwnerAWSAccountId
        {
            get { return this.queueOwnerAWSAccountId; }
            set { this.queueOwnerAWSAccountId = value; }
        }

        // Check to see if QueueOwnerAWSAccountId property is set
        internal bool IsSetQueueOwnerAWSAccountId()
        {
            return this.queueOwnerAWSAccountId != null;
        }

    }
}
    
