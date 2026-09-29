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

namespace Amazon.QBusiness.Model
{
    /// <summary>
    /// This is the response object from the GetApplication operation.
    /// </summary>
    public partial class GetApplicationResponse : AmazonWebServiceResponse
    {
        /// <summary>
        /// Gets and sets the property ApplicationArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the Amazon Q Business application.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 1284)]
        public string ApplicationArn { get; set; }

        /// <summary>
        /// Checks to see if the ApplicationArn property is set.
        /// </summary>
        internal bool IsSetApplicationArn() => this.ApplicationArn != null;

        /// <summary>
        /// Gets and sets the property ApplicationId. 
        /// <para>
        /// The identifier of the Amazon Q Business application.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 36, Max = 36)]
        public string ApplicationId { get; set; }

        /// <summary>
        /// Checks to see if the ApplicationId property is set.
        /// </summary>
        internal bool IsSetApplicationId() => this.ApplicationId != null;

        /// <summary>
        /// Gets and sets the property AttachmentsConfiguration. 
        /// <para>
        /// Settings for whether end users can upload files directly during chat.
        /// </para>
        /// </summary>
        public AppliedAttachmentsConfiguration AttachmentsConfiguration { get; set; }

        /// <summary>
        /// Checks to see if the AttachmentsConfiguration property is set.
        /// </summary>
        internal bool IsSetAttachmentsConfiguration() => this.AttachmentsConfiguration != null;

        /// <summary>
        /// Gets and sets the property AutoSubscriptionConfiguration. 
        /// <para>
        /// Settings for auto-subscription behavior for this application. This is only applicable
        /// to SAML and OIDC applications.
        /// </para>
        /// </summary>
        public AutoSubscriptionConfiguration AutoSubscriptionConfiguration { get; set; }

        /// <summary>
        /// Checks to see if the AutoSubscriptionConfiguration property is set.
        /// </summary>
        internal bool IsSetAutoSubscriptionConfiguration() => this.AutoSubscriptionConfiguration != null;

        /// <summary>
        /// Gets and sets the property ClientIdsForOIDC. 
        /// <para>
        /// The OIDC client ID for a Amazon Q Business application.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> ClientIdsForOIDC { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the ClientIdsForOIDC property is set.
        /// </summary>
        internal bool IsSetClientIdsForOIDC() => this.ClientIdsForOIDC != null && (this.ClientIdsForOIDC.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property CreatedAt. 
        /// <para>
        /// The Unix timestamp when the Amazon Q Business application was last updated.
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
        /// A description for the Amazon Q Business application.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 1000)]
        public string Description { get; set; }

        /// <summary>
        /// Checks to see if the Description property is set.
        /// </summary>
        internal bool IsSetDescription() => this.Description != null;

        /// <summary>
        /// Gets and sets the property DisplayName. 
        /// <para>
        /// The name of the Amazon Q Business application.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 1000)]
        public string DisplayName { get; set; }

        /// <summary>
        /// Checks to see if the DisplayName property is set.
        /// </summary>
        internal bool IsSetDisplayName() => this.DisplayName != null;

        /// <summary>
        /// Gets and sets the property EncryptionConfiguration. 
        /// <para>
        /// The identifier of the Amazon Web Services KMS key that is used to encrypt your data.
        /// Amazon Q Business doesn't support asymmetric keys.
        /// </para>
        /// </summary>
        public EncryptionConfiguration EncryptionConfiguration { get; set; }

        /// <summary>
        /// Checks to see if the EncryptionConfiguration property is set.
        /// </summary>
        internal bool IsSetEncryptionConfiguration() => this.EncryptionConfiguration != null;

        /// <summary>
        /// Gets and sets the property Error. 
        /// <para>
        /// If the <c>Status</c> field is set to <c>ERROR</c>, the <c>ErrorMessage</c> field contains
        /// a description of the error that caused the synchronization to fail.
        /// </para>
        /// </summary>
        public ErrorDetail Error { get; set; }

        /// <summary>
        /// Checks to see if the Error property is set.
        /// </summary>
        internal bool IsSetError() => this.Error != null;

        /// <summary>
        /// Gets and sets the property IamIdentityProviderArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of an identity provider being used by an Amazon Q Business
        /// application.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 20, Max = 2048)]
        public string IamIdentityProviderArn { get; set; }

        /// <summary>
        /// Checks to see if the IamIdentityProviderArn property is set.
        /// </summary>
        internal bool IsSetIamIdentityProviderArn() => this.IamIdentityProviderArn != null;

        /// <summary>
        /// Gets and sets the property IdentityCenterApplicationArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the AWS IAM Identity Center instance attached to
        /// your Amazon Q Business application.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 10, Max = 1224)]
        public string IdentityCenterApplicationArn { get; set; }

        /// <summary>
        /// Checks to see if the IdentityCenterApplicationArn property is set.
        /// </summary>
        internal bool IsSetIdentityCenterApplicationArn() => this.IdentityCenterApplicationArn != null;

        /// <summary>
        /// Gets and sets the property IdentityType. 
        /// <para>
        /// The authentication type being used by a Amazon Q Business application.
        /// </para>
        /// </summary>
        public IdentityType IdentityType { get; set; }

        /// <summary>
        /// Checks to see if the IdentityType property is set.
        /// </summary>
        internal bool IsSetIdentityType() => this.IdentityType != null;

        /// <summary>
        /// Gets and sets the property PersonalizationConfiguration. 
        /// <para>
        /// Configuration information about chat response personalization. For more information,
        /// see <a href="https://docs.aws.amazon.com/amazonq/latest/qbusiness-ug/personalizing-chat-responses.html">Personalizing
        /// chat responses</a>.
        /// </para>
        /// </summary>
        public PersonalizationConfiguration PersonalizationConfiguration { get; set; }

        /// <summary>
        /// Checks to see if the PersonalizationConfiguration property is set.
        /// </summary>
        internal bool IsSetPersonalizationConfiguration() => this.PersonalizationConfiguration != null;

        /// <summary>
        /// Gets and sets the property QAppsConfiguration. 
        /// <para>
        /// Settings for whether end users can create and use Amazon Q Apps in the web experience.
        /// </para>
        /// </summary>
        public QAppsConfiguration QAppsConfiguration { get; set; }

        /// <summary>
        /// Checks to see if the QAppsConfiguration property is set.
        /// </summary>
        internal bool IsSetQAppsConfiguration() => this.QAppsConfiguration != null;

        /// <summary>
        /// Gets and sets the property QuickSightConfiguration. 
        /// <para>
        /// The Amazon Quick Suite authentication configuration for the Amazon Q Business application.
        /// </para>
        /// </summary>
        public QuickSightConfiguration QuickSightConfiguration { get; set; }

        /// <summary>
        /// Checks to see if the QuickSightConfiguration property is set.
        /// </summary>
        internal bool IsSetQuickSightConfiguration() => this.QuickSightConfiguration != null;

        /// <summary>
        /// Gets and sets the property RoleArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the IAM with permissions to access your CloudWatch
        /// logs and metrics.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 1284)]
        public string RoleArn { get; set; }

        /// <summary>
        /// Checks to see if the RoleArn property is set.
        /// </summary>
        internal bool IsSetRoleArn() => this.RoleArn != null;

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The status of the Amazon Q Business application.
        /// </para>
        /// </summary>
        public ApplicationStatus Status { get; set; }

        /// <summary>
        /// Checks to see if the Status property is set.
        /// </summary>
        internal bool IsSetStatus() => this.Status != null;

        /// <summary>
        /// Gets and sets the property UpdatedAt. 
        /// <para>
        /// The Unix timestamp when the Amazon Q Business application was last updated.
        /// </para>
        /// </summary>
        public DateTime? UpdatedAt { get; set; }

        /// <summary>
        /// Checks to see if the UpdatedAt property is set.
        /// </summary>
        internal bool IsSetUpdatedAt() => this.UpdatedAt.HasValue;
    }
}
