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

namespace Amazon.EC2.Model
{
    /// <summary>
    /// Describes the OpenID Connect (OIDC) options.
    /// </summary>
    public partial class NativeApplicationOidcOptions
    {
        /// <summary>
        /// Gets and sets the property AuthorizationEndpoint. 
        /// <para>
        /// The authorization endpoint of the IdP.
        /// </para>
        /// </summary>
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
        public string ClientId { get; set; }

        /// <summary>
        /// Checks to see if the ClientId property is set.
        /// </summary>
        internal bool IsSetClientId() => this.ClientId != null;

        /// <summary>
        /// Gets and sets the property Issuer. 
        /// <para>
        /// The OIDC issuer identifier of the IdP.
        /// </para>
        /// </summary>
        public string Issuer { get; set; }

        /// <summary>
        /// Checks to see if the Issuer property is set.
        /// </summary>
        internal bool IsSetIssuer() => this.Issuer != null;

        /// <summary>
        /// Gets and sets the property PublicSigningKeyEndpoint. 
        /// <para>
        /// The public signing key endpoint.
        /// </para>
        /// </summary>
        public string PublicSigningKeyEndpoint { get; set; }

        /// <summary>
        /// Checks to see if the PublicSigningKeyEndpoint property is set.
        /// </summary>
        internal bool IsSetPublicSigningKeyEndpoint() => this.PublicSigningKeyEndpoint != null;

        /// <summary>
        /// Gets and sets the property Scope. 
        /// <para>
        /// The set of user claims to be requested from the IdP.
        /// </para>
        /// </summary>
        public string Scope { get; set; }

        /// <summary>
        /// Checks to see if the Scope property is set.
        /// </summary>
        internal bool IsSetScope() => this.Scope != null;

        /// <summary>
        /// Gets and sets the property TokenEndpoint. 
        /// <para>
        /// The token endpoint of the IdP.
        /// </para>
        /// </summary>
        public string TokenEndpoint { get; set; }

        /// <summary>
        /// Checks to see if the TokenEndpoint property is set.
        /// </summary>
        internal bool IsSetTokenEndpoint() => this.TokenEndpoint != null;

        /// <summary>
        /// Gets and sets the property UserInfoEndpoint. 
        /// <para>
        /// The user info endpoint of the IdP.
        /// </para>
        /// </summary>
        public string UserInfoEndpoint { get; set; }

        /// <summary>
        /// Checks to see if the UserInfoEndpoint property is set.
        /// </summary>
        internal bool IsSetUserInfoEndpoint() => this.UserInfoEndpoint != null;
    }
}
