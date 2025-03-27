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

#pragma warning disable CS0612,CS0618,CS1570
namespace Amazon.CognitoIdentityProvider.Model
{
    /// <summary>
    /// Container for the parameters to the AdminSetUserPassword operation.
    /// Sets the specified user's password in a user pool. This operation administratively
    /// sets a temporary or permanent password for a user. With this operation, you can bypass
    /// self-service password changes and permit immediate sign-in with the password that
    /// you set. To do this, set <c>Permanent</c> to <c>true</c>.
    /// 
    ///  
    /// <para>
    /// You can also set a new temporary password in this request, send it to a user, and
    /// require them to choose a new password on their next sign-in. To do this, set <c>Permanent</c>
    /// to <c>false</c>.
    /// </para>
    ///  
    /// <para>
    /// If the password is temporary, the user's <c>Status</c> becomes <c>FORCE_CHANGE_PASSWORD</c>.
    /// When the user next tries to sign in, the <c>InitiateAuth</c> or <c>AdminInitiateAuth</c>
    /// response includes the <c>NEW_PASSWORD_REQUIRED</c> challenge. If the user doesn't
    /// sign in before the temporary password expires, they can no longer sign in and you
    /// must repeat this operation to set a temporary or permanent password for them.
    /// </para>
    ///  
    /// <para>
    /// After the user sets a new password, or if you set a permanent password, their status
    /// becomes <c>Confirmed</c>.
    /// </para>
    ///  
    /// <para>
    ///  <c>AdminSetUserPassword</c> can set a password for the user profile that Amazon Cognito
    /// creates for third-party federated users. When you set a password, the federated user's
    /// status changes from <c>EXTERNAL_PROVIDER</c> to <c>CONFIRMED</c>. A user in this state
    /// can sign in as a federated user, and initiate authentication flows in the API like
    /// a linked native user. They can also modify their password and attributes in token-authenticated
    /// API requests like <c>ChangePassword</c> and <c>UpdateUserAttributes</c>. As a best
    /// security practice and to keep users in sync with your external IdP, don't set passwords
    /// on federated user profiles. To set up a federated user for native sign-in with a linked
    /// native user, refer to <a href="https://docs.aws.amazon.com/cognito/latest/developerguide/cognito-user-pools-identity-federation-consolidate-users.html">Linking
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
        /// The new temporary or permanent password that you want to set for the user. You can't
        /// remove the password for a user who already has a password so that they can only sign
        /// in with passwordless methods. In this scenario, you must create a new user without
        /// a password.
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
        /// Set to <c>true</c> to set a password that the user can immediately sign in with. Set
        /// to <c>false</c> to set a temporary password that the user must change on their next
        /// sign-in.
        /// </para>
        /// </summary>
        public bool? Permanent
        {
            get { return this._permanent; }
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
        /// The name of the user that you want to query or modify. The value of this parameter
        /// is typically your user's username, but it can be any of their alias attributes. If
        /// <c>username</c> isn't an alias attribute in your user pool, this value must be the
        /// <c>sub</c> of a local user or the username of a user from a third-party IdP.
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
        /// The ID of the user pool where you want to set the user's password.
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