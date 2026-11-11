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
    /// Container for the parameters to the CreateOTAUpdate operation. Creates an IoT OTA
    /// update on a target group of things or groups. <para> Requires permission to access
    /// the <a href="https://docs.aws.amazon.com/service-authorization/latest/reference/list_awsiot.html#awsiot-actions-as-permissions">CreateOTAUpdate</a>
    /// action. </para>
    /// </summary>
    public partial class CreateOTAUpdateRequest : AmazonIoTRequest
    {
        /// <summary>
        /// Gets and sets the property AdditionalParameters. 
        /// <para>
        /// A list of additional OTA update parameters, which are name-value pairs. They won't
        /// be sent to devices as a part of the Job document.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public Dictionary<string, string> AdditionalParameters { get; set; } = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;

        /// <summary>
        /// Checks to see if the AdditionalParameters property is set.
        /// </summary>
        internal bool IsSetAdditionalParameters() => this.AdditionalParameters != null && (this.AdditionalParameters.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property AwsJobAbortConfig. 
        /// <para>
        /// The criteria that determine when and how a job abort takes place.
        /// </para>
        /// </summary>
        public AwsJobAbortConfig AwsJobAbortConfig { get; set; }

        /// <summary>
        /// Checks to see if the AwsJobAbortConfig property is set.
        /// </summary>
        internal bool IsSetAwsJobAbortConfig() => this.AwsJobAbortConfig != null;

        /// <summary>
        /// Gets and sets the property AwsJobExecutionsRolloutConfig. 
        /// <para>
        /// Configuration for the rollout of OTA updates.
        /// </para>
        /// </summary>
        public AwsJobExecutionsRolloutConfig AwsJobExecutionsRolloutConfig { get; set; }

        /// <summary>
        /// Checks to see if the AwsJobExecutionsRolloutConfig property is set.
        /// </summary>
        internal bool IsSetAwsJobExecutionsRolloutConfig() => this.AwsJobExecutionsRolloutConfig != null;

        /// <summary>
        /// Gets and sets the property AwsJobPresignedUrlConfig. 
        /// <para>
        /// Configuration information for pre-signed URLs.
        /// </para>
        /// </summary>
        public AwsJobPresignedUrlConfig AwsJobPresignedUrlConfig { get; set; }

        /// <summary>
        /// Checks to see if the AwsJobPresignedUrlConfig property is set.
        /// </summary>
        internal bool IsSetAwsJobPresignedUrlConfig() => this.AwsJobPresignedUrlConfig != null;

        /// <summary>
        /// Gets and sets the property AwsJobTimeoutConfig. 
        /// <para>
        /// Specifies the amount of time each device has to finish its execution of the job. A
        /// timer is started when the job execution status is set to <c>IN_PROGRESS</c>. If the
        /// job execution status is not set to another terminal state before the timer expires,
        /// it will be automatically set to <c>TIMED_OUT</c>.
        /// </para>
        /// </summary>
        public AwsJobTimeoutConfig AwsJobTimeoutConfig { get; set; }

        /// <summary>
        /// Checks to see if the AwsJobTimeoutConfig property is set.
        /// </summary>
        internal bool IsSetAwsJobTimeoutConfig() => this.AwsJobTimeoutConfig != null;

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// The description of the OTA update.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 2028)]
        public string Description { get; set; }

        /// <summary>
        /// Checks to see if the Description property is set.
        /// </summary>
        internal bool IsSetDescription() => this.Description != null;

        /// <summary>
        /// Gets and sets the property Files. 
        /// <para>
        /// The files to be streamed by the OTA update.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required = true, Min = 1)]
        public List<OTAUpdateFile> Files { get; set; } = AWSConfigs.InitializeCollections ? new List<OTAUpdateFile>() : null;

        /// <summary>
        /// Checks to see if the Files property is set.
        /// </summary>
        internal bool IsSetFiles() => this.Files != null && (this.Files.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property OtaUpdateId. 
        /// <para>
        /// The ID of the OTA update to be created.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 128)]
        public string OtaUpdateId { get; set; }

        /// <summary>
        /// Checks to see if the OtaUpdateId property is set.
        /// </summary>
        internal bool IsSetOtaUpdateId() => this.OtaUpdateId != null;

        /// <summary>
        /// Gets and sets the property Protocols. 
        /// <para>
        /// The protocol used to transfer the OTA update image. Valid values are [HTTP], [MQTT],
        /// [HTTP, MQTT]. When both HTTP and MQTT are specified, the target device can choose
        /// the protocol.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 1, Max = 2)]
        public List<string> Protocols { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the Protocols property is set.
        /// </summary>
        internal bool IsSetProtocols() => this.Protocols != null && (this.Protocols.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property RoleArn. 
        /// <para>
        /// The IAM role that grants Amazon Web Services IoT Core access to the Amazon S3, IoT
        /// jobs and Amazon Web Services Code Signing resources to create an OTA update job.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 20, Max = 2048)]
        public string RoleArn { get; set; }

        /// <summary>
        /// Checks to see if the RoleArn property is set.
        /// </summary>
        internal bool IsSetRoleArn() => this.RoleArn != null;

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// Metadata which can be used to manage updates.
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
        /// Specifies whether the update will continue to run (CONTINUOUS), or will be complete
        /// after all the things specified as targets have completed the update (SNAPSHOT). If
        /// continuous, the update may also be run on a thing when a change is detected in a target.
        /// For example, an update will run on a thing when the thing is added to a target group,
        /// even after the update was completed by all things originally in the group. Valid values:
        /// CONTINUOUS | SNAPSHOT.
        /// </para>
        /// </summary>
        public TargetSelection TargetSelection { get; set; }

        /// <summary>
        /// Checks to see if the TargetSelection property is set.
        /// </summary>
        internal bool IsSetTargetSelection() => this.TargetSelection != null;

        /// <summary>
        /// Gets and sets the property Targets. 
        /// <para>
        /// The devices targeted to receive OTA updates.
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
    }
}
