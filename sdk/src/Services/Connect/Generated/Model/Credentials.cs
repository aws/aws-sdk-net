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
 * Do not modify this file. This file is generated from the connect-2017-08-08.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.Connect.Model
{
    /// <summary>
    /// Contains credentials to use for federation.
    /// </summary>
    public partial class Credentials
    {
        private string _accessToken;
        private DateTime? _accessTokenExpiration;
        private string _refreshToken;
        private DateTime? _refreshTokenExpiration;

        /// <summary>
        /// Gets and sets the property AccessToken. 
        /// <para>
        /// An access token generated for a federated user to access Amazon Connect.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive=true)]
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
        /// Gets and sets the property AccessTokenExpiration. 
        /// <para>
        /// A token generated with an expiration time for the session a user is logged in to Amazon
        /// Connect.
        /// </para>
        /// </summary>
        public DateTime AccessTokenExpiration
        {
            get { return this._accessTokenExpiration.GetValueOrDefault(); }
            set { this._accessTokenExpiration = value; }
        }

        // Check to see if AccessTokenExpiration property is set
        internal bool IsSetAccessTokenExpiration()
        {
            return this._accessTokenExpiration.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property RefreshToken. 
        /// <para>
        /// Renews a token generated for a user to access the Amazon Connect instance.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive=true)]
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

        /// <summary>
        /// Gets and sets the property RefreshTokenExpiration. 
        /// <para>
        /// Renews the expiration timer for a generated token.
        /// </para>
        /// </summary>
        public DateTime RefreshTokenExpiration
        {
            get { return this._refreshTokenExpiration.GetValueOrDefault(); }
            set { this._refreshTokenExpiration = value; }
        }

        // Check to see if RefreshTokenExpiration property is set
        internal bool IsSetRefreshTokenExpiration()
        {
            return this._refreshTokenExpiration.HasValue; 
        }

    }
}