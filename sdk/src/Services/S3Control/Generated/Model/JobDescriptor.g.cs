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

namespace Amazon.S3Control.Model
{
    /// <summary>
    /// A container element for the job configuration and status information returned by a
    /// <c>Describe Job</c> request.
    /// </summary>
    public partial class JobDescriptor
    {
        /// <summary>
        /// Gets and sets the property ConfirmationRequired. 
        /// <para>
        /// Indicates whether confirmation is required before Amazon S3 begins running the specified
        /// job. Confirmation is required only for jobs created through the Amazon S3 console.
        /// </para>
        /// </summary>
        public bool? ConfirmationRequired { get; set; }

        /// <summary>
        /// Checks to see if the ConfirmationRequired property is set.
        /// </summary>
        internal bool IsSetConfirmationRequired() => this.ConfirmationRequired.HasValue;

        /// <summary>
        /// Gets and sets the property CreationTime. 
        /// <para>
        /// A timestamp indicating when this job was created.
        /// </para>
        /// </summary>
        public DateTime? CreationTime { get; set; }

        /// <summary>
        /// Checks to see if the CreationTime property is set.
        /// </summary>
        internal bool IsSetCreationTime() => this.CreationTime.HasValue;

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// The description for this job, if one was provided in this job's <c>Create Job</c>
        /// request.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 256)]
        public string Description { get; set; }

        /// <summary>
        /// Checks to see if the Description property is set.
        /// </summary>
        internal bool IsSetDescription() => this.Description != null;

        /// <summary>
        /// Gets and sets the property FailureReasons. 
        /// <para>
        /// If the specified job failed, this field contains information describing the failure.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<JobFailure> FailureReasons { get; set; } = AWSConfigs.InitializeCollections ? new List<JobFailure>() : null;

        /// <summary>
        /// Checks to see if the FailureReasons property is set.
        /// </summary>
        internal bool IsSetFailureReasons() => this.FailureReasons != null && (this.FailureReasons.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property GeneratedManifestDescriptor. 
        /// <para>
        /// The attribute of the JobDescriptor containing details about the job's generated manifest.
        /// </para>
        /// </summary>
        public S3GeneratedManifestDescriptor GeneratedManifestDescriptor { get; set; }

        /// <summary>
        /// Checks to see if the GeneratedManifestDescriptor property is set.
        /// </summary>
        internal bool IsSetGeneratedManifestDescriptor() => this.GeneratedManifestDescriptor != null;

        /// <summary>
        /// Gets and sets the property JobArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) for this job.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 1024)]
        public string JobArn { get; set; }

        /// <summary>
        /// Checks to see if the JobArn property is set.
        /// </summary>
        internal bool IsSetJobArn() => this.JobArn != null;

        /// <summary>
        /// Gets and sets the property JobId. 
        /// <para>
        /// The ID for the specified job.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 5, Max = 36)]
        public string JobId { get; set; }

        /// <summary>
        /// Checks to see if the JobId property is set.
        /// </summary>
        internal bool IsSetJobId() => this.JobId != null;

        /// <summary>
        /// Gets and sets the property Manifest. 
        /// <para>
        /// The configuration information for the specified job's manifest object.
        /// </para>
        /// </summary>
        public JobManifest Manifest { get; set; }

        /// <summary>
        /// Checks to see if the Manifest property is set.
        /// </summary>
        internal bool IsSetManifest() => this.Manifest != null;

        /// <summary>
        /// Gets and sets the property ManifestGenerator. 
        /// <para>
        /// The manifest generator that was used to generate a job manifest for this job.
        /// </para>
        /// </summary>
        public JobManifestGenerator ManifestGenerator { get; set; }

        /// <summary>
        /// Checks to see if the ManifestGenerator property is set.
        /// </summary>
        internal bool IsSetManifestGenerator() => this.ManifestGenerator != null;

        /// <summary>
        /// Gets and sets the property Operation. 
        /// <para>
        /// The operation that the specified job is configured to run on the objects listed in
        /// the manifest.
        /// </para>
        /// </summary>
        public JobOperation Operation { get; set; }

        /// <summary>
        /// Checks to see if the Operation property is set.
        /// </summary>
        internal bool IsSetOperation() => this.Operation != null;

        /// <summary>
        /// Gets and sets the property Priority. 
        /// <para>
        /// The priority of the specified job.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 2147483647)]
        public int? Priority { get; set; }

        /// <summary>
        /// Checks to see if the Priority property is set.
        /// </summary>
        internal bool IsSetPriority() => this.Priority.HasValue;

        /// <summary>
        /// Gets and sets the property ProgressSummary. 
        /// <para>
        /// Describes the total number of tasks that the specified job has run, the number of
        /// tasks that succeeded, and the number of tasks that failed.
        /// </para>
        /// </summary>
        public JobProgressSummary ProgressSummary { get; set; }

        /// <summary>
        /// Checks to see if the ProgressSummary property is set.
        /// </summary>
        internal bool IsSetProgressSummary() => this.ProgressSummary != null;

        /// <summary>
        /// Gets and sets the property Report. 
        /// <para>
        /// Contains the configuration information for the job-completion report if you requested
        /// one in the <c>Create Job</c> request.
        /// </para>
        /// </summary>
        public JobReport Report { get; set; }

        /// <summary>
        /// Checks to see if the Report property is set.
        /// </summary>
        internal bool IsSetReport() => this.Report != null;

        /// <summary>
        /// Gets and sets the property RoleArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) for the Identity and Access Management (IAM) role assigned
        /// to run the tasks for this job.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 2048)]
        public string RoleArn { get; set; }

        /// <summary>
        /// Checks to see if the RoleArn property is set.
        /// </summary>
        internal bool IsSetRoleArn() => this.RoleArn != null;

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The current status of the specified job.
        /// </para>
        /// </summary>
        public JobStatus Status { get; set; }

        /// <summary>
        /// Checks to see if the Status property is set.
        /// </summary>
        internal bool IsSetStatus() => this.Status != null;

        /// <summary>
        /// Gets and sets the property StatusUpdateReason. 
        /// <para>
        /// The reason for updating the job.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 256)]
        public string StatusUpdateReason { get; set; }

        /// <summary>
        /// Checks to see if the StatusUpdateReason property is set.
        /// </summary>
        internal bool IsSetStatusUpdateReason() => this.StatusUpdateReason != null;

        /// <summary>
        /// Gets and sets the property SuspendedCause. 
        /// <para>
        /// The reason why the specified job was suspended. A job is only suspended if you create
        /// it through the Amazon S3 console. When you create the job, it enters the <c>Suspended</c>
        /// state to await confirmation before running. After you confirm the job, it automatically
        /// exits the <c>Suspended</c> state.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 1024)]
        public string SuspendedCause { get; set; }

        /// <summary>
        /// Checks to see if the SuspendedCause property is set.
        /// </summary>
        internal bool IsSetSuspendedCause() => this.SuspendedCause != null;

        /// <summary>
        /// Gets and sets the property SuspendedDate. 
        /// <para>
        /// The timestamp when this job was suspended, if it has been suspended.
        /// </para>
        /// </summary>
        public DateTime? SuspendedDate { get; set; }

        /// <summary>
        /// Checks to see if the SuspendedDate property is set.
        /// </summary>
        internal bool IsSetSuspendedDate() => this.SuspendedDate.HasValue;

        /// <summary>
        /// Gets and sets the property TerminationDate. 
        /// <para>
        /// A timestamp indicating when this job terminated. A job's termination date is the date
        /// and time when it succeeded, failed, or was canceled.
        /// </para>
        /// </summary>
        public DateTime? TerminationDate { get; set; }

        /// <summary>
        /// Checks to see if the TerminationDate property is set.
        /// </summary>
        internal bool IsSetTerminationDate() => this.TerminationDate.HasValue;
    }
}
