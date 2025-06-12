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
    /// Container for the parameters to the CreateApplication operation.
    /// Creates an Amazon Q Business application.
    /// 
    ///  <note> 
    /// <para>
    /// There are new tiers for Amazon Q Business. Not all features in Amazon Q Business Pro
    /// are also available in Amazon Q Business Lite. For information on what's included in
    /// Amazon Q Business Lite and what's included in Amazon Q Business Pro, see <a href="https://docs.aws.amazon.com/amazonq/latest/qbusiness-ug/tiers.html#user-sub-tiers">Amazon
    /// Q Business tiers</a>. You must use the Amazon Q Business console to assign subscription
    /// tiers to users. 
    /// </para>
    ///  
    /// <para>
    /// An Amazon Q Apps service linked role will be created if it's absent in the Amazon
    /// Web Services account when <c>QAppsConfiguration</c> is enabled in the request. For
    /// more information, see <a href="https://docs.aws.amazon.com/amazonq/latest/qbusiness-ug/using-service-linked-roles-qapps.html">
    /// Using service-linked roles for Q Apps</a>.
    /// </para>
    ///  
    /// <para>
    /// When you create an application, Amazon Q Business may securely transmit data for processing
    /// from your selected Amazon Web Services region, but within your geography. For more
    /// information, see <a href="https://docs.aws.amazon.com/amazonq/latest/qbusiness-ug/cross-region-inference.html">Cross
    /// region inference in Amazon Q Business</a>.
    /// </para>
    ///  </note>
    /// </summary>
    public partial class CreateApplicationRequest : AmazonQBusinessRequest
    {
        private AttachmentsConfiguration _attachmentsConfiguration;
        private List<string> _clientIdsForOIDC = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private string _clientToken;
        private string _description;
        private string _displayName;
        private EncryptionConfiguration _encryptionConfiguration;
        private string _iamIdentityProviderArn;
        private string _identityCenterInstanceArn;
        private IdentityType _identityType;
        private PersonalizationConfiguration _personalizationConfiguration;
        private QAppsConfiguration _qAppsConfiguration;
        private QuickSightConfiguration _quickSightConfiguration;
        private string _roleArn;
        private List<Tag> _tags = AWSConfigs.InitializeCollections ? new List<Tag>() : null;

        /// <summary>
        /// Gets and sets the property AttachmentsConfiguration. 
        /// <para>
        /// An option to allow end users to upload files directly during chat.
        /// </para>
        /// </summary>
        public AttachmentsConfiguration AttachmentsConfiguration
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
        /// Gets and sets the property ClientToken. 
        /// <para>
        /// A token that you provide to identify the request to create your Amazon Q Business
        /// application.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=100)]
        public string ClientToken
        {
            get { return this._clientToken; }
            set { this._clientToken = value; }
        }

        // Check to see if ClientToken property is set
        internal bool IsSetClientToken()
        {
            return this._clientToken != null;
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
        /// A name for the Amazon Q Business application. 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=1000)]
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
        /// The identifier of the KMS key that is used to encrypt your data. Amazon Q Business
        /// doesn't support asymmetric keys.
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
        /// Gets and sets the property IdentityCenterInstanceArn. 
        /// <para>
        ///  The Amazon Resource Name (ARN) of the IAM Identity Center instance you are either
        /// creating for—or connecting to—your Amazon Q Business application.
        /// </para>
        /// </summary>
        [AWSProperty(Min=10, Max=1224)]
        public string IdentityCenterInstanceArn
        {
            get { return this._identityCenterInstanceArn; }
            set { this._identityCenterInstanceArn = value; }
        }

        // Check to see if IdentityCenterInstanceArn property is set
        internal bool IsSetIdentityCenterInstanceArn()
        {
            return this._identityCenterInstanceArn != null;
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
        /// chat responses</a> 
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
        /// An option to allow end users to create and use Amazon Q Apps in the web experience.
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
        /// The Amazon QuickSight configuration for an Amazon Q Business application that uses
        /// QuickSight for authentication. This configuration is required if your application
        /// uses QuickSight as the identity provider. For more information, see <a href="https://docs.aws.amazon.com/amazonq/latest/qbusiness-ug/create-quicksight-integrated-application.html">Creating
        /// an Amazon QuickSight integrated application</a>.
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
        ///  The Amazon Resource Name (ARN) of an IAM role with permissions to access your Amazon
        /// CloudWatch logs and metrics. If this property is not specified, Amazon Q Business
        /// will create a <a href="https://docs.aws.amazon.com/amazonq/latest/qbusiness-ug/using-service-linked-roles.html#slr-permissions">service
        /// linked role (SLR)</a> and use it as the application's role.
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
        /// Gets and sets the property Tags. 
        /// <para>
        /// A list of key-value pairs that identify or categorize your Amazon Q Business application.
        /// You can also use tags to help control access to the application. Tag keys and values
        /// can consist of Unicode letters, digits, white space, and any of the following symbols:
        /// _ . : / = + - @.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=0, Max=200)]
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

    }
}