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
 * Do not modify this file. This file is generated from the qbusiness-2023-11-27.normal.json service model.
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
        private string _applicationArn;
        private string _applicationId;
        private AppliedAttachmentsConfiguration _attachmentsConfiguration;
        private AutoSubscriptionConfiguration _autoSubscriptionConfiguration;
        private List<string> _clientIdsForOIDC = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private DateTime? _createdAt;
        private string _description;
        private string _displayName;
        private EncryptionConfiguration _encryptionConfiguration;
        private ErrorDetail _error;
        private string _iamIdentityProviderArn;
        private string _identityCenterApplicationArn;
        private IdentityType _identityType;
        private PersonalizationConfiguration _personalizationConfiguration;
        private QAppsConfiguration _qAppsConfiguration;
        private QuickSightConfiguration _quickSightConfiguration;
        private string _roleArn;
        private ApplicationStatus _status;
        private DateTime? _updatedAt;

        /// <summary>
        /// Gets and sets the property ApplicationArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the Amazon Q Business application.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=1284)]
        public string ApplicationArn
        {
            get { return this._applicationArn; }
            set { this._applicationArn = value; }
        }

        // Check to see if ApplicationArn property is set
        internal bool IsSetApplicationArn()
        {
            return this._applicationArn != null;
        }

        /// <summary>
        /// Gets and sets the property ApplicationId. 
        /// <para>
        /// The identifier of the Amazon Q Business application.
        /// </para>
        /// </summary>
        [AWSProperty(Min=36, Max=36)]
        public string ApplicationId
        {
            get { return this._applicationId; }
            set { this._applicationId = value; }
        }

        // Check to see if ApplicationId property is set
        internal bool IsSetApplicationId()
        {
            return this._applicationId != null;
        }

        /// <summary>
        /// Gets and sets the property AttachmentsConfiguration. 
        /// <para>
        /// Settings for whether end users can upload files directly during chat.
        /// </para>
        /// </summary>
        public AppliedAttachmentsConfiguration AttachmentsConfiguration
        {
            get { return this._attachmentsConfiguration; }
            set { this._attachmentsConfiguration = value; }
        }

        // Check to see if AttachmentsConfiguration property is set
        internal bool IsSetAttachmentsConfiguration()
        {
            return this._attachmentsConfiguration != null;
        }

        /// <summary>
        /// Gets and sets the property AutoSubscriptionConfiguration. 
        /// <para>
        /// Settings for auto-subscription behavior for this application. This is only applicable
        /// to SAML and OIDC applications.
        /// </para>
        /// </summary>
        public AutoSubscriptionConfiguration AutoSubscriptionConfiguration
        {
            get { return this._autoSubscriptionConfiguration; }
            set { this._autoSubscriptionConfiguration = value; }
        }

        // Check to see if AutoSubscriptionConfiguration property is set
        internal bool IsSetAutoSubscriptionConfiguration()
        {
            return this._autoSubscriptionConfiguration != null;
        }

        /// <summary>
        /// Gets and sets the property ClientIdsForOIDC. 
        /// <para>
        /// The OIDC client ID for a Amazon Q Business application.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> ClientIdsForOIDC
        {
            get { return this._clientIdsForOIDC; }
            set { this._clientIdsForOIDC = value; }
        }

        // Check to see if ClientIdsForOIDC property is set
        internal bool IsSetClientIdsForOIDC()
        {
            return this._clientIdsForOIDC != null && (this._clientIdsForOIDC.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property CreatedAt. 
        /// <para>
        /// The Unix timestamp when the Amazon Q Business application was last updated.
        /// </para>
        /// </summary>
        public DateTime? CreatedAt
        {
            get { return this._createdAt; }
            set { this._createdAt = value; }
        }

        // Check to see if CreatedAt property is set
        internal bool IsSetCreatedAt()
        {
            return this._createdAt.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// A description for the Amazon Q Business application.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=1000)]
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
        /// Gets and sets the property DisplayName. 
        /// <para>
        /// The name of the Amazon Q Business application.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=1000)]
        public string DisplayName
        {
            get { return this._displayName; }
            set { this._displayName = value; }
        }

        // Check to see if DisplayName property is set
        internal bool IsSetDisplayName()
        {
            return this._displayName != null;
        }

        /// <summary>
        /// Gets and sets the property EncryptionConfiguration. 
        /// <para>
        /// The identifier of the Amazon Web Services KMS key that is used to encrypt your data.
        /// Amazon Q Business doesn't support asymmetric keys.
        /// </para>
        /// </summary>
        public EncryptionConfiguration EncryptionConfiguration
        {
            get { return this._encryptionConfiguration; }
            set { this._encryptionConfiguration = value; }
        }

        // Check to see if EncryptionConfiguration property is set
        internal bool IsSetEncryptionConfiguration()
        {
            return this._encryptionConfiguration != null;
        }

        /// <summary>
        /// Gets and sets the property Error. 
        /// <para>
        /// If the <c>Status</c> field is set to <c>ERROR</c>, the <c>ErrorMessage</c> field contains
        /// a description of the error that caused the synchronization to fail.
        /// </para>
        /// </summary>
        public ErrorDetail Error
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
        /// Gets and sets the property IamIdentityProviderArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of an identity provider being used by an Amazon Q Business
        /// application.
        /// </para>
        /// </summary>
        [AWSProperty(Min=20, Max=2048)]
        public string IamIdentityProviderArn
        {
            get { return this._iamIdentityProviderArn; }
            set { this._iamIdentityProviderArn = value; }
        }

        // Check to see if IamIdentityProviderArn property is set
        internal bool IsSetIamIdentityProviderArn()
        {
            return this._iamIdentityProviderArn != null;
        }

        /// <summary>
        /// Gets and sets the property IdentityCenterApplicationArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the AWS IAM Identity Center instance attached to
        /// your Amazon Q Business application.
        /// </para>
        /// </summary>
        [AWSProperty(Min=10, Max=1224)]
        public string IdentityCenterApplicationArn
        {
            get { return this._identityCenterApplicationArn; }
            set { this._identityCenterApplicationArn = value; }
        }

        // Check to see if IdentityCenterApplicationArn property is set
        internal bool IsSetIdentityCenterApplicationArn()
        {
            return this._identityCenterApplicationArn != null;
        }

        /// <summary>
        /// Gets and sets the property IdentityType. 
        /// <para>
        /// The authentication type being used by a Amazon Q Business application.
        /// </para>
        /// </summary>
        public IdentityType IdentityType
        {
            get { return this._identityType; }
            set { this._identityType = value; }
        }

        // Check to see if IdentityType property is set
        internal bool IsSetIdentityType()
        {
            return this._identityType != null;
        }

        /// <summary>
        /// Gets and sets the property PersonalizationConfiguration. 
        /// <para>
        /// Configuration information about chat response personalization. For more information,
        /// see <a href="https://docs.aws.amazon.com/amazonq/latest/qbusiness-ug/personalizing-chat-responses.html">Personalizing
        /// chat responses</a>.
        /// </para>
        /// </summary>
        public PersonalizationConfiguration PersonalizationConfiguration
        {
            get { return this._personalizationConfiguration; }
            set { this._personalizationConfiguration = value; }
        }

        // Check to see if PersonalizationConfiguration property is set
        internal bool IsSetPersonalizationConfiguration()
        {
            return this._personalizationConfiguration != null;
        }

        /// <summary>
        /// Gets and sets the property QAppsConfiguration. 
        /// <para>
        /// Settings for whether end users can create and use Amazon Q Apps in the web experience.
        /// </para>
        /// </summary>
        public QAppsConfiguration QAppsConfiguration
        {
            get { return this._qAppsConfiguration; }
            set { this._qAppsConfiguration = value; }
        }

        // Check to see if QAppsConfiguration property is set
        internal bool IsSetQAppsConfiguration()
        {
            return this._qAppsConfiguration != null;
        }

        /// <summary>
        /// Gets and sets the property QuickSightConfiguration. 
        /// <para>
        /// The Amazon QuickSight authentication configuration for the Amazon Q Business application.
        /// </para>
        /// </summary>
        public QuickSightConfiguration QuickSightConfiguration
        {
            get { return this._quickSightConfiguration; }
            set { this._quickSightConfiguration = value; }
        }

        // Check to see if QuickSightConfiguration property is set
        internal bool IsSetQuickSightConfiguration()
        {
            return this._quickSightConfiguration != null;
        }

        /// <summary>
        /// Gets and sets the property RoleArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the IAM with permissions to access your CloudWatch
        /// logs and metrics.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=1284)]
        public string RoleArn
        {
            get { return this._roleArn; }
            set { this._roleArn = value; }
        }

        // Check to see if RoleArn property is set
        internal bool IsSetRoleArn()
        {
            return this._roleArn != null;
        }

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The status of the Amazon Q Business application.
        /// </para>
        /// </summary>
        public ApplicationStatus Status
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
        /// Gets and sets the property UpdatedAt. 
        /// <para>
        /// The Unix timestamp when the Amazon Q Business application was last updated.
        /// </para>
        /// </summary>
        public DateTime? UpdatedAt
        {
            get { return this._updatedAt; }
            set { this._updatedAt = value; }
        }

        // Check to see if UpdatedAt property is set
        internal bool IsSetUpdatedAt()
        {
            return this._updatedAt.HasValue; 
        }

    }
}