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
    /// Container for the parameters to the UpdateUserPoolClient operation.
    /// Updates the specified user pool app client with the specified attributes. You can
    /// get a list of the current user pool app client settings using <a href="https://docs.aws.amazon.com/cognito-user-identity-pools/latest/APIReference/API_DescribeUserPoolClient.html">DescribeUserPoolClient</a>.
    /// 
    ///  <important> 
    /// <para>
    /// If you don't provide a value for an attribute, it will be set to the default value.
    /// </para>
    ///  </important>
    /// </summary>
    public partial class UpdateUserPoolClientRequest : AmazonCognitoIdentityProviderRequest
    {
        private int? _accessTokenValidity;
        private List<string> _allowedOAuthFlows = new List<string>();
        private bool? _allowedOAuthFlowsUserPoolClient;
        private List<string> _allowedOAuthScopes = new List<string>();
        private AnalyticsConfigurationType _analyticsConfiguration;
        private List<string> _callbackURLs = new List<string>();
        private string _clientId;
        private string _clientName;
        private string _defaultRedirectURI;
        private List<string> _explicitAuthFlows = new List<string>();
        private int? _idTokenValidity;
        private List<string> _logoutURLs = new List<string>();
        private PreventUserExistenceErrorTypes _preventUserExistenceErrors;
        private List<string> _readAttributes = new List<string>();
        private int? _refreshTokenValidity;
        private List<string> _supportedIdentityProviders = new List<string>();
        private TokenValidityUnitsType _tokenValidityUnits;
        private string _userPoolId;
        private List<string> _writeAttributes = new List<string>();

        /// <summary>
        /// Gets and sets the property AccessTokenValidity. 
        /// <para>
        /// The time limit, after which the access token is no longer valid and cannot be used.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=86400)]
        public int AccessTokenValidity
        {
            get { return this._accessTokenValidity.GetValueOrDefault(); }
            set { this._accessTokenValidity = value; }
        }

        // Check to see if AccessTokenValidity property is set
        internal bool IsSetAccessTokenValidity()
        {
            return this._accessTokenValidity.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property AllowedOAuthFlows. 
        /// <para>
        /// The allowed OAuth flows.
        /// </para>
        ///  
        /// <para>
        /// Set to <code>code</code> to initiate a code grant flow, which provides an authorization
        /// code as the response. This code can be exchanged for access tokens with the token
        /// endpoint.
        /// </para>
        ///  
        /// <para>
        /// Set to <code>implicit</code> to specify that the client should get the access token
        /// (and, optionally, ID token, based on scopes) directly.
        /// </para>
        ///  
        /// <para>
        /// Set to <code>client_credentials</code> to specify that the client should get the access
        /// token (and, optionally, ID token, based on scopes) from the token endpoint using a
        /// combination of client and client_secret.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=3)]
        public List<string> AllowedOAuthFlows
        {
            get { return this._allowedOAuthFlows; }
            set { this._allowedOAuthFlows = value; }
        }

        // Check to see if AllowedOAuthFlows property is set
        internal bool IsSetAllowedOAuthFlows()
        {
            return this._allowedOAuthFlows != null && this._allowedOAuthFlows.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property AllowedOAuthFlowsUserPoolClient. 
        /// <para>
        /// Set to true if the client is allowed to follow the OAuth protocol when interacting
        /// with Cognito user pools.
        /// </para>
        /// </summary>
        public bool AllowedOAuthFlowsUserPoolClient
        {
            get { return this._allowedOAuthFlowsUserPoolClient.GetValueOrDefault(); }
            set { this._allowedOAuthFlowsUserPoolClient = value; }
        }

        // Check to see if AllowedOAuthFlowsUserPoolClient property is set
        internal bool IsSetAllowedOAuthFlowsUserPoolClient()
        {
            return this._allowedOAuthFlowsUserPoolClient.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property AllowedOAuthScopes. 
        /// <para>
        /// The allowed OAuth scopes. Possible values provided by OAuth are: <code>phone</code>,
        /// <code>email</code>, <code>openid</code>, and <code>profile</code>. Possible values
        /// provided by AWS are: <code>aws.cognito.signin.user.admin</code>. Custom scopes created
        /// in Resource Servers are also supported.
        /// </para>
        /// </summary>
        [AWSProperty(Max=50)]
        public List<string> AllowedOAuthScopes
        {
            get { return this._allowedOAuthScopes; }
            set { this._allowedOAuthScopes = value; }
        }

        // Check to see if AllowedOAuthScopes property is set
        internal bool IsSetAllowedOAuthScopes()
        {
            return this._allowedOAuthScopes != null && this._allowedOAuthScopes.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property AnalyticsConfiguration. 
        /// <para>
        /// The Amazon Pinpoint analytics configuration for collecting metrics for this user pool.
        /// </para>
        ///  <note> 
        /// <para>
        /// In regions where Pinpoint is not available, Cognito User Pools only supports sending
        /// events to Amazon Pinpoint projects in us-east-1. In regions where Pinpoint is available,
        /// Cognito User Pools will support sending events to Amazon Pinpoint projects within
        /// that same region. 
        /// </para>
        ///  </note>
        /// </summary>
        public AnalyticsConfigurationType AnalyticsConfiguration
        {
            get { return this._analyticsConfiguration; }
            set { this._analyticsConfiguration = value; }
        }

        // Check to see if AnalyticsConfiguration property is set
        internal bool IsSetAnalyticsConfiguration()
        {
            return this._analyticsConfiguration != null;
        }

        /// <summary>
        /// Gets and sets the property CallbackURLs. 
        /// <para>
        /// A list of allowed redirect (callback) URLs for the identity providers.
        /// </para>
        ///  
        /// <para>
        /// A redirect URI must:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Be an absolute URI.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Be registered with the authorization server.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Not include a fragment component.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// See <a href="https://tools.ietf.org/html/rfc6749#section-3.1.2">OAuth 2.0 - Redirection
        /// Endpoint</a>.
        /// </para>
        ///  
        /// <para>
        /// Amazon Cognito requires HTTPS over HTTP except for http://localhost for testing purposes
        /// only.
        /// </para>
        ///  
        /// <para>
        /// App callback URLs such as myapp://example are also supported.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=100)]
        public List<string> CallbackURLs
        {
            get { return this._callbackURLs; }
            set { this._callbackURLs = value; }
        }

        // Check to see if CallbackURLs property is set
        internal bool IsSetCallbackURLs()
        {
            return this._callbackURLs != null && this._callbackURLs.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property ClientId. 
        /// <para>
        /// The ID of the client associated with the user pool.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=128)]
        public string ClientId
        {
            get { return this._clientId; }
            set { this._clientId = value; }
        }

        // Check to see if ClientId property is set
        internal bool IsSetClientId()
        {
            return this._clientId != null;
        }

        /// <summary>
        /// Gets and sets the property ClientName. 
        /// <para>
        /// The client name from the update user pool client request.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=128)]
        public string ClientName
        {
            get { return this._clientName; }
            set { this._clientName = value; }
        }

        // Check to see if ClientName property is set
        internal bool IsSetClientName()
        {
            return this._clientName != null;
        }

        /// <summary>
        /// Gets and sets the property DefaultRedirectURI. 
        /// <para>
        /// The default redirect URI. Must be in the <code>CallbackURLs</code> list.
        /// </para>
        ///  
        /// <para>
        /// A redirect URI must:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Be an absolute URI.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Be registered with the authorization server.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Not include a fragment component.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// See <a href="https://tools.ietf.org/html/rfc6749#section-3.1.2">OAuth 2.0 - Redirection
        /// Endpoint</a>.
        /// </para>
        ///  
        /// <para>
        /// Amazon Cognito requires HTTPS over HTTP except for http://localhost for testing purposes
        /// only.
        /// </para>
        ///  
        /// <para>
        /// App callback URLs such as myapp://example are also supported.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=1024)]
        public string DefaultRedirectURI
        {
            get { return this._defaultRedirectURI; }
            set { this._defaultRedirectURI = value; }
        }

        // Check to see if DefaultRedirectURI property is set
        internal bool IsSetDefaultRedirectURI()
        {
            return this._defaultRedirectURI != null;
        }

        /// <summary>
        /// Gets and sets the property ExplicitAuthFlows. 
        /// <para>
        /// The authentication flows that are supported by the user pool clients. Flow names without
        /// the <code>ALLOW_</code> prefix are deprecated in favor of new names with the <code>ALLOW_</code>
        /// prefix. Note that values with <code>ALLOW_</code> prefix cannot be used along with
        /// values without <code>ALLOW_</code> prefix.
        /// </para>
        ///  
        /// <para>
        /// Valid values include:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <code>ALLOW_ADMIN_USER_PASSWORD_AUTH</code>: Enable admin based user password authentication
        /// flow <code>ADMIN_USER_PASSWORD_AUTH</code>. This setting replaces the <code>ADMIN_NO_SRP_AUTH</code>
        /// setting. With this authentication flow, Cognito receives the password in the request
        /// instead of using the SRP (Secure Remote Password protocol) protocol to verify passwords.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>ALLOW_CUSTOM_AUTH</code>: Enable Lambda trigger based authentication.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>ALLOW_USER_PASSWORD_AUTH</code>: Enable user password-based authentication.
        /// In this flow, Cognito receives the password in the request instead of using the SRP
        /// protocol to verify passwords.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>ALLOW_USER_SRP_AUTH</code>: Enable SRP based authentication.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>ALLOW_REFRESH_TOKEN_AUTH</code>: Enable authflow to refresh tokens.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public List<string> ExplicitAuthFlows
        {
            get { return this._explicitAuthFlows; }
            set { this._explicitAuthFlows = value; }
        }

        // Check to see if ExplicitAuthFlows property is set
        internal bool IsSetExplicitAuthFlows()
        {
            return this._explicitAuthFlows != null && this._explicitAuthFlows.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property IdTokenValidity. 
        /// <para>
        /// The time limit, after which the ID token is no longer valid and cannot be used.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=86400)]
        public int IdTokenValidity
        {
            get { return this._idTokenValidity.GetValueOrDefault(); }
            set { this._idTokenValidity = value; }
        }

        // Check to see if IdTokenValidity property is set
        internal bool IsSetIdTokenValidity()
        {
            return this._idTokenValidity.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property LogoutURLs. 
        /// <para>
        /// A list of allowed logout URLs for the identity providers.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=100)]
        public List<string> LogoutURLs
        {
            get { return this._logoutURLs; }
            set { this._logoutURLs = value; }
        }

        // Check to see if LogoutURLs property is set
        internal bool IsSetLogoutURLs()
        {
            return this._logoutURLs != null && this._logoutURLs.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property PreventUserExistenceErrors. 
        /// <para>
        /// Use this setting to choose which errors and responses are returned by Cognito APIs
        /// during authentication, account confirmation, and password recovery when the user does
        /// not exist in the user pool. When set to <code>ENABLED</code> and the user does not
        /// exist, authentication returns an error indicating either the username or password
        /// was incorrect, and account confirmation and password recovery return a response indicating
        /// a code was sent to a simulated destination. When set to <code>LEGACY</code>, those
        /// APIs will return a <code>UserNotFoundException</code> exception if the user does not
        /// exist in the user pool.
        /// </para>
        ///  
        /// <para>
        /// Valid values include:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <code>ENABLED</code> - This prevents user existence-related errors.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>LEGACY</code> - This represents the old behavior of Cognito where user existence
        /// related errors are not prevented.
        /// </para>
        ///  </li> </ul> <note> 
        /// <para>
        /// After February 15th 2020, the value of <code>PreventUserExistenceErrors</code> will
        /// default to <code>ENABLED</code> for newly created user pool clients if no value is
        /// provided.
        /// </para>
        ///  </note>
        /// </summary>
        public PreventUserExistenceErrorTypes PreventUserExistenceErrors
        {
            get { return this._preventUserExistenceErrors; }
            set { this._preventUserExistenceErrors = value; }
        }

        // Check to see if PreventUserExistenceErrors property is set
        internal bool IsSetPreventUserExistenceErrors()
        {
            return this._preventUserExistenceErrors != null;
        }

        /// <summary>
        /// Gets and sets the property ReadAttributes. 
        /// <para>
        /// The read-only attributes of the user pool.
        /// </para>
        /// </summary>
        public List<string> ReadAttributes
        {
            get { return this._readAttributes; }
            set { this._readAttributes = value; }
        }

        // Check to see if ReadAttributes property is set
        internal bool IsSetReadAttributes()
        {
            return this._readAttributes != null && this._readAttributes.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property RefreshTokenValidity. 
        /// <para>
        /// The time limit, in days, after which the refresh token is no longer valid and cannot
        /// be used.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=315360000)]
        public int RefreshTokenValidity
        {
            get { return this._refreshTokenValidity.GetValueOrDefault(); }
            set { this._refreshTokenValidity = value; }
        }

        // Check to see if RefreshTokenValidity property is set
        internal bool IsSetRefreshTokenValidity()
        {
            return this._refreshTokenValidity.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property SupportedIdentityProviders. 
        /// <para>
        /// A list of provider names for the identity providers that are supported on this client.
        /// </para>
        /// </summary>
        public List<string> SupportedIdentityProviders
        {
            get { return this._supportedIdentityProviders; }
            set { this._supportedIdentityProviders = value; }
        }

        // Check to see if SupportedIdentityProviders property is set
        internal bool IsSetSupportedIdentityProviders()
        {
            return this._supportedIdentityProviders != null && this._supportedIdentityProviders.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property TokenValidityUnits. 
        /// <para>
        /// The units in which the validity times are represented in. Default for RefreshToken
        /// is days, and default for ID and access tokens are hours.
        /// </para>
        /// </summary>
        public TokenValidityUnitsType TokenValidityUnits
        {
            get { return this._tokenValidityUnits; }
            set { this._tokenValidityUnits = value; }
        }

        // Check to see if TokenValidityUnits property is set
        internal bool IsSetTokenValidityUnits()
        {
            return this._tokenValidityUnits != null;
        }

        /// <summary>
        /// Gets and sets the property UserPoolId. 
        /// <para>
        /// The user pool ID for the user pool where you want to update the user pool client.
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

        /// <summary>
        /// Gets and sets the property WriteAttributes. 
        /// <para>
        /// The writeable attributes of the user pool.
        /// </para>
        /// </summary>
        public List<string> WriteAttributes
        {
            get { return this._writeAttributes; }
            set { this._writeAttributes = value; }
        }

        // Check to see if WriteAttributes property is set
        internal bool IsSetWriteAttributes()
        {
            return this._writeAttributes != null && this._writeAttributes.Count > 0; 
        }

    }
}