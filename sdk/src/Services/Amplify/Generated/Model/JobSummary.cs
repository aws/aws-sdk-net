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
 * Do not modify this file. This file is generated from the amplify-2017-07-25.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.Amplify.Model
{
    /// <summary>
    /// Describes the summary for an execution job for an Amplify app.
    /// </summary>
    public partial class JobSummary
    {
        private string _commitId;
        private string _commitMessage;
        private DateTime? _commitTime;
        private DateTime? _endTime;
        private string _jobArn;
        private string _jobId;
        private JobType _jobType;
        private DateTime? _startTime;
        private JobStatus _status;

        /// <summary>
        /// Gets and sets the property CommitId. 
        /// <para>
        ///  The commit ID from a third-party repository provider for the job. 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Max=255)]
        public string CommitId
        {
            get { return this._commitId; }
            set { this._commitId = value; }
        }

        // Check to see if CommitId property is set
        internal bool IsSetCommitId()
        {
            return this._commitId != null;
        }

        /// <summary>
        /// Gets and sets the property CommitMessage. 
        /// <para>
        ///  The commit message from a third-party repository provider for the job. 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Max=10000)]
        public string CommitMessage
        {
            get { return this._commitMessage; }
            set { this._commitMessage = value; }
        }

        // Check to see if CommitMessage property is set
        internal bool IsSetCommitMessage()
        {
            return this._commitMessage != null;
        }

        /// <summary>
        /// Gets and sets the property CommitTime. 
        /// <para>
        ///  The commit date and time for the job. 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public DateTime CommitTime
        {
            get { return this._commitTime.GetValueOrDefault(); }
            set { this._commitTime = value; }
        }

        // Check to see if CommitTime property is set
        internal bool IsSetCommitTime()
        {
            return this._commitTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property EndTime. 
        /// <para>
        ///  The end date and time for the job. 
        /// </para>
        /// </summary>
        public DateTime EndTime
        {
            get { return this._endTime.GetValueOrDefault(); }
            set { this._endTime = value; }
        }

        // Check to see if EndTime property is set
        internal bool IsSetEndTime()
        {
            return this._endTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property JobArn. 
        /// <para>
        ///  The Amazon Resource Name (ARN) for the job. 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Max=1000)]
        public string JobArn
        {
            get { return this._jobArn; }
            set { this._jobArn = value; }
        }

        // Check to see if JobArn property is set
        internal bool IsSetJobArn()
        {
            return this._jobArn != null;
        }

        /// <summary>
        /// Gets and sets the property JobId. 
        /// <para>
        ///  The unique ID for the job. 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Max=255)]
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
        ///  The type for the job. If the value is <code>RELEASE</code>, the job was manually
        /// released from its source by using the <code>StartJob</code> API. If the value is <code>RETRY</code>,
        /// the job was manually retried using the <code>StartJob</code> API. If the value is
        /// <code>WEB_HOOK</code>, the job was automatically triggered by webhooks. 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Max=10)]
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
        /// Gets and sets the property StartTime. 
        /// <para>
        ///  The start date and time for the job. 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public DateTime StartTime
        {
            get { return this._startTime.GetValueOrDefault(); }
            set { this._startTime = value; }
        }

        // Check to see if StartTime property is set
        internal bool IsSetStartTime()
        {
            return this._startTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        ///  The current status for the job. 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public JobStatus Status
        {
            get { return this._status; }
            set { this._status = value; }
        }

        // Check to see if Status property is set
        internal bool IsSetStatus()
        {
            return this._status != null;
        }

    }
}