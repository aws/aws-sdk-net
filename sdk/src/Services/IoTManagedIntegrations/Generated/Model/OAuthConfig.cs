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
 * Do not modify this file. This file is generated from the iot-managed-integrations-2025-03-03.normal.json service model.
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
        private string _authUrl;
        private string _oAuthCompleteRedirectUrl;
        private ProactiveRefreshTokenRenewal _proactiveRefreshTokenRenewal;
        private string _scope;
        private TokenEndpointAuthenticationScheme _tokenEndpointAuthenticationScheme;
        private string _tokenUrl;

        /// <summary>
        /// Gets and sets the property AuthUrl. 
        /// <para>
        /// The authorization URL for the OAuth service, where users are directed to authenticate
        /// and authorize access.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=1024)]
        public string AuthUrl
        {
            get { return this._authUrl; }
            set { this._authUrl = value; }
        }

        // Check to see if AuthUrl property is set
        internal bool IsSetAuthUrl()
        {
            return this._authUrl != null;
        }

        /// <summary>
        /// Gets and sets the property OAuthCompleteRedirectUrl. 
        /// <para>
        /// The URL where users are redirected after completing the OAuth authorization process.
        /// </para>
        /// </summary>
        public string OAuthCompleteRedirectUrl
        {
            get { return this._oAuthCompleteRedirectUrl; }
            set { this._oAuthCompleteRedirectUrl = value; }
        }

        // Check to see if OAuthCompleteRedirectUrl property is set
        internal bool IsSetOAuthCompleteRedirectUrl()
        {
            return this._oAuthCompleteRedirectUrl != null;
        }

        /// <summary>
        /// Gets and sets the property ProactiveRefreshTokenRenewal. 
        /// <para>
        /// Configuration for proactively refreshing OAuth tokens before they expire.
        /// </para>
        /// </summary>
        public ProactiveRefreshTokenRenewal ProactiveRefreshTokenRenewal
        {
            get { return this._proactiveRefreshTokenRenewal; }
            set { this._proactiveRefreshTokenRenewal = value; }
        }

        // Check to see if ProactiveRefreshTokenRenewal property is set
        internal bool IsSetProactiveRefreshTokenRenewal()
        {
            return this._proactiveRefreshTokenRenewal != null;
        }

        /// <summary>
        /// Gets and sets the property Scope. 
        /// <para>
        /// The OAuth scopes requested during authorization, which define the permissions granted
        /// to the application.
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
        /// Gets and sets the property TokenEndpointAuthenticationScheme. 
        /// <para>
        /// The authentication scheme used when requesting tokens from the token endpoint.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public TokenEndpointAuthenticationScheme TokenEndpointAuthenticationScheme
        {
            get { return this._tokenEndpointAuthenticationScheme; }
            set { this._tokenEndpointAuthenticationScheme = value; }
        }

        // Check to see if TokenEndpointAuthenticationScheme property is set
        internal bool IsSetTokenEndpointAuthenticationScheme()
        {
            return this._tokenEndpointAuthenticationScheme != null;
        }

        /// <summary>
        /// Gets and sets the property TokenUrl. 
        /// <para>
        /// The token URL for the OAuth service, where authorization codes are exchanged for access
        /// tokens.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=1024)]
        public string TokenUrl
        {
            get { return this._tokenUrl; }
            set { this._tokenUrl = value; }
        }

        // Check to see if TokenUrl property is set
        internal bool IsSetTokenUrl()
        {
            return this._tokenUrl != null;
        }

    }
}