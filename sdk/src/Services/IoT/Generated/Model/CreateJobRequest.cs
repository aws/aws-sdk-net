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
 * Do not modify this file. This file is generated from the iot-2015-05-28.normal.json service model.
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
    /// Container for the parameters to the CreateJob operation.
    /// Creates a job.
    /// 
    ///  
    /// <para>
    /// Requires permission to access the <a href="https://docs.aws.amazon.com/service-authorization/latest/reference/list_awsiot.html#awsiot-actions-as-permissions">CreateJob</a>
    /// action.
    /// </para>
    /// </summary>
    public partial class CreateJobRequest : AmazonIoTRequest
    {
        private AbortConfig _abortConfig;
        private string _description;
        private List<string> _destinationPackageVersions = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private string _document;
        private Dictionary<string, string> _documentParameters = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;
        private string _documentSource;
        private JobExecutionsRetryConfig _jobExecutionsRetryConfig;
        private JobExecutionsRolloutConfig _jobExecutionsRolloutConfig;
        private string _jobId;
        private string _jobTemplateArn;
        private string _namespaceId;
        private PresignedUrlConfig _presignedUrlConfig;
        private SchedulingConfig _schedulingConfig;
        private List<Tag> _tags = AWSConfigs.InitializeCollections ? new List<Tag>() : null;
        private List<string> _targets = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private TargetSelection _targetSelection;
        private TimeoutConfig _timeoutConfig;

        /// <summary>
        /// Gets and sets the property AbortConfig. 
        /// <para>
        /// Allows you to create the criteria to abort a job.
        /// </para>
        /// </summary>
        public AbortConfig AbortConfig
        {
            get { return this._abortConfig; }
            set { this._abortConfig = value; }
        }

        // Check to see if AbortConfig property is set
        internal bool IsSetAbortConfig()
        {
            return this._abortConfig != null;
        }

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// A short text description of the job.
        /// </para>
        /// </summary>
        [AWSProperty(Max=2028)]
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
        /// </summary>
        public List<string> DestinationPackageVersions
        {
            get { return this._destinationPackageVersions; }
            set { this._destinationPackageVersions = value; }
        }

        // Check to see if DestinationPackageVersions property is set
        internal bool IsSetDestinationPackageVersions()
        {
            return this._destinationPackageVersions != null && (this._destinationPackageVersions.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property Document. 
        /// <para>
        /// The job document. Required if you don't specify a value for <c>documentSource</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Max=32768)]
        public string Document
        {
            get { return this._document; }
            set { this._document = value; }
        }

        // Check to see if Document property is set
        internal bool IsSetDocument()
        {
            return this._document != null;
        }

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
        /// </summary>
        public Dictionary<string, string> DocumentParameters
        {
            get { return this._documentParameters; }
            set { this._documentParameters = value; }
        }

        // Check to see if DocumentParameters property is set
        internal bool IsSetDocumentParameters()
        {
            return this._documentParameters != null && (this._documentParameters.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

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
        [AWSProperty(Min=1, Max=1350)]
        public string DocumentSource
        {
            get { return this._documentSource; }
            set { this._documentSource = value; }
        }

        // Check to see if DocumentSource property is set
        internal bool IsSetDocumentSource()
        {
            return this._documentSource != null;
        }

        /// <summary>
        /// Gets and sets the property JobExecutionsRetryConfig. 
        /// <para>
        /// Allows you to create the criteria to retry a job.
        /// </para>
        /// </summary>
        public JobExecutionsRetryConfig JobExecutionsRetryConfig
        {
            get { return this._jobExecutionsRetryConfig; }
            set { this._jobExecutionsRetryConfig = value; }
        }

        // Check to see if JobExecutionsRetryConfig property is set
        internal bool IsSetJobExecutionsRetryConfig()
        {
            return this._jobExecutionsRetryConfig != null;
        }

        /// <summary>
        /// Gets and sets the property JobExecutionsRolloutConfig. 
        /// <para>
        /// Allows you to create a staged rollout of the job.
        /// </para>
        /// </summary>
        public JobExecutionsRolloutConfig JobExecutionsRolloutConfig
        {
            get { return this._jobExecutionsRolloutConfig; }
            set { this._jobExecutionsRolloutConfig = value; }
        }

        // Check to see if JobExecutionsRolloutConfig property is set
        internal bool IsSetJobExecutionsRolloutConfig()
        {
            return this._jobExecutionsRolloutConfig != null;
        }

        /// <summary>
        /// Gets and sets the property JobId. 
        /// <para>
        /// A job identifier which must be unique for your Amazon Web Services account. We recommend
        /// using a UUID. Alpha-numeric characters, "-" and "_" are valid for use here.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=64)]
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
        /// Gets and sets the property JobTemplateArn. 
        /// <para>
        /// The ARN of the job template used to create the job.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=1600)]
        public string JobTemplateArn
        {
            get { return this._jobTemplateArn; }
            set { this._jobTemplateArn = value; }
        }

        // Check to see if JobTemplateArn property is set
        internal bool IsSetJobTemplateArn()
        {
            return this._jobTemplateArn != null;
        }

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
        public string NamespaceId
        {
            get { return this._namespaceId; }
            set { this._namespaceId = value; }
        }

        // Check to see if NamespaceId property is set
        internal bool IsSetNamespaceId()
        {
            return this._namespaceId != null;
        }

        /// <summary>
        /// Gets and sets the property PresignedUrlConfig. 
        /// <para>
        /// Configuration information for pre-signed S3 URLs.
        /// </para>
        /// </summary>
        public PresignedUrlConfig PresignedUrlConfig
        {
            get { return this._presignedUrlConfig; }
            set { this._presignedUrlConfig = value; }
        }

        // Check to see if PresignedUrlConfig property is set
        internal bool IsSetPresignedUrlConfig()
        {
            return this._presignedUrlConfig != null;
        }

        /// <summary>
        /// Gets and sets the property SchedulingConfig. 
        /// <para>
        /// The configuration that allows you to schedule a job for a future date and time in
        /// addition to specifying the end behavior for each job execution.
        /// </para>
        /// </summary>
        public SchedulingConfig SchedulingConfig
        {
            get { return this._schedulingConfig; }
            set { this._schedulingConfig = value; }
        }

        // Check to see if SchedulingConfig property is set
        internal bool IsSetSchedulingConfig()
        {
            return this._schedulingConfig != null;
        }

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// Metadata which can be used to manage the job.
        /// </para>
        /// </summary>
        public List<Tag> Tags
        {
            get { return this._tags; }
            set { this._tags = value; }
        }

        // Check to see if Tags property is set
        internal bool IsSetTags()
        {
            return this._tags != null && (this._tags.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property Targets. 
        /// <para>
        /// A list of things and thing groups to which the job should be sent.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1)]
        public List<string> Targets
        {
            get { return this._targets; }
            set { this._targets = value; }
        }

        // Check to see if Targets property is set
        internal bool IsSetTargets()
        {
            return this._targets != null && (this._targets.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

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
        public TargetSelection TargetSelection
        {
            get { return this._targetSelection; }
            set { this._targetSelection = value; }
        }

        // Check to see if TargetSelection property is set
        internal bool IsSetTargetSelection()
        {
            return this._targetSelection != null;
        }

        /// <summary>
        /// Gets and sets the property TimeoutConfig. 
        /// <para>
        /// Specifies the amount of time each device has to finish its execution of the job. The
        /// timer is started when the job execution status is set to <c>IN_PROGRESS</c>. If the
        /// job execution status is not set to another terminal state before the time expires,
        /// it will be automatically set to <c>TIMED_OUT</c>.
        /// </para>
        /// </summary>
        public TimeoutConfig TimeoutConfig
        {
            get { return this._timeoutConfig; }
            set { this._timeoutConfig = value; }
        }

        // Check to see if TimeoutConfig property is set
        internal bool IsSetTimeoutConfig()
        {
            return this._timeoutConfig != null;
        }

    }
}