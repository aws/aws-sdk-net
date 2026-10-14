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
    /// Contains all the information about a speaker enrollment job.
    /// </summary>
    public partial class SpeakerEnrollmentJob
    {
        /// <summary>
        /// Gets and sets the property CreatedAt. 
        /// <para>
        /// A timestamp of when the speaker enrollment job was created.
        /// </para>
        /// </summary>
        public DateTime? CreatedAt { get; set; }

        /// <summary>
        /// Checks to see if the CreatedAt property is set.
        /// </summary>
        internal bool IsSetCreatedAt() => this.CreatedAt.HasValue;

        /// <summary>
        /// Gets and sets the property DataAccessRoleArn. 
        /// <para>
        /// The IAM role Amazon Resource Name (ARN) that grants Voice ID permissions to access
        /// customer's buckets to read the input manifest file and write the job output file.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 20, Max = 2048)]
        public string DataAccessRoleArn { get; set; }

        /// <summary>
        /// Checks to see if the DataAccessRoleArn property is set.
        /// </summary>
        internal bool IsSetDataAccessRoleArn() => this.DataAccessRoleArn != null;

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
        /// Gets and sets the property EnrollmentConfig. 
        /// <para>
        /// The configuration that defines the action to take when the speaker is already enrolled
        /// in Voice ID, and the <c>FraudDetectionConfig</c> to use.
        /// </para>
        /// </summary>
        public EnrollmentConfig EnrollmentConfig { get; set; }

        /// <summary>
        /// Checks to see if the EnrollmentConfig property is set.
        /// </summary>
        internal bool IsSetEnrollmentConfig() => this.EnrollmentConfig != null;

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
        /// Gets and sets the property InputDataConfig. 
        /// <para>
        /// The input data config containing an S3 URI for the input manifest file that contains
        /// the list of speaker enrollment job requests.
        /// </para>
        /// </summary>
        public InputDataConfig InputDataConfig { get; set; }

        /// <summary>
        /// Checks to see if the InputDataConfig property is set.
        /// </summary>
        internal bool IsSetInputDataConfig() => this.InputDataConfig != null;

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
        /// Provides details on job progress. This field shows the completed percentage of registration
        /// requests listed in the input file.
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

        /// <summary>
        /// Gets and sets the property OutputDataConfig. 
        /// <para>
        /// The output data config containing the S3 location where Voice ID writes the job output
        /// file; you must also include a KMS key ID to encrypt the file.
        /// </para>
        /// </summary>
        public OutputDataConfig OutputDataConfig { get; set; }

        /// <summary>
        /// Checks to see if the OutputDataConfig property is set.
        /// </summary>
        internal bool IsSetOutputDataConfig() => this.OutputDataConfig != null;
    }
}
