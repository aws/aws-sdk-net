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

namespace Amazon.VoiceID.Model
{
    /// <summary>
    /// Contains a summary of information about a speaker enrollment job.
    /// </summary>
    public partial class SpeakerEnrollmentJobSummary
    {
        /// <summary>
        /// Gets and sets the property CreatedAt. 
        /// <para>
        /// A timestamp of when of the speaker enrollment job was created.
        /// </para>
        /// </summary>
        public DateTime? CreatedAt { get; set; }

        /// <summary>
        /// Checks to see if the CreatedAt property is set.
        /// </summary>
        internal bool IsSetCreatedAt() => this.CreatedAt.HasValue;

        /// <summary>
        /// Gets and sets the property DomainId. 
        /// <para>
        /// The identifier of the domain that contains the speaker enrollment job.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 22, Max = 22)]
        public string DomainId { get; set; }

        /// <summary>
        /// Checks to see if the DomainId property is set.
        /// </summary>
        internal bool IsSetDomainId() => this.DomainId != null;

        /// <summary>
        /// Gets and sets the property EndedAt. 
        /// <para>
        /// A timestamp of when the speaker enrollment job ended.
        /// </para>
        /// </summary>
        public DateTime? EndedAt { get; set; }

        /// <summary>
        /// Checks to see if the EndedAt property is set.
        /// </summary>
        internal bool IsSetEndedAt() => this.EndedAt.HasValue;

        /// <summary>
        /// Gets and sets the property FailureDetails. 
        /// <para>
        /// Contains details that are populated when an entire batch job fails. In cases of individual
        /// registration job failures, the batch job as a whole doesn't fail; it is completed
        /// with a <c>JobStatus</c> of <c>COMPLETED_WITH_ERRORS</c>. You can use the job output
        /// file to identify the individual registration requests that failed.
        /// </para>
        /// </summary>
        public FailureDetails FailureDetails { get; set; }

        /// <summary>
        /// Checks to see if the FailureDetails property is set.
        /// </summary>
        internal bool IsSetFailureDetails() => this.FailureDetails != null;

        /// <summary>
        /// Gets and sets the property JobId. 
        /// <para>
        /// The service-generated identifier for the speaker enrollment job.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 22, Max = 22)]
        public string JobId { get; set; }

        /// <summary>
        /// Checks to see if the JobId property is set.
        /// </summary>
        internal bool IsSetJobId() => this.JobId != null;

        /// <summary>
        /// Gets and sets the property JobName. 
        /// <para>
        /// The client-provided name for the speaker enrollment job.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive = true, Min = 1, Max = 256)]
        public string JobName { get; set; }

        /// <summary>
        /// Checks to see if the JobName property is set.
        /// </summary>
        internal bool IsSetJobName() => this.JobName != null;

        /// <summary>
        /// Gets and sets the property JobProgress. 
        /// <para>
        /// Provides details regarding job progress. This field shows the completed percentage
        /// of enrollment requests listed in the input file.
        /// </para>
        /// </summary>
        public JobProgress JobProgress { get; set; }

        /// <summary>
        /// Checks to see if the JobProgress property is set.
        /// </summary>
        internal bool IsSetJobProgress() => this.JobProgress != null;

        /// <summary>
        /// Gets and sets the property JobStatus. 
        /// <para>
        /// The current status of the speaker enrollment job.
        /// </para>
        /// </summary>
        public SpeakerEnrollmentJobStatus JobStatus { get; set; }

        /// <summary>
        /// Checks to see if the JobStatus property is set.
        /// </summary>
        internal bool IsSetJobStatus() => this.JobStatus != null;
    }
}
