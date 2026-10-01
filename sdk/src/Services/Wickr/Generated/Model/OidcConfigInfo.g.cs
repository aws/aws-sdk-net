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

namespace Amazon.Wickr.Model
{
    /// <summary>
    /// Contains the OpenID Connect (OIDC) configuration information for Single Sign-On (SSO)
    /// authentication, including identity provider settings and client credentials.
    /// </summary>
    public partial class OidcConfigInfo
    {
        /// <summary>
        /// Gets and sets the property ApplicationId. 
        /// <para>
        /// The unique identifier for the registered OIDC application. Valid range is 1-10.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 10)]
        public int? ApplicationId { get; set; }

        /// <summary>
        /// Checks to see if the ApplicationId property is set.
        /// </summary>
        internal bool IsSetApplicationId() => this.ApplicationId.HasValue;

        /// <summary>
        /// Gets and sets the property ApplicationName. 
        /// <para>
        /// The name of the OIDC application as registered with the identity provider.
        /// </para>
        /// </summary>
        public string ApplicationName { get; set; }

        /// <summary>
        /// Checks to see if the ApplicationName property is set.
        /// </summary>
        internal bool IsSetApplicationName() => this.ApplicationName != null;

        /// <summary>
        /// Gets and sets the property CaCertificate. 
        /// <para>
        /// The X.509 CA certificate for validating SSL/TLS connections to the identity provider
        /// when using self-signed or enterprise certificates.
        /// </para>
        /// </summary>
        public string CaCertificate { get; set; }

        /// <summary>
        /// Checks to see if the CaCertificate property is set.
        /// </summary>
        internal bool IsSetCaCertificate() => this.CaCertificate != null;

        /// <summary>
        /// Gets and sets the property ClientId. 
        /// <para>
        /// The OAuth client ID assigned by the identity provider for authentication requests.
        /// </para>
        /// </summary>
        public string ClientId { get; set; }

        /// <summary>
        /// Checks to see if the ClientId property is set.
        /// </summary>
        internal bool IsSetClientId() => this.ClientId != null;

        /// <summary>
        /// Gets and sets the property ClientSecret. 
        /// <para>
        /// The OAuth client secret used to authenticate the application with the identity provider.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive = true)]
        public string ClientSecret { get; set; }

        /// <summary>
        /// Checks to see if the ClientSecret property is set.
        /// </summary>
        internal bool IsSetClientSecret() => this.ClientSecret != null;

        /// <summary>
        /// Gets and sets the property CompanyId. 
        /// <para>
        /// Custom identifier your end users will use to sign in with SSO.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string CompanyId { get; set; }

        /// <summary>
        /// Checks to see if the CompanyId property is set.
        /// </summary>
        internal bool IsSetCompanyId() => this.CompanyId != null;

        /// <summary>
        /// Gets and sets the property CustomUsername. 
        /// <para>
        /// A custom field mapping to extract the username from the OIDC token when the standard
        /// username claim is insufficient.
        /// </para>
        /// </summary>
        public string CustomUsername { get; set; }

        /// <summary>
        /// Checks to see if the CustomUsername property is set.
        /// </summary>
        internal bool IsSetCustomUsername() => this.CustomUsername != null;

        /// <summary>
        /// Gets and sets the property ExtraAuthParams. 
        /// <para>
        /// Additional authentication parameters to include in the OIDC authorization request
        /// as a query string. Useful for provider-specific extensions.
        /// </para>
        /// </summary>
        public string ExtraAuthParams { get; set; }

        /// <summary>
        /// Checks to see if the ExtraAuthParams property is set.
        /// </summary>
        internal bool IsSetExtraAuthParams() => this.ExtraAuthParams != null;

        /// <summary>
        /// Gets and sets the property Issuer. 
        /// <para>
        /// The issuer URL of the identity provider, which serves as the base URL for OIDC endpoints
        /// and configuration discovery.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string Issuer { get; set; }

        /// <summary>
        /// Checks to see if the Issuer property is set.
        /// </summary>
        internal bool IsSetIssuer() => this.Issuer != null;

        /// <summary>
        /// Gets and sets the property RedirectUrl. 
        /// <para>
        /// The callback URL where the identity provider redirects users after successful authentication.
        /// This URL must be registered with the identity provider.
        /// </para>
        /// </summary>
        public string RedirectUrl { get; set; }

        /// <summary>
        /// Checks to see if the RedirectUrl property is set.
        /// </summary>
        internal bool IsSetRedirectUrl() => this.RedirectUrl != null;

        /// <summary>
        /// Gets and sets the property Scopes. 
        /// <para>
        /// The OAuth scopes requested from the identity provider, which determine what user information
        /// is accessible (e.g., 'openid profile email').
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string Scopes { get; set; }

        /// <summary>
        /// Checks to see if the Scopes property is set.
        /// </summary>
        internal bool IsSetScopes() => this.Scopes != null;

        /// <summary>
        /// Gets and sets the property Secret. 
        /// <para>
        /// An additional secret credential used by the identity provider for authentication.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive = true)]
        public string Secret { get; set; }

        /// <summary>
        /// Checks to see if the Secret property is set.
        /// </summary>
        internal bool IsSetSecret() => this.Secret != null;

        /// <summary>
        /// Gets and sets the property SsoTokenBufferMinutes. 
        /// <para>
        /// The grace period in minutes before the SSO token expires when the system should proactively
        /// refresh the token to maintain seamless user access.
        /// </para>
        /// </summary>
        public int? SsoTokenBufferMinutes { get; set; }

        /// <summary>
        /// Checks to see if the SsoTokenBufferMinutes property is set.
        /// </summary>
        internal bool IsSetSsoTokenBufferMinutes() => this.SsoTokenBufferMinutes.HasValue;

        /// <summary>
        /// Gets and sets the property UserId. 
        /// <para>
        /// The claim field from the OIDC token to use as the unique user identifier (e.g., 'email',
        /// 'sub', or a custom claim).
        /// </para>
        /// </summary>
        public string UserId { get; set; }

        /// <summary>
        /// Checks to see if the UserId property is set.
        /// </summary>
        internal bool IsSetUserId() => this.UserId != null;
    }
}
