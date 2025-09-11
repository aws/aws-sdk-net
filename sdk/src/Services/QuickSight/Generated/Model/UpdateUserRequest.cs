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
    /// Container for the parameters to the UpdateUser operation.
    /// Updates an Amazon QuickSight user.
    /// </summary>
    public partial class UpdateUserRequest : AmazonQuickSightRequest
    {
        private string _awsAccountId;
        private string _customFederationProviderUrl;
        private string _customPermissionsName;
        private string _email;
        private string _externalLoginFederationProviderType;
        private string _externalLoginId;
        private string _awsNamespace;
        private UserRole _role;
        private bool? _unapplyCustomPermissions;
        private string _userName;

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
        /// A set of custom permissions includes any combination of these restrictions. Currently,
        /// you need to create the profile names for custom permission sets by using the QuickSight
        /// console. Then, you use the <c>RegisterUser</c> API operation to assign the named set
        /// of permissions to a QuickSight user. 
        /// </para>
        ///  
        /// <para>
        /// QuickSight custom permissions are applied through IAM policies. Therefore, they override
        /// the permissions typically granted by assigning QuickSight users to one of the default
        /// security cohorts in QuickSight (admin, author, reader).
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
        /// The email address of the user that you want to update.
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
        /// federate into QuickSight with an associated Identity and Access Management(IAM) role.
        /// The type of supported external login provider can be one of the following.
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
        ///  </li> <li> 
        /// <para>
        ///  <c>NONE</c>: This clears all the previously saved external login information for
        /// a user. Use the <c> <a href="https://docs.aws.amazon.com/quicksight/latest/APIReference/API_DescribeUser.html">DescribeUser</a>
        /// </c> API operation to check the external login information.
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
        /// Gets and sets the property Role. 
        /// <para>
        /// The Amazon QuickSight role of the user. The role can be one of the following default
        /// security cohorts:
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
        ///  </li> </ul> 
        /// <para>
        /// The name of the QuickSight role is invisible to the user except for the console screens
        /// dealing with permissions.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public UserRole Role
        {
            get { return this._role; }
            set { this._role = value; }
        }

        // Check to see if Role property is set
        internal bool IsSetRole()
        {
            return this._role != null;
        }

        /// <summary>
        /// Gets and sets the property UnapplyCustomPermissions. 
        /// <para>
        /// A flag that you use to indicate that you want to remove all custom permissions from
        /// this user. Using this parameter resets the user to the state it was in before a custom
        /// permissions profile was applied. This parameter defaults to NULL and it doesn't accept
        /// any other value.
        /// </para>
        /// </summary>
        public bool? UnapplyCustomPermissions
        {
            get { return this._unapplyCustomPermissions; }
            set { this._unapplyCustomPermissions = value; }
        }

        // Check to see if UnapplyCustomPermissions property is set
        internal bool IsSetUnapplyCustomPermissions()
        {
            return this._unapplyCustomPermissions.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property UserName. 
        /// <para>
        /// The Amazon QuickSight user name that you want to update.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1)]
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

    }
}