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
    /// The configuration of a user pool client.
    /// </summary>
    public partial class UserPoolClientType
    {
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
        [AWSProperty(Min = 1, Max = 86400)]
        public int? AccessTokenValidity { get; set; }

        /// <summary>
        /// Checks to see if the AccessTokenValidity property is set.
        /// </summary>
        internal bool IsSetAccessTokenValidity() => this.AccessTokenValidity.HasValue;

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
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 0, Max = 3)]
        public List<string> AllowedOAuthFlows { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the AllowedOAuthFlows property is set.
        /// </summary>
        internal bool IsSetAllowedOAuthFlows() => this.AllowedOAuthFlows != null && (this.AllowedOAuthFlows.Count > 0 || !AWSConfigs.InitializeCollections);

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
        public bool? AllowedOAuthFlowsUserPoolClient { get; set; }

        /// <summary>
        /// Checks to see if the AllowedOAuthFlowsUserPoolClient property is set.
        /// </summary>
        internal bool IsSetAllowedOAuthFlowsUserPoolClient() => this.AllowedOAuthFlowsUserPoolClient.HasValue;

        /// <summary>
        /// Gets and sets the property AllowedOAuthScopes. 
        /// <para>
        /// The OAuth 2.0 scopes that you want your app client to support. Can include standard
        /// OAuth scopes like <c>phone</c>, <c>email</c>, <c>openid</c>, and <c>profile</c>. Can
        /// also include the <c>aws.cognito.signin.user.admin</c> scope that authorizes user profile
        /// self-service operations and custom scopes from resource servers.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 0, Max = 50)]
        public List<string> AllowedOAuthScopes { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the AllowedOAuthScopes property is set.
        /// </summary>
        internal bool IsSetAllowedOAuthScopes() => this.AllowedOAuthScopes != null && (this.AllowedOAuthScopes.Count > 0 || !AWSConfigs.InitializeCollections);

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
        public AnalyticsConfigurationType AnalyticsConfiguration { get; set; }

        /// <summary>
        /// Checks to see if the AnalyticsConfiguration property is set.
        /// </summary>
        internal bool IsSetAnalyticsConfiguration() => this.AnalyticsConfiguration != null;

        /// <summary>
        /// Gets and sets the property AuthSessionValidity. 
        /// <para>
        /// Amazon Cognito creates a session token for each API request in an authentication flow.
        /// <c>AuthSessionValidity</c> is the duration, in minutes, of that session token. Your
        /// user pool native user must respond to each authentication challenge before the session
        /// expires.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 3, Max = 15)]
        public int? AuthSessionValidity { get; set; }

        /// <summary>
        /// Checks to see if the AuthSessionValidity property is set.
        /// </summary>
        internal bool IsSetAuthSessionValidity() => this.AuthSessionValidity.HasValue;

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
        /// Amazon Cognito requires HTTPS over HTTP for callback URLs to <c>http://localhost</c>,
        /// <c>http://127.0.0.1</c> and <c>http://[::1]</c>. These callback URLs are for testing
        /// purposes only. You can specify custom TCP ports for your callback URLs.
        /// </para>
        ///  
        /// <para>
        /// App callback URLs such as myapp://example are also supported.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 0, Max = 100)]
        public List<string> CallbackURLs { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the CallbackURLs property is set.
        /// </summary>
        internal bool IsSetCallbackURLs() => this.CallbackURLs != null && (this.CallbackURLs.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property ClientId. 
        /// <para>
        /// The ID of the app client.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive = true, Min = 1, Max = 128)]
        public string ClientId { get; set; }

        /// <summary>
        /// Checks to see if the ClientId property is set.
        /// </summary>
        internal bool IsSetClientId() => this.ClientId != null;

        /// <summary>
        /// Gets and sets the property ClientName. 
        /// <para>
        /// The name of the app client.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 128)]
        public string ClientName { get; set; }

        /// <summary>
        /// Checks to see if the ClientName property is set.
        /// </summary>
        internal bool IsSetClientName() => this.ClientName != null;

        /// <summary>
        /// Gets and sets the property ClientSecret. 
        /// <para>
        /// The app client secret.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive = true, Min = 24, Max = 64)]
        public string ClientSecret { get; set; }

        /// <summary>
        /// Checks to see if the ClientSecret property is set.
        /// </summary>
        internal bool IsSetClientSecret() => this.ClientSecret != null;

        /// <summary>
        /// Gets and sets the property CreationDate. 
        /// <para>
        /// The date and time when the item was created. Amazon Cognito returns this timestamp
        /// in UNIX epoch time format. Your SDK might render the output in a human-readable format
        /// like ISO 8601 or a Java <c>Date</c> object.
        /// </para>
        /// </summary>
        public DateTime? CreationDate { get; set; }

        /// <summary>
        /// Checks to see if the CreationDate property is set.
        /// </summary>
        internal bool IsSetCreationDate() => this.CreationDate.HasValue;

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
        /// Amazon Cognito requires HTTPS over HTTP for callback URLs to <c>http://localhost</c>,
        /// <c>http://127.0.0.1</c> and <c>http://[::1]</c>. These callback URLs are for testing
        /// purposes only. You can specify custom TCP ports for your callback URLs.
        /// </para>
        ///  
        /// <para>
        /// App callback URLs such as myapp://example are also supported.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 1024)]
        public string DefaultRedirectURI { get; set; }

        /// <summary>
        /// Checks to see if the DefaultRedirectURI property is set.
        /// </summary>
        internal bool IsSetDefaultRedirectURI() => this.DefaultRedirectURI != null;

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
        public bool? EnablePropagateAdditionalUserContextData { get; set; }

        /// <summary>
        /// Checks to see if the EnablePropagateAdditionalUserContextData property is set.
        /// </summary>
        internal bool IsSetEnablePropagateAdditionalUserContextData() => this.EnablePropagateAdditionalUserContextData.HasValue;

        /// <summary>
        /// Gets and sets the property EnableTokenRevocation. 
        /// <para>
        /// Indicates whether token revocation is activated for the user pool client. When you
        /// create a new user pool client, token revocation is activated by default.
        /// </para>
        /// </summary>
        public bool? EnableTokenRevocation { get; set; }

        /// <summary>
        /// Checks to see if the EnableTokenRevocation property is set.
        /// </summary>
        internal bool IsSetEnableTokenRevocation() => this.EnableTokenRevocation.HasValue;

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
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> ExplicitAuthFlows { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the ExplicitAuthFlows property is set.
        /// </summary>
        internal bool IsSetExplicitAuthFlows() => this.ExplicitAuthFlows != null && (this.ExplicitAuthFlows.Count > 0 || !AWSConfigs.InitializeCollections);

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
        [AWSProperty(Min = 1, Max = 86400)]
        public int? IdTokenValidity { get; set; }

        /// <summary>
        /// Checks to see if the IdTokenValidity property is set.
        /// </summary>
        internal bool IsSetIdTokenValidity() => this.IdTokenValidity.HasValue;

        /// <summary>
        /// Gets and sets the property LastModifiedDate. 
        /// <para>
        /// The date and time when the item was modified. Amazon Cognito returns this timestamp
        /// in UNIX epoch time format. Your SDK might render the output in a human-readable format
        /// like ISO 8601 or a Java <c>Date</c> object.
        /// </para>
        /// </summary>
        public DateTime? LastModifiedDate { get; set; }

        /// <summary>
        /// Checks to see if the LastModifiedDate property is set.
        /// </summary>
        internal bool IsSetLastModifiedDate() => this.LastModifiedDate.HasValue;

        /// <summary>
        /// Gets and sets the property LogoutURLs. 
        /// <para>
        /// A list of allowed logout URLs for the IdPs.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 0, Max = 100)]
        public List<string> LogoutURLs { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the LogoutURLs property is set.
        /// </summary>
        internal bool IsSetLogoutURLs() => this.LogoutURLs != null && (this.LogoutURLs.Count > 0 || !AWSConfigs.InitializeCollections);

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
        public PreventUserExistenceErrorTypes PreventUserExistenceErrors { get; set; }

        /// <summary>
        /// Checks to see if the PreventUserExistenceErrors property is set.
        /// </summary>
        internal bool IsSetPreventUserExistenceErrors() => this.PreventUserExistenceErrors != null;

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
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> ReadAttributes { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the ReadAttributes property is set.
        /// </summary>
        internal bool IsSetReadAttributes() => this.ReadAttributes != null && (this.ReadAttributes.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property RefreshTokenRotation. 
        /// <para>
        /// The configuration of your app client for refresh token rotation. When enabled, your
        /// app client issues new ID, access, and refresh tokens when users renew their sessions
        /// with refresh tokens. When disabled, token refresh issues only ID and access tokens.
        /// </para>
        /// </summary>
        public RefreshTokenRotationType RefreshTokenRotation { get; set; }

        /// <summary>
        /// Checks to see if the RefreshTokenRotation property is set.
        /// </summary>
        internal bool IsSetRefreshTokenRotation() => this.RefreshTokenRotation != null;

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
        [AWSProperty(Min = 0, Max = 315360000)]
        public int? RefreshTokenValidity { get; set; }

        /// <summary>
        /// Checks to see if the RefreshTokenValidity property is set.
        /// </summary>
        internal bool IsSetRefreshTokenValidity() => this.RefreshTokenValidity.HasValue;

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
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> SupportedIdentityProviders { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the SupportedIdentityProviders property is set.
        /// </summary>
        internal bool IsSetSupportedIdentityProviders() => this.SupportedIdentityProviders != null && (this.SupportedIdentityProviders.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property TokenValidityUnits. 
        /// <para>
        /// The time units that, with <c>IdTokenValidity</c>, <c>AccessTokenValidity</c>, and
        /// <c>RefreshTokenValidity</c>, set and display the duration of ID, access, and refresh
        /// tokens for an app client. You can assign a separate token validity unit to each type
        /// of token. 
        /// </para>
        /// </summary>
        public TokenValidityUnitsType TokenValidityUnits { get; set; }

        /// <summary>
        /// Checks to see if the TokenValidityUnits property is set.
        /// </summary>
        internal bool IsSetTokenValidityUnits() => this.TokenValidityUnits != null;

        /// <summary>
        /// Gets and sets the property UserPoolId. 
        /// <para>
        /// The ID of the user pool associated with the app client.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 55)]
        public string UserPoolId { get; set; }

        /// <summary>
        /// Checks to see if the UserPoolId property is set.
        /// </summary>
        internal bool IsSetUserPoolId() => this.UserPoolId != null;

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
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> WriteAttributes { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the WriteAttributes property is set.
        /// </summary>
        internal bool IsSetWriteAttributes() => this.WriteAttributes != null && (this.WriteAttributes.Count > 0 || !AWSConfigs.InitializeCollections);
    }
}
