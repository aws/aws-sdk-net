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
    /// <para>
    /// You can also use this operation to enable token revocation for user pool clients.
    /// For more information about revoking tokens, see <a href="https://docs.aws.amazon.com/cognito-user-identity-pools/latest/APIReference/API_RevokeToken.html">RevokeToken</a>.
    /// </para>
    /// </summary>
    public partial class UpdateUserPoolClientRequest : AmazonCognitoIdentityProviderRequest
    {
        private int? _accessTokenValidity;
        private List<string> _allowedOAuthFlows = new List<string>();
        private bool? _allowedOAuthFlowsUserPoolClient;
        private List<string> _allowedOAuthScopes = new List<string>();
        private AnalyticsConfigurationType _analyticsConfiguration;
        private int? _authSessionValidity;
        private List<string> _callbackURLs = new List<string>();
        private string _clientId;
        private string _clientName;
        private string _defaultRedirectURI;
        private bool? _enablePropagateAdditionalUserContextData;
        private bool? _enableTokenRevocation;
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
        /// The access token time limit. After this limit expires, your user can't use their access
        /// token. To specify the time unit for <code>AccessTokenValidity</code> as <code>seconds</code>,
        /// <code>minutes</code>, <code>hours</code>, or <code>days</code>, set a <code>TokenValidityUnits</code>
        /// value in your API request.
        /// </para>
        ///  
        /// <para>
        /// For example, when you set <code>AccessTokenValidity</code> to <code>10</code> and
        /// <code>TokenValidityUnits</code> to <code>hours</code>, your user can authorize access
        /// with their access token for 10 hours.
        /// </para>
        ///  
        /// <para>
        /// The default time unit for <code>AccessTokenValidity</code> in an API request is hours.
        /// <i>Valid range</i> is displayed below in seconds.
        /// </para>
        ///  
        /// <para>
        /// If you don't specify otherwise in the configuration of your app client, your access
        /// tokens are valid for one hour.
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
        ///  <dl> <dt>code</dt> <dd> 
        /// <para>
        /// Use a code grant flow, which provides an authorization code as the response. This
        /// code can be exchanged for access tokens with the <code>/oauth2/token</code> endpoint.
        /// </para>
        ///  </dd> <dt>implicit</dt> <dd> 
        /// <para>
        /// Issue the access token (and, optionally, ID token, based on scopes) directly to your
        /// user.
        /// </para>
        ///  </dd> <dt>client_credentials</dt> <dd> 
        /// <para>
        /// Issue the access token from the <code>/oauth2/token</code> endpoint directly to a
        /// non-person user using a combination of the client ID and client secret.
        /// </para>
        ///  </dd> </dl>
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
        /// with Amazon Cognito user pools.
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
        /// The allowed OAuth scopes. Possible values provided by OAuth are <code>phone</code>,
        /// <code>email</code>, <code>openid</code>, and <code>profile</code>. Possible values
        /// provided by Amazon Web Services are <code>aws.cognito.signin.user.admin</code>. Custom
        /// scopes created in Resource Servers are also supported.
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
        /// The Amazon Pinpoint analytics configuration necessary to collect metrics for this
        /// user pool.
        /// </para>
        ///  <note> 
        /// <para>
        /// In Amazon Web Services Regions where Amazon Pinpoint isn't available, user pools only
        /// support sending events to Amazon Pinpoint projects in us-east-1. In Regions where
        /// Amazon Pinpoint is available, user pools support sending events to Amazon Pinpoint
        /// projects within that same Region.
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
        /// Gets and sets the property AuthSessionValidity. 
        /// <para>
        /// Amazon Cognito creates a session token for each API request in an authentication flow.
        /// <code>AuthSessionValidity</code> is the duration, in minutes, of that session token.
        /// Your user pool native user must respond to each authentication challenge before the
        /// session expires.
        /// </para>
        /// </summary>
        [AWSProperty(Min=3, Max=15)]
        public int AuthSessionValidity
        {
            get { return this._authSessionValidity.GetValueOrDefault(); }
            set { this._authSessionValidity = value; }
        }

        // Check to see if AuthSessionValidity property is set
        internal bool IsSetAuthSessionValidity()
        {
            return this._authSessionValidity.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property CallbackURLs. 
        /// <para>
        /// A list of allowed redirect (callback) URLs for the IdPs.
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
        /// App callback URLs such as <code>myapp://example</code> are also supported.
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
        [AWSProperty(Required=true, Sensitive=true, Min=1, Max=128)]
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
        /// Amazon Cognito requires HTTPS over HTTP except for <code>http://localhost</code> for
        /// testing purposes only.
        /// </para>
        ///  
        /// <para>
        /// App callback URLs such as <code>myapp://example</code> are also supported.
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
        /// Gets and sets the property EnablePropagateAdditionalUserContextData. 
        /// <para>
        /// Activates the propagation of additional user context data. For more information about
        /// propagation of user context data, see <a href="https://docs.aws.amazon.com/cognito/latest/developerguide/cognito-user-pool-settings-advanced-security.html">
        /// Adding advanced security to a user pool</a>. If you don’t include this parameter,
        /// you can't send device fingerprint information, including source IP address, to Amazon
        /// Cognito advanced security. You can only activate <code>EnablePropagateAdditionalUserContextData</code>
        /// in an app client that has a client secret.
        /// </para>
        /// </summary>
        public bool EnablePropagateAdditionalUserContextData
        {
            get { return this._enablePropagateAdditionalUserContextData.GetValueOrDefault(); }
            set { this._enablePropagateAdditionalUserContextData = value; }
        }

        // Check to see if EnablePropagateAdditionalUserContextData property is set
        internal bool IsSetEnablePropagateAdditionalUserContextData()
        {
            return this._enablePropagateAdditionalUserContextData.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property EnableTokenRevocation. 
        /// <para>
        /// Activates or deactivates token revocation. For more information about revoking tokens,
        /// see <a href="https://docs.aws.amazon.com/cognito-user-identity-pools/latest/APIReference/API_RevokeToken.html">RevokeToken</a>.
        /// </para>
        /// </summary>
        public bool EnableTokenRevocation
        {
            get { return this._enableTokenRevocation.GetValueOrDefault(); }
            set { this._enableTokenRevocation = value; }
        }

        // Check to see if EnableTokenRevocation property is set
        internal bool IsSetEnableTokenRevocation()
        {
            return this._enableTokenRevocation.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property ExplicitAuthFlows. 
        /// <para>
        /// The authentication flows that you want your user pool client to support. For each
        /// app client in your user pool, you can sign in your users with any combination of one
        /// or more flows, including with a user name and Secure Remote Password (SRP), a user
        /// name and password, or a custom authentication process that you define with Lambda
        /// functions.
        /// </para>
        ///  <note> 
        /// <para>
        /// If you don't specify a value for <code>ExplicitAuthFlows</code>, your user client
        /// supports <code>ALLOW_REFRESH_TOKEN_AUTH</code>, <code>ALLOW_USER_SRP_AUTH</code>,
        /// and <code>ALLOW_CUSTOM_AUTH</code>.
        /// </para>
        ///  </note> 
        /// <para>
        /// Valid values include:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <code>ALLOW_ADMIN_USER_PASSWORD_AUTH</code>: Enable admin based user password authentication
        /// flow <code>ADMIN_USER_PASSWORD_AUTH</code>. This setting replaces the <code>ADMIN_NO_SRP_AUTH</code>
        /// setting. With this authentication flow, your app passes a user name and password to
        /// Amazon Cognito in the request, instead of using the Secure Remote Password (SRP) protocol
        /// to securely transmit the password.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>ALLOW_CUSTOM_AUTH</code>: Enable Lambda trigger based authentication.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>ALLOW_USER_PASSWORD_AUTH</code>: Enable user password-based authentication.
        /// In this flow, Amazon Cognito receives the password in the request instead of using
        /// the SRP protocol to verify passwords.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>ALLOW_USER_SRP_AUTH</code>: Enable SRP-based authentication.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>ALLOW_REFRESH_TOKEN_AUTH</code>: Enable authflow to refresh tokens.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// In some environments, you will see the values <code>ADMIN_NO_SRP_AUTH</code>, <code>CUSTOM_AUTH_FLOW_ONLY</code>,
        /// or <code>USER_PASSWORD_AUTH</code>. You can't assign these legacy <code>ExplicitAuthFlows</code>
        /// values to user pool clients at the same time as values that begin with <code>ALLOW_</code>,
        /// like <code>ALLOW_USER_SRP_AUTH</code>.
        /// </para>
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
        /// The ID token time limit. After this limit expires, your user can't use their ID token.
        /// To specify the time unit for <code>IdTokenValidity</code> as <code>seconds</code>,
        /// <code>minutes</code>, <code>hours</code>, or <code>days</code>, set a <code>TokenValidityUnits</code>
        /// value in your API request.
        /// </para>
        ///  
        /// <para>
        /// For example, when you set <code>IdTokenValidity</code> as <code>10</code> and <code>TokenValidityUnits</code>
        /// as <code>hours</code>, your user can authenticate their session with their ID token
        /// for 10 hours.
        /// </para>
        ///  
        /// <para>
        /// The default time unit for <code>AccessTokenValidity</code> in an API request is hours.
        /// <i>Valid range</i> is displayed below in seconds.
        /// </para>
        ///  
        /// <para>
        /// If you don't specify otherwise in the configuration of your app client, your ID tokens
        /// are valid for one hour.
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
        /// A list of allowed logout URLs for the IdPs.
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
        /// Errors and responses that you want Amazon Cognito APIs to return during authentication,
        /// account confirmation, and password recovery when the user doesn't exist in the user
        /// pool. When set to <code>ENABLED</code> and the user doesn't exist, authentication
        /// returns an error indicating either the username or password was incorrect. Account
        /// confirmation and password recovery return a response indicating a code was sent to
        /// a simulated destination. When set to <code>LEGACY</code>, those APIs return a <code>UserNotFoundException</code>
        /// exception if the user doesn't exist in the user pool.
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
        ///  <code>LEGACY</code> - This represents the early behavior of Amazon Cognito where
        /// user existence related errors aren't prevented.
        /// </para>
        ///  </li> </ul>
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
        /// The refresh token time limit. After this limit expires, your user can't use their
        /// refresh token. To specify the time unit for <code>RefreshTokenValidity</code> as <code>seconds</code>,
        /// <code>minutes</code>, <code>hours</code>, or <code>days</code>, set a <code>TokenValidityUnits</code>
        /// value in your API request.
        /// </para>
        ///  
        /// <para>
        /// For example, when you set <code>RefreshTokenValidity</code> as <code>10</code> and
        /// <code>TokenValidityUnits</code> as <code>days</code>, your user can refresh their
        /// session and retrieve new access and ID tokens for 10 days.
        /// </para>
        ///  
        /// <para>
        /// The default time unit for <code>RefreshTokenValidity</code> in an API request is days.
        /// You can't set <code>RefreshTokenValidity</code> to 0. If you do, Amazon Cognito overrides
        /// the value with the default value of 30 days. <i>Valid range</i> is displayed below
        /// in seconds.
        /// </para>
        ///  
        /// <para>
        /// If you don't specify otherwise in the configuration of your app client, your refresh
        /// tokens are valid for 30 days.
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
        /// A list of provider names for the IdPs that this client supports. The following are
        /// supported: <code>COGNITO</code>, <code>Facebook</code>, <code>Google</code>, <code>SignInWithApple</code>,
        /// <code>LoginWithAmazon</code>, and the names of your own SAML and OIDC providers.
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
        /// The units in which the validity times are represented. The default unit for RefreshToken
        /// is days, and the default for ID and access tokens is hours.
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