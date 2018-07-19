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
 * Do not modify this file. This file is generated from the elasticloadbalancingv2-2015-12-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.ElasticLoadBalancingV2.Model
{
    /// <summary>
    /// Request parameters when using an identity provider (IdP) that is compliant with OpenID
    /// Connect (OIDC) to authenticate users.
    /// </summary>
    public partial class AuthenticateOidcActionConfig
    {
        private Dictionary<string, string> _authenticationRequestExtraParams = new Dictionary<string, string>();
        private string _authorizationEndpoint;
        private string _clientId;
        private string _clientSecret;
        private string _issuer;
        private AuthenticateOidcActionConditionalBehaviorEnum _onUnauthenticatedRequest;
        private string _scope;
        private string _sessionCookieName;
        private long? _sessionTimeout;
        private string _tokenEndpoint;
        private string _userInfoEndpoint;

        /// <summary>
        /// Gets and sets the property AuthenticationRequestExtraParams. 
        /// <para>
        /// The query parameters (up to 10) to include in the redirect request to the authorization
        /// endpoint.
        /// </para>
        /// </summary>
        public Dictionary<string, string> AuthenticationRequestExtraParams
        {
            get { return this._authenticationRequestExtraParams; }
            set { this._authenticationRequestExtraParams = value; }
        }

        // Check to see if AuthenticationRequestExtraParams property is set
        internal bool IsSetAuthenticationRequestExtraParams()
        {
            return this._authenticationRequestExtraParams != null && this._authenticationRequestExtraParams.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property AuthorizationEndpoint. 
        /// <para>
        /// The authorization endpoint of the IdP. This must be a full URL, including the HTTPS
        /// protocol, the domain, and the path.
        /// </para>
        /// </summary>
        public string AuthorizationEndpoint
        {
            get { return this._authorizationEndpoint; }
            set { this._authorizationEndpoint = value; }
        }

        // Check to see if AuthorizationEndpoint property is set
        internal bool IsSetAuthorizationEndpoint()
        {
            return this._authorizationEndpoint != null;
        }

        /// <summary>
        /// Gets and sets the property ClientId. 
        /// <para>
        /// The OAuth 2.0 client identifier.
        /// </para>
        /// </summary>
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
        /// Gets and sets the property ClientSecret. 
        /// <para>
        /// The OAuth 2.0 client secret.
        /// </para>
        /// </summary>
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
        /// Gets and sets the property Issuer. 
        /// <para>
        /// The OIDC issuer identifier of the IdP. This must be a full URL, including the HTTPS
        /// protocol, the domain, and the path.
        /// </para>
        /// </summary>
        public string Issuer
        {
            get { return this._issuer; }
            set { this._issuer = value; }
        }

        // Check to see if Issuer property is set
        internal bool IsSetIssuer()
        {
            return this._issuer != null;
        }

        /// <summary>
        /// Gets and sets the property OnUnauthenticatedRequest. 
        /// <para>
        /// The behavior if the user is not authenticated. The following are possible values:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// deny<code/> - Return an HTTP 401 Unauthorized error.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// allow<code/> - Allow the request to be forwarded to the target.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// authenticate<code/> - Redirect the request to the IdP authorization endpoint. This
        /// is the default value.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public AuthenticateOidcActionConditionalBehaviorEnum OnUnauthenticatedRequest
        {
            get { return this._onUnauthenticatedRequest; }
            set { this._onUnauthenticatedRequest = value; }
        }

        // Check to see if OnUnauthenticatedRequest property is set
        internal bool IsSetOnUnauthenticatedRequest()
        {
            return this._onUnauthenticatedRequest != null;
        }

        /// <summary>
        /// Gets and sets the property Scope. 
        /// <para>
        /// The set of user claims to be requested from the IdP. The default is <code>openid</code>.
        /// </para>
        ///  
        /// <para>
        /// To verify which scope values your IdP supports and how to separate multiple values,
        /// see the documentation for your IdP.
        /// </para>
        /// </summary>
        public string Scope
        {
            get { return this._scope; }
            set { this._scope = value; }
        }

        // Check to see if Scope property is set
        internal bool IsSetScope()
        {
            return this._scope != null;
        }

        /// <summary>
        /// Gets and sets the property SessionCookieName. 
        /// <para>
        /// The name of the cookie used to maintain session information. The default is AWSELBAuthSessionCookie.
        /// </para>
        /// </summary>
        public string SessionCookieName
        {
            get { return this._sessionCookieName; }
            set { this._sessionCookieName = value; }
        }

        // Check to see if SessionCookieName property is set
        internal bool IsSetSessionCookieName()
        {
            return this._sessionCookieName != null;
        }

        /// <summary>
        /// Gets and sets the property SessionTimeout. 
        /// <para>
        /// The maximum duration of the authentication session, in seconds. The default is 604800
        /// seconds (7 days).
        /// </para>
        /// </summary>
        public long SessionTimeout
        {
            get { return this._sessionTimeout.GetValueOrDefault(); }
            set { this._sessionTimeout = value; }
        }

        // Check to see if SessionTimeout property is set
        internal bool IsSetSessionTimeout()
        {
            return this._sessionTimeout.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property TokenEndpoint. 
        /// <para>
        /// The token endpoint of the IdP. This must be a full URL, including the HTTPS protocol,
        /// the domain, and the path.
        /// </para>
        /// </summary>
        public string TokenEndpoint
        {
            get { return this._tokenEndpoint; }
            set { this._tokenEndpoint = value; }
        }

        // Check to see if TokenEndpoint property is set
        internal bool IsSetTokenEndpoint()
        {
            return this._tokenEndpoint != null;
        }

        /// <summary>
        /// Gets and sets the property UserInfoEndpoint. 
        /// <para>
        /// The user info endpoint of the IdP. This must be a full URL, including the HTTPS protocol,
        /// the domain, and the path.
        /// </para>
        /// </summary>
        public string UserInfoEndpoint
        {
            get { return this._userInfoEndpoint; }
            set { this._userInfoEndpoint = value; }
        }

        // Check to see if UserInfoEndpoint property is set
        internal bool IsSetUserInfoEndpoint()
        {
            return this._userInfoEndpoint != null;
        }

    }
}