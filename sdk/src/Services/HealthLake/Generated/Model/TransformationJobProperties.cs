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
 * Do not modify this file. This file is generated from the healthlake-2017-07-01.normal.json service model.
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
        private string _dataAccessRoleArn;
        private bool? _driftDetectionEnabled;
        private DateTime? _endTime;
        private TransformationInputDataConfig _inputDataConfig;
        private string _jobId;
        private string _jobName;
        private TransformationJobProgressReport _jobProgressReport;
        private TransformationJobStatus _jobStatus;
        private string _message;
        private TransformationOutputDataConfig _outputDataConfig;
        private string _profileId;
        private string _profileName;
        private int? _profileVersion;
        private bool? _provenanceEnabled;
        private DateTime? _submitTime;

        /// <summary>
        /// Gets and sets the property DataAccessRoleArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the AWS Identity and Access Management (IAM) role
        /// that grants AWS HealthLake access to the specified Amazon S3 locations. AWS HealthLake
        /// assumes this role to read input files and write output files.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=20, Max=2048)]
        public string DataAccessRoleArn
        {
            get { return this._dataAccessRoleArn; }
            set { this._dataAccessRoleArn = value; }
        }

        // Check to see if DataAccessRoleArn property is set
        internal bool IsSetDataAccessRoleArn()
        {
            return this._dataAccessRoleArn != null;
        }

        /// <summary>
        /// Gets and sets the property DriftDetectionEnabled. 
        /// <para>
        /// Specifies whether drift detection is enabled for this job. When enabled, AWS HealthLake
        /// writes a drift report to the output Amazon S3 location alongside the converted files.
        /// </para>
        /// </summary>
        public bool? DriftDetectionEnabled
        {
            get { return this._driftDetectionEnabled; }
            set { this._driftDetectionEnabled = value; }
        }

        // Check to see if DriftDetectionEnabled property is set
        internal bool IsSetDriftDetectionEnabled()
        {
            return this._driftDetectionEnabled.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property EndTime. 
        /// <para>
        /// The timestamp when the job completed or failed.
        /// </para>
        /// </summary>
        public DateTime? EndTime
        {
            get { return this._endTime; }
            set { this._endTime = value; }
        }

        // Check to see if EndTime property is set
        internal bool IsSetEndTime()
        {
            return this._endTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property InputDataConfig. 
        /// <para>
        /// The Amazon S3 location and format of the source files for this job.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public TransformationInputDataConfig InputDataConfig
        {
            get { return this._inputDataConfig; }
            set { this._inputDataConfig = value; }
        }

        // Check to see if InputDataConfig property is set
        internal bool IsSetInputDataConfig()
        {
            return this._inputDataConfig != null;
        }

        /// <summary>
        /// Gets and sets the property JobId. 
        /// <para>
        /// The unique identifier of the data transformation job.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=32)]
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
        /// The name of the data transformation job.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=64)]
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
        /// Gets and sets the property JobProgressReport. 
        /// <para>
        /// The progress report for the data transformation job, including counts of files processed
        /// and resources generated.
        /// </para>
        /// </summary>
        public TransformationJobProgressReport JobProgressReport
        {
            get { return this._jobProgressReport; }
            set { this._jobProgressReport = value; }
        }

        // Check to see if JobProgressReport property is set
        internal bool IsSetJobProgressReport()
        {
            return this._jobProgressReport != null;
        }

        /// <summary>
        /// Gets and sets the property JobStatus. 
        /// <para>
        /// The current status of the data transformation job.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public TransformationJobStatus JobStatus
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
        /// Gets and sets the property Message. 
        /// <para>
        /// An informational message about the job, such as an error description if the job failed.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=2048)]
        public string Message
        {
            get { return this._message; }
            set { this._message = value; }
        }

        // Check to see if Message property is set
        internal bool IsSetMessage()
        {
            return this._message != null;
        }

        /// <summary>
        /// Gets and sets the property OutputDataConfig. 
        /// <para>
        /// The Amazon S3 location and encryption configuration for the converted output.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public TransformationOutputDataConfig OutputDataConfig
        {
            get { return this._outputDataConfig; }
            set { this._outputDataConfig = value; }
        }

        // Check to see if OutputDataConfig property is set
        internal bool IsSetOutputDataConfig()
        {
            return this._outputDataConfig != null;
        }

        /// <summary>
        /// Gets and sets the property ProfileId. 
        /// <para>
        /// The unique identifier of the data transformation profile used for this job.
        /// </para>
        /// </summary>
        [AWSProperty(Min=32, Max=32)]
        public string ProfileId
        {
            get { return this._profileId; }
            set { this._profileId = value; }
        }

        // Check to see if ProfileId property is set
        internal bool IsSetProfileId()
        {
            return this._profileId != null;
        }

        /// <summary>
        /// Gets and sets the property ProfileName. 
        /// <para>
        /// The name of the data transformation profile used for this job.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=256)]
        public string ProfileName
        {
            get { return this._profileName; }
            set { this._profileName = value; }
        }

        // Check to see if ProfileName property is set
        internal bool IsSetProfileName()
        {
            return this._profileName != null;
        }

        /// <summary>
        /// Gets and sets the property ProfileVersion. 
        /// <para>
        /// The version number of the data transformation profile used for this job.
        /// </para>
        /// </summary>
        public int? ProfileVersion
        {
            get { return this._profileVersion; }
            set { this._profileVersion = value; }
        }

        // Check to see if ProfileVersion property is set
        internal bool IsSetProfileVersion()
        {
            return this._profileVersion.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property ProvenanceEnabled. 
        /// <para>
        /// Specifies whether FHIR R4 Provenance resource generation is enabled for this transformation
        /// job. When provenance is enabled, the service also generates related DocumentReference
        /// and Device resources.
        /// </para>
        /// </summary>
        public bool? ProvenanceEnabled
        {
            get { return this._provenanceEnabled; }
            set { this._provenanceEnabled = value; }
        }

        // Check to see if ProvenanceEnabled property is set
        internal bool IsSetProvenanceEnabled()
        {
            return this._provenanceEnabled.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property SubmitTime. 
        /// <para>
        /// The timestamp when the job was submitted.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public DateTime? SubmitTime
        {
            get { return this._submitTime; }
            set { this._submitTime = value; }
        }

        // Check to see if SubmitTime property is set
        internal bool IsSetSubmitTime()
        {
            return this._submitTime.HasValue; 
        }

    }
}