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
    /// Information about an OTA update.
    /// </summary>
    public partial class OTAUpdateInfo
    {
        private Dictionary<string, string> _additionalParameters = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;
        private string _awsIotJobArn;
        private string _awsIotJobId;
        private AwsJobExecutionsRolloutConfig _awsJobExecutionsRolloutConfig;
        private AwsJobPresignedUrlConfig _awsJobPresignedUrlConfig;
        private DateTime? _creationDate;
        private string _description;
        private ErrorInfo _errorInfo;
        private DateTime? _lastModifiedDate;
        private string _otaUpdateArn;
        private List<OTAUpdateFile> _otaUpdateFiles = AWSConfigs.InitializeCollections ? new List<OTAUpdateFile>() : null;
        private string _otaUpdateId;
        private OTAUpdateStatus _otaUpdateStatus;
        private List<string> _protocols = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private List<string> _targets = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private TargetSelection _targetSelection;

        /// <summary>
        /// Gets and sets the property AdditionalParameters. 
        /// <para>
        /// A collection of name/value pairs
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public Dictionary<string, string> AdditionalParameters
        {
            get { return this._additionalParameters; }
            set { this._additionalParameters = value; }
        }

        // Check to see if AdditionalParameters property is set
        internal bool IsSetAdditionalParameters()
        {
            return this._additionalParameters != null && (this._additionalParameters.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property AwsIotJobArn. 
        /// <para>
        /// The IoT job ARN associated with the OTA update.
        /// </para>
        /// </summary>
        public string AwsIotJobArn
        {
            get { return this._awsIotJobArn; }
            set { this._awsIotJobArn = value; }
        }

        // Check to see if AwsIotJobArn property is set
        internal bool IsSetAwsIotJobArn()
        {
            return this._awsIotJobArn != null;
        }

        /// <summary>
        /// Gets and sets the property AwsIotJobId. 
        /// <para>
        /// The IoT job ID associated with the OTA update.
        /// </para>
        /// </summary>
        public string AwsIotJobId
        {
            get { return this._awsIotJobId; }
            set { this._awsIotJobId = value; }
        }

        // Check to see if AwsIotJobId property is set
        internal bool IsSetAwsIotJobId()
        {
            return this._awsIotJobId != null;
        }

        /// <summary>
        /// Gets and sets the property AwsJobExecutionsRolloutConfig. 
        /// <para>
        /// Configuration for the rollout of OTA updates.
        /// </para>
        /// </summary>
        public AwsJobExecutionsRolloutConfig AwsJobExecutionsRolloutConfig
        {
            get { return this._awsJobExecutionsRolloutConfig; }
            set { this._awsJobExecutionsRolloutConfig = value; }
        }

        // Check to see if AwsJobExecutionsRolloutConfig property is set
        internal bool IsSetAwsJobExecutionsRolloutConfig()
        {
            return this._awsJobExecutionsRolloutConfig != null;
        }

        /// <summary>
        /// Gets and sets the property AwsJobPresignedUrlConfig. 
        /// <para>
        /// Configuration information for pre-signed URLs. Valid when <c>protocols</c> contains
        /// HTTP.
        /// </para>
        /// </summary>
        public AwsJobPresignedUrlConfig AwsJobPresignedUrlConfig
        {
            get { return this._awsJobPresignedUrlConfig; }
            set { this._awsJobPresignedUrlConfig = value; }
        }

        // Check to see if AwsJobPresignedUrlConfig property is set
        internal bool IsSetAwsJobPresignedUrlConfig()
        {
            return this._awsJobPresignedUrlConfig != null;
        }

        /// <summary>
        /// Gets and sets the property CreationDate. 
        /// <para>
        /// The date when the OTA update was created.
        /// </para>
        /// </summary>
        public DateTime? CreationDate
        {
            get { return this._creationDate; }
            set { this._creationDate = value; }
        }

        // Check to see if CreationDate property is set
        internal bool IsSetCreationDate()
        {
            return this._creationDate.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// A description of the OTA update.
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
        /// Gets and sets the property ErrorInfo. 
        /// <para>
        /// Error information associated with the OTA update.
        /// </para>
        /// </summary>
        public ErrorInfo ErrorInfo
        {
            get { return this._errorInfo; }
            set { this._errorInfo = value; }
        }

        // Check to see if ErrorInfo property is set
        internal bool IsSetErrorInfo()
        {
            return this._errorInfo != null;
        }

        /// <summary>
        /// Gets and sets the property LastModifiedDate. 
        /// <para>
        /// The date when the OTA update was last updated.
        /// </para>
        /// </summary>
        public DateTime? LastModifiedDate
        {
            get { return this._lastModifiedDate; }
            set { this._lastModifiedDate = value; }
        }

        // Check to see if LastModifiedDate property is set
        internal bool IsSetLastModifiedDate()
        {
            return this._lastModifiedDate.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property OtaUpdateArn. 
        /// <para>
        /// The OTA update ARN.
        /// </para>
        /// </summary>
        public string OtaUpdateArn
        {
            get { return this._otaUpdateArn; }
            set { this._otaUpdateArn = value; }
        }

        // Check to see if OtaUpdateArn property is set
        internal bool IsSetOtaUpdateArn()
        {
            return this._otaUpdateArn != null;
        }

        /// <summary>
        /// Gets and sets the property OtaUpdateFiles. 
        /// <para>
        /// A list of files associated with the OTA update.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=1)]
        public List<OTAUpdateFile> OtaUpdateFiles
        {
            get { return this._otaUpdateFiles; }
            set { this._otaUpdateFiles = value; }
        }

        // Check to see if OtaUpdateFiles property is set
        internal bool IsSetOtaUpdateFiles()
        {
            return this._otaUpdateFiles != null && (this._otaUpdateFiles.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property OtaUpdateId. 
        /// <para>
        /// The OTA update ID.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=128)]
        public string OtaUpdateId
        {
            get { return this._otaUpdateId; }
            set { this._otaUpdateId = value; }
        }

        // Check to see if OtaUpdateId property is set
        internal bool IsSetOtaUpdateId()
        {
            return this._otaUpdateId != null;
        }

        /// <summary>
        /// Gets and sets the property OtaUpdateStatus. 
        /// <para>
        /// The status of the OTA update.
        /// </para>
        /// </summary>
        public OTAUpdateStatus OtaUpdateStatus
        {
            get { return this._otaUpdateStatus; }
            set { this._otaUpdateStatus = value; }
        }

        // Check to see if OtaUpdateStatus property is set
        internal bool IsSetOtaUpdateStatus()
        {
            return this._otaUpdateStatus != null;
        }

        /// <summary>
        /// Gets and sets the property Protocols. 
        /// <para>
        /// The protocol used to transfer the OTA update image. Valid values are [HTTP], [MQTT],
        /// [HTTP, MQTT]. When both HTTP and MQTT are specified, the target device can choose
        /// the protocol.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=1, Max=2)]
        public List<string> Protocols
        {
            get { return this._protocols; }
            set { this._protocols = value; }
        }

        // Check to see if Protocols property is set
        internal bool IsSetProtocols()
        {
            return this._protocols != null && (this._protocols.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property Targets. 
        /// <para>
        /// The targets of the OTA update.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=1)]
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
        /// Specifies whether the OTA update will continue to run (CONTINUOUS), or will be complete
        /// after all those things specified as targets have completed the OTA update (SNAPSHOT).
        /// If continuous, the OTA update may also be run on a thing when a change is detected
        /// in a target. For example, an OTA update will run on a thing when the thing is added
        /// to a target group, even after the OTA update was completed by all things originally
        /// in the group. 
        /// </para>
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

    }
}