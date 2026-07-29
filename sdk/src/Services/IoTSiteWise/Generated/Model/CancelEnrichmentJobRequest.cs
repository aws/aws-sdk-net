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
 * Do not modify this file. This file is generated from the iotsitewise-2019-12-02.normal.json service model.
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
namespace Amazon.IoTSiteWise.Model
{
    /// <summary>
    /// Container for the parameters to the CancelEnrichmentJob operation.
    /// Cancels a running or pending enrichment job. This is an idempotent operation—calling
    /// it multiple times with the same jobId is safe and returns the current status.
    /// 
    ///  <h2>Behavior</h2> <ul> <li>Jobs in PENDING or RUNNING status transition to CANCELLED</li>
    /// <li>Jobs in RUNNING state may not be cancellable once they have progressed to certain
    /// processing stages</li> <li>Jobs already in terminal states (COMPLETED, FAILED, TIMED_OUT)
    /// cannot be cancelled; the operation returns a ConflictingOperationException</li> <li>Cancelling
    /// an already-CANCELLED job is a no-op and returns the current status (idempotent behavior)</li>
    /// <li>The API responds immediately after recording the cancellation</li> <li>Cleanup
    /// of job resources happens asynchronously in the background</li> </ul> <h2>When to Cancel</h2>
    /// 
    /// <para>
    /// Cancel a job when:
    /// </para>
    ///  <ul> <li>The job is taking longer than expected</li> <li>The job was created with
    /// incorrect parameters</li> <li>You no longer need the results</li> </ul> <h2>Idempotency</h2>
    /// 
    /// <para>
    /// You can safely retry cancellation requests. Calling CancelEnrichmentJob multiple times
    /// for the same job returns the current status without error as long as the job is not
    /// in a terminal state other than CANCELLED.
    /// </para>
    /// </summary>
    public partial class CancelEnrichmentJobRequest : AmazonIoTSiteWiseRequest
    {
        private string _jobId;
        private string _workspaceName;

        /// <summary>
        /// Gets and sets the property JobId. 
        /// <para>
        /// The unique identifier of the enrichment job to cancel. This is the jobId returned
        /// by CreateEnrichmentJob.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=36, Max=36)]
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
        /// Gets and sets the property WorkspaceName. 
        /// <para>
        /// The name of the IoT SiteWise workspace containing the enrichment job to cancel.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=64)]
        public string WorkspaceName
        {
            get { return this._workspaceName; }
            set { this._workspaceName = value; }
        }

        // Check to see if WorkspaceName property is set
        internal bool IsSetWorkspaceName()
        {
            return this._workspaceName != null;
        }

    }
}