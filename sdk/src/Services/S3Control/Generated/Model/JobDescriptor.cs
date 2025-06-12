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
 * Do not modify this file. This file is generated from the s3control-2018-08-20.normal.json service model.
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
namespace Amazon.S3Control.Model
{
    /// <summary>
    /// A container element for the job configuration and status information returned by a
    /// <c>Describe Job</c> request.
    /// </summary>
    public partial class JobDescriptor
    {
        private bool? _confirmationRequired;
        private DateTime? _creationTime;
        private string _description;
        private List<JobFailure> _failureReasons = AWSConfigs.InitializeCollections ? new List<JobFailure>() : null;
        private S3GeneratedManifestDescriptor _generatedManifestDescriptor;
        private string _jobArn;
        private string _jobId;
        private JobManifest _manifest;
        private JobManifestGenerator _manifestGenerator;
        private JobOperation _operation;
        private int? _priority;
        private JobProgressSummary _progressSummary;
        private JobReport _report;
        private string _roleArn;
        private JobStatus _status;
        private string _statusUpdateReason;
        private string _suspendedCause;
        private DateTime? _suspendedDate;
        private DateTime? _terminationDate;

        /// <summary>
        /// Gets and sets the property ConfirmationRequired. 
        /// <para>
        /// Indicates whether confirmation is required before Amazon S3 begins running the specified
        /// job. Confirmation is required only for jobs created through the Amazon S3 console.
        /// </para>
        /// </summary>
        public bool? ConfirmationRequired
        {
            get { return this._confirmationRequired; }
            set { this._confirmationRequired = value; }
        }

        // Check to see if ConfirmationRequired property is set
        internal bool IsSetConfirmationRequired()
        {
            return this._confirmationRequired.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property CreationTime. 
        /// <para>
        /// A timestamp indicating when this job was created.
        /// </para>
        /// </summary>
        public DateTime? CreationTime
        {
            get { return this._creationTime; }
            set { this._creationTime = value; }
        }

        // Check to see if CreationTime property is set
        internal bool IsSetCreationTime()
        {
            return this._creationTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// The description for this job, if one was provided in this job's <c>Create Job</c>
        /// request.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=256)]
        public string Description
        {
            get { return this._description; }
            set { this._description = value; }
        }

        // Check to see if Description property is set
        internal bool IsSetDescription()
        {
            return this._description != null;
        }

        /// <summary>
        /// Gets and sets the property FailureReasons. 
        /// <para>
        /// If the specified job failed, this field contains information describing the failure.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<JobFailure> FailureReasons
        {
            get { return this._failureReasons; }
            set { this._failureReasons = value; }
        }

        // Check to see if FailureReasons property is set
        internal bool IsSetFailureReasons()
        {
            return this._failureReasons != null && (this._failureReasons.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property GeneratedManifestDescriptor. 
        /// <para>
        /// The attribute of the JobDescriptor containing details about the job's generated manifest.
        /// </para>
        /// </summary>
        public S3GeneratedManifestDescriptor GeneratedManifestDescriptor
        {
            get { return this._generatedManifestDescriptor; }
            set { this._generatedManifestDescriptor = value; }
        }

        // Check to see if GeneratedManifestDescriptor property is set
        internal bool IsSetGeneratedManifestDescriptor()
        {
            return this._generatedManifestDescriptor != null;
        }

        /// <summary>
        /// Gets and sets the property JobArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) for this job.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=1024)]
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
        /// The ID for the specified job.
        /// </para>
        /// </summary>
        [AWSProperty(Min=5, Max=36)]
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
        /// Gets and sets the property Manifest. 
        /// <para>
        /// The configuration information for the specified job's manifest object.
        /// </para>
        /// </summary>
        public JobManifest Manifest
        {
            get { return this._manifest; }
            set { this._manifest = value; }
        }

        // Check to see if Manifest property is set
        internal bool IsSetManifest()
        {
            return this._manifest != null;
        }

        /// <summary>
        /// Gets and sets the property ManifestGenerator. 
        /// <para>
        /// The manifest generator that was used to generate a job manifest for this job.
        /// </para>
        /// </summary>
        public JobManifestGenerator ManifestGenerator
        {
            get { return this._manifestGenerator; }
            set { this._manifestGenerator = value; }
        }

        // Check to see if ManifestGenerator property is set
        internal bool IsSetManifestGenerator()
        {
            return this._manifestGenerator != null;
        }

        /// <summary>
        /// Gets and sets the property Operation. 
        /// <para>
        /// The operation that the specified job is configured to run on the objects listed in
        /// the manifest.
        /// </para>
        /// </summary>
        public JobOperation Operation
        {
            get { return this._operation; }
            set { this._operation = value; }
        }

        // Check to see if Operation property is set
        internal bool IsSetOperation()
        {
            return this._operation != null;
        }

        /// <summary>
        /// Gets and sets the property Priority. 
        /// <para>
        /// The priority of the specified job.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=2147483647)]
        public int? Priority
        {
            get { return this._priority; }
            set { this._priority = value; }
        }

        // Check to see if Priority property is set
        internal bool IsSetPriority()
        {
            return this._priority.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property ProgressSummary. 
        /// <para>
        /// Describes the total number of tasks that the specified job has run, the number of
        /// tasks that succeeded, and the number of tasks that failed.
        /// </para>
        /// </summary>
        public JobProgressSummary ProgressSummary
        {
            get { return this._progressSummary; }
            set { this._progressSummary = value; }
        }

        // Check to see if ProgressSummary property is set
        internal bool IsSetProgressSummary()
        {
            return this._progressSummary != null;
        }

        /// <summary>
        /// Gets and sets the property Report. 
        /// <para>
        /// Contains the configuration information for the job-completion report if you requested
        /// one in the <c>Create Job</c> request.
        /// </para>
        /// </summary>
        public JobReport Report
        {
            get { return this._report; }
            set { this._report = value; }
        }

        // Check to see if Report property is set
        internal bool IsSetReport()
        {
            return this._report != null;
        }

        /// <summary>
        /// Gets and sets the property RoleArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) for the Identity and Access Management (IAM) role assigned
        /// to run the tasks for this job.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=2048)]
        public string RoleArn
        {
            get { return this._roleArn; }
            set { this._roleArn = value; }
        }

        // Check to see if RoleArn property is set
        internal bool IsSetRoleArn()
        {
            return this._roleArn != null;
        }

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The current status of the specified job.
        /// </para>
        /// </summary>
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

        /// <summary>
        /// Gets and sets the property StatusUpdateReason. 
        /// <para>
        /// The reason for updating the job.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=256)]
        public string StatusUpdateReason
        {
            get { return this._statusUpdateReason; }
            set { this._statusUpdateReason = value; }
        }

        // Check to see if StatusUpdateReason property is set
        internal bool IsSetStatusUpdateReason()
        {
            return this._statusUpdateReason != null;
        }

        /// <summary>
        /// Gets and sets the property SuspendedCause. 
        /// <para>
        /// The reason why the specified job was suspended. A job is only suspended if you create
        /// it through the Amazon S3 console. When you create the job, it enters the <c>Suspended</c>
        /// state to await confirmation before running. After you confirm the job, it automatically
        /// exits the <c>Suspended</c> state.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=1024)]
        public string SuspendedCause
        {
            get { return this._suspendedCause; }
            set { this._suspendedCause = value; }
        }

        // Check to see if SuspendedCause property is set
        internal bool IsSetSuspendedCause()
        {
            return this._suspendedCause != null;
        }

        /// <summary>
        /// Gets and sets the property SuspendedDate. 
        /// <para>
        /// The timestamp when this job was suspended, if it has been suspended.
        /// </para>
        /// </summary>
        public DateTime? SuspendedDate
        {
            get { return this._suspendedDate; }
            set { this._suspendedDate = value; }
        }

        // Check to see if SuspendedDate property is set
        internal bool IsSetSuspendedDate()
        {
            return this._suspendedDate.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property TerminationDate. 
        /// <para>
        /// A timestamp indicating when this job terminated. A job's termination date is the date
        /// and time when it succeeded, failed, or was canceled.
        /// </para>
        /// </summary>
        public DateTime? TerminationDate
        {
            get { return this._terminationDate; }
            set { this._terminationDate = value; }
        }

        // Check to see if TerminationDate property is set
        internal bool IsSetTerminationDate()
        {
            return this._terminationDate.HasValue; 
        }

    }
}