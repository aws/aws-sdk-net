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
 * Do not modify this file. This file is generated from the sso-oidc-2019-06-10.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.SSOOIDC.Model
{
    /// <summary>
    /// This is the response object from the CreateToken operation.
    /// </summary>
    public partial class CreateTokenResponse : AmazonWebServiceResponse
    {
        private string _accessToken;
        private int? _expiresIn;
        private string _idToken;
        private string _refreshToken;
        private string _tokenType;

        /// <summary>
        /// Gets and sets the property AccessToken. 
        /// <para>
        /// An opaque token to access IAM Identity Center resources assigned to a user.
        /// </para>
        /// </summary>
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
        /// Gets and sets the property ExpiresIn. 
        /// <para>
        /// Indicates the time in seconds when an access token will expire.
        /// </para>
        /// </summary>
        public int ExpiresIn
        {
            get { return this._expiresIn.GetValueOrDefault(); }
            set { this._expiresIn = value; }
        }

        // Check to see if ExpiresIn property is set
        internal bool IsSetExpiresIn()
        {
            return this._expiresIn.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property IdToken. 
        /// <para>
        /// Currently, <code>idToken</code> is not yet implemented and is not supported. For more
        /// information about the features and limitations of the current IAM Identity Center
        /// OIDC implementation, see <i>Considerations for Using this Guide</i> in the <a href="https://docs.aws.amazon.com/singlesignon/latest/OIDCAPIReference/Welcome.html">IAM
        /// Identity Center OIDC API Reference</a>.
        /// </para>
        ///  
        /// <para>
        /// The identifier of the user that associated with the access token, if present.
        /// </para>
        /// </summary>
        public string IdToken
        {
            get { return this._idToken; }
            set { this._idToken = value; }
        }

        // Check to see if IdToken property is set
        internal bool IsSetIdToken()
        {
            return this._idToken != null;
        }

        /// <summary>
        /// Gets and sets the property RefreshToken. 
        /// <para>
        /// Currently, <code>refreshToken</code> is not yet implemented and is not supported.
        /// For more information about the features and limitations of the current IAM Identity
        /// Center OIDC implementation, see <i>Considerations for Using this Guide</i> in the
        /// <a href="https://docs.aws.amazon.com/singlesignon/latest/OIDCAPIReference/Welcome.html">IAM
        /// Identity Center OIDC API Reference</a>.
        /// </para>
        ///  
        /// <para>
        /// A token that, if present, can be used to refresh a previously issued access token
        /// that might have expired.
        /// </para>
        /// </summary>
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
        /// Gets and sets the property TokenType. 
        /// <para>
        /// Used to notify the client that the returned token is an access token. The supported
        /// type is <code>BearerToken</code>.
        /// </para>
        /// </summary>
        public string TokenType
        {
            get { return this._tokenType; }
            set { this._tokenType = value; }
        }

        // Check to see if TokenType property is set
        internal bool IsSetTokenType()
        {
            return this._tokenType != null;
        }

    }
}