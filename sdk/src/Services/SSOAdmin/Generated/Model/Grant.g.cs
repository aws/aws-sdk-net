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

namespace Amazon.SSOAdmin.Model
{
    /// <summary>
    /// The Grant union represents the set of possible configuration options for the selected
    /// grant type. Exactly one member of the union must be specified, and must match the
    /// grant type selected.
    /// </summary>
    public partial class Grant
    {
        /// <summary>
        /// Gets and sets the property AuthorizationCode. 
        /// <para>
        /// Configuration options for the <c>authorization_code</c> grant type.
        /// </para>
        /// </summary>
        public AuthorizationCodeGrant AuthorizationCode { get; set; }

        /// <summary>
        /// Checks to see if the AuthorizationCode property is set.
        /// </summary>
        internal bool IsSetAuthorizationCode() => this.AuthorizationCode != null;

        /// <summary>
        /// Gets and sets the property JwtBearer. 
        /// <para>
        /// Configuration options for the <c>urn:ietf:params:oauth:grant-type:jwt-bearer</c> grant
        /// type.
        /// </para>
        /// </summary>
        public JwtBearerGrant JwtBearer { get; set; }

        /// <summary>
        /// Checks to see if the JwtBearer property is set.
        /// </summary>
        internal bool IsSetJwtBearer() => this.JwtBearer != null;

        /// <summary>
        /// Gets and sets the property RefreshToken. 
        /// <para>
        /// Configuration options for the <c>refresh_token</c> grant type.
        /// </para>
        /// </summary>
        public RefreshTokenGrant RefreshToken { get; set; }

        /// <summary>
        /// Checks to see if the RefreshToken property is set.
        /// </summary>
        internal bool IsSetRefreshToken() => this.RefreshToken != null;

        /// <summary>
        /// Gets and sets the property TokenExchange. 
        /// <para>
        /// Configuration options for the <c>urn:ietf:params:oauth:grant-type:token-exchange</c>
        /// grant type.
        /// </para>
        /// </summary>
        public TokenExchangeGrant TokenExchange { get; set; }

        /// <summary>
        /// Checks to see if the TokenExchange property is set.
        /// </summary>
        internal bool IsSetTokenExchange() => this.TokenExchange != null;
    }
}
