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
    /// The configuration of a user pool client.
    /// </summary>
    public partial class UserPoolClientType
    {
        private int? _accessTokenValidity;
        private List<string> _allowedOAuthFlows = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private bool? _allowedOAuthFlowsUserPoolClient;
        private List<string> _allowedOAuthScopes = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private AnalyticsConfigurationType _analyticsConfiguration;
        private int? _authSessionValidity;
        private List<string> _callbackURLs = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private string _clientId;
        private string _clientName;
        private string _clientSecret;
        private DateTime? _creationDate;
        private string _defaultRedirectURI;
        private bool? _enablePropagateAdditionalUserContextData;
        private bool? _enableTokenRevocation;
        private List<string> _explicitAuthFlows = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private int? _idTokenValidity;
        private DateTime? _lastModifiedDate;
        private List<string> _logoutURLs = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private PreventUserExistenceErrorTypes _preventUserExistenceErrors;
        private List<string> _readAttributes = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private RefreshTokenRotationType _refreshTokenRotation;
        private int? _refreshTokenValidity;
        private List<string> _supportedIdentityProviders = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private TokenValidityUnitsType _tokenValidityUnits;
        private string _userPoolId;
        private List<string> _writeAttributes = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Gets and sets the property AccessTokenValidity. 
        /// <para>
        /// The access token time limit. After this limit expires, your user can't use their access
        /// token. To specify the time unit for <c>AccessTokenValidity</c> as <c>seconds</c>,
        /// <c>minutes</c>, <c>hours</c>, or <c>days</c>, set a <c>TokenValidityUnits</c> value
        /// in your API request.
        /// </para>
        ///  
        /// <para>
        /// For example, when you set <c>AccessTokenValidity</c> to <c>10</c> and <c>TokenValidityUnits</c>
        /// to <c>hours</c>, your user can authorize access with their access token for 10 hours.
        /// </para>
        ///  
        /// <para>
        /// The default time unit for <c>AccessTokenValidity</c> in an API request is hours. <i>Valid
        /// range</i> is displayed below in seconds.
        /// </para>
        ///  
        /// <para>
        /// If you don't specify otherwise in the configuration of your app client, your access
        /// tokens are valid for one hour.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=86400)]
        public int? AccessTokenValidity
        {
            get { return this._accessTokenValidity; }
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
        /// The OAuth grant types that you want your app client to generate. To create an app
        /// client that generates client credentials grants, you must add <c>client_credentials</c>
        /// as the only allowed OAuth flow.
        /// </para>
        ///  <dl> <dt>code</dt> <dd> 
        /// <para>
        /// Use a code grant flow, which provides an authorization code as the response. This
        /// code can be exchanged for access tokens with the <c>/oauth2/token</c> endpoint.
        /// </para>
        ///  </dd> <dt>implicit</dt> <dd> 
        /// <para>
        /// Issue the access token (and, optionally, ID token, based on scopes) directly to your
        /// user.
        /// </para>
        ///  </dd> <dt>client_credentials</dt> <dd> 
        /// <para>
        /// Issue the access token from the <c>/oauth2/token</c> endpoint directly to a non-person
        /// user using a combination of the client ID and client secret.
        /// </para>
        ///  </dd> </dl>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
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
            return this._allowedOAuthFlows != null && (this._allowedOAuthFlows.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property AllowedOAuthFlowsUserPoolClient. 
        /// <para>
        /// Set to <c>true</c> to use OAuth 2.0 authorization server features in your app client.
        /// </para>
        ///  
        /// <para>
        /// This parameter must have a value of <c>true</c> before you can configure the following
        /// features in your app client.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>CallBackURLs</c>: Callback URLs.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>LogoutURLs</c>: Sign-out redirect URLs.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>AllowedOAuthScopes</c>: OAuth 2.0 scopes.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>AllowedOAuthFlows</c>: Support for authorization code, implicit, and client credentials
        /// OAuth 2.0 grants.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// To use authorization server features, configure one of these features in the Amazon
        /// Cognito console or set <c>AllowedOAuthFlowsUserPoolClient</c> to <c>true</c> in a
        /// <c>CreateUserPoolClient</c> or <c>UpdateUserPoolClient</c> API request. If you don't
        /// set a value for <c>AllowedOAuthFlowsUserPoolClient</c> in a request with the CLI or
        /// SDKs, it defaults to <c>false</c>. When <c>false</c>, only SDK-based API sign-in is
        /// permitted.
        /// </para>
        /// </summary>
        public bool? AllowedOAuthFlowsUserPoolClient
        {
            get { return this._allowedOAuthFlowsUserPoolClient; }
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
        /// The OAuth 2.0 scopes that you want your app client to support. Can include standard
        /// OAuth scopes like <c>phone</c>, <c>email</c>, <c>openid</c>, and <c>profile</c>. Can
        /// also include the <c>aws.cognito.signin.user.admin</c> scope that authorizes user profile
        /// self-service operations and custom scopes from resource servers.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
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
            return this._allowedOAuthScopes != null && (this._allowedOAuthScopes.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property AnalyticsConfiguration. 
        /// <para>
        /// The user pool analytics configuration for collecting metrics and sending them to your
        /// Amazon Pinpoint campaign.
        /// </para>
        ///  <note> 
        /// <para>
        /// In Amazon Web Services Regions where Amazon Pinpoint isn't available, user pools only
        /// support sending events to Amazon Pinpoint projects in Amazon Web Services Region us-east-1.
        /// In Regions where Amazon Pinpoint is available, user pools support sending events to
        /// Amazon Pinpoint projects within that same Region.
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
        /// <c>AuthSessionValidity</c> is the duration, in minutes, of that session token. Your
        /// user pool native user must respond to each authentication challenge before the session
        /// expires.
        /// </para>
        /// </summary>
        [AWSProperty(Min=3, Max=15)]
        public int? AuthSessionValidity
        {
            get { return this._authSessionValidity; }
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
        /// App callback URLs such as myapp://example are also supported.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
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
            return this._callbackURLs != null && (this._callbackURLs.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property ClientId. 
        /// <para>
        /// The ID of the app client.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive=true, Min=1, Max=128)]
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
        /// The name of the app client.
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
        /// Gets and sets the property ClientSecret. 
        /// <para>
        /// The app client secret.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive=true, Min=1, Max=64)]
        public string ClientSecret
        {
            get { return this._clientSecret; }
            set { this._clientSecret = value; }
        }

        // Check to see if ClientSecret property is set
        internal bool IsSetClientSecret()
        {
            return this._clientSecret != null;
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
        /// Gets and sets the property DefaultRedirectURI. 
        /// <para>
        /// The default redirect URI. Must be in the <c>CallbackURLs</c> list.
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
        /// Gets and sets the property EnablePropagateAdditionalUserContextData. 
        /// <para>
        /// When <c>EnablePropagateAdditionalUserContextData</c> is true, Amazon Cognito accepts
        /// an <c>IpAddress</c> value that you send in the <c>UserContextData</c> parameter. The
        /// <c>UserContextData</c> parameter sends information to Amazon Cognito threat protection
        /// for risk analysis. You can send <c>UserContextData</c> when you sign in Amazon Cognito
        /// native users with the <c>InitiateAuth</c> and <c>RespondToAuthChallenge</c> API operations.
        /// </para>
        ///  
        /// <para>
        /// When <c>EnablePropagateAdditionalUserContextData</c> is false, you can't send your
        /// user's source IP address to Amazon Cognito threat protection with unauthenticated
        /// API operations. <c>EnablePropagateAdditionalUserContextData</c> doesn't affect whether
        /// you can send a source IP address in a <c>ContextData</c> parameter with the authenticated
        /// API operations <c>AdminInitiateAuth</c> and <c>AdminRespondToAuthChallenge</c>.
        /// </para>
        ///  
        /// <para>
        /// You can only activate <c>EnablePropagateAdditionalUserContextData</c> in an app client
        /// that has a client secret. For more information about propagation of user context data,
        /// see <a href="https://docs.aws.amazon.com/cognito/latest/developerguide/cognito-user-pool-settings-adaptive-authentication.html#user-pool-settings-adaptive-authentication-device-fingerprint">Adding
        /// user device and session data to API requests</a>.
        /// </para>
        /// </summary>
        public bool? EnablePropagateAdditionalUserContextData
        {
            get { return this._enablePropagateAdditionalUserContextData; }
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
        /// Indicates whether token revocation is activated for the user pool client. When you
        /// create a new user pool client, token revocation is activated by default.
        /// </para>
        /// </summary>
        public bool? EnableTokenRevocation
        {
            get { return this._enableTokenRevocation; }
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
        /// The <a href="https://docs.aws.amazon.com/cognito/latest/developerguide/amazon-cognito-user-pools-authentication-flow-methods.html">authentication
        /// flows</a> that you want your user pool client to support. For each app client in your
        /// user pool, you can sign in your users with any combination of one or more flows, including
        /// with a user name and Secure Remote Password (SRP), a user name and password, or a
        /// custom authentication process that you define with Lambda functions.
        /// </para>
        ///  <note> 
        /// <para>
        /// If you don't specify a value for <c>ExplicitAuthFlows</c>, your app client supports
        /// <c>ALLOW_REFRESH_TOKEN_AUTH</c>, <c>ALLOW_USER_SRP_AUTH</c>, and <c>ALLOW_CUSTOM_AUTH</c>.
        /// 
        /// </para>
        ///  </note> 
        /// <para>
        /// The values for authentication flow options include the following.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>ALLOW_USER_AUTH</c>: Enable selection-based sign-in with <c>USER_AUTH</c>. This
        /// setting covers username-password, secure remote password (SRP), passwordless, and
        /// passkey authentication. This authentiation flow can do username-password and SRP authentication
        /// without other <c>ExplicitAuthFlows</c> permitting them. For example users can complete
        /// an SRP challenge through <c>USER_AUTH</c> without the flow <c>USER_SRP_AUTH</c> being
        /// active for the app client. This flow doesn't include <c>CUSTOM_AUTH</c>. 
        /// </para>
        ///  
        /// <para>
        /// To activate this setting, your user pool must be in the <a href="https://docs.aws.amazon.com/cognito/latest/developerguide/feature-plans-features-essentials.html">
        /// Essentials tier</a> or higher.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>ALLOW_ADMIN_USER_PASSWORD_AUTH</c>: Enable admin based user password authentication
        /// flow <c>ADMIN_USER_PASSWORD_AUTH</c>. This setting replaces the <c>ADMIN_NO_SRP_AUTH</c>
        /// setting. With this authentication flow, your app passes a user name and password to
        /// Amazon Cognito in the request, instead of using the Secure Remote Password (SRP) protocol
        /// to securely transmit the password.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>ALLOW_CUSTOM_AUTH</c>: Enable Lambda trigger based authentication.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>ALLOW_USER_PASSWORD_AUTH</c>: Enable user password-based authentication. In this
        /// flow, Amazon Cognito receives the password in the request instead of using the SRP
        /// protocol to verify passwords.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>ALLOW_USER_SRP_AUTH</c>: Enable SRP-based authentication.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>ALLOW_REFRESH_TOKEN_AUTH</c>: Enable authflow to refresh tokens.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// In some environments, you will see the values <c>ADMIN_NO_SRP_AUTH</c>, <c>CUSTOM_AUTH_FLOW_ONLY</c>,
        /// or <c>USER_PASSWORD_AUTH</c>. You can't assign these legacy <c>ExplicitAuthFlows</c>
        /// values to user pool clients at the same time as values that begin with <c>ALLOW_</c>,
        /// like <c>ALLOW_USER_SRP_AUTH</c>.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> ExplicitAuthFlows
        {
            get { return this._explicitAuthFlows; }
            set { this._explicitAuthFlows = value; }
        }

        // Check to see if ExplicitAuthFlows property is set
        internal bool IsSetExplicitAuthFlows()
        {
            return this._explicitAuthFlows != null && (this._explicitAuthFlows.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property IdTokenValidity. 
        /// <para>
        /// The ID token time limit. After this limit expires, your user can't use their ID token.
        /// To specify the time unit for <c>IdTokenValidity</c> as <c>seconds</c>, <c>minutes</c>,
        /// <c>hours</c>, or <c>days</c>, set a <c>TokenValidityUnits</c> value in your API request.
        /// </para>
        ///  
        /// <para>
        /// For example, when you set <c>IdTokenValidity</c> as <c>10</c> and <c>TokenValidityUnits</c>
        /// as <c>hours</c>, your user can authenticate their session with their ID token for
        /// 10 hours.
        /// </para>
        ///  
        /// <para>
        /// The default time unit for <c>IdTokenValidity</c> in an API request is hours. <i>Valid
        /// range</i> is displayed below in seconds.
        /// </para>
        ///  
        /// <para>
        /// If you don't specify otherwise in the configuration of your app client, your ID tokens
        /// are valid for one hour.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=86400)]
        public int? IdTokenValidity
        {
            get { return this._idTokenValidity; }
            set { this._idTokenValidity = value; }
        }

        // Check to see if IdTokenValidity property is set
        internal bool IsSetIdTokenValidity()
        {
            return this._idTokenValidity.HasValue; 
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
        /// Gets and sets the property LogoutURLs. 
        /// <para>
        /// A list of allowed logout URLs for the IdPs.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
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
            return this._logoutURLs != null && (this._logoutURLs.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property PreventUserExistenceErrors. 
        /// <para>
        /// When <c>ENABLED</c>, suppresses messages that might indicate a valid user exists when
        /// someone attempts sign-in. This parameters sets your preference for the errors and
        /// responses that you want Amazon Cognito APIs to return during authentication, account
        /// confirmation, and password recovery when the user doesn't exist in the user pool.
        /// When set to <c>ENABLED</c> and the user doesn't exist, authentication returns an error
        /// indicating either the username or password was incorrect. Account confirmation and
        /// password recovery return a response indicating a code was sent to a simulated destination.
        /// When set to <c>LEGACY</c>, those APIs return a <c>UserNotFoundException</c> exception
        /// if the user doesn't exist in the user pool.
        /// </para>
        ///  
        /// <para>
        /// Defaults to <c>LEGACY</c>.
        /// </para>
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
        /// The list of user attributes that you want your app client to have read access to.
        /// After your user authenticates in your app, their access token authorizes them to read
        /// their own attribute value for any attribute in this list.
        /// </para>
        ///  
        /// <para>
        /// When you don't specify the <c>ReadAttributes</c> for your app client, your app can
        /// read the values of <c>email_verified</c>, <c>phone_number_verified</c>, and the standard
        /// attributes of your user pool. When your user pool app client has read access to these
        /// default attributes, <c>ReadAttributes</c> doesn't return any information. Amazon Cognito
        /// only populates <c>ReadAttributes</c> in the API response if you have specified your
        /// own custom set of read attributes.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> ReadAttributes
        {
            get { return this._readAttributes; }
            set { this._readAttributes = value; }
        }

        // Check to see if ReadAttributes property is set
        internal bool IsSetReadAttributes()
        {
            return this._readAttributes != null && (this._readAttributes.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property RefreshTokenRotation. 
        /// <para>
        /// The configuration of your app client for refresh token rotation. When enabled, your
        /// app client issues new ID, access, and refresh tokens when users renew their sessions
        /// with refresh tokens. When disabled, token refresh issues only ID and access tokens.
        /// </para>
        /// </summary>
        public RefreshTokenRotationType RefreshTokenRotation
        {
            get { return this._refreshTokenRotation; }
            set { this._refreshTokenRotation = value; }
        }

        // Check to see if RefreshTokenRotation property is set
        internal bool IsSetRefreshTokenRotation()
        {
            return this._refreshTokenRotation != null;
        }

        /// <summary>
        /// Gets and sets the property RefreshTokenValidity. 
        /// <para>
        /// The refresh token time limit. After this limit expires, your user can't use their
        /// refresh token. To specify the time unit for <c>RefreshTokenValidity</c> as <c>seconds</c>,
        /// <c>minutes</c>, <c>hours</c>, or <c>days</c>, set a <c>TokenValidityUnits</c> value
        /// in your API request.
        /// </para>
        ///  
        /// <para>
        /// For example, when you set <c>RefreshTokenValidity</c> as <c>10</c> and <c>TokenValidityUnits</c>
        /// as <c>days</c>, your user can refresh their session and retrieve new access and ID
        /// tokens for 10 days.
        /// </para>
        ///  
        /// <para>
        /// The default time unit for <c>RefreshTokenValidity</c> in an API request is days. You
        /// can't set <c>RefreshTokenValidity</c> to 0. If you do, Amazon Cognito overrides the
        /// value with the default value of 30 days. <i>Valid range</i> is displayed below in
        /// seconds.
        /// </para>
        ///  
        /// <para>
        /// If you don't specify otherwise in the configuration of your app client, your refresh
        /// tokens are valid for 30 days.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=315360000)]
        public int? RefreshTokenValidity
        {
            get { return this._refreshTokenValidity; }
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
        /// A list of provider names for the identity providers (IdPs) that are supported on this
        /// client. The following are supported: <c>COGNITO</c>, <c>Facebook</c>, <c>Google</c>,
        /// <c>SignInWithApple</c>, and <c>LoginWithAmazon</c>. You can also specify the names
        /// that you configured for the SAML and OIDC IdPs in your user pool, for example <c>MySAMLIdP</c>
        /// or <c>MyOIDCIdP</c>.
        /// </para>
        ///  
        /// <para>
        /// This parameter sets the IdPs that <a href="https://docs.aws.amazon.com/cognito/latest/developerguide/cognito-user-pools-managed-login.html">managed
        /// login</a> will display on the login page for your app client. The removal of <c>COGNITO</c>
        /// from this list doesn't prevent authentication operations for local users with the
        /// user pools API in an Amazon Web Services SDK. The only way to prevent SDK-based authentication
        /// is to block access with a <a href="https://docs.aws.amazon.com/cognito/latest/developerguide/user-pool-waf.html">WAF
        /// rule</a>. 
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> SupportedIdentityProviders
        {
            get { return this._supportedIdentityProviders; }
            set { this._supportedIdentityProviders = value; }
        }

        // Check to see if SupportedIdentityProviders property is set
        internal bool IsSetSupportedIdentityProviders()
        {
            return this._supportedIdentityProviders != null && (this._supportedIdentityProviders.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property TokenValidityUnits. 
        /// <para>
        /// The time units that, with <c>IdTokenValidity</c>, <c>AccessTokenValidity</c>, and
        /// <c>RefreshTokenValidity</c>, set and display the duration of ID, access, and refresh
        /// tokens for an app client. You can assign a separate token validity unit to each type
        /// of token. 
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
        /// The ID of the user pool associated with the app client.
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

        /// <summary>
        /// Gets and sets the property WriteAttributes. 
        /// <para>
        /// The list of user attributes that you want your app client to have write access to.
        /// After your user authenticates in your app, their access token authorizes them to set
        /// or modify their own attribute value for any attribute in this list.
        /// </para>
        ///  
        /// <para>
        /// When you don't specify the <c>WriteAttributes</c> for your app client, your app can
        /// write the values of the Standard attributes of your user pool. When your user pool
        /// has write access to these default attributes, <c>WriteAttributes</c> doesn't return
        /// any information. Amazon Cognito only populates <c>WriteAttributes</c> in the API response
        /// if you have specified your own custom set of write attributes.
        /// </para>
        ///  
        /// <para>
        /// If your app client allows users to sign in through an IdP, this array must include
        /// all attributes that you have mapped to IdP attributes. Amazon Cognito updates mapped
        /// attributes when users sign in to your application through an IdP. If your app client
        /// does not have write access to a mapped attribute, Amazon Cognito throws an error when
        /// it tries to update the attribute. For more information, see <a href="https://docs.aws.amazon.com/cognito/latest/developerguide/cognito-user-pools-specifying-attribute-mapping.html">Specifying
        /// IdP Attribute Mappings for Your user pool</a>.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> WriteAttributes
        {
            get { return this._writeAttributes; }
            set { this._writeAttributes = value; }
        }

        // Check to see if WriteAttributes property is set
        internal bool IsSetWriteAttributes()
        {
            return this._writeAttributes != null && (this._writeAttributes.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}