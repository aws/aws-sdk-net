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

namespace Amazon.QuickSight.Model
{
    /// <summary>
    /// This is the response object from the DescribeDashboardSnapshotJob operation.
    /// </summary>
    public partial class DescribeDashboardSnapshotJobResponse : AmazonWebServiceResponse
    {
        /// <summary>
        /// Gets and sets the property Arn. 
        /// <para>
        /// The Amazon Resource Name (ARN) for the snapshot job. The job ARN is generated when
        /// you start a new job with a <c>StartDashboardSnapshotJob</c> API call.
        /// </para>
        /// </summary>
        public string Arn { get; set; }

        /// <summary>
        /// Checks to see if the Arn property is set.
        /// </summary>
        internal bool IsSetArn() => this.Arn != null;

        /// <summary>
        /// Gets and sets the property AwsAccountId. 
        /// <para>
        ///  The ID of the Amazon Web Services account that the dashboard snapshot job is executed
        /// in. 
        /// </para>
        /// </summary>
        [AWSProperty(Min = 12, Max = 12)]
        public string AwsAccountId { get; set; }

        /// <summary>
        /// Checks to see if the AwsAccountId property is set.
        /// </summary>
        internal bool IsSetAwsAccountId() => this.AwsAccountId != null;

        /// <summary>
        /// Gets and sets the property CreatedTime. 
        /// <para>
        ///  The time that the snapshot job was created. 
        /// </para>
        /// </summary>
        public DateTime? CreatedTime { get; set; }

        /// <summary>
        /// Checks to see if the CreatedTime property is set.
        /// </summary>
        internal bool IsSetCreatedTime() => this.CreatedTime.HasValue;

        /// <summary>
        /// Gets and sets the property DashboardId. 
        /// <para>
        /// The ID of the dashboard that you have started a snapshot job for.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 512)]
        public string DashboardId { get; set; }

        /// <summary>
        /// Checks to see if the DashboardId property is set.
        /// </summary>
        internal bool IsSetDashboardId() => this.DashboardId != null;

        /// <summary>
        /// Gets and sets the property JobStatus. 
        /// <para>
        /// Indicates the status of a job. The status updates as the job executes. This shows
        /// one of the following values.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>COMPLETED</c> - The job was completed successfully.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>FAILED</c> - The job failed to execute.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>QUEUED</c> - The job is queued and hasn't started yet.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>RUNNING</c> - The job is still running.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public SnapshotJobStatus JobStatus { get; set; }

        /// <summary>
        /// Checks to see if the JobStatus property is set.
        /// </summary>
        internal bool IsSetJobStatus() => this.JobStatus != null;

        /// <summary>
        /// Gets and sets the property LastUpdatedTime. 
        /// <para>
        ///  The time that the snapshot job status was last updated. 
        /// </para>
        /// </summary>
        public DateTime? LastUpdatedTime { get; set; }

        /// <summary>
        /// Checks to see if the LastUpdatedTime property is set.
        /// </summary>
        internal bool IsSetLastUpdatedTime() => this.LastUpdatedTime.HasValue;

        /// <summary>
        /// Gets and sets the property RequestId. 
        /// <para>
        ///  The Amazon Web Services request ID for this operation. 
        /// </para>
        /// </summary>
        public string RequestId { get; set; }

        /// <summary>
        /// Checks to see if the RequestId property is set.
        /// </summary>
        internal bool IsSetRequestId() => this.RequestId != null;

        /// <summary>
        /// Gets and sets the property SnapshotConfiguration. 
        /// <para>
        /// The snapshot configuration of the job. This information is provided when you make
        /// a <c>StartDashboardSnapshotJob</c> API call.
        /// </para>
        /// </summary>
        public SnapshotConfiguration SnapshotConfiguration { get; set; }

        /// <summary>
        /// Checks to see if the SnapshotConfiguration property is set.
        /// </summary>
        internal bool IsSetSnapshotConfiguration() => this.SnapshotConfiguration != null;

        /// <summary>
        /// Gets and sets the property SnapshotJobId. 
        /// <para>
        /// The ID of the job to be described. The job ID is set when you start a new job with
        /// a <c>StartDashboardSnapshotJob</c> API call.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 512)]
        public string SnapshotJobId { get; set; }

        /// <summary>
        /// Checks to see if the SnapshotJobId property is set.
        /// </summary>
        internal bool IsSetSnapshotJobId() => this.SnapshotJobId != null;

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The HTTP status of the request
        /// </para>
        /// </summary>
        public int? Status { get; set; }

        /// <summary>
        /// Checks to see if the Status property is set.
        /// </summary>
        internal bool IsSetStatus() => this.Status.HasValue;

        /// <summary>
        /// Gets and sets the property UserConfiguration. 
        /// <para>
        /// The user configuration for the snapshot job. This information is provided when you
        /// make a <c>StartDashboardSnapshotJob</c> API call.
        /// </para>
        /// </summary>
        public SnapshotUserConfigurationRedacted UserConfiguration { get; set; }

        /// <summary>
        /// Checks to see if the UserConfiguration property is set.
        /// </summary>
        internal bool IsSetUserConfiguration() => this.UserConfiguration != null;
    }
}
