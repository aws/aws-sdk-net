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
    /// A user pool identity provider (IdP). Contains information about a third-party IdP
    /// to a user pool, the attributes that it populates to user profiles, and the trust relationship
    /// between the IdP and your user pool.
    /// </summary>
    public partial class IdentityProviderType
    {
        private Dictionary<string, string> _attributeMapping = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;
        private DateTime? _creationDate;
        private List<string> _idpIdentifiers = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private DateTime? _lastModifiedDate;
        private Dictionary<string, string> _providerDetails = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;
        private string _providerName;
        private IdentityProviderTypeType _providerType;
        private string _userPoolId;

        /// <summary>
        /// Gets and sets the property AttributeMapping. 
        /// <para>
        /// A mapping of IdP attributes to standard and custom user pool attributes.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public Dictionary<string, string> AttributeMapping
        {
            get { return this._attributeMapping; }
            set { this._attributeMapping = value; }
        }

        // Check to see if AttributeMapping property is set
        internal bool IsSetAttributeMapping()
        {
            return this._attributeMapping != null && (this._attributeMapping.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property CreationDate. 
        /// <para>
        /// The date and time when the item was created. Amazon Cognito returns this timestamp
        /// in UNIX epoch time format. Your SDK might render the output in a human-readable format
        /// like ISO 8601 or a Java <c>Date</c> object.
        /// </para>
        /// </summary>
        public DateTime? CreationDate
        {
            get { return this._creationDate; }
            set { this._creationDate = value; }
        }

        // Check to see if CreationDate property is set
        internal bool IsSetCreationDate()
        {
            return this._creationDate.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property IdpIdentifiers. 
        /// <para>
        /// A list of IdP identifiers. IdP identifiers are strings that represent friendly names
        /// or domain names of IdPs, for example <c>MyIdP</c> or <c>auth.example.com</c>. You
        /// can choose to route user authorization requests to the right IdP with either IdP identifiers
        /// or IdP names. For more information, see <c>identity_provider</c> and <c>idp_identifier</c>
        /// at <a href="https://docs.aws.amazon.com/cognito/latest/developerguide/authorization-endpoint.html#get-authorize-request-parameters">Authorize
        /// endpoint</a>.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=0, Max=50)]
        public List<string> IdpIdentifiers
        {
            get { return this._idpIdentifiers; }
            set { this._idpIdentifiers = value; }
        }

        // Check to see if IdpIdentifiers property is set
        internal bool IsSetIdpIdentifiers()
        {
            return this._idpIdentifiers != null && (this._idpIdentifiers.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property LastModifiedDate. 
        /// <para>
        /// The date and time when the item was modified. Amazon Cognito returns this timestamp
        /// in UNIX epoch time format. Your SDK might render the output in a human-readable format
        /// like ISO 8601 or a Java <c>Date</c> object.
        /// </para>
        /// </summary>
        public DateTime? LastModifiedDate
        {
            get { return this._lastModifiedDate; }
            set { this._lastModifiedDate = value; }
        }

        // Check to see if LastModifiedDate property is set
        internal bool IsSetLastModifiedDate()
        {
            return this._lastModifiedDate.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property ProviderDetails. 
        /// <para>
        /// The scopes, URLs, and identifiers for your external identity provider. The following
        /// examples describe the provider detail keys for each IdP type. These values and their
        /// schema are subject to change. Social IdP <c>authorize_scopes</c> values must match
        /// the values listed here.
        /// </para>
        ///  <dl> <dt>OpenID Connect (OIDC)</dt> <dd> 
        /// <para>
        /// Amazon Cognito accepts the following elements when it can't discover endpoint URLs
        /// from <c>oidc_issuer</c>: <c>attributes_url</c>, <c>authorize_url</c>, <c>jwks_uri</c>,
        /// <c>token_url</c>.
        /// </para>
        ///  
        /// <para>
        /// Create or update request: <c>"ProviderDetails": { "attributes_request_method": "GET",
        /// "attributes_url": "https://auth.example.com/userInfo", "authorize_scopes": "openid
        /// profile email", "authorize_url": "https://auth.example.com/authorize", "client_id":
        /// "1example23456789", "client_secret": "provider-app-client-secret", "jwks_uri": "https://auth.example.com/.well-known/jwks.json",
        /// "oidc_issuer": "https://auth.example.com", "token_url": "https://example.com/token"
        /// }</c> 
        /// </para>
        ///  
        /// <para>
        /// Describe response: <c>"ProviderDetails": { "attributes_request_method": "GET", "attributes_url":
        /// "https://auth.example.com/userInfo", "attributes_url_add_attributes": "false", "authorize_scopes":
        /// "openid profile email", "authorize_url": "https://auth.example.com/authorize", "client_id":
        /// "1example23456789", "client_secret": "provider-app-client-secret", "jwks_uri": "https://auth.example.com/.well-known/jwks.json",
        /// "oidc_issuer": "https://auth.example.com", "token_url": "https://example.com/token"
        /// }</c> 
        /// </para>
        ///  </dd> <dt>SAML</dt> <dd> 
        /// <para>
        /// Create or update request with Metadata URL: <c>"ProviderDetails": { "IDPInit": "true",
        /// "IDPSignout": "true", "EncryptedResponses" : "true", "MetadataURL": "https://auth.example.com/sso/saml/metadata",
        /// "RequestSigningAlgorithm": "rsa-sha256" }</c> 
        /// </para>
        ///  
        /// <para>
        /// Create or update request with Metadata file: <c>"ProviderDetails": { "IDPInit": "true",
        /// "IDPSignout": "true", "EncryptedResponses" : "true", "MetadataFile": "[metadata XML]",
        /// "RequestSigningAlgorithm": "rsa-sha256" }</c> 
        /// </para>
        ///  
        /// <para>
        /// The value of <c>MetadataFile</c> must be the plaintext metadata document with all
        /// quote (") characters escaped by backslashes.
        /// </para>
        ///  
        /// <para>
        /// Describe response: <c>"ProviderDetails": { "IDPInit": "true", "IDPSignout": "true",
        /// "EncryptedResponses" : "true", "ActiveEncryptionCertificate": "[certificate]", "MetadataURL":
        /// "https://auth.example.com/sso/saml/metadata", "RequestSigningAlgorithm": "rsa-sha256",
        /// "SLORedirectBindingURI": "https://auth.example.com/slo/saml", "SSORedirectBindingURI":
        /// "https://auth.example.com/sso/saml" }</c> 
        /// </para>
        ///  </dd> <dt>LoginWithAmazon</dt> <dd> 
        /// <para>
        /// Create or update request: <c>"ProviderDetails": { "authorize_scopes": "profile postal_code",
        /// "client_id": "amzn1.application-oa2-client.1example23456789", "client_secret": "provider-app-client-secret"</c>
        /// 
        /// </para>
        ///  
        /// <para>
        /// Describe response: <c>"ProviderDetails": { "attributes_url": "https://api.amazon.com/user/profile",
        /// "attributes_url_add_attributes": "false", "authorize_scopes": "profile postal_code",
        /// "authorize_url": "https://www.amazon.com/ap/oa", "client_id": "amzn1.application-oa2-client.1example23456789",
        /// "client_secret": "provider-app-client-secret", "token_request_method": "POST", "token_url":
        /// "https://api.amazon.com/auth/o2/token" }</c> 
        /// </para>
        ///  </dd> <dt>Google</dt> <dd> 
        /// <para>
        /// Create or update request: <c>"ProviderDetails": { "authorize_scopes": "email profile
        /// openid", "client_id": "1example23456789.apps.googleusercontent.com", "client_secret":
        /// "provider-app-client-secret" }</c> 
        /// </para>
        ///  
        /// <para>
        /// Describe response: <c>"ProviderDetails": { "attributes_url": "https://people.googleapis.com/v1/people/me?personFields=",
        /// "attributes_url_add_attributes": "true", "authorize_scopes": "email profile openid",
        /// "authorize_url": "https://accounts.google.com/o/oauth2/v2/auth", "client_id": "1example23456789.apps.googleusercontent.com",
        /// "client_secret": "provider-app-client-secret", "oidc_issuer": "https://accounts.google.com",
        /// "token_request_method": "POST", "token_url": "https://www.googleapis.com/oauth2/v4/token"
        /// }</c> 
        /// </para>
        ///  </dd> <dt>SignInWithApple</dt> <dd> 
        /// <para>
        /// Create or update request: <c>"ProviderDetails": { "authorize_scopes": "email name",
        /// "client_id": "com.example.cognito", "private_key": "1EXAMPLE", "key_id": "2EXAMPLE",
        /// "team_id": "3EXAMPLE" }</c> 
        /// </para>
        ///  
        /// <para>
        /// Describe response: <c>"ProviderDetails": { "attributes_url_add_attributes": "false",
        /// "authorize_scopes": "email name", "authorize_url": "https://appleid.apple.com/auth/authorize",
        /// "client_id": "com.example.cognito", "key_id": "1EXAMPLE", "oidc_issuer": "https://appleid.apple.com",
        /// "team_id": "2EXAMPLE", "token_request_method": "POST", "token_url": "https://appleid.apple.com/auth/token"
        /// }</c> 
        /// </para>
        ///  </dd> <dt>Facebook</dt> <dd> 
        /// <para>
        /// Create or update request: <c>"ProviderDetails": { "api_version": "v17.0", "authorize_scopes":
        /// "public_profile, email", "client_id": "1example23456789", "client_secret": "provider-app-client-secret"
        /// }</c> 
        /// </para>
        ///  
        /// <para>
        /// Describe response: <c>"ProviderDetails": { "api_version": "v17.0", "attributes_url":
        /// "https://graph.facebook.com/v17.0/me?fields=", "attributes_url_add_attributes": "true",
        /// "authorize_scopes": "public_profile, email", "authorize_url": "https://www.facebook.com/v17.0/dialog/oauth",
        /// "client_id": "1example23456789", "client_secret": "provider-app-client-secret", "token_request_method":
        /// "GET", "token_url": "https://graph.facebook.com/v17.0/oauth/access_token" }</c> 
        /// </para>
        ///  </dd> </dl>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public Dictionary<string, string> ProviderDetails
        {
            get { return this._providerDetails; }
            set { this._providerDetails = value; }
        }

        // Check to see if ProviderDetails property is set
        internal bool IsSetProviderDetails()
        {
            return this._providerDetails != null && (this._providerDetails.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property ProviderName. 
        /// <para>
        /// A friendly name for the IdP.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=32)]
        public string ProviderName
        {
            get { return this._providerName; }
            set { this._providerName = value; }
        }

        // Check to see if ProviderName property is set
        internal bool IsSetProviderName()
        {
            return this._providerName != null;
        }

        /// <summary>
        /// Gets and sets the property ProviderType. 
        /// <para>
        /// The type of IdP. Either SAML, OIDC, or a named social identity provider.
        /// </para>
        /// </summary>
        public IdentityProviderTypeType ProviderType
        {
            get { return this._providerType; }
            set { this._providerType = value; }
        }

        // Check to see if ProviderType property is set
        internal bool IsSetProviderType()
        {
            return this._providerType != null;
        }

        /// <summary>
        /// Gets and sets the property UserPoolId. 
        /// <para>
        /// The ID of the user pool associated with the IdP.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=55)]
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