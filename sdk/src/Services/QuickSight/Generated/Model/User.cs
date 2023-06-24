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
    /// A registered user of Amazon QuickSight.
    /// </summary>
    public partial class User
    {
        private bool? _active;
        private string _arn;
        private string _customPermissionsName;
        private string _email;
        private string _externalLoginFederationProviderType;
        private string _externalLoginFederationProviderUrl;
        private string _externalLoginId;
        private IdentityType _identityType;
        private string _principalId;
        private UserRole _role;
        private string _userName;

        /// <summary>
        /// Gets and sets the property Active. 
        /// <para>
        /// The active status of user. When you create an Amazon QuickSight user that's not an
        /// IAM user or an Active Directory user, that user is inactive until they sign in and
        /// provide a password.
        /// </para>
        /// </summary>
        public bool Active
        {
            get { return this._active.GetValueOrDefault(); }
            set { this._active = value; }
        }

        // Check to see if Active property is set
        internal bool IsSetActive()
        {
            return this._active.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Arn. 
        /// <para>
        /// The Amazon Resource Name (ARN) for the user.
        /// </para>
        /// </summary>
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
        /// Gets and sets the property CustomPermissionsName. 
        /// <para>
        /// The custom permissions profile associated with this user.
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
        /// The user's email address.
        /// </para>
        /// </summary>
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
        /// The type of supported external login provider that provides identity to let the user
        /// federate into Amazon QuickSight with an associated IAM role. The type can be one of
        /// the following.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <code>COGNITO</code>: Amazon Cognito. The provider URL is cognito-identity.amazonaws.com.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>CUSTOM_OIDC</code>: Custom OpenID Connect (OIDC) provider.
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
        /// Gets and sets the property ExternalLoginFederationProviderUrl. 
        /// <para>
        /// The URL of the external login provider.
        /// </para>
        /// </summary>
        public string ExternalLoginFederationProviderUrl
        {
            get { return this._externalLoginFederationProviderUrl; }
            set { this._externalLoginFederationProviderUrl = value; }
        }

        // Check to see if ExternalLoginFederationProviderUrl property is set
        internal bool IsSetExternalLoginFederationProviderUrl()
        {
            return this._externalLoginFederationProviderUrl != null;
        }

        /// <summary>
        /// Gets and sets the property ExternalLoginId. 
        /// <para>
        /// The identity ID for the user in the external login provider.
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
        /// Gets and sets the property IdentityType. 
        /// <para>
        /// The type of identity authentication used by the user.
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
        /// Gets and sets the property PrincipalId. 
        /// <para>
        /// The principal ID of the user.
        /// </para>
        /// </summary>
        public string PrincipalId
        {
            get { return this._principalId; }
            set { this._principalId = value; }
        }

        // Check to see if PrincipalId property is set
        internal bool IsSetPrincipalId()
        {
            return this._principalId != null;
        }

        /// <summary>
        /// Gets and sets the property Role. 
        /// <para>
        /// The Amazon QuickSight role for the user. The user role can be one of the following:.
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
        ///  <code>ADMIN</code>: A user who is an author, who can also manage Amazon Amazon QuickSight
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
        /// Gets and sets the property UserName. 
        /// <para>
        /// The user's user name. This value is required if you are registering a user that will
        /// be managed in Amazon QuickSight. In the output, the value for <code>UserName</code>
        /// is <code>N/A</code> when the value for <code>IdentityType</code> is <code>IAM</code>
        /// and the corresponding IAM user is deleted.
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

    }
}