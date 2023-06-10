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
 * Do not modify this file. This file is generated from the voice-id-2021-09-27.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.VoiceID.Model
{
    /// <summary>
    /// Contains a summary of information about a speaker enrollment job.
    /// </summary>
    public partial class SpeakerEnrollmentJobSummary
    {
        private DateTime? _createdAt;
        private string _domainId;
        private DateTime? _endedAt;
        private FailureDetails _failureDetails;
        private string _jobId;
        private string _jobName;
        private JobProgress _jobProgress;
        private SpeakerEnrollmentJobStatus _jobStatus;

        /// <summary>
        /// Gets and sets the property CreatedAt. 
        /// <para>
        /// A timestamp of when of the speaker enrollment job was created.
        /// </para>
        /// </summary>
        public DateTime CreatedAt
        {
            get { return this._createdAt.GetValueOrDefault(); }
            set { this._createdAt = value; }
        }

        // Check to see if CreatedAt property is set
        internal bool IsSetCreatedAt()
        {
            return this._createdAt.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property DomainId. 
        /// <para>
        /// The identifier of the domain that contains the speaker enrollment job.
        /// </para>
        /// </summary>
        [AWSProperty(Min=22, Max=22)]
        public string DomainId
        {
            get { return this._domainId; }
            set { this._domainId = value; }
        }

        // Check to see if DomainId property is set
        internal bool IsSetDomainId()
        {
            return this._domainId != null;
        }

        /// <summary>
        /// Gets and sets the property EndedAt. 
        /// <para>
        /// A timestamp of when the speaker enrollment job ended.
        /// </para>
        /// </summary>
        public DateTime EndedAt
        {
            get { return this._endedAt.GetValueOrDefault(); }
            set { this._endedAt = value; }
        }

        // Check to see if EndedAt property is set
        internal bool IsSetEndedAt()
        {
            return this._endedAt.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property FailureDetails. 
        /// <para>
        /// Contains details that are populated when an entire batch job fails. In cases of individual
        /// registration job failures, the batch job as a whole doesn't fail; it is completed
        /// with a <code>JobStatus</code> of <code>COMPLETED_WITH_ERRORS</code>. You can use the
        /// job output file to identify the individual registration requests that failed.
        /// </para>
        /// </summary>
        public FailureDetails FailureDetails
        {
            get { return this._failureDetails; }
            set { this._failureDetails = value; }
        }

        // Check to see if FailureDetails property is set
        internal bool IsSetFailureDetails()
        {
            return this._failureDetails != null;
        }

        /// <summary>
        /// Gets and sets the property JobId. 
        /// <para>
        /// The service-generated identifier for the speaker enrollment job.
        /// </para>
        /// </summary>
        [AWSProperty(Min=22, Max=22)]
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
        /// Gets and sets the property JobName. 
        /// <para>
        /// The client-provided name for the speaker enrollment job.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive=true, Min=1, Max=256)]
        public string JobName
        {
            get { return this._jobName; }
            set { this._jobName = value; }
        }

        // Check to see if JobName property is set
        internal bool IsSetJobName()
        {
            return this._jobName != null;
        }

        /// <summary>
        /// Gets and sets the property JobProgress. 
        /// <para>
        /// Provides details regarding job progress. This field shows the completed percentage
        /// of enrollment requests listed in the input file.
        /// </para>
        /// </summary>
        public JobProgress JobProgress
        {
            get { return this._jobProgress; }
            set { this._jobProgress = value; }
        }

        // Check to see if JobProgress property is set
        internal bool IsSetJobProgress()
        {
            return this._jobProgress != null;
        }

        /// <summary>
        /// Gets and sets the property JobStatus. 
        /// <para>
        /// The current status of the speaker enrollment job.
        /// </para>
        /// </summary>
        public SpeakerEnrollmentJobStatus JobStatus
        {
            get { return this._jobStatus; }
            set { this._jobStatus = value; }
        }

        // Check to see if JobStatus property is set
        internal bool IsSetJobStatus()
        {
            return this._jobStatus != null;
        }

    }
}