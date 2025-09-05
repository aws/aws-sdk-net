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
 * Do not modify this file. This file is generated from the sagemaker-2017-07-24.normal.json service model.
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
namespace Amazon.SageMaker.Model
{
    /// <summary>
    /// This is the response object from the DescribePartnerApp operation.
    /// </summary>
    public partial class DescribePartnerAppResponse : AmazonWebServiceResponse
    {
        private PartnerAppConfig _applicationConfig;
        private string _arn;
        private PartnerAppAuthType _authType;
        private string _baseUrl;
        private DateTime? _creationTime;
        private bool? _enableIamSessionBasedIdentity;
        private ErrorInfo _error;
        private string _executionRoleArn;
        private string _kmsKeyId;
        private DateTime? _lastModifiedTime;
        private PartnerAppMaintenanceConfig _maintenanceConfig;
        private string _name;
        private PartnerAppStatus _status;
        private string _tier;
        private PartnerAppType _type;
        private string _version;

        /// <summary>
        /// Gets and sets the property ApplicationConfig. 
        /// <para>
        /// Configuration settings for the SageMaker Partner AI App.
        /// </para>
        /// </summary>
        public PartnerAppConfig ApplicationConfig
        {
            get { return this._applicationConfig; }
            set { this._applicationConfig = value; }
        }

        // Check to see if ApplicationConfig property is set
        internal bool IsSetApplicationConfig()
        {
            return this._applicationConfig != null;
        }

        /// <summary>
        /// Gets and sets the property Arn. 
        /// <para>
        /// The ARN of the SageMaker Partner AI App that was described.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=128)]
        public string Arn
        {
            get { return this._arn; }
            set { this._arn = value; }
        }

        // Check to see if Arn property is set
        internal bool IsSetArn()
        {
            return this._arn != null;
        }

        /// <summary>
        /// Gets and sets the property AuthType. 
        /// <para>
        /// The authorization type that users use to access the SageMaker Partner AI App.
        /// </para>
        /// </summary>
        public PartnerAppAuthType AuthType
        {
            get { return this._authType; }
            set { this._authType = value; }
        }

        // Check to see if AuthType property is set
        internal bool IsSetAuthType()
        {
            return this._authType != null;
        }

        /// <summary>
        /// Gets and sets the property BaseUrl. 
        /// <para>
        /// The URL of the SageMaker Partner AI App that the Application SDK uses to support in-app
        /// calls for the user.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=2048)]
        public string BaseUrl
        {
            get { return this._baseUrl; }
            set { this._baseUrl = value; }
        }

        // Check to see if BaseUrl property is set
        internal bool IsSetBaseUrl()
        {
            return this._baseUrl != null;
        }

        /// <summary>
        /// Gets and sets the property CreationTime. 
        /// <para>
        /// The time that the SageMaker Partner AI App was created.
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
        /// Gets and sets the property EnableIamSessionBasedIdentity. 
        /// <para>
        /// When set to <c>TRUE</c>, the SageMaker Partner AI App sets the Amazon Web Services
        /// IAM session name or the authenticated IAM user as the identity of the SageMaker Partner
        /// AI App user.
        /// </para>
        /// </summary>
        public bool? EnableIamSessionBasedIdentity
        {
            get { return this._enableIamSessionBasedIdentity; }
            set { this._enableIamSessionBasedIdentity = value; }
        }

        // Check to see if EnableIamSessionBasedIdentity property is set
        internal bool IsSetEnableIamSessionBasedIdentity()
        {
            return this._enableIamSessionBasedIdentity.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Error. 
        /// <para>
        /// This is an error field object that contains the error code and the reason for an operation
        /// failure.
        /// </para>
        /// </summary>
        public ErrorInfo Error
        {
            get { return this._error; }
            set { this._error = value; }
        }

        // Check to see if Error property is set
        internal bool IsSetError()
        {
            return this._error != null;
        }

        /// <summary>
        /// Gets and sets the property ExecutionRoleArn. 
        /// <para>
        /// The ARN of the IAM role associated with the SageMaker Partner AI App.
        /// </para>
        /// </summary>
        [AWSProperty(Min=20, Max=2048)]
        public string ExecutionRoleArn
        {
            get { return this._executionRoleArn; }
            set { this._executionRoleArn = value; }
        }

        // Check to see if ExecutionRoleArn property is set
        internal bool IsSetExecutionRoleArn()
        {
            return this._executionRoleArn != null;
        }

        /// <summary>
        /// Gets and sets the property KmsKeyId. 
        /// <para>
        /// The Amazon Web Services KMS customer managed key used to encrypt the data at rest
        /// associated with SageMaker Partner AI Apps.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=2048)]
        public string KmsKeyId
        {
            get { return this._kmsKeyId; }
            set { this._kmsKeyId = value; }
        }

        // Check to see if KmsKeyId property is set
        internal bool IsSetKmsKeyId()
        {
            return this._kmsKeyId != null;
        }

        /// <summary>
        /// Gets and sets the property LastModifiedTime. 
        /// <para>
        /// The time that the SageMaker Partner AI App was last modified.
        /// </para>
        /// </summary>
        public DateTime? LastModifiedTime
        {
            get { return this._lastModifiedTime; }
            set { this._lastModifiedTime = value; }
        }

        // Check to see if LastModifiedTime property is set
        internal bool IsSetLastModifiedTime()
        {
            return this._lastModifiedTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property MaintenanceConfig. 
        /// <para>
        /// Maintenance configuration settings for the SageMaker Partner AI App.
        /// </para>
        /// </summary>
        public PartnerAppMaintenanceConfig MaintenanceConfig
        {
            get { return this._maintenanceConfig; }
            set { this._maintenanceConfig = value; }
        }

        // Check to see if MaintenanceConfig property is set
        internal bool IsSetMaintenanceConfig()
        {
            return this._maintenanceConfig != null;
        }

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the SageMaker Partner AI App.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=256)]
        public string Name
        {
            get { return this._name; }
            set { this._name = value; }
        }

        // Check to see if Name property is set
        internal bool IsSetName()
        {
            return this._name != null;
        }

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The status of the SageMaker Partner AI App.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Creating: SageMaker AI is creating the partner AI app. The partner AI app is not available
        /// during creation.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Updating: SageMaker AI is updating the partner AI app. The partner AI app is not available
        /// when updating.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Deleting: SageMaker AI is deleting the partner AI app. The partner AI app is not available
        /// during deletion.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Available: The partner AI app is provisioned and accessible.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Failed: The partner AI app is in a failed state and isn't available. SageMaker AI
        /// is investigating the issue. For further guidance, contact Amazon Web Services Support.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// UpdateFailed: The partner AI app couldn't be updated but is available.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Deleted: The partner AI app is permanently deleted and not available.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public PartnerAppStatus Status
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
        /// Gets and sets the property Tier. 
        /// <para>
        /// The instance type and size of the cluster attached to the SageMaker Partner AI App.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=64)]
        public string Tier
        {
            get { return this._tier; }
            set { this._tier = value; }
        }

        // Check to see if Tier property is set
        internal bool IsSetTier()
        {
            return this._tier != null;
        }

        /// <summary>
        /// Gets and sets the property Type. 
        /// <para>
        /// The type of SageMaker Partner AI App. Must be one of the following: <c>lakera-guard</c>,
        /// <c>comet</c>, <c>deepchecks-llm-evaluation</c>, or <c>fiddler</c>.
        /// </para>
        /// </summary>
        public PartnerAppType Type
        {
            get { return this._type; }
            set { this._type = value; }
        }

        // Check to see if Type property is set
        internal bool IsSetType()
        {
            return this._type != null;
        }

        /// <summary>
        /// Gets and sets the property Version. 
        /// <para>
        /// The version of the SageMaker Partner AI App.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=64)]
        public string Version
        {
            get { return this._version; }
            set { this._version = value; }
        }

        // Check to see if Version property is set
        internal bool IsSetVersion()
        {
            return this._version != null;
        }

    }
}