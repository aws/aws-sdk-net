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
 * Do not modify this file. This file is generated from the smithy.json service model.
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

namespace Amazon.KinesisFirehose.Model
{
    /// <summary>
    /// This is the response object from the PutRecordBatch operation.
    /// </summary>
    public partial class PutRecordBatchResponse : AmazonWebServiceResponse
    {
        /// <summary>
        /// Gets and sets the property Encrypted. 
        /// <para>
        /// Indicates whether server-side encryption (SSE) was enabled during this operation.
        /// </para>
        /// </summary>
        public bool? Encrypted { get; set; }

        /// <summary>
        /// Checks to see if the Encrypted property is set.
        /// </summary>
        internal bool IsSetEncrypted() => this.Encrypted.HasValue;

        /// <summary>
        /// Gets and sets the property FailedPutCount. 
        /// <para>
        /// The number of records that might have failed processing. This number might be greater
        /// than 0 even if the <a>PutRecordBatch</a> call succeeds. Check <c>FailedPutCount</c>
        /// to determine whether there are records that you need to resend.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 0)]
        public int? FailedPutCount { get; set; }

        /// <summary>
        /// Checks to see if the FailedPutCount property is set.
        /// </summary>
        internal bool IsSetFailedPutCount() => this.FailedPutCount.HasValue;

        /// <summary>
        /// Gets and sets the property RequestResponses. 
        /// <para>
        /// The results array. For each record, the index of the response element is the same
        /// as the index used in the request array.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 500)]
        public List<PutRecordBatchResponseEntry> RequestResponses { get; set; } = AWSConfigs.InitializeCollections ? new List<PutRecordBatchResponseEntry>() : null;

        /// <summary>
        /// Checks to see if the RequestResponses property is set.
        /// </summary>
        internal bool IsSetRequestResponses() => this.RequestResponses != null && (this.RequestResponses.Count > 0 || !AWSConfigs.InitializeCollections);
    }
}
