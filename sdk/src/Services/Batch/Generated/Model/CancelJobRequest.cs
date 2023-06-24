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
 * Do not modify this file. This file is generated from the batch-2016-08-10.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.Batch.Model
{
    /// <summary>
    /// Container for the parameters to the CancelJob operation.
    /// Cancels a job in an Batch job queue. Jobs that are in the <code>SUBMITTED</code> or
    /// <code>PENDING</code> are canceled. A job in<code>RUNNABLE</code> remains in <code>RUNNABLE</code>
    /// until it reaches the head of the job queue. Then the job status is updated to <code>FAILED</code>.
    /// 
    ///  
    /// <para>
    /// Jobs that progressed to the <code>STARTING</code> or <code>RUNNING</code> state aren't
    /// canceled. However, the API operation still succeeds, even if no job is canceled. These
    /// jobs must be terminated with the <a>TerminateJob</a> operation.
    /// </para>
    /// </summary>
    public partial class CancelJobRequest : AmazonBatchRequest
    {
        private string _jobId;
        private string _reason;

        /// <summary>
        /// Gets and sets the property JobId. 
        /// <para>
        /// The Batch job ID of the job to cancel.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string JobId
        {
            get { return this._jobId; }
            set { this._jobId = value; }
        }

        // Check to see if JobId property is set
        internal bool IsSetJobId()
        {
            return this._jobId != null;
        }

        /// <summary>
        /// Gets and sets the property Reason. 
        /// <para>
        /// A message to attach to the job that explains the reason for canceling it. This message
        /// is returned by future <a>DescribeJobs</a> operations on the job. This message is also
        /// recorded in the Batch activity logs.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string Reason
        {
            get { return this._reason; }
            set { this._reason = value; }
        }

        // Check to see if Reason property is set
        internal bool IsSetReason()
        {
            return this._reason != null;
        }

    }
}