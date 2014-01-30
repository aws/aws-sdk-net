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

namespace Amazon.SQS.Model
{
    /// <summary>
    /// <para>For each message in the batch, the response contains a SendMessageBatchResultEntry tag if the message succeeds or a
    /// BatchResultErrorEntry tag if the message fails.</para>
    /// </summary>
    public partial class SendMessageBatchResult : AmazonWebServiceResponse
    {
        
        private List<SendMessageBatchResultEntry> successful = new List<SendMessageBatchResultEntry>();
        private List<BatchResultErrorEntry> failed = new List<BatchResultErrorEntry>();


        /// <summary>
        /// A list of <a>SendMessageBatchResultEntry</a> items.
        ///  
        /// </summary>
        public List<SendMessageBatchResultEntry> Successful
        {
            get { return this.successful; }
            set { this.successful = value; }
        }

        // Check to see if Successful property is set
        internal bool IsSetSuccessful()
        {
            return this.successful.Count > 0;
        }

        /// <summary>
        /// A list of <a>BatchResultErrorEntry</a> items with the error detail about each message that could not be enqueued.
        ///  
        /// </summary>
        public List<BatchResultErrorEntry> Failed
        {
            get { return this.failed; }
            set { this.failed = value; }
        }

        // Check to see if Failed property is set
        internal bool IsSetFailed()
        {
            return this.failed.Count > 0;
        }
    }
}
