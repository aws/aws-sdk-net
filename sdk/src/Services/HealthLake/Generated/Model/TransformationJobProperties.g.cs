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

namespace Amazon.HealthLake.Model
{
    /// <summary>
    /// Contains the properties of a data transformation job, including its status, configuration,
    /// and progress information. You retrieve this structure by calling <c>DescribeDataTransformationJob</c>.
    /// </summary>
    public partial class TransformationJobProperties
    {
        /// <summary>
        /// Gets and sets the property DataAccessRoleArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the Amazon Web Services Identity and Access Management
        /// (IAM) role that grants HealthLake access to the specified Amazon S3 locations. HealthLake
        /// assumes this role to read input files and write output files.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 20, Max = 2048)]
        public string DataAccessRoleArn { get; set; }

        /// <summary>
        /// Checks to see if the DataAccessRoleArn property is set.
        /// </summary>
        internal bool IsSetDataAccessRoleArn() => this.DataAccessRoleArn != null;

        /// <summary>
        /// Gets and sets the property DriftDetectionEnabled. 
        /// <para>
        /// Specifies whether drift detection is enabled for this job. When enabled, HealthLake
        /// writes a drift report to the output Amazon S3 location alongside the converted files.
        /// </para>
        /// </summary>
        public bool? DriftDetectionEnabled { get; set; }

        /// <summary>
        /// Checks to see if the DriftDetectionEnabled property is set.
        /// </summary>
        internal bool IsSetDriftDetectionEnabled() => this.DriftDetectionEnabled.HasValue;

        /// <summary>
        /// Gets and sets the property EndTime. 
        /// <para>
        /// The timestamp when the job completed or failed.
        /// </para>
        /// </summary>
        public DateTime? EndTime { get; set; }

        /// <summary>
        /// Checks to see if the EndTime property is set.
        /// </summary>
        internal bool IsSetEndTime() => this.EndTime.HasValue;

        /// <summary>
        /// Gets and sets the property InputDataConfig. 
        /// <para>
        /// The Amazon S3 location and format of the source files for this job.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public TransformationInputDataConfig InputDataConfig { get; set; }

        /// <summary>
        /// Checks to see if the InputDataConfig property is set.
        /// </summary>
        internal bool IsSetInputDataConfig() => this.InputDataConfig != null;

        /// <summary>
        /// Gets and sets the property JobId. 
        /// <para>
        /// The unique identifier of the data transformation job.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 32)]
        public string JobId { get; set; }

        /// <summary>
        /// Checks to see if the JobId property is set.
        /// </summary>
        internal bool IsSetJobId() => this.JobId != null;

        /// <summary>
        /// Gets and sets the property JobName. 
        /// <para>
        /// The name of the data transformation job.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 64)]
        public string JobName { get; set; }

        /// <summary>
        /// Checks to see if the JobName property is set.
        /// </summary>
        internal bool IsSetJobName() => this.JobName != null;

        /// <summary>
        /// Gets and sets the property JobProgressReport. 
        /// <para>
        /// The progress report for the data transformation job, including counts of files processed
        /// and resources generated.
        /// </para>
        /// </summary>
        public TransformationJobProgressReport JobProgressReport { get; set; }

        /// <summary>
        /// Checks to see if the JobProgressReport property is set.
        /// </summary>
        internal bool IsSetJobProgressReport() => this.JobProgressReport != null;

        /// <summary>
        /// Gets and sets the property JobStatus. 
        /// <para>
        /// The current status of the data transformation job.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public TransformationJobStatus JobStatus { get; set; }

        /// <summary>
        /// Checks to see if the JobStatus property is set.
        /// </summary>
        internal bool IsSetJobStatus() => this.JobStatus != null;

        /// <summary>
        /// Gets and sets the property Message. 
        /// <para>
        /// An informational message about the job, such as an error description if the job failed.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 2048)]
        public string Message { get; set; }

        /// <summary>
        /// Checks to see if the Message property is set.
        /// </summary>
        internal bool IsSetMessage() => this.Message != null;

        /// <summary>
        /// Gets and sets the property OutputDataConfig. 
        /// <para>
        /// The Amazon S3 location and encryption configuration for the converted output.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public TransformationOutputDataConfig OutputDataConfig { get; set; }

        /// <summary>
        /// Checks to see if the OutputDataConfig property is set.
        /// </summary>
        internal bool IsSetOutputDataConfig() => this.OutputDataConfig != null;

        /// <summary>
        /// Gets and sets the property ProfileId. 
        /// <para>
        /// The unique identifier of the data transformation profile used for this job.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 32, Max = 32)]
        public string ProfileId { get; set; }

        /// <summary>
        /// Checks to see if the ProfileId property is set.
        /// </summary>
        internal bool IsSetProfileId() => this.ProfileId != null;

        /// <summary>
        /// Gets and sets the property ProfileName. 
        /// <para>
        /// The name of the data transformation profile used for this job.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 256)]
        public string ProfileName { get; set; }

        /// <summary>
        /// Checks to see if the ProfileName property is set.
        /// </summary>
        internal bool IsSetProfileName() => this.ProfileName != null;

        /// <summary>
        /// Gets and sets the property ProfileVersion. 
        /// <para>
        /// The version number of the data transformation profile used for this job.
        /// </para>
        /// </summary>
        public int? ProfileVersion { get; set; }

        /// <summary>
        /// Checks to see if the ProfileVersion property is set.
        /// </summary>
        internal bool IsSetProfileVersion() => this.ProfileVersion.HasValue;

        /// <summary>
        /// Gets and sets the property ProvenanceEnabled. 
        /// <para>
        /// Specifies whether FHIR R4 Provenance resource generation is enabled for this transformation
        /// job. When provenance is enabled, the service also generates related DocumentReference
        /// and Device resources.
        /// </para>
        /// </summary>
        public bool? ProvenanceEnabled { get; set; }

        /// <summary>
        /// Checks to see if the ProvenanceEnabled property is set.
        /// </summary>
        internal bool IsSetProvenanceEnabled() => this.ProvenanceEnabled.HasValue;

        /// <summary>
        /// Gets and sets the property SubmitTime. 
        /// <para>
        /// The timestamp when the job was submitted.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public DateTime? SubmitTime { get; set; }

        /// <summary>
        /// Checks to see if the SubmitTime property is set.
        /// </summary>
        internal bool IsSetSubmitTime() => this.SubmitTime.HasValue;
    }
}
