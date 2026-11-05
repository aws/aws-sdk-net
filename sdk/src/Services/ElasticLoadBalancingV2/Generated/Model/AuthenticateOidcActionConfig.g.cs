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

namespace Amazon.ElasticLoadBalancingV2.Model
{
    /// <summary>
    /// Request parameters when using an identity provider (IdP) that is compliant with OpenID
    /// Connect (OIDC) to authenticate users.
    /// </summary>
    public partial class AuthenticateOidcActionConfig
    {
        /// <summary>
        /// Gets and sets the property AuthenticationRequestExtraParams. 
        /// <para>
        /// The query parameters (up to 10) to include in the redirect request to the authorization
        /// endpoint.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public Dictionary<string, string> AuthenticationRequestExtraParams { get; set; } = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;

        /// <summary>
        /// Checks to see if the AuthenticationRequestExtraParams property is set.
        /// </summary>
        internal bool IsSetAuthenticationRequestExtraParams() => this.AuthenticationRequestExtraParams != null && (this.AuthenticationRequestExtraParams.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property AuthorizationEndpoint. 
        /// <para>
        /// The authorization endpoint of the IdP. This must be a full URL, including the HTTPS
        /// protocol, the domain, and the path.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string AuthorizationEndpoint { get; set; }

        /// <summary>
        /// Checks to see if the AuthorizationEndpoint property is set.
        /// </summary>
        internal bool IsSetAuthorizationEndpoint() => this.AuthorizationEndpoint != null;

        /// <summary>
        /// Gets and sets the property ClientId. 
        /// <para>
        /// The OAuth 2.0 client identifier.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string ClientId { get; set; }

        /// <summary>
        /// Checks to see if the ClientId property is set.
        /// </summary>
        internal bool IsSetClientId() => this.ClientId != null;

        /// <summary>
        /// Gets and sets the property ClientSecret. 
        /// <para>
        /// The OAuth 2.0 client secret. This parameter is required if you are creating a rule.
        /// If you are modifying a rule, you can omit this parameter if you set <c>UseExistingClientSecret</c>
        /// to true.
        /// </para>
        /// </summary>
        public string ClientSecret { get; set; }

        /// <summary>
        /// Checks to see if the ClientSecret property is set.
        /// </summary>
        internal bool IsSetClientSecret() => this.ClientSecret != null;

        /// <summary>
        /// Gets and sets the property Issuer. 
        /// <para>
        /// The OIDC issuer identifier of the IdP. This must be a full URL, including the HTTPS
        /// protocol, the domain, and the path.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string Issuer { get; set; }

        /// <summary>
        /// Checks to see if the Issuer property is set.
        /// </summary>
        internal bool IsSetIssuer() => this.Issuer != null;

        /// <summary>
        /// Gets and sets the property OnUnauthenticatedRequest. 
        /// <para>
        /// The behavior if the user is not authenticated. The following are possible values:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// deny<c></c> - Return an HTTP 401 Unauthorized error.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// allow<c></c> - Allow the request to be forwarded to the target.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// authenticate<c></c> - Redirect the request to the IdP authorization endpoint. This
        /// is the default value.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public AuthenticateOidcActionConditionalBehaviorEnum OnUnauthenticatedRequest { get; set; }

        /// <summary>
        /// Checks to see if the OnUnauthenticatedRequest property is set.
        /// </summary>
        internal bool IsSetOnUnauthenticatedRequest() => this.OnUnauthenticatedRequest != null;

        /// <summary>
        /// Gets and sets the property Scope. 
        /// <para>
        /// The set of user claims to be requested from the IdP. The default is <c>openid</c>.
        /// </para>
        ///  
        /// <para>
        /// To verify which scope values your IdP supports and how to separate multiple values,
        /// see the documentation for your IdP.
        /// </para>
        /// </summary>
        public string Scope { get; set; }

        /// <summary>
        /// Checks to see if the Scope property is set.
        /// </summary>
        internal bool IsSetScope() => this.Scope != null;

        /// <summary>
        /// Gets and sets the property SessionCookieName. 
        /// <para>
        /// The name of the cookie used to maintain session information. The default is AWSELBAuthSessionCookie.
        /// </para>
        /// </summary>
        public string SessionCookieName { get; set; }

        /// <summary>
        /// Checks to see if the SessionCookieName property is set.
        /// </summary>
        internal bool IsSetSessionCookieName() => this.SessionCookieName != null;

        /// <summary>
        /// Gets and sets the property SessionTimeout. 
        /// <para>
        /// The maximum duration of the authentication session, in seconds. The default is 604800
        /// seconds (7 days).
        /// </para>
        /// </summary>
        public long? SessionTimeout { get; set; }

        /// <summary>
        /// Checks to see if the SessionTimeout property is set.
        /// </summary>
        internal bool IsSetSessionTimeout() => this.SessionTimeout.HasValue;

        /// <summary>
        /// Gets and sets the property TokenEndpoint. 
        /// <para>
        /// The token endpoint of the IdP. This must be a full URL, including the HTTPS protocol,
        /// the domain, and the path.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string TokenEndpoint { get; set; }

        /// <summary>
        /// Checks to see if the TokenEndpoint property is set.
        /// </summary>
        internal bool IsSetTokenEndpoint() => this.TokenEndpoint != null;

        /// <summary>
        /// Gets and sets the property UseExistingClientSecret. 
        /// <para>
        /// Indicates whether to use the existing client secret when modifying a rule. If you
        /// are creating a rule, you can omit this parameter or set it to false.
        /// </para>
        /// </summary>
        public bool? UseExistingClientSecret { get; set; }

        /// <summary>
        /// Checks to see if the UseExistingClientSecret property is set.
        /// </summary>
        internal bool IsSetUseExistingClientSecret() => this.UseExistingClientSecret.HasValue;

        /// <summary>
        /// Gets and sets the property UserInfoEndpoint. 
        /// <para>
        /// The user info endpoint of the IdP. This must be a full URL, including the HTTPS protocol,
        /// the domain, and the path.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string UserInfoEndpoint { get; set; }

        /// <summary>
        /// Checks to see if the UserInfoEndpoint property is set.
        /// </summary>
        internal bool IsSetUserInfoEndpoint() => this.UserInfoEndpoint != null;
    }
}
