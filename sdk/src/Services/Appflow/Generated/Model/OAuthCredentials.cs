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
 * Do not modify this file. This file is generated from the appflow-2020-08-23.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.Appflow.Model
{
    /// <summary>
    /// The OAuth credentials required for OAuth type authentication.
    /// </summary>
    public partial class OAuthCredentials
    {
        private string _accessToken;
        private string _clientId;
        private string _clientSecret;
        private ConnectorOAuthRequest _oAuthRequest;
        private string _refreshToken;

        /// <summary>
        /// Gets and sets the property AccessToken. 
        /// <para>
        ///  The access token used to access protected SAPOData resources. 
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive=true, Max=4096)]
        public string AccessToken
        {
            get { return this._accessToken; }
            set { this._accessToken = value; }
        }

        // Check to see if AccessToken property is set
        internal bool IsSetAccessToken()
        {
            return this._accessToken != null;
        }

        /// <summary>
        /// Gets and sets the property ClientId. 
        /// <para>
        ///  The identifier for the desired client. 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Max=512)]
        public string ClientId
        {
            get { return this._clientId; }
            set { this._clientId = value; }
        }

        // Check to see if ClientId property is set
        internal bool IsSetClientId()
        {
            return this._clientId != null;
        }

        /// <summary>
        /// Gets and sets the property ClientSecret. 
        /// <para>
        ///  The client secret used by the OAuth client to authenticate to the authorization server.
        /// 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Sensitive=true, Max=512)]
        public string ClientSecret
        {
            get { return this._clientSecret; }
            set { this._clientSecret = value; }
        }

        // Check to see if ClientSecret property is set
        internal bool IsSetClientSecret()
        {
            return this._clientSecret != null;
        }

        /// <summary>
        /// Gets and sets the property OAuthRequest. 
        /// <para>
        ///  The OAuth requirement needed to request security tokens from the connector endpoint.
        /// 
        /// </para>
        /// </summary>
        public ConnectorOAuthRequest OAuthRequest
        {
            get { return this._oAuthRequest; }
            set { this._oAuthRequest = value; }
        }

        // Check to see if OAuthRequest property is set
        internal bool IsSetOAuthRequest()
        {
            return this._oAuthRequest != null;
        }

        /// <summary>
        /// Gets and sets the property RefreshToken. 
        /// <para>
        ///  The refresh token used to refresh expired access token. 
        /// </para>
        /// </summary>
        [AWSProperty(Max=2048)]
        public string RefreshToken
        {
            get { return this._refreshToken; }
            set { this._refreshToken = value; }
        }

        // Check to see if RefreshToken property is set
        internal bool IsSetRefreshToken()
        {
            return this._refreshToken != null;
        }

    }
}