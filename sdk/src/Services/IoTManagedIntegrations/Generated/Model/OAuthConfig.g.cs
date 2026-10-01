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

namespace Amazon.IoTManagedIntegrations.Model
{
    /// <summary>
    /// Configuration details for OAuth authentication with a third-party service.
    /// </summary>
    public partial class OAuthConfig
    {
        /// <summary>
        /// Gets and sets the property AuthUrl. 
        /// <para>
        /// The authorization URL for the OAuth service, where users are directed to authenticate
        /// and authorize access.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 1024)]
        public string AuthUrl { get; set; }

        /// <summary>
        /// Checks to see if the AuthUrl property is set.
        /// </summary>
        internal bool IsSetAuthUrl() => this.AuthUrl != null;

        /// <summary>
        /// Gets and sets the property OAuthCompleteRedirectUrl. 
        /// <para>
        /// The URL where users are redirected after completing the OAuth authorization process.
        /// </para>
        /// </summary>
        public string OAuthCompleteRedirectUrl { get; set; }

        /// <summary>
        /// Checks to see if the OAuthCompleteRedirectUrl property is set.
        /// </summary>
        internal bool IsSetOAuthCompleteRedirectUrl() => this.OAuthCompleteRedirectUrl != null;

        /// <summary>
        /// Gets and sets the property ProactiveRefreshTokenRenewal. 
        /// <para>
        /// Configuration for proactively refreshing OAuth tokens before they expire.
        /// </para>
        /// </summary>
        public ProactiveRefreshTokenRenewal ProactiveRefreshTokenRenewal { get; set; }

        /// <summary>
        /// Checks to see if the ProactiveRefreshTokenRenewal property is set.
        /// </summary>
        internal bool IsSetProactiveRefreshTokenRenewal() => this.ProactiveRefreshTokenRenewal != null;

        /// <summary>
        /// Gets and sets the property Scope. 
        /// <para>
        /// The OAuth scopes requested during authorization, which define the permissions granted
        /// to the application.
        /// </para>
        /// </summary>
        public string Scope { get; set; }

        /// <summary>
        /// Checks to see if the Scope property is set.
        /// </summary>
        internal bool IsSetScope() => this.Scope != null;

        /// <summary>
        /// Gets and sets the property TokenEndpointAuthenticationScheme. 
        /// <para>
        /// The authentication scheme used when requesting tokens from the token endpoint.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public TokenEndpointAuthenticationScheme TokenEndpointAuthenticationScheme { get; set; }

        /// <summary>
        /// Checks to see if the TokenEndpointAuthenticationScheme property is set.
        /// </summary>
        internal bool IsSetTokenEndpointAuthenticationScheme() => this.TokenEndpointAuthenticationScheme != null;

        /// <summary>
        /// Gets and sets the property TokenUrl. 
        /// <para>
        /// The token URL for the OAuth service, where authorization codes are exchanged for access
        /// tokens.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 1024)]
        public string TokenUrl { get; set; }

        /// <summary>
        /// Checks to see if the TokenUrl property is set.
        /// </summary>
        internal bool IsSetTokenUrl() => this.TokenUrl != null;
    }
}
