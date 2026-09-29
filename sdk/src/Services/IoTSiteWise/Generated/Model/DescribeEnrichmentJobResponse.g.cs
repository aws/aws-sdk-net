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

namespace Amazon.IoTSiteWise.Model
{
    /// <summary>
    /// This is the response object from the DescribeEnrichmentJob operation.
    /// </summary>
    public partial class DescribeEnrichmentJobResponse : AmazonWebServiceResponse
    {
        /// <summary>
        /// Gets and sets the property CancelledAt. 
        /// <para>
        /// Timestamp when the job was cancelled in ISO 8601 format. Only present if status is
        /// CANCELLED.
        /// </para>
        /// </summary>
        public DateTime? CancelledAt { get; set; }

        /// <summary>
        /// Checks to see if the CancelledAt property is set.
        /// </summary>
        internal bool IsSetCancelledAt() => this.CancelledAt.HasValue;

        /// <summary>
        /// Gets and sets the property CompletedAt. 
        /// <para>
        /// Timestamp when the job completed successfully in ISO 8601 format. Only present if
        /// status is COMPLETED.
        /// </para>
        /// </summary>
        public DateTime? CompletedAt { get; set; }

        /// <summary>
        /// Checks to see if the CompletedAt property is set.
        /// </summary>
        internal bool IsSetCompletedAt() => this.CompletedAt.HasValue;

        /// <summary>
        /// Gets and sets the property CreatedAt. 
        /// <para>
        /// Timestamp when the enrichment job was created in ISO 8601 format.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public DateTime? CreatedAt { get; set; }

        /// <summary>
        /// Checks to see if the CreatedAt property is set.
        /// </summary>
        internal bool IsSetCreatedAt() => this.CreatedAt.HasValue;

        /// <summary>
        /// Gets and sets the property FailureMessage. 
        /// <para>
        /// Human-readable error message explaining why the job failed. Only present if status
        /// is FAILED. Use this information to diagnose configuration issues, permission problems,
        /// or data processing errors.
        /// </para>
        /// </summary>
        public string FailureMessage { get; set; }

        /// <summary>
        /// Checks to see if the FailureMessage property is set.
        /// </summary>
        internal bool IsSetFailureMessage() => this.FailureMessage != null;

        /// <summary>
        /// Gets and sets the property JobConfiguration. 
        /// <para>
        /// The complete job configuration as originally submitted, including the analysis type
        /// and parameters. For event detection jobs, this includes the dataset ID, time series
        /// identifier, and trim settings defining the analysis time range.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public EnrichmentJobConfiguration JobConfiguration { get; set; }

        /// <summary>
        /// Checks to see if the JobConfiguration property is set.
        /// </summary>
        internal bool IsSetJobConfiguration() => this.JobConfiguration != null;

        /// <summary>
        /// Gets and sets the property JobId. 
        /// <para>
        /// The unique identifier of the enrichment job.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 36, Max = 36)]
        public string JobId { get; set; }

        /// <summary>
        /// Checks to see if the JobId property is set.
        /// </summary>
        internal bool IsSetJobId() => this.JobId != null;

        /// <summary>
        /// Gets and sets the property JobType. 
        /// <para>
        /// The type of enrichment job, derived from the job configuration. Currently EVENT_DETECTION
        /// is the only supported type.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public JobType JobType { get; set; }

        /// <summary>
        /// Checks to see if the JobType property is set.
        /// </summary>
        internal bool IsSetJobType() => this.JobType != null;

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// Current status of the enrichment job. Possible values:
        /// </para>
        ///  <ul> <li>PENDING: Job is waiting to start processing</li> <li>RUNNING: Job is actively
        /// processing video data</li> <li>COMPLETED: Job finished successfully; embeddings available
        /// in IoT SiteWise</li> <li>FAILED: Job encountered an error; see failureMessage for
        /// details</li> <li>TIMED_OUT: Job exceeded maximum processing time limit</li> <li>CANCELLED:
        /// Job was cancelled by user request</li> </ul>
        /// </summary>
        [AWSProperty(Required = true)]
        public EnrichmentJobStatus Status { get; set; }

        /// <summary>
        /// Checks to see if the Status property is set.
        /// </summary>
        internal bool IsSetStatus() => this.Status != null;

        /// <summary>
        /// Gets and sets the property UpdatedAt. 
        /// <para>
        /// Timestamp when the job status was last updated in ISO 8601 format. Useful for tracking
        /// recent activity.
        /// </para>
        /// </summary>
        public DateTime? UpdatedAt { get; set; }

        /// <summary>
        /// Checks to see if the UpdatedAt property is set.
        /// </summary>
        internal bool IsSetUpdatedAt() => this.UpdatedAt.HasValue;

        /// <summary>
        /// Gets and sets the property WorkspaceName. 
        /// <para>
        /// The name of the IoT SiteWise workspace containing the job.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 64)]
        public string WorkspaceName { get; set; }

        /// <summary>
        /// Checks to see if the WorkspaceName property is set.
        /// </summary>
        internal bool IsSetWorkspaceName() => this.WorkspaceName != null;
    }
}
