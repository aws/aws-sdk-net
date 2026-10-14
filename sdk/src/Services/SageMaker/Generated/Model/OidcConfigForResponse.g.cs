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

namespace Amazon.SageMaker.Model
{
    /// <summary>
    /// Your OIDC IdP workforce configuration.
    /// </summary>
    public partial class OidcConfigForResponse
    {
        /// <summary>
        /// Gets and sets the property AuthenticationRequestExtraParams. 
        /// <para>
        /// A string to string map of identifiers specific to the custom identity provider (IdP)
        /// being used.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 0, Max = 10)]
        public Dictionary<string, string> AuthenticationRequestExtraParams { get; set; } = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;

        /// <summary>
        /// Checks to see if the AuthenticationRequestExtraParams property is set.
        /// </summary>
        internal bool IsSetAuthenticationRequestExtraParams() => this.AuthenticationRequestExtraParams != null && (this.AuthenticationRequestExtraParams.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property AuthorizationEndpoint. 
        /// <para>
        /// The OIDC IdP authorization endpoint used to configure your private workforce.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 500)]
        public string AuthorizationEndpoint { get; set; }

        /// <summary>
        /// Checks to see if the AuthorizationEndpoint property is set.
        /// </summary>
        internal bool IsSetAuthorizationEndpoint() => this.AuthorizationEndpoint != null;

        /// <summary>
        /// Gets and sets the property ClientId. 
        /// <para>
        /// The OIDC IdP client ID used to configure your private workforce.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 1024)]
        public string ClientId { get; set; }

        /// <summary>
        /// Checks to see if the ClientId property is set.
        /// </summary>
        internal bool IsSetClientId() => this.ClientId != null;

        /// <summary>
        /// Gets and sets the property Issuer. 
        /// <para>
        /// The OIDC IdP issuer used to configure your private workforce.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 500)]
        public string Issuer { get; set; }

        /// <summary>
        /// Checks to see if the Issuer property is set.
        /// </summary>
        internal bool IsSetIssuer() => this.Issuer != null;

        /// <summary>
        /// Gets and sets the property JwksUri. 
        /// <para>
        /// The OIDC IdP JSON Web Key Set (Jwks) URI used to configure your private workforce.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 500)]
        public string JwksUri { get; set; }

        /// <summary>
        /// Checks to see if the JwksUri property is set.
        /// </summary>
        internal bool IsSetJwksUri() => this.JwksUri != null;

        /// <summary>
        /// Gets and sets the property LogoutEndpoint. 
        /// <para>
        /// The OIDC IdP logout endpoint used to configure your private workforce.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 500)]
        public string LogoutEndpoint { get; set; }

        /// <summary>
        /// Checks to see if the LogoutEndpoint property is set.
        /// </summary>
        internal bool IsSetLogoutEndpoint() => this.LogoutEndpoint != null;

        /// <summary>
        /// Gets and sets the property Scope. 
        /// <para>
        /// An array of string identifiers used to refer to the specific pieces of user data or
        /// claims that the client application wants to access.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 1024)]
        public string Scope { get; set; }

        /// <summary>
        /// Checks to see if the Scope property is set.
        /// </summary>
        internal bool IsSetScope() => this.Scope != null;

        /// <summary>
        /// Gets and sets the property TokenEndpoint. 
        /// <para>
        /// The OIDC IdP token endpoint used to configure your private workforce.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 500)]
        public string TokenEndpoint { get; set; }

        /// <summary>
        /// Checks to see if the TokenEndpoint property is set.
        /// </summary>
        internal bool IsSetTokenEndpoint() => this.TokenEndpoint != null;

        /// <summary>
        /// Gets and sets the property UserInfoEndpoint. 
        /// <para>
        /// The OIDC IdP user information endpoint used to configure your private workforce.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 500)]
        public string UserInfoEndpoint { get; set; }

        /// <summary>
        /// Checks to see if the UserInfoEndpoint property is set.
        /// </summary>
        internal bool IsSetUserInfoEndpoint() => this.UserInfoEndpoint != null;
    }
}
