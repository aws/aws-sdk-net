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
 * Do not modify this file. This file is generated from the smithy.json service model.
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
    /// Container for the parameters to the GetDerivedToken operation. Exchanges an existing
    /// token for a new token that is scoped and audience-bound for a specific downstream
    /// service, following the OAuth 2.0 Token Exchange grant type. For more information about
    /// the OAuth 2.0 Token Exchange grant type, see <a href="https://tools.ietf.org/html/rfc8693">RFC
    /// 8693 - OAuth 2.0 Token Exchange</a> on the IETF website. Present a <c>SubjectToken</c>,
    /// the credential that you already hold, to receive a new token appropriate for calling
    /// a specific resource server or audience. <para> If you also present an <c>ActorToken</c>
    /// that identifies an intermediary service, the issued token carries an <c>act</c> claim
    /// that identifies the intermediary, and downstream services can distinguish a user acting
    /// directly from an intermediary acting on the user's behalf. If you don't present an
    /// <c>ActorToken</c>, the issued token appears as if the user acted directly. </para>
    /// <para> To use this operation, you must have IAM credentials, or you must present the
    /// requesting app client's <c>ClientId</c> and, if the client has a secret, <c>ClientSecret</c>,
    /// in the request. </para> <para> The requesting app client must have <c>ALLOW_TOKEN_EXCHANGE_IMPERSONATION</c>
    /// or <c>ALLOW_TOKEN_EXCHANGE_DELEGATION</c> in its <c>ExplicitAuthFlows</c> (depending
    /// on whether you include an <c>ActorToken</c>), or the request fails. </para>
    /// </summary>
    public partial class GetDerivedTokenRequest : AmazonCognitoIdentityProviderRequest
    {
        /// <summary>
        /// Gets and sets the property ActorToken. 
        /// <para>
        /// A token that identifies the intermediary service that is exchanging the token on behalf
        /// of the user. When you provide an <c>ActorToken</c>, the token that Amazon Cognito
        /// issues carries an <c>act</c> claim that identifies the intermediary, so that downstream
        /// services can distinguish a user acting directly from an intermediary acting on the
        /// user's behalf.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive = true, Min = 0, Max = 131072)]
        public string ActorToken { get; set; }

        /// <summary>
        /// Checks to see if the ActorToken property is set.
        /// </summary>
        internal bool IsSetActorToken() => this.ActorToken != null;

        /// <summary>
        /// Gets and sets the property ActorTokenProviderName. 
        /// <para>
        /// The name of the third-party identity provider that issued the <c>ActorToken</c>, if
        /// the actor token isn't a Amazon Cognito token.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 32)]
        public string ActorTokenProviderName { get; set; }

        /// <summary>
        /// Checks to see if the ActorTokenProviderName property is set.
        /// </summary>
        internal bool IsSetActorTokenProviderName() => this.ActorTokenProviderName != null;

        /// <summary>
        /// Gets and sets the property ActorTokenType. 
        /// <para>
        /// The type of the <c>ActorToken</c> that you provide. Required when you provide an <c>ActorToken</c>.
        /// Valid values:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>ACCESS_TOKEN</c> – The actor token is an access token.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>ID_TOKEN</c> – The actor token is an ID token.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>SAML2</c> – The actor token is a SAML 2.0 assertion.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public TokenTypeIdentifierType ActorTokenType { get; set; }

        /// <summary>
        /// Checks to see if the ActorTokenType property is set.
        /// </summary>
        internal bool IsSetActorTokenType() => this.ActorTokenType != null;

        /// <summary>
        /// Gets and sets the property Audiences. 
        /// <para>
        /// The logical name of the target service where you intend to use the issued token. You
        /// can't request both <c>Audiences</c> and <c>Resources</c> in the same request.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 0, Max = 1)]
        public List<string> Audiences { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the Audiences property is set.
        /// </summary>
        internal bool IsSetAudiences() => this.Audiences != null && (this.Audiences.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property ClientId. 
        /// <para>
        /// The ID of the app client that requests the token exchange.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Sensitive = true, Min = 1, Max = 128)]
        public string ClientId { get; set; }

        /// <summary>
        /// Checks to see if the ClientId property is set.
        /// </summary>
        internal bool IsSetClientId() => this.ClientId != null;

        /// <summary>
        /// Gets and sets the property ClientSecret. 
        /// <para>
        /// The client secret of the requested app client, if the client has a secret.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive = true, Min = 24, Max = 64)]
        public string ClientSecret { get; set; }

        /// <summary>
        /// Checks to see if the ClientSecret property is set.
        /// </summary>
        internal bool IsSetClientSecret() => this.ClientSecret != null;

        /// <summary>
        /// Gets and sets the property RequestedTokenType. 
        /// <para>
        /// The type of token that you want Amazon Cognito to issue. Valid values:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>ACCESS_TOKEN</c> – Issues an access token.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>ID_TOKEN</c> – Issues an ID token.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// Amazon Cognito can't issue a SAML assertion, so <c>SAML2</c> isn't a valid value for
        /// this parameter.
        /// </para>
        /// </summary>
        public IssuedTokenTypeIdentifierType RequestedTokenType { get; set; }

        /// <summary>
        /// Checks to see if the RequestedTokenType property is set.
        /// </summary>
        internal bool IsSetRequestedTokenType() => this.RequestedTokenType != null;

        /// <summary>
        /// Gets and sets the property Resources. 
        /// <para>
        /// The identifier of a resource server in your user pool where you intend to use the
        /// issued token. You can't request both <c>Resources</c> and <c>Audiences</c> in the
        /// same request.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 0, Max = 1)]
        public List<string> Resources { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the Resources property is set.
        /// </summary>
        internal bool IsSetResources() => this.Resources != null && (this.Resources.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property Scopes. 
        /// <para>
        /// The scopes that you want the new token to have. Amazon Cognito issues a token with
        /// the intersection of these requested scopes, the scopes of your <c>SubjectToken</c>,
        /// and the scopes that are allowed for the requesting app client. If you don't specify
        /// any scopes, Amazon Cognito issues a token with the same scopes as your <c>SubjectToken</c>.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 0, Max = 50)]
        public List<string> Scopes { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the Scopes property is set.
        /// </summary>
        internal bool IsSetScopes() => this.Scopes != null && (this.Scopes.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property SubjectToken. 
        /// <para>
        /// The token that you want to exchange for a new token. This is the credential that represents
        /// the identity of the party on behalf of whom the request is being made.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Sensitive = true, Min = 0, Max = 131072)]
        public string SubjectToken { get; set; }

        /// <summary>
        /// Checks to see if the SubjectToken property is set.
        /// </summary>
        internal bool IsSetSubjectToken() => this.SubjectToken != null;

        /// <summary>
        /// Gets and sets the property SubjectTokenProviderName. 
        /// <para>
        /// The name of the third-party identity provider that issued the <c>SubjectToken</c>,
        /// if the subject token isn't a Amazon Cognito token. Provide this value when your <c>SubjectToken</c>
        /// came from a SAML or OIDC provider that you registered with your user pool, so that
        /// Amazon Cognito can validate it against that provider's configuration. Omit this parameter
        /// for a Amazon Cognito ID or access token.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 32)]
        public string SubjectTokenProviderName { get; set; }

        /// <summary>
        /// Checks to see if the SubjectTokenProviderName property is set.
        /// </summary>
        internal bool IsSetSubjectTokenProviderName() => this.SubjectTokenProviderName != null;

        /// <summary>
        /// Gets and sets the property SubjectTokenType. 
        /// <para>
        /// The type of the <c>SubjectToken</c> that you want to exchange. Valid values:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>ACCESS_TOKEN</c> – The subject token is an access token.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>ID_TOKEN</c> – The subject token is an ID token.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>SAML2</c> – The subject token is a SAML 2.0 assertion.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        [AWSProperty(Required = true)]
        public TokenTypeIdentifierType SubjectTokenType { get; set; }

        /// <summary>
        /// Checks to see if the SubjectTokenType property is set.
        /// </summary>
        internal bool IsSetSubjectTokenType() => this.SubjectTokenType != null;
    }
}
