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
    /// <para>The <c>GetQueueUrl</c> action returns the URL of an existing queue.</para>
    /// </summary>
    public partial class GetQueueUrlRequest : AmazonSQSRequest
    {
        private string queueName;
        private string queueOwnerAWSAccountId;


        /// <summary>
        /// The name of the queue whose URL must be fetched.
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
        /// The AWS account number of the queue's owner.
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
    
