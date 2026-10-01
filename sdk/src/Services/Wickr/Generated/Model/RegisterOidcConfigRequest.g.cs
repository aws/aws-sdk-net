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
    /// Container for the parameters to the RegisterOidcConfig operation. Registers and saves
    /// an OpenID Connect (OIDC) configuration for a Wickr network, enabling Single Sign-On
    /// (SSO) authentication through an identity provider.
    /// </summary>
    public partial class RegisterOidcConfigRequest : AmazonWickrRequest
    {
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
        /// A custom field mapping to extract the username from the OIDC token (optional). 
        /// </para>
        ///  <note> 
        /// <para>
        /// The customUsername is only required if you use something other than email as the username
        /// field.
        /// </para>
        ///  </note>
        /// </summary>
        public string CustomUsername { get; set; }

        /// <summary>
        /// Checks to see if the CustomUsername property is set.
        /// </summary>
        internal bool IsSetCustomUsername() => this.CustomUsername != null;

        /// <summary>
        /// Gets and sets the property ExtraAuthParams. 
        /// <para>
        /// Additional authentication parameters to include in the OIDC flow (optional).
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
        /// The issuer URL of the OIDC provider (e.g., 'https://login.example.com').
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string Issuer { get; set; }

        /// <summary>
        /// Checks to see if the Issuer property is set.
        /// </summary>
        internal bool IsSetIssuer() => this.Issuer != null;

        /// <summary>
        /// Gets and sets the property NetworkId. 
        /// <para>
        /// The ID of the Wickr network for which OIDC will be configured.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 8, Max = 8)]
        public string NetworkId { get; set; }

        /// <summary>
        /// Checks to see if the NetworkId property is set.
        /// </summary>
        internal bool IsSetNetworkId() => this.NetworkId != null;

        /// <summary>
        /// Gets and sets the property Scopes. 
        /// <para>
        /// The OAuth scopes to request from the OIDC provider (e.g., 'openid profile email').
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
        /// The client secret for authenticating with the OIDC provider (optional).
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
        /// The buffer time in minutes before the SSO token expires to refresh it (optional).
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
        /// Unique identifier provided by your identity provider to authenticate the access request.
        /// Also referred to as clientID.
        /// </para>
        /// </summary>
        public string UserId { get; set; }

        /// <summary>
        /// Checks to see if the UserId property is set.
        /// </summary>
        internal bool IsSetUserId() => this.UserId != null;
    }
}
