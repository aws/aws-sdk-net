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
    /// Container for the parameters to the DescribeEnrichmentJob operation.
    /// Retrieves detailed information about a specific enrichment job, including its current
    /// status, configuration, and timestamps.
    /// 
    ///  <h2>Use Cases</h2> <ul> <li>Monitor job progress by checking status updates with
    /// DescribeEnrichmentJob</li> <li>Retrieve the complete job configuration submitted during
    /// creation</li> <li>Debug failed jobs by examining the failureMessage field</li> <li>Track
    /// job lifecycle with creation, update, completion, and cancellation timestamps</li>
    /// </ul> <h2>Status Monitoring</h2> 
    /// <para>
    /// Jobs progress through statuses: PENDING → RUNNING → terminal state
    /// </para>
    ///  
    /// <para>
    /// Terminal states:
    /// </para>
    ///  <ul> <li>COMPLETED: Job finished successfully; query IoT SiteWise for semantic search
    /// results</li> <li>FAILED: Job encountered an error; check failureMessage for details</li>
    /// <li>TIMED_OUT: Job exceeded maximum processing time</li> <li>CANCELLED: Job was cancelled
    /// via CancelEnrichmentJob</li> </ul> <h2>Response Fields</h2> 
    /// <para>
    /// The response includes:
    /// </para>
    ///  <ul> <li>Current job status and type</li> <li>Full job configuration as originally
    /// submitted</li> <li>Lifecycle timestamps (created, updated, completed, cancelled)</li>
    /// <li>Failure details if status is FAILED</li> </ul>
    /// </summary>
    public partial class DescribeEnrichmentJobRequest : AmazonIoTSiteWiseRequest
    {
        private string _jobId;
        private string _workspaceName;

        /// <summary>
        /// Gets and sets the property JobId. 
        /// <para>
        /// The unique identifier of the enrichment job to retrieve. This is the jobId returned
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
        /// The name of the IoT SiteWise workspace containing the enrichment job.
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