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
    /// Information about an OTA update.
    /// </summary>
    public partial class OTAUpdateInfo
    {
        /// <summary>
        /// Gets and sets the property AdditionalParameters. 
        /// <para>
        /// A collection of name/value pairs
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
        /// Gets and sets the property AwsIotJobArn. 
        /// <para>
        /// The IoT job ARN associated with the OTA update.
        /// </para>
        /// </summary>
        public string AwsIotJobArn { get; set; }

        /// <summary>
        /// Checks to see if the AwsIotJobArn property is set.
        /// </summary>
        internal bool IsSetAwsIotJobArn() => this.AwsIotJobArn != null;

        /// <summary>
        /// Gets and sets the property AwsIotJobId. 
        /// <para>
        /// The IoT job ID associated with the OTA update.
        /// </para>
        /// </summary>
        public string AwsIotJobId { get; set; }

        /// <summary>
        /// Checks to see if the AwsIotJobId property is set.
        /// </summary>
        internal bool IsSetAwsIotJobId() => this.AwsIotJobId != null;

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
        /// Configuration information for pre-signed URLs. Valid when <c>protocols</c> contains
        /// HTTP.
        /// </para>
        /// </summary>
        public AwsJobPresignedUrlConfig AwsJobPresignedUrlConfig { get; set; }

        /// <summary>
        /// Checks to see if the AwsJobPresignedUrlConfig property is set.
        /// </summary>
        internal bool IsSetAwsJobPresignedUrlConfig() => this.AwsJobPresignedUrlConfig != null;

        /// <summary>
        /// Gets and sets the property CreationDate. 
        /// <para>
        /// The date when the OTA update was created.
        /// </para>
        /// </summary>
        public DateTime? CreationDate { get; set; }

        /// <summary>
        /// Checks to see if the CreationDate property is set.
        /// </summary>
        internal bool IsSetCreationDate() => this.CreationDate.HasValue;

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// A description of the OTA update.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 2028)]
        public string Description { get; set; }

        /// <summary>
        /// Checks to see if the Description property is set.
        /// </summary>
        internal bool IsSetDescription() => this.Description != null;

        /// <summary>
        /// Gets and sets the property ErrorInfo. 
        /// <para>
        /// Error information associated with the OTA update.
        /// </para>
        /// </summary>
        public ErrorInfo ErrorInfo { get; set; }

        /// <summary>
        /// Checks to see if the ErrorInfo property is set.
        /// </summary>
        internal bool IsSetErrorInfo() => this.ErrorInfo != null;

        /// <summary>
        /// Gets and sets the property LastModifiedDate. 
        /// <para>
        /// The date when the OTA update was last updated.
        /// </para>
        /// </summary>
        public DateTime? LastModifiedDate { get; set; }

        /// <summary>
        /// Checks to see if the LastModifiedDate property is set.
        /// </summary>
        internal bool IsSetLastModifiedDate() => this.LastModifiedDate.HasValue;

        /// <summary>
        /// Gets and sets the property OtaUpdateArn. 
        /// <para>
        /// The OTA update ARN.
        /// </para>
        /// </summary>
        public string OtaUpdateArn { get; set; }

        /// <summary>
        /// Checks to see if the OtaUpdateArn property is set.
        /// </summary>
        internal bool IsSetOtaUpdateArn() => this.OtaUpdateArn != null;

        /// <summary>
        /// Gets and sets the property OtaUpdateFiles. 
        /// <para>
        /// A list of files associated with the OTA update.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 1)]
        public List<OTAUpdateFile> OtaUpdateFiles { get; set; } = AWSConfigs.InitializeCollections ? new List<OTAUpdateFile>() : null;

        /// <summary>
        /// Checks to see if the OtaUpdateFiles property is set.
        /// </summary>
        internal bool IsSetOtaUpdateFiles() => this.OtaUpdateFiles != null && (this.OtaUpdateFiles.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property OtaUpdateId. 
        /// <para>
        /// The OTA update ID.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 128)]
        public string OtaUpdateId { get; set; }

        /// <summary>
        /// Checks to see if the OtaUpdateId property is set.
        /// </summary>
        internal bool IsSetOtaUpdateId() => this.OtaUpdateId != null;

        /// <summary>
        /// Gets and sets the property OtaUpdateStatus. 
        /// <para>
        /// The status of the OTA update.
        /// </para>
        /// </summary>
        public OTAUpdateStatus OtaUpdateStatus { get; set; }

        /// <summary>
        /// Checks to see if the OtaUpdateStatus property is set.
        /// </summary>
        internal bool IsSetOtaUpdateStatus() => this.OtaUpdateStatus != null;

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
        /// Gets and sets the property TargetSelection. 
        /// <para>
        /// Specifies whether the OTA update will continue to run (CONTINUOUS), or will be complete
        /// after all those things specified as targets have completed the OTA update (SNAPSHOT).
        /// If continuous, the OTA update may also be run on a thing when a change is detected
        /// in a target. For example, an OTA update will run on a thing when the thing is added
        /// to a target group, even after the OTA update was completed by all things originally
        /// in the group. 
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
        /// The targets of the OTA update.
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
    }
}
