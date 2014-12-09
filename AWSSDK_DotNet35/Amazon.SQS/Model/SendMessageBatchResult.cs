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
    /// For each message in the batch, the response contains a <a>SendMessageBatchResultEntry</a>
    /// tag if the message succeeds or a <a>BatchResultErrorEntry</a> tag if the message fails.
    /// </summary>
    public partial class SendMessageBatchResult : AmazonWebServiceResponse
    {
        private List<BatchResultErrorEntry> _failed = new List<BatchResultErrorEntry>();
        private List<SendMessageBatchResultEntry> _successful = new List<SendMessageBatchResultEntry>();

        /// <summary>
        /// Gets and sets the property Failed. 
        /// <para>
        /// A list of <a>BatchResultErrorEntry</a> items with the error detail about each message
        /// that could not be enqueued.
        /// </para>
        /// </summary>
        public List<BatchResultErrorEntry> Failed
        {
            get { return this._failed; }
            set { this._failed = value; }
        }

        // Check to see if Failed property is set
        internal bool IsSetFailed()
        {
            return this._failed != null && this._failed.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property Successful. 
        /// <para>
        /// A list of <a>SendMessageBatchResultEntry</a> items.
        /// </para>
        /// </summary>
        public List<SendMessageBatchResultEntry> Successful
        {
            get { return this._successful; }
            set { this._successful = value; }
        }

        // Check to see if Successful property is set
        internal bool IsSetSuccessful()
        {
            return this._successful != null && this._successful.Count > 0; 
        }

    }
}