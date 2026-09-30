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
    /// This is the response object from the RegisterOidcConfigTest operation.
    /// </summary>
    public partial class RegisterOidcConfigTestResponse : AmazonWebServiceResponse
    {
        /// <summary>
        /// Gets and sets the property AuthorizationEndpoint. 
        /// <para>
        /// The authorization endpoint URL discovered from the OIDC provider.
        /// </para>
        /// </summary>
        public string AuthorizationEndpoint { get; set; }

        /// <summary>
        /// Checks to see if the AuthorizationEndpoint property is set.
        /// </summary>
        internal bool IsSetAuthorizationEndpoint() => this.AuthorizationEndpoint != null;

        /// <summary>
        /// Gets and sets the property EndSessionEndpoint. 
        /// <para>
        /// The end session endpoint URL for logging out users from the OIDC provider.
        /// </para>
        /// </summary>
        public string EndSessionEndpoint { get; set; }

        /// <summary>
        /// Checks to see if the EndSessionEndpoint property is set.
        /// </summary>
        internal bool IsSetEndSessionEndpoint() => this.EndSessionEndpoint != null;

        /// <summary>
        /// Gets and sets the property GrantTypesSupported. 
        /// <para>
        /// The OAuth grant types supported by the OIDC provider.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> GrantTypesSupported { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the GrantTypesSupported property is set.
        /// </summary>
        internal bool IsSetGrantTypesSupported() => this.GrantTypesSupported != null && (this.GrantTypesSupported.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property Issuer. 
        /// <para>
        /// The issuer URL confirmed by the OIDC provider.
        /// </para>
        /// </summary>
        public string Issuer { get; set; }

        /// <summary>
        /// Checks to see if the Issuer property is set.
        /// </summary>
        internal bool IsSetIssuer() => this.Issuer != null;

        /// <summary>
        /// Gets and sets the property LogoutEndpoint. 
        /// <para>
        /// The logout endpoint URL for terminating user sessions.
        /// </para>
        /// </summary>
        public string LogoutEndpoint { get; set; }

        /// <summary>
        /// Checks to see if the LogoutEndpoint property is set.
        /// </summary>
        internal bool IsSetLogoutEndpoint() => this.LogoutEndpoint != null;

        /// <summary>
        /// Gets and sets the property MicrosoftMultiRefreshToken. 
        /// <para>
        /// Indicates whether the provider supports Microsoft multi-refresh tokens.
        /// </para>
        /// </summary>
        public bool? MicrosoftMultiRefreshToken { get; set; }

        /// <summary>
        /// Checks to see if the MicrosoftMultiRefreshToken property is set.
        /// </summary>
        internal bool IsSetMicrosoftMultiRefreshToken() => this.MicrosoftMultiRefreshToken.HasValue;

        /// <summary>
        /// Gets and sets the property ResponseTypesSupported. 
        /// <para>
        /// The OAuth response types supported by the OIDC provider.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> ResponseTypesSupported { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the ResponseTypesSupported property is set.
        /// </summary>
        internal bool IsSetResponseTypesSupported() => this.ResponseTypesSupported != null && (this.ResponseTypesSupported.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property RevocationEndpoint. 
        /// <para>
        /// The token revocation endpoint URL for invalidating tokens.
        /// </para>
        /// </summary>
        public string RevocationEndpoint { get; set; }

        /// <summary>
        /// Checks to see if the RevocationEndpoint property is set.
        /// </summary>
        internal bool IsSetRevocationEndpoint() => this.RevocationEndpoint != null;

        /// <summary>
        /// Gets and sets the property ScopesSupported. 
        /// <para>
        /// The OAuth scopes supported by the OIDC provider.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> ScopesSupported { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the ScopesSupported property is set.
        /// </summary>
        internal bool IsSetScopesSupported() => this.ScopesSupported != null && (this.ScopesSupported.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property TokenEndpoint. 
        /// <para>
        /// The token endpoint URL discovered from the OIDC provider.
        /// </para>
        /// </summary>
        public string TokenEndpoint { get; set; }

        /// <summary>
        /// Checks to see if the TokenEndpoint property is set.
        /// </summary>
        internal bool IsSetTokenEndpoint() => this.TokenEndpoint != null;

        /// <summary>
        /// Gets and sets the property TokenEndpointAuthMethodsSupported. 
        /// <para>
        /// The authentication methods supported by the token endpoint.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> TokenEndpointAuthMethodsSupported { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the TokenEndpointAuthMethodsSupported property is set.
        /// </summary>
        internal bool IsSetTokenEndpointAuthMethodsSupported() => this.TokenEndpointAuthMethodsSupported != null && (this.TokenEndpointAuthMethodsSupported.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property UserinfoEndpoint. 
        /// <para>
        /// The user info endpoint URL discovered from the OIDC provider.
        /// </para>
        /// </summary>
        public string UserinfoEndpoint { get; set; }

        /// <summary>
        /// Checks to see if the UserinfoEndpoint property is set.
        /// </summary>
        internal bool IsSetUserinfoEndpoint() => this.UserinfoEndpoint != null;
    }
}
