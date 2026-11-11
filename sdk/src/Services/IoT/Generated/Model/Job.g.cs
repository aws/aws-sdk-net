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

namespace Amazon.IoT.Model
{
    /// <summary>
    /// The <c>Job</c> object contains details about a job.
    /// </summary>
    public partial class Job
    {
        /// <summary>
        /// Gets and sets the property AbortConfig. 
        /// <para>
        /// Configuration for criteria to abort the job.
        /// </para>
        /// </summary>
        public AbortConfig AbortConfig { get; set; }

        /// <summary>
        /// Checks to see if the AbortConfig property is set.
        /// </summary>
        internal bool IsSetAbortConfig() => this.AbortConfig != null;

        /// <summary>
        /// Gets and sets the property Comment. 
        /// <para>
        /// If the job was updated, describes the reason for the update.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 2028)]
        public string Comment { get; set; }

        /// <summary>
        /// Checks to see if the Comment property is set.
        /// </summary>
        internal bool IsSetComment() => this.Comment != null;

        /// <summary>
        /// Gets and sets the property CompletedAt. 
        /// <para>
        /// The time, in seconds since the epoch, when the job was completed.
        /// </para>
        /// </summary>
        public DateTime? CompletedAt { get; set; }

        /// <summary>
        /// Checks to see if the CompletedAt property is set.
        /// </summary>
        internal bool IsSetCompletedAt() => this.CompletedAt.HasValue;

        /// <summary>
        /// Gets and sets the property CreatedAt. 
        /// <para>
        /// The time, in seconds since the epoch, when the job was created.
        /// </para>
        /// </summary>
        public DateTime? CreatedAt { get; set; }

        /// <summary>
        /// Checks to see if the CreatedAt property is set.
        /// </summary>
        internal bool IsSetCreatedAt() => this.CreatedAt.HasValue;

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// A short text description of the job.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 2028)]
        public string Description { get; set; }

        /// <summary>
        /// Checks to see if the Description property is set.
        /// </summary>
        internal bool IsSetDescription() => this.Description != null;

        /// <summary>
        /// Gets and sets the property DestinationPackageVersions. 
        /// <para>
        /// The package version Amazon Resource Names (ARNs) that are installed on the device
        /// when the job successfully completes. The package version must be in either the Published
        /// or Deprecated state when the job deploys. For more information, see <a href="https://docs.aws.amazon.com/iot/latest/developerguide/preparing-to-use-software-package-catalog.html#package-version-lifecycle">Package
        /// version lifecycle</a>.The package version must be in either the Published or Deprecated
        /// state when the job deploys. For more information, see <a href="https://docs.aws.amazon.com/iot/latest/developerguide/preparing-to-use-software-package-catalog.html#package-version-lifecycle">Package
        /// version lifecycle</a>.
        /// </para>
        ///  
        /// <para>
        ///  <b>Note:</b>The following Length Constraints relates to a single ARN. Up to 25 package
        /// version ARNs are allowed.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> DestinationPackageVersions { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the DestinationPackageVersions property is set.
        /// </summary>
        internal bool IsSetDestinationPackageVersions() => this.DestinationPackageVersions != null && (this.DestinationPackageVersions.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property DocumentParameters. 
        /// <para>
        /// A key-value map that pairs the patterns that need to be replaced in a managed template
        /// job document schema. You can use the description of each key as a guidance to specify
        /// the inputs during runtime when creating a job.
        /// </para>
        ///  <note> 
        /// <para>
        ///  <c>documentParameters</c> can only be used when creating jobs from Amazon Web Services
        /// managed templates. This parameter can't be used with custom job templates or to create
        /// jobs from them.
        /// </para>
        ///  </note>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public Dictionary<string, string> DocumentParameters { get; set; } = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;

        /// <summary>
        /// Checks to see if the DocumentParameters property is set.
        /// </summary>
        internal bool IsSetDocumentParameters() => this.DocumentParameters != null && (this.DocumentParameters.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property ForceCanceled. 
        /// <para>
        /// Will be <c>true</c> if the job was canceled with the optional <c>force</c> parameter
        /// set to <c>true</c>.
        /// </para>
        /// </summary>
        public bool? ForceCanceled { get; set; }

        /// <summary>
        /// Checks to see if the ForceCanceled property is set.
        /// </summary>
        internal bool IsSetForceCanceled() => this.ForceCanceled.HasValue;

        /// <summary>
        /// Gets and sets the property IsConcurrent. 
        /// <para>
        /// Indicates whether a job is concurrent. Will be true when a job is rolling out new
        /// job executions or canceling previously created executions, otherwise false.
        /// </para>
        /// </summary>
        public bool? IsConcurrent { get; set; }

        /// <summary>
        /// Checks to see if the IsConcurrent property is set.
        /// </summary>
        internal bool IsSetIsConcurrent() => this.IsConcurrent.HasValue;

        /// <summary>
        /// Gets and sets the property JobArn. 
        /// <para>
        /// An ARN identifying the job with format "arn:aws:iot:region:account:job/jobId".
        /// </para>
        /// </summary>
        public string JobArn { get; set; }

        /// <summary>
        /// Checks to see if the JobArn property is set.
        /// </summary>
        internal bool IsSetJobArn() => this.JobArn != null;

        /// <summary>
        /// Gets and sets the property JobExecutionsRetryConfig. 
        /// <para>
        /// The configuration for the criteria to retry the job.
        /// </para>
        /// </summary>
        public JobExecutionsRetryConfig JobExecutionsRetryConfig { get; set; }

        /// <summary>
        /// Checks to see if the JobExecutionsRetryConfig property is set.
        /// </summary>
        internal bool IsSetJobExecutionsRetryConfig() => this.JobExecutionsRetryConfig != null;

        /// <summary>
        /// Gets and sets the property JobExecutionsRolloutConfig. 
        /// <para>
        /// Allows you to create a staged rollout of a job.
        /// </para>
        /// </summary>
        public JobExecutionsRolloutConfig JobExecutionsRolloutConfig { get; set; }

        /// <summary>
        /// Checks to see if the JobExecutionsRolloutConfig property is set.
        /// </summary>
        internal bool IsSetJobExecutionsRolloutConfig() => this.JobExecutionsRolloutConfig != null;

        /// <summary>
        /// Gets and sets the property JobId. 
        /// <para>
        /// The unique identifier you assigned to this job when it was created.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 64)]
        public string JobId { get; set; }

        /// <summary>
        /// Checks to see if the JobId property is set.
        /// </summary>
        internal bool IsSetJobId() => this.JobId != null;

        /// <summary>
        /// Gets and sets the property JobProcessDetails. 
        /// <para>
        /// Details about the job process.
        /// </para>
        /// </summary>
        public JobProcessDetails JobProcessDetails { get; set; }

        /// <summary>
        /// Checks to see if the JobProcessDetails property is set.
        /// </summary>
        internal bool IsSetJobProcessDetails() => this.JobProcessDetails != null;

        /// <summary>
        /// Gets and sets the property JobTemplateArn. 
        /// <para>
        /// The ARN of the job template used to create the job.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 1600)]
        public string JobTemplateArn { get; set; }

        /// <summary>
        /// Checks to see if the JobTemplateArn property is set.
        /// </summary>
        internal bool IsSetJobTemplateArn() => this.JobTemplateArn != null;

        /// <summary>
        /// Gets and sets the property LastUpdatedAt. 
        /// <para>
        /// The time, in seconds since the epoch, when the job was last updated.
        /// </para>
        /// </summary>
        public DateTime? LastUpdatedAt { get; set; }

        /// <summary>
        /// Checks to see if the LastUpdatedAt property is set.
        /// </summary>
        internal bool IsSetLastUpdatedAt() => this.LastUpdatedAt.HasValue;

        /// <summary>
        /// Gets and sets the property NamespaceId. 
        /// <para>
        /// The namespace used to indicate that a job is a customer-managed job.
        /// </para>
        ///  
        /// <para>
        /// When you specify a value for this parameter, Amazon Web Services IoT Core sends jobs
        /// notifications to MQTT topics that contain the value in the following format.
        /// </para>
        ///  
        /// <para>
        ///  <c>$aws/things/<i>THING_NAME</i>/jobs/<i>JOB_ID</i>/notify-namespace-<i>NAMESPACE_ID</i>/</c>
        /// 
        /// </para>
        ///  <note> 
        /// <para>
        /// The <c>namespaceId</c> feature is only supported by IoT Greengrass at this time. For
        /// more information, see <a href="https://docs.aws.amazon.com/greengrass/v2/developerguide/setting-up.html">Setting
        /// up IoT Greengrass core devices.</a> 
        /// </para>
        ///  </note>
        /// </summary>
        public string NamespaceId { get; set; }

        /// <summary>
        /// Checks to see if the NamespaceId property is set.
        /// </summary>
        internal bool IsSetNamespaceId() => this.NamespaceId != null;

        /// <summary>
        /// Gets and sets the property PresignedUrlConfig. 
        /// <para>
        /// Configuration for pre-signed S3 URLs.
        /// </para>
        /// </summary>
        public PresignedUrlConfig PresignedUrlConfig { get; set; }

        /// <summary>
        /// Checks to see if the PresignedUrlConfig property is set.
        /// </summary>
        internal bool IsSetPresignedUrlConfig() => this.PresignedUrlConfig != null;

        /// <summary>
        /// Gets and sets the property ReasonCode. 
        /// <para>
        /// If the job was updated, provides the reason code for the update.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 128)]
        public string ReasonCode { get; set; }

        /// <summary>
        /// Checks to see if the ReasonCode property is set.
        /// </summary>
        internal bool IsSetReasonCode() => this.ReasonCode != null;

        /// <summary>
        /// Gets and sets the property ScheduledJobRollouts. 
        /// <para>
        /// Displays the next seven maintenance window occurrences and their start times.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<ScheduledJobRollout> ScheduledJobRollouts { get; set; } = AWSConfigs.InitializeCollections ? new List<ScheduledJobRollout>() : null;

        /// <summary>
        /// Checks to see if the ScheduledJobRollouts property is set.
        /// </summary>
        internal bool IsSetScheduledJobRollouts() => this.ScheduledJobRollouts != null && (this.ScheduledJobRollouts.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property SchedulingConfig. 
        /// <para>
        /// The configuration that allows you to schedule a job for a future date and time in
        /// addition to specifying the end behavior for each job execution.
        /// </para>
        /// </summary>
        public SchedulingConfig SchedulingConfig { get; set; }

        /// <summary>
        /// Checks to see if the SchedulingConfig property is set.
        /// </summary>
        internal bool IsSetSchedulingConfig() => this.SchedulingConfig != null;

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The status of the job, one of <c>IN_PROGRESS</c>, <c>CANCELED</c>, <c>DELETION_IN_PROGRESS</c>
        /// or <c>COMPLETED</c>. 
        /// </para>
        /// </summary>
        public JobStatus Status { get; set; }

        /// <summary>
        /// Checks to see if the Status property is set.
        /// </summary>
        internal bool IsSetStatus() => this.Status != null;

        /// <summary>
        /// Gets and sets the property TargetSelection. 
        /// <para>
        /// Specifies whether the job will continue to run (CONTINUOUS), or will be complete after
        /// all those things specified as targets have completed the job (SNAPSHOT). If continuous,
        /// the job may also be run on a thing when a change is detected in a target. For example,
        /// a job will run on a device when the thing representing the device is added to a target
        /// group, even after the job was completed by all things originally in the group. 
        /// </para>
        ///  <note> 
        /// <para>
        /// We recommend that you use continuous jobs instead of snapshot jobs for dynamic thing
        /// group targets. By using continuous jobs, devices that join the group receive the job
        /// execution even after the job has been created.
        /// </para>
        ///  </note>
        /// </summary>
        public TargetSelection TargetSelection { get; set; }

        /// <summary>
        /// Checks to see if the TargetSelection property is set.
        /// </summary>
        internal bool IsSetTargetSelection() => this.TargetSelection != null;

        /// <summary>
        /// Gets and sets the property Targets. 
        /// <para>
        /// A list of IoT things and thing groups to which the job should be sent.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 1)]
        public List<string> Targets { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the Targets property is set.
        /// </summary>
        internal bool IsSetTargets() => this.Targets != null && (this.Targets.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property TimeoutConfig. 
        /// <para>
        /// Specifies the amount of time each device has to finish its execution of the job. A
        /// timer is started when the job execution status is set to <c>IN_PROGRESS</c>. If the
        /// job execution status is not set to another terminal state before the timer expires,
        /// it will be automatically set to <c>TIMED_OUT</c>.
        /// </para>
        /// </summary>
        public TimeoutConfig TimeoutConfig { get; set; }

        /// <summary>
        /// Checks to see if the TimeoutConfig property is set.
        /// </summary>
        internal bool IsSetTimeoutConfig() => this.TimeoutConfig != null;
    }
}
