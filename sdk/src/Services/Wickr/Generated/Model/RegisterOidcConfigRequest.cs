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
 * Do not modify this file. This file is generated from the wickr-2024-02-01.normal.json service model.
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
    /// Container for the parameters to the RegisterOidcConfig operation.
    /// Registers and saves an OpenID Connect (OIDC) configuration for a Wickr network, enabling
    /// Single Sign-On (SSO) authentication through an identity provider.
    /// </summary>
    public partial class RegisterOidcConfigRequest : AmazonWickrRequest
    {
        private string _companyId;
        private string _customUsername;
        private string _extraAuthParams;
        private string _issuer;
        private string _networkId;
        private string _scopes;
        private string _secret;
        private int? _ssoTokenBufferMinutes;
        private string _userId;

        /// <summary>
        /// Gets and sets the property CompanyId. 
        /// <para>
        /// Custom identifier your end users will use to sign in with SSO.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string CompanyId
        {
            get { return this._companyId; }
            set { this._companyId = value; }
        }

        // Check to see if CompanyId property is set
        internal bool IsSetCompanyId()
        {
            return this._companyId != null;
        }

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
        public string CustomUsername
        {
            get { return this._customUsername; }
            set { this._customUsername = value; }
        }

        // Check to see if CustomUsername property is set
        internal bool IsSetCustomUsername()
        {
            return this._customUsername != null;
        }

        /// <summary>
        /// Gets and sets the property ExtraAuthParams. 
        /// <para>
        /// Additional authentication parameters to include in the OIDC flow (optional).
        /// </para>
        /// </summary>
        public string ExtraAuthParams
        {
            get { return this._extraAuthParams; }
            set { this._extraAuthParams = value; }
        }

        // Check to see if ExtraAuthParams property is set
        internal bool IsSetExtraAuthParams()
        {
            return this._extraAuthParams != null;
        }

        /// <summary>
        /// Gets and sets the property Issuer. 
        /// <para>
        /// The issuer URL of the OIDC provider (e.g., 'https://login.example.com').
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
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
        /// Gets and sets the property NetworkId. 
        /// <para>
        /// The ID of the Wickr network for which OIDC will be configured.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=8, Max=8)]
        public string NetworkId
        {
            get { return this._networkId; }
            set { this._networkId = value; }
        }

        // Check to see if NetworkId property is set
        internal bool IsSetNetworkId()
        {
            return this._networkId != null;
        }

        /// <summary>
        /// Gets and sets the property Scopes. 
        /// <para>
        /// The OAuth scopes to request from the OIDC provider (e.g., 'openid profile email').
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string Scopes
        {
            get { return this._scopes; }
            set { this._scopes = value; }
        }

        // Check to see if Scopes property is set
        internal bool IsSetScopes()
        {
            return this._scopes != null;
        }

        /// <summary>
        /// Gets and sets the property Secret. 
        /// <para>
        /// The client secret for authenticating with the OIDC provider (optional).
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive=true)]
        public string Secret
        {
            get { return this._secret; }
            set { this._secret = value; }
        }

        // Check to see if Secret property is set
        internal bool IsSetSecret()
        {
            return this._secret != null;
        }

        /// <summary>
        /// Gets and sets the property SsoTokenBufferMinutes. 
        /// <para>
        /// The buffer time in minutes before the SSO token expires to refresh it (optional).
        /// </para>
        /// </summary>
        public int SsoTokenBufferMinutes
        {
            get { return this._ssoTokenBufferMinutes.GetValueOrDefault(); }
            set { this._ssoTokenBufferMinutes = value; }
        }

        // Check to see if SsoTokenBufferMinutes property is set
        internal bool IsSetSsoTokenBufferMinutes()
        {
            return this._ssoTokenBufferMinutes.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property UserId. 
        /// <para>
        /// Unique identifier provided by your identity provider to authenticate the access request.
        /// Also referred to as clientID.
        /// </para>
        /// </summary>
        public string UserId
        {
            get { return this._userId; }
            set { this._userId = value; }
        }

        // Check to see if UserId property is set
        internal bool IsSetUserId()
        {
            return this._userId != null;
        }

    }
}