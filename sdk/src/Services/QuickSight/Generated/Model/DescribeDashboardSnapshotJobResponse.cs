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
 * Do not modify this file. This file is generated from the quicksight-2018-04-01.normal.json service model.
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
        private string _arn;
        private string _awsAccountId;
        private DateTime? _createdTime;
        private string _dashboardId;
        private SnapshotJobStatus _jobStatus;
        private DateTime? _lastUpdatedTime;
        private string _requestId;
        private SnapshotConfiguration _snapshotConfiguration;
        private string _snapshotJobId;
        private int? _status;
        private SnapshotUserConfigurationRedacted _userConfiguration;

        /// <summary>
        /// Gets and sets the property Arn. 
        /// <para>
        /// The Amazon Resource Name (ARN) for the snapshot job. The job ARN is generated when
        /// you start a new job with a <c>StartDashboardSnapshotJob</c> API call.
        /// </para>
        /// </summary>
        public string Arn
        {
            get { return this._arn; }
            set { this._arn = value; }
        }

        // Check to see if Arn property is set
        internal bool IsSetArn()
        {
            return this._arn != null;
        }

        /// <summary>
        /// Gets and sets the property AwsAccountId. 
        /// <para>
        ///  The ID of the Amazon Web Services account that the dashboard snapshot job is executed
        /// in. 
        /// </para>
        /// </summary>
        [AWSProperty(Min=12, Max=12)]
        public string AwsAccountId
        {
            get { return this._awsAccountId; }
            set { this._awsAccountId = value; }
        }

        // Check to see if AwsAccountId property is set
        internal bool IsSetAwsAccountId()
        {
            return this._awsAccountId != null;
        }

        /// <summary>
        /// Gets and sets the property CreatedTime. 
        /// <para>
        ///  The time that the snapshot job was created. 
        /// </para>
        /// </summary>
        public DateTime? CreatedTime
        {
            get { return this._createdTime; }
            set { this._createdTime = value; }
        }

        // Check to see if CreatedTime property is set
        internal bool IsSetCreatedTime()
        {
            return this._createdTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property DashboardId. 
        /// <para>
        /// The ID of the dashboard that you have started a snapshot job for.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=512)]
        public string DashboardId
        {
            get { return this._dashboardId; }
            set { this._dashboardId = value; }
        }

        // Check to see if DashboardId property is set
        internal bool IsSetDashboardId()
        {
            return this._dashboardId != null;
        }

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
        public SnapshotJobStatus JobStatus
        {
            get { return this._jobStatus; }
            set { this._jobStatus = value; }
        }

        // Check to see if JobStatus property is set
        internal bool IsSetJobStatus()
        {
            return this._jobStatus != null;
        }

        /// <summary>
        /// Gets and sets the property LastUpdatedTime. 
        /// <para>
        ///  The time that the snapshot job status was last updated. 
        /// </para>
        /// </summary>
        public DateTime? LastUpdatedTime
        {
            get { return this._lastUpdatedTime; }
            set { this._lastUpdatedTime = value; }
        }

        // Check to see if LastUpdatedTime property is set
        internal bool IsSetLastUpdatedTime()
        {
            return this._lastUpdatedTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property RequestId. 
        /// <para>
        ///  The Amazon Web Services request ID for this operation. 
        /// </para>
        /// </summary>
        public string RequestId
        {
            get { return this._requestId; }
            set { this._requestId = value; }
        }

        // Check to see if RequestId property is set
        internal bool IsSetRequestId()
        {
            return this._requestId != null;
        }

        /// <summary>
        /// Gets and sets the property SnapshotConfiguration. 
        /// <para>
        /// The snapshot configuration of the job. This information is provided when you make
        /// a <c>StartDashboardSnapshotJob</c> API call.
        /// </para>
        /// </summary>
        public SnapshotConfiguration SnapshotConfiguration
        {
            get { return this._snapshotConfiguration; }
            set { this._snapshotConfiguration = value; }
        }

        // Check to see if SnapshotConfiguration property is set
        internal bool IsSetSnapshotConfiguration()
        {
            return this._snapshotConfiguration != null;
        }

        /// <summary>
        /// Gets and sets the property SnapshotJobId. 
        /// <para>
        /// The ID of the job to be described. The job ID is set when you start a new job with
        /// a <c>StartDashboardSnapshotJob</c> API call.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=512)]
        public string SnapshotJobId
        {
            get { return this._snapshotJobId; }
            set { this._snapshotJobId = value; }
        }

        // Check to see if SnapshotJobId property is set
        internal bool IsSetSnapshotJobId()
        {
            return this._snapshotJobId != null;
        }

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The HTTP status of the request
        /// </para>
        /// </summary>
        public int? Status
        {
            get { return this._status; }
            set { this._status = value; }
        }

        // Check to see if Status property is set
        internal bool IsSetStatus()
        {
            return this._status.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property UserConfiguration. 
        /// <para>
        /// The user configuration for the snapshot job. This information is provided when you
        /// make a <c>StartDashboardSnapshotJob</c> API call.
        /// </para>
        /// </summary>
        public SnapshotUserConfigurationRedacted UserConfiguration
        {
            get { return this._userConfiguration; }
            set { this._userConfiguration = value; }
        }

        // Check to see if UserConfiguration property is set
        internal bool IsSetUserConfiguration()
        {
            return this._userConfiguration != null;
        }

    }
}