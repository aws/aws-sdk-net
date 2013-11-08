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
    /// Container for the parameters to the DeleteMessageBatch operation.
    /// <para>This is a batch version of DeleteMessage. It takes multiple receipt handles and deletes each one of the messages. The result of the
    /// delete operation on each message is reported individually in the response.</para>
    /// </summary>
    public partial class DeleteMessageBatchRequest : AmazonSQSRequest
    {
        private string queueUrl;
        private List<DeleteMessageBatchRequestEntry> entries = new List<DeleteMessageBatchRequestEntry>();


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
        /// A list of receipt handles for the messages to be deleted.
        ///  
        /// </summary>
        public List<DeleteMessageBatchRequestEntry> Entries
        {
            get { return this.entries; }
            set { this.entries = value; }
        }

        // Check to see if Entries property is set
        internal bool IsSetEntries()
        {
            return this.entries.Count > 0;
        }

    }
}
    
