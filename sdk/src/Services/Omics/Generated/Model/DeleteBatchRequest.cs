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
 * Do not modify this file. This file is generated from the omics-2022-11-28.normal.json service model.
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
namespace Amazon.Omics.Model
{
    /// <summary>
    /// Container for the parameters to the DeleteBatch operation.
    /// Deletes a run batch resource and its associated metadata. This operation does not
    /// delete the individual workflow runs. To delete the runs, call <c>DeleteRunBatch</c>
    /// before calling <c>DeleteBatch</c>.
    /// 
    ///  
    /// <para>
    ///  <c>DeleteBatch</c> requires the batch to be in a terminal state: <c>PROCESSED</c>,
    /// <c>FAILED</c>, <c>CANCELLED</c>, or <c>RUNS_DELETED</c>. After <c>DeleteBatch</c>
    /// completes, the batch metadata is no longer accessible. You cannot call <c>GetBatch</c>,
    /// <c>ListRunsInBatch</c>, <c>DeleteRunBatch</c>, or <c>CancelRunBatch</c> on a deleted
    /// batch.
    /// </para>
    /// </summary>
    public partial class DeleteBatchRequest : AmazonOmicsRequest
    {
        private string _batchId;

        /// <summary>
        /// Gets and sets the property BatchId. 
        /// <para>
        /// The identifier portion of the run batch ARN.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=18)]
        public string BatchId
        {
            get { return this._batchId; }
            set { this._batchId = value; }
        }

        // Check to see if BatchId property is set
        internal bool IsSetBatchId()
        {
            return this._batchId != null;
        }

    }
}