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
    /// Container for the parameters to the DeleteMessage operation.
    /// <para>The <c>DeleteMessage</c> action unconditionally removes the specified message from the specified queue. Even if the message is locked
    /// by another reader due to the visibility timeout setting, it is still deleted from the queue.</para>
    /// </summary>
    public partial class DeleteMessageRequest : AmazonSQSRequest
    {
        private string queueUrl;
        private string receiptHandle;


        /// <summary>
        /// The URL of the SQS queue to take action on.
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
        /// The receipt handle associated with the message to delete.
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

    }
}
    
