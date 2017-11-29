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
    /// Container for the parameters to the AdminLinkProviderForUser operation.
    /// Links an existing user account in a user pool (<code>DestinationUser</code>) to an
    /// identity from an external identity provider (<code>SourceUser</code>) based on a specified
    /// attribute name and value from the external identity provider. This allows you to create
    /// a link from the existing user account to an external federated user identity that
    /// has not yet been used to sign in, so that the federated user identity can be used
    /// to sign in as the existing user account. 
    /// 
    ///  
    /// <para>
    ///  For example, if there is an existing user with a username and password, this API
    /// links that user to a federated user identity, so that when the federated user identity
    /// is used, the user signs in as the existing user account. 
    /// </para>
    ///  <important> 
    /// <para>
    /// Because this API allows a user with an external federated identity to sign in as an
    /// existing user in the user pool, it is critical that it only be used with external
    /// identity providers and provider attributes that have been trusted by the application
    /// owner.
    /// </para>
    ///  </important> 
    /// <para>
    /// See also .
    /// </para>
    ///  
    /// <para>
    /// This action is enabled only for admin access and requires developer credentials.
    /// </para>
    /// </summary>
    public partial class AdminLinkProviderForUserRequest : AmazonCognitoIdentityProviderRequest
    {
        private ProviderUserIdentifierType _destinationUser;
        private ProviderUserIdentifierType _sourceUser;
        private string _userPoolId;

        /// <summary>
        /// Gets and sets the property DestinationUser. 
        /// <para>
        /// The existing user in the user pool to be linked to the external identity provider
        /// user account. Can be a native (Username + Password) Cognito User Pools user or a federated
        /// user (for example, a SAML or Facebook user). If the user doesn't exist, an exception
        /// is thrown. This is the user that is returned when the new user (with the linked identity
        /// provider attribute) signs in.
        /// </para>
        ///  
        /// <para>
        /// For a native username + password user, the <code>ProviderAttributeValue</code> for
        /// the <code>DestinationUser</code> should be the username in the user pool. For a federated
        /// user, it should be the provider-specific <code>user_id</code>.
        /// </para>
        ///  
        /// <para>
        /// The <code>ProviderAttributeName</code> of the <code>DestinationUser</code> is ignored.
        /// </para>
        ///  
        /// <para>
        /// The <code>ProviderName</code> should be set to <code>Cognito</code> for users in Cognito
        /// user pools.
        /// </para>
        /// </summary>
        public ProviderUserIdentifierType DestinationUser
        {
            get { return this._destinationUser; }
            set { this._destinationUser = value; }
        }

        // Check to see if DestinationUser property is set
        internal bool IsSetDestinationUser()
        {
            return this._destinationUser != null;
        }

        /// <summary>
        /// Gets and sets the property SourceUser. 
        /// <para>
        /// An external identity provider account for a user who does not currently exist yet
        /// in the user pool. This user must be a federated user (for example, a SAML or Facebook
        /// user), not another native user.
        /// </para>
        ///  
        /// <para>
        /// If the <code>SourceUser</code> is a federated social identity provider user (Facebook,
        /// Google, or Login with Amazon), you must set the <code>ProviderAttributeName</code>
        /// to <code>Cognito_Subject</code>. For social identity providers, the <code>ProviderName</code>
        /// will be <code>Facebook</code>, <code>Google</code>, or <code>LoginWithAmazon</code>,
        /// and Cognito will automatically parse the Facebook, Google, and Login with Amazon tokens
        /// for <code>id</code>, <code>sub</code>, and <code>user_id</code>, respectively. The
        /// <code>ProviderAttributeValue</code> for the user must be the same value as the <code>id</code>,
        /// <code>sub</code>, or <code>user_id</code> value found in the social identity provider
        /// token.
        /// </para>
        ///   
        /// <para>
        /// For SAML, the <code>ProviderAttributeName</code> can be any value that matches a claim
        /// in the SAML assertion. If you wish to link SAML users based on the subject of the
        /// SAML assertion, you should map the subject to a claim through the SAML identity provider
        /// and submit that claim name as the <code>ProviderAttributeName</code>. If you set <code>ProviderAttributeName</code>
        /// to <code>Cognito_Subject</code>, Cognito will automatically parse the default unique
        /// identifier found in the subject from the SAML token.
        /// </para>
        /// </summary>
        public ProviderUserIdentifierType SourceUser
        {
            get { return this._sourceUser; }
            set { this._sourceUser = value; }
        }

        // Check to see if SourceUser property is set
        internal bool IsSetSourceUser()
        {
            return this._sourceUser != null;
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