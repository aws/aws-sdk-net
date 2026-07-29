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
    /// Container for the parameters to the CreateEnrichmentJob operation.
    /// Creates an asynchronous enrichment job to analyze time-series sensor data. The operation
    /// returns immediately with job details while processing continues in the background.
    /// 
    ///  <h2>Idempotency</h2> 
    /// <para>
    /// Include a clientToken to make the operation idempotent. If you submit the same request
    /// with the same token within the idempotency window, you receive the original job details
    /// without creating a duplicate.
    /// </para>
    ///  <h2>Prerequisites</h2> 
    /// <para>
    /// Before creating a job, ensure:
    /// </para>
    ///  <ul> <li>The workspace is in ACTIVE state (not being deleted)</li> <li>You have IAM
    /// permissions for the workspace, dataset, and time-series resources</li> <li>You have
    /// KMS Decrypt permission on the workspace's customer-managed encryption key</li> <li>No
    /// duplicate job (same workspace, dataset, property, and job type) is currently running</li>
    /// </ul> <h2>Workflow</h2> <ol> <li>Submit the job with configuration specifying which
    /// video data to analyze and the time range</li> <li>Capture the jobId from the response</li>
    /// <li>Use DescribeEnrichmentJob to monitor progress and check job status</li> <li>When
    /// status reaches a terminal state (COMPLETED, FAILED, TIMED_OUT, CANCELLED), check results</li>
    /// <li>For COMPLETED jobs, query IoT SiteWise for semantic search on video events</li>
    /// </ol> <h2>Error Handling</h2> <ul> <li>ConflictingOperationException: A duplicate
    /// job is already running for the same configuration</li> <li>InvalidRequestException:
    /// Invalid parameters (e.g., both timeSeriesId and propertyAlias specified)</li> <li>AccessDeniedException:
    /// Insufficient IAM or KMS permissions</li> <li>LimitExceededException: Too many concurrent
    /// jobs or requests</li> </ul>
    /// </summary>
    public partial class CreateEnrichmentJobRequest : AmazonIoTSiteWiseRequest
    {
        private string _clientToken;
        private EnrichmentJobConfiguration _jobConfiguration;
        private string _workspaceName;

        /// <summary>
        /// Gets and sets the property ClientToken. 
        /// <para>
        /// Optional unique token that makes the operation idempotent. If you submit the same
        /// request with the same token within the idempotency window, the service returns the
        /// original job without creating a duplicate. Use a UUID or timestamp-based token for
        /// each unique request.
        /// </para>
        /// </summary>
        [AWSProperty(Min=36, Max=64)]
        public string ClientToken
        {
            get { return this._clientToken; }
            set { this._clientToken = value; }
        }

        // Check to see if ClientToken property is set
        internal bool IsSetClientToken()
        {
            return this._clientToken != null;
        }

        /// <summary>
        /// Gets and sets the property JobConfiguration. 
        /// <para>
        /// Configuration defining the type of enrichment analysis to perform and which video
        /// data to analyze. Currently supports eventDetection for generating embeddings from
        /// video data for semantic search.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public EnrichmentJobConfiguration JobConfiguration
        {
            get { return this._jobConfiguration; }
            set { this._jobConfiguration = value; }
        }

        // Check to see if JobConfiguration property is set
        internal bool IsSetJobConfiguration()
        {
            return this._jobConfiguration != null;
        }

        /// <summary>
        /// Gets and sets the property WorkspaceName. 
        /// <para>
        /// The name of the IoT SiteWise workspace containing the video data to analyze.
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