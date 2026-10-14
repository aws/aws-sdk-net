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

namespace Amazon.SageMaker.Model
{
    /// <summary>
    /// This is the response object from the DescribePartnerApp operation.
    /// </summary>
    public partial class DescribePartnerAppResponse : AmazonWebServiceResponse
    {
        /// <summary>
        /// Gets and sets the property ApplicationConfig. 
        /// <para>
        /// Configuration settings for the SageMaker Partner AI App.
        /// </para>
        /// </summary>
        public PartnerAppConfig ApplicationConfig { get; set; }

        /// <summary>
        /// Checks to see if the ApplicationConfig property is set.
        /// </summary>
        internal bool IsSetApplicationConfig() => this.ApplicationConfig != null;

        /// <summary>
        /// Gets and sets the property Arn. 
        /// <para>
        /// The ARN of the SageMaker Partner AI App that was described.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 128)]
        public string Arn { get; set; }

        /// <summary>
        /// Checks to see if the Arn property is set.
        /// </summary>
        internal bool IsSetArn() => this.Arn != null;

        /// <summary>
        /// Gets and sets the property AuthType. 
        /// <para>
        /// The authorization type that users use to access the SageMaker Partner AI App. Valid
        /// values:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>IAM</c>: Users access the SageMaker Partner AI App with their Amazon Web Services
        /// IAM identity.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>IDC</c>: Users access the SageMaker Partner AI App with their Amazon Web Services
        /// IAM Identity Center identity.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public PartnerAppAuthType AuthType { get; set; }

        /// <summary>
        /// Checks to see if the AuthType property is set.
        /// </summary>
        internal bool IsSetAuthType() => this.AuthType != null;

        /// <summary>
        /// Gets and sets the property AvailableUpgrade. 
        /// <para>
        /// A map of available minor version upgrades for the SageMaker Partner AI App. The key
        /// is the semantic version number, and the value is a list of release notes for that
        /// version. A null value indicates no upgrades are available.
        /// </para>
        /// </summary>
        public AvailableUpgrade AvailableUpgrade { get; set; }

        /// <summary>
        /// Checks to see if the AvailableUpgrade property is set.
        /// </summary>
        internal bool IsSetAvailableUpgrade() => this.AvailableUpgrade != null;

        /// <summary>
        /// Gets and sets the property BaseUrl. 
        /// <para>
        /// The URL of the SageMaker Partner AI App that the Application SDK uses to support in-app
        /// calls for the user.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 2048)]
        public string BaseUrl { get; set; }

        /// <summary>
        /// Checks to see if the BaseUrl property is set.
        /// </summary>
        internal bool IsSetBaseUrl() => this.BaseUrl != null;

        /// <summary>
        /// Gets and sets the property CreationTime. 
        /// <para>
        /// The time that the SageMaker Partner AI App was created.
        /// </para>
        /// </summary>
        public DateTime? CreationTime { get; set; }

        /// <summary>
        /// Checks to see if the CreationTime property is set.
        /// </summary>
        internal bool IsSetCreationTime() => this.CreationTime.HasValue;

        /// <summary>
        /// Gets and sets the property CurrentVersionEolDate. 
        /// <para>
        /// The end-of-life date for the current version of the SageMaker Partner AI App.
        /// </para>
        /// </summary>
        public DateTime? CurrentVersionEolDate { get; set; }

        /// <summary>
        /// Checks to see if the CurrentVersionEolDate property is set.
        /// </summary>
        internal bool IsSetCurrentVersionEolDate() => this.CurrentVersionEolDate.HasValue;

        /// <summary>
        /// Gets and sets the property EnableAutoMinorVersionUpgrade. 
        /// <para>
        /// Indicates whether the SageMaker Partner AI App is configured for automatic minor version
        /// upgrades during scheduled maintenance windows.
        /// </para>
        /// </summary>
        public bool? EnableAutoMinorVersionUpgrade { get; set; }

        /// <summary>
        /// Checks to see if the EnableAutoMinorVersionUpgrade property is set.
        /// </summary>
        internal bool IsSetEnableAutoMinorVersionUpgrade() => this.EnableAutoMinorVersionUpgrade.HasValue;

        /// <summary>
        /// Gets and sets the property EnableIamSessionBasedIdentity. 
        /// <para>
        /// When set to <c>TRUE</c>, the SageMaker Partner AI App sets the Amazon Web Services
        /// IAM session name or the authenticated IAM user as the identity of the SageMaker Partner
        /// AI App user.
        /// </para>
        /// </summary>
        public bool? EnableIamSessionBasedIdentity { get; set; }

        /// <summary>
        /// Checks to see if the EnableIamSessionBasedIdentity property is set.
        /// </summary>
        internal bool IsSetEnableIamSessionBasedIdentity() => this.EnableIamSessionBasedIdentity.HasValue;

        /// <summary>
        /// Gets and sets the property Error. 
        /// <para>
        /// This is an error field object that contains the error code and the reason for an operation
        /// failure.
        /// </para>
        /// </summary>
        public ErrorInfo Error { get; set; }

        /// <summary>
        /// Checks to see if the Error property is set.
        /// </summary>
        internal bool IsSetError() => this.Error != null;

        /// <summary>
        /// Gets and sets the property ExecutionRoleArn. 
        /// <para>
        /// The ARN of the IAM role associated with the SageMaker Partner AI App.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 20, Max = 2048)]
        public string ExecutionRoleArn { get; set; }

        /// <summary>
        /// Checks to see if the ExecutionRoleArn property is set.
        /// </summary>
        internal bool IsSetExecutionRoleArn() => this.ExecutionRoleArn != null;

        /// <summary>
        /// Gets and sets the property IdcConfig. 
        /// <para>
        /// Contains the Amazon Web Services IAM Identity Center configuration for the SageMaker
        /// Partner AI App, including the Identity Center instance and the Identity Center application
        /// that SageMaker creates for the app. The service returns this field for apps that use
        /// <c>IDC</c> authorization.
        /// </para>
        /// </summary>
        public IdcConfigOutput IdcConfig { get; set; }

        /// <summary>
        /// Checks to see if the IdcConfig property is set.
        /// </summary>
        internal bool IsSetIdcConfig() => this.IdcConfig != null;

        /// <summary>
        /// Gets and sets the property KmsKeyId. 
        /// <para>
        /// The Amazon Web Services KMS customer managed key used to encrypt the data at rest
        /// associated with SageMaker Partner AI Apps.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 2048)]
        public string KmsKeyId { get; set; }

        /// <summary>
        /// Checks to see if the KmsKeyId property is set.
        /// </summary>
        internal bool IsSetKmsKeyId() => this.KmsKeyId != null;

        /// <summary>
        /// Gets and sets the property LastModifiedTime. 
        /// <para>
        /// The time that the SageMaker Partner AI App was last modified.
        /// </para>
        /// </summary>
        public DateTime? LastModifiedTime { get; set; }

        /// <summary>
        /// Checks to see if the LastModifiedTime property is set.
        /// </summary>
        internal bool IsSetLastModifiedTime() => this.LastModifiedTime.HasValue;

        /// <summary>
        /// Gets and sets the property MaintenanceConfig. 
        /// <para>
        /// Maintenance configuration settings for the SageMaker Partner AI App.
        /// </para>
        /// </summary>
        public PartnerAppMaintenanceConfig MaintenanceConfig { get; set; }

        /// <summary>
        /// Checks to see if the MaintenanceConfig property is set.
        /// </summary>
        internal bool IsSetMaintenanceConfig() => this.MaintenanceConfig != null;

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the SageMaker Partner AI App.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 256)]
        public string Name { get; set; }

        /// <summary>
        /// Checks to see if the Name property is set.
        /// </summary>
        internal bool IsSetName() => this.Name != null;

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
        public PartnerAppStatus Status { get; set; }

        /// <summary>
        /// Checks to see if the Status property is set.
        /// </summary>
        internal bool IsSetStatus() => this.Status != null;

        /// <summary>
        /// Gets and sets the property Tier. 
        /// <para>
        /// The instance type and size of the cluster attached to the SageMaker Partner AI App.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 64)]
        public string Tier { get; set; }

        /// <summary>
        /// Checks to see if the Tier property is set.
        /// </summary>
        internal bool IsSetTier() => this.Tier != null;

        /// <summary>
        /// Gets and sets the property Type. 
        /// <para>
        /// The type of SageMaker Partner AI App. Must be one of the following: <c>lakera-guard</c>,
        /// <c>comet</c>, <c>deepchecks-llm-evaluation</c>, or <c>fiddler</c>.
        /// </para>
        /// </summary>
        public PartnerAppType Type { get; set; }

        /// <summary>
        /// Checks to see if the Type property is set.
        /// </summary>
        internal bool IsSetType() => this.Type != null;

        /// <summary>
        /// Gets and sets the property Version. 
        /// <para>
        /// The version of the SageMaker Partner AI App.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 64)]
        public string Version { get; set; }

        /// <summary>
        /// Checks to see if the Version property is set.
        /// </summary>
        internal bool IsSetVersion() => this.Version != null;
    }
}
