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
    /// This is the response object from the RegisterOidcConfigTest operation.
    /// </summary>
    public partial class RegisterOidcConfigTestResponse : AmazonWebServiceResponse
    {
        private string _authorizationEndpoint;
        private string _endSessionEndpoint;
        private List<string> _grantTypesSupported = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private string _issuer;
        private string _logoutEndpoint;
        private bool? _microsoftMultiRefreshToken;
        private List<string> _responseTypesSupported = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private string _revocationEndpoint;
        private List<string> _scopesSupported = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private string _tokenEndpoint;
        private List<string> _tokenEndpointAuthMethodsSupported = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private string _userinfoEndpoint;

        /// <summary>
        /// Gets and sets the property AuthorizationEndpoint. 
        /// <para>
        /// The authorization endpoint URL discovered from the OIDC provider.
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
        /// Gets and sets the property EndSessionEndpoint. 
        /// <para>
        /// The end session endpoint URL for logging out users from the OIDC provider.
        /// </para>
        /// </summary>
        public string EndSessionEndpoint
        {
            get { return this._endSessionEndpoint; }
            set { this._endSessionEndpoint = value; }
        }

        // Check to see if EndSessionEndpoint property is set
        internal bool IsSetEndSessionEndpoint()
        {
            return this._endSessionEndpoint != null;
        }

        /// <summary>
        /// Gets and sets the property GrantTypesSupported. 
        /// <para>
        /// The OAuth grant types supported by the OIDC provider.
        /// </para>
        /// </summary>
        public List<string> GrantTypesSupported
        {
            get { return this._grantTypesSupported; }
            set { this._grantTypesSupported = value; }
        }

        // Check to see if GrantTypesSupported property is set
        internal bool IsSetGrantTypesSupported()
        {
            return this._grantTypesSupported != null && (this._grantTypesSupported.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property Issuer. 
        /// <para>
        /// The issuer URL confirmed by the OIDC provider.
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
        /// Gets and sets the property LogoutEndpoint. 
        /// <para>
        /// The logout endpoint URL for terminating user sessions.
        /// </para>
        /// </summary>
        public string LogoutEndpoint
        {
            get { return this._logoutEndpoint; }
            set { this._logoutEndpoint = value; }
        }

        // Check to see if LogoutEndpoint property is set
        internal bool IsSetLogoutEndpoint()
        {
            return this._logoutEndpoint != null;
        }

        /// <summary>
        /// Gets and sets the property MicrosoftMultiRefreshToken. 
        /// <para>
        /// Indicates whether the provider supports Microsoft multi-refresh tokens.
        /// </para>
        /// </summary>
        public bool MicrosoftMultiRefreshToken
        {
            get { return this._microsoftMultiRefreshToken.GetValueOrDefault(); }
            set { this._microsoftMultiRefreshToken = value; }
        }

        // Check to see if MicrosoftMultiRefreshToken property is set
        internal bool IsSetMicrosoftMultiRefreshToken()
        {
            return this._microsoftMultiRefreshToken.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property ResponseTypesSupported. 
        /// <para>
        /// The OAuth response types supported by the OIDC provider.
        /// </para>
        /// </summary>
        public List<string> ResponseTypesSupported
        {
            get { return this._responseTypesSupported; }
            set { this._responseTypesSupported = value; }
        }

        // Check to see if ResponseTypesSupported property is set
        internal bool IsSetResponseTypesSupported()
        {
            return this._responseTypesSupported != null && (this._responseTypesSupported.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property RevocationEndpoint. 
        /// <para>
        /// The token revocation endpoint URL for invalidating tokens.
        /// </para>
        /// </summary>
        public string RevocationEndpoint
        {
            get { return this._revocationEndpoint; }
            set { this._revocationEndpoint = value; }
        }

        // Check to see if RevocationEndpoint property is set
        internal bool IsSetRevocationEndpoint()
        {
            return this._revocationEndpoint != null;
        }

        /// <summary>
        /// Gets and sets the property ScopesSupported. 
        /// <para>
        /// The OAuth scopes supported by the OIDC provider.
        /// </para>
        /// </summary>
        public List<string> ScopesSupported
        {
            get { return this._scopesSupported; }
            set { this._scopesSupported = value; }
        }

        // Check to see if ScopesSupported property is set
        internal bool IsSetScopesSupported()
        {
            return this._scopesSupported != null && (this._scopesSupported.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property TokenEndpoint. 
        /// <para>
        /// The token endpoint URL discovered from the OIDC provider.
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
        /// Gets and sets the property TokenEndpointAuthMethodsSupported. 
        /// <para>
        /// The authentication methods supported by the token endpoint.
        /// </para>
        /// </summary>
        public List<string> TokenEndpointAuthMethodsSupported
        {
            get { return this._tokenEndpointAuthMethodsSupported; }
            set { this._tokenEndpointAuthMethodsSupported = value; }
        }

        // Check to see if TokenEndpointAuthMethodsSupported property is set
        internal bool IsSetTokenEndpointAuthMethodsSupported()
        {
            return this._tokenEndpointAuthMethodsSupported != null && (this._tokenEndpointAuthMethodsSupported.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property UserinfoEndpoint. 
        /// <para>
        /// The user info endpoint URL discovered from the OIDC provider.
        /// </para>
        /// </summary>
        public string UserinfoEndpoint
        {
            get { return this._userinfoEndpoint; }
            set { this._userinfoEndpoint = value; }
        }

        // Check to see if UserinfoEndpoint property is set
        internal bool IsSetUserinfoEndpoint()
        {
            return this._userinfoEndpoint != null;
        }

    }
}