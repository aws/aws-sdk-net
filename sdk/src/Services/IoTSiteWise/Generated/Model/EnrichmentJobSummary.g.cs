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
    /// Summary information for an enrichment job returned by ListEnrichmentJobs. This lightweight
    /// representation includes identifiers, status, and key metadata without the full job
    /// configuration.
    /// 
    ///  
    /// <para>
    /// Use DescribeEnrichmentJob to retrieve:
    /// </para>
    ///  <ul> <li>Complete job configuration (trim settings, full parameters)</li> <li>Detailed
    /// timestamps (completedAt, cancelledAt)</li> <li>Failure messages for failed jobs</li>
    /// </ul> 
    /// <para>
    /// The summary is optimized for display in lists and dashboards, providing enough information
    /// to identify and filter jobs without the overhead of full configuration details.
    /// </para>
    /// </summary>
    public partial class EnrichmentJobSummary
    {
        /// <summary>
        /// Gets and sets the property CreatedAt. 
        /// <para>
        /// Timestamp when the job was created in ISO 8601 format.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public DateTime? CreatedAt { get; set; }

        /// <summary>
        /// Checks to see if the CreatedAt property is set.
        /// </summary>
        internal bool IsSetCreatedAt() => this.CreatedAt.HasValue;

        /// <summary>
        /// Gets and sets the property DatasetId. 
        /// <para>
        /// The dataset being enriched. Useful for filtering and identifying jobs without fetching
        /// the full configuration. This allows you to quickly find all jobs related to a specific
        /// dataset.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 36, Max = 36)]
        public string DatasetId { get; set; }

        /// <summary>
        /// Checks to see if the DatasetId property is set.
        /// </summary>
        internal bool IsSetDatasetId() => this.DatasetId != null;

        /// <summary>
        /// Gets and sets the property JobId. 
        /// <para>
        /// Unique identifier for the enrichment job.
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
        /// The type of enrichment job. Currently EVENT_DETECTION is the only supported type.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public JobType JobType { get; set; }

        /// <summary>
        /// Checks to see if the JobType property is set.
        /// </summary>
        internal bool IsSetJobType() => this.JobType != null;

        /// <summary>
        /// Gets and sets the property PropertyAlias. 
        /// <para>
        /// The property alias (human-readable sensor name) of the time series being enriched.
        /// Present when the job was created using a propertyAlias. Use this to identify which
        /// sensor the job analyzes.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 2048)]
        public string PropertyAlias { get; set; }

        /// <summary>
        /// Checks to see if the PropertyAlias property is set.
        /// </summary>
        internal bool IsSetPropertyAlias() => this.PropertyAlias != null;

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// Current status of the job: PENDING, RUNNING, COMPLETED, FAILED, TIMED_OUT, or CANCELLED.
        /// Use this to quickly identify active jobs or jobs requiring attention.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public EnrichmentJobStatus Status { get; set; }

        /// <summary>
        /// Checks to see if the Status property is set.
        /// </summary>
        internal bool IsSetStatus() => this.Status != null;

        /// <summary>
        /// Gets and sets the property TimeSeriesId. 
        /// <para>
        /// The system identifier of the time series being enriched. Present when the job was
        /// created using a timeSeriesId. Use this to identify which time series the job analyzes.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 36, Max = 73)]
        public string TimeSeriesId { get; set; }

        /// <summary>
        /// Checks to see if the TimeSeriesId property is set.
        /// </summary>
        internal bool IsSetTimeSeriesId() => this.TimeSeriesId != null;

        /// <summary>
        /// Gets and sets the property UpdatedAt. 
        /// <para>
        /// Timestamp of the last job status change in ISO 8601 format. Use this to track recent
        /// activity and identify stale jobs. For active jobs, this shows the last time the job
        /// transitioned to a new status.
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
        /// The name of the IoT SiteWise workspace containing this job.
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
