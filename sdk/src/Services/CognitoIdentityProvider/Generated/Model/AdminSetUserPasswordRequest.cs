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
 * Do not modify this file. This file is generated from the cognito-idp-2016-04-18.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.CognitoIdentityProvider.Model
{
    /// <summary>
    /// Container for the parameters to the AdminSetUserPassword operation.
    /// Sets the specified user's password in a user pool as an administrator. Works on any
    /// user. 
    /// 
    ///  
    /// <para>
    /// The password can be temporary or permanent. If it is temporary, the user status enters
    /// the <code>FORCE_CHANGE_PASSWORD</code> state. When the user next tries to sign in,
    /// the InitiateAuth/AdminInitiateAuth response will contain the <code>NEW_PASSWORD_REQUIRED</code>
    /// challenge. If the user doesn't sign in before it expires, the user won't be able to
    /// sign in, and an administrator must reset their password. 
    /// </para>
    ///  
    /// <para>
    /// Once the user has set a new password, or the password is permanent, the user status
    /// is set to <code>Confirmed</code>.
    /// </para>
    ///  
    /// <para>
    ///  <code>AdminSetUserPassword</code> can set a password for the user profile that Amazon
    /// Cognito creates for third-party federated users. When you set a password, the federated
    /// user's status changes from <code>EXTERNAL_PROVIDER</code> to <code>CONFIRMED</code>.
    /// A user in this state can sign in as a federated user, and initiate authentication
    /// flows in the API like a linked native user. They can also modify their password and
    /// attributes in token-authenticated API requests like <code>ChangePassword</code> and
    /// <code>UpdateUserAttributes</code>. As a best security practice and to keep users in
    /// sync with your external IdP, don't set passwords on federated user profiles. To set
    /// up a federated user for native sign-in with a linked native user, refer to <a href="https://docs.aws.amazon.com/cognito/latest/developerguide/cognito-user-pools-identity-federation-consolidate-users.html">Linking
    /// federated users to an existing user profile</a>.
    /// </para>
    ///  <note> 
    /// <para>
    /// Amazon Cognito evaluates Identity and Access Management (IAM) policies in requests
    /// for this API operation. For this operation, you must use IAM credentials to authorize
    /// requests, and you must grant yourself the corresponding IAM permission in a policy.
    /// </para>
    ///  
    /// <para>
    ///  <b>Learn more</b> 
    /// </para>
    ///  <ul> <li> 
    /// <para>
    ///  <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/reference_aws-signing.html">Signing
    /// Amazon Web Services API Requests</a> 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a href="https://docs.aws.amazon.com/cognito/latest/developerguide/user-pools-API-operations.html">Using
    /// the Amazon Cognito user pools API and user pool endpoints</a> 
    /// </para>
    ///  </li> </ul> </note>
    /// </summary>
    public partial class AdminSetUserPasswordRequest : AmazonCognitoIdentityProviderRequest
    {
        private string _password;
        private bool? _permanent;
        private string _username;
        private string _userPoolId;

        /// <summary>
        /// Gets and sets the property Password. 
        /// <para>
        /// The password for the user.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Sensitive=true, Max=256)]
        public string Password
        {
            get { return this._password; }
            set { this._password = value; }
        }

        // Check to see if Password property is set
        internal bool IsSetPassword()
        {
            return this._password != null;
        }

        /// <summary>
        /// Gets and sets the property Permanent. 
        /// <para>
        ///  <code>True</code> if the password is permanent, <code>False</code> if it is temporary.
        /// </para>
        /// </summary>
        public bool Permanent
        {
            get { return this._permanent.GetValueOrDefault(); }
            set { this._permanent = value; }
        }

        // Check to see if Permanent property is set
        internal bool IsSetPermanent()
        {
            return this._permanent.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Username. 
        /// <para>
        /// The user name of the user whose password you want to set.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Sensitive=true, Min=1, Max=128)]
        public string Username
        {
            get { return this._username; }
            set { this._username = value; }
        }

        // Check to see if Username property is set
        internal bool IsSetUsername()
        {
            return this._username != null;
        }

        /// <summary>
        /// Gets and sets the property UserPoolId. 
        /// <para>
        /// The user pool ID for the user pool where you want to set the user's password.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=55)]
        public string UserPoolId
        {
            get { return this._userPoolId; }
            set { this._userPoolId = value; }
        }

        // Check to see if UserPoolId property is set
        internal bool IsSetUserPoolId()
        {
            return this._userPoolId != null;
        }

    }
}