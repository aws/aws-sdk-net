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
    /// Container for the parameters to the CreateUserPoolClient operation.
    /// Creates the user pool client.
    /// </summary>
    public partial class CreateUserPoolClientRequest : AmazonCognitoIdentityProviderRequest
    {
        private List<string> _allowedOAuthFlows = new List<string>();
        private bool? _allowedOAuthFlowsUserPoolClient;
        private List<string> _allowedOAuthScopes = new List<string>();
        private AnalyticsConfigurationType _analyticsConfiguration;
        private List<string> _callbackURLs = new List<string>();
        private string _clientName;
        private string _defaultRedirectURI;
        private List<string> _explicitAuthFlows = new List<string>();
        private bool? _generateSecret;
        private List<string> _logoutURLs = new List<string>();
        private List<string> _readAttributes = new List<string>();
        private int? _refreshTokenValidity;
        private List<string> _supportedIdentityProviders = new List<string>();
        private string _userPoolId;
        private List<string> _writeAttributes = new List<string>();

        /// <summary>
        /// Gets and sets the property AllowedOAuthFlows. 
        /// <para>
        /// Set to <code>code</code> to initiate a code grant flow, which provides an authorization
        /// code as the response. This code can be exchanged for access tokens with the token
        /// endpoint.
        /// </para>
        ///  
        /// <para>
        /// Set to <code>token</code> to specify that the client should get the access token (and,
        /// optionally, ID token, based on scopes) directly.
        /// </para>
        /// </summary>
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
        /// Set to <code>True</code> if the client is allowed to follow the OAuth protocol when
        /// interacting with Cognito user pools.
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
        /// A list of allowed <code>OAuth</code> scopes. Currently supported values are <code>"phone"</code>,
        /// <code>"email"</code>, <code>"openid"</code>, and <code>"Cognito"</code>.
        /// </para>
        /// </summary>
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
        /// Not use HTTP without TLS (i.e. use HTTPS instead of HTTP).
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
        /// </summary>
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
        /// Gets and sets the property ClientName. 
        /// <para>
        /// The client name for the user pool client you would like to create.
        /// </para>
        /// </summary>
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
        /// Not use HTTP without TLS (i.e. use HTTPS instead of HTTP).
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
        /// </summary>
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
        /// The explicit authentication flows.
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
        /// Gets and sets the property GenerateSecret. 
        /// <para>
        /// Boolean to specify whether you want to generate a secret for the user pool client
        /// being created.
        /// </para>
        /// </summary>
        public bool GenerateSecret
        {
            get { return this._generateSecret.GetValueOrDefault(); }
            set { this._generateSecret = value; }
        }

        // Check to see if GenerateSecret property is set
        internal bool IsSetGenerateSecret()
        {
            return this._generateSecret.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property LogoutURLs. 
        /// <para>
        /// A list of allowed logout URLs for the identity providers.
        /// </para>
        /// </summary>
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
        /// Gets and sets the property ReadAttributes. 
        /// <para>
        /// The read attributes.
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
        /// Gets and sets the property UserPoolId. 
        /// <para>
        /// The user pool ID for the user pool where you want to create a user pool client.
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

        /// <summary>
        /// Gets and sets the property WriteAttributes. 
        /// <para>
        /// The write attributes.
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