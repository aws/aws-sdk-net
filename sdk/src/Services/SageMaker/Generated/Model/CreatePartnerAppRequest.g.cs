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
    /// Container for the parameters to the CreatePartnerApp operation. Creates an Amazon
    /// SageMaker Partner AI App.
    /// </summary>
    public partial class CreatePartnerAppRequest : AmazonSageMakerRequest
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
        /// IAM Identity Center identity. Specify the Identity Center instance to use in <c>IdcConfig</c>.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        [AWSProperty(Required = true)]
        public PartnerAppAuthType AuthType { get; set; }

        /// <summary>
        /// Checks to see if the AuthType property is set.
        /// </summary>
        internal bool IsSetAuthType() => this.AuthType != null;

        /// <summary>
        /// Gets and sets the property ClientToken. 
        /// <para>
        /// A unique token that guarantees that the call to this API is idempotent.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 36)]
        public string ClientToken { get; set; }

        /// <summary>
        /// Checks to see if the ClientToken property is set.
        /// </summary>
        internal bool IsSetClientToken() => this.ClientToken != null;

        /// <summary>
        /// Gets and sets the property EnableAutoMinorVersionUpgrade. 
        /// <para>
        /// When set to <c>TRUE</c>, the SageMaker Partner AI App is automatically upgraded to
        /// the latest minor version during the next scheduled maintenance window, if one is available.
        /// Default is <c>FALSE</c>.
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
        /// Gets and sets the property ExecutionRoleArn. 
        /// <para>
        /// The ARN of the IAM role that the partner application uses.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 20, Max = 2048)]
        public string ExecutionRoleArn { get; set; }

        /// <summary>
        /// Checks to see if the ExecutionRoleArn property is set.
        /// </summary>
        internal bool IsSetExecutionRoleArn() => this.ExecutionRoleArn != null;

        /// <summary>
        /// Gets and sets the property IdcConfig. 
        /// <para>
        /// Specifies the Amazon Web Services IAM Identity Center configuration for the SageMaker
        /// Partner AI App. Specify this parameter when <c>AuthType</c> is <c>IDC</c>. Apps that
        /// use <c>IAM</c> authorization don't use this parameter.
        /// </para>
        /// </summary>
        public IdcConfigInput IdcConfig { get; set; }

        /// <summary>
        /// Checks to see if the IdcConfig property is set.
        /// </summary>
        internal bool IsSetIdcConfig() => this.IdcConfig != null;

        /// <summary>
        /// Gets and sets the property KmsKeyId. 
        /// <para>
        /// SageMaker Partner AI Apps uses Amazon Web Services KMS to encrypt data at rest using
        /// an Amazon Web Services managed key by default. For more control, specify a customer
        /// managed key.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 2048)]
        public string KmsKeyId { get; set; }

        /// <summary>
        /// Checks to see if the KmsKeyId property is set.
        /// </summary>
        internal bool IsSetKmsKeyId() => this.KmsKeyId != null;

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
        /// The name to give the SageMaker Partner AI App.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 256)]
        public string Name { get; set; }

        /// <summary>
        /// Checks to see if the Name property is set.
        /// </summary>
        internal bool IsSetName() => this.Name != null;

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// Each tag consists of a key and an optional value. Tag keys must be unique per resource.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 0, Max = 50)]
        public List<Tag> Tags { get; set; } = AWSConfigs.InitializeCollections ? new List<Tag>() : null;

        /// <summary>
        /// Checks to see if the Tags property is set.
        /// </summary>
        internal bool IsSetTags() => this.Tags != null && (this.Tags.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property Tier. 
        /// <para>
        /// Indicates the instance type and size of the cluster attached to the SageMaker Partner
        /// AI App.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 0, Max = 64)]
        public string Tier { get; set; }

        /// <summary>
        /// Checks to see if the Tier property is set.
        /// </summary>
        internal bool IsSetTier() => this.Tier != null;

        /// <summary>
        /// Gets and sets the property Type. 
        /// <para>
        /// The type of SageMaker Partner AI App to create. Must be one of the following: <c>lakera-guard</c>,
        /// <c>comet</c>, <c>deepchecks-llm-evaluation</c>, or <c>fiddler</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public PartnerAppType Type { get; set; }

        /// <summary>
        /// Checks to see if the Type property is set.
        /// </summary>
        internal bool IsSetType() => this.Type != null;
    }
}
