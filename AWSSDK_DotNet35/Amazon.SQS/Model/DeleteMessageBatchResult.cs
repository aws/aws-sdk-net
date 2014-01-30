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
    /// <para> For each message in the batch, the response contains a DeleteMessageBatchResultEntry tag if the message is deleted or a
    /// BatchResultErrorEntry tag if the message cannot be deleted. </para>
    /// </summary>
    public partial class DeleteMessageBatchResult : AmazonWebServiceResponse
    {
        
        private List<DeleteMessageBatchResultEntry> successful = new List<DeleteMessageBatchResultEntry>();
        private List<BatchResultErrorEntry> failed = new List<BatchResultErrorEntry>();


        /// <summary>
        /// A list of <a>DeleteMessageBatchResultEntry</a> items.
        ///  
        /// </summary>
        public List<DeleteMessageBatchResultEntry> Successful
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
        /// A list of <a>BatchResultErrorEntry</a> items.
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
