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
    /// Container for the parameters to the CancelRunBatch operation.
    /// Cancels all runs within a specified batch. This operation prevents not-yet-submitted
    /// runs from starting and submits <c>CancelRun</c> requests for runs that have already
    /// started.
    /// 
    ///  
    /// <para>
    /// Cancel is only allowed on batches in <c>PENDING</c>, <c>SUBMITTING</c>, or <c>INPROGRESS</c>
    /// state. Cancel operations are non-atomic and may be partially successful. Use <c>GetBatch</c>
    /// to review <c>successfulCancelSubmissionCount</c> and <c>failedCancelSubmissionCount</c>
    /// in the <c>submissionSummary</c>. Only one cancel or delete operation per batch is
    /// allowed at a time.
    /// </para>
    /// </summary>
    public partial class CancelRunBatchRequest : AmazonOmicsRequest
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