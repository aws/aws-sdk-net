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
    /// This is the response object from the DescribeEnrichmentJob operation.
    /// </summary>
    public partial class DescribeEnrichmentJobResponse : AmazonWebServiceResponse
    {
        private DateTime? _cancelledAt;
        private DateTime? _completedAt;
        private DateTime? _createdAt;
        private string _failureMessage;
        private EnrichmentJobConfiguration _jobConfiguration;
        private string _jobId;
        private JobType _jobType;
        private EnrichmentJobStatus _status;
        private DateTime? _updatedAt;
        private string _workspaceName;

        /// <summary>
        /// Gets and sets the property CancelledAt. 
        /// <para>
        /// Timestamp when the job was cancelled in ISO 8601 format. Only present if status is
        /// CANCELLED.
        /// </para>
        /// </summary>
        public DateTime? CancelledAt
        {
            get { return this._cancelledAt; }
            set { this._cancelledAt = value; }
        }

        // Check to see if CancelledAt property is set
        internal bool IsSetCancelledAt()
        {
            return this._cancelledAt.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property CompletedAt. 
        /// <para>
        /// Timestamp when the job completed successfully in ISO 8601 format. Only present if
        /// status is COMPLETED.
        /// </para>
        /// </summary>
        public DateTime? CompletedAt
        {
            get { return this._completedAt; }
            set { this._completedAt = value; }
        }

        // Check to see if CompletedAt property is set
        internal bool IsSetCompletedAt()
        {
            return this._completedAt.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property CreatedAt. 
        /// <para>
        /// Timestamp when the enrichment job was created in ISO 8601 format.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public DateTime? CreatedAt
        {
            get { return this._createdAt; }
            set { this._createdAt = value; }
        }

        // Check to see if CreatedAt property is set
        internal bool IsSetCreatedAt()
        {
            return this._createdAt.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property FailureMessage. 
        /// <para>
        /// Human-readable error message explaining why the job failed. Only present if status
        /// is FAILED. Use this information to diagnose configuration issues, permission problems,
        /// or data processing errors.
        /// </para>
        /// </summary>
        public string FailureMessage
        {
            get { return this._failureMessage; }
            set { this._failureMessage = value; }
        }

        // Check to see if FailureMessage property is set
        internal bool IsSetFailureMessage()
        {
            return this._failureMessage != null;
        }

        /// <summary>
        /// Gets and sets the property JobConfiguration. 
        /// <para>
        /// The complete job configuration as originally submitted, including the analysis type
        /// and parameters. For event detection jobs, this includes the dataset ID, time series
        /// identifier, and trim settings defining the analysis time range.
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
        /// Gets and sets the property JobId. 
        /// <para>
        /// The unique identifier of the enrichment job.
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
        /// Gets and sets the property JobType. 
        /// <para>
        /// The type of enrichment job, derived from the job configuration. Currently EVENT_DETECTION
        /// is the only supported type.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public JobType JobType
        {
            get { return this._jobType; }
            set { this._jobType = value; }
        }

        // Check to see if JobType property is set
        internal bool IsSetJobType()
        {
            return this._jobType != null;
        }

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
        [AWSProperty(Required=true)]
        public EnrichmentJobStatus Status
        {
            get { return this._status; }
            set { this._status = value; }
        }

        // Check to see if Status property is set
        internal bool IsSetStatus()
        {
            return this._status != null;
        }

        /// <summary>
        /// Gets and sets the property UpdatedAt. 
        /// <para>
        /// Timestamp when the job status was last updated in ISO 8601 format. Useful for tracking
        /// recent activity.
        /// </para>
        /// </summary>
        public DateTime? UpdatedAt
        {
            get { return this._updatedAt; }
            set { this._updatedAt = value; }
        }

        // Check to see if UpdatedAt property is set
        internal bool IsSetUpdatedAt()
        {
            return this._updatedAt.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property WorkspaceName. 
        /// <para>
        /// The name of the IoT SiteWise workspace containing the job.
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