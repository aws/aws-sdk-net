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
 * Do not modify this file. This file is generated from the sso-admin-2020-07-20.normal.json service model.
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
namespace Amazon.SSOAdmin.Model
{
    /// <summary>
    /// The Grant union represents the set of possible configuration options for the selected
    /// grant type. Exactly one member of the union must be specified, and must match the
    /// grant type selected.
    /// </summary>
    public partial class Grant
    {
        private AuthorizationCodeGrant _authorizationCode;
        private JwtBearerGrant _jwtBearer;
        private RefreshTokenGrant _refreshToken;
        private TokenExchangeGrant _tokenExchange;

        /// <summary>
        /// Gets and sets the property AuthorizationCode. 
        /// <para>
        /// Configuration options for the <c>authorization_code</c> grant type.
        /// </para>
        /// </summary>
        public AuthorizationCodeGrant AuthorizationCode
        {
            get { return this._authorizationCode; }
            set { this._authorizationCode = value; }
        }

        // Check to see if AuthorizationCode property is set
        internal bool IsSetAuthorizationCode()
        {
            return this._authorizationCode != null;
        }

        /// <summary>
        /// Gets and sets the property JwtBearer. 
        /// <para>
        /// Configuration options for the <c>urn:ietf:params:oauth:grant-type:jwt-bearer</c> grant
        /// type.
        /// </para>
        /// </summary>
        public JwtBearerGrant JwtBearer
        {
            get { return this._jwtBearer; }
            set { this._jwtBearer = value; }
        }

        // Check to see if JwtBearer property is set
        internal bool IsSetJwtBearer()
        {
            return this._jwtBearer != null;
        }

        /// <summary>
        /// Gets and sets the property RefreshToken. 
        /// <para>
        /// Configuration options for the <c>refresh_token</c> grant type.
        /// </para>
        /// </summary>
        public RefreshTokenGrant RefreshToken
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
        /// Gets and sets the property TokenExchange. 
        /// <para>
        /// Configuration options for the <c>urn:ietf:params:oauth:grant-type:token-exchange</c>
        /// grant type.
        /// </para>
        /// </summary>
        public TokenExchangeGrant TokenExchange
        {
            get { return this._tokenExchange; }
            set { this._tokenExchange = value; }
        }

        // Check to see if TokenExchange property is set
        internal bool IsSetTokenExchange()
        {
            return this._tokenExchange != null;
        }

    }
}