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

namespace Amazon.QuickSight.Model
{
    /// <summary>
    /// Container for the parameters to the RegisterUser operation.
    /// Creates an Amazon QuickSight user whose identity is associated with the Identity and
    /// Access Management (IAM) identity or role specified in the request. When you register
    /// a new user from the Amazon QuickSight API, Amazon QuickSight generates a registration
    /// URL. The user accesses this registration URL to create their account. Amazon QuickSight
    /// doesn't send a registration email to users who are registered from the Amazon QuickSight
    /// API. If you want new users to receive a registration email, then add those users in
    /// the Amazon QuickSight console. For more information on registering a new user in the
    /// Amazon QuickSight console, see <a href="https://docs.aws.amazon.com/quicksight/latest/user/managing-users.html#inviting-users">
    /// Inviting users to access Amazon QuickSight</a>.
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
        /// a user federate into Amazon QuickSight with an associated Identity and Access Management(IAM)
        /// role. This parameter should only be used when <code>ExternalLoginFederationProviderType</code>
        /// parameter is set to <code>CUSTOM_OIDC</code>.
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
        /// To add custom permissions to an existing user, use <code> <a href="https://docs.aws.amazon.com/quicksight/latest/APIReference/API_UpdateUser.html">UpdateUser</a>
        /// </code> instead.
        /// </para>
        ///  
        /// <para>
        /// A set of custom permissions includes any combination of these restrictions. Currently,
        /// you need to create the profile names for custom permission sets by using the Amazon
        /// QuickSight console. Then, you use the <code>RegisterUser</code> API operation to assign
        /// the named set of permissions to a Amazon QuickSight user. 
        /// </para>
        ///  
        /// <para>
        /// Amazon QuickSight custom permissions are applied through IAM policies. Therefore,
        /// they override the permissions typically granted by assigning Amazon QuickSight users
        /// to one of the default security cohorts in Amazon QuickSight (admin, author, reader).
        /// </para>
        ///  
        /// <para>
        /// This feature is available only to Amazon QuickSight Enterprise edition subscriptions.
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
        ///  <code>COGNITO</code>: Amazon Cognito. The provider URL is cognito-identity.amazonaws.com.
        /// When choosing the <code>COGNITO</code> provider type, don’t use the "CustomFederationProviderUrl"
        /// parameter which is only needed when the external provider is custom.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>CUSTOM_OIDC</code>: Custom OpenID Connect (OIDC) provider. When choosing <code>CUSTOM_OIDC</code>
        /// type, use the <code>CustomFederationProviderUrl</code> parameter to provide the custom
        /// OIDC provider URL.
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
        /// Amazon QuickSight supports several ways of managing the identity of users. This parameter
        /// accepts two values:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <code>IAM</code>: A user whose identity maps to an existing IAM user or role. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>QUICKSIGHT</code>: A user whose identity is owned and managed internally by
        /// Amazon QuickSight. 
        /// </para>
        ///  </li> </ul>
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
        /// The namespace. Currently, you should set this to <code>default</code>.
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
        /// <code>assume-role</code> </a> in the <i>CLI Reference.</i> 
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
        ///  <code>READER</code>: A user who has read-only access to dashboards.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>AUTHOR</code>: A user who can create data sources, datasets, analyses, and
        /// dashboards.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>ADMIN</code>: A user who is an author, who can also manage Amazon QuickSight
        /// settings.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>RESTRICTED_READER</code>: This role isn't currently available for use.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>RESTRICTED_AUTHOR</code>: This role isn't currently available for use.
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