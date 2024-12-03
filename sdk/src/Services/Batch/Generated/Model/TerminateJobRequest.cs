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

#pragma warning disable CS0612,CS0618,CS1570
namespace Amazon.Batch.Model
{
    /// <summary>
    /// Container for the parameters to the TerminateJob operation.
    /// Terminates a job in a job queue. Jobs that are in the <c>STARTING</c> or <c>RUNNING</c>
    /// state are terminated, which causes them to transition to <c>FAILED</c>. Jobs that
    /// have not progressed to the <c>STARTING</c> state are cancelled.
    /// </summary>
    public partial class TerminateJobRequest : AmazonBatchRequest
    {
        private string _jobId;
        private string _reason;

        /// <summary>
        /// Gets and sets the property JobId. 
        /// <para>
        /// The Batch job ID of the job to terminate.
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
        /// is returned by future <a>DescribeJobs</a> operations on the job. It is also recorded
        /// in the Batch activity logs.
        /// </para>
        ///  
        /// <para>
        /// This parameter has as limit of 1024 characters.
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