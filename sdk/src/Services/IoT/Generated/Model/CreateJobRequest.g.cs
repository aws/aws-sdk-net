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
    /// Container for the parameters to the CreateJob operation. Creates a job. <para> Requires
    /// permission to access the <a href="https://docs.aws.amazon.com/service-authorization/latest/reference/list_awsiot.html#awsiot-actions-as-permissions">CreateJob</a>
    /// action. </para>
    /// </summary>
    public partial class CreateJobRequest : AmazonIoTRequest
    {
        /// <summary>
        /// Gets and sets the property AbortConfig. 
        /// <para>
        /// Allows you to create the criteria to abort a job.
        /// </para>
        /// </summary>
        public AbortConfig AbortConfig { get; set; }

        /// <summary>
        /// Checks to see if the AbortConfig property is set.
        /// </summary>
        internal bool IsSetAbortConfig() => this.AbortConfig != null;

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
        /// Gets and sets the property Document. 
        /// <para>
        /// The job document. Required if you don't specify a value for <c>documentSource</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 32768)]
        public string Document { get; set; }

        /// <summary>
        /// Checks to see if the Document property is set.
        /// </summary>
        internal bool IsSetDocument() => this.Document != null;

        /// <summary>
        /// Gets and sets the property DocumentParameters. 
        /// <para>
        /// Parameters of an Amazon Web Services managed template that you can specify to create
        /// the job document.
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
        /// Gets and sets the property DocumentSource. 
        /// <para>
        /// An S3 link, or S3 object URL, to the job document. The link is an Amazon S3 object
        /// URL and is required if you don't specify a value for <c>document</c>.
        /// </para>
        ///  
        /// <para>
        /// For example, <c>--document-source https://s3.<i>region-code</i>.amazonaws.com/example-firmware/device-firmware.1.0</c>
        /// 
        /// </para>
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/AmazonS3/latest/userguide/access-bucket-intro.html">Methods
        /// for accessing a bucket</a>.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 1350)]
        public string DocumentSource { get; set; }

        /// <summary>
        /// Checks to see if the DocumentSource property is set.
        /// </summary>
        internal bool IsSetDocumentSource() => this.DocumentSource != null;

        /// <summary>
        /// Gets and sets the property JobExecutionsRetryConfig. 
        /// <para>
        /// Allows you to create the criteria to retry a job.
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
        /// Allows you to create a staged rollout of the job.
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
        /// A job identifier which must be unique for your account. We recommend using a UUID.
        /// Alpha-numeric characters, "-" and "_" are valid for use here.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 64)]
        public string JobId { get; set; }

        /// <summary>
        /// Checks to see if the JobId property is set.
        /// </summary>
        internal bool IsSetJobId() => this.JobId != null;

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
        /// Configuration information for pre-signed S3 URLs.
        /// </para>
        /// </summary>
        public PresignedUrlConfig PresignedUrlConfig { get; set; }

        /// <summary>
        /// Checks to see if the PresignedUrlConfig property is set.
        /// </summary>
        internal bool IsSetPresignedUrlConfig() => this.PresignedUrlConfig != null;

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
        /// Gets and sets the property Tags. 
        /// <para>
        /// Metadata which can be used to manage the job.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<Tag> Tags { get; set; } = AWSConfigs.InitializeCollections ? new List<Tag>() : null;

        /// <summary>
        /// Checks to see if the Tags property is set.
        /// </summary>
        internal bool IsSetTags() => this.Tags != null && (this.Tags.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property TargetSelection. 
        /// <para>
        /// Specifies whether the job will continue to run (CONTINUOUS), or will be complete after
        /// all those things specified as targets have completed the job (SNAPSHOT). If continuous,
        /// the job may also be run on a thing when a change is detected in a target. For example,
        /// a job will run on a thing when the thing is added to a target group, even after the
        /// job was completed by all things originally in the group.
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
        /// A list of things and thing groups to which the job should be sent.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required = true, Min = 1)]
        public List<string> Targets { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the Targets property is set.
        /// </summary>
        internal bool IsSetTargets() => this.Targets != null && (this.Targets.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property TimeoutConfig. 
        /// <para>
        /// Specifies the amount of time each device has to finish its execution of the job. The
        /// timer is started when the job execution status is set to <c>IN_PROGRESS</c>. If the
        /// job execution status is not set to another terminal state before the time expires,
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
