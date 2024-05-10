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
    /// Container for the parameters to the AdminLinkProviderForUser operation.
    /// Links an existing user account in a user pool (<c>DestinationUser</c>) to an identity
    /// from an external IdP (<c>SourceUser</c>) based on a specified attribute name and value
    /// from the external IdP. This allows you to create a link from the existing user account
    /// to an external federated user identity that has not yet been used to sign in. You
    /// can then use the federated user identity to sign in as the existing user account.
    /// 
    /// 
    ///  
    /// <para>
    ///  For example, if there is an existing user with a username and password, this API
    /// links that user to a federated user identity. When the user signs in with a federated
    /// user identity, they sign in as the existing user account.
    /// </para>
    ///  <note> 
    /// <para>
    /// The maximum number of federated identities linked to a user is five.
    /// </para>
    ///  </note> <important> 
    /// <para>
    /// Because this API allows a user with an external federated identity to sign in as an
    /// existing user in the user pool, it is critical that it only be used with external
    /// IdPs and provider attributes that have been trusted by the application owner.
    /// </para>
    ///  </important> <note> 
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
    public partial class AdminLinkProviderForUserRequest : AmazonCognitoIdentityProviderRequest
    {
        private ProviderUserIdentifierType _destinationUser;
        private ProviderUserIdentifierType _sourceUser;
        private string _userPoolId;

        /// <summary>
        /// Gets and sets the property DestinationUser. 
        /// <para>
        /// The existing user in the user pool that you want to assign to the external IdP user
        /// account. This user can be a local (Username + Password) Amazon Cognito user pools
        /// user or a federated user (for example, a SAML or Facebook user). If the user doesn't
        /// exist, Amazon Cognito generates an exception. Amazon Cognito returns this user when
        /// the new user (with the linked IdP attribute) signs in.
        /// </para>
        ///  
        /// <para>
        /// For a native username + password user, the <c>ProviderAttributeValue</c> for the <c>DestinationUser</c>
        /// should be the username in the user pool. For a federated user, it should be the provider-specific
        /// <c>user_id</c>.
        /// </para>
        ///  
        /// <para>
        /// The <c>ProviderAttributeName</c> of the <c>DestinationUser</c> is ignored.
        /// </para>
        ///  
        /// <para>
        /// The <c>ProviderName</c> should be set to <c>Cognito</c> for users in Cognito user
        /// pools.
        /// </para>
        ///  <important> 
        /// <para>
        /// All attributes in the DestinationUser profile must be mutable. If you have assigned
        /// the user any immutable custom attributes, the operation won't succeed.
        /// </para>
        ///  </important>
        /// </summary>
        [AWSProperty(Required=true)]
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
        /// An external IdP account for a user who doesn't exist yet in the user pool. This user
        /// must be a federated user (for example, a SAML or Facebook user), not another native
        /// user.
        /// </para>
        ///  
        /// <para>
        /// If the <c>SourceUser</c> is using a federated social IdP, such as Facebook, Google,
        /// or Login with Amazon, you must set the <c>ProviderAttributeName</c> to <c>Cognito_Subject</c>.
        /// For social IdPs, the <c>ProviderName</c> will be <c>Facebook</c>, <c>Google</c>, or
        /// <c>LoginWithAmazon</c>, and Amazon Cognito will automatically parse the Facebook,
        /// Google, and Login with Amazon tokens for <c>id</c>, <c>sub</c>, and <c>user_id</c>,
        /// respectively. The <c>ProviderAttributeValue</c> for the user must be the same value
        /// as the <c>id</c>, <c>sub</c>, or <c>user_id</c> value found in the social IdP token.
        /// </para>
        ///   
        /// <para>
        /// For OIDC, the <c>ProviderAttributeName</c> can be any value that matches a claim in
        /// the ID token, or that your app retrieves from the <c>userInfo</c> endpoint. You must
        /// map the claim to a user pool attribute in your IdP configuration, and set the user
        /// pool attribute name as the value of <c>ProviderAttributeName</c> in your <c>AdminLinkProviderForUser</c>
        /// request.
        /// </para>
        ///  
        /// <para>
        /// For SAML, the <c>ProviderAttributeName</c> can be any value that matches a claim in
        /// the SAML assertion. To link SAML users based on the subject of the SAML assertion,
        /// map the subject to a claim through the SAML IdP and set that claim name as the value
        /// of <c>ProviderAttributeName</c> in your <c>AdminLinkProviderForUser</c> request.
        /// </para>
        ///  
        /// <para>
        /// For both OIDC and SAML users, when you set <c>ProviderAttributeName</c> to <c>Cognito_Subject</c>,
        /// Amazon Cognito will automatically parse the default unique identifier found in the
        /// subject from the IdP token.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
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