/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.CognitoIdentityProvider.Model
{
    /// <summary>
    /// Container for the parameters to the AdminDisableProviderForUser operation.
    /// Disables the user from signing in with the specified external (SAML or social) identity
    /// provider. If the user to disable is a Cognito User Pools native username + password
    /// user, they are not permitted to use their password to sign-in. If the user to disable
    /// is a linked external IdP user, any link between that user and an existing user is
    /// removed. The next time the external user (no longer attached to the previously linked
    /// <code>DestinationUser</code>) signs in, they must create a new user account. See .
    /// 
    ///  
    /// <para>
    /// This action is enabled only for admin access and requires developer credentials.
    /// </para>
    ///  
    /// <para>
    /// The <code>ProviderName</code> must match the value specified when creating an IdP
    /// for the pool. 
    /// </para>
    ///  
    /// <para>
    /// To disable a native username + password user, the <code>ProviderName</code> value
    /// must be <code>Cognito</code> and the <code>ProviderAttributeName</code> must be <code>Cognito_Subject</code>,
    /// with the <code>ProviderAttributeValue</code> being the name that is used in the user
    /// pool for the user.
    /// </para>
    ///  
    /// <para>
    /// The <code>ProviderAttributeName</code> must always be <code>Cognito_Subject</code>
    /// for social identity providers. The <code>ProviderAttributeValue</code> must always
    /// be the exact subject that was used when the user was originally linked as a source
    /// user.
    /// </para>
    ///  
    /// <para>
    /// For de-linking a SAML identity, there are two scenarios. If the linked identity has
    /// not yet been used to sign-in, the <code>ProviderAttributeName</code> and <code>ProviderAttributeValue</code>
    /// must be the same values that were used for the <code>SourceUser</code> when the identities
    /// were originally linked in the call. (If the linking was done with <code>ProviderAttributeName</code>
    /// set to <code>Cognito_Subject</code>, the same applies here). However, if the user
    /// has already signed in, the <code>ProviderAttributeName</code> must be <code>Cognito_Subject</code>
    /// and <code>ProviderAttributeValue</code> must be the subject of the SAML assertion.
    /// </para>
    /// </summary>
    public partial class AdminDisableProviderForUserRequest : AmazonCognitoIdentityProviderRequest
    {
        private ProviderUserIdentifierType _user;
        private string _userPoolId;

        /// <summary>
        /// Gets and sets the property User. 
        /// <para>
        /// The user to be disabled.
        /// </para>
        /// </summary>
        public ProviderUserIdentifierType User
        {
            get { return this._user; }
            set { this._user = value; }
        }

        // Check to see if User property is set
        internal bool IsSetUser()
        {
            return this._user != null;
        }

        /// <summary>
        /// Gets and sets the property UserPoolId. 
        /// <para>
        /// The user pool ID for the user pool.
        /// </para>
        /// </summary>
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