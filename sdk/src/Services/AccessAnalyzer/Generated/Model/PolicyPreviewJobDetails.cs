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
 * Do not modify this file. This file is generated from the accessanalyzer-2019-11-01.normal.json service model.
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
namespace Amazon.AccessAnalyzer.Model
{
    /// <summary>
    /// Contains details about the execution of a policy preview job.
    /// </summary>
    public partial class PolicyPreviewJobDetails
    {
        private DateTime? _completedAt;
        private JobError _jobError;
        private ImpactAnalysisJobStatus _jobStatus;
        private DateTime? _startedAt;
        private DateTime? _submittedAt;

        /// <summary>
        /// Gets and sets the property CompletedAt. 
        /// <para>
        /// The time at which the job completed. This field is populated only when the job reaches
        /// a terminal state (COMPLETED, FAILED, or CANCELED).
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
        /// Gets and sets the property JobError. 
        /// <para>
        /// Detailed information about the error that caused the job to fail. This field is populated
        /// only when the job status is FAILED.
        /// </para>
        /// </summary>
        public JobError JobError
        {
            get { return this._jobError; }
            set { this._jobError = value; }
        }

        // Check to see if JobError property is set
        internal bool IsSetJobError()
        {
            return this._jobError != null;
        }

        /// <summary>
        /// Gets and sets the property JobStatus. 
        /// <para>
        /// The current status of the job. Possible values are:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>SUBMITTED</c> - The job has been submitted but not yet started.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>IN_PROGRESS</c> - The job is currently executing.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>COMPLETED</c> - The job completed successfully.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>FAILED</c> - The job failed with an error.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>CANCELED</c> - The job was canceled by the user.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        [AWSProperty(Required=true)]
        public ImpactAnalysisJobStatus JobStatus
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
        /// Gets and sets the property StartedAt. 
        /// <para>
        /// The time at which the job execution started. This field is not populated until the
        /// job begins processing.
        /// </para>
        /// </summary>
        public DateTime? StartedAt
        {
            get { return this._startedAt; }
            set { this._startedAt = value; }
        }

        // Check to see if StartedAt property is set
        internal bool IsSetStartedAt()
        {
            return this._startedAt.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property SubmittedAt. 
        /// <para>
        /// The time at which the job was submitted.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public DateTime? SubmittedAt
        {
            get { return this._submittedAt; }
            set { this._submittedAt = value; }
        }

        // Check to see if SubmittedAt property is set
        internal bool IsSetSubmittedAt()
        {
            return this._submittedAt.HasValue; 
        }

    }
}