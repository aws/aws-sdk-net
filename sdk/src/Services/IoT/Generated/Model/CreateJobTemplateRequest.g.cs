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
    /// Container for the parameters to the CreateJobTemplate operation. Creates a job template.
    /// <para> Requires permission to access the <a href="https://docs.aws.amazon.com/service-authorization/latest/reference/list_awsiot.html#awsiot-actions-as-permissions">CreateJobTemplate</a>
    /// action. </para>
    /// </summary>
    public partial class CreateJobTemplateRequest : AmazonIoTRequest
    {
        /// <summary>
        /// Gets and sets the property AbortConfig.
        /// </summary>
        public AbortConfig AbortConfig { get; set; }

        /// <summary>
        /// Checks to see if the AbortConfig property is set.
        /// </summary>
        internal bool IsSetAbortConfig() => this.AbortConfig != null;

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// A description of the job document.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 0, Max = 2028)]
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
        /// Gets and sets the property JobArn. 
        /// <para>
        /// The ARN of the job to use as the basis for the job template.
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
        /// </summary>
        public JobExecutionsRolloutConfig JobExecutionsRolloutConfig { get; set; }

        /// <summary>
        /// Checks to see if the JobExecutionsRolloutConfig property is set.
        /// </summary>
        internal bool IsSetJobExecutionsRolloutConfig() => this.JobExecutionsRolloutConfig != null;

        /// <summary>
        /// Gets and sets the property JobTemplateId. 
        /// <para>
        /// A unique identifier for the job template. We recommend using a UUID. Alpha-numeric
        /// characters, "-", and "_" are valid for use here.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 64)]
        public string JobTemplateId { get; set; }

        /// <summary>
        /// Checks to see if the JobTemplateId property is set.
        /// </summary>
        internal bool IsSetJobTemplateId() => this.JobTemplateId != null;

        /// <summary>
        /// Gets and sets the property MaintenanceWindows. 
        /// <para>
        /// Allows you to configure an optional maintenance window for the rollout of a job document
        /// to all devices in the target group for a job.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<MaintenanceWindow> MaintenanceWindows { get; set; } = AWSConfigs.InitializeCollections ? new List<MaintenanceWindow>() : null;

        /// <summary>
        /// Checks to see if the MaintenanceWindows property is set.
        /// </summary>
        internal bool IsSetMaintenanceWindows() => this.MaintenanceWindows != null && (this.MaintenanceWindows.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property PresignedUrlConfig.
        /// </summary>
        public PresignedUrlConfig PresignedUrlConfig { get; set; }

        /// <summary>
        /// Checks to see if the PresignedUrlConfig property is set.
        /// </summary>
        internal bool IsSetPresignedUrlConfig() => this.PresignedUrlConfig != null;

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// Metadata that can be used to manage the job template.
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
        /// Gets and sets the property TimeoutConfig.
        /// </summary>
        public TimeoutConfig TimeoutConfig { get; set; }

        /// <summary>
        /// Checks to see if the TimeoutConfig property is set.
        /// </summary>
        internal bool IsSetTimeoutConfig() => this.TimeoutConfig != null;
    }
}
