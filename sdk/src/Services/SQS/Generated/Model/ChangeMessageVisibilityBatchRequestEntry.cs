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
    /// Encloses a receipt handle and an entry ID for each message in <c> <a>ChangeMessageVisibilityBatch</a>.</c>
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
        /// <param name="id">An identifier for this particular receipt handle used to communicate the result. <note> The <c>Id</c>s of a batch request need to be unique within a request. This identifier can have up to 80 characters. The following characters are accepted: alphanumeric characters, hyphens(-), and underscores (_). </note></param>
        /// <param name="receiptHandle">A receipt handle.</param>
        public ChangeMessageVisibilityBatchRequestEntry(string id, string receiptHandle)
        {
            _id = id;
            _receiptHandle = receiptHandle;
        }

        /// <summary>
        /// Gets and sets the property Id. 
        /// <para>
        /// An identifier for this particular receipt handle used to communicate the result.
        /// </para>
        ///  <note> 
        /// <para>
        /// The <c>Id</c>s of a batch request need to be unique within a request.
        /// </para>
        ///  
        /// <para>
        /// This identifier can have up to 80 characters. The following characters are accepted:
        /// alphanumeric characters, hyphens(-), and underscores (_).
        /// </para>
        ///  </note>
        /// </summary>
        [AWSProperty(Required=true)]
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
        [AWSProperty(Required=true)]
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
        public int? VisibilityTimeout
        {
            get { return this._visibilityTimeout; }
            set { this._visibilityTimeout = value; }
        }

        // Check to see if VisibilityTimeout property is set
        internal bool IsSetVisibilityTimeout()
        {
            return this._visibilityTimeout.HasValue; 
        }

    }
}