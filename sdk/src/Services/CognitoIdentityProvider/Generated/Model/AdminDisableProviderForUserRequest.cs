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
    /// Container for the parameters to the AdminDisableProviderForUser operation.
    /// Prevents the user from signing in with the specified external (SAML or social) identity
    /// provider (IdP). If the user that you want to deactivate is a Amazon Cognito user pools
    /// native username + password user, they can't use their password to sign in. If the
    /// user to deactivate is a linked external IdP user, any link between that user and an
    /// existing user is removed. When the external user signs in again, and the user is no
    /// longer attached to the previously linked <c>DestinationUser</c>, the user must create
    /// a new user account.
    /// 
    ///  
    /// <para>
    /// The value of <c>ProviderName</c> must match the name of a user pool IdP.
    /// </para>
    ///  
    /// <para>
    /// To deactivate a local user, set <c>ProviderName</c> to <c>Cognito</c> and the <c>ProviderAttributeName</c>
    /// to <c>Cognito_Subject</c>. The <c>ProviderAttributeValue</c> must be user's local
    /// username.
    /// </para>
    ///  
    /// <para>
    /// The <c>ProviderAttributeName</c> must always be <c>Cognito_Subject</c> for social
    /// IdPs. The <c>ProviderAttributeValue</c> must always be the exact subject that was
    /// used when the user was originally linked as a source user.
    /// </para>
    ///  
    /// <para>
    /// For de-linking a SAML identity, there are two scenarios. If the linked identity has
    /// not yet been used to sign in, the <c>ProviderAttributeName</c> and <c>ProviderAttributeValue</c>
    /// must be the same values that were used for the <c>SourceUser</c> when the identities
    /// were originally linked using <c> AdminLinkProviderForUser</c> call. This is also true
    /// if the linking was done with <c>ProviderAttributeName</c> set to <c>Cognito_Subject</c>.
    /// If the user has already signed in, the <c>ProviderAttributeName</c> must be <c>Cognito_Subject</c>
    /// and <c>ProviderAttributeValue</c> must be the <c>NameID</c> from their SAML assertion.
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
    public partial class AdminDisableProviderForUserRequest : AmazonCognitoIdentityProviderRequest
    {
        private ProviderUserIdentifierType _user;
        private string _userPoolId;

        /// <summary>
        /// Gets and sets the property User. 
        /// <para>
        /// The user profile that you want to delete a linked identity from.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
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
        /// The ID of the user pool where you want to delete the user's linked identities.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=0, Max=131072)]
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