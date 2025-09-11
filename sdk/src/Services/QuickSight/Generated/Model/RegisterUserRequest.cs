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
 * Do not modify this file. This file is generated from the quicksight-2018-04-01.normal.json service model.
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
namespace Amazon.QuickSight.Model
{
    /// <summary>
    /// Container for the parameters to the RegisterUser operation.
    /// Creates an Amazon QuickSight user whose identity is associated with the Identity and
    /// Access Management (IAM) identity or role specified in the request. When you register
    /// a new user from the QuickSight API, QuickSight generates a registration URL. The user
    /// accesses this registration URL to create their account. QuickSight doesn't send a
    /// registration email to users who are registered from the QuickSight API. If you want
    /// new users to receive a registration email, then add those users in the QuickSight
    /// console. For more information on registering a new user in the QuickSight console,
    /// see <a href="https://docs.aws.amazon.com/quicksight/latest/user/managing-users.html#inviting-users">
    /// Inviting users to access QuickSight</a>.
    /// </summary>
    public partial class RegisterUserRequest : AmazonQuickSightRequest
    {
        private string _awsAccountId;
        private string _customFederationProviderUrl;
        private string _customPermissionsName;
        private string _email;
        private string _externalLoginFederationProviderType;
        private string _externalLoginId;
        private string _iamArn;
        private IdentityType _identityType;
        private string _awsNamespace;
        private string _sessionName;
        private List<Tag> _tags = AWSConfigs.InitializeCollections ? new List<Tag>() : null;
        private string _userName;
        private UserRole _userRole;

        /// <summary>
        /// Gets and sets the property AwsAccountId. 
        /// <para>
        /// The ID for the Amazon Web Services account that the user is in. Currently, you use
        /// the ID for the Amazon Web Services account that contains your Amazon QuickSight account.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=12, Max=12)]
        public string AwsAccountId
        {
            get { return this._awsAccountId; }
            set { this._awsAccountId = value; }
        }

        // Check to see if AwsAccountId property is set
        internal bool IsSetAwsAccountId()
        {
            return this._awsAccountId != null;
        }

        /// <summary>
        /// Gets and sets the property CustomFederationProviderUrl. 
        /// <para>
        /// The URL of the custom OpenID Connect (OIDC) provider that provides identity to let
        /// a user federate into QuickSight with an associated Identity and Access Management(IAM)
        /// role. This parameter should only be used when <c>ExternalLoginFederationProviderType</c>
        /// parameter is set to <c>CUSTOM_OIDC</c>.
        /// </para>
        /// </summary>
        public string CustomFederationProviderUrl
        {
            get { return this._customFederationProviderUrl; }
            set { this._customFederationProviderUrl = value; }
        }

        // Check to see if CustomFederationProviderUrl property is set
        internal bool IsSetCustomFederationProviderUrl()
        {
            return this._customFederationProviderUrl != null;
        }

        /// <summary>
        /// Gets and sets the property CustomPermissionsName. 
        /// <para>
        /// (Enterprise edition only) The name of the custom permissions profile that you want
        /// to assign to this user. Customized permissions allows you to control a user's access
        /// by restricting access the following operations:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Create and update data sources
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Create and update datasets
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Create and update email reports
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Subscribe to email reports
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// To add custom permissions to an existing user, use <c> <a href="https://docs.aws.amazon.com/quicksight/latest/APIReference/API_UpdateUser.html">UpdateUser</a>
        /// </c> instead.
        /// </para>
        ///  
        /// <para>
        /// A set of custom permissions includes any combination of these restrictions. Currently,
        /// you need to create the profile names for custom permission sets by using the QuickSight
        /// console. Then, you use the <c>RegisterUser</c> API operation to assign the named set
        /// of permissions to a QuickSight user. 
        /// </para>
        ///  
        /// <para>
        /// QuickSight custom permissions are applied through IAM policies. Therefore, they override
        /// the permissions typically granted by assigning QuickSight users to one of the default
        /// security cohorts in QuickSight (admin, author, reader, admin pro, author pro, reader
        /// pro).
        /// </para>
        ///  
        /// <para>
        /// This feature is available only to QuickSight Enterprise edition subscriptions.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=64)]
        public string CustomPermissionsName
        {
            get { return this._customPermissionsName; }
            set { this._customPermissionsName = value; }
        }

        // Check to see if CustomPermissionsName property is set
        internal bool IsSetCustomPermissionsName()
        {
            return this._customPermissionsName != null;
        }

        /// <summary>
        /// Gets and sets the property Email. 
        /// <para>
        /// The email address of the user that you want to register.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string Email
        {
            get { return this._email; }
            set { this._email = value; }
        }

        // Check to see if Email property is set
        internal bool IsSetEmail()
        {
            return this._email != null;
        }

        /// <summary>
        /// Gets and sets the property ExternalLoginFederationProviderType. 
        /// <para>
        /// The type of supported external login provider that provides identity to let a user
        /// federate into Amazon QuickSight with an associated Identity and Access Management(IAM)
        /// role. The type of supported external login provider can be one of the following.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>COGNITO</c>: Amazon Cognito. The provider URL is cognito-identity.amazonaws.com.
        /// When choosing the <c>COGNITO</c> provider type, don’t use the "CustomFederationProviderUrl"
        /// parameter which is only needed when the external provider is custom.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>CUSTOM_OIDC</c>: Custom OpenID Connect (OIDC) provider. When choosing <c>CUSTOM_OIDC</c>
        /// type, use the <c>CustomFederationProviderUrl</c> parameter to provide the custom OIDC
        /// provider URL.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public string ExternalLoginFederationProviderType
        {
            get { return this._externalLoginFederationProviderType; }
            set { this._externalLoginFederationProviderType = value; }
        }

        // Check to see if ExternalLoginFederationProviderType property is set
        internal bool IsSetExternalLoginFederationProviderType()
        {
            return this._externalLoginFederationProviderType != null;
        }

        /// <summary>
        /// Gets and sets the property ExternalLoginId. 
        /// <para>
        /// The identity ID for a user in the external login provider.
        /// </para>
        /// </summary>
        public string ExternalLoginId
        {
            get { return this._externalLoginId; }
            set { this._externalLoginId = value; }
        }

        // Check to see if ExternalLoginId property is set
        internal bool IsSetExternalLoginId()
        {
            return this._externalLoginId != null;
        }

        /// <summary>
        /// Gets and sets the property IamArn. 
        /// <para>
        /// The ARN of the IAM user or role that you are registering with Amazon QuickSight. 
        /// </para>
        /// </summary>
        public string IamArn
        {
            get { return this._iamArn; }
            set { this._iamArn = value; }
        }

        // Check to see if IamArn property is set
        internal bool IsSetIamArn()
        {
            return this._iamArn != null;
        }

        /// <summary>
        /// Gets and sets the property IdentityType. 
        /// <para>
        /// The identity type that your QuickSight account uses to manage the identity of users.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
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
        /// Gets and sets the property Namespace. 
        /// <para>
        /// The namespace. Currently, you should set this to <c>default</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Max=64)]
        public string Namespace
        {
            get { return this._awsNamespace; }
            set { this._awsNamespace = value; }
        }

        // Check to see if Namespace property is set
        internal bool IsSetNamespace()
        {
            return this._awsNamespace != null;
        }

        /// <summary>
        /// Gets and sets the property SessionName. 
        /// <para>
        /// You need to use this parameter only when you register one or more users using an assumed
        /// IAM role. You don't need to provide the session name for other scenarios, for example
        /// when you are registering an IAM user or an Amazon QuickSight user. You can register
        /// multiple users using the same IAM role if each user has a different session name.
        /// For more information on assuming IAM roles, see <a href="https://docs.aws.amazon.com/cli/latest/reference/sts/assume-role.html">
        /// <c>assume-role</c> </a> in the <i>CLI Reference.</i> 
        /// </para>
        /// </summary>
        [AWSProperty(Min=2, Max=64)]
        public string SessionName
        {
            get { return this._sessionName; }
            set { this._sessionName = value; }
        }

        // Check to see if SessionName property is set
        internal bool IsSetSessionName()
        {
            return this._sessionName != null;
        }

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// The tags to associate with the user.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=1, Max=200)]
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

        /// <summary>
        /// Gets and sets the property UserName. 
        /// <para>
        /// The Amazon QuickSight user name that you want to create for the user you are registering.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1)]
        public string UserName
        {
            get { return this._userName; }
            set { this._userName = value; }
        }

        // Check to see if UserName property is set
        internal bool IsSetUserName()
        {
            return this._userName != null;
        }

        /// <summary>
        /// Gets and sets the property UserRole. 
        /// <para>
        /// The Amazon QuickSight role for the user. The user role can be one of the following:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>READER</c>: A user who has read-only access to dashboards.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>AUTHOR</c>: A user who can create data sources, datasets, analyses, and dashboards.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>ADMIN</c>: A user who is an author, who can also manage Amazon QuickSight settings.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>READER_PRO</c>: Reader Pro adds Generative BI capabilities to the Reader role.
        /// Reader Pros have access to Amazon Q in QuickSight, can build stories with Amazon Q,
        /// and can generate executive summaries from dashboards.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>AUTHOR_PRO</c>: Author Pro adds Generative BI capabilities to the Author role.
        /// Author Pros can author dashboards with natural language with Amazon Q, build stories
        /// with Amazon Q, create Topics for Q&amp;A, and generate executive summaries from dashboards.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>ADMIN_PRO</c>: Admin Pros are Author Pros who can also manage Amazon QuickSight
        /// administrative settings. Admin Pro users are billed at Author Pro pricing.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>RESTRICTED_READER</c>: This role isn't currently available for use.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>RESTRICTED_AUTHOR</c>: This role isn't currently available for use.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        [AWSProperty(Required=true)]
        public UserRole UserRole
        {
            get { return this._userRole; }
            set { this._userRole = value; }
        }

        // Check to see if UserRole property is set
        internal bool IsSetUserRole()
        {
            return this._userRole != null;
        }

    }
}