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
 * Do not modify this file. This file is generated from the firehose-2015-08-04.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.KinesisFirehose.Model
{
    /// <summary>
    /// This is the response object from the PutRecordBatch operation.
    /// </summary>
    public partial class PutRecordBatchResponse : AmazonWebServiceResponse
    {
        private bool? _encrypted;
        private int? _failedPutCount;
        private List<PutRecordBatchResponseEntry> _requestResponses = new List<PutRecordBatchResponseEntry>();

        /// <summary>
        /// Gets and sets the property Encrypted. 
        /// <para>
        /// Indicates whether server-side encryption (SSE) was enabled during this operation.
        /// </para>
        /// </summary>
        public bool Encrypted
        {
            get { return this._encrypted.GetValueOrDefault(); }
            set { this._encrypted = value; }
        }

        // Check to see if Encrypted property is set
        internal bool IsSetEncrypted()
        {
            return this._encrypted.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property FailedPutCount. 
        /// <para>
        /// The number of records that might have failed processing. This number might be greater
        /// than 0 even if the <a>PutRecordBatch</a> call succeeds. Check <code>FailedPutCount</code>
        /// to determine whether there are records that you need to resend.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=0)]
        public int FailedPutCount
        {
            get { return this._failedPutCount.GetValueOrDefault(); }
            set { this._failedPutCount = value; }
        }

        // Check to see if FailedPutCount property is set
        internal bool IsSetFailedPutCount()
        {
            return this._failedPutCount.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property RequestResponses. 
        /// <para>
        /// The results array. For each record, the index of the response element is the same
        /// as the index used in the request array.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=500)]
        public List<PutRecordBatchResponseEntry> RequestResponses
        {
            get { return this._requestResponses; }
            set { this._requestResponses = value; }
        }

        // Check to see if RequestResponses property is set
        internal bool IsSetRequestResponses()
        {
            return this._requestResponses != null && this._requestResponses.Count > 0; 
        }

    }
}