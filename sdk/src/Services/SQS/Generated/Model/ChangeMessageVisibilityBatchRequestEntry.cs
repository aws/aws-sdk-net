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
    /// Encloses a receipt handle and an entry id for each message in <a>ChangeMessageVisibilityBatch</a>.
    /// 
    /// 
    ///  <important> 
    /// <para>
    /// All of the following parameters are list parameters that must be prefixed with <code>ChangeMessageVisibilityBatchRequestEntry.n</code>,
    /// where <code>n</code> is an integer value starting with 1. For example, a parameter
    /// list for this action might look like this:
    /// </para>
    ///  </important> 
    /// <para>
    /// <code>&amp;ChangeMessageVisibilityBatchRequestEntry.1.Id=change_visibility_msg_2</code>
    /// </para>
    ///  
    /// <para>
    /// <code>&amp;ChangeMessageVisibilityBatchRequestEntry.1.ReceiptHandle=<replaceable>Your_Receipt_Handle</replaceable></code>
    /// </para>
    ///  
    /// <para>
    /// <code>&amp;ChangeMessageVisibilityBatchRequestEntry.1.VisibilityTimeout=45</code>
    /// </para>
    /// </summary>
    public partial class ChangeMessageVisibilityBatchRequestEntry
    {
        private string _id;
        private string _receiptHandle;
        private int? _visibilityTimeout;

        /// <summary>
        /// Empty constructor used to set  properties independently even when a simple constructor is available
        /// </summary>
        public ChangeMessageVisibilityBatchRequestEntry() { }

        /// <summary>
        /// Instantiates ChangeMessageVisibilityBatchRequestEntry with the parameterized properties
        /// </summary>
        /// <param name="id">An identifier for this particular receipt handle. This is used to communicate the result. Note that the <code>Id</code>s of a batch request need to be unique within the request.</param>
        /// <param name="receiptHandle">A receipt handle.</param>
        public ChangeMessageVisibilityBatchRequestEntry(string id, string receiptHandle)
        {
            _id = id;
            _receiptHandle = receiptHandle;
        }

        /// <summary>
        /// Gets and sets the property Id. 
        /// <para>
        /// An identifier for this particular receipt handle. This is used to communicate the
        /// result. Note that the <code>Id</code>s of a batch request need to be unique within
        /// the request.
        /// </para>
        /// </summary>
        public string Id
        {
            get { return this._id; }
            set { this._id = value; }
        }

        // Check to see if Id property is set
        internal bool IsSetId()
        {
            return this._id != null;
        }

        /// <summary>
        /// Gets and sets the property ReceiptHandle. 
        /// <para>
        /// A receipt handle.
        /// </para>
        /// </summary>
        public string ReceiptHandle
        {
            get { return this._receiptHandle; }
            set { this._receiptHandle = value; }
        }

        // Check to see if ReceiptHandle property is set
        internal bool IsSetReceiptHandle()
        {
            return this._receiptHandle != null;
        }

        /// <summary>
        /// Gets and sets the property VisibilityTimeout. 
        /// <para>
        /// The new value (in seconds) for the message's visibility timeout.
        /// </para>
        /// </summary>
        public int VisibilityTimeout
        {
            get { return this._visibilityTimeout.GetValueOrDefault(); }
            set { this._visibilityTimeout = value; }
        }

        // Check to see if VisibilityTimeout property is set
        internal bool IsSetVisibilityTimeout()
        {
            return this._visibilityTimeout.HasValue; 
        }

    }
}